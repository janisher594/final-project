<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmRentalsList
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
        dgvRentals = New DataGridView()
        txtTenantSearch = New TextBox()
        txtStallSearch = New TextBox()
        dtpTo = New DateTimePicker()
        chkDateRange = New CheckBox()
        cboSort = New ComboBox()
        btnAdd = New Button()
        btnEdit = New Button()
        btnDelete = New Button()
        btnRefresh = New Button()
        btnPrint = New Button()
        Label1 = New Label()
        dtpFrom = New DateTimePicker()
        Label2 = New Label()
        btnExit = New Button()
        CType(dgvRentals, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' dgvRentals
        ' 
        dgvRentals.BackgroundColor = SystemColors.Info
        dgvRentals.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvRentals.Location = New Point(331, 12)
        dgvRentals.Name = "dgvRentals"
        dgvRentals.Size = New Size(447, 427)
        dgvRentals.TabIndex = 0
        ' 
        ' txtTenantSearch
        ' 
        txtTenantSearch.Location = New Point(11, 55)
        txtTenantSearch.Name = "txtTenantSearch"
        txtTenantSearch.Size = New Size(127, 23)
        txtTenantSearch.TabIndex = 1
        ' 
        ' txtStallSearch
        ' 
        txtStallSearch.Location = New Point(158, 55)
        txtStallSearch.Name = "txtStallSearch"
        txtStallSearch.Size = New Size(154, 23)
        txtStallSearch.TabIndex = 2
        ' 
        ' dtpTo
        ' 
        dtpTo.Location = New Point(55, 135)
        dtpTo.Name = "dtpTo"
        dtpTo.Size = New Size(200, 23)
        dtpTo.TabIndex = 3
        ' 
        ' chkDateRange
        ' 
        chkDateRange.AutoSize = True
        chkDateRange.Location = New Point(104, 166)
        chkDateRange.Name = "chkDateRange"
        chkDateRange.Size = New Size(108, 19)
        chkDateRange.TabIndex = 5
        chkDateRange.Text = "Use Date Range"
        chkDateRange.UseVisualStyleBackColor = True
        ' 
        ' cboSort
        ' 
        cboSort.FormattingEnabled = True
        cboSort.Location = New Point(104, 206)
        cboSort.Name = "cboSort"
        cboSort.Size = New Size(121, 23)
        cboSort.TabIndex = 6
        ' 
        ' btnAdd
        ' 
        btnAdd.Location = New Point(55, 257)
        btnAdd.Name = "btnAdd"
        btnAdd.Size = New Size(75, 33)
        btnAdd.TabIndex = 7
        btnAdd.Text = "Add"
        btnAdd.UseVisualStyleBackColor = True
        ' 
        ' btnEdit
        ' 
        btnEdit.Location = New Point(165, 257)
        btnEdit.Name = "btnEdit"
        btnEdit.Size = New Size(75, 33)
        btnEdit.TabIndex = 8
        btnEdit.Text = "Edit"
        btnEdit.UseVisualStyleBackColor = True
        ' 
        ' btnDelete
        ' 
        btnDelete.Location = New Point(55, 316)
        btnDelete.Name = "btnDelete"
        btnDelete.Size = New Size(75, 34)
        btnDelete.TabIndex = 9
        btnDelete.Text = "Delete"
        btnDelete.UseVisualStyleBackColor = True
        ' 
        ' btnRefresh
        ' 
        btnRefresh.Location = New Point(165, 316)
        btnRefresh.Name = "btnRefresh"
        btnRefresh.Size = New Size(75, 34)
        btnRefresh.TabIndex = 10
        btnRefresh.Text = "Refresh"
        btnRefresh.UseVisualStyleBackColor = True
        ' 
        ' btnPrint
        ' 
        btnPrint.Location = New Point(55, 372)
        btnPrint.Name = "btnPrint"
        btnPrint.Size = New Size(75, 36)
        btnPrint.TabIndex = 11
        btnPrint.Text = "Print"
        btnPrint.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(11, 100)
        Label1.Name = "Label1"
        Label1.Size = New Size(38, 15)
        Label1.TabIndex = 12
        Label1.Text = "From:"
        ' 
        ' dtpFrom
        ' 
        dtpFrom.Location = New Point(55, 94)
        dtpFrom.Name = "dtpFrom"
        dtpFrom.Size = New Size(200, 23)
        dtpFrom.TabIndex = 4
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(12, 141)
        Label2.Name = "Label2"
        Label2.Size = New Size(23, 15)
        Label2.TabIndex = 13
        Label2.Text = "To:"
        ' 
        ' btnExit
        ' 
        btnExit.Location = New Point(165, 374)
        btnExit.Name = "btnExit"
        btnExit.Size = New Size(75, 34)
        btnExit.TabIndex = 14
        btnExit.Text = "Exit"
        btnExit.UseVisualStyleBackColor = True
        ' 
        ' FrmRentalsList
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveCaption
        ClientSize = New Size(800, 450)
        Controls.Add(btnExit)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(btnPrint)
        Controls.Add(btnRefresh)
        Controls.Add(btnDelete)
        Controls.Add(btnEdit)
        Controls.Add(btnAdd)
        Controls.Add(cboSort)
        Controls.Add(chkDateRange)
        Controls.Add(dtpFrom)
        Controls.Add(dtpTo)
        Controls.Add(txtStallSearch)
        Controls.Add(txtTenantSearch)
        Controls.Add(dgvRentals)
        Name = "FrmRentalsList"
        Text = "FrmRentalsList"
        CType(dgvRentals, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents dgvRentals As DataGridView
    Friend WithEvents txtTenantSearch As TextBox
    Friend WithEvents txtStallSearch As TextBox
    Friend WithEvents dtpTo As DateTimePicker
    Friend WithEvents chkDateRange As CheckBox
    Friend WithEvents cboSort As ComboBox
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnEdit As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnRefresh As Button
    Friend WithEvents btnPrint As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents dtpFrom As DateTimePicker
    Friend WithEvents Label2 As Label
    Friend WithEvents btnExit As Button
End Class
