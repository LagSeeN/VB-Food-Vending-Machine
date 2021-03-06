Imports System.Threading
Imports System.Drawing.Text
Public Class Home
    Dim mongoDBServer As New MongoDBServer
    Dim lst As ListViewItem

    Dim total_product As Integer
    Dim image_list As New ArrayList
    Dim food_list As New ArrayList
    Dim coin_ready As Boolean

    Dim colFont As New PrivateFontCollection

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
    End Sub
    Private Sub Home_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Fontload()
        InitializeFoodView()
        If mongoDBServer.ConnectServer() Then
            Load_Products_Worker.RunWorkerAsync()
        Else
            MessageBox.Show("เกิดข้อผิดพลาดขณะเชื่อมต่อ", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            buyBtn.Text = "ไม่พร้อมให้บริการ"
        End If

    End Sub

    Private Sub buyBtn_Click(sender As Object, e As EventArgs) Handles buyBtn.Click
        Dim id As String = FoodView.Items(FoodView.FocusedItem.Index).SubItems(1).Text
        Dim Payment As New Payment(id)
        Payment.ShowDialog()
        InitializeFoodView()
        If mongoDBServer.ConnectServer() Then
            Load_Products_Worker.RunWorkerAsync()
        Else
            MessageBox.Show("เกิดข้อผิดพลาดขณะเชื่อมต่อ", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            buyBtn.Text = "ไม่พร้อมให้บริการ"
        End If
    End Sub

    Private Sub Load_Products()
        FoodView.View = View.LargeIcon
        FoodView.FullRowSelect = True
        For Each img In image_list
            ProductListImage.Images.Add(img)
        Next
        FoodView.LargeImageList = ProductListImage
        Dim num As Integer = 0
        For Each item In food_list
            FoodView.LargeImageList = ProductListImage
            lst = FoodView.Items.Add(item("product_name"), num)
            lst.SubItems.Add(item("_id").ToString)
            lst.SubItems.Add(item("stock").ToString)
            lst.Font = New Font(colFont.Families(0), 20, FontStyle.Regular)
            num += 1
        Next
    End Sub

    Private Sub InitializeFoodView()
        buyBtn.Text = "ชำระเงิน"
        ProductListImage.Images.Clear()
        buyBtn.Enabled = False
        Me.KeyPreview = False
        FoodView.Enabled = False
        FoodView.Items.Clear()
    End Sub


    Private Sub Load_Products_Worker_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles Load_Products_Worker.DoWork
        total_product = mongoDBServer.CountFood(True)
        image_list = mongoDBServer.GetAllImage(True)
        food_list = mongoDBServer.GetAllFood(True)
        If mongoDBServer.CheckCoin Then
            coin_ready = True
        Else
            coin_ready = False
        End If
    End Sub
    Private Sub Load_Products_Worker_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles Load_Products_Worker.RunWorkerCompleted
        Try
            If coin_ready Then
                Load_Products()
                FoodView.Enabled = True
            Else
                MessageBox.Show("ตู้เหรียญหมด", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                buyBtn.Text = "ไม่พร้อมให้บริการ"
                buyBtn.Enabled = False
                FoodView.Enabled = False
            End If
            FoodView.Enabled = True
            Me.KeyPreview = True
        Catch ex As Exception
            MessageBox.Show("ERROR" & vbCrLf & ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            MessageBox.Show("ERROR" & vbCrLf & "เกิดข้อผิดพลาดในการทำงาน โปรแกรมจะปิดตัวลง", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Application.Exit()
        End Try
    End Sub

    Private Sub FoodView_SelectedIndexChanged(sender As Object, e As EventArgs) Handles FoodView.SelectedIndexChanged
        If FoodView.SelectedItems.Count = 0 Then
            buyBtn.Enabled = False
            buyBtn.Text = "ชำระเงิน"
        Else
            If FoodView.Items(FoodView.FocusedItem.Index).SubItems(2).Text = "0" Then
                buyBtn.Text = "หมด"
                buyBtn.Enabled = False
            Else
                buyBtn.Text = "ชำระเงิน"
                buyBtn.Enabled = True
            End If
        End If
    End Sub

    Private Sub Home_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.F1 Then
            Dim ModeSelect As New ModeSelect
            ModeSelect.ShowDialog()
            InitializeFoodView()
            Try
                If mongoDBServer.ConnectServer() Then
                    Load_Products_Worker.RunWorkerAsync()
                Else
                    Throw New System.Exception("เกิดข้อผิดพลาดขณะเชื่อมต่อ")
                    buyBtn.Text = "ไม่พร้อมให้บริการ"
                End If
            Catch ex As System.InvalidOperationException
                MessageBox.Show("กรุณารอสักครู่ และดำเนินการใหม่อีกครั้ง", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Catch ex As Exception
                MessageBox.Show("ERROR" & vbCrLf & ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub
    Private Sub Fontload()
        Try
            colFont.AddFontFile(Application.StartupPath + "Font\FC Lamoon Regular ver 1.00.ttf")
            buyBtn.Font = New Font(colFont.Families(0), 20, FontStyle.Regular)
            titleLabel.Font = New Font(colFont.Families(0), 45, FontStyle.Bold)
        Catch ex As System.IO.FileNotFoundException
            MessageBox.Show("ไม่พบ Font ในโปรแกรม", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As Exception
            MessageBox.Show("ERROR" & vbCrLf & ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Home_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        System.Environment.Exit(0)
    End Sub
End Class