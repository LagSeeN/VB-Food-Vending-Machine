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
        Me.picBird1 = New System.Windows.Forms.PictureBox()
        Me.picBird2 = New System.Windows.Forms.PictureBox()
        Me.pnlProgress = New System.Windows.Forms.Panel()
        Me.lblCountDown = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.pnlBack = New System.Windows.Forms.Panel()
        Me.lblTextWait = New System.Windows.Forms.Label()
        Me.lblTextSec = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.picBird1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBird2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlBack.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Panel1.Controls.Add(Me.lblTakeFood)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1262, 125)
        Me.Panel1.TabIndex = 0
        '
        'lblTakeFood
        '
        Me.lblTakeFood.AutoSize = True
        Me.lblTakeFood.Font = New System.Drawing.Font("Microsoft Sans Serif", 28.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblTakeFood.Location = New System.Drawing.Point(278, 35)
        Me.lblTakeFood.Name = "lblTakeFood"
        Me.lblTakeFood.Size = New System.Drawing.Size(709, 55)
        Me.lblTakeFood.TabIndex = 2
        Me.lblTakeFood.Text = "กรุณารอสักครู่ กำลังทำการอุ่นอาหาร..."
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.BackColor = System.Drawing.Color.White
        Me.TableLayoutPanel1.ColumnCount = 5
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29.42178!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 41.37891!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29.19931!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 27.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.pnlBack, 2, 6)
        Me.TableLayoutPanel1.Controls.Add(Me.picBird1, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.picBird2, 3, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.lblCountDown, 2, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.lblTextWait, 2, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.lblTextSec, 2, 4)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 125)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 8
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.97195!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 91.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 160.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 85.02805!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1262, 548)
        Me.TableLayoutPanel1.TabIndex = 1
        '
        'picBird1
        '
        Me.picBird1.Image = Global.Food_Vending_Machine.My.Resources.Resources.BirdKnife
        Me.picBird1.Location = New System.Drawing.Point(23, 80)
        Me.picBird1.Name = "picBird1"
        Me.TableLayoutPanel1.SetRowSpan(Me.picBird1, 3)
        Me.picBird1.Size = New System.Drawing.Size(351, 344)
        Me.picBird1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picBird1.TabIndex = 1
        Me.picBird1.TabStop = False
        '
        'picBird2
        '
        Me.picBird2.Image = Global.Food_Vending_Machine.My.Resources.Resources.BirdChef1
        Me.picBird2.Location = New System.Drawing.Point(882, 80)
        Me.picBird2.Name = "picBird2"
        Me.TableLayoutPanel1.SetRowSpan(Me.picBird2, 3)
        Me.picBird2.Size = New System.Drawing.Size(348, 344)
        Me.picBird2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picBird2.TabIndex = 2
        Me.picBird2.TabStop = False
        '
        'pnlProgress
        '
        Me.pnlProgress.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.pnlProgress.Location = New System.Drawing.Point(0, 0)
        Me.pnlProgress.Name = "pnlProgress"
        Me.pnlProgress.Size = New System.Drawing.Size(10, 34)
        Me.pnlProgress.TabIndex = 3
        '
        'lblCountDown
        '
        Me.lblCountDown.AutoSize = True
        Me.lblCountDown.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblCountDown.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblCountDown.Location = New System.Drawing.Point(380, 168)
        Me.lblCountDown.Name = "lblCountDown"
        Me.lblCountDown.Size = New System.Drawing.Size(496, 160)
        Me.lblCountDown.TabIndex = 4
        Me.lblCountDown.Text = "Label1"
        Me.lblCountDown.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Timer1
        '
        '
        'pnlBack
        '
        Me.pnlBack.BackColor = System.Drawing.Color.DarkGray
        Me.pnlBack.Controls.Add(Me.pnlProgress)
        Me.pnlBack.Location = New System.Drawing.Point(380, 450)
        Me.pnlBack.Name = "pnlBack"
        Me.pnlBack.Size = New System.Drawing.Size(488, 34)
        Me.pnlBack.TabIndex = 5
        '
        'lblTextWait
        '
        Me.lblTextWait.AutoSize = True
        Me.lblTextWait.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblTextWait.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblTextWait.Location = New System.Drawing.Point(380, 77)
        Me.lblTextWait.Name = "lblTextWait"
        Me.lblTextWait.Size = New System.Drawing.Size(496, 91)
        Me.lblTextWait.TabIndex = 6
        Me.lblTextWait.Text = "เหลือเวลารอ"
        Me.lblTextWait.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblTextSec
        '
        Me.lblTextSec.AutoSize = True
        Me.lblTextSec.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblTextSec.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblTextSec.Location = New System.Drawing.Point(380, 328)
        Me.lblTextSec.Name = "lblTextSec"
        Me.lblTextSec.Size = New System.Drawing.Size(496, 99)
        Me.lblTextSec.TabIndex = 7
        Me.lblTextSec.Text = "วินาที"
        Me.lblTextSec.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'HeatFoodPage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1262, 673)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "HeatFoodPage"
        Me.Text = "HeatFoodPage"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        CType(Me.picBird1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBird2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlBack.ResumeLayout(False)
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
