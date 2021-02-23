<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ModeSelect
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
        Me.AddProductBtn = New System.Windows.Forms.Button()
        Me.EditProductBtn = New System.Windows.Forms.Button()
        Me.SellProductBtn = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'AddProductBtn
        '
        Me.AddProductBtn.Location = New System.Drawing.Point(21, 12)
        Me.AddProductBtn.Name = "AddProductBtn"
        Me.AddProductBtn.Size = New System.Drawing.Size(342, 75)
        Me.AddProductBtn.TabIndex = 0
        Me.AddProductBtn.Text = "เพิ่มสินค้า"
        Me.AddProductBtn.UseVisualStyleBackColor = True
        '
        'EditProductBtn
        '
        Me.EditProductBtn.Location = New System.Drawing.Point(21, 104)
        Me.EditProductBtn.Name = "EditProductBtn"
        Me.EditProductBtn.Size = New System.Drawing.Size(342, 75)
        Me.EditProductBtn.TabIndex = 1
        Me.EditProductBtn.Text = "แก้ไขสินค้า"
        Me.EditProductBtn.UseVisualStyleBackColor = True
        '
        'SellProductBtn
        '
        Me.SellProductBtn.Location = New System.Drawing.Point(21, 201)
        Me.SellProductBtn.Name = "SellProductBtn"
        Me.SellProductBtn.Size = New System.Drawing.Size(342, 75)
        Me.SellProductBtn.TabIndex = 2
        Me.SellProductBtn.Text = "ขายสินค้า"
        Me.SellProductBtn.UseVisualStyleBackColor = True
        '
        'ModeSelect
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(391, 293)
        Me.Controls.Add(Me.SellProductBtn)
        Me.Controls.Add(Me.EditProductBtn)
        Me.Controls.Add(Me.AddProductBtn)
        Me.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Name = "ModeSelect"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ModeSelect"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents AddProductBtn As Button
    Friend WithEvents EditProductBtn As Button
    Friend WithEvents SellProductBtn As Button
End Class
