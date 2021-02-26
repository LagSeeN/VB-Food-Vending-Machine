Imports MongoDB.Bson
Imports System.Drawing.Text
Public Class InsertItem
    Dim base64 As New Base64
    Dim mongoDBServer As New MongoDBServer
    Dim isEditMode As Boolean = False

    Dim currentId As String = String.Empty
    Dim currentImage As Image
    Dim imagePath As String = String.Empty

    Public Sub New(Optional isEditMode As Boolean = False)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.isEditMode = isEditMode

    End Sub
    Private Sub InsertItem_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If isEditMode Then
            'Fontload()
            LoadCombobox()
        Else
            'Fontload()
            cbm_productList.Visible = False
            availableLabel.Visible = False
            availableCheck.Visible = False
        End If
    End Sub
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

        If currentImage Is Nothing Then
            If String.IsNullOrEmpty(imagePath) Then
                errorMessage &= "- รูปภาพของสินค้ายังไม่ได้ถูกเลือก" & System.Environment.NewLine
                isNoEmpty = False
            End If
        End If


        If isNoEmpty Then
            Dim detail As New Product()

            detail.product_name = nameTextBox.Text
            detail.price = priceInput.Value
            detail.stock = stockInput.Value
            detail.time = timeInput.Value
            If isEditMode Then
                detail.id = ObjectId.Parse(currentId)
                detail.is_available = If(availableCheck.Checked, 1, 0)

                Dim image As Image = If(String.IsNullOrEmpty(imagePath), currentImage, Bitmap.FromFile(imagePath))
                Dim imageFormat As Imaging.ImageFormat = image.RawFormat

                detail.image = base64.ConvertImageToBase64(image, imageFormat)

                If mongoDBServer.Update(detail) Then
                    MessageBox.Show("อัปเดตสินค้าลงในฐานข้อมูลสำเร็จ", "ผลการปฏิบัติงาน", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    Dim currSelectedIndex As Integer = cbm_productList.SelectedIndex
                    LoadCombobox()
                    cbm_productList.SelectedIndex = currSelectedIndex

                    GetFoodData()

                Else
                    MessageBox.Show("อัปเดตเพิ่มสินค้าลงในฐานข้อมูลล้มเหลว", "ผลการปฏิบัติงาน", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If

            Else
                detail.is_available = 1
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
            End If

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

    Private Sub cbm_productList_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbm_productList.SelectedIndexChanged
        GetFoodData()
    End Sub

    Private Sub GetFoodData()
        Dim foodId = DirectCast(cbm_productList.SelectedItem, KeyValuePair(Of String, String)).Key
        Dim food = mongoDBServer.GetFood(foodId)

        currentId = food("_id").ToString()
        currentImage = base64.ConvertByteToImage(base64.ConvertBase64ToByteArray(food("image")))
        itemPicBox.Image = currentImage

        nameTextBox.Text = food("product_name")
        priceInput.Value = food("price")
        stockInput.Value = food("stock")
        timeInput.Value = food("time")
        availableCheck.Checked = If(food("is_available") = 1, True, False)
    End Sub

    Private Sub LoadCombobox()
        Dim comboSource As New Dictionary(Of String, String)()
        Dim foods = mongoDBServer.GetAllFood(False)

        For i = 0 To mongoDBServer.CountFood(False) - 1
            comboSource.Add(foods(i)("_id").ToString, foods(i)("product_name"))
        Next

        cbm_productList.DataSource = New BindingSource(comboSource, Nothing)
        cbm_productList.DisplayMember = "Value"
        cbm_productList.ValueMember = "Key"
    End Sub
    Private Sub Fontload()
        Dim colFont As New PrivateFontCollection
        colFont.AddFontFile(Application.StartupPath + "Font\FC Lamoon Regular ver 1.00.ttf")

        cbm_productList.Font = New Font(colFont.Families(0), 18, FontStyle.Regular)
        nameLabel.Font = New Font(colFont.Families(0), 18, FontStyle.Bold)
        priceLabel.Font = New Font(colFont.Families(0), 18, FontStyle.Bold)
        stockLabel.Font = New Font(colFont.Families(0), 18, FontStyle.Bold)
        timeLabel.Font = New Font(colFont.Families(0), 18, FontStyle.Bold)
        availableLabel.Font = New Font(colFont.Families(0), 18, FontStyle.Bold)

        nameTextBox.Font = New Font(colFont.Families(0), 18, FontStyle.Regular)
        priceInput.Font = New Font(colFont.Families(0), 18, FontStyle.Regular)
        stockInput.Font = New Font(colFont.Families(0), 18, FontStyle.Regular)
        timeInput.Font = New Font(colFont.Families(0), 18, FontStyle.Regular)
        availableCheck.Font = New Font(colFont.Families(0), 18, FontStyle.Regular)

        uploadBtn.Font = New Font(colFont.Families(0), 18, FontStyle.Regular)
        acceptBtn.Font = New Font(colFont.Families(0), 18, FontStyle.Regular)
        cancelBtn.Font = New Font(colFont.Families(0), 18, FontStyle.Regular)

    End Sub
End Class