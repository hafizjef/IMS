Public Class Product

    Public Property ID As Integer
    Public Property Name As String
    Public Property Code As String
    Public Property ImageID As String
    Public Property Category As String
    Public Property ProductDate As Date
    Public Property Supplier As String
    Public Property Description As String
    Public Property Rate As Double
    Public Property SaleRate As Double
    Public Property Quantity As Integer

    Public Overrides Function ToString() As String
        Return Name
    End Function

End Class
