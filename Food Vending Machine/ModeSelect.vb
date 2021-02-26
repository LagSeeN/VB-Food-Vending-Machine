Imports System.Drawing.Text
Public Class ModeSelect
    Private Sub AddProductBtn_Click(sender As Object, e As EventArgs) Handles AddProductBtn.Click
        Dim InsertItem As New InsertItem
        InsertItem.ShowDialog()
    End Sub

    Private Sub EditProductBtn_Click(sender As Object, e As EventArgs) Handles EditProductBtn.Click
        Dim InsertItem As New InsertItem(True)
        InsertItem.ShowDialog()
    End Sub

    Private Sub SellProductBtn_Click(sender As Object, e As EventArgs) Handles SellProductBtn.Click
        Dim TransactionViewer As New TransactionViewer
        TransactionViewer.ShowDialog()
    End Sub
    Private Sub Fontload()
        Dim colFont As New PrivateFontCollection
        colFont.AddFontFile(Application.StartupPath + "Font\FC Lamoon Regular ver 1.00.ttf")

        AddProductBtn.Font = New Font(colFont.Families(0), 20, FontStyle.Bold)
        SellProductBtn.Font = New Font(colFont.Families(0), 20, FontStyle.Bold)
        EditProductBtn.Font = New Font(colFont.Families(0), 20, FontStyle.Bold)

    End Sub
    Private Sub ModeSelect_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Fontload()
    End Sub
End Class