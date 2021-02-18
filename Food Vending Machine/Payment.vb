Public Class Payment
    Dim timeCount As Integer = 60
    Dim id As String
    Dim food_item
    Dim mongoDBServer As New mongoDBServer
    Dim base64 As New Base64

    Public Sub New(id As String)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.id = id
    End Sub
    Private Sub Payment_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GetFood_Worker.RunWorkerAsync()
        lblTime.Text = timeCount
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If timeCount >= 0 Then
            lblTime.Text = timeCount
            timeCount -= 1
        Else
            Timer1.Stop()
            MessageBox.Show("หมดเวลาทำการ กลับไปยังหน้าแรก", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Dim Home As New Home
            Home.Show()
            Me.Close()
            'Me.Hide()
            'กลับไปหน้าแรก
        End If
    End Sub

    Private Sub BtnCoinEmu_Click(sender As Object, e As EventArgs) Handles btnCoinEmu.Click
        'Me.Hide()
        'เรียก Emu เหรียญ
        CoinEmu.Show()
        Me.Hide()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Dim Home As New Home
        Home.Show()
        Me.Close()
    End Sub

    Private Sub Load_Food()
        lblName.Text = food_item("product_name").ToString
        lblPrice.Text = food_item("price").ToString
        ptbProduct.Image = base64.convertbytetoimage(base64.ConvertBase64ToByteArray(food_item("image")))
    End Sub

    Private Sub GetFood_Worker_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles GetFood_Worker.DoWork
        food_item = mongoDBServer.get_food(id)
    End Sub

    Private Sub GetFood_Worker_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles GetFood_Worker.RunWorkerCompleted
        Load_Food()
    End Sub
End Class