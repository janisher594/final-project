Imports System.Data.OleDb

Public Class FrmVendorEdit
    Private _vendorId As Integer? = Nothing

    Public Sub New()
        InitializeComponent()
    End Sub

    Public Sub New(vendorId As Integer)
        InitializeComponent()
        _vendorId = vendorId
    End Sub

    Private Sub FrmVendorEdit_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If Not _vendorId.HasValue AndAlso Me.Tag IsNot Nothing Then
            Dim tmp As Integer
            If Integer.TryParse(Me.Tag.ToString(), tmp) Then _vendorId = tmp
        End If

        If _vendorId.HasValue Then LoadVendor()
    End Sub

    Private Sub LoadVendor()

        Dim sql = "SELECT [VendorName], [ContactNo], [Address] FROM [Vendors] WHERE [VendorID] = ?"
        Dim prms As New List(Of OleDbParameter) From {
            New OleDbParameter With {.OleDbType = OleDbType.Integer, .Value = _vendorId.Value}
        }
        Dim dt = modDB.GetTable(sql, prms)
        If dt.Rows.Count = 0 Then Return
        Dim r = dt.Rows(0)
        txtName.Text = r("VendorName").ToString()
        txtContact.Text = r("ContactNo").ToString()
        txtAddress.Text = r("Address").ToString()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If String.IsNullOrWhiteSpace(txtName.Text) Then
            MessageBox.Show("Vendor name required.")
            Return
        End If

        Try
            Dim affected As Integer = 0

            If _vendorId.HasValue Then
                Dim sql = "UPDATE [Vendors] SET [VendorName]=?, [ContactNo]=?, [Address]=?, [UpdatedAt]=Now() WHERE [VendorID]=?"
                Dim prms As New List(Of OleDbParameter) From {
                    New OleDbParameter With {.OleDbType = OleDbType.VarWChar, .Value = txtName.Text.Trim()},
                    New OleDbParameter With {.OleDbType = OleDbType.VarWChar, .Value = txtContact.Text.Trim()},
                    New OleDbParameter With {.OleDbType = OleDbType.VarWChar, .Value = txtAddress.Text.Trim()},
                    New OleDbParameter With {.OleDbType = OleDbType.Integer, .Value = _vendorId.Value}
                }
                affected = modDB.Exec(sql, prms)
            Else
                Dim sql = "INSERT INTO [Vendors] ([VendorName], [ContactNo], [Address], [CreatedAt], [UpdatedAt]) VALUES (?,?,?,Now(),Now())"
                Dim prms As New List(Of OleDbParameter) From {
                    New OleDbParameter With {.OleDbType = OleDbType.VarWChar, .Value = txtName.Text.Trim()},
                    New OleDbParameter With {.OleDbType = OleDbType.VarWChar, .Value = txtContact.Text.Trim()},
                    New OleDbParameter With {.OleDbType = OleDbType.VarWChar, .Value = txtAddress.Text.Trim()}
                }
                affected = modDB.Exec(sql, prms)
            End If

            If affected > 0 Then
                MessageBox.Show("Saved.")
                Me.DialogResult = DialogResult.OK
                Me.Close()
            Else
                MessageBox.Show("No changes were saved. Please try again.")
            End If
        Catch ex As Exception
            MessageBox.Show("Error saving vendor: " & ex.Message)
        End Try
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.DialogResult = DialogResult.Cancel
        Me.Close()
    End Sub
End Class
