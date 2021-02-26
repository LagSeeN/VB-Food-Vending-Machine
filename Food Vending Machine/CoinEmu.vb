﻿Imports System.IO
Imports System.Drawing.Text
Imports System.Runtime.InteropServices
Imports System.Reflection
Public Class CoinEmu
    Dim price As Integer
    Dim coin(3) As Integer
    Dim input_coin As Integer
    Dim is_canceled As Boolean

    Public ReadOnly Property Get_input_coin As Integer
        Get
            Return input_coin
        End Get
    End Property

    Public ReadOnly Property Get_coin_arr As Integer()
        Get
            Return coin
        End Get
    End Property

    Public ReadOnly Property Get_is_canceled As Boolean
        Get
            Return is_canceled
        End Get
    End Property
    Public Sub New(price As Integer)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.price = price

    End Sub

    Private Sub cancelBtn_Click(sender As Object, e As EventArgs) Handles cancelBtn.Click
        is_canceled = True
        Me.Hide()
    End Sub

    Private Sub CoinEmu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Fontload()
        input_coin = 0
        is_canceled = False
    End Sub

    Private Sub oneCoinBtn_Click(sender As Object, e As EventArgs) Handles oneCoinBtn.Click
        coin(0) += 1
        input_coin += 1
        coinTotalTB.Text = input_coin
        CheckPrice()
    End Sub

    Private Sub fiveCoinBtn_Click(sender As Object, e As EventArgs) Handles fiveCoinBtn.Click
        coin(1) += 1
        input_coin += 5
        coinTotalTB.Text = input_coin
        CheckPrice()
    End Sub

    Private Sub tenCoinBtn_Click(sender As Object, e As EventArgs) Handles tenCoinBtn.Click
        coin(2) += 1
        input_coin += 10
        coinTotalTB.Text = input_coin
        CheckPrice()
    End Sub

    Private Sub CheckPrice()
        If input_coin >= price Then
            Me.Hide()
        End If
    End Sub

    Private Sub CoinEmu_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        is_canceled = True
        Me.Hide()
    End Sub
    Private Sub Fontload()
        'Dim pfc As New PrivateFontCollection
        'Dim resource As String = "Food_Vending_Machine.FC Lamoon Regular ver 1.00.ttf"
        'Dim fontstream As Stream
        'Dim data As IntPtr
        'Dim fontdata As Byte()
        'fontstream = Assembly.GetExecutingAssembly().GetManifestResourceStream(resource)
        'Data = Marshal.AllocCoTaskMem(CInt(fontstream.Length))
        'fontdata = New Byte(fontstream.Length - 1) {}
        'fontstream.Read(fontdata, 0, CInt(fontstream.Length))
        'Marshal.Copy(fontdata, 0, data, CInt(fontstream.Length))
        'pfc.AddMemoryFont(data, CInt(fontstream.Length))
        'fontstream.Close()
        'Marshal.FreeCoTaskMem(data)

        'oneCoinBtn.Font = New Font(pfc.Families(0), 20, FontStyle.Regular)
        'fiveCoinBtn.Font = New Font(pfc.Families(0), 20, FontStyle.Regular)
        'tenCoinBtn.Font = New Font(pfc.Families(0), 20, FontStyle.Regular)
        'cancelBtn.Font = New Font(pfc.Families(0), 20, FontStyle.Regular)
        'coinTotalTB.Font = New Font(pfc.Families(0), 24, FontStyle.Regular)

    End Sub
End Class