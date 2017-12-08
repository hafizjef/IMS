Imports MySql.Data.MySqlClient

Module UserModule
    Public Function AddNewUser(ByVal user As User)
        Try
            conn.Open()
            Dim cmd As New MySqlCommand("INSERT INTO user VALUES (NULL, @username, @password, @userType, @secretQ, @secretA)", conn)
            cmd.Parameters.AddWithValue("@username", user.Name)
            cmd.Parameters.AddWithValue("@password", user.Password)
            cmd.Parameters.AddWithValue("@userType", user.UserType)
            cmd.Parameters.AddWithValue("@secretQ", user.SecretQuestion)
            cmd.Parameters.AddWithValue("@secretA", user.SecretAnswer)
            cmd.Prepare()
            Return cmd.ExecuteNonQuery()
        Catch ex As Exception
            Return ex.Message
        Finally
            conn.Close()
        End Try
    End Function

    Public Function DeleteUser(userID As Integer)
        Using conn
            Try
                conn.Open()
                Dim sql = "DELETE FROM user WHERE userID=@id"
                Dim cmd As New MySqlCommand(sql, conn)
                cmd.Parameters.AddWithValue("@id", userID)
                cmd.Prepare()

                Return cmd.ExecuteNonQuery

            Catch ex As Exception
                Return ex.Message
            End Try
        End Using
    End Function

    Public Function GetAllUser()
        Using conn
            Try
                conn.Open()
                Dim sql = "SELECT * FROM user"
                Dim cmd As New MySqlCommand(sql, conn)
                Dim res As MySqlDataReader = cmd.ExecuteReader

                Dim users As New List(Of User)

                While (res.Read)
                    Dim user = New User()
                    user.ID = res.GetInt16(0)
                    user.Name = res.GetString(1)
                    user.Password = res.GetString(2)
                    user.UserType = res.GetString(3)
                    user.SecretQuestion = res.GetString(4)
                    user.SecretAnswer = res.GetString(5)

                    users.Add(user)
                End While

                Return users
            Catch ex As Exception
                Return ex.Message
            End Try
        End Using
    End Function

    Public Function UpdateUser(user As User)
        Using conn
            Try
                conn.Open()
                Dim sql As String = "UPDATE user SET username=@name, password=@pass,
                                    userType=@userType, secretQuestion=@secretQ,
                                    secretAnswer=@secretA WHERE userID=@id"
                Dim cmd As New MySqlCommand(sql, conn)

                cmd.Parameters.AddWithValue("@id", user.ID)
                cmd.Parameters.AddWithValue("@name", user.Name)
                cmd.Parameters.AddWithValue("@pass", user.Password)
                cmd.Parameters.AddWithValue("@userType", user.UserType)
                cmd.Parameters.AddWithValue("@secretQ", user.SecretQuestion)
                cmd.Parameters.AddWithValue("@secretA", user.SecretAnswer)

                cmd.Prepare()
                Return cmd.ExecuteNonQuery()

            Catch ex As Exception
                Return ex.Message
            End Try
        End Using
    End Function

    Public Function UpdateUserPassword(userid As Integer, password As String)
        Using conn
            Try
                conn.Open()
                Dim sql As String = "UPDATE user SET password=@password WHERE userID=@id"
                Dim cmd As New MySqlCommand(sql, conn)

                cmd.Parameters.AddWithValue("@id", userid)
                cmd.Parameters.AddWithValue("@password", password)

                cmd.Prepare()
                Return cmd.ExecuteNonQuery()

            Catch ex As Exception
                Return ex.Message
            End Try
        End Using
    End Function

    Public Function UpdateUserProfile(userid As Integer, password As String, secretQ As String, secretAns As String)
        Using conn
            Try
                conn.Open()
                Dim sql As String = "UPDATE user SET password=@password, secretQuestion=@secretQ, secretAnswer=@secretA WHERE userID=@id"
                Dim cmd As New MySqlCommand(sql, conn)

                cmd.Parameters.AddWithValue("@id", userid)
                cmd.Parameters.AddWithValue("@password", password)
                cmd.Parameters.AddWithValue("@secretQ", secretQ)
                cmd.Parameters.AddWithValue("@secretA", secretAns)

                cmd.Prepare()
                Return cmd.ExecuteNonQuery()

            Catch ex As Exception
                Return ex.Message
            End Try
        End Using
    End Function

    Public Function GetUserByName(username As String)
        Using conn
            Try
                conn.Open()
                Dim sql = "SELECT * FROM user WHERE username=@name LIMIT 1"
                Dim cmd As New MySqlCommand(sql, conn)
                cmd.Parameters.AddWithValue("@name", username)
                cmd.Prepare()

                Dim res As MySqlDataReader = cmd.ExecuteReader

                res.Read()

                Dim user = New User With {
                    .ID = res.GetInt16(0),
                    .Name = res.GetString(1),
                    .Password = res.GetString(2),
                    .UserType = res.GetString(3),
                    .SecretQuestion = res.GetString(4),
                    .SecretAnswer = res.GetString(5)
                }

                Return user

            Catch ex As Exception
                Return ex.Message
            End Try
        End Using
    End Function
End Module
