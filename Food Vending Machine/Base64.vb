Imports System.IO
Public Class Base64
    Public Function ConvertBase64ToByteArray(base64 As String) As Byte()
        Return Convert.FromBase64String(base64) 'Convert the base64 back to byte array.
    End Function

    Public Function ConvertByteToImage(ByVal BA As Byte())
        Dim ms As MemoryStream = New MemoryStream(BA)
        Dim image = System.Drawing.Image.FromStream(ms)
        Return image
    End Function

    ''' <summary>
    ''' return base64 as string
    ''' </summary>
    Public Function ConvertImageToBase64(ByVal image As Image, ByVal format As System.Drawing.Imaging.ImageFormat) As String
        Using ms As New MemoryStream()
            image.Save(ms, format)
            Dim imageBytes As Byte() = ms.ToArray()
            Dim base64String As String = Convert.ToBase64String(imageBytes)
            Return base64String
        End Using
    End Function

End Class
