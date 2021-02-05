Public Class Change
    Private Sub BtnHeat_Click(sender As Object, e As EventArgs) Handles btnHeat.Click
        HeatFoodPage.Show()
        Me.Hide()
    End Sub

    Private Sub BtnNotHeat_Click(sender As Object, e As EventArgs) Handles btnNotHeat.Click
        TakeFood.Show()
        Me.Hide()
    End Sub
End Class