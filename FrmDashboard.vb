Imports System.Windows.Forms

Public Class FrmDashboard
    Private Sub FrmDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.Text = "Market Rental Dashboard"
        AppDomain.CurrentDomain.SetData("DataDirectory", Application.StartupPath)
    End Sub

    Private Sub btnVendors_Click(sender As Object, e As EventArgs) Handles btnVendors.Click
        Dim f As New FrmVendorsList()
        f.ShowDialog()
    End Sub

    Private Sub btnStalls_Click(sender As Object, e As EventArgs) Handles btnStalls.Click
        Dim f As New FrmStallsList()
        f.ShowDialog()
    End Sub

    Private Sub btnRentals_Click(sender As Object, e As EventArgs) Handles btnRentals.Click
        Dim f As New FrmRentalsList()
        f.ShowDialog()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        If MessageBox.Show("Are you sure you want to exit?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Application.Exit()
        End If
    End Sub

    Private Sub lblTitle_Click(sender As Object, e As EventArgs) Handles lblTitle.Click

    End Sub
End Class
