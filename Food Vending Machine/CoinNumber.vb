Imports System.Drawing.Text
Public Class CoinNumber
    Dim colFont As New PrivateFontCollection
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub Fontload()
        colFont.AddFontFile(Application.StartupPath + "Font\FC Lamoon Regular ver 1.00.ttf")

        lblCoin1.Font = New Font(colFont.Families(0), 18, FontStyle.Bold)
        lblCoin2.Font = New Font(colFont.Families(0), 18, FontStyle.Bold)
        lblCoin3.Font = New Font(colFont.Families(0), 18, FontStyle.Bold)
        btnUpdate.Font = New Font(colFont.Families(0), 18, FontStyle.Bold)
        btnCancel.Font = New Font(colFont.Families(0), 18, FontStyle.Bold)

    End Sub
    Private Sub ModeSelect_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Fontload()
    End Sub
End Class