<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Payment
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.lblTextPrice = New System.Windows.Forms.Label()
        Me.lblPrice = New System.Windows.Forms.Label()
        Me.lblName = New System.Windows.Forms.Label()
        Me.lblTextName = New System.Windows.Forms.Label()
        Me.btnCoinEmu = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.lblTextTime = New System.Windows.Forms.Label()
        Me.lblTime = New System.Windows.Forms.Label()
        Me.ptbProduct = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblPaymentHead = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.ptbProduct, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.BackColor = System.Drawing.Color.White
        Me.TableLayoutPanel1.ColumnCount = 10
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 26.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 651.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 15.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 133.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 162.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 15.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 162.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 74.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 35.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.lblTextPrice, 3, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.lblPrice, 4, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.lblName, 4, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.lblTextName, 3, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.btnCoinEmu, 6, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.btnCancel, 4, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.lblTextTime, 6, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.lblTime, 7, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.ptbProduct, 1, 1)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 154)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 7
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 74.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 74.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 249.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 74.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1262, 690)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'lblTextPrice
        '
        Me.lblTextPrice.BackColor = System.Drawing.Color.White
        Me.lblTextPrice.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblTextPrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblTextPrice.Location = New System.Drawing.Point(695, 204)
        Me.lblTextPrice.Name = "lblTextPrice"
        Me.lblTextPrice.Size = New System.Drawing.Size(127, 74)
        Me.lblTextPrice.TabIndex = 11
        Me.lblTextPrice.Text = "ราคา"
        Me.lblTextPrice.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblPrice
        '
        Me.lblPrice.BackColor = System.Drawing.Color.White
        Me.lblPrice.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblPrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblPrice.Location = New System.Drawing.Point(828, 204)
        Me.lblPrice.Name = "lblPrice"
        Me.lblPrice.Size = New System.Drawing.Size(156, 74)
        Me.lblPrice.TabIndex = 13
        Me.lblPrice.Text = "ราคาสินค้า"
        Me.lblPrice.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblName
        '
        Me.lblName.BackColor = System.Drawing.Color.White
        Me.TableLayoutPanel1.SetColumnSpan(Me.lblName, 4)
        Me.lblName.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblName.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblName.Location = New System.Drawing.Point(828, 87)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(407, 74)
        Me.lblName.TabIndex = 19
        Me.lblName.Text = "ชื่อสินค้าที่ซื้อ"
        Me.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblTextName
        '
        Me.lblTextName.BackColor = System.Drawing.Color.White
        Me.lblTextName.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblTextName.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblTextName.Location = New System.Drawing.Point(695, 87)
        Me.lblTextName.Name = "lblTextName"
        Me.lblTextName.Size = New System.Drawing.Size(127, 74)
        Me.lblTextName.TabIndex = 10
        Me.lblTextName.Text = "ชื่อสินค้า"
        Me.lblTextName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnCoinEmu
        '
        Me.btnCoinEmu.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnCoinEmu.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnCoinEmu.Location = New System.Drawing.Point(1005, 208)
        Me.btnCoinEmu.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnCoinEmu.Name = "btnCoinEmu"
        Me.btnCoinEmu.Size = New System.Drawing.Size(156, 66)
        Me.btnCoinEmu.TabIndex = 15
        Me.btnCoinEmu.Text = "หยอดเหรียญ"
        Me.btnCoinEmu.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnCancel.Location = New System.Drawing.Point(828, 531)
        Me.btnCancel.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(156, 66)
        Me.btnCancel.TabIndex = 16
        Me.btnCancel.Text = "ยกเลิกการซื้อ"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'lblTextTime
        '
        Me.lblTextTime.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblTextTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblTextTime.Location = New System.Drawing.Point(1005, 527)
        Me.lblTextTime.Name = "lblTextTime"
        Me.lblTextTime.Size = New System.Drawing.Size(156, 74)
        Me.lblTextTime.TabIndex = 21
        Me.lblTextTime.Text = "เวลาทำการ"
        Me.lblTextTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblTime
        '
        Me.lblTime.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblTime.Location = New System.Drawing.Point(1167, 527)
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(68, 74)
        Me.lblTime.TabIndex = 22
        Me.lblTime.Text = "0"
        Me.lblTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ptbProduct
        '
        Me.ptbProduct.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ptbProduct.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ptbProduct.Location = New System.Drawing.Point(29, 91)
        Me.ptbProduct.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ptbProduct.Name = "ptbProduct"
        Me.TableLayoutPanel1.SetRowSpan(Me.ptbProduct, 5)
        Me.ptbProduct.Size = New System.Drawing.Size(645, 506)
        Me.ptbProduct.TabIndex = 23
        Me.ptbProduct.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Panel1.Controls.Add(Me.lblPaymentHead)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1262, 156)
        Me.Panel1.TabIndex = 1
        '
        'lblPaymentHead
        '
        Me.lblPaymentHead.AutoSize = True
        Me.lblPaymentHead.Font = New System.Drawing.Font("Microsoft Sans Serif", 28.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblPaymentHead.Location = New System.Drawing.Point(49, 38)
        Me.lblPaymentHead.Name = "lblPaymentHead"
        Me.lblPaymentHead.Size = New System.Drawing.Size(175, 54)
        Me.lblPaymentHead.TabIndex = 0
        Me.lblPaymentHead.Text = "ชำระเงิน"
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'Payment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1262, 841)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "Payment"
        Me.Text = "Payment"
        Me.TableLayoutPanel1.ResumeLayout(False)
        CType(Me.ptbProduct, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblPaymentHead As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents lblTextName As Label
    Friend WithEvents lblTextPrice As Label
    Friend WithEvents lblPrice As Label
    Friend WithEvents lblName As Label
    Friend WithEvents btnCoinEmu As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents lblTextTime As Label
    Friend WithEvents lblTime As Label
    Friend WithEvents ptbProduct As PictureBox
End Class
