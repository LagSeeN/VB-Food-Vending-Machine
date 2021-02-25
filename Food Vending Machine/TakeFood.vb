Imports System.IO
Imports System.Drawing.Text
Imports System.Runtime.InteropServices
Imports System.Reflection
Public Class TakeFood

    Dim count As Integer = 0
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub TakeFood_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Fontload()
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        count += 1
        If count = 5 Then
            Timer1.Stop()
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
    End Sub
End Class