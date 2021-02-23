Public Class HeatFoodPage
    Dim time As Double = 60
    Dim sizes As Double = 0

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Private Sub HeatFoodPage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        pnlProgress.Width = 0
        lblCountDown.Text = time
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        sizes = 372 / 60
        If time >= 0 Then
            lblCountDown.Text = time
            time -= 1
            pnlProgress.Width += sizes
        Else
            My.Computer.Audio.Play(My.Resources.Sound, AudioPlayMode.WaitToComplete)
            Timer1.Stop()
            Dim TakeFood As New TakeFood
            TakeFood.Show()
            Me.Close()
        End If
    End Sub
End Class



