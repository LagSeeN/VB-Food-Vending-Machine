Public Class Change

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Private Sub BtnHeat_Click(sender As Object, e As EventArgs) Handles btnHeat.Click
        Dim HeatFoodPage As New HeatFoodPage
        HeatFoodPage.Show()
        Me.Close()
    End Sub

    Private Sub BtnNotHeat_Click(sender As Object, e As EventArgs) Handles btnNotHeat.Click
        Dim TakeFood As New TakeFood
        TakeFood.Show()
        Me.Close()
    End Sub

    Private Sub Change_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class