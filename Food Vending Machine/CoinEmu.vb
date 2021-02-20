Public Class CoinEmu
    Dim price As Integer
    Dim coin(3) As Integer
    Dim input_coin As Integer

    Public ReadOnly Property Get_input_coin As Integer
        Get
            Return input_coin
        End Get
    End Property
    Public Sub New(price As Integer)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.price = price

    End Sub
    Private Sub submitBtn_Click(sender As Object, e As EventArgs) Handles submitBtn.Click
        'Payment.Show()
        Me.Hide()
        'ส่งค่าไปด้วย
    End Sub

    Private Sub cancelBtn_Click(sender As Object, e As EventArgs) Handles cancelBtn.Click
        'Payment.Show()
        Me.Hide()
    End Sub

    Private Sub CoinEmu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        input_coin = 0
    End Sub

    Private Sub oneCoinBtn_Click(sender As Object, e As EventArgs) Handles oneCoinBtn.Click
        coin(0) += 1
        input_coin += 1
        coinTotalTB.Text = input_coin
        CheckPrice()
    End Sub

    Private Sub fiveCoinBtn_Click(sender As Object, e As EventArgs) Handles fiveCoinBtn.Click
        coin(1) += 1
        input_coin += 5
        coinTotalTB.Text = input_coin
        CheckPrice()
    End Sub

    Private Sub tenCoinBtn_Click(sender As Object, e As EventArgs) Handles tenCoinBtn.Click
        coin(2) += 1
        input_coin += 10
        coinTotalTB.Text = input_coin
        CheckPrice()
    End Sub

    Private Sub CheckPrice()
        If input_coin >= price Then
            Me.Close()
        End If
    End Sub
End Class