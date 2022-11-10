<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class inventoryFrm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(inventoryFrm))
        Me.productPhoto_picture = New System.Windows.Forms.PictureBox()
        Me.prodctCode_txt = New System.Windows.Forms.TextBox()
        Me.originalPrice_txt = New System.Windows.Forms.TextBox()
        Me.resellerRate_txt = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.description_txt = New System.Windows.Forms.RichTextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.sellRate_txt = New System.Windows.Forms.TextBox()
        Me.wholeSeller_txt = New System.Windows.Forms.ComboBox()
        Me.profitPrice_Txt = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.entry_date = New System.Windows.Forms.DateTimePicker()
        Me.statusMsg_lbl = New System.Windows.Forms.Label()
        Me.uploadProduct_btn = New System.Windows.Forms.Button()
        Me.search_txt = New System.Windows.Forms.TextBox()
        Me.productID_txt = New System.Windows.Forms.TextBox()
        Me.separater_txt = New System.Windows.Forms.Label()
        Me.Asset_Code_txt = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.couponPrice_txt = New System.Windows.Forms.TextBox()
        Me.willMillsPrice_txt = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.inventory_Grid = New System.Windows.Forms.DataGridView()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.productSize_txt = New System.Windows.Forms.ComboBox()
        Me.productColor_txt = New System.Windows.Forms.ComboBox()
        Me.productSeason_txt = New System.Windows.Forms.ComboBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.prodctName_txt = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.productCategory_txt = New System.Windows.Forms.ComboBox()
        Me.productStatus_txt = New System.Windows.Forms.ComboBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.foredit_txt = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        CType(Me.productPhoto_picture, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.inventory_Grid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'productPhoto_picture
        '
        Me.productPhoto_picture.Image = CType(resources.GetObject("productPhoto_picture.Image"), System.Drawing.Image)
        Me.productPhoto_picture.Location = New System.Drawing.Point(504, 98)
        Me.productPhoto_picture.Name = "productPhoto_picture"
        Me.productPhoto_picture.Size = New System.Drawing.Size(207, 194)
        Me.productPhoto_picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.productPhoto_picture.TabIndex = 1
        Me.productPhoto_picture.TabStop = False
        '
        'prodctCode_txt
        '
        Me.prodctCode_txt.Location = New System.Drawing.Point(203, 127)
        Me.prodctCode_txt.Name = "prodctCode_txt"
        Me.prodctCode_txt.Size = New System.Drawing.Size(267, 22)
        Me.prodctCode_txt.TabIndex = 2
        '
        'originalPrice_txt
        '
        Me.originalPrice_txt.Location = New System.Drawing.Point(205, 319)
        Me.originalPrice_txt.Name = "originalPrice_txt"
        Me.originalPrice_txt.Size = New System.Drawing.Size(267, 22)
        Me.originalPrice_txt.TabIndex = 4
        '
        'resellerRate_txt
        '
        Me.resellerRate_txt.Location = New System.Drawing.Point(205, 362)
        Me.resellerRate_txt.Name = "resellerRate_txt"
        Me.resellerRate_txt.Size = New System.Drawing.Size(267, 22)
        Me.resellerRate_txt.TabIndex = 5
        Me.resellerRate_txt.Text = "50"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(98, 104)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(84, 17)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "WholeSeller"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(99, 132)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(94, 17)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Product Code"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(99, 195)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(41, 17)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Color"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(101, 319)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(93, 17)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Original Price"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(127, 470)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(67, 17)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Sell Price"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("OCR A Extended", 28.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(572, 22)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(292, 50)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Inventory"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(103, 493)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(79, 17)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Description"
        '
        'description_txt
        '
        Me.description_txt.Location = New System.Drawing.Point(207, 493)
        Me.description_txt.Name = "description_txt"
        Me.description_txt.Size = New System.Drawing.Size(470, 169)
        Me.description_txt.TabIndex = 13
        Me.description_txt.Text = ""
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(59, 362)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(137, 17)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "Reseller commission"
        '
        'sellRate_txt
        '
        Me.sellRate_txt.Location = New System.Drawing.Point(207, 467)
        Me.sellRate_txt.Name = "sellRate_txt"
        Me.sellRate_txt.Size = New System.Drawing.Size(267, 22)
        Me.sellRate_txt.TabIndex = 15
        '
        'wholeSeller_txt
        '
        Me.wholeSeller_txt.FormattingEnabled = True
        Me.wholeSeller_txt.Location = New System.Drawing.Point(202, 97)
        Me.wholeSeller_txt.Name = "wholeSeller_txt"
        Me.wholeSeller_txt.Size = New System.Drawing.Size(268, 24)
        Me.wholeSeller_txt.TabIndex = 16
        '
        'profitPrice_Txt
        '
        Me.profitPrice_Txt.Location = New System.Drawing.Point(124, 55)
        Me.profitPrice_Txt.Name = "profitPrice_Txt"
        Me.profitPrice_Txt.Size = New System.Drawing.Size(250, 22)
        Me.profitPrice_Txt.TabIndex = 18
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(13, 58)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(105, 17)
        Me.Label9.TabIndex = 17
        Me.Label9.Text = "WillsMills Profit "
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(602, 690)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 28)
        Me.btnSave.TabIndex = 19
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(744, 620)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(38, 17)
        Me.Label10.TabIndex = 20
        Me.Label10.Text = "Date"
        '
        'entry_date
        '
        Me.entry_date.Location = New System.Drawing.Point(747, 640)
        Me.entry_date.Name = "entry_date"
        Me.entry_date.Size = New System.Drawing.Size(209, 22)
        Me.entry_date.TabIndex = 21
        '
        'statusMsg_lbl
        '
        Me.statusMsg_lbl.AutoSize = True
        Me.statusMsg_lbl.Location = New System.Drawing.Point(744, 701)
        Me.statusMsg_lbl.Name = "statusMsg_lbl"
        Me.statusMsg_lbl.Size = New System.Drawing.Size(59, 17)
        Me.statusMsg_lbl.TabIndex = 22
        Me.statusMsg_lbl.Text = "Label11"
        '
        'uploadProduct_btn
        '
        Me.uploadProduct_btn.Location = New System.Drawing.Point(546, 298)
        Me.uploadProduct_btn.Name = "uploadProduct_btn"
        Me.uploadProduct_btn.Size = New System.Drawing.Size(85, 33)
        Me.uploadProduct_btn.TabIndex = 23
        Me.uploadProduct_btn.Text = "Upload"
        Me.uploadProduct_btn.UseVisualStyleBackColor = True
        '
        'search_txt
        '
        Me.search_txt.Location = New System.Drawing.Point(1158, 75)
        Me.search_txt.Name = "search_txt"
        Me.search_txt.Size = New System.Drawing.Size(267, 22)
        Me.search_txt.TabIndex = 25
        '
        'productID_txt
        '
        Me.productID_txt.Location = New System.Drawing.Point(203, 69)
        Me.productID_txt.Name = "productID_txt"
        Me.productID_txt.Size = New System.Drawing.Size(267, 22)
        Me.productID_txt.TabIndex = 27
        Me.productID_txt.Visible = False
        '
        'separater_txt
        '
        Me.separater_txt.AutoSize = True
        Me.separater_txt.Location = New System.Drawing.Point(21, 46)
        Me.separater_txt.Name = "separater_txt"
        Me.separater_txt.Size = New System.Drawing.Size(13, 17)
        Me.separater_txt.TabIndex = 33
        Me.separater_txt.Text = "-"
        Me.separater_txt.Visible = False
        '
        'Asset_Code_txt
        '
        Me.Asset_Code_txt.Location = New System.Drawing.Point(281, 14)
        Me.Asset_Code_txt.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Asset_Code_txt.Name = "Asset_Code_txt"
        Me.Asset_Code_txt.Size = New System.Drawing.Size(29, 22)
        Me.Asset_Code_txt.TabIndex = 46
        Me.Asset_Code_txt.Visible = False
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(102, 406)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(93, 17)
        Me.Label11.TabIndex = 48
        Me.Label11.Text = "Coupon Price"
        '
        'couponPrice_txt
        '
        Me.couponPrice_txt.Location = New System.Drawing.Point(207, 401)
        Me.couponPrice_txt.Name = "couponPrice_txt"
        Me.couponPrice_txt.Size = New System.Drawing.Size(267, 22)
        Me.couponPrice_txt.TabIndex = 47
        Me.couponPrice_txt.Text = "100"
        '
        'willMillsPrice_txt
        '
        Me.willMillsPrice_txt.Location = New System.Drawing.Point(207, 441)
        Me.willMillsPrice_txt.Name = "willMillsPrice_txt"
        Me.willMillsPrice_txt.Size = New System.Drawing.Size(267, 22)
        Me.willMillsPrice_txt.TabIndex = 50
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(94, 444)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(100, 17)
        Me.Label12.TabIndex = 49
        Me.Label12.Text = "WillsMills Price"
        '
        'inventory_Grid
        '
        Me.inventory_Grid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders
        Me.inventory_Grid.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.inventory_Grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.inventory_Grid.Location = New System.Drawing.Point(717, 98)
        Me.inventory_Grid.Name = "inventory_Grid"
        Me.inventory_Grid.RowHeadersWidth = 51
        Me.inventory_Grid.RowTemplate.Height = 24
        Me.inventory_Grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.inventory_Grid.Size = New System.Drawing.Size(708, 481)
        Me.inventory_Grid.TabIndex = 53
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.profitPrice_Txt)
        Me.Panel1.Location = New System.Drawing.Point(73, 22)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(10, 38)
        Me.Panel1.TabIndex = 54
        Me.Panel1.Visible = False
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(99, 223)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(35, 17)
        Me.Label13.TabIndex = 56
        Me.Label13.Text = "Size"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(99, 251)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(65, 17)
        Me.Label14.TabIndex = 58
        Me.Label14.Text = "Category"
        '
        'productSize_txt
        '
        Me.productSize_txt.FormattingEnabled = True
        Me.productSize_txt.Location = New System.Drawing.Point(204, 218)
        Me.productSize_txt.Name = "productSize_txt"
        Me.productSize_txt.Size = New System.Drawing.Size(268, 24)
        Me.productSize_txt.TabIndex = 59
        '
        'productColor_txt
        '
        Me.productColor_txt.FormattingEnabled = True
        Me.productColor_txt.Location = New System.Drawing.Point(204, 188)
        Me.productColor_txt.Name = "productColor_txt"
        Me.productColor_txt.Size = New System.Drawing.Size(268, 24)
        Me.productColor_txt.TabIndex = 60
        '
        'productSeason_txt
        '
        Me.productSeason_txt.FormattingEnabled = True
        Me.productSeason_txt.Location = New System.Drawing.Point(205, 279)
        Me.productSeason_txt.Name = "productSeason_txt"
        Me.productSeason_txt.Size = New System.Drawing.Size(268, 24)
        Me.productSeason_txt.TabIndex = 64
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(97, 160)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(98, 17)
        Me.Label15.TabIndex = 63
        Me.Label15.Text = "Product Name"
        '
        'prodctName_txt
        '
        Me.prodctName_txt.Location = New System.Drawing.Point(206, 160)
        Me.prodctName_txt.Name = "prodctName_txt"
        Me.prodctName_txt.Size = New System.Drawing.Size(267, 22)
        Me.prodctName_txt.TabIndex = 62
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(100, 284)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(56, 17)
        Me.Label16.TabIndex = 61
        Me.Label16.Text = "Season"
        '
        'productCategory_txt
        '
        Me.productCategory_txt.FormattingEnabled = True
        Me.productCategory_txt.Location = New System.Drawing.Point(203, 248)
        Me.productCategory_txt.Name = "productCategory_txt"
        Me.productCategory_txt.Size = New System.Drawing.Size(268, 24)
        Me.productCategory_txt.TabIndex = 65
        '
        'productStatus_txt
        '
        Me.productStatus_txt.FormattingEnabled = True
        Me.productStatus_txt.Items.AddRange(New Object() {"Pending", "Uploaded"})
        Me.productStatus_txt.Location = New System.Drawing.Point(396, 694)
        Me.productStatus_txt.Name = "productStatus_txt"
        Me.productStatus_txt.Size = New System.Drawing.Size(137, 24)
        Me.productStatus_txt.TabIndex = 67
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(400, 674)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(133, 17)
        Me.Label17.TabIndex = 66
        Me.Label17.Text = "Upload on WillsMills"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(541, 422)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 68
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(602, 724)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 28)
        Me.Button2.TabIndex = 69
        Me.Button2.Text = "Edit"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'foredit_txt
        '
        Me.foredit_txt.Location = New System.Drawing.Point(391, 69)
        Me.foredit_txt.Name = "foredit_txt"
        Me.foredit_txt.Size = New System.Drawing.Size(79, 22)
        Me.foredit_txt.TabIndex = 70
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(402, 49)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(72, 17)
        Me.Label18.TabIndex = 71
        Me.Label18.Text = "Product id"
        '
        'inventoryFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1437, 772)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.foredit_txt)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.productStatus_txt)
        Me.Controls.Add(Me.entry_date)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.productCategory_txt)
        Me.Controls.Add(Me.productSeason_txt)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.prodctName_txt)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.productColor_txt)
        Me.Controls.Add(Me.productSize_txt)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.inventory_Grid)
        Me.Controls.Add(Me.willMillsPrice_txt)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.couponPrice_txt)
        Me.Controls.Add(Me.Asset_Code_txt)
        Me.Controls.Add(Me.separater_txt)
        Me.Controls.Add(Me.productID_txt)
        Me.Controls.Add(Me.search_txt)
        Me.Controls.Add(Me.uploadProduct_btn)
        Me.Controls.Add(Me.statusMsg_lbl)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.wholeSeller_txt)
        Me.Controls.Add(Me.sellRate_txt)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.description_txt)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.resellerRate_txt)
        Me.Controls.Add(Me.originalPrice_txt)
        Me.Controls.Add(Me.prodctCode_txt)
        Me.Controls.Add(Me.productPhoto_picture)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "inventoryFrm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "WillsMills"
        CType(Me.productPhoto_picture, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.inventory_Grid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents productPhoto_picture As PictureBox
    Friend WithEvents prodctCode_txt As TextBox
    Friend WithEvents originalPrice_txt As TextBox
    Friend WithEvents resellerRate_txt As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents description_txt As RichTextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents sellRate_txt As TextBox
    Friend WithEvents wholeSeller_txt As ComboBox
    Friend WithEvents profitPrice_Txt As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents btnSave As Button
    Friend WithEvents Label10 As Label
    Friend WithEvents entry_date As DateTimePicker
    Friend WithEvents statusMsg_lbl As Label
    Friend WithEvents uploadProduct_btn As Button
    Friend WithEvents search_txt As TextBox
    Friend WithEvents productID_txt As TextBox
    Friend WithEvents separater_txt As Label
    Friend WithEvents Asset_Code_txt As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents couponPrice_txt As TextBox
    Friend WithEvents willMillsPrice_txt As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents inventory_Grid As DataGridView
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents productSize_txt As ComboBox
    Friend WithEvents productColor_txt As ComboBox
    Friend WithEvents productSeason_txt As ComboBox
    Friend WithEvents Label15 As Label
    Friend WithEvents prodctName_txt As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents productCategory_txt As ComboBox
    Friend WithEvents productStatus_txt As ComboBox
    Friend WithEvents Label17 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents foredit_txt As TextBox
    Friend WithEvents Label18 As Label
End Class
