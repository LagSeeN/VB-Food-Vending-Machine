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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(HeatFoodPage))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblTakeFood = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.picBird1 = New System.Windows.Forms.PictureBox()
        Me.picBird2 = New System.Windows.Forms.PictureBox()
        Me.lblCountDown = New System.Windows.Forms.Label()
        Me.lblTextWait = New System.Windows.Forms.Label()
        Me.lblTextSec = New System.Windows.Forms.Label()
        Me.ProgressBar = New System.Windows.Forms.ProgressBar()
        Me.TimerWorker = New System.ComponentModel.BackgroundWorker()
        Me.Panel1.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
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
        Me.Panel1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1262, 156)
        Me.Panel1.TabIndex = 0
        '
        'lblTakeFood
        '
        Me.lblTakeFood.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblTakeFood.Font = New System.Drawing.Font("Microsoft Sans Serif", 28.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblTakeFood.ForeColor = System.Drawing.Color.White
        Me.lblTakeFood.Location = New System.Drawing.Point(0, 0)
        Me.lblTakeFood.Name = "lblTakeFood"
        Me.lblTakeFood.Size = New System.Drawing.Size(1262, 156)
        Me.lblTakeFood.TabIndex = 2
        Me.lblTakeFood.Text = "กรุณารอสักครู่ กำลังทำการอุ่นอาหาร..."
        Me.lblTakeFood.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.BackColor = System.Drawing.Color.White
        Me.TableLayoutPanel1.ColumnCount = 5
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 42.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 65.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.picBird1, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.picBird2, 3, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.lblCountDown, 2, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.lblTextWait, 2, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.lblTextSec, 2, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.ProgressBar, 2, 6)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 156)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 8
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 75.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.97195!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 113.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 200.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 85.02805!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 51.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 75.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1262, 685)
        Me.TableLayoutPanel1.TabIndex = 1
        '
        'picBird1
        '
        Me.picBird1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.picBird1.Image = CType(resources.GetObject("picBird1.Image"), System.Drawing.Image)
        Me.picBird1.Location = New System.Drawing.Point(45, 100)
        Me.picBird1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.picBird1.Name = "picBird1"
        Me.TableLayoutPanel1.SetRowSpan(Me.picBird1, 3)
        Me.picBird1.Size = New System.Drawing.Size(340, 429)
        Me.picBird1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picBird1.TabIndex = 1
        Me.picBird1.TabStop = False
        '
        'picBird2
        '
        Me.picBird2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.picBird2.Image = CType(resources.GetObject("picBird2.Image"), System.Drawing.Image)
        Me.picBird2.Location = New System.Drawing.Point(853, 100)
        Me.picBird2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.picBird2.Name = "picBird2"
        Me.TableLayoutPanel1.SetRowSpan(Me.picBird2, 3)
        Me.picBird2.Size = New System.Drawing.Size(340, 429)
        Me.picBird2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picBird2.TabIndex = 2
        Me.picBird2.TabStop = False
        '
        'lblCountDown
        '
        Me.lblCountDown.AutoSize = True
        Me.lblCountDown.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblCountDown.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblCountDown.Location = New System.Drawing.Point(391, 209)
        Me.lblCountDown.Name = "lblCountDown"
        Me.lblCountDown.Size = New System.Drawing.Size(456, 200)
        Me.lblCountDown.TabIndex = 4
        Me.lblCountDown.Text = "Label1"
        Me.lblCountDown.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblTextWait
        '
        Me.lblTextWait.AutoSize = True
        Me.lblTextWait.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblTextWait.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblTextWait.Location = New System.Drawing.Point(391, 96)
        Me.lblTextWait.Name = "lblTextWait"
        Me.lblTextWait.Size = New System.Drawing.Size(456, 113)
        Me.lblTextWait.TabIndex = 6
        Me.lblTextWait.Text = "เหลือเวลารอ"
        Me.lblTextWait.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblTextSec
        '
        Me.lblTextSec.AutoSize = True
        Me.lblTextSec.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblTextSec.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblTextSec.Location = New System.Drawing.Point(391, 409)
        Me.lblTextSec.Name = "lblTextSec"
        Me.lblTextSec.Size = New System.Drawing.Size(456, 124)
        Me.lblTextSec.TabIndex = 7
        Me.lblTextSec.Text = "วินาที"
        Me.lblTextSec.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ProgressBar
        '
        Me.ProgressBar.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ProgressBar.Location = New System.Drawing.Point(391, 562)
        Me.ProgressBar.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ProgressBar.Name = "ProgressBar"
        Me.ProgressBar.Size = New System.Drawing.Size(456, 43)
        Me.ProgressBar.Step = 1
        Me.ProgressBar.TabIndex = 8
        '
        'TimerWorker
        '
        Me.TimerWorker.WorkerReportsProgress = True
        '
        'HeatFoodPage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1262, 841)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.Panel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "HeatFoodPage"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "HeatFoodPage"
        Me.Panel1.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        CType(Me.picBird1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBird2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblTakeFood As Label
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents picBird1 As PictureBox
    Friend WithEvents picBird2 As PictureBox
    Friend WithEvents lblCountDown As Label
    Friend WithEvents lblTextWait As Label
    Friend WithEvents lblTextSec As Label
    Friend WithEvents ProgressBar As ProgressBar
    Friend WithEvents TimerWorker As System.ComponentModel.BackgroundWorker
End Class
