Imports System.IO
Imports MySql.Data.MySqlClient

Module ImageModel

    Public Function SaveImageToDB(image As Image)

        Using conn
            Try
                conn.Open()
                ' Check if image exist, return imageID else add to DB

                Dim sql = "SELECT imageID FROM image WHERE hash=@hash LIMIT 1"
                Dim cmd As New MySqlCommand(sql, conn)
                cmd.Parameters.AddWithValue("@hash", getImageHash(image))
                cmd.Prepare()

                Dim result As MySqlDataReader = cmd.ExecuteReader()

                result.Read()

                If (Not result.HasRows) Then
                    result.Close()
                    Dim sqlInsert As String = "INSERT INTO image VALUES (NULL, @image, @hash)"
                    Dim cmdInsert As New MySqlCommand(sqlInsert, conn)

                    Dim ms As New MemoryStream()
                    image.Save(ms, image.RawFormat)
                    Dim data As Byte() = ms.GetBuffer()
                    cmdInsert.Parameters.AddWithValue("@image", data)
                    cmdInsert.Parameters.AddWithValue("@hash", getImageHash(image))
                    cmdInsert.Prepare()

                    cmdInsert.ExecuteNonQuery()
                    Return cmdInsert.LastInsertedId
                Else
                    Return result.GetInt16(0)
                End If

            Catch ex As Exception
                Return ex.Message
            End Try
        End Using
    End Function

    Public Function GetImage(productID As Integer)
        Using conn
            Try
                conn.Open()

                Dim sql = "SELECT image.content FROM product INNER JOIN image ON product.imageID = image.imageID WHERE productID = @id"
                Dim cmd As New MySqlCommand(sql, conn)
                cmd.Parameters.AddWithValue("@id", productID)
                cmd.Prepare()

                Dim imageData As Byte() = DirectCast(cmd.ExecuteScalar, Byte())

                If Not imageData Is Nothing Then
                    Using ms As New MemoryStream(imageData, 0, imageData.Length)
                        ms.Write(imageData, 0, imageData.Length)
                        Return Image.FromStream(ms)
                    End Using
                End If

                Return "No Data in Database"

            Catch ex As Exception
                Return ex.Message
            End Try
        End Using
    End Function
End Module
