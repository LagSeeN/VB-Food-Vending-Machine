Public Class TakeFood

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Private Sub BtnBuy_Click(sender As Object, e As EventArgs)
        'กลับไปหน้า home
    End Sub

    Private Sub BtnNotBuy_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub TakeFood_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class