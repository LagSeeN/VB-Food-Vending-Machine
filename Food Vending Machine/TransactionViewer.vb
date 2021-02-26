﻿Imports System.Drawing.Text
Public Class TransactionViewer
    Dim mongoDBServer As New MongoDBServer
    Dim colFont As New PrivateFontCollection
    Private Sub TransactionViewer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Fontload()
        Dim transactions As List(Of TransactionResult) = mongoDBServer.GetTransaction()

        Dim thaiMonth() As String = {"มกราคม", "กุมภาพันธ์", "มีนาคม", "เมษายน", "พฤษภาคม", "มิถุนายน",
            "กรกฎาคม", "สิงหาคม", "กันยายน", "ตุลาคม", "พฤศจิกายน", "ธันวาคม"}

        dgvTransaction.Columns.Add("FoodName", "ชื่อสินค้า")
        dgvTransaction.Columns.Add("Price", "ราคาที่จำหน่าย")
        dgvTransaction.Columns.Add("Count", "จำนวนที่ขายได้")
        dgvTransaction.Columns.Add("TotalSale", "รายได้")

        dgvTransaction.Columns(0).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        dgvTransaction.Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        dgvTransaction.Columns(2).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        dgvTransaction.Columns(3).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells

        dgvTransaction.Columns(0).SortMode = DataGridViewColumnSortMode.NotSortable
        dgvTransaction.Columns(1).SortMode = DataGridViewColumnSortMode.NotSortable
        dgvTransaction.Columns(2).SortMode = DataGridViewColumnSortMode.NotSortable
        dgvTransaction.Columns(3).SortMode = DataGridViewColumnSortMode.NotSortable

        dgvTransaction.AllowUserToResizeRows = False
        dgvTransaction.AllowUserToResizeColumns = False


        For Each transaction In transactions
            dgvTransaction.Rows.Add(transaction.FoodName, transaction.Price.ToString("N") & " บาท", transaction.Count.ToString("N0") & " ชิ้น", transaction.TotalSale.ToString("N") & " บาท")
        Next

        lblTitle.Text = "กำลังแสดงรายการสินค้าได้จำหน่ายได้ในเดือน " & thaiMonth(Date.Now.Month - 1) & " ปี " & Date.Now.Year
    End Sub
    Private Sub Fontload()
        colFont.AddFontFile(Application.StartupPath + "Font\FC Lamoon Regular ver 1.00.ttf")

        lblTitle.Font = New Font(colFont.Families(0), 30, FontStyle.Regular)

    End Sub
End Class