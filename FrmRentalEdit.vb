Imports System.Data.OleDb

Public Class FrmRentalEdit
    Private _rentalId As Integer? = Nothing

    Public Sub New()
        InitializeComponent()
    End Sub

    Public Sub New(rentalId As Integer)
        InitializeComponent()
        _rentalId = rentalId
    End Sub

    Private Sub FrmRentalEdit_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadVendors()
        LoadAvailableStalls()

        AddHandler btnCancel.Click, AddressOf btnCancel_Click
        If _rentalId.HasValue Then LoadRental()
    End Sub

    Private Sub LoadVendors()
        Dim dt = modDB.GetTable("SELECT VendorID, VendorName FROM Vendors ORDER BY VendorName", Nothing)
        cboVendor.DataSource = dt
        cboVendor.DisplayMember = "VendorName"
        cboVendor.ValueMember = "VendorID"
    End Sub

    Private Sub LoadAvailableStalls()
        Dim dt = modDB.GetTable("SELECT StallID, StallNo FROM Stalls WHERE Status='Available' OR Status='Reserved' ORDER BY StallNo", Nothing)
        cboStall.DataSource = dt
        cboStall.DisplayMember = "StallNo"
        cboStall.ValueMember = "StallID"
    End Sub

    Private Sub LoadRental()
        Dim sql = "SELECT VendorID, StallID, StartDate, EndDate, AmountPaid, ORNo FROM Rentals WHERE RentalID = ?"
        Dim prms As New List(Of OleDbParameter) From {
            New OleDbParameter With {.Value = _rentalId.Value}
        }
        Dim dt = modDB.GetTable(sql, prms)
        If dt.Rows.Count = 0 Then Return
        Dim r = dt.Rows(0)
        cboVendor.SelectedValue = CInt(r("VendorID"))
        cboStall.SelectedValue = CInt(r("StallID"))
        dtpStart.Value = CDate(r("StartDate"))
        If Not IsDBNull(r("EndDate")) Then dtpEnd.Value = CDate(r("EndDate"))
        numAmount.Value = CDec(r("AmountPaid"))
        txtORNo.Text = r("ORNo").ToString()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If cboVendor.SelectedValue Is Nothing Or cboStall.SelectedValue Is Nothing Then
            MessageBox.Show("Please select vendor and stall.")
            Return
        End If

        Dim vendorId = CInt(cboVendor.SelectedValue)
        Dim stallId = CInt(cboStall.SelectedValue)
        Dim startDate = dtpStart.Value.Date
        Dim endDate = If(chkAddPaymentNow.Checked, dtpEnd.Value.Date, CType(Nothing, Date?))
        Dim amount = numAmount.Value
        Dim orno = txtORNo.Text.Trim()

        Using cn As New OleDbConnection(modDB.CONN)
            cn.Open()
            Using tx = cn.BeginTransaction()
                Try
                    If _rentalId.HasValue Then
                        Dim sql = "UPDATE Rentals SET VendorID=?, StallID=?, StartDate=?, EndDate=?, AmountPaid=?, ORNo=?, UpdatedAt=Now() WHERE RentalID=?"
                        Using cmd As New OleDbCommand(sql, cn, tx)
                            cmd.Parameters.AddWithValue("@v", vendorId)
                            cmd.Parameters.AddWithValue("@s", stallId)
                            cmd.Parameters.AddWithValue("@sd", startDate)
                            cmd.Parameters.AddWithValue("@ed", If(endDate, DBNull.Value))
                            cmd.Parameters.AddWithValue("@amt", amount)
                            cmd.Parameters.AddWithValue("@or", orno)
                            cmd.Parameters.AddWithValue("@id", _rentalId.Value)
                            cmd.ExecuteNonQuery()
                        End Using
                    Else
                        Dim sql = "INSERT INTO Rentals (VendorID, StallID, StartDate, EndDate, AmountPaid, ORNo, CreatedAt, UpdatedAt) VALUES (?,?,?,?,?,?,Now(),Now())"
                        Using cmd As New OleDbCommand(sql, cn, tx)
                            cmd.Parameters.AddWithValue("@v", vendorId)
                            cmd.Parameters.AddWithValue("@s", stallId)
                            cmd.Parameters.AddWithValue("@sd", startDate)
                            cmd.Parameters.AddWithValue("@ed", If(endDate, DBNull.Value))
                            cmd.Parameters.AddWithValue("@amt", amount)
                            cmd.Parameters.AddWithValue("@or", orno)
                            cmd.ExecuteNonQuery()
                        End Using

                        Using cmd As New OleDbCommand("UPDATE Stalls SET Status='Occupied', UpdatedAt=Now() WHERE StallID=@id", cn, tx)
                            cmd.Parameters.AddWithValue("@id", stallId)
                            cmd.ExecuteNonQuery()
                        End Using
                    End If

                    tx.Commit()
                    MessageBox.Show("Saved.")
                    Me.DialogResult = DialogResult.OK
                    Me.Close()
                Catch ex As Exception
                    tx.Rollback()
                    MessageBox.Show("Error saving rental: " & ex.Message)
                End Try
            End Using
        End Using
    End Sub

    Private Sub dtpEnd_ValueChanged(sender As Object, e As EventArgs) Handles dtpEnd.ValueChanged

    End Sub


    Private Sub btnCancel_Click(sender As Object, e As EventArgs)

        For Each f As Form In Application.OpenForms
            If TypeOf f Is FrmRentalsList Then
                Dim list = DirectCast(f, FrmRentalsList)
                If list.WindowState = FormWindowState.Minimized Then list.WindowState = FormWindowState.Normal
                list.BringToFront()
                Me.DialogResult = DialogResult.Cancel
                Me.Close()
                Return
            End If
        Next


        Dim frm As New FrmRentalsList()
        frm.Show()
        Me.DialogResult = DialogResult.Cancel
        Me.Close()
    End Sub
End Class
