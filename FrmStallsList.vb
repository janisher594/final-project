Imports System.Data.OleDb
Imports System.Reflection

Public Class FrmStallsList
    Private Sub FrmStallsList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadStalls()
    End Sub

    Private Sub LoadStalls()
        Dim sql = "SELECT StallID, StallNo, Location, RentRate, Status FROM Stalls WHERE StallNo LIKE ? ORDER BY StallNo"
        Dim prms As New List(Of OleDbParameter) From {
                New OleDbParameter With {.Value = "%" & txtSearch.Text.Trim() & "%"}
            }
        dgvStalls.DataSource = modDB.GetTable(sql, prms)
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        LoadStalls()
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim f As New FrmStallEdit()
        Dim res = f.ShowDialog()

        If res = DialogResult.Cancel Then
            Me.DialogResult = DialogResult.Cancel
            Me.Close()
            Return
        End If
        LoadStalls()
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        If dgvStalls.CurrentRow Is Nothing Then Return

        Dim id = CInt(dgvStalls.CurrentRow.Cells("StallID").Value)
        Dim f As New FrmStallEdit()


        Dim t As Type = f.GetType()
        Dim prop As PropertyInfo = t.GetProperty("StallID")
        If prop Is Nothing Then prop = t.GetProperty("StallId")
        If prop Is Nothing Then prop = t.GetProperty("Id")

        If prop IsNot Nothing AndAlso prop.CanWrite Then
            prop.SetValue(f, id, Nothing)
        Else

            Dim m As MethodInfo = t.GetMethod("SetStall", New Type() {GetType(Integer)})
            If m Is Nothing Then m = t.GetMethod("LoadStall", New Type() {GetType(Integer)})
            If m Is Nothing Then m = t.GetMethod("Load", New Type() {GetType(Integer)})
            If m IsNot Nothing Then
                m.Invoke(f, New Object() {id})
            End If
        End If

        Dim res = f.ShowDialog()
        If res = DialogResult.Cancel Then
            Me.DialogResult = DialogResult.Cancel
            Me.Close()
            Return
        End If

        LoadStalls()
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If dgvStalls.CurrentRow Is Nothing Then Return
        If MessageBox.Show("Delete selected stall?", "Confirm", MessageBoxButtons.YesNo) <> DialogResult.Yes Then Return

        Dim id = CInt(dgvStalls.CurrentRow.Cells("StallID").Value)
        Dim sql = "DELETE FROM Stalls WHERE StallID = ?"
        Dim prms As New List(Of OleDbParameter) From {
                New OleDbParameter With {.Value = id}
            }
        modDB.Exec(sql, prms)
        LoadStalls()
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged

        LoadStalls()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click

        Me.Close()
    End Sub
End Class
