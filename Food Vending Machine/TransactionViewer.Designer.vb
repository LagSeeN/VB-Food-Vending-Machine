<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TransactionViewer
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
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.dgvTransaction = New System.Windows.Forms.DataGridView()
        Me.headerPanel.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.dgvTransaction, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'headerPanel
        '
        Me.headerPanel.BackColor = System.Drawing.Color.Coral
        Me.headerPanel.Controls.Add(Me.lblTitle)
        Me.headerPanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.headerPanel.Location = New System.Drawing.Point(0, 0)
        Me.headerPanel.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.headerPanel.Name = "headerPanel"
        Me.headerPanel.Size = New System.Drawing.Size(1002, 94)
        Me.headerPanel.TabIndex = 2
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 45.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblTitle.ForeColor = System.Drawing.Color.White
        Me.lblTitle.Location = New System.Drawing.Point(65, 27)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(356, 69)
        Me.lblTitle.TabIndex = 1
        Me.lblTitle.Text = "รายการซื้อขาย"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 3
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.206293!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 86.97553!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.818181!))
        Me.TableLayoutPanel1.Controls.Add(Me.dgvTransaction, 1, 1)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 94)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 3
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.50324!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80.56155!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.719222!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1002, 347)
        Me.TableLayoutPanel1.TabIndex = 3
        '
        'dgvTransaction
        '
        Me.dgvTransaction.AllowUserToAddRows = False
        Me.dgvTransaction.AllowUserToDeleteRows = False
        Me.dgvTransaction.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvTransaction.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvTransaction.Location = New System.Drawing.Point(65, 35)
        Me.dgvTransaction.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.dgvTransaction.Name = "dgvTransaction"
        Me.dgvTransaction.ReadOnly = True
        Me.dgvTransaction.RowHeadersWidth = 51
        Me.dgvTransaction.RowTemplate.Height = 29
        Me.dgvTransaction.Size = New System.Drawing.Size(865, 276)
        Me.dgvTransaction.TabIndex = 0
        '
        'TransactionViewer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1002, 441)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.headerPanel)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "TransactionViewer"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "TransactionViewer"
        Me.headerPanel.ResumeLayout(False)
        Me.headerPanel.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        CType(Me.dgvTransaction, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents headerPanel As Panel
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents dgvTransaction As DataGridView
    Friend WithEvents lblTitle As Label
End Class
