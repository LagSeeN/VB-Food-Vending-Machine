Imports System.IO
Imports System.Drawing.Text
Imports System.Runtime.InteropServices
Imports System.Reflection
Public Class HeatFoodPage
    Dim time As Double = 60
    Dim sizes As Double = 0
    Dim id As String
    Dim time_to_cook As Integer
    Dim current_time As Integer

    Public Sub New(id As String, time_to_cook As Integer)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.id = id
        Me.time_to_cook = time_to_cook
        Me.current_time = time_to_cook

    End Sub
    Private Sub HeatFoodPage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Fontload()
        lblCountDown.Text = time_to_cook
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If current_time > 0 Then
            lblCountDown.Text = current_time
            current_time -= 1
            ProgressBar.Value = 100 - ((current_time / time_to_cook) * 100)
        Else
            My.Computer.Audio.Play(My.Resources.Sound, AudioPlayMode.WaitToComplete)
            Timer1.Stop()
            Dim TakeFood As New TakeFood
            TakeFood.ShowDialog()
            Me.Close()
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

        lblTakeFood.Font = New Font(pfc.Families(0), 45, FontStyle.Regular)
        lblTextWait.Font = New Font(pfc.Families(0), 30, FontStyle.Regular)
        lblTextSec.Font = New Font(pfc.Families(0), 30, FontStyle.Regular)
        lblCountDown.Font = New Font(pfc.Families(0), 40, FontStyle.Regular)

    End Sub
End Class



