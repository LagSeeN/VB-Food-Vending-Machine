Imports System.Threading
Imports System.IO
Imports System.Drawing.Text
Imports System.Runtime.InteropServices
Imports System.Reflection
Public Class Home
    Dim mongoDBServer As New MongoDBServer
    Dim lst As ListViewItem

    Dim total_product As Integer
    Dim image_list()
    Dim food_list()

    Dim colFont As New PrivateFontCollection

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
    End Sub
    Private Sub Home_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Fontload()
        InitializeFoodView()
        Load_Products_Worker.RunWorkerAsync()

    End Sub

    Private Sub buyBtn_Click(sender As Object, e As EventArgs) Handles buyBtn.Click
        Dim id As String = FoodView.Items(FoodView.FocusedItem.Index).SubItems(1).Text
        Dim Payment As New Payment(id)
        Payment.ShowDialog()
        buyBtn.Enabled = False
        InitializeFoodView()
        Load_Products_Worker.RunWorkerAsync()
    End Sub

    Private Sub Load_Products()
        FoodView.View = View.LargeIcon
        FoodView.FullRowSelect = True
        For i As Integer = 0 To total_product - 1
            ProductListImage.Images.Add(image_list(i))
        Next
        FoodView.LargeImageList = ProductListImage
        For i As Integer = 0 To total_product - 1
            FoodView.LargeImageList = ProductListImage
            lst = FoodView.Items.Add(food_list(i)("product_name"), i)
            lst.SubItems.Add(food_list(i)("_id").ToString)
            lst.SubItems.Add(food_list(i)("stock").ToString)
            lst.Font = New Font(colFont.Families(0), 20, FontStyle.Regular)
        Next
        FoodView.Enabled = True
        Me.KeyPreview = True
        buyBtn.Enabled = True
    End Sub

    Private Sub InitializeFoodView()
        buyBtn.Enabled = False
        Me.KeyPreview = False
        FoodView.Enabled = False
        FoodView.Items.Clear()
    End Sub


    Private Sub Load_Products_Worker_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles Load_Products_Worker.DoWork
        total_product = mongoDBServer.CountFood(True)
        image_list = mongoDBServer.GetAllImage(True)
        food_list = mongoDBServer.GetAllFood(True)
    End Sub
    Private Sub Load_Products_Worker_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles Load_Products_Worker.RunWorkerCompleted
        Try
            Load_Products()
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
            Else
                buyBtn.Text = "ชำระเงิน"
                buyBtn.Enabled = True
            End If
        End If
    End Sub

    Private Sub Home_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.F1 Then
            Dim ModeSelect As New ModeSelect()
            ModeSelect.ShowDialog()
            InitializeFoodView()
            Try
                Load_Products_Worker.RunWorkerAsync()
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
            buyBtn.Font = New Font(colFont.Families(0), 16, FontStyle.Regular)
            'FoodView.Font = New Font(colFont.Families(0), 20, FontStyle.Regular)
            titleLabel.Font = New Font(colFont.Families(0), 45, FontStyle.Regular)
        Catch ex As System.IO.FileNotFoundException
            MessageBox.Show("ไม่พบ Font ในโปรแกรม", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As Exception
            MessageBox.Show("ERROR" & vbCrLf & ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class