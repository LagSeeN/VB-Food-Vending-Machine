Public Class Change
    Dim mongoDBServer As New MongoDBServer
    Dim id As String
    Dim change_price As Integer
    Dim coin
    Dim time_to_cook As Integer

    Public Sub New(id, change_price, coin, time_to_cook)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.id = id
        Me.change_price = change_price
        Me.coin = coin
        Me.time_to_cook = time_to_cook

    End Sub
    Private Sub BtnHeat_Click(sender As Object, e As EventArgs) Handles btnHeat.Click
        Dim HeatFoodPage As New HeatFoodPage(id, time_to_cook)
        HeatFoodPage.Show()
        Me.Close()
    End Sub

    Private Sub BtnNotHeat_Click(sender As Object, e As EventArgs) Handles btnNotHeat.Click
        Dim TakeFood As New TakeFood
        TakeFood.Show()
        Me.Close()
    End Sub

    Private Sub Change_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblChange.Text = change_price
        mongoDBServer.food_finish(id)
    End Sub
End Class