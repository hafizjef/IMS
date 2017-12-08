Imports MySql.Data.MySqlClient

Module ProductModel
    Public Function getProductCategory()
        Using conn
            Dim categoryList As New List(Of String)
            Try
                conn.Open()
                Dim cmd As New MySqlCommand("SELECT category FROM product GROUP BY category", conn)
                Dim res As MySqlDataReader = cmd.ExecuteReader

                While (res.Read)
                    categoryList.Add(res.GetString(0))
                End While

                Return categoryList.ToArray

            Catch ex As Exception
                MsgBox(ex.Message)
                Return categoryList.ToArray
            End Try
        End Using
    End Function

    Public Function getSuppliers()
        Using conn
            Dim supplierList As New List(Of String)
            Try
                conn.Open()
                Dim cmd As New MySqlCommand("SELECT supplier FROM product GROUP BY supplier", conn)
                Dim res As MySqlDataReader = cmd.ExecuteReader

                While (res.Read)
                    supplierList.Add(res.GetString(0))
                End While

                Return supplierList.ToArray

            Catch ex As Exception
                MsgBox(ex.Message)
                Return supplierList.ToArray
            End Try
        End Using
    End Function

    Public Function AddProduct(product As Product, image As Image)

        Dim result = SaveImageToDB(image)

        If (result.GetType() Is GetType(String)) Then
            Return result
        Else
            Using conn
                Try
                    conn.Open()
                    Dim sql As String = "INSERT INTO product VALUES (NULL, @name, @code, @category,
                            @supplier, @desc, @date, @qty, @rate, @saleRate, @image)"
                    Dim cmd As New MySqlCommand(sql, conn)

                    cmd.Parameters.AddWithValue("@name", product.Name)
                    cmd.Parameters.AddWithValue("@code", product.Code)
                    cmd.Parameters.AddWithValue("@category", product.Category)
                    cmd.Parameters.AddWithValue("@supplier", product.Supplier)
                    cmd.Parameters.AddWithValue("@desc", product.Description)
                    cmd.Parameters.AddWithValue("@date", product.ProductDate)
                    cmd.Parameters.AddWithValue("@qty", product.Quantity)
                    cmd.Parameters.AddWithValue("@rate", product.Rate)
                    cmd.Parameters.AddWithValue("@saleRate", product.SaleRate)
                    cmd.Parameters.AddWithValue("@image", result)

                    cmd.Prepare()
                    Return cmd.ExecuteNonQuery()

                Catch ex As Exception
                    Return ex.Message
                End Try
            End Using
        End If
    End Function

    Public Function GetAllProducts()
        Using conn
            Try
                conn.Open()
                Dim cmd As New MySqlCommand("SELECT * FROM product", conn)
                Dim res As MySqlDataReader = cmd.ExecuteReader

                Dim products = New List(Of Product)


                While (res.Read)
                    Dim product = New Product
                    product.ID = res.GetInt16(0)
                    product.Code = res.GetString("code")
                    product.Name = res.GetString("name")
                    product.Description = res.GetString("description")
                    product.Quantity = res.GetInt16("quantity")
                    product.Category = res.GetString("category")
                    product.Rate = res.GetDouble("rate")
                    product.SaleRate = res.GetDouble("saleRate")
                    product.ProductDate = res.GetDateTime("date")
                    products.Add(product)
                End While

                Return products
            Catch ex As Exception
                Return ex.Message
            End Try
        End Using
    End Function

    Public Function GetProductByID(productID As Integer)
        Using conn
            Try
                conn.Open()
                Dim cmd As New MySqlCommand("SELECT * FROM product WHERE productID = @id", conn)
                cmd.Parameters.AddWithValue("@id", productID)
                cmd.Prepare()

                Dim res As MySqlDataReader = cmd.ExecuteReader
                res.Read()

                Dim product = New Product

                If (res.HasRows) Then
                    product.ID = res.GetInt16(0)
                    product.Code = res.GetString("code")
                    product.Name = res.GetString("name")
                    product.Description = res.GetString("description")
                    product.Quantity = res.GetInt16("quantity")
                    product.Category = res.GetString("category")
                    product.Rate = res.GetDouble("rate")
                    product.SaleRate = res.GetDouble("saleRate")
                    product.ProductDate = res.GetDateTime("date")
                Else
                    Return "Product not exist"
                End If

                Return product

            Catch ex As Exception
                Return ex.Message
            End Try
        End Using
    End Function

    Public Function UpdateProduct(product As Product, image As Image)

        Dim result = SaveImageToDB(image)

        If (result.GetType() Is GetType(String)) Then
            Return result
        Else
            Using conn
                Try
                    conn.Open()
                    Dim sql As String = "UPDATE product SET name=@name, code=@code, category=@category,
                            supplier=@supplier, description=@desc, date=@date, quantity=@qty, rate=@rate, 
                            saleRate=@saleRate, imageID=@image WHERE productID=@id"
                    Dim cmd As New MySqlCommand(sql, conn)

                    cmd.Parameters.AddWithValue("@id", product.ID)
                    cmd.Parameters.AddWithValue("@name", product.Name)
                    cmd.Parameters.AddWithValue("@code", product.Code)
                    cmd.Parameters.AddWithValue("@category", product.Category)
                    cmd.Parameters.AddWithValue("@supplier", product.Supplier)
                    cmd.Parameters.AddWithValue("@desc", product.Description)
                    cmd.Parameters.AddWithValue("@date", product.ProductDate)
                    cmd.Parameters.AddWithValue("@qty", product.Quantity)
                    cmd.Parameters.AddWithValue("@rate", product.Rate)
                    cmd.Parameters.AddWithValue("@saleRate", product.SaleRate)
                    cmd.Parameters.AddWithValue("@image", result)

                    cmd.Prepare()
                    Return cmd.ExecuteNonQuery()

                Catch ex As Exception
                    Return ex.Message
                End Try
            End Using
        End If
    End Function

    Public Function DeleteProduct(productID As Integer)
        Using conn
            Try
                conn.Open()
                Dim sql = "DELETE FROM product WHERE productID=@id"
                Dim cmd As New MySqlCommand(sql, conn)
                cmd.Parameters.AddWithValue("@id", productID)
                cmd.Prepare()

                Return cmd.ExecuteNonQuery

            Catch ex As Exception
                Return ex.Message
            End Try
        End Using
    End Function
End Module
