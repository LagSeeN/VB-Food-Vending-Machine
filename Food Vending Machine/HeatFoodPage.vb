Imports System.Threading
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
        TimerWorker.RunWorkerAsync()
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

    Private Sub TimerWorker_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles TimerWorker.DoWork
        While True
            If current_time = 0 Then
                Exit While
            End If
            current_time -= 1
            TimerWorker.ReportProgress(current_time)
            Thread.Sleep(1000)
        End While
    End Sub

    Private Sub TimerWorker_ProgressChanged(sender As Object, e As System.ComponentModel.ProgressChangedEventArgs) Handles TimerWorker.ProgressChanged
        lblCountDown.Text = e.ProgressPercentage
        ProgressBar.Value = 100 - ((e.ProgressPercentage / time_to_cook) * 100)
    End Sub

    Private Sub TimerWorker_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles TimerWorker.RunWorkerCompleted
        My.Computer.Audio.Play(My.Resources.Sound, AudioPlayMode.WaitToComplete)
        Dim TakeFood As New TakeFood
        TakeFood.ShowDialog()
        can_close = True
        Me.Close()
    End Sub
End Class



