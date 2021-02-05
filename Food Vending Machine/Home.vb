Public Class Home
    Private Sub Home_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub buyBtn_Click(sender As Object, e As EventArgs) Handles buyBtn.Click
        Payment.Show()
        Me.Hide()
    End Sub
End Class