Public Class ForgotPassword
    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        For Each tb As TextBox In Controls.OfType(Of TextBox).OrderBy(Function(x) x.Top)
            If (tb.Text = String.Empty) Then
                MsgBox("Please fill all details", MsgBoxStyle.Critical, "Form Error")
                tb.Select()
                Return
            End If
        Next
        If (secretCombo.SelectedIndex = 0) Then
            MsgBox("Please Select Category", MsgBoxStyle.Critical, "Form Error")
            secretCombo.Select()
            Return
        End If

        Dim username = userNameTxt.Text
        Dim secretAns = secretAnsTxt.Text
        Dim secretQ = secretCombo.Text

        Dim result = GetUserByName(username)

        If (result.GetType Is GetType(User)) Then
            If (result.SecretAnswer.Equals(secretAns) And result.SecretQuestion.Equals(secretQ)) Then
                Dim newPass As String = InputBox("Insert New Password", "Reset Password")
                If newPass.Length = 0 Then Return

                Dim verifyPass As String = InputBox("Repeat New Password", "Reset Password")
                If verifyPass.Length = 0 Then Return

                If (newPass.Equals(verifyPass)) Then
                    Dim chPass = UpdateUserPassword(result.ID, newPass)
                    If (chPass.GetType Is GetType(Integer)) Then
                        MsgBox(String.Format("Password for {0} updated", result.Name), MsgBoxStyle.Information, "Password Updated")
                        Me.Close()
                    Else
                        MsgBox(chPass)
                    End If
                Else
                    MsgBox("Password not match")
                End If
            Else
                MsgBox("Invalid Details")
            End If
        Else
            MsgBox(result)
        End If

    End Sub

    Private Sub ForgotPassword_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        secretCombo.SelectedIndex = 0
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub
End Class