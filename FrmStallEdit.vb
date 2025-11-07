Imports System.Data.OleDb

Public Class FrmStallEdit
    Private _stallId As Integer? = Nothing

    Public Sub New()
        InitializeComponent()
    End Sub

    Public Sub New(stallId As Integer)
        InitializeComponent()
        _stallId = stallId
    End Sub

    Private Sub FrmStallEdit_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If _stallId.HasValue Then LoadStall()
    End Sub

    Private Sub LoadStall()
        Dim sql = "SELECT StallNo, Location, RentRate, Status FROM Stalls WHERE StallID = ?"
        Dim prms As New List(Of OleDbParameter) From {
            New OleDbParameter With {.Value = _stallId.Value}
        }
        Dim dt = modDB.GetTable(sql, prms)
        If dt.Rows.Count = 0 Then Return
        Dim r = dt.Rows(0)
        txtStallNo.Text = r("StallNo").ToString()
        txtLocation.Text = r("Location").ToString()
        numRentRate.Value = CDec(r("RentRate"))
        cboStatus.Text = r("Status").ToString()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If String.IsNullOrWhiteSpace(txtStallNo.Text) Then
            MessageBox.Show("Stall number required.")
            Return
        End If

        If _stallId.HasValue Then
            Dim sql = "UPDATE Stalls SET StallNo=?, Location=?, RentRate=?, Status=?, UpdatedAt=Now() WHERE StallID=?"
            Dim prms As New List(Of OleDbParameter) From {
                New OleDbParameter With {.Value = txtStallNo.Text.Trim()},
                New OleDbParameter With {.Value = txtLocation.Text.Trim()},
                New OleDbParameter With {.Value = numRentRate.Value},
                New OleDbParameter With {.Value = cboStatus.Text},
                New OleDbParameter With {.Value = _stallId.Value}
            }
            modDB.Exec(sql, prms)
        Else
            Dim sql = "INSERT INTO Stalls (StallNo, Location, RentRate, Status, CreatedAt, UpdatedAt) VALUES (?,?,?,?,?,?)"
            Dim prms As New List(Of OleDbParameter) From {
                New OleDbParameter With {.Value = txtStallNo.Text.Trim()},
                New OleDbParameter With {.Value = txtLocation.Text.Trim()},
                New OleDbParameter With {.Value = numRentRate.Value},
                New OleDbParameter With {.Value = cboStatus.Text},
                New OleDbParameter With {.Value = Now()},
                New OleDbParameter With {.Value = Now()}
            }
            modDB.Exec(sql, prms)
        End If

        Me.DialogResult = DialogResult.OK
        Me.Close()
    End Sub

    Private Sub txtLocation_TextChanged(sender As Object, e As EventArgs) Handles txtLocation.TextChanged

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.DialogResult = DialogResult.Cancel
        Me.Close()
    End Sub
End Class
