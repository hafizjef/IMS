Public Class FormLogin

    Public Sub initDBConnection()
        getDBConnection()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim login = DoUserLogin(userTxt.Text, pwdTxt.Text)

        If (login = 1) Then
            Dim adminForm = New FormAdmin(userTxt.Text)
            adminForm.Show()
            Me.Close()
        ElseIf (login = 2) Then
            Dim adminForm = New FormAdmin(userTxt.Text, True)
            adminForm.Show()
            Me.Close()
        ElseIf (login = 0) Then
            MsgBox("User Not Exist", MsgBoxStyle.Exclamation, "Authentication Error")
        ElseIf (login = 99) Then
            MsgBox("Invalid Credentials", MsgBoxStyle.Exclamation, "Authentication Error")
            pwdTxt.SelectAll()
        End If


    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        initDBConnection()
        userTxt.Select()
    End Sub

    Private Sub userTxt_TextChanged(sender As Object, e As EventArgs) Handles userTxt.TextChanged
        If userTxt.Text = String.Empty Or pwdTxt.Text = String.Empty Then
            btnLogin.Enabled = False
        Else
            btnLogin.Enabled = True
        End If
    End Sub

    Private Sub pwdTxt_TextChanged(sender As Object, e As EventArgs) Handles pwdTxt.TextChanged
        If userTxt.Text = String.Empty Or pwdTxt.Text = String.Empty Then
            btnLogin.Enabled = False
        Else
            btnLogin.Enabled = True
        End If
    End Sub

    Private Sub forgotLink_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles forgotLink.LinkClicked
        ForgotPassword.ShowDialog()
    End Sub
End Class
