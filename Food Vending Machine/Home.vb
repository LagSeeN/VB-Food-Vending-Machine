Imports System.IO
Imports MongoDB.Driver
Imports MongoDB.Bson
Imports System.Threading

Public Class Home
    Dim mongoDBServer As New mongoDBServer
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
        buyBtn.Enabled = False
        Load_Products_Worker.RunWorkerAsync()

    End Sub

    Private Sub buyBtn_Click(sender As Object, e As EventArgs) Handles buyBtn.Click
        Dim id As String = ListView1.Items(ListView1.FocusedItem.Index).SubItems(1).Text
        Dim Payment As New Payment(id)
        Payment.Show()
        Me.Close()
    End Sub

    Private Sub Load_Products()
        ListView1.View = View.LargeIcon
        ListView1.FullRowSelect = True
        For i As Integer = 0 To total_product - 1
            ProductListImage.Images.Add(image_list(i))
        Next
        ListView1.LargeImageList = ProductListImage
        For i As Integer = 0 To total_product - 1
            ListView1.LargeImageList = ProductListImage
            lst = ListView1.Items.Add(food_list(i)("product_name"), i)
            lst.SubItems.Add(food_list(i)("_id").ToString)
            lst.SubItems.Add(food_list(i)("stock").ToString)
        Next
    End Sub

    Private Sub Load_Products_Worker_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles Load_Products_Worker.DoWork
        total_product = mongoDBServer.count_data
        image_list = mongoDBServer.get_all_image
        food_list = mongoDBServer.get_all_food
    End Sub
    Private Sub Load_Products_Worker_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles Load_Products_Worker.RunWorkerCompleted
        Load_Products()
    End Sub

    Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListView1.SelectedIndexChanged
        If ListView1.SelectedItems.Count = 0 Then
            buyBtn.Enabled = False
        Else
            If ListView1.Items(ListView1.FocusedItem.Index).SubItems(2).Text = "0" Then
                buyBtn.Text = "หมด"
            Else
                buyBtn.Text = "ชำระเงิน"
                buyBtn.Enabled = True
            End If
        End If
    End Sub
End Class