<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmStallsList
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
        dgvStalls = New DataGridView()
        txtSearch = New TextBox()
        btnAdd = New Button()
        btnEdit = New Button()
        btnDelete = New Button()
        btnRefresh = New Button()
        Label1 = New Label()
        btnExit = New Button()
        CType(dgvStalls, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' dgvStalls
        ' 
        dgvStalls.BackgroundColor = SystemColors.ActiveCaption
        dgvStalls.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvStalls.Location = New Point(96, 70)
        dgvStalls.Name = "dgvStalls"
        dgvStalls.Size = New Size(537, 299)
        dgvStalls.TabIndex = 0
        ' 
        ' txtSearch
        ' 
        txtSearch.BackColor = SystemColors.MenuBar
        txtSearch.Location = New Point(96, 44)
        txtSearch.Name = "txtSearch"
        txtSearch.Size = New Size(301, 23)
        txtSearch.TabIndex = 1
        ' 
        ' btnAdd
        ' 
        btnAdd.BackColor = SystemColors.ActiveCaption
        btnAdd.Location = New Point(12, 91)
        btnAdd.Name = "btnAdd"
        btnAdd.Size = New Size(78, 38)
        btnAdd.TabIndex = 2
        btnAdd.Text = "Add"
        btnAdd.UseVisualStyleBackColor = False
        ' 
        ' btnEdit
        ' 
        btnEdit.BackColor = SystemColors.Window
        btnEdit.Location = New Point(12, 147)
        btnEdit.Name = "btnEdit"
        btnEdit.Size = New Size(78, 39)
        btnEdit.TabIndex = 3
        btnEdit.Text = "Edit"
        btnEdit.UseVisualStyleBackColor = False
        ' 
        ' btnDelete
        ' 
        btnDelete.BackColor = SystemColors.Info
        btnDelete.Location = New Point(12, 209)
        btnDelete.Name = "btnDelete"
        btnDelete.Size = New Size(78, 39)
        btnDelete.TabIndex = 4
        btnDelete.Text = "Delete"
        btnDelete.UseVisualStyleBackColor = False
        ' 
        ' btnRefresh
        ' 
        btnRefresh.BackColor = SystemColors.Menu
        btnRefresh.Location = New Point(12, 272)
        btnRefresh.Name = "btnRefresh"
        btnRefresh.Size = New Size(78, 38)
        btnRefresh.TabIndex = 5
        btnRefresh.Text = "Refresh"
        btnRefresh.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(45, 52)
        Label1.Name = "Label1"
        Label1.Size = New Size(45, 15)
        Label1.TabIndex = 6
        Label1.Text = "Search:"
        ' 
        ' btnExit
        ' 
        btnExit.Location = New Point(12, 328)
        btnExit.Name = "btnExit"
        btnExit.Size = New Size(78, 41)
        btnExit.TabIndex = 7
        btnExit.Text = "Exit"
        btnExit.UseVisualStyleBackColor = True
        ' 
        ' FrmStallsList
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ScrollBar
        ClientSize = New Size(800, 450)
        Controls.Add(btnExit)
        Controls.Add(Label1)
        Controls.Add(btnRefresh)
        Controls.Add(btnDelete)
        Controls.Add(btnEdit)
        Controls.Add(btnAdd)
        Controls.Add(txtSearch)
        Controls.Add(dgvStalls)
        Name = "FrmStallsList"
        Text = "FrmStallsList"
        CType(dgvStalls, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents dgvStalls As DataGridView
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnEdit As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnRefresh As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents btnExit As Button
End Class
