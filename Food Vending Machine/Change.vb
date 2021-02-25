﻿Imports System.IO
Imports System.Drawing.Text
Imports System.Runtime.InteropServices
Imports System.Reflection
Public Class Change
    Dim mongoDBServer As New MongoDBServer
    Dim id As String
    Dim change_price As Integer
    Dim coin
    Dim time_to_cook As Integer

    Public Sub New(id, change_price, coin, time_to_cook)

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
        HeatFoodPage.Show()
        Me.Close()
    End Sub

    Private Sub BtnNotHeat_Click(sender As Object, e As EventArgs) Handles btnNotHeat.Click
        Dim TakeFood As New TakeFood
        TakeFood.Show()
        Me.Close()
    End Sub

    Private Sub Change_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Fontload()
        lblChange.Text = change_price
        mongoDBServer.food_finish(id)
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

        lblTakeFood.Font = New Font(pfc.Families(0), 45, FontStyle.Regular)
        lblTextChange.Font = New Font(pfc.Families(0), 30, FontStyle.Regular)
        lblTextHeat.Font = New Font(pfc.Families(0), 30, FontStyle.Regular)
        lblBahtText.Font = New Font(pfc.Families(0), 30, FontStyle.Regular)
        lblChange.Font = New Font(pfc.Families(0), 40, FontStyle.Regular)
        btnHeat.Font = New Font(pfc.Families(0), 20, FontStyle.Regular)
        btnNotHeat.Font = New Font(pfc.Families(0), 20, FontStyle.Regular)

    End Sub
End Class