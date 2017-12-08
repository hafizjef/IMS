Public Class User

    Public Property ID As Integer
    Public Property Name As String
    Public Property Password As String
    Public Property SecretQuestion As String
    Public Property SecretAnswer As String

    Private mUserType

    Property UserType() As String
        Get
            Return mUserType
        End Get
        Set(value As String)
            If value.Equals("Admin") Then
                mUserType = "A"
            ElseIf value.Equals("Staff") Then
                mUserType = "S"
            Else
                mUserType = value
            End If
        End Set
    End Property

End Class
