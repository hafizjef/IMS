Public Class EditProfile
    Private user As User
    Public Sub New(user As User)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.user = user
    End Sub
    Private Sub EditProfile_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        secretCombo.SelectedIndex = 0

        passTxt.Text = user.Password
        secretAnsTxt.Text = user.SecretAnswer
        userNameTxt.Text = user.Name

    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If (passTxt.Text Is Nothing) Then
            MsgBox("Please fill in your new password", MsgBoxStyle.Critical, "Form Error")
            passTxt.Select()
            Return
        ElseIf (secretCombo.SelectedIndex) = 0 Then
            MsgBox("Please Select your secret question", MsgBoxStyle.Critical, "Form Error")
            secretCombo.Select()
            Return
        ElseIf (secretAnsTxt.Text Is Nothing) Then
            MsgBox("Please fill in your new Secret Answer", MsgBoxStyle.Critical, "Form Error")
            secretAnsTxt.Select()
            Return
        End If

        Dim result = UpdateUserProfile(user.ID, passTxt.Text, secretCombo.Text, secretAnsTxt.Text)

        If (result = 1) Then
            MsgBox(String.Format("{0} user profile updated", user.Name), MsgBoxStyle.Information, "Profile Updated")
            Me.Close()
        Else
            MsgBox(result)
        End If

    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub
End Class