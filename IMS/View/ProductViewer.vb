Imports System.Globalization.NumberFormatInfo

Public Class ProductViewer

    Private mouseLocation As DataGridViewCellEventArgs

    Private Sub ProductViewer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RefreshData()
    End Sub

    Public Sub RefreshData()

        dgView.Rows.Clear()
        Dim result = GetAllProducts()

        If (result.GetType Is GetType(String)) Then
            MsgBox(result)
        Else
            For Each item As Product In result
                dgView.Rows.Add(item.ID, item.Code, item.Name, item.Description, item.Category,
                                item.Rate, item.SaleRate, (item.SaleRate * 1.06), (item.SaleRate * 1.06 * item.Quantity),
                                item.Quantity, item.ProductDate)
            Next
            lblTotalItems.Text = result.Count.ToString
        End If

    End Sub

    Private Sub RefreshToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RefreshToolStripMenuItem.Click
        RefreshData()
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click

    End Sub

    ' Deal with hovering over a cell.
    Private Sub dataGridView_CellMouseEnter(ByVal sender As Object, ByVal location As DataGridViewCellEventArgs) Handles dgView.CellMouseEnter
        mouseLocation = location
    End Sub

    Private Sub SelectToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SelectToolStripMenuItem.Click
        Dim pID = dgView.Rows(mouseLocation.RowIndex).Cells(0).Value
        Dim pName = dgView.Rows(mouseLocation.RowIndex).Cells("prodName").Value

        Dim imgViewer = New ImageViewer(GetImage(pID), pName)
        imgViewer.ShowDialog()
    End Sub

    Private Sub EditToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditToolStripMenuItem.Click
        Dim pID = dgView.Rows(mouseLocation.RowIndex).Cells(0).Value

        Dim result = GetProductByID(pID)

        If (result.GetType() Is GetType(Product)) Then
            Dim product As Product = result
            Dim productEditor = New FormAdmin(product)
            productEditor.ShowDialog()
        End If


    End Sub

    Private Sub DeleteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteToolStripMenuItem.Click

        Dim pID = dgView.Rows(mouseLocation.RowIndex).Cells(0).Value
        Dim pName = dgView.Rows(mouseLocation.RowIndex).Cells("prodName").Value

        Dim msgResult = MsgBox("Confirm delete product?" + vbCrLf + "Product ID: " + pID.ToString + vbCrLf +
                               "Product Name: " + pName, MsgBoxStyle.YesNo, "Delete Product")

        If msgResult = MsgBoxResult.Yes Then
            Dim result = DeleteProduct(pID)
            If (result.GetType() Is GetType(Integer)) Then
                MsgBox("Deleted Product: " + pName, MsgBoxStyle.Information, "Delete Success")
                RefreshData()
            Else
                MsgBox(result, MsgBoxStyle.Critical, "Database Error")
            End If
        End If

    End Sub
End Class