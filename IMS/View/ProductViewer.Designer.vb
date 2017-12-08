<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ProductViewer
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
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.dgView = New System.Windows.Forms.DataGridView()
        Me.prodID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.prodCode = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.prodName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ctxMenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.RefreshToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SelectToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.DeleteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.prodDesc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.prodCat = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.prodPrice = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.prodSalePrice = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.gstPrice = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.totalPrice = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.prodQty = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.prodDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.productStatusStrip = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lblTotalItems = New System.Windows.Forms.ToolStripStatusLabel()
        Me.MenuStrip = New System.Windows.Forms.MenuStrip()
        Me.OptionsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ByCategoriesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ByNameToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BySupplierToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnSearch = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripTextBox1 = New System.Windows.Forms.ToolStripTextBox()
        CType(Me.dgView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ctxMenu.SuspendLayout()
        Me.productStatusStrip.SuspendLayout()
        Me.MenuStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgView
        '
        Me.dgView.AllowUserToAddRows = False
        Me.dgView.AllowUserToDeleteRows = False
        Me.dgView.AllowUserToOrderColumns = True
        Me.dgView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.prodID, Me.prodCode, Me.prodName, Me.prodDesc, Me.prodCat, Me.prodPrice, Me.prodSalePrice, Me.gstPrice, Me.totalPrice, Me.prodQty, Me.prodDate})
        Me.dgView.ContextMenuStrip = Me.ctxMenu
        Me.dgView.Location = New System.Drawing.Point(0, 30)
        Me.dgView.Name = "dgView"
        Me.dgView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgView.Size = New System.Drawing.Size(971, 330)
        Me.dgView.TabIndex = 0
        '
        'prodID
        '
        Me.prodID.FillWeight = 30.0!
        Me.prodID.HeaderText = "ID"
        Me.prodID.Name = "prodID"
        Me.prodID.ReadOnly = True
        '
        'prodCode
        '
        Me.prodCode.FillWeight = 83.94669!
        Me.prodCode.HeaderText = "Code"
        Me.prodCode.Name = "prodCode"
        Me.prodCode.ReadOnly = True
        '
        'prodName
        '
        Me.prodName.ContextMenuStrip = Me.ctxMenu
        Me.prodName.FillWeight = 83.94669!
        Me.prodName.HeaderText = "Name"
        Me.prodName.Name = "prodName"
        Me.prodName.ReadOnly = True
        '
        'ctxMenu
        '
        Me.ctxMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RefreshToolStripMenuItem, Me.SelectToolStripMenuItem, Me.ToolStripSeparator1, Me.DeleteToolStripMenuItem, Me.EditToolStripMenuItem})
        Me.ctxMenu.Name = "contextMenu"
        Me.ctxMenu.Size = New System.Drawing.Size(136, 98)
        '
        'RefreshToolStripMenuItem
        '
        Me.RefreshToolStripMenuItem.Name = "RefreshToolStripMenuItem"
        Me.RefreshToolStripMenuItem.Size = New System.Drawing.Size(135, 22)
        Me.RefreshToolStripMenuItem.Text = "Refresh"
        '
        'SelectToolStripMenuItem
        '
        Me.SelectToolStripMenuItem.Name = "SelectToolStripMenuItem"
        Me.SelectToolStripMenuItem.Size = New System.Drawing.Size(135, 22)
        Me.SelectToolStripMenuItem.Text = "View Image"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(132, 6)
        '
        'DeleteToolStripMenuItem
        '
        Me.DeleteToolStripMenuItem.Name = "DeleteToolStripMenuItem"
        Me.DeleteToolStripMenuItem.Size = New System.Drawing.Size(135, 22)
        Me.DeleteToolStripMenuItem.Text = "Delete"
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(135, 22)
        Me.EditToolStripMenuItem.Text = "Edit"
        '
        'prodDesc
        '
        Me.prodDesc.FillWeight = 83.94669!
        Me.prodDesc.HeaderText = "Description"
        Me.prodDesc.Name = "prodDesc"
        Me.prodDesc.ReadOnly = True
        '
        'prodCat
        '
        Me.prodCat.FillWeight = 83.94669!
        Me.prodCat.HeaderText = "Category"
        Me.prodCat.Name = "prodCat"
        Me.prodCat.ReadOnly = True
        '
        'prodPrice
        '
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle1.Format = "C2"
        DataGridViewCellStyle1.NullValue = Nothing
        Me.prodPrice.DefaultCellStyle = DataGridViewCellStyle1
        Me.prodPrice.FillWeight = 83.94669!
        Me.prodPrice.HeaderText = "Price"
        Me.prodPrice.Name = "prodPrice"
        Me.prodPrice.ReadOnly = True
        '
        'prodSalePrice
        '
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle2.Format = "C2"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.prodSalePrice.DefaultCellStyle = DataGridViewCellStyle2
        Me.prodSalePrice.FillWeight = 83.94669!
        Me.prodSalePrice.HeaderText = "Sale Price"
        Me.prodSalePrice.Name = "prodSalePrice"
        Me.prodSalePrice.ReadOnly = True
        '
        'gstPrice
        '
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle3.Format = "C2"
        DataGridViewCellStyle3.NullValue = Nothing
        Me.gstPrice.DefaultCellStyle = DataGridViewCellStyle3
        Me.gstPrice.FillWeight = 120.0!
        Me.gstPrice.HeaderText = "Sale Price (+GST)"
        Me.gstPrice.Name = "gstPrice"
        Me.gstPrice.ReadOnly = True
        '
        'totalPrice
        '
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle4.Format = "C2"
        DataGridViewCellStyle4.NullValue = Nothing
        Me.totalPrice.DefaultCellStyle = DataGridViewCellStyle4
        Me.totalPrice.HeaderText = "Total Price"
        Me.totalPrice.Name = "totalPrice"
        Me.totalPrice.ReadOnly = True
        '
        'prodQty
        '
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.prodQty.DefaultCellStyle = DataGridViewCellStyle5
        Me.prodQty.FillWeight = 50.0!
        Me.prodQty.HeaderText = "Quantity"
        Me.prodQty.Name = "prodQty"
        Me.prodQty.ReadOnly = True
        '
        'prodDate
        '
        DataGridViewCellStyle6.Format = "g"
        DataGridViewCellStyle6.NullValue = Nothing
        Me.prodDate.DefaultCellStyle = DataGridViewCellStyle6
        Me.prodDate.HeaderText = "Entry Date"
        Me.prodDate.Name = "prodDate"
        Me.prodDate.ReadOnly = True
        '
        'productStatusStrip
        '
        Me.productStatusStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1, Me.lblTotalItems})
        Me.productStatusStrip.Location = New System.Drawing.Point(0, 363)
        Me.productStatusStrip.Name = "productStatusStrip"
        Me.productStatusStrip.Size = New System.Drawing.Size(971, 22)
        Me.productStatusStrip.TabIndex = 1
        Me.productStatusStrip.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(69, 17)
        Me.ToolStripStatusLabel1.Text = "Total Items:"
        '
        'lblTotalItems
        '
        Me.lblTotalItems.Name = "lblTotalItems"
        Me.lblTotalItems.Size = New System.Drawing.Size(13, 17)
        Me.lblTotalItems.Text = "0"
        '
        'MenuStrip
        '
        Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OptionsToolStripMenuItem, Me.btnSearch, Me.ToolStripTextBox1})
        Me.MenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip.Name = "MenuStrip"
        Me.MenuStrip.Size = New System.Drawing.Size(971, 27)
        Me.MenuStrip.TabIndex = 3
        Me.MenuStrip.Text = "MenuStrip1"
        '
        'OptionsToolStripMenuItem
        '
        Me.OptionsToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.OptionsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ByCategoriesToolStripMenuItem, Me.ByNameToolStripMenuItem, Me.BySupplierToolStripMenuItem})
        Me.OptionsToolStripMenuItem.Name = "OptionsToolStripMenuItem"
        Me.OptionsToolStripMenuItem.Size = New System.Drawing.Size(99, 23)
        Me.OptionsToolStripMenuItem.Text = "Search Options"
        '
        'ByCategoriesToolStripMenuItem
        '
        Me.ByCategoriesToolStripMenuItem.CheckOnClick = True
        Me.ByCategoriesToolStripMenuItem.Name = "ByCategoriesToolStripMenuItem"
        Me.ByCategoriesToolStripMenuItem.Size = New System.Drawing.Size(138, 22)
        Me.ByCategoriesToolStripMenuItem.Text = "By Category"
        '
        'ByNameToolStripMenuItem
        '
        Me.ByNameToolStripMenuItem.CheckOnClick = True
        Me.ByNameToolStripMenuItem.Name = "ByNameToolStripMenuItem"
        Me.ByNameToolStripMenuItem.Size = New System.Drawing.Size(138, 22)
        Me.ByNameToolStripMenuItem.Text = "By Name"
        '
        'BySupplierToolStripMenuItem
        '
        Me.BySupplierToolStripMenuItem.CheckOnClick = True
        Me.BySupplierToolStripMenuItem.Name = "BySupplierToolStripMenuItem"
        Me.BySupplierToolStripMenuItem.Size = New System.Drawing.Size(138, 22)
        Me.BySupplierToolStripMenuItem.Text = "By Supplier"
        '
        'btnSearch
        '
        Me.btnSearch.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnSearch.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(54, 23)
        Me.btnSearch.Text = "Search"
        '
        'ToolStripTextBox1
        '
        Me.ToolStripTextBox1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripTextBox1.Name = "ToolStripTextBox1"
        Me.ToolStripTextBox1.Size = New System.Drawing.Size(150, 23)
        '
        'ProductViewer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(971, 385)
        Me.Controls.Add(Me.productStatusStrip)
        Me.Controls.Add(Me.MenuStrip)
        Me.Controls.Add(Me.dgView)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(987, 423)
        Me.Name = "ProductViewer"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Product List"
        CType(Me.dgView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ctxMenu.ResumeLayout(False)
        Me.productStatusStrip.ResumeLayout(False)
        Me.productStatusStrip.PerformLayout()
        Me.MenuStrip.ResumeLayout(False)
        Me.MenuStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgView As DataGridView
    Friend WithEvents productStatusStrip As StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As ToolStripStatusLabel
    Friend WithEvents lblTotalItems As ToolStripStatusLabel
    Friend WithEvents ctxMenu As ContextMenuStrip
    Friend WithEvents RefreshToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MenuStrip As MenuStrip
    Friend WithEvents btnSearch As ToolStripMenuItem
    Friend WithEvents ToolStripTextBox1 As ToolStripTextBox
    Friend WithEvents OptionsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ByCategoriesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ByNameToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BySupplierToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SelectToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents DeleteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EditToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents prodID As DataGridViewTextBoxColumn
    Friend WithEvents prodCode As DataGridViewTextBoxColumn
    Friend WithEvents prodName As DataGridViewTextBoxColumn
    Friend WithEvents prodDesc As DataGridViewTextBoxColumn
    Friend WithEvents prodCat As DataGridViewTextBoxColumn
    Friend WithEvents prodPrice As DataGridViewTextBoxColumn
    Friend WithEvents prodSalePrice As DataGridViewTextBoxColumn
    Friend WithEvents gstPrice As DataGridViewTextBoxColumn
    Friend WithEvents totalPrice As DataGridViewTextBoxColumn
    Friend WithEvents prodQty As DataGridViewTextBoxColumn
    Friend WithEvents prodDate As DataGridViewTextBoxColumn
End Class
