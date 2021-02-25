Public Class HeatFoodPage
    Dim time As Double = 60
    Dim sizes As Double = 0
    Dim id As String
    Dim time_to_cook As Integer
    Dim current_time As Integer

    Public Sub New(id As String, time_to_cook As Integer)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.id = id
        Me.time_to_cook = time_to_cook
        Me.current_time = time_to_cook

    End Sub
    Private Sub HeatFoodPage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblCountDown.Text = time_to_cook
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If current_time > 0 Then
            lblCountDown.Text = current_time
            current_time -= 1
            ProgressBar.Value = 100 - ((current_time / time_to_cook) * 100)
        Else
            My.Computer.Audio.Play(My.Resources.Sound, AudioPlayMode.WaitToComplete)
            Timer1.Stop()
            Dim TakeFood As New TakeFood
            TakeFood.Show()
            Me.Close()
        End If
    End Sub
End Class



