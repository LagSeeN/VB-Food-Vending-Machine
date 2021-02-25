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
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.dtgTransaction = New System.Windows.Forms.DataGridView()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.dtgTransaction, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'headerPanel
        '
        Me.headerPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.headerPanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.headerPanel.Location = New System.Drawing.Point(0, 0)
        Me.headerPanel.Name = "headerPanel"
        Me.headerPanel.Size = New System.Drawing.Size(1145, 125)
        Me.headerPanel.TabIndex = 2
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 3
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.dtgTransaction, 1, 1)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 125)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 3
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1145, 463)
        Me.TableLayoutPanel1.TabIndex = 3
        '
        'dtgTransaction
        '
        Me.dtgTransaction.AllowUserToAddRows = False
        Me.dtgTransaction.AllowUserToDeleteRows = False
        Me.dtgTransaction.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgTransaction.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dtgTransaction.Location = New System.Drawing.Point(53, 53)
        Me.dtgTransaction.Name = "dtgTransaction"
        Me.dtgTransaction.ReadOnly = True
        Me.dtgTransaction.RowHeadersWidth = 51
        Me.dtgTransaction.RowTemplate.Height = 29
        Me.dtgTransaction.Size = New System.Drawing.Size(1039, 357)
        Me.dtgTransaction.TabIndex = 0
        '
        'TransactionViewer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1145, 588)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.headerPanel)
        Me.Name = "TransactionViewer"
        Me.Text = "TransactionViewer"
        Me.TableLayoutPanel1.ResumeLayout(False)
        CType(Me.dtgTransaction, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents headerPanel As Panel
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents dtgTransaction As DataGridView
End Class
