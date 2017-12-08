Imports MySql.Data.MySqlClient

Module Database
    Public conn As New MySqlConnection

    Sub getDBConnection()
        If Not conn Is Nothing Then conn.Close()
        conn.ConnectionString = String.Format("server={0}; user id={1}; password={2}; database={3}; pooling=false", dbServer, dbUser, dbPass, dbName)
        Try
            conn.Open()
        Catch ex As Exception
            MsgBox(ex.Message + vbCrLf + "Please Check Your Database Connection and Restart The App", MsgBoxStyle.Critical, "Database Error")
            End
        End Try
        conn.Close()
    End Sub

    Public Function DoUserLogin(ByVal username As String, ByVal password As String)
        Try
            conn.Open()
            Dim cmd As New MySqlCommand("SELECT username, password, userType FROM user WHERE username=@usernameval", conn)
            cmd.Parameters.AddWithValue("@usernameval", username)
            cmd.Parameters.AddWithValue("@passval", password)
            cmd.Prepare()
            Dim res As MySqlDataReader = cmd.ExecuteReader()

            res.Read()

            If (Not res.HasRows) Then
                Return 0
            End If

            Dim userType = res.GetString("userType")
            Dim userPass = res.GetString("password")

            ' User Authentication
            ' Return 1 if user = STAFF
            ' Return 2 if user = ADMIN
            ' Return 99 if password is invalid
            ' Else return 0
            If (userType.Equals("S")) Then
                If (userPass.Equals(password)) Then
                    Return 1
                Else
                    Return 99
                End If
            ElseIf (userType.Equals("A")) Then
                If (userPass.Equals(password)) Then
                    Return 2
                Else
                    Return 99
                End If
            Else
                Return 0
            End If

            res.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
            Return 0
        Finally
            conn.Close()
        End Try
    End Function
End Module
