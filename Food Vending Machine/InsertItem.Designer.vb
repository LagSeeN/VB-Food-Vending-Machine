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
        Me.itemPicBox = New System.Windows.Forms.PictureBox()
        Me.nameLabel = New System.Windows.Forms.Label()
        Me.priceLabel = New System.Windows.Forms.Label()
        Me.stockLabel = New System.Windows.Forms.Label()
        Me.timeLabel = New System.Windows.Forms.Label()
        Me.nameTextBox = New System.Windows.Forms.TextBox()
        Me.priceInput = New System.Windows.Forms.NumericUpDown()
        Me.stockInput = New System.Windows.Forms.NumericUpDown()
        Me.timeInput = New System.Windows.Forms.NumericUpDown()
        Me.availableLabel = New System.Windows.Forms.Label()
        Me.availableCheck = New System.Windows.Forms.CheckBox()
        Me.uploadBtn = New System.Windows.Forms.Button()
        Me.cancelBtn = New System.Windows.Forms.Button()
        Me.acceptBtn = New System.Windows.Forms.Button()
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
        Me.headerPanel.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.headerPanel.Name = "headerPanel"
        Me.headerPanel.Size = New System.Drawing.Size(1104, 94)
        Me.headerPanel.TabIndex = 1
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 15
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.16981!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.63774!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 1.51333!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.693!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 1.08095!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.197443!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2.017771!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2.738406!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.01426!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.76862!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.131537!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2.931854!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 1.361353!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.154273!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.407989!))
        Me.TableLayoutPanel1.Controls.Add(Me.cbm_productList, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.itemPicBox, 9, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.nameLabel, 1, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.priceLabel, 1, 6)
        Me.TableLayoutPanel1.Controls.Add(Me.stockLabel, 1, 8)
        Me.TableLayoutPanel1.Controls.Add(Me.timeLabel, 1, 10)
        Me.TableLayoutPanel1.Controls.Add(Me.nameTextBox, 3, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.priceInput, 3, 6)
        Me.TableLayoutPanel1.Controls.Add(Me.stockInput, 3, 8)
        Me.TableLayoutPanel1.Controls.Add(Me.timeInput, 3, 10)
        Me.TableLayoutPanel1.Controls.Add(Me.availableLabel, 1, 12)
        Me.TableLayoutPanel1.Controls.Add(Me.availableCheck, 3, 12)
        Me.TableLayoutPanel1.Controls.Add(Me.uploadBtn, 11, 10)
        Me.TableLayoutPanel1.Controls.Add(Me.cancelBtn, 13, 12)
        Me.TableLayoutPanel1.Controls.Add(Me.acceptBtn, 10, 12)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 94)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 14
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.197605!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.983706!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.358325!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3.422366!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.814399!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.050653!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.811974!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.050653!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.811974!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.050653!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.150098!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3.843041!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.64016!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.814399!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1104, 411)
        Me.TableLayoutPanel1.TabIndex = 2
        '
        'cbm_productList
        '
        Me.cbm_productList.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cbm_productList.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.TableLayoutPanel1.SetColumnSpan(Me.cbm_productList, 7)
        Me.cbm_productList.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cbm_productList.FormattingEnabled = True
        Me.cbm_productList.Location = New System.Drawing.Point(126, 39)
        Me.cbm_productList.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cbm_productList.Name = "cbm_productList"
        Me.cbm_productList.Size = New System.Drawing.Size(375, 29)
        Me.cbm_productList.TabIndex = 1
        '
        'itemPicBox
        '
        Me.itemPicBox.BackColor = System.Drawing.Color.Transparent
        Me.itemPicBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.TableLayoutPanel1.SetColumnSpan(Me.itemPicBox, 5)
        Me.itemPicBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.itemPicBox.Location = New System.Drawing.Point(628, 39)
        Me.itemPicBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.itemPicBox.Name = "itemPicBox"
        Me.TableLayoutPanel1.SetRowSpan(Me.itemPicBox, 8)
        Me.itemPicBox.Size = New System.Drawing.Size(394, 204)
        Me.itemPicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.itemPicBox.TabIndex = 12
        Me.itemPicBox.TabStop = False
        '
        'nameLabel
        '
        Me.nameLabel.AutoSize = True
        Me.nameLabel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.nameLabel.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.nameLabel.Location = New System.Drawing.Point(126, 117)
        Me.nameLabel.Name = "nameLabel"
        Me.nameLabel.Size = New System.Drawing.Size(166, 32)
        Me.nameLabel.TabIndex = 13
        Me.nameLabel.Text = "ชื่อสินค้า"
        '
        'priceLabel
        '
        Me.priceLabel.AutoSize = True
        Me.priceLabel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.priceLabel.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.priceLabel.Location = New System.Drawing.Point(126, 165)
        Me.priceLabel.Name = "priceLabel"
        Me.priceLabel.Size = New System.Drawing.Size(166, 32)
        Me.priceLabel.TabIndex = 14
        Me.priceLabel.Text = "ราคา"
        '
        'stockLabel
        '
        Me.stockLabel.AutoSize = True
        Me.stockLabel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.stockLabel.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.stockLabel.Location = New System.Drawing.Point(126, 213)
        Me.stockLabel.Name = "stockLabel"
        Me.stockLabel.Size = New System.Drawing.Size(166, 32)
        Me.stockLabel.TabIndex = 15
        Me.stockLabel.Text = "สต็อกสินค้า"
        '
        'timeLabel
        '
        Me.timeLabel.AutoSize = True
        Me.timeLabel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.timeLabel.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.timeLabel.Location = New System.Drawing.Point(126, 261)
        Me.timeLabel.Name = "timeLabel"
        Me.timeLabel.Size = New System.Drawing.Size(166, 37)
        Me.timeLabel.TabIndex = 16
        Me.timeLabel.Text = "ระยะเวลาที่ใช้ในการอุ่น"
        '
        'nameTextBox
        '
        Me.TableLayoutPanel1.SetColumnSpan(Me.nameTextBox, 5)
        Me.nameTextBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.nameTextBox.Location = New System.Drawing.Point(314, 119)
        Me.nameTextBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.nameTextBox.MaxLength = 30
        Me.nameTextBox.Name = "nameTextBox"
        Me.nameTextBox.Size = New System.Drawing.Size(187, 29)
        Me.nameTextBox.TabIndex = 17
        '
        'priceInput
        '
        Me.TableLayoutPanel1.SetColumnSpan(Me.priceInput, 3)
        Me.priceInput.DecimalPlaces = 2
        Me.priceInput.Dock = System.Windows.Forms.DockStyle.Fill
        Me.priceInput.Location = New System.Drawing.Point(314, 167)
        Me.priceInput.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.priceInput.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.priceInput.Name = "priceInput"
        Me.priceInput.Size = New System.Drawing.Size(135, 29)
        Me.priceInput.TabIndex = 24
        '
        'stockInput
        '
        Me.TableLayoutPanel1.SetColumnSpan(Me.stockInput, 3)
        Me.stockInput.Dock = System.Windows.Forms.DockStyle.Fill
        Me.stockInput.Location = New System.Drawing.Point(314, 215)
        Me.stockInput.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.stockInput.Name = "stockInput"
        Me.stockInput.Size = New System.Drawing.Size(135, 29)
        Me.stockInput.TabIndex = 25
        '
        'timeInput
        '
        Me.TableLayoutPanel1.SetColumnSpan(Me.timeInput, 3)
        Me.timeInput.Dock = System.Windows.Forms.DockStyle.Fill
        Me.timeInput.Location = New System.Drawing.Point(314, 263)
        Me.timeInput.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.timeInput.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.timeInput.Name = "timeInput"
        Me.timeInput.Size = New System.Drawing.Size(135, 29)
        Me.timeInput.TabIndex = 26
        '
        'availableLabel
        '
        Me.availableLabel.AutoSize = True
        Me.availableLabel.Dock = System.Windows.Forms.DockStyle.Top
        Me.availableLabel.Location = New System.Drawing.Point(126, 313)
        Me.availableLabel.Name = "availableLabel"
        Me.availableLabel.Size = New System.Drawing.Size(166, 21)
        Me.availableLabel.TabIndex = 27
        Me.availableLabel.Text = "สถานะการจำหน่าย"
        '
        'availableCheck
        '
        Me.availableCheck.AutoSize = True
        Me.availableCheck.Dock = System.Windows.Forms.DockStyle.Top
        Me.availableCheck.Location = New System.Drawing.Point(314, 316)
        Me.availableCheck.Name = "availableCheck"
        Me.availableCheck.Size = New System.Drawing.Size(56, 25)
        Me.availableCheck.TabIndex = 28
        Me.availableCheck.Text = "มีการจำหน่าย"
        Me.availableCheck.UseVisualStyleBackColor = True
        '
        'uploadBtn
        '
        Me.TableLayoutPanel1.SetColumnSpan(Me.uploadBtn, 3)
        Me.uploadBtn.Dock = System.Windows.Forms.DockStyle.Top
        Me.uploadBtn.Location = New System.Drawing.Point(880, 263)
        Me.uploadBtn.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.uploadBtn.Name = "uploadBtn"
        Me.uploadBtn.Size = New System.Drawing.Size(142, 33)
        Me.uploadBtn.TabIndex = 8
        Me.uploadBtn.Text = "อัพโหลดภาพ"
        Me.uploadBtn.UseVisualStyleBackColor = True
        '
        'cancelBtn
        '
        Me.cancelBtn.Dock = System.Windows.Forms.DockStyle.Top
        Me.cancelBtn.Location = New System.Drawing.Point(927, 315)
        Me.cancelBtn.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cancelBtn.Name = "cancelBtn"
        Me.cancelBtn.Size = New System.Drawing.Size(95, 31)
        Me.cancelBtn.TabIndex = 11
        Me.cancelBtn.Text = "ยกเลิก"
        Me.cancelBtn.UseVisualStyleBackColor = True
        '
        'acceptBtn
        '
        Me.TableLayoutPanel1.SetColumnSpan(Me.acceptBtn, 2)
        Me.acceptBtn.Dock = System.Windows.Forms.DockStyle.Top
        Me.acceptBtn.Location = New System.Drawing.Point(802, 315)
        Me.acceptBtn.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.acceptBtn.Name = "acceptBtn"
        Me.acceptBtn.Size = New System.Drawing.Size(104, 31)
        Me.acceptBtn.TabIndex = 9
        Me.acceptBtn.Text = "ยืนยัน"
        Me.acceptBtn.UseVisualStyleBackColor = True
        '
        'InsertItem
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1104, 505)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.headerPanel)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
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
    Friend WithEvents availableLabel As Label
    Friend WithEvents availableCheck As CheckBox
End Class
