Imports System.IO
Imports System.Drawing.Text
Imports System.Runtime.InteropServices
Imports System.Reflection
Public Class Payment
    Dim timeCount As Integer = 5
    Dim id As String
    Dim change_price As Integer
    Dim coin As Integer()
    Dim time_to_cook As Integer
    Dim food_item
    Dim mongoDBServer As New MongoDBServer
    Dim base64 As New Base64
    Dim CoinEmu As CoinEmu
    Dim price As Integer

    Public Sub New(id As String)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.id = id
    End Sub
    Private Sub Payment_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Fontload()
        GetFood_Worker.RunWorkerAsync()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Try
            If timeCount > 0 Then
                timeCount -= 1
                lblTime.Text = timeCount
                If Application.OpenForms().OfType(Of CoinEmu).Any Then
                    If CoinEmu.Get_is_canceled Then
                        Timer1.Stop()
                        If CoinEmu.Get_input_coin > 0 Then
                            'หน้ารับเงินคืน
                            MessageBox.Show("ยกเลิกรายการแล้ว กรุณารับเงินคืน", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            Debug.WriteLine(CoinEmu.Get_coin_arr)
                            Debug.WriteLine(CoinEmu.Get_input_coin)
                        Else
                            MessageBox.Show("ยกเลิกรายการแล้ว กลับไปยังหน้าแรก", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        End If
                        Me.Close()
                    ElseIf CoinEmu.Get_input_coin >= price Then
                        'ไปหน้าต่อไป
                        Timer1.Stop()
                        coin = CoinEmu.Get_coin_arr
                        change_price = CoinEmu.Get_input_coin - price
                        btnCoinEmu.Enabled = False
                        Dim Change As New Change(id, change_price, coin, time_to_cook)
                        CoinEmu.Close()
                        Change.ShowDialog()
                        Me.Close()
                    End If
                End If
            Else
                Timer1.Stop()
                If Application.OpenForms().OfType(Of CoinEmu).Any Then
                    If CoinEmu.Get_input_coin > 0 Then
                        'หน้ารับเงินคืน
                        MessageBox.Show("หมดเวลาทำการ กรุณารับเงินคืน", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Debug.WriteLine(CoinEmu.Get_coin_arr)
                        Debug.WriteLine(CoinEmu.Get_input_coin)
                    End If
                    CoinEmu.Close()
                End If
                MessageBox.Show("หมดเวลาทำการ กลับไปยังหน้าแรก", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.Close()
                'กลับไปหน้าแรก
            End If
        Catch ex As Exception
            MessageBox.Show("ERROR" & vbCrLf & ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            MessageBox.Show("ERROR" & vbCrLf & "เกิดข้อผิดพลาดในการทำงาน โปรแกรมจะปิดตัวลง", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Application.Exit()
        End Try
    End Sub

    Private Sub BtnCoinEmu_Click(sender As Object, e As EventArgs) Handles btnCoinEmu.Click
        'เรียก Emu เหรียญ
        CoinEmu.Show()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Timer1.Stop()
        MessageBox.Show("กรุณารับเงินคืน", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Me.Close()
    End Sub

    Private Sub Load_Food()
        lblName.Text = food_item("product_name").ToString
        lblPrice.Text = food_item("price").ToString
        ptbProduct.Image = base64.ConvertByteToImage(base64.ConvertBase64ToByteArray(food_item("image")))
        price = food_item("price")
        time_to_cook = food_item("time")
        CoinEmu = New CoinEmu(price)
    End Sub

    Private Sub GetFood_Worker_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles GetFood_Worker.DoWork
        food_item = mongoDBServer.GetFood(id)
    End Sub

    Private Sub GetFood_Worker_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles GetFood_Worker.RunWorkerCompleted
        Load_Food()
        lblTime.Text = timeCount
        Timer1.Start()
    End Sub

    Private Sub Fontload()
        Dim colFont As New PrivateFontCollection
        colFont.AddFontFile(Application.StartupPath + "Font\FC Lamoon Regular ver 1.00.ttf")

        lblPaymentHead.Font = New Font(colFont.Families(0), 45, FontStyle.Regular)
        lblTextName.Font = New Font(colFont.Families(0), 20, FontStyle.Regular)
        lblName.Font = New Font(colFont.Families(0), 30, FontStyle.Regular)
        lblTextPrice.Font = New Font(colFont.Families(0), 20, FontStyle.Regular)
        lblPrice.Font = New Font(colFont.Families(0), 30, FontStyle.Regular)
        lblTextTime.Font = New Font(colFont.Families(0), 20, FontStyle.Regular)
        lblTime.Font = New Font(colFont.Families(0), 35, FontStyle.Regular)
        btnCancel.Font = New Font(colFont.Families(0), 15, FontStyle.Regular)
        btnCoinEmu.Font = New Font(colFont.Families(0), 20, FontStyle.Regular)


    End Sub
End Class