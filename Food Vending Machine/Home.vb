﻿Imports System.Threading
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

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
    End Sub
    Private Sub Home_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Fontload()
        Me.KeyPreview = True
        buyBtn.Enabled = False
        Load_Products_Worker.RunWorkerAsync()

    End Sub

    Private Sub buyBtn_Click(sender As Object, e As EventArgs) Handles buyBtn.Click
        Dim id As String = FoodView.Items(FoodView.FocusedItem.Index).SubItems(1).Text
        Dim Payment As New Payment(id)
        Payment.ShowDialog()
        buyBtn.Enabled = False
        FoodView.Items.Clear()
        Load_Products_Worker.RunWorkerAsync()
    End Sub

    Private Sub Load_Products()
        Fontload()
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
        Next
    End Sub

    Private Sub Load_Products_Worker_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles Load_Products_Worker.DoWork
        total_product = mongoDBServer.CountFood
        image_list = mongoDBServer.GetAllImage
        food_list = mongoDBServer.GetAllFood
    End Sub
    Private Sub Load_Products_Worker_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles Load_Products_Worker.RunWorkerCompleted
        Load_Products()
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
            Load_Products_Worker.RunWorkerAsync()
        End If
    End Sub
    Private Sub Fontload()
        Dim pfc As New PrivateFontCollection
        Dim resource As String = "Food_Vending_Machine.FC Lamoon Regular ver 1.00.ttf"
        Dim fontstream As Stream
        Dim data As IntPtr
        Dim fontdata As Byte()
        fontstream = Assembly.GetExecutingAssembly().GetManifestResourceStream(resource)
        data = Marshal.AllocCoTaskMem(CInt(fontstream.Length))
        fontdata = New Byte(fontstream.Length - 1) {}
        fontstream.Read(fontdata, 0, CInt(fontstream.Length))
        Marshal.Copy(fontdata, 0, data, CInt(fontstream.Length))
        pfc.AddMemoryFont(data, CInt(fontstream.Length))
        fontstream.Close()
        Marshal.FreeCoTaskMem(data)

        buyBtn.Font = New Font(pfc.Families(0), 16, FontStyle.Regular)
        FoodView.Font = New Font(pfc.Families(0), 20, FontStyle.Regular)
        titleLabel.Font = New Font(pfc.Families(0), 45, FontStyle.Regular)

    End Sub
End Class