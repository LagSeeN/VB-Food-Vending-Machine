Imports System.Drawing.Text
Public Class TakeFood

    Dim count As Integer = 0
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub TakeFood_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Fontload()
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        count += 1
        If count = 5 Then
            Timer1.Stop()
            Me.Close()
        End If
    End Sub
    Private Sub Fontload()
        Dim colFont As New PrivateFontCollection
        colFont.AddFontFile(Application.StartupPath + "Font\FC Lamoon Regular ver 1.00.ttf")

        lblTakeFood.Font = New Font(colFont.Families(0), 45, FontStyle.Regular)

    End Sub
End Class