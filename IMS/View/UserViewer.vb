Public Class UserViewer

    Private mouseLocation As DataGridViewCellEventArgs
    Private UserList As List(Of User)

    Private Sub UserViewer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RefreshData()
    End Sub

    ' Deal with hovering over a cell.
    Private Sub dataGridView_CellMouseEnter(ByVal sender As Object, ByVal location As DataGridViewCellEventArgs) Handles userDGView.CellMouseEnter
        mouseLocation = location
    End Sub

    Public Sub RefreshData()
        If UserList IsNot Nothing Then UserList.Clear()

        userDGView.Rows.Clear()
        Dim result = GetAllUser()

        If (result.GetType() Is GetType(String)) Then
            MsgBox(result)
        Else
            UserList = result
            For Each user As User In result
                userDGView.Rows.Add(user.ID, user.Name, user.UserType,
                                    user.SecretQuestion, user.SecretAnswer)
            Next
            userCountLbl.Text = result.Count.ToString
        End If
    End Sub

    Private Sub RefreshToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RefreshToolStripMenuItem.Click
        RefreshData()
    End Sub

    Private Sub DeleteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteToolStripMenuItem.Click
        Dim uID = userDGView.Rows(mouseLocation.RowIndex).Cells(0).Value
        Dim uName = userDGView.Rows(mouseLocation.RowIndex).Cells("userName").Value

        Dim msgResult = MsgBox("Confirm delete user?" + vbCrLf + "User ID: " + uID.ToString + vbCrLf +
                               "User Name: " + uName, MsgBoxStyle.YesNo, "Delete User")

        If (msgResult = MsgBoxResult.Yes) Then
            Dim result = DeleteUser(uID)
            If (result.GetType() Is GetType(Integer)) Then
                MsgBox(String.Format("Deleted {0} User: {1}", result, uName),
                       MsgBoxStyle.Information, "Delete Success")
                RefreshData()
            Else
                MsgBox(result, MsgBoxStyle.Critical, "Database Error")
            End If
        End If

    End Sub

    Private Sub EditToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditToolStripMenuItem.Click
        Dim uID = userDGView.Rows(mouseLocation.RowIndex).Cells(0).Value

        Try
            For Each user As User In UserList
                If user.ID = uID Then
                    Dim editUser = New AddUser(user)
                    editUser.ShowDialog()
                End If
            Next
        Catch ex As Exception

        End Try
    End Sub
End Class