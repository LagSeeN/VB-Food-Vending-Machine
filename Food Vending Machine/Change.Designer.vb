<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Change
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Change))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblTakeFood = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.lblTextHeat = New System.Windows.Forms.Label()
        Me.btnHeat = New System.Windows.Forms.Button()
        Me.btnNotHeat = New System.Windows.Forms.Button()
        Me.picBird3 = New System.Windows.Forms.PictureBox()
        Me.lblChange = New System.Windows.Forms.Label()
        Me.lblBahtText = New System.Windows.Forms.Label()
        Me.lblTextChange = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.picBird3, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.lblTakeFood.Location = New System.Drawing.Point(395, 30)
        Me.lblTakeFood.Name = "lblTakeFood"
        Me.lblTakeFood.Size = New System.Drawing.Size(260, 44)
        Me.lblTakeFood.TabIndex = 2
        Me.lblTakeFood.Text = "กรุณารับเงินทอน"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.BackColor = System.Drawing.Color.White
        Me.TableLayoutPanel1.ColumnCount = 9
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 250.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 39.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 214.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 18.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 134.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 29.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 134.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 226.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.lblTextHeat, 1, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.btnHeat, 5, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.btnNotHeat, 7, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.picBird3, 3, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.lblChange, 5, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.lblBahtText, 7, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.lblTextChange, 2, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 117)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 6
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 72.63158!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 27.36842!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 296.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 41.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1104, 514)
        Me.TableLayoutPanel1.TabIndex = 1
        '
        'lblTextHeat
        '
        Me.lblTextHeat.AutoSize = True
        Me.TableLayoutPanel1.SetColumnSpan(Me.lblTextHeat, 3)
        Me.lblTextHeat.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblTextHeat.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblTextHeat.Location = New System.Drawing.Point(253, 412)
        Me.lblTextHeat.Name = "lblTextHeat"
        Me.lblTextHeat.Size = New System.Drawing.Size(307, 60)
        Me.lblTextHeat.TabIndex = 0
        Me.lblTextHeat.Text = "ต้องการอุ่นอาหารหรือไม่"
        Me.lblTextHeat.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnHeat
        '
        Me.btnHeat.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnHeat.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnHeat.Location = New System.Drawing.Point(584, 415)
        Me.btnHeat.Name = "btnHeat"
        Me.btnHeat.Size = New System.Drawing.Size(128, 54)
        Me.btnHeat.TabIndex = 1
        Me.btnHeat.Text = "อุ่นอาหาร"
        Me.btnHeat.UseVisualStyleBackColor = True
        '
        'btnNotHeat
        '
        Me.btnNotHeat.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnNotHeat.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnNotHeat.Location = New System.Drawing.Point(747, 415)
        Me.btnNotHeat.Name = "btnNotHeat"
        Me.btnNotHeat.Size = New System.Drawing.Size(128, 54)
        Me.btnNotHeat.TabIndex = 2
        Me.btnNotHeat.Text = "ไม่อุ่นอาหาร"
        Me.btnNotHeat.UseVisualStyleBackColor = True
        '
        'picBird3
        '
        Me.TableLayoutPanel1.SetColumnSpan(Me.picBird3, 4)
        Me.picBird3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.picBird3.Image = CType(resources.GetObject("picBird3.Image"), System.Drawing.Image)
        Me.picBird3.Location = New System.Drawing.Point(352, 85)
        Me.picBird3.Name = "picBird3"
        Me.picBird3.Size = New System.Drawing.Size(389, 290)
        Me.picBird3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picBird3.TabIndex = 3
        Me.picBird3.TabStop = False
        '
        'lblChange
        '
        Me.lblChange.AutoSize = True
        Me.lblChange.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblChange.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblChange.Location = New System.Drawing.Point(584, 0)
        Me.lblChange.Name = "lblChange"
        Me.lblChange.Size = New System.Drawing.Size(128, 60)
        Me.lblChange.TabIndex = 5
        Me.lblChange.Text = "เงินทอน"
        Me.lblChange.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblBahtText
        '
        Me.lblBahtText.AutoSize = True
        Me.lblBahtText.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblBahtText.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblBahtText.Location = New System.Drawing.Point(747, 0)
        Me.lblBahtText.Name = "lblBahtText"
        Me.lblBahtText.Size = New System.Drawing.Size(128, 60)
        Me.lblBahtText.TabIndex = 6
        Me.lblBahtText.Text = "บาท"
        Me.lblBahtText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblTextChange
        '
        Me.lblTextChange.AutoSize = True
        Me.TableLayoutPanel1.SetColumnSpan(Me.lblTextChange, 2)
        Me.lblTextChange.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblTextChange.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblTextChange.Location = New System.Drawing.Point(292, 0)
        Me.lblTextChange.Name = "lblTextChange"
        Me.lblTextChange.Size = New System.Drawing.Size(268, 60)
        Me.lblTextChange.TabIndex = 7
        Me.lblTextChange.Text = "เงินทอนทั้งหมด"
        Me.lblTextChange.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Change
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1104, 631)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Change"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Change"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        CType(Me.picBird3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblTakeFood As Label
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents lblTextHeat As Label
    Friend WithEvents btnHeat As Button
    Friend WithEvents btnNotHeat As Button
    Friend WithEvents picBird3 As PictureBox
    Friend WithEvents lblChange As Label
    Friend WithEvents lblBahtText As Label
    Friend WithEvents lblTextChange As Label
End Class
