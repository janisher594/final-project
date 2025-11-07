<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmVendorsList
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
        dgvVendors = New DataGridView()
        txtSearch = New TextBox()
        btnAdd = New Button()
        btnEdit = New Button()
        btnDelete = New Button()
        btnRefresh = New Button()
        btnPrint = New Button()
        btnExit = New Button()
        CType(dgvVendors, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' dgvVendors
        ' 
        dgvVendors.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvVendors.Location = New Point(60, 51)
        dgvVendors.Name = "dgvVendors"
        dgvVendors.Size = New Size(707, 342)
        dgvVendors.TabIndex = 0
        ' 
        ' txtSearch
        ' 
        txtSearch.BackColor = SystemColors.InactiveCaption
        txtSearch.Location = New Point(60, 22)
        txtSearch.Name = "txtSearch"
        txtSearch.Size = New Size(358, 23)
        txtSearch.TabIndex = 1
        ' 
        ' btnAdd
        ' 
        btnAdd.Location = New Point(60, 399)
        btnAdd.Name = "btnAdd"
        btnAdd.Size = New Size(102, 39)
        btnAdd.TabIndex = 2
        btnAdd.Text = "Add"
        btnAdd.UseVisualStyleBackColor = True
        ' 
        ' btnEdit
        ' 
        btnEdit.Location = New Point(183, 399)
        btnEdit.Name = "btnEdit"
        btnEdit.Size = New Size(98, 39)
        btnEdit.TabIndex = 3
        btnEdit.Text = "Edit"
        btnEdit.UseVisualStyleBackColor = True
        ' 
        ' btnDelete
        ' 
        btnDelete.Location = New Point(287, 399)
        btnDelete.Name = "btnDelete"
        btnDelete.Size = New Size(100, 39)
        btnDelete.TabIndex = 4
        btnDelete.Text = "Delete"
        btnDelete.UseVisualStyleBackColor = True
        ' 
        ' btnRefresh
        ' 
        btnRefresh.Location = New Point(411, 399)
        btnRefresh.Name = "btnRefresh"
        btnRefresh.Size = New Size(110, 39)
        btnRefresh.TabIndex = 5
        btnRefresh.Text = "Refresh"
        btnRefresh.UseVisualStyleBackColor = True
        ' 
        ' btnPrint
        ' 
        btnPrint.Location = New Point(536, 399)
        btnPrint.Name = "btnPrint"
        btnPrint.Size = New Size(107, 39)
        btnPrint.TabIndex = 6
        btnPrint.Text = "Print"
        btnPrint.UseVisualStyleBackColor = True
        ' 
        ' btnExit
        ' 
        btnExit.Location = New Point(659, 399)
        btnExit.Name = "btnExit"
        btnExit.Size = New Size(108, 39)
        btnExit.TabIndex = 7
        btnExit.Text = "Exit"
        btnExit.UseVisualStyleBackColor = True
        ' 
        ' FrmVendorsList
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(840, 479)
        Controls.Add(btnExit)
        Controls.Add(btnPrint)
        Controls.Add(btnRefresh)
        Controls.Add(btnDelete)
        Controls.Add(btnEdit)
        Controls.Add(btnAdd)
        Controls.Add(txtSearch)
        Controls.Add(dgvVendors)
        Name = "FrmVendorsList"
        Text = "FrmVendorsList"
        CType(dgvVendors, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents dgvVendors As DataGridView
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnEdit As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnRefresh As Button
    Friend WithEvents btnPrint As Button
    Friend WithEvents btnExit As Button
End Class
