Imports System.Drawing.Text
Public Class ModeSelect
    Dim colFont As New PrivateFontCollection
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Private Sub AddProductBtn_Click(sender As Object, e As EventArgs) Handles AddProductBtn.Click
        Dim InsertItem As New InsertItem
        InsertItem.titleLabel.Text = "เพิ่มรายการสินค้า"
        InsertItem.ShowDialog()
    End Sub

    Private Sub EditProductBtn_Click(sender As Object, e As EventArgs) Handles EditProductBtn.Click
        Dim InsertItem As New InsertItem(True)
        InsertItem.titleLabel.Text = "แก้ไขรายการสินค้า"
        InsertItem.ShowDialog()
    End Sub

    Private Sub SellProductBtn_Click(sender As Object, e As EventArgs) Handles SellProductBtn.Click
        Dim TransactionViewer As New TransactionViewer
        TransactionViewer.ShowDialog()
    End Sub
    Private Sub CoinNumBtn_Click(sender As Object, e As EventArgs) Handles CoinNumBtn.Click
        Dim CoinNumber As New CoinNumber
        CoinNumber.ShowDialog()
    End Sub
    Private Sub Fontload()
        colFont.AddFontFile(Application.StartupPath + "Font\<font file>")

        AddProductBtn.Font = New Font(colFont.Families(0), 20, FontStyle.Bold)
        SellProductBtn.Font = New Font(colFont.Families(0), 20, FontStyle.Bold)
        EditProductBtn.Font = New Font(colFont.Families(0), 20, FontStyle.Bold)
        CoinNumBtn.Font = New Font(colFont.Families(0), 20, FontStyle.Bold)

    End Sub
    Private Sub ModeSelect_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Fontload()
    End Sub


End Class