Imports System.Drawing.Text
Public Class TransactionViewer
    Dim mongoDBServer As New MongoDBServer
    Private Sub TransactionViewer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Fontload()
        Dim transactions As List(Of TransactionResult) = mongoDBServer.GetTransaction()

        Dim thaiMonth() As String = {"มกราคม", "กุมภาพันธ์", "มีนาคม", "เมษายน", "พฤษภาคม", "มิถุนายน",
            "กรกฎาคม", "สิงหาคม", "กันยายน", "ตุลาคม", "พฤศจิกายน", "ธันวาคม"}

        dgvTransaction.Columns.Add("FoodName", "ชื่อสินค้า")
        dgvTransaction.Columns.Add("Count", "จำนวนที่ขายได้")

        dgvTransaction.Columns(0).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        dgvTransaction.Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells

        For Each transaction In transactions
            dgvTransaction.Rows.Add(transaction.FoodName, transaction.Count)
        Next

        lblTitle.Text = "กำลังแสดงรายการสินค้าได้จำหน่ายได้ในเดือน " & thaiMonth(Date.Now.Month - 1) & " ปี " & Date.Now.Year
    End Sub
    Private Sub Fontload()
        Dim colFont As New PrivateFontCollection
        colFont.AddFontFile(Application.StartupPath + "Font\FC Lamoon Regular ver 1.00.ttf")

        lblTitle.Font = New Font(colFont.Families(0), 45, FontStyle.Regular)

    End Sub
End Class