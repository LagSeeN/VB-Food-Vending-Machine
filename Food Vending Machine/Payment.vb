Public Class Payment
    Dim timeCount As Integer = 60
    Private Sub Payment_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblTime.Text = timeCount
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If timeCount >= 0 Then
            lblTime.Text = timeCount
            timeCount -= 1
        Else
            Timer1.Stop()
            MessageBox.Show("หมดเวลาทำการ กลับไปยังหน้าแรก", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information)
            'Me.Hide()
            'กลับไปหน้าแรก
        End If
    End Sub

    Private Sub BtnCoinEmu_Click(sender As Object, e As EventArgs) Handles btnCoinEmu.Click
        'Me.Hide()
        'เรียก Emu เหรียญ
        CoinEmu.Show()
        Me.Hide()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Home.Show()
        Me.Hide()
    End Sub
End Class