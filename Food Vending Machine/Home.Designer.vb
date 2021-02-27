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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Home))
        Me.headerPanel = New System.Windows.Forms.Panel()
        Me.titleLabel = New System.Windows.Forms.Label()
        Me.homeTableLayoutPanel = New System.Windows.Forms.TableLayoutPanel()
        Me.foodListPanel = New System.Windows.Forms.Panel()
        Me.FoodView = New System.Windows.Forms.ListView()
        Me.buyBtn = New System.Windows.Forms.Button()
        Me.ProductListImage = New System.Windows.Forms.ImageList(Me.components)
        Me.Load_Products_Worker = New System.ComponentModel.BackgroundWorker()
        Me.headerPanel.SuspendLayout()
        Me.homeTableLayoutPanel.SuspendLayout()
        Me.foodListPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'headerPanel
        '
        Me.headerPanel.BackColor = System.Drawing.Color.Coral
        Me.headerPanel.Controls.Add(Me.titleLabel)
        Me.headerPanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.headerPanel.Location = New System.Drawing.Point(0, 0)
        Me.headerPanel.Name = "headerPanel"
        Me.headerPanel.Size = New System.Drawing.Size(1469, 125)
        Me.headerPanel.TabIndex = 0
        '
        'titleLabel
        '
        Me.titleLabel.AutoSize = True
        Me.titleLabel.Font = New System.Drawing.Font("Segoe UI", 28.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.titleLabel.ForeColor = System.Drawing.Color.White
        Me.titleLabel.Location = New System.Drawing.Point(89, 24)
        Me.titleLabel.Name = "titleLabel"
        Me.titleLabel.Size = New System.Drawing.Size(510, 62)
        Me.titleLabel.TabIndex = 0
        Me.titleLabel.Text = "Food Vending Machine"
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
        Me.homeTableLayoutPanel.Size = New System.Drawing.Size(1469, 548)
        Me.homeTableLayoutPanel.TabIndex = 1
        '
        'foodListPanel
        '
        Me.foodListPanel.BackColor = System.Drawing.SystemColors.ControlLight
        Me.homeTableLayoutPanel.SetColumnSpan(Me.foodListPanel, 4)
        Me.foodListPanel.Controls.Add(Me.FoodView)
        Me.foodListPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.foodListPanel.Location = New System.Drawing.Point(86, 24)
        Me.foodListPanel.Name = "foodListPanel"
        Me.foodListPanel.Size = New System.Drawing.Size(1320, 383)
        Me.foodListPanel.TabIndex = 0
        '
        'FoodView
        '
        Me.FoodView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FoodView.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.FoodView.HideSelection = False
        Me.FoodView.LabelWrap = False
        Me.FoodView.Location = New System.Drawing.Point(0, 0)
        Me.FoodView.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.FoodView.MultiSelect = False
        Me.FoodView.Name = "FoodView"
        Me.FoodView.Size = New System.Drawing.Size(1320, 383)
        Me.FoodView.TabIndex = 1
        Me.FoodView.UseCompatibleStateImageBehavior = False
        '
        'buyBtn
        '
        Me.buyBtn.Dock = System.Windows.Forms.DockStyle.Fill
        Me.buyBtn.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.buyBtn.Location = New System.Drawing.Point(1250, 432)
        Me.buyBtn.Name = "buyBtn"
        Me.buyBtn.Size = New System.Drawing.Size(156, 53)
        Me.buyBtn.TabIndex = 2
        Me.buyBtn.Text = "ชำระเงิน"
        Me.buyBtn.UseVisualStyleBackColor = True
        '
        'ProductListImage
        '
        Me.ProductListImage.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit
        Me.ProductListImage.ImageSize = New System.Drawing.Size(240, 240)
        Me.ProductListImage.TransparentColor = System.Drawing.Color.Transparent
        '
        'Load_Products_Worker
        '
        Me.Load_Products_Worker.WorkerSupportsCancellation = True
        '
        'Home
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1469, 673)
        Me.Controls.Add(Me.homeTableLayoutPanel)
        Me.Controls.Add(Me.headerPanel)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Home"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Home"
        Me.headerPanel.ResumeLayout(False)
        Me.headerPanel.PerformLayout()
        Me.homeTableLayoutPanel.ResumeLayout(False)
        Me.foodListPanel.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents headerPanel As Panel
    Friend WithEvents homeTableLayoutPanel As TableLayoutPanel
    Friend WithEvents buyBtn As Button
    Friend WithEvents foodListPanel As Panel
    Friend WithEvents FoodView As ListView
    Friend WithEvents ProductListImage As ImageList
    Friend WithEvents Load_Products_Worker As System.ComponentModel.BackgroundWorker
    Friend WithEvents titleLabel As Label
End Class
