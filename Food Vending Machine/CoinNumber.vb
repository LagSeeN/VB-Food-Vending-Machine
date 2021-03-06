Imports System.Drawing.Text
Public Class CoinNumber
    Dim mongoDBServer As New MongoDBServer
    Dim colFont As New PrivateFontCollection

    Dim coin
    Dim new_coin(3) As Int32
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub InitializeCoinLoad()
        If mongoDBServer.ConnectServer() Then
            coin = mongoDBServer.GetCoin
            numCoin1.Value = coin("coin1")
            numCoin5.Value = coin("coin5")
            numCoin10.Value = coin("coin10")
        Else
            MessageBox.Show("เกิดข้อผิดพลาดขณะเชื่อมต่อ", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.Close()
        End If

    End Sub

    Private Sub Fontload()
        colFont.AddFontFile(Application.StartupPath + "Font\<font file>")

        lblCoin1.Font = New Font(colFont.Families(0), 18, FontStyle.Bold)
        lblCoin2.Font = New Font(colFont.Families(0), 18, FontStyle.Bold)
        lblCoin3.Font = New Font(colFont.Families(0), 18, FontStyle.Bold)
        btnUpdate.Font = New Font(colFont.Families(0), 18, FontStyle.Regular)
        btnCancel.Font = New Font(colFont.Families(0), 18, FontStyle.Regular)
        numCoin1.Font = New Font(colFont.Families(0), 18, FontStyle.Regular)
        numCoin5.Font = New Font(colFont.Families(0), 18, FontStyle.Regular)
        numCoin10.Font = New Font(colFont.Families(0), 18, FontStyle.Regular)

    End Sub
    Private Sub ModeSelect_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Fontload()
        InitializeCoinLoad()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        new_coin(0) = numCoin1.Value
        new_coin(1) = numCoin5.Value
        new_coin(2) = numCoin10.Value
        mongoDBServer.updateCoin(new_coin)
        InitializeCoinLoad()
    End Sub
End Class