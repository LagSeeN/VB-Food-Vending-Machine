Imports System.Drawing.Text
Public Class Change
    Dim mongoDBServer As New MongoDBServer
    Dim id As String
    Dim change_price As Integer
    Dim coin As Integer()
    Dim time_to_cook As Integer
    Dim can_close As Boolean
    Dim colFont As New PrivateFontCollection

    Public Sub New(id As String, change_price As Integer, coin As Integer(), time_to_cook As Double)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.id = id
        Me.change_price = change_price
        Me.coin = coin
        Me.time_to_cook = time_to_cook

    End Sub
    Private Sub BtnHeat_Click(sender As Object, e As EventArgs) Handles btnHeat.Click
        Dim HeatFoodPage As New HeatFoodPage(id, time_to_cook)
        HeatFoodPage.ShowDialog()
        can_close = True
        Me.Close()
    End Sub

    Private Sub BtnNotHeat_Click(sender As Object, e As EventArgs) Handles btnNotHeat.Click
        Dim TakeFood As New TakeFood
        TakeFood.ShowDialog()
        can_close = True
        Me.Close()
    End Sub

    Private Sub Change_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Fontload()
        can_close = False
        lblChange.Text = change_price
        If mongoDBServer.ConnectServer() Then
            mongoDBServer.food_finish(id, coin, change_price)
        Else
            MessageBox.Show("เกิดข้อผิดพลาดขณะเชื่อมต่อ", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            can_close = True
            Me.Close()
        End If
    End Sub
    Private Sub Change_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If can_close Then
            e.Cancel = False
        Else
            e.Cancel = True
        End If
    End Sub
    Private Sub Fontload()
        colFont.AddFontFile(Application.StartupPath + "Font\<font file>")

        lblTakeFood.Font = New Font(colFont.Families(0), 45, FontStyle.Bold)
        lblTextChange.Font = New Font(colFont.Families(0), 30, FontStyle.Regular)
        lblTextHeat.Font = New Font(colFont.Families(0), 30, FontStyle.Regular)
        lblBahtText.Font = New Font(colFont.Families(0), 30, FontStyle.Regular)
        lblChange.Font = New Font(colFont.Families(0), 40, FontStyle.Regular)
        btnHeat.Font = New Font(colFont.Families(0), 20, FontStyle.Regular)
        btnNotHeat.Font = New Font(colFont.Families(0), 20, FontStyle.Regular)

    End Sub
End Class