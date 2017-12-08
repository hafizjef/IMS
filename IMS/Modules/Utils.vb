Imports System.IO
Imports System.Drawing.Imaging.ImageFormat
Imports System.Security.Cryptography

Module Utils
    Public Function getImageExt(image As Image)
        If (Jpeg.Equals(image.RawFormat)) Then
            Return ".jpg"
        ElseIf (Png.Equals(image.RawFormat)) Then
            Return ".png"
        Else
            Return ".notimage"
        End If
    End Function

    Public Function getImageHash(image As Image)
        Dim stream = New MemoryStream
        image.Save(stream, image.RawFormat)
        stream.Position = 0

        Dim sha = New SHA256Managed()
        Dim hash = sha.ComputeHash(stream)
        Return BitConverter.ToString(hash).Replace("-", String.Empty)
    End Function
End Module
