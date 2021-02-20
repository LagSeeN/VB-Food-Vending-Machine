Public Class InsertItem
    Dim base64 As New Base64
    Dim mongoDBServer As New MongoDBServer
    Dim imagePath As String = String.Empty
    Private Sub acceptBtn_Click(sender As Object, e As EventArgs) Handles acceptBtn.Click
        acceptBtn.Enabled = False

        Dim isNoEmpty As Boolean = True
        Dim errorMessage As String = "กรุณาตรวจสอบข้อมูลที่ได้ทำการกรอกเข้ามาอีกครั้ง" & System.Environment.NewLine

        If String.IsNullOrEmpty(nameTextBox.Text) Then
            errorMessage &= "- ชื่อสินค้า" & System.Environment.NewLine
            isNoEmpty = False
        End If

        If priceInput.Value <= 0 Then
            errorMessage &= "- ราคาสินค้า (ต้องมากกว่า 0)" & System.Environment.NewLine
            isNoEmpty = False
        End If

        If stockInput.Value <= 0 Then
            errorMessage &= "- จำนวนสินค้า (ต้องมากกว่า 0)" & System.Environment.NewLine
            isNoEmpty = False
        End If

        If timeInput.Value <= 0 Then
            errorMessage &= "- ระยะเวลาอุ่นสินค้า (ต้องมากกว่า 0)" & System.Environment.NewLine
            isNoEmpty = False
        End If

        If String.IsNullOrEmpty(imagePath) Then
            errorMessage &= "- รูปภาพของสินค้ายังไม่ได้ถูกเลือก" & System.Environment.NewLine
            isNoEmpty = False
        End If

        If isNoEmpty Then
            'If Mode = "Add" Then
            Dim detail As New Product()

            detail.product_name = nameTextBox.Text
            detail.price = priceInput.Value
            detail.stock = stockInput.Value
            detail.time = timeInput.Value

            If My.Computer.FileSystem.FileExists(imagePath) Then
                Dim image As Image = Bitmap.FromFile(imagePath)
                Dim imageFormat As Imaging.ImageFormat = image.RawFormat

                detail.image = base64.ConvertImageToBase64(image, imageFormat)

                If mongoDBServer.Insert(detail) Then
                    MessageBox.Show("เพิ่มสินค้าลงในฐานข้อมูลสำเร็จ", "ผลการปฏิบัติงาน", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    ResetInput()
                Else
                    MessageBox.Show("เพิ่มสินค้าลงในฐานข้อมูลล้มเหลว", "ผลการปฏิบัติงาน", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If

            Else
                MessageBox.Show("กรุณาตรวจสอบรูปภาพที่เลือกอีกครั้ง (ไฟล์ไม่ถูกย้าย, เปลี่ยนชื่อ หรือถูกลบออกจากเครื่องคอมพิวเตอร์)", "ข้อผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

            'End If
        Else
            MessageBox.Show(errorMessage, "กรุณาตรวจสอบ", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If

        acceptBtn.Enabled = True
    End Sub

    Private Sub uploadBtn_Click(sender As Object, e As EventArgs) Handles uploadBtn.Click
        Using fileDialog As OpenFileDialog = New OpenFileDialog()
            fileDialog.Title = "Select image for this product"
            fileDialog.InitialDirectory = "C:\"
            fileDialog.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png"
            fileDialog.FilterIndex = 2
            fileDialog.RestoreDirectory = True

            If fileDialog.ShowDialog() = DialogResult.OK Then
                imagePath = fileDialog.FileName
                itemPicBox.Image = Image.FromFile(imagePath)
            End If
        End Using
    End Sub

    Private Sub ResetInput()
        nameTextBox.Text = String.Empty
        priceInput.Value = 0
        stockInput.Value = 0
        timeInput.Value = 0

        imagePath = String.Empty
        itemPicBox.Image = Nothing
    End Sub

End Class