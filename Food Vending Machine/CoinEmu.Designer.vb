<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CoinEmu
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
        Me.footerPanel = New System.Windows.Forms.Panel()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.CoinEmuTableLayoutPanel = New System.Windows.Forms.TableLayoutPanel()
        Me.coinTotalTB = New System.Windows.Forms.TextBox()
        Me.oneCoinBtn = New System.Windows.Forms.Button()
        Me.fiveCoinBtn = New System.Windows.Forms.Button()
        Me.tenCoinBtn = New System.Windows.Forms.Button()
        Me.cancelBtn = New System.Windows.Forms.Button()
        Me.CoinEmuTableLayoutPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'footerPanel
        '
        Me.footerPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.footerPanel.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.footerPanel.Location = New System.Drawing.Point(0, 281)
        Me.footerPanel.Name = "footerPanel"
        Me.footerPanel.Size = New System.Drawing.Size(462, 52)
        Me.footerPanel.TabIndex = 1
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(0, 0)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 27)
        Me.TextBox1.TabIndex = 0
        Me.TextBox1.Text = "TextBox1"
        '
        'CoinEmuTableLayoutPanel
        '
        Me.CoinEmuTableLayoutPanel.ColumnCount = 7
        Me.CoinEmuTableLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.294656!))
        Me.CoinEmuTableLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26.05234!))
        Me.CoinEmuTableLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 3.624672!))
        Me.CoinEmuTableLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26.05594!))
        Me.CoinEmuTableLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 3.621797!))
        Me.CoinEmuTableLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26.05594!))
        Me.CoinEmuTableLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.294657!))
        Me.CoinEmuTableLayoutPanel.Controls.Add(Me.coinTotalTB, 1, 1)
        Me.CoinEmuTableLayoutPanel.Controls.Add(Me.oneCoinBtn, 1, 3)
        Me.CoinEmuTableLayoutPanel.Controls.Add(Me.fiveCoinBtn, 3, 3)
        Me.CoinEmuTableLayoutPanel.Controls.Add(Me.tenCoinBtn, 5, 3)
        Me.CoinEmuTableLayoutPanel.Controls.Add(Me.cancelBtn, 5, 5)
        Me.CoinEmuTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CoinEmuTableLayoutPanel.Location = New System.Drawing.Point(0, 0)
        Me.CoinEmuTableLayoutPanel.Name = "CoinEmuTableLayoutPanel"
        Me.CoinEmuTableLayoutPanel.RowCount = 7
        Me.CoinEmuTableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.88077!))
        Me.CoinEmuTableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 21.35231!))
        Me.CoinEmuTableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.761566!))
        Me.CoinEmuTableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.50534!))
        Me.CoinEmuTableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.94662!))
        Me.CoinEmuTableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.08185!))
        Me.CoinEmuTableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.252669!))
        Me.CoinEmuTableLayoutPanel.Size = New System.Drawing.Size(462, 281)
        Me.CoinEmuTableLayoutPanel.TabIndex = 2
        '
        'coinTotalTB
        '
        Me.CoinEmuTableLayoutPanel.SetColumnSpan(Me.coinTotalTB, 5)
        Me.coinTotalTB.Dock = System.Windows.Forms.DockStyle.Top
        Me.coinTotalTB.Font = New System.Drawing.Font("Segoe UI", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.coinTotalTB.Location = New System.Drawing.Point(36, 36)
        Me.coinTotalTB.Name = "coinTotalTB"
        Me.coinTotalTB.ReadOnly = True
        Me.coinTotalTB.Size = New System.Drawing.Size(386, 61)
        Me.coinTotalTB.TabIndex = 0
        Me.coinTotalTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'oneCoinBtn
        '
        Me.oneCoinBtn.Dock = System.Windows.Forms.DockStyle.Top
        Me.oneCoinBtn.Location = New System.Drawing.Point(36, 115)
        Me.oneCoinBtn.Name = "oneCoinBtn"
        Me.oneCoinBtn.Size = New System.Drawing.Size(114, 46)
        Me.oneCoinBtn.TabIndex = 1
        Me.oneCoinBtn.Text = "1"
        Me.oneCoinBtn.UseVisualStyleBackColor = True
        '
        'fiveCoinBtn
        '
        Me.fiveCoinBtn.Dock = System.Windows.Forms.DockStyle.Top
        Me.fiveCoinBtn.Location = New System.Drawing.Point(172, 115)
        Me.fiveCoinBtn.Name = "fiveCoinBtn"
        Me.fiveCoinBtn.Size = New System.Drawing.Size(114, 46)
        Me.fiveCoinBtn.TabIndex = 2
        Me.fiveCoinBtn.Text = "5"
        Me.fiveCoinBtn.UseVisualStyleBackColor = True
        '
        'tenCoinBtn
        '
        Me.tenCoinBtn.Dock = System.Windows.Forms.DockStyle.Top
        Me.tenCoinBtn.Location = New System.Drawing.Point(308, 115)
        Me.tenCoinBtn.Name = "tenCoinBtn"
        Me.tenCoinBtn.Size = New System.Drawing.Size(114, 46)
        Me.tenCoinBtn.TabIndex = 3
        Me.tenCoinBtn.Text = "10"
        Me.tenCoinBtn.UseVisualStyleBackColor = True
        '
        'cancelBtn
        '
        Me.cancelBtn.Dock = System.Windows.Forms.DockStyle.Top
        Me.cancelBtn.Location = New System.Drawing.Point(308, 209)
        Me.cancelBtn.Name = "cancelBtn"
        Me.cancelBtn.Size = New System.Drawing.Size(114, 40)
        Me.cancelBtn.TabIndex = 5
        Me.cancelBtn.Text = "ยกเลิก"
        Me.cancelBtn.UseVisualStyleBackColor = True
        '
        'CoinEmu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(462, 333)
        Me.Controls.Add(Me.CoinEmuTableLayoutPanel)
        Me.Controls.Add(Me.footerPanel)
        Me.MaximizeBox = False
        Me.Name = "CoinEmu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CoinEmu"
        Me.CoinEmuTableLayoutPanel.ResumeLayout(False)
        Me.CoinEmuTableLayoutPanel.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents footerPanel As Panel
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents CoinEmuTableLayoutPanel As TableLayoutPanel
    Friend WithEvents coinTotalTB As TextBox
    Friend WithEvents oneCoinBtn As Button
    Friend WithEvents fiveCoinBtn As Button
    Friend WithEvents tenCoinBtn As Button
    Friend WithEvents cancelBtn As Button
End Class
