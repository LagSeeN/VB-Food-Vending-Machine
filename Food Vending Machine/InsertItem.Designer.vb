<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class InsertItem
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
        Me.headerPanel = New System.Windows.Forms.Panel()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.cbm_productList = New System.Windows.Forms.ComboBox()
        Me.uploadBtn = New System.Windows.Forms.Button()
        Me.cancelBtn = New System.Windows.Forms.Button()
        Me.acceptBtn = New System.Windows.Forms.Button()
        Me.itemPicBox = New System.Windows.Forms.PictureBox()
        Me.nameLabel = New System.Windows.Forms.Label()
        Me.priceLabel = New System.Windows.Forms.Label()
        Me.stockLabel = New System.Windows.Forms.Label()
        Me.timeLabel = New System.Windows.Forms.Label()
        Me.nameTextBox = New System.Windows.Forms.TextBox()
        Me.priceInput = New System.Windows.Forms.NumericUpDown()
        Me.stockInput = New System.Windows.Forms.NumericUpDown()
        Me.timeInput = New System.Windows.Forms.NumericUpDown()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.itemPicBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.priceInput, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.stockInput, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.timeInput, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'headerPanel
        '
        Me.headerPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.headerPanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.headerPanel.Location = New System.Drawing.Point(0, 0)
        Me.headerPanel.Name = "headerPanel"
        Me.headerPanel.Size = New System.Drawing.Size(1262, 125)
        Me.headerPanel.TabIndex = 1
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 14
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.28679!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.20151!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 1.664663!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.2623!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 1.189045!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.817188!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2.219548!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 3.012247!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.579379!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.3478!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.803555!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 1.497488!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.0697!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.048788!))
        Me.TableLayoutPanel1.Controls.Add(Me.cbm_productList, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.uploadBtn, 12, 11)
        Me.TableLayoutPanel1.Controls.Add(Me.cancelBtn, 12, 13)
        Me.TableLayoutPanel1.Controls.Add(Me.acceptBtn, 10, 13)
        Me.TableLayoutPanel1.Controls.Add(Me.itemPicBox, 9, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.nameLabel, 1, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.priceLabel, 1, 7)
        Me.TableLayoutPanel1.Controls.Add(Me.stockLabel, 1, 9)
        Me.TableLayoutPanel1.Controls.Add(Me.timeLabel, 1, 11)
        Me.TableLayoutPanel1.Controls.Add(Me.nameTextBox, 3, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.priceInput, 3, 7)
        Me.TableLayoutPanel1.Controls.Add(Me.stockInput, 3, 9)
        Me.TableLayoutPanel1.Controls.Add(Me.timeInput, 3, 11)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 125)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 15
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.374806!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.180044!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.284783!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.10149!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3.116208!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.11534!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3.688291!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.113132!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3.688291!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.113132!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3.688291!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.113132!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.037651!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.27007!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.11534!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1262, 548)
        Me.TableLayoutPanel1.TabIndex = 2
        '
        'cbm_productList
        '
        Me.cbm_productList.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cbm_productList.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.TableLayoutPanel1.SetColumnSpan(Me.cbm_productList, 7)
        Me.cbm_productList.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cbm_productList.FormattingEnabled = True
        Me.cbm_productList.Location = New System.Drawing.Point(158, 48)
        Me.cbm_productList.Name = "cbm_productList"
        Me.cbm_productList.Size = New System.Drawing.Size(478, 36)
        Me.cbm_productList.TabIndex = 1
        '
        'uploadBtn
        '
        Me.uploadBtn.Dock = System.Windows.Forms.DockStyle.Top
        Me.uploadBtn.Location = New System.Drawing.Point(1047, 366)
        Me.uploadBtn.Name = "uploadBtn"
        Me.uploadBtn.Size = New System.Drawing.Size(121, 32)
        Me.uploadBtn.TabIndex = 8
        Me.uploadBtn.Text = "อัพโหลดภาพ"
        Me.uploadBtn.UseVisualStyleBackColor = True
        '
        'cancelBtn
        '
        Me.cancelBtn.Dock = System.Windows.Forms.DockStyle.Top
        Me.cancelBtn.Location = New System.Drawing.Point(1047, 437)
        Me.cancelBtn.Name = "cancelBtn"
        Me.cancelBtn.Size = New System.Drawing.Size(121, 34)
        Me.cancelBtn.TabIndex = 11
        Me.cancelBtn.Text = "ยกเลิก"
        Me.cancelBtn.UseVisualStyleBackColor = True
        '
        'acceptBtn
        '
        Me.acceptBtn.Dock = System.Windows.Forms.DockStyle.Top
        Me.acceptBtn.Location = New System.Drawing.Point(906, 437)
        Me.acceptBtn.Name = "acceptBtn"
        Me.acceptBtn.Size = New System.Drawing.Size(117, 34)
        Me.acceptBtn.TabIndex = 9
        Me.acceptBtn.Text = "ยืนยัน"
        Me.acceptBtn.UseVisualStyleBackColor = True
        '
        'itemPicBox
        '
        Me.itemPicBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TableLayoutPanel1.SetColumnSpan(Me.itemPicBox, 4)
        Me.itemPicBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.itemPicBox.Location = New System.Drawing.Point(725, 48)
        Me.itemPicBox.Name = "itemPicBox"
        Me.TableLayoutPanel1.SetRowSpan(Me.itemPicBox, 9)
        Me.itemPicBox.Size = New System.Drawing.Size(443, 292)
        Me.itemPicBox.TabIndex = 12
        Me.itemPicBox.TabStop = False
        '
        'nameLabel
        '
        Me.nameLabel.AutoSize = True
        Me.nameLabel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.nameLabel.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.nameLabel.Location = New System.Drawing.Point(158, 189)
        Me.nameLabel.Name = "nameLabel"
        Me.nameLabel.Size = New System.Drawing.Size(211, 38)
        Me.nameLabel.TabIndex = 13
        Me.nameLabel.Text = "ชื่อสินค้า"
        '
        'priceLabel
        '
        Me.priceLabel.AutoSize = True
        Me.priceLabel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.priceLabel.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.priceLabel.Location = New System.Drawing.Point(158, 247)
        Me.priceLabel.Name = "priceLabel"
        Me.priceLabel.Size = New System.Drawing.Size(211, 38)
        Me.priceLabel.TabIndex = 14
        Me.priceLabel.Text = "ราคา"
        '
        'stockLabel
        '
        Me.stockLabel.AutoSize = True
        Me.stockLabel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.stockLabel.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.stockLabel.Location = New System.Drawing.Point(158, 305)
        Me.stockLabel.Name = "stockLabel"
        Me.stockLabel.Size = New System.Drawing.Size(211, 38)
        Me.stockLabel.TabIndex = 15
        Me.stockLabel.Text = "สต็อกสินค้า"
        '
        'timeLabel
        '
        Me.timeLabel.AutoSize = True
        Me.timeLabel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.timeLabel.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.timeLabel.Location = New System.Drawing.Point(158, 363)
        Me.timeLabel.Name = "timeLabel"
        Me.timeLabel.Size = New System.Drawing.Size(211, 38)
        Me.timeLabel.TabIndex = 16
        Me.timeLabel.Text = "ระยะเวลาที่ใช้ในการอุ่น"
        '
        'nameTextBox
        '
        Me.TableLayoutPanel1.SetColumnSpan(Me.nameTextBox, 5)
        Me.nameTextBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.nameTextBox.Location = New System.Drawing.Point(396, 192)
        Me.nameTextBox.Name = "nameTextBox"
        Me.nameTextBox.Size = New System.Drawing.Size(240, 34)
        Me.nameTextBox.TabIndex = 17
        '
        'priceInput
        '
        Me.TableLayoutPanel1.SetColumnSpan(Me.priceInput, 3)
        Me.priceInput.DecimalPlaces = 2
        Me.priceInput.Dock = System.Windows.Forms.DockStyle.Fill
        Me.priceInput.Location = New System.Drawing.Point(396, 250)
        Me.priceInput.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.priceInput.Name = "priceInput"
        Me.priceInput.Size = New System.Drawing.Size(174, 34)
        Me.priceInput.TabIndex = 24
        '
        'stockInput
        '
        Me.TableLayoutPanel1.SetColumnSpan(Me.stockInput, 3)
        Me.stockInput.Dock = System.Windows.Forms.DockStyle.Fill
        Me.stockInput.Location = New System.Drawing.Point(396, 308)
        Me.stockInput.Name = "stockInput"
        Me.stockInput.Size = New System.Drawing.Size(174, 34)
        Me.stockInput.TabIndex = 25
        '
        'timeInput
        '
        Me.TableLayoutPanel1.SetColumnSpan(Me.timeInput, 3)
        Me.timeInput.Dock = System.Windows.Forms.DockStyle.Fill
        Me.timeInput.Location = New System.Drawing.Point(396, 366)
        Me.timeInput.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.timeInput.Name = "timeInput"
        Me.timeInput.Size = New System.Drawing.Size(174, 34)
        Me.timeInput.TabIndex = 26
        '
        'InsertItem
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1262, 673)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.headerPanel)
        Me.Name = "InsertItem"
        Me.Text = "InsertItem"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        CType(Me.itemPicBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.priceInput, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.stockInput, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.timeInput, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents headerPanel As Panel
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents cbm_productList As ComboBox
    Friend WithEvents uploadBtn As Button
    Friend WithEvents acceptBtn As Button
    Friend WithEvents cancelBtn As Button
    Friend WithEvents itemPicBox As PictureBox
    Friend WithEvents nameLabel As Label
    Friend WithEvents priceLabel As Label
    Friend WithEvents stockLabel As Label
    Friend WithEvents timeLabel As Label
    Friend WithEvents nameTextBox As TextBox
    Friend WithEvents priceInput As NumericUpDown
    Friend WithEvents stockInput As NumericUpDown
    Friend WithEvents timeInput As NumericUpDown
End Class
