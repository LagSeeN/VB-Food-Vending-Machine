Public Class ModeSelect
    Private Sub AddProductBtn_Click(sender As Object, e As EventArgs) Handles AddProductBtn.Click
        Dim InsertItem As New InsertItem
        InsertItem.Show()
        Me.Close()
    End Sub

    Private Sub EditProductBtn_Click(sender As Object, e As EventArgs) Handles EditProductBtn.Click
        Dim InsertItem As New InsertItem
        InsertItem.Show()
        Me.Close()
    End Sub

    Private Sub SellProductBtn_Click(sender As Object, e As EventArgs) Handles SellProductBtn.Click
        Dim Home As New Home
        Home.Show()
        Me.Close()
    End Sub
End Class