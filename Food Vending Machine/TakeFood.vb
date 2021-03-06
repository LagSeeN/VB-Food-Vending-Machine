Imports System.Drawing.Text
Public Class TakeFood
    Dim colFont As New PrivateFontCollection
    Dim count As Integer = 0
    Dim can_close As Boolean
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub TakeFood_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Fontload()
        can_close = False
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        count += 1
        If count = 5 Then
            Timer1.Stop()
            can_close = True
            Me.Close()
        End If
    End Sub
    Private Sub Fontload()
        colFont.AddFontFile(Application.StartupPath + "Font\<font file>")

        lblTakeFood.Font = New Font(colFont.Families(0), 45, FontStyle.Bold)

    End Sub

    Private Sub TakeFood_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If can_close Then
            e.Cancel = False
        Else
            e.Cancel = True
        End If
    End Sub
End Class