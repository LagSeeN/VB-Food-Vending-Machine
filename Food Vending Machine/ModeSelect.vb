Public Class ModeSelect
    Private Sub AddProductBtn_Click(sender As Object, e As EventArgs) Handles AddProductBtn.Click
        Dim InsertItem As New InsertItem
        InsertItem.Show()
    End Sub

    Private Sub EditProductBtn_Click(sender As Object, e As EventArgs) Handles EditProductBtn.Click
        Dim InsertItem As New InsertItem(True)
        InsertItem.Show()
    End Sub

    Private Sub SellProductBtn_Click(sender As Object, e As EventArgs) Handles SellProductBtn.Click
        Dim TransactionViewer As New TransactionViewer
        TransactionViewer.Show()
    End Sub
End Class