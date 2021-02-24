<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class HeatFoodPage
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblTakeFood = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.pnlBack = New System.Windows.Forms.Panel()
        Me.pnlProgress = New System.Windows.Forms.Panel()
        Me.picBird1 = New System.Windows.Forms.PictureBox()
        Me.picBird2 = New System.Windows.Forms.PictureBox()
        Me.lblCountDown = New System.Windows.Forms.Label()
        Me.lblTextWait = New System.Windows.Forms.Label()
        Me.lblTextSec = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Panel1.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.pnlBack.SuspendLayout()
        CType(Me.picBird1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBird2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Panel1.Controls.Add(Me.lblTakeFood)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1104, 117)
        Me.Panel1.TabIndex = 0
        '
        'lblTakeFood
        '
        Me.lblTakeFood.AutoSize = True
        Me.lblTakeFood.Font = New System.Drawing.Font("Microsoft Sans Serif", 28.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblTakeFood.Location = New System.Drawing.Point(243, 33)
        Me.lblTakeFood.Name = "lblTakeFood"
        Me.lblTakeFood.Size = New System.Drawing.Size(565, 44)
        Me.lblTakeFood.TabIndex = 2
        Me.lblTakeFood.Text = "กรุณารอสักครู่ กำลังทำการอุ่นอาหาร..."
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.BackColor = System.Drawing.Color.White
        Me.TableLayoutPanel1.ColumnCount = 5
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 18.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29.42178!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 41.37891!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29.19931!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.pnlBack, 2, 6)
        Me.TableLayoutPanel1.Controls.Add(Me.picBird1, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.picBird2, 3, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.lblCountDown, 2, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.lblTextWait, 2, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.lblTextSec, 2, 4)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 117)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 8
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 56.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.97195!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 85.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 150.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 85.02805!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 19.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 56.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1104, 514)
        Me.TableLayoutPanel1.TabIndex = 1
        '
        'pnlBack
        '
        Me.pnlBack.BackColor = System.Drawing.Color.DarkGray
        Me.pnlBack.Controls.Add(Me.pnlProgress)
        Me.pnlBack.Location = New System.Drawing.Point(331, 422)
        Me.pnlBack.Name = "pnlBack"
        Me.pnlBack.Size = New System.Drawing.Size(427, 32)
        Me.pnlBack.TabIndex = 5
        '
        'pnlProgress
        '
        Me.pnlProgress.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.pnlProgress.Location = New System.Drawing.Point(0, 0)
        Me.pnlProgress.Name = "pnlProgress"
        Me.pnlProgress.Size = New System.Drawing.Size(9, 32)
        Me.pnlProgress.TabIndex = 3
        '
        'picBird1
        '
        Me.picBird1.Location = New System.Drawing.Point(21, 75)
        Me.picBird1.Name = "picBird1"
        Me.TableLayoutPanel1.SetRowSpan(Me.picBird1, 3)
        Me.picBird1.Size = New System.Drawing.Size(304, 322)
        Me.picBird1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picBird1.TabIndex = 1
        Me.picBird1.TabStop = False
        '
        'picBird2
        '
        Me.picBird2.Location = New System.Drawing.Point(767, 75)
        Me.picBird2.Name = "picBird2"
        Me.TableLayoutPanel1.SetRowSpan(Me.picBird2, 3)
        Me.picBird2.Size = New System.Drawing.Size(302, 322)
        Me.picBird2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picBird2.TabIndex = 2
        Me.picBird2.TabStop = False
        '
        'lblCountDown
        '
        Me.lblCountDown.AutoSize = True
        Me.lblCountDown.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblCountDown.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblCountDown.Location = New System.Drawing.Point(331, 157)
        Me.lblCountDown.Name = "lblCountDown"
        Me.lblCountDown.Size = New System.Drawing.Size(430, 150)
        Me.lblCountDown.TabIndex = 4
        Me.lblCountDown.Text = "Label1"
        Me.lblCountDown.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblTextWait
        '
        Me.lblTextWait.AutoSize = True
        Me.lblTextWait.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblTextWait.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblTextWait.Location = New System.Drawing.Point(331, 72)
        Me.lblTextWait.Name = "lblTextWait"
        Me.lblTextWait.Size = New System.Drawing.Size(430, 85)
        Me.lblTextWait.TabIndex = 6
        Me.lblTextWait.Text = "เหลือเวลารอ"
        Me.lblTextWait.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblTextSec
        '
        Me.lblTextSec.AutoSize = True
        Me.lblTextSec.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblTextSec.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblTextSec.Location = New System.Drawing.Point(331, 307)
        Me.lblTextSec.Name = "lblTextSec"
        Me.lblTextSec.Size = New System.Drawing.Size(430, 93)
        Me.lblTextSec.TabIndex = 7
        Me.lblTextSec.Text = "วินาที"
        Me.lblTextSec.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'HeatFoodPage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1104, 631)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "HeatFoodPage"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "HeatFoodPage"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.pnlBack.ResumeLayout(False)
        CType(Me.picBird1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBird2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblTakeFood As Label
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    'Friend WithEvents CircularProgressBar1 As CircularProgressBar.CircularProgressBar
    Friend WithEvents Timer1 As Timer
    Friend WithEvents picBird1 As PictureBox
    Friend WithEvents picBird2 As PictureBox
    Friend WithEvents pnlProgress As Panel
    Friend WithEvents lblCountDown As Label
    Friend WithEvents pnlBack As Panel
    Friend WithEvents lblTextWait As Label
    Friend WithEvents lblTextSec As Label
End Class
