Imports System.Drawing.Text
Public Class HeatFoodPage
    Dim time As Double = 60
    Dim sizes As Double = 0
    Dim id As String
    Dim time_to_cook As Integer
    Dim current_time As Integer
    Dim can_close As Boolean
    Dim colFont As New PrivateFontCollection

    Public Sub New(id As String, time_to_cook As Integer)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.id = id
        Me.time_to_cook = time_to_cook
        Me.current_time = time_to_cook

    End Sub
    Private Sub HeatFoodPage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Fontload()
        can_close = False
        lblCountDown.Text = time_to_cook
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If current_time > 0 Then
            current_time -= 1
            lblCountDown.Text = current_time
            ProgressBar.Value = 100 - ((current_time / time_to_cook) * 100)
        Else
            My.Computer.Audio.Play(My.Resources.Sound, AudioPlayMode.WaitToComplete)
            Timer1.Stop()
            Dim TakeFood As New TakeFood
            TakeFood.ShowDialog()
            can_close = True
            Me.Close()
        End If
    End Sub
    Private Sub Fontload()
        colFont.AddFontFile(Application.StartupPath + "Font\FC Lamoon Regular ver 1.00.ttf")

        lblTakeFood.Font = New Font(colFont.Families(0), 45, FontStyle.Regular)
        lblTextWait.Font = New Font(colFont.Families(0), 30, FontStyle.Regular)
        lblTextSec.Font = New Font(colFont.Families(0), 30, FontStyle.Regular)
        lblCountDown.Font = New Font(colFont.Families(0), 40, FontStyle.Regular)

    End Sub

    Private Sub HeatFoodPage_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If can_close Then
            e.Cancel = False
        Else
            e.Cancel = True
        End If
    End Sub
End Class



