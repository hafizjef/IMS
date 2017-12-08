Public Class AddUser

    Private mUser As User
    Private editMode = False

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Public Sub New(user As User)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        addUserGroup.Text = "Edit User Information"
        btnAddUser.Text = "Update User"
        Me.Text = "IMS - Edit User Info"
        editMode = True
        mUser = user

        userNameTxt.Text = user.Name
        passwordTxt.Text = user.Password
        rpasswordTxt.Text = user.Password
        secretAnsTxt.Text = user.SecretAnswer
    End Sub

    Private Sub AddUser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.AcceptButton = btnAddUser
        secretCombo.SelectedIndex = 0
        userTypeCombo.SelectedIndex = 0
        addUserGroup.Show()
        addUserGroup.BringToFront()
        userNameTxt.Select()
    End Sub

    Private Sub showPassword_CheckedChanged(sender As Object, e As EventArgs) Handles showPassword.CheckedChanged
        If (showPassword.Checked) Then
            passwordTxt.PasswordChar = ""
            rpasswordTxt.PasswordChar = ""
        Else
            passwordTxt.PasswordChar = "●"
            rpasswordTxt.PasswordChar = "●"
        End If
    End Sub

    Private Sub resetForm_Click(sender As Object, e As EventArgs) Handles resetForm.Click
        secretCombo.SelectedIndex = 0
        userTypeCombo.SelectedIndex = 0
        For Each tb As TextBox In addUserGroup.Controls.OfType(Of TextBox)()
            tb.Text = String.Empty
        Next
        userNameTxt.Select()
    End Sub

    Private Sub btnAddUser_Click(sender As Object, e As EventArgs) Handles btnAddUser.Click
        For Each tb As TextBox In addUserGroup.Controls.OfType(Of TextBox).OrderBy(Function(x) x.Top)
            If (tb.Text = String.Empty) Then
                MsgBox("Please fill required details", MsgBoxStyle.Critical, "Form Error")
                tb.Select()
                Return
            End If
        Next

        If (userTypeCombo.SelectedIndex = 0) Then
            MsgBox("Please Select User Type", MsgBoxStyle.Critical, "Form Error")
            userTypeCombo.Select()
            Return
        ElseIf (secretCombo.SelectedIndex = 0) Then
            MsgBox("Please Select Secret Question", MsgBoxStyle.Critical, "Form Error")
            secretCombo.Select()
            Return
        ElseIf (Not passwordTxt.Text.Equals(rpasswordTxt.Text)) Then
            MsgBox("Password Did Not Match", MsgBoxStyle.Critical, "Form Error")
            rpasswordTxt.SelectAll()
            rpasswordTxt.Select()
            Return
        End If

        Dim username = userNameTxt.Text
        Dim passwd = passwordTxt.Text
        Dim userType = userTypeCombo.Text
        Dim secretQuestion = secretCombo.Text
        Dim secretAnswer = secretAnsTxt.Text

        Dim user = New User With {
            .Name = username,
            .Password = passwd,
            .UserType = userType,
            .SecretQuestion = secretQuestion,
            .SecretAnswer = secretAnswer
        }

        Dim result, successMsg
        If editMode Then
            user.ID = mUser.ID
            result = UpdateUser(user)
            successMsg = String.Format("User: {0} Updated", user.Name)
        Else
            result = AddNewUser(user)
            successMsg = String.Format("User: {0} Added", user.Name)
        End If



        If (Integer.TryParse(result, 1)) Then
            MsgBox(successMsg, MsgBoxStyle.Information, "Success")
            If editMode Then
                Me.Close()
                UserViewer.RefreshData()
            End If
            secretCombo.SelectedIndex = 0
            userTypeCombo.SelectedIndex = 0
            For Each tb As TextBox In addUserGroup.Controls.OfType(Of TextBox)()
                tb.Text = String.Empty
            Next
        Else
            MsgBox(result, MsgBoxStyle.Exclamation, "Database Error")
        End If
    End Sub
End Class