<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Home
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
        Me.headerPanel = New System.Windows.Forms.Panel()
        Me.homeTableLayoutPanel = New System.Windows.Forms.TableLayoutPanel()
        Me.foodListPanel = New System.Windows.Forms.Panel()
        Me.foodListHScrollBar = New System.Windows.Forms.HScrollBar()
        Me.buyBtn = New System.Windows.Forms.Button()
        Me.homeTableLayoutPanel.SuspendLayout()
        Me.foodListPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'headerPanel
        '
        Me.headerPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.headerPanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.headerPanel.Location = New System.Drawing.Point(0, 0)
        Me.headerPanel.Name = "headerPanel"
        Me.headerPanel.Size = New System.Drawing.Size(1262, 125)
        Me.headerPanel.TabIndex = 0
        '
        'homeTableLayoutPanel
        '
        Me.homeTableLayoutPanel.ColumnCount = 7
        Me.homeTableLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.81!))
        Me.homeTableLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 92.19!))
        Me.homeTableLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 162.0!))
        Me.homeTableLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 18.0!))
        Me.homeTableLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 162.0!))
        Me.homeTableLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 16.0!))
        Me.homeTableLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 43.0!))
        Me.homeTableLayoutPanel.Controls.Add(Me.foodListPanel, 1, 1)
        Me.homeTableLayoutPanel.Controls.Add(Me.buyBtn, 4, 3)
        Me.homeTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.homeTableLayoutPanel.Location = New System.Drawing.Point(0, 125)
        Me.homeTableLayoutPanel.Name = "homeTableLayoutPanel"
        Me.homeTableLayoutPanel.RowCount = 5
        Me.homeTableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.992511!))
        Me.homeTableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90.58412!))
        Me.homeTableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.423365!))
        Me.homeTableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 59.0!))
        Me.homeTableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 59.0!))
        Me.homeTableLayoutPanel.Size = New System.Drawing.Size(1262, 548)
        Me.homeTableLayoutPanel.TabIndex = 1
        '
        'foodListPanel
        '
        Me.foodListPanel.BackColor = System.Drawing.SystemColors.ControlLight
        Me.homeTableLayoutPanel.SetColumnSpan(Me.foodListPanel, 4)
        Me.foodListPanel.Controls.Add(Me.foodListHScrollBar)
        Me.foodListPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.foodListPanel.Location = New System.Drawing.Point(70, 24)
        Me.foodListPanel.Name = "foodListPanel"
        Me.foodListPanel.Size = New System.Drawing.Size(1129, 383)
        Me.foodListPanel.TabIndex = 0
        '
        'foodListHScrollBar
        '
        Me.foodListHScrollBar.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.foodListHScrollBar.Location = New System.Drawing.Point(0, 361)
        Me.foodListHScrollBar.Name = "foodListHScrollBar"
        Me.foodListHScrollBar.Size = New System.Drawing.Size(1129, 22)
        Me.foodListHScrollBar.TabIndex = 0
        '
        'buyBtn
        '
        Me.buyBtn.Dock = System.Windows.Forms.DockStyle.Fill
        Me.buyBtn.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.buyBtn.Location = New System.Drawing.Point(1043, 432)
        Me.buyBtn.Name = "buyBtn"
        Me.buyBtn.Size = New System.Drawing.Size(156, 53)
        Me.buyBtn.TabIndex = 2
        Me.buyBtn.Text = "ชำระเงิน"
        Me.buyBtn.UseVisualStyleBackColor = True
        '
        'Home
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1262, 673)
        Me.Controls.Add(Me.homeTableLayoutPanel)
        Me.Controls.Add(Me.headerPanel)
        Me.Name = "Home"
        Me.Text = "Home"
        Me.homeTableLayoutPanel.ResumeLayout(False)
        Me.foodListPanel.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents headerPanel As Panel
    Friend WithEvents homeTableLayoutPanel As TableLayoutPanel
    Friend WithEvents foodListPanel As Panel
    Friend WithEvents foodListHScrollBar As HScrollBar
    Friend WithEvents buyBtn As Button
End Class
