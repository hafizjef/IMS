Public Class ImageViewer
    Public Sub New(ByVal image As Image, Optional title As String = "")

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        productPicture.Image = image

        Me.Text += " " + title
    End Sub
    Private Sub exitBtn_Click(sender As Object, e As EventArgs) Handles exitBtn.Click
        Me.Close()
    End Sub
End Class