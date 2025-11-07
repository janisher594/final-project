Imports System.Data.OleDb
Imports System.Drawing.Printing
Imports System.Drawing

Public Class FrmVendorsList
    Private printDoc As PrintDocument
    Private printBmp As Bitmap

    Private Sub FrmVendorsList_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        printDoc = New PrintDocument()
        AddHandler printDoc.PrintPage, AddressOf OnPrintPage

        LoadVendors()
    End Sub

    Private Sub LoadVendors()
        Dim sql = "SELECT VendorID, VendorName, ContactNo, Address, CreatedAt FROM Vendors WHERE VendorName LIKE ? ORDER BY VendorName"
        Dim prms As New List(Of OleDbParameter) From {
            New OleDbParameter With {.Value = "%" & txtSearch.Text.Trim() & "%"}
        }
        dgvVendors.DataSource = modDB.GetTable(sql, prms)
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        LoadVendors()
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        LoadVendors()
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim f As New FrmVendorEdit()
        f.ShowDialog()
        LoadVendors()
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        If dgvVendors.CurrentRow Is Nothing Then Return
        Dim id = CInt(dgvVendors.CurrentRow.Cells("VendorID").Value)

        Dim f As New FrmVendorEdit()
        f.Tag = id
        f.ShowDialog()
        LoadVendors()
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If dgvVendors.CurrentRow Is Nothing Then Return
        If MessageBox.Show("Delete selected vendor?", "Confirm", MessageBoxButtons.YesNo) <> DialogResult.Yes Then Return
        Dim id = CInt(dgvVendors.CurrentRow.Cells("VendorID").Value)
        Dim sql = "DELETE FROM Vendors WHERE VendorID = ?"
        Dim prms As New List(Of OleDbParameter) From {
            New OleDbParameter With {.Value = id}
        }
        modDB.Exec(sql, prms)
        LoadVendors()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click

        Me.Close()
    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        If dgvVendors.Rows.Count = 0 Then
            MessageBox.Show("No data to print.", "Print", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If

        ng.
        Try
        printBmp?.Dispose()
            printBmp = New Bitmap(dgvVendors.Width, dgvVendors.Height)
            dgvVendors.DrawToBitmap(printBmp, New Rectangle(0, 0, dgvVendors.Width, dgvVendors.Height))

            Dim preview As New PrintPreviewDialog With {
                .Document = printDoc,
                .WindowState = FormWindowState.Maximized
            }
            preview.ShowDialog()
        Catch ex As Exception
            MessageBox.Show("Printing failed: " & ex.Message, "Print Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub OnPrintPage(sender As Object, e As PrintPageEventArgs)
        If printBmp Is Nothing Then
            e.HasMorePages = False
            Return
        End If


        Dim img = printBmp
        Dim bounds = e.MarginBounds
        Dim scaleX = bounds.Width / CSng(img.Width)
        Dim scaleY = bounds.Height / CSng(img.Height)
        Dim scale = Math.Min(scaleX, scaleY)
        Dim destWidth = CInt(img.Width * scale)
        Dim destHeight = CInt(img.Height * scale)
        Dim destRect = New Rectangle(bounds.Left, bounds.Top, destWidth, destHeight)

        e.Graphics.DrawImage(img, destRect)
        e.HasMorePages = False
    End Sub
End Class
