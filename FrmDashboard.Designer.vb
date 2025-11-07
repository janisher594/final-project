<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmDashboard
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
        lblTitle = New Label()
        btnVendors = New Button()
        btnStalls = New Button()
        btnRentals = New Button()
        btnExit = New Button()
        SuspendLayout()
        ' 
        ' lblTitle
        ' 
        lblTitle.AutoSize = True
        lblTitle.Location = New Point(282, 36)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(182, 15)
        lblTitle.TabIndex = 0
        lblTitle.Text = "Public Market Stall Rental System"
        ' 
        ' btnVendors
        ' 
        btnVendors.BackColor = SystemColors.GradientActiveCaption
        btnVendors.Location = New Point(271, 78)
        btnVendors.Name = "btnVendors"
        btnVendors.Size = New Size(206, 67)
        btnVendors.TabIndex = 1
        btnVendors.Text = "Manage Vendors"
        btnVendors.UseVisualStyleBackColor = False
        ' 
        ' btnStalls
        ' 
        btnStalls.BackColor = SystemColors.ActiveCaption
        btnStalls.Location = New Point(271, 169)
        btnStalls.Name = "btnStalls"
        btnStalls.Size = New Size(206, 65)
        btnStalls.TabIndex = 2
        btnStalls.Text = "Manage Stalls"
        btnStalls.UseVisualStyleBackColor = False
        ' 
        ' btnRentals
        ' 
        btnRentals.BackColor = SystemColors.ControlDark
        btnRentals.Location = New Point(271, 259)
        btnRentals.Name = "btnRentals"
        btnRentals.Size = New Size(206, 69)
        btnRentals.TabIndex = 3
        btnRentals.Text = "Manage Rentals"
        btnRentals.UseVisualStyleBackColor = False
        ' 
        ' btnExit
        ' 
        btnExit.BackColor = SystemColors.GradientActiveCaption
        btnExit.Location = New Point(271, 358)
        btnExit.Name = "btnExit"
        btnExit.Size = New Size(206, 65)
        btnExit.TabIndex = 4
        btnExit.Text = "Exit"
        btnExit.UseVisualStyleBackColor = False
        ' 
        ' FrmDashboard
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(btnExit)
        Controls.Add(btnRentals)
        Controls.Add(btnStalls)
        Controls.Add(btnVendors)
        Controls.Add(lblTitle)
        Name = "FrmDashboard"
        Text = "FrmDashboard"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblTitle As Label
    Friend WithEvents btnVendors As Button
    Friend WithEvents btnStalls As Button
    Friend WithEvents btnRentals As Button
    Friend WithEvents btnExit As Button
End Class
