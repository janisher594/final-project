<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmStallEdit
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
        txtStallNo = New TextBox()
        txtLocation = New TextBox()
        numRentRate = New NumericUpDown()
        cboStatus = New ComboBox()
        btnSave = New Button()
        btnCancel = New Button()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        CType(numRentRate, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' txtStallNo
        ' 
        txtStallNo.Location = New Point(166, 112)
        txtStallNo.Name = "txtStallNo"
        txtStallNo.Size = New Size(365, 23)
        txtStallNo.TabIndex = 0
        ' 
        ' txtLocation
        ' 
        txtLocation.Location = New Point(167, 170)
        txtLocation.Name = "txtLocation"
        txtLocation.Size = New Size(364, 23)
        txtLocation.TabIndex = 1
        ' 
        ' numRentRate
        ' 
        numRentRate.Location = New Point(167, 215)
        numRentRate.Name = "numRentRate"
        numRentRate.Size = New Size(364, 23)
        numRentRate.TabIndex = 2
        ' 
        ' cboStatus
        ' 
        cboStatus.FormattingEnabled = True
        cboStatus.Location = New Point(167, 266)
        cboStatus.Name = "cboStatus"
        cboStatus.Size = New Size(364, 23)
        cboStatus.TabIndex = 3
        ' 
        ' btnSave
        ' 
        btnSave.Location = New Point(397, 311)
        btnSave.Name = "btnSave"
        btnSave.Size = New Size(63, 33)
        btnSave.TabIndex = 4
        btnSave.Text = "Save"
        btnSave.UseVisualStyleBackColor = True
        ' 
        ' btnCancel
        ' 
        btnCancel.Location = New Point(466, 311)
        btnCancel.Name = "btnCancel"
        btnCancel.Size = New Size(65, 33)
        btnCancel.TabIndex = 5
        btnCancel.Text = "Cancel"
        btnCancel.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(109, 115)
        Label1.Name = "Label1"
        Label1.Size = New Size(51, 15)
        Label1.TabIndex = 6
        Label1.Text = "Stall No:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(101, 170)
        Label2.Name = "Label2"
        Label2.Size = New Size(56, 15)
        Label2.TabIndex = 7
        Label2.Text = "Location:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(101, 217)
        Label3.Name = "Label3"
        Label3.Size = New Size(60, 15)
        Label3.TabIndex = 8
        Label3.Text = "Rent Rate:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(109, 269)
        Label4.Name = "Label4"
        Label4.Size = New Size(42, 15)
        Label4.TabIndex = 9
        Label4.Text = "Status:"
        ' 
        ' FrmStallEdit
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveCaption
        ClientSize = New Size(800, 450)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(btnCancel)
        Controls.Add(btnSave)
        Controls.Add(cboStatus)
        Controls.Add(numRentRate)
        Controls.Add(txtLocation)
        Controls.Add(txtStallNo)
        Name = "FrmStallEdit"
        Text = "FrmStallEdit"
        CType(numRentRate, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtStallNo As TextBox
    Friend WithEvents txtLocation As TextBox
    Friend WithEvents numRentRate As NumericUpDown
    Friend WithEvents cboStatus As ComboBox
    Friend WithEvents btnSave As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
End Class
