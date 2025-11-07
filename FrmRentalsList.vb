Imports System.Data.OleDb
Imports System.Drawing
Imports System.Drawing.Printing
Imports System.Linq

Public Class FrmRentalsList
    Private pd As PrintDocument
    Private printRowIndex As Integer
    Private colPrintWidths() As Single
    Private headerFont As Font
    Private cellFont As Font
    Private printColumns As List(Of DataGridViewColumn)

    Private Sub FrmRentalsList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadRentals()

        pd = New PrintDocument()
        AddHandler pd.BeginPrint, AddressOf PrintDocument_BeginPrint
        AddHandler pd.PrintPage, AddressOf PrintDocument_PrintPage
        headerFont = New Font("Segoe UI", 9, FontStyle.Bold)
        cellFont = New Font("Segoe UI", 9, FontStyle.Regular)

        ' Wire a regular Button named "btnPrint" (if exists)
        Dim btns = Me.Controls.Find("btnPrint", True)
        If btns.Length > 0 Then
            Dim btn = TryCast(btns(0), Button)
            If btn IsNot Nothing Then AddHandler btn.Click, AddressOf btnPrint_Click
        End If

        ' Also wire a ToolStripItem named "btnPrint" (ToolStripButton etc.)
        For Each ts As ToolStrip In Me.Controls.OfType(Of ToolStrip)()
            For Each item As ToolStripItem In ts.Items
                If String.Equals(item.Name, "btnPrint", StringComparison.OrdinalIgnoreCase) Then
                    AddHandler item.Click, AddressOf btnPrint_Click
                End If
            Next
        Next
    End Sub

    Private Sub LoadRentals()
        Dim where As New List(Of String)
        Dim prms As New List(Of OleDbParameter)


        Dim sql As String =
            "SELECT r.RentalID, v.VendorName, s.StallNo, r.StartDate, r.EndDate, r.AmountPaid, r.ORNo " &
            "FROM (Rentals r INNER JOIN Vendors v ON r.VendorID = v.VendorID) " &
            "INNER JOIN Stalls s ON r.StallID = s.StallID"

        If Not String.IsNullOrWhiteSpace(txtTenantSearch.Text) Then
            where.Add("v.VendorName LIKE ?")
            prms.Add(New OleDbParameter With {.Value = "%" & txtTenantSearch.Text.Trim() & "%"})
        End If
        If Not String.IsNullOrWhiteSpace(txtStallSearch.Text) Then
            where.Add("s.StallNo = ?")
            prms.Add(New OleDbParameter With {.Value = txtStallSearch.Text.Trim()})
        End If
        If chkDateRange.Checked Then
            where.Add("r.StartDate BETWEEN ? AND ?")
            prms.Add(New OleDbParameter With {.Value = dtpFrom.Value.Date})
            prms.Add(New OleDbParameter With {.Value = dtpTo.Value.Date})
        End If
        If where.Count > 0 Then sql &= " WHERE " & String.Join(" AND ", where)

        Dim sortCol As String = "r.StartDate"
        If cboSort.SelectedItem IsNot Nothing Then
            Select Case cboSort.SelectedItem.ToString()
                Case "StartDate" : sortCol = "r.StartDate"
                Case "Vendor" : sortCol = "v.VendorName"
                Case "Stall" : sortCol = "s.StallNo"
            End Select
        End If
        sql &= " ORDER BY " & sortCol

        dgvRentals.DataSource = modDB.GetTable(sql, prms)
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        LoadRentals()
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim f As New FrmRentalEdit()
        f.ShowDialog()
        LoadRentals()
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        If dgvRentals.CurrentRow Is Nothing Then Return
        Dim id = CInt(dgvRentals.CurrentRow.Cells("RentalID").Value)

        Dim f As New FrmRentalEdit()
        f.Tag = id
        f.ShowDialog()
        LoadRentals()
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If dgvRentals.CurrentRow Is Nothing Then Return
        If MessageBox.Show("Delete selected rental?", "Confirm", MessageBoxButtons.YesNo) <> DialogResult.Yes Then Return
        Dim id = CInt(dgvRentals.CurrentRow.Cells("RentalID").Value)
        Dim sql = "DELETE FROM Rentals WHERE RentalID = ?"
        Dim prms As New List(Of OleDbParameter) From {
            New OleDbParameter With {.Value = id}
        }
        modDB.Exec(sql, prms)
        LoadRentals()
    End Sub

    Private Sub dtpTo_ValueChanged(sender As Object, e As EventArgs) Handles dtpTo.ValueChanged

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    ' Print button handler (works for Button and ToolStripItem)
    Private Sub btnPrint_Click(sender As Object, e As EventArgs)
        Try
            If dgvRentals.DataSource Is Nothing OrElse dgvRentals.Rows.Count = 0 Then
                MessageBox.Show("Nothing to print.")
                Return
            End If

            ' Build list of visible columns (in display order)
            printColumns = dgvRentals.Columns.Cast(Of DataGridViewColumn)().Where(Function(c) c.Visible).OrderBy(Function(c) c.DisplayIndex).ToList()
            If printColumns.Count = 0 Then
                MessageBox.Show("No visible columns to print.")
                Return
            End If

            printRowIndex = 0

            Using pp As New PrintPreviewDialog()
                pp.Document = pd
                pp.Width = 800
                pp.Height = 600
                pp.ShowDialog(Me)
            End Using
        Catch ex As Exception
            MessageBox.Show("Print action failed: " & ex.Message)
        End Try
    End Sub

    Private Sub PrintDocument_BeginPrint(sender As Object, e As PrintEventArgs)
        printRowIndex = 0
        colPrintWidths = Nothing
        ' Ensure printColumns is populated (in case Print invoked directly)
        printColumns = dgvRentals.Columns.Cast(Of DataGridViewColumn)().Where(Function(c) c.Visible).OrderBy(Function(c) c.DisplayIndex).ToList()
    End Sub

    Private Sub PrintDocument_PrintPage(sender As Object, e As PrintPageEventArgs)
        Dim g = e.Graphics
        Dim marginLeft = e.MarginBounds.Left
        Dim marginTop = e.MarginBounds.Top
        Dim printableWidth = e.MarginBounds.Width
        Dim printableHeight = e.MarginBounds.Height

        Dim cols = If(printColumns, dgvRentals.Columns.Cast(Of DataGridViewColumn)().Where(Function(c) c.Visible).OrderBy(Function(c) c.DisplayIndex).ToList())

        If cols.Count = 0 Then
            e.HasMorePages = False
            Return
        End If

        ' Calculate scaled widths
        If colPrintWidths Is Nothing OrElse colPrintWidths.Length <> cols.Count Then
            Dim totalGridWidth As Integer = cols.Sum(Function(c) c.Width)
            If totalGridWidth = 0 Then totalGridWidth = cols.Count * 100
            ReDim colPrintWidths(cols.Count - 1)
            For i As Integer = 0 To cols.Count - 1
                colPrintWidths(i) = cols(i).Width / CSng(totalGridWidth) * printableWidth
            Next
        End If

        Dim x = marginLeft
        Dim y = marginTop
        Dim rowHeight As Single = Math.Max(headerFont.GetHeight(g), cellFont.GetHeight(g)) + 6

        ' Draw headers
        For i As Integer = 0 To cols.Count - 1
            Dim headerRect = New RectangleF(x, y, colPrintWidths(i), rowHeight)
            g.FillRectangle(Brushes.LightGray, headerRect)
            g.DrawRectangle(Pens.Black, headerRect.X, headerRect.Y, headerRect.Width, headerRect.Height)
            g.DrawString(cols(i).HeaderText, headerFont, Brushes.Black, New RectangleF(headerRect.X + 2, headerRect.Y + 2, headerRect.Width - 4, headerRect.Height - 4))
            x += colPrintWidths(i)
        Next
        y += rowHeight

        ' Draw rows
        While printRowIndex < dgvRentals.Rows.Count
            x = marginLeft
            Dim row = dgvRentals.Rows(printRowIndex)
            If row.IsNewRow Then
                printRowIndex += 1
                Continue While
            End If

            If y + rowHeight > marginTop + printableHeight Then
                e.HasMorePages = True
                Return
            End If

            For i As Integer = 0 To cols.Count - 1
                Dim cellRect = New RectangleF(x, y, colPrintWidths(i), rowHeight)
                g.DrawRectangle(Pens.Black, cellRect.X, cellRect.Y, cellRect.Width, cellRect.Height)
                Dim cellValue = row.Cells(cols(i).Index).Value
                Dim text As String = If(cellValue Is Nothing OrElse IsDBNull(cellValue), String.Empty, cellValue.ToString())
                g.DrawString(text, cellFont, Brushes.Black, New RectangleF(cellRect.X + 2, cellRect.Y + 2, cellRect.Width - 4, cellRect.Height - 4))
                x += colPrintWidths(i)
            Next

            y += rowHeight
            printRowIndex += 1
        End While

        e.HasMorePages = False
        printRowIndex = 0
        colPrintWidths = Nothing
    End Sub
End Class
