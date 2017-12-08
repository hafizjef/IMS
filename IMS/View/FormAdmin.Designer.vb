<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormAdmin
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormAdmin))
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.statusLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.usernameLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ProductManager = New System.Windows.Forms.GroupBox()
        Me.btnResetDate = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.purchaseRateTxt = New System.Windows.Forms.TextBox()
        Me.prodQuantity = New System.Windows.Forms.NumericUpDown()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.btnBrowseImg = New System.Windows.Forms.Button()
        Me.btnRemoveImg = New System.Windows.Forms.Button()
        Me.productPicture = New System.Windows.Forms.PictureBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.salesRateTxt = New System.Windows.Forms.TextBox()
        Me.btnAddSupplier = New System.Windows.Forms.Button()
        Me.btnAddCategory = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.prodDescTxt = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.supplierCombo = New System.Windows.Forms.ComboBox()
        Me.prodDatePicker = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.categoryCombo = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.prodNameTxt = New System.Windows.Forms.TextBox()
        Me.prodCodeTxt = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.MenuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListOfProductToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReturnProductToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UserManagementToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.addUserMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.ManageUserToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AdminMenuStrip = New System.Windows.Forms.MenuStrip()
        Me.SignOutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UserMenuStrip = New System.Windows.Forms.MenuStrip()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListProductMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.editProfileStrip = New System.Windows.Forms.ToolStripMenuItem()
        Me.SignOutToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditProfileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusStrip1.SuspendLayout()
        Me.ProductManager.SuspendLayout()
        CType(Me.prodQuantity, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.productPicture, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.AdminMenuStrip.SuspendLayout()
        Me.UserMenuStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.statusLabel, Me.usernameLabel})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 393)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.StatusStrip1.Size = New System.Drawing.Size(776, 22)
        Me.StatusStrip1.TabIndex = 1
        Me.StatusStrip1.Text = "usernameStatus"
        '
        'statusLabel
        '
        Me.statusLabel.Name = "statusLabel"
        Me.statusLabel.Size = New System.Drawing.Size(60, 17)
        Me.statusLabel.Text = "Welcome:"
        '
        'usernameLabel
        '
        Me.usernameLabel.Name = "usernameLabel"
        Me.usernameLabel.Size = New System.Drawing.Size(60, 17)
        Me.usernameLabel.Text = "Username"
        '
        'ProductManager
        '
        Me.ProductManager.Controls.Add(Me.btnResetDate)
        Me.ProductManager.Controls.Add(Me.btnReset)
        Me.ProductManager.Controls.Add(Me.purchaseRateTxt)
        Me.ProductManager.Controls.Add(Me.prodQuantity)
        Me.ProductManager.Controls.Add(Me.btnSave)
        Me.ProductManager.Controls.Add(Me.Label10)
        Me.ProductManager.Controls.Add(Me.btnBrowseImg)
        Me.ProductManager.Controls.Add(Me.btnRemoveImg)
        Me.ProductManager.Controls.Add(Me.productPicture)
        Me.ProductManager.Controls.Add(Me.Label8)
        Me.ProductManager.Controls.Add(Me.Label7)
        Me.ProductManager.Controls.Add(Me.salesRateTxt)
        Me.ProductManager.Controls.Add(Me.btnAddSupplier)
        Me.ProductManager.Controls.Add(Me.btnAddCategory)
        Me.ProductManager.Controls.Add(Me.Label6)
        Me.ProductManager.Controls.Add(Me.prodDescTxt)
        Me.ProductManager.Controls.Add(Me.Label5)
        Me.ProductManager.Controls.Add(Me.supplierCombo)
        Me.ProductManager.Controls.Add(Me.prodDatePicker)
        Me.ProductManager.Controls.Add(Me.Label4)
        Me.ProductManager.Controls.Add(Me.categoryCombo)
        Me.ProductManager.Controls.Add(Me.Label3)
        Me.ProductManager.Controls.Add(Me.Label2)
        Me.ProductManager.Controls.Add(Me.prodNameTxt)
        Me.ProductManager.Controls.Add(Me.prodCodeTxt)
        Me.ProductManager.Controls.Add(Me.Label1)
        Me.ProductManager.Controls.Add(Me.btnUpdate)
        Me.ProductManager.Location = New System.Drawing.Point(12, 27)
        Me.ProductManager.Name = "ProductManager"
        Me.ProductManager.Size = New System.Drawing.Size(752, 363)
        Me.ProductManager.TabIndex = 2
        Me.ProductManager.TabStop = False
        Me.ProductManager.Text = "Manage Product"
        '
        'btnResetDate
        '
        Me.btnResetDate.Location = New System.Drawing.Point(313, 97)
        Me.btnResetDate.Name = "btnResetDate"
        Me.btnResetDate.Size = New System.Drawing.Size(23, 23)
        Me.btnResetDate.TabIndex = 6
        Me.btnResetDate.Text = "x"
        Me.btnResetDate.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.Location = New System.Drawing.Point(590, 334)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(75, 23)
        Me.btnReset.TabIndex = 16
        Me.btnReset.Text = "Reset"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'purchaseRateTxt
        '
        Me.purchaseRateTxt.Location = New System.Drawing.Point(107, 226)
        Me.purchaseRateTxt.Name = "purchaseRateTxt"
        Me.purchaseRateTxt.Size = New System.Drawing.Size(200, 20)
        Me.purchaseRateTxt.TabIndex = 10
        Me.purchaseRateTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'prodQuantity
        '
        Me.prodQuantity.Location = New System.Drawing.Point(107, 278)
        Me.prodQuantity.Maximum = New Decimal(New Integer() {99999, 0, 0, 0})
        Me.prodQuantity.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.prodQuantity.Name = "prodQuantity"
        Me.prodQuantity.Size = New System.Drawing.Size(200, 20)
        Me.prodQuantity.TabIndex = 12
        Me.prodQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.prodQuantity.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(671, 334)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 23)
        Me.btnSave.TabIndex = 15
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        Me.btnSave.Visible = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(24, 280)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(77, 13)
        Me.Label10.TabIndex = 24
        Me.Label10.Text = "Purchase Unit:"
        '
        'btnBrowseImg
        '
        Me.btnBrowseImg.Location = New System.Drawing.Point(570, 173)
        Me.btnBrowseImg.Name = "btnBrowseImg"
        Me.btnBrowseImg.Size = New System.Drawing.Size(75, 23)
        Me.btnBrowseImg.TabIndex = 13
        Me.btnBrowseImg.Text = "Browse"
        Me.btnBrowseImg.UseVisualStyleBackColor = True
        '
        'btnRemoveImg
        '
        Me.btnRemoveImg.Location = New System.Drawing.Point(651, 173)
        Me.btnRemoveImg.Name = "btnRemoveImg"
        Me.btnRemoveImg.Size = New System.Drawing.Size(75, 23)
        Me.btnRemoveImg.TabIndex = 14
        Me.btnRemoveImg.Text = "Remove"
        Me.btnRemoveImg.UseVisualStyleBackColor = True
        '
        'productPicture
        '
        Me.productPicture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.productPicture.Image = Global.IMS.My.Resources.Resources.imagePlaceholder
        Me.productPicture.Location = New System.Drawing.Point(547, 19)
        Me.productPicture.Name = "productPicture"
        Me.productPicture.Size = New System.Drawing.Size(199, 148)
        Me.productPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.productPicture.TabIndex = 18
        Me.productPicture.TabStop = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(39, 255)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(62, 13)
        Me.Label8.TabIndex = 17
        Me.Label8.Text = "Sales Rate:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(20, 229)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(81, 13)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "Purchase Rate:"
        '
        'salesRateTxt
        '
        Me.salesRateTxt.Location = New System.Drawing.Point(107, 252)
        Me.salesRateTxt.Name = "salesRateTxt"
        Me.salesRateTxt.Size = New System.Drawing.Size(200, 20)
        Me.salesRateTxt.TabIndex = 11
        Me.salesRateTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnAddSupplier
        '
        Me.btnAddSupplier.Location = New System.Drawing.Point(313, 124)
        Me.btnAddSupplier.Name = "btnAddSupplier"
        Me.btnAddSupplier.Size = New System.Drawing.Size(23, 23)
        Me.btnAddSupplier.TabIndex = 8
        Me.btnAddSupplier.Text = "+"
        Me.btnAddSupplier.UseVisualStyleBackColor = True
        '
        'btnAddCategory
        '
        Me.btnAddCategory.Location = New System.Drawing.Point(313, 71)
        Me.btnAddCategory.Name = "btnAddCategory"
        Me.btnAddCategory.Size = New System.Drawing.Size(23, 23)
        Me.btnAddCategory.TabIndex = 4
        Me.btnAddCategory.Text = "+"
        Me.btnAddCategory.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(38, 154)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(63, 13)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Description:"
        '
        'prodDescTxt
        '
        Me.prodDescTxt.Location = New System.Drawing.Point(107, 151)
        Me.prodDescTxt.Multiline = True
        Me.prodDescTxt.Name = "prodDescTxt"
        Me.prodDescTxt.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.prodDescTxt.Size = New System.Drawing.Size(200, 69)
        Me.prodDescTxt.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(53, 127)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(48, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Supplier:"
        '
        'supplierCombo
        '
        Me.supplierCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.supplierCombo.FormattingEnabled = True
        Me.supplierCombo.Items.AddRange(New Object() {"- Select Supplier -"})
        Me.supplierCombo.Location = New System.Drawing.Point(107, 124)
        Me.supplierCombo.Name = "supplierCombo"
        Me.supplierCombo.Size = New System.Drawing.Size(200, 21)
        Me.supplierCombo.TabIndex = 7
        '
        'prodDatePicker
        '
        Me.prodDatePicker.CustomFormat = "dd/MMMM/yyyy HH:mm"
        Me.prodDatePicker.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right
        Me.prodDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.prodDatePicker.Location = New System.Drawing.Point(107, 98)
        Me.prodDatePicker.Name = "prodDatePicker"
        Me.prodDatePicker.Size = New System.Drawing.Size(200, 20)
        Me.prodDatePicker.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(68, 104)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(33, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Date:"
        '
        'categoryCombo
        '
        Me.categoryCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.categoryCombo.FormattingEnabled = True
        Me.categoryCombo.Items.AddRange(New Object() {"- Select Category -"})
        Me.categoryCombo.Location = New System.Drawing.Point(107, 71)
        Me.categoryCombo.Name = "categoryCombo"
        Me.categoryCombo.Size = New System.Drawing.Size(200, 21)
        Me.categoryCombo.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(49, 76)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(52, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Category:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(23, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Product Name:"
        '
        'prodNameTxt
        '
        Me.prodNameTxt.Location = New System.Drawing.Point(107, 45)
        Me.prodNameTxt.Name = "prodNameTxt"
        Me.prodNameTxt.Size = New System.Drawing.Size(200, 20)
        Me.prodNameTxt.TabIndex = 2
        Me.prodNameTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'prodCodeTxt
        '
        Me.prodCodeTxt.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.prodCodeTxt.Location = New System.Drawing.Point(107, 19)
        Me.prodCodeTxt.Name = "prodCodeTxt"
        Me.prodCodeTxt.Size = New System.Drawing.Size(200, 20)
        Me.prodCodeTxt.TabIndex = 1
        Me.prodCodeTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(26, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Product Code:"
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(671, 334)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(75, 23)
        Me.btnUpdate.TabIndex = 25
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = True
        Me.btnUpdate.Visible = False
        '
        'MenuToolStripMenuItem
        '
        Me.MenuToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ListOfProductToolStripMenuItem, Me.ReturnProductToolStripMenuItem})
        Me.MenuToolStripMenuItem.Name = "MenuToolStripMenuItem"
        Me.MenuToolStripMenuItem.Size = New System.Drawing.Size(61, 20)
        Me.MenuToolStripMenuItem.Text = "Product"
        '
        'ListOfProductToolStripMenuItem
        '
        Me.ListOfProductToolStripMenuItem.Name = "ListOfProductToolStripMenuItem"
        Me.ListOfProductToolStripMenuItem.Size = New System.Drawing.Size(154, 22)
        Me.ListOfProductToolStripMenuItem.Text = "List Of Product"
        '
        'ReturnProductToolStripMenuItem
        '
        Me.ReturnProductToolStripMenuItem.Name = "ReturnProductToolStripMenuItem"
        Me.ReturnProductToolStripMenuItem.Size = New System.Drawing.Size(154, 22)
        Me.ReturnProductToolStripMenuItem.Text = "Return Product"
        '
        'UserManagementToolStripMenuItem
        '
        Me.UserManagementToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.addUserMenu, Me.ManageUserToolStripMenuItem})
        Me.UserManagementToolStripMenuItem.Name = "UserManagementToolStripMenuItem"
        Me.UserManagementToolStripMenuItem.Size = New System.Drawing.Size(116, 20)
        Me.UserManagementToolStripMenuItem.Text = "User Management"
        '
        'addUserMenu
        '
        Me.addUserMenu.Name = "addUserMenu"
        Me.addUserMenu.Size = New System.Drawing.Size(143, 22)
        Me.addUserMenu.Text = "Add User"
        '
        'ManageUserToolStripMenuItem
        '
        Me.ManageUserToolStripMenuItem.Name = "ManageUserToolStripMenuItem"
        Me.ManageUserToolStripMenuItem.Size = New System.Drawing.Size(143, 22)
        Me.ManageUserToolStripMenuItem.Text = "Manage User"
        '
        'AdminMenuStrip
        '
        Me.AdminMenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuToolStripMenuItem, Me.UserManagementToolStripMenuItem, Me.SignOutToolStripMenuItem, Me.EditProfileToolStripMenuItem})
        Me.AdminMenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.AdminMenuStrip.Name = "AdminMenuStrip"
        Me.AdminMenuStrip.Size = New System.Drawing.Size(776, 24)
        Me.AdminMenuStrip.TabIndex = 0
        Me.AdminMenuStrip.Text = "MenuStrip1"
        Me.AdminMenuStrip.Visible = False
        '
        'SignOutToolStripMenuItem
        '
        Me.SignOutToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.SignOutToolStripMenuItem.Name = "SignOutToolStripMenuItem"
        Me.SignOutToolStripMenuItem.Size = New System.Drawing.Size(65, 20)
        Me.SignOutToolStripMenuItem.Text = "Sign Out"
        '
        'UserMenuStrip
        '
        Me.UserMenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1, Me.SignOutToolStripMenuItem1, Me.editProfileStrip})
        Me.UserMenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.UserMenuStrip.Name = "UserMenuStrip"
        Me.UserMenuStrip.Size = New System.Drawing.Size(776, 24)
        Me.UserMenuStrip.TabIndex = 3
        Me.UserMenuStrip.Text = "MenuStrip1"
        Me.UserMenuStrip.Visible = False
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ListProductMenuItem, Me.ToolStripMenuItem3})
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(61, 20)
        Me.ToolStripMenuItem1.Text = "Product"
        '
        'ListProductMenuItem
        '
        Me.ListProductMenuItem.Name = "ListProductMenuItem"
        Me.ListProductMenuItem.Size = New System.Drawing.Size(154, 22)
        Me.ListProductMenuItem.Text = "List Of Product"
        '
        'ToolStripMenuItem3
        '
        Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        Me.ToolStripMenuItem3.Size = New System.Drawing.Size(154, 22)
        Me.ToolStripMenuItem3.Text = "Return Product"
        '
        'editProfileStrip
        '
        Me.editProfileStrip.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.editProfileStrip.Name = "editProfileStrip"
        Me.editProfileStrip.Size = New System.Drawing.Size(76, 20)
        Me.editProfileStrip.Text = "Edit Profile"
        '
        'SignOutToolStripMenuItem1
        '
        Me.SignOutToolStripMenuItem1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.SignOutToolStripMenuItem1.Name = "SignOutToolStripMenuItem1"
        Me.SignOutToolStripMenuItem1.Size = New System.Drawing.Size(65, 20)
        Me.SignOutToolStripMenuItem1.Text = "Sign Out"
        '
        'EditProfileToolStripMenuItem
        '
        Me.EditProfileToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.EditProfileToolStripMenuItem.Name = "EditProfileToolStripMenuItem"
        Me.EditProfileToolStripMenuItem.Size = New System.Drawing.Size(76, 20)
        Me.EditProfileToolStripMenuItem.Text = "Edit Profile"
        '
        'FormAdmin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(776, 415)
        Me.Controls.Add(Me.UserMenuStrip)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.AdminMenuStrip)
        Me.Controls.Add(Me.ProductManager)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.AdminMenuStrip
        Me.MaximizeBox = False
        Me.Name = "FormAdmin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "IMS - Administrator"
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ProductManager.ResumeLayout(False)
        Me.ProductManager.PerformLayout()
        CType(Me.prodQuantity, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.productPicture, System.ComponentModel.ISupportInitialize).EndInit()
        Me.AdminMenuStrip.ResumeLayout(False)
        Me.AdminMenuStrip.PerformLayout()
        Me.UserMenuStrip.ResumeLayout(False)
        Me.UserMenuStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents statusLabel As ToolStripStatusLabel
    Friend WithEvents ProductManager As GroupBox
    Friend WithEvents prodCodeTxt As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents categoryCombo As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents prodNameTxt As TextBox
    Friend WithEvents prodDatePicker As DateTimePicker
    Friend WithEvents Label4 As Label
    Friend WithEvents btnAddSupplier As Button
    Friend WithEvents btnAddCategory As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents prodDescTxt As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents supplierCombo As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents salesRateTxt As TextBox
    Friend WithEvents btnSave As Button
    Friend WithEvents Label10 As Label
    Friend WithEvents btnBrowseImg As Button
    Friend WithEvents btnRemoveImg As Button
    Friend WithEvents productPicture As PictureBox
    Friend WithEvents Label8 As Label
    Friend WithEvents prodQuantity As NumericUpDown
    Friend WithEvents purchaseRateTxt As TextBox
    Friend WithEvents btnReset As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents MenuToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ListOfProductToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReturnProductToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UserManagementToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents addUserMenu As ToolStripMenuItem
    Friend WithEvents AdminMenuStrip As MenuStrip
    Friend WithEvents btnResetDate As Button
    Friend WithEvents usernameLabel As ToolStripStatusLabel
    Friend WithEvents ManageUserToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UserMenuStrip As MenuStrip
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ListProductMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem3 As ToolStripMenuItem
    Friend WithEvents editProfileStrip As ToolStripMenuItem
    Friend WithEvents SignOutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SignOutToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents EditProfileToolStripMenuItem As ToolStripMenuItem
End Class
