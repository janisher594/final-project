<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmRentalEdit
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
        cboVendor = New ComboBox()
        cboStall = New ComboBox()
        dtpStart = New DateTimePicker()
        dtpEnd = New DateTimePicker()
        numAmount = New NumericUpDown()
        txtORNo = New TextBox()
        chkAddPaymentNow = New CheckBox()
        btnSave = New Button()
        btnCancel = New Button()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        CType(numAmount, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' cboVendor
        ' 
        cboVendor.FormattingEnabled = True
        cboVendor.Location = New Point(113, 31)
        cboVendor.Name = "cboVendor"
        cboVendor.Size = New Size(121, 23)
        cboVendor.TabIndex = 0
        ' 
        ' cboStall
        ' 
        cboStall.FormattingEnabled = True
        cboStall.Location = New Point(113, 78)
        cboStall.Name = "cboStall"
        cboStall.Size = New Size(121, 23)
        cboStall.TabIndex = 1
        ' 
        ' dtpStart
        ' 
        dtpStart.Location = New Point(113, 119)
        dtpStart.Name = "dtpStart"
        dtpStart.Size = New Size(200, 23)
        dtpStart.TabIndex = 2
        ' 
        ' dtpEnd
        ' 
        dtpEnd.Location = New Point(113, 163)
        dtpEnd.Name = "dtpEnd"
        dtpEnd.Size = New Size(200, 23)
        dtpEnd.TabIndex = 3
        ' 
        ' numAmount
        ' 
        numAmount.Location = New Point(114, 211)
        numAmount.Name = "numAmount"
        numAmount.Size = New Size(120, 23)
        numAmount.TabIndex = 4
        ' 
        ' txtORNo
        ' 
        txtORNo.Location = New Point(114, 265)
        txtORNo.Name = "txtORNo"
        txtORNo.Size = New Size(100, 23)
        txtORNo.TabIndex = 5
        ' 
        ' chkAddPaymentNow
        ' 
        chkAddPaymentNow.AutoSize = True
        chkAddPaymentNow.Location = New Point(114, 317)
        chkAddPaymentNow.Name = "chkAddPaymentNow"
        chkAddPaymentNow.Size = New Size(84, 19)
        chkAddPaymentNow.TabIndex = 6
        chkAddPaymentNow.Text = "CheckBox1"
        chkAddPaymentNow.UseVisualStyleBackColor = True
        ' 
        ' btnSave
        ' 
        btnSave.Location = New Point(113, 355)
        btnSave.Name = "btnSave"
        btnSave.Size = New Size(85, 41)
        btnSave.TabIndex = 7
        btnSave.Text = "Save"
        btnSave.UseVisualStyleBackColor = True
        ' 
        ' btnCancel
        ' 
        btnCancel.Location = New Point(238, 355)
        btnCancel.Name = "btnCancel"
        btnCancel.Size = New Size(75, 41)
        btnCancel.TabIndex = 8
        btnCancel.Text = "Cancel"
        btnCancel.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(60, 31)
        Label1.Name = "Label1"
        Label1.Size = New Size(47, 15)
        Label1.TabIndex = 9
        Label1.Text = "Vendor:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(60, 78)
        Label2.Name = "Label2"
        Label2.Size = New Size(32, 15)
        Label2.TabIndex = 10
        Label2.Text = "Stall:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(37, 127)
        Label3.Name = "Label3"
        Label3.Size = New Size(61, 15)
        Label3.TabIndex = 11
        Label3.Text = "Start Date:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(44, 169)
        Label4.Name = "Label4"
        Label4.Size = New Size(54, 15)
        Label4.TabIndex = 12
        Label4.Text = "Amount:"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(44, 213)
        Label5.Name = "Label5"
        Label5.Size = New Size(45, 15)
        Label5.TabIndex = 13
        Label5.Text = "OR No:"
        ' 
        ' FrmRentalEdit
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveCaption
        ClientSize = New Size(800, 450)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(btnCancel)
        Controls.Add(btnSave)
        Controls.Add(chkAddPaymentNow)
        Controls.Add(txtORNo)
        Controls.Add(numAmount)
        Controls.Add(dtpEnd)
        Controls.Add(dtpStart)
        Controls.Add(cboStall)
        Controls.Add(cboVendor)
        Name = "FrmRentalEdit"
        Text = "FrmRentalEdit"
        CType(numAmount, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents cboVendor As ComboBox
    Friend WithEvents cboStall As ComboBox
    Friend WithEvents dtpStart As DateTimePicker
    Friend WithEvents dtpEnd As DateTimePicker
    Friend WithEvents numAmount As NumericUpDown
    Friend WithEvents txtORNo As TextBox
    Friend WithEvents chkAddPaymentNow As CheckBox
    Friend WithEvents btnSave As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
End Class
