Imports System.Globalization.NumberFormatInfo

Public Class FormAdmin

    Private productID As Integer
    Private editMode = False
    Private adminMode = False
    Private winTitle = ""
    Private username = ""

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Public Sub New(ByVal loggedUser As String, Optional isAdmin As Boolean = False)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        username = loggedUser
        usernameLabel.Text = loggedUser

        btnSave.Visible = True
        btnSave.BringToFront()
        btnUpdate.Visible = False

        Me.AcceptButton = btnSave
        adminMode = isAdmin

    End Sub

    Public Sub New(ByVal product As Product)
        InitializeComponent()

        productID = product.ID
        editMode = True

        statusLabel.Text = "Editing Product: " + product.ID.ToString
        usernameLabel.Visible = False

        btnSave.Visible = False
        btnUpdate.BringToFront()
        btnUpdate.Visible = True
        Me.AcceptButton = btnUpdate
        AdminMenuStrip.Visible = False
        ProductManager.Text = "Update Product"
        ProductManager.Size = New Size(752, 378)
        ProductManager.Location = New Point(12, 12)

        productPicture.Image = GetImage(product.ID)

        prodCodeTxt.Text = product.Code
        prodNameTxt.Text = product.Name
        prodDatePicker.Value = product.ProductDate
        prodDescTxt.Text = product.Description
        purchaseRateTxt.Text = String.Format(System.Globalization.CultureInfo.CurrentCulture, "{0:C2}", product.Rate)
        salesRateTxt.Text = String.Format(System.Globalization.CultureInfo.CurrentCulture, "{0:C2}", product.SaleRate)
        prodQuantity.Value = product.Quantity

    End Sub

    Private Sub addUserMenu_Click(sender As Object, e As EventArgs) Handles addUserMenu.Click
        AddUser.ShowDialog()
    End Sub

    Private Sub btnBrowseImg_Click(sender As Object, e As EventArgs) Handles btnBrowseImg.Click
        Dim productImage As New OpenFileDialog
        productImage.Filter = "Image Files|*.png;*.jpg"
        productImage.Title = "Select Product Image"

        If productImage.ShowDialog() = DialogResult.OK Then
            productPicture.Image = New Bitmap(productImage.OpenFile)
        End If
    End Sub

    Private Sub btnRemoveImg_Click(sender As Object, e As EventArgs) Handles btnRemoveImg.Click
        If Not IsNothing(productPicture.Image) Then productPicture.Image.Dispose()
        productPicture.Image = My.Resources.imagePlaceholder
    End Sub

    Private Sub salesRateTxt_Leave(sender As Object, e As EventArgs) Handles salesRateTxt.Leave
        salesRateTxt.Text = salesRateTxt.Text.Replace(CurrentInfo.CurrencySymbol, "")
        Dim nonNumericCharacters As New System.Text.RegularExpressions.Regex("[^0-9\,\.]")
        salesRateTxt.Text = nonNumericCharacters.Replace(salesRateTxt.Text, String.Empty)
        Dim value As Double
        If (Double.TryParse(salesRateTxt.Text, value)) Then
            salesRateTxt.Text = String.Format(System.Globalization.CultureInfo.CurrentCulture, "{0:C2}", value)
        Else
            salesRateTxt.Text = String.Empty
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        For Each tb As TextBox In ProductManager.Controls.OfType(Of TextBox).OrderBy(Function(x) x.Top)
            If (tb.Text = String.Empty) Then
                MsgBox("Please fill all details", MsgBoxStyle.Critical, "Form Error")
                tb.Select()
                Return
            End If
        Next
        If (categoryCombo.SelectedIndex = 0) Then
            MsgBox("Please Select Category", MsgBoxStyle.Critical, "Form Error")
            categoryCombo.Select()
            Return
        ElseIf (supplierCombo.SelectedIndex = 0) Then
            MsgBox("Please Select Supplier", MsgBoxStyle.Critical, "Form Error")
            supplierCombo.Select()
            Return
        End If

        Dim purchaseRate = purchaseRateTxt.Text.Replace(CurrentInfo.CurrencySymbol, "")
        Dim salesRate = salesRateTxt.Text.Replace(CurrentInfo.CurrencySymbol, "")

        Dim Product = New Product With {
            .Name = prodNameTxt.Text,
            .Code = prodCodeTxt.Text,
            .Category = categoryCombo.Text,
            .Description = prodDescTxt.Text,
            .ProductDate = prodDatePicker.Value,
            .Quantity = Integer.Parse(prodQuantity.Value),
            .Rate = Double.Parse(purchaseRate),
            .SaleRate = Double.Parse(salesRate),
            .Supplier = supplierCombo.Text
        }


        Dim result = AddProduct(Product, productPicture.Image)

        If (result.GetType() Is GetType(String)) Then
            MsgBox(result, MsgBoxStyle.Critical, "Database Error")
        ElseIf (result.GetType() Is GetType(Integer)) Then
            MsgBox(Product.ToString + " added successfully", MsgBoxStyle.Information, "Product Added")

            prodCodeTxt.Select()

            RefreshData()
            prodQuantity.Value = 1
            prodDatePicker.ResetText()

            If Not IsNothing(productPicture.Image) Then productPicture.Image.Dispose()
            productPicture.Image = My.Resources.imagePlaceholder

            For Each tb As TextBox In ProductManager.Controls.OfType(Of TextBox).OrderBy(Function(x) x.Top)
                tb.Text = String.Empty
            Next

        End If

    End Sub

    Private Sub purchaseRateTxt_Leave(sender As Object, e As EventArgs) Handles purchaseRateTxt.Leave
        purchaseRateTxt.Text = purchaseRateTxt.Text.Replace(CurrentInfo.CurrencySymbol, "")
        Dim nonNumericCharacters As New System.Text.RegularExpressions.Regex("[^0-9\,\.]")
        purchaseRateTxt.Text = nonNumericCharacters.Replace(purchaseRateTxt.Text, String.Empty)
        Dim value As Double
        If (Double.TryParse(purchaseRateTxt.Text, value)) Then
            purchaseRateTxt.Text = String.Format(System.Globalization.CultureInfo.CurrentCulture, "{0:C2}", value)
        Else
            purchaseRateTxt.Text = String.Empty
        End If
    End Sub

    Private Sub FormAdmin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If adminMode And Not editMode Then
            AdminMenuStrip.Visible = True
            winTitle = "IMS - Administrator"
        ElseIf Not adminMode And Not editMode Then
            UserMenuStrip.Visible = True
            winTitle = "IMS - Staff"
        ElseIf editMode Then
            AdminMenuStrip.Visible = False
            UserMenuStrip.Visible = False
            winTitle = "IMS - Edit Mode"
        End If

        Me.Text = winTitle

        RefreshData()
    End Sub

    Public Sub RefreshData()

        categoryCombo.Items.Clear()
        supplierCombo.Items.Clear()

        categoryCombo.Items.Add("- Select Category -")
        supplierCombo.Items.Add("- Select Supplier -")


        categoryCombo.Items.AddRange(getProductCategory)
        supplierCombo.Items.AddRange(getSuppliers)

        categoryCombo.SelectedIndex = 0
        supplierCombo.SelectedIndex = 0
    End Sub

    Private Sub btnAddCategory_Click(sender As Object, e As EventArgs) Handles btnAddCategory.Click

        Dim newCategory As String = InputBox("Add new product category", "New Category", "Category")
        Dim exist = False

        If (newCategory.Equals(String.Empty)) Then
            Return
        End If

        For Each value As String In categoryCombo.Items
            If (value.Equals(newCategory)) Then
                exist = True
            End If
        Next

        If (Not exist) Then
            categoryCombo.Items.Add(newCategory)
        End If

        categoryCombo.SelectedItem = newCategory
    End Sub

    Private Sub btnAddSupplier_Click(sender As Object, e As EventArgs) Handles btnAddSupplier.Click
        Dim newSupplier As String = InputBox("Add new product supplier", "New Supplier", "Supplier")
        Dim exist = False

        If (newSupplier.Equals(String.Empty)) Then
            Return
        End If

        For Each value As String In supplierCombo.Items
            If (value.Equals(newSupplier)) Then
                exist = True
            End If
        Next

        If (Not exist) Then
            supplierCombo.Items.Add(newSupplier)
        End If

        supplierCombo.SelectedItem = newSupplier
    End Sub


    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        prodCodeTxt.Select()
        categoryCombo.SelectedIndex = 0
        supplierCombo.SelectedIndex = 0
        prodQuantity.Value = 1
        prodDatePicker.ResetText()

        For Each tb As TextBox In ProductManager.Controls.OfType(Of TextBox).OrderBy(Function(x) x.Top)
            tb.Text = String.Empty
        Next
    End Sub

    Private Sub ListOfProductToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListOfProductToolStripMenuItem.Click
        Dim productView As New ProductViewer()
        AddHandler productView.FormClosed, AddressOf childClosed
        productView.ShowDialog()
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        For Each tb As TextBox In ProductManager.Controls.OfType(Of TextBox).OrderBy(Function(x) x.Top)
            If (tb.Text = String.Empty) Then
                MsgBox("Please fill all details", MsgBoxStyle.Critical, "Form Error")
                tb.Select()
                Return
            End If
        Next
        If (categoryCombo.SelectedIndex = 0) Then
            MsgBox("Please Select Category", MsgBoxStyle.Critical, "Form Error")
            categoryCombo.Select()
            Return
        ElseIf (supplierCombo.SelectedIndex = 0) Then
            MsgBox("Please Select Supplier", MsgBoxStyle.Critical, "Form Error")
            supplierCombo.Select()
            Return
        End If

        Dim purchaseRate = purchaseRateTxt.Text.Replace(CurrentInfo.CurrencySymbol, "")
        Dim salesRate = salesRateTxt.Text.Replace(CurrentInfo.CurrencySymbol, "")

        Dim Product = New Product With {
            .ID = productID,
            .Name = prodNameTxt.Text,
            .Code = prodCodeTxt.Text,
            .Category = categoryCombo.Text,
            .Description = prodDescTxt.Text,
            .ProductDate = prodDatePicker.Value,
            .Quantity = Integer.Parse(prodQuantity.Value),
            .Rate = Double.Parse(purchaseRate),
            .SaleRate = Double.Parse(salesRate),
            .Supplier = supplierCombo.Text
        }


        Dim result = UpdateProduct(Product, productPicture.Image)

        If (result.GetType() Is GetType(String)) Then
            MsgBox(result, MsgBoxStyle.Critical, "Database Error")
        ElseIf (result.GetType() Is GetType(Integer)) Then
            MsgBox(Product.ToString + " updated successfully", MsgBoxStyle.Information, "Product Updated")

            ProductViewer.RefreshData()
            Me.Close()


        End If
    End Sub

    Private Sub btnResetDate_Click(sender As Object, e As EventArgs) Handles btnResetDate.Click
        prodDatePicker.ResetText()
    End Sub

    Private Sub ManageUserToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ManageUserToolStripMenuItem.Click
        UserViewer.ShowDialog()
    End Sub

    Private Sub ListProductMenuItem_Click(sender As Object, e As EventArgs) Handles ListProductMenuItem.Click
        Dim productView As New ProductViewer()
        AddHandler productView.FormClosed, AddressOf childClosed
        productView.ShowDialog()
    End Sub

    Private Sub childClosed()
        RefreshData()
    End Sub

    Private Sub SignOutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SignOutToolStripMenuItem.Click
        FormLogin.Show()
        Me.Close()
    End Sub

    Private Sub SignOutToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles SignOutToolStripMenuItem1.Click
        FormLogin.Show()
        Me.Close()
    End Sub

    Private Sub editProfileStrip_Click(sender As Object, e As EventArgs) Handles editProfileStrip.Click
        Dim result = GetUserByName(username)

        If (result.GetType Is GetType(User)) Then
            Dim editProfile = New EditProfile(result)
            editProfile.ShowDialog()
        End If
    End Sub

    Private Sub EditProfileToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditProfileToolStripMenuItem.Click
        Dim result = GetUserByName(username)

        If (result.GetType Is GetType(User)) Then
            Dim editProfile = New EditProfile(result)
            editProfile.ShowDialog()
        End If
    End Sub
End Class