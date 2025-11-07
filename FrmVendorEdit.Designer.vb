<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmVendorEdit
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        txtName = New TextBox()
        txtContact = New TextBox()
        txtAddress = New TextBox()
        btnSave = New Button()
        btnCancel = New Button()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        SuspendLayout()
        ' 
        ' txtName
        ' 
        txtName.Location = New Point(221, 128)
        txtName.Name = "txtName"
        txtName.Size = New Size(364, 23)
        txtName.TabIndex = 0
        ' 
        ' txtContact
        ' 
        txtContact.Location = New Point(221, 169)
        txtContact.Name = "txtContact"
        txtContact.Size = New Size(364, 23)
        txtContact.TabIndex = 1
        ' 
        ' txtAddress
        ' 
        txtAddress.Location = New Point(221, 210)
        txtAddress.Name = "txtAddress"
        txtAddress.Size = New Size(364, 23)
        txtAddress.TabIndex = 2
        ' 
        ' btnSave
        ' 
        btnSave.BackColor = SystemColors.Info
        btnSave.Location = New Point(384, 261)
        btnSave.Name = "btnSave"
        btnSave.Size = New Size(85, 37)
        btnSave.TabIndex = 3
        btnSave.Text = "Save"
        btnSave.UseVisualStyleBackColor = False
        ' 
        ' btnCancel
        ' 
        btnCancel.BackColor = SystemColors.ScrollBar
        btnCancel.Location = New Point(491, 261)
        btnCancel.Name = "btnCancel"
        btnCancel.Size = New Size(94, 36)
        btnCancel.TabIndex = 4
        btnCancel.Text = "Cancel"
        btnCancel.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(133, 131)
        Label1.Name = "Label1"
        Label1.Size = New Size(82, 15)
        Label1.TabIndex = 5
        Label1.Text = "Vendor Name:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(133, 177)
        Label2.Name = "Label2"
        Label2.Size = New Size(71, 15)
        Label2.TabIndex = 6
        Label2.Text = "Contact No:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(133, 218)
        Label3.Name = "Label3"
        Label3.Size = New Size(52, 15)
        Label3.TabIndex = 7
        Label3.Text = "Address:"
        ' 
        ' FrmVendorEdit
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.GradientActiveCaption
        ClientSize = New Size(800, 450)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(btnCancel)
        Controls.Add(btnSave)
        Controls.Add(txtAddress)
        Controls.Add(txtContact)
        Controls.Add(txtName)
        Name = "FrmVendorEdit"
        Text = "FrmVendorEdit"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtName As TextBox
    Friend WithEvents txtContact As TextBox
    Friend WithEvents txtAddress As TextBox
    Friend WithEvents btnSave As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
End Class
