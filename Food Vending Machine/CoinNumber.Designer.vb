<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CoinNumber
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CoinNumber))
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.lblCoin1 = New System.Windows.Forms.Label()
        Me.lblCoin2 = New System.Windows.Forms.Label()
        Me.lblCoin3 = New System.Windows.Forms.Label()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.numCoin5 = New System.Windows.Forms.NumericUpDown()
        Me.numCoin1 = New System.Windows.Forms.NumericUpDown()
        Me.numCoin10 = New System.Windows.Forms.NumericUpDown()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.numCoin5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numCoin1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numCoin10, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 6
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.39345!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29.5082!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.46448!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 4.863388!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29.18033!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.59016!))
        Me.TableLayoutPanel1.Controls.Add(Me.lblCoin1, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.lblCoin2, 1, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.lblCoin3, 1, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.btnUpdate, 1, 7)
        Me.TableLayoutPanel1.Controls.Add(Me.numCoin5, 3, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.numCoin1, 3, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.numCoin10, 3, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.btnCancel, 4, 7)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 9
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.69519!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.69519!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.69519!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.69519!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.69519!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.69519!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.69519!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.4385!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.69519!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(360, 257)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'lblCoin1
        '
        Me.lblCoin1.AutoSize = True
        Me.lblCoin1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblCoin1.Location = New System.Drawing.Point(62, 27)
        Me.lblCoin1.Name = "lblCoin1"
        Me.lblCoin1.Size = New System.Drawing.Size(100, 27)
        Me.lblCoin1.TabIndex = 0
        Me.lblCoin1.Text = "เหรียญ 1 บาท"
        Me.lblCoin1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblCoin2
        '
        Me.lblCoin2.AutoSize = True
        Me.lblCoin2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblCoin2.Location = New System.Drawing.Point(62, 81)
        Me.lblCoin2.Name = "lblCoin2"
        Me.lblCoin2.Size = New System.Drawing.Size(100, 27)
        Me.lblCoin2.TabIndex = 1
        Me.lblCoin2.Text = "เหรียญ 5 บาท"
        Me.lblCoin2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblCoin3
        '
        Me.lblCoin3.AutoSize = True
        Me.lblCoin3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblCoin3.Location = New System.Drawing.Point(62, 135)
        Me.lblCoin3.Name = "lblCoin3"
        Me.lblCoin3.Size = New System.Drawing.Size(100, 27)
        Me.lblCoin3.TabIndex = 2
        Me.lblCoin3.Text = "เหรียญ 10 บาท"
        Me.lblCoin3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnUpdate
        '
        Me.btnUpdate.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnUpdate.Location = New System.Drawing.Point(62, 191)
        Me.btnUpdate.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(100, 33)
        Me.btnUpdate.TabIndex = 3
        Me.btnUpdate.Text = "บันทึก"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'numCoin5
        '
        Me.TableLayoutPanel1.SetColumnSpan(Me.numCoin5, 2)
        Me.numCoin5.Location = New System.Drawing.Point(187, 83)
        Me.numCoin5.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.numCoin5.Name = "numCoin5"
        Me.numCoin5.Size = New System.Drawing.Size(116, 23)
        Me.numCoin5.TabIndex = 6
        '
        'numCoin1
        '
        Me.TableLayoutPanel1.SetColumnSpan(Me.numCoin1, 2)
        Me.numCoin1.Location = New System.Drawing.Point(187, 29)
        Me.numCoin1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.numCoin1.Name = "numCoin1"
        Me.numCoin1.Size = New System.Drawing.Size(116, 23)
        Me.numCoin1.TabIndex = 5
        '
        'numCoin10
        '
        Me.TableLayoutPanel1.SetColumnSpan(Me.numCoin10, 2)
        Me.numCoin10.Location = New System.Drawing.Point(187, 137)
        Me.numCoin10.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.numCoin10.Name = "numCoin10"
        Me.numCoin10.Size = New System.Drawing.Size(116, 23)
        Me.numCoin10.TabIndex = 7
        '
        'btnCancel
        '
        Me.btnCancel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnCancel.Location = New System.Drawing.Point(204, 191)
        Me.btnCancel.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(99, 33)
        Me.btnCancel.TabIndex = 4
        Me.btnCancel.Text = "ยกเลิก"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'CoinNumber
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(360, 257)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "CoinNumber"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CoinNumber"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        CType(Me.numCoin5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numCoin1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numCoin10, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents lblCoin1 As Label
    Friend WithEvents lblCoin2 As Label
    Friend WithEvents lblCoin3 As Label
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents numCoin1 As NumericUpDown
    Friend WithEvents numCoin5 As NumericUpDown
    Friend WithEvents numCoin10 As NumericUpDown
End Class
