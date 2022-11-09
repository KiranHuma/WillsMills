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
        Me.prodctName_txt = New System.Windows.Forms.TextBox()
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
        Me.Label13 = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        CType(Me.productPhoto_picture, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.inventory_Grid, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.prodctCode_txt.Location = New System.Drawing.Point(203, 168)
        Me.prodctCode_txt.Name = "prodctCode_txt"
        Me.prodctCode_txt.Size = New System.Drawing.Size(267, 22)
        Me.prodctCode_txt.TabIndex = 2
        '
        'prodctName_txt
        '
        Me.prodctName_txt.Location = New System.Drawing.Point(203, 207)
        Me.prodctName_txt.Name = "prodctName_txt"
        Me.prodctName_txt.Size = New System.Drawing.Size(267, 22)
        Me.prodctName_txt.TabIndex = 3
        '
        'originalPrice_txt
        '
        Me.originalPrice_txt.Location = New System.Drawing.Point(202, 245)
        Me.originalPrice_txt.Name = "originalPrice_txt"
        Me.originalPrice_txt.Size = New System.Drawing.Size(267, 22)
        Me.originalPrice_txt.TabIndex = 4
        '
        'resellerRate_txt
        '
        Me.resellerRate_txt.Location = New System.Drawing.Point(202, 288)
        Me.resellerRate_txt.Name = "resellerRate_txt"
        Me.resellerRate_txt.Size = New System.Drawing.Size(267, 22)
        Me.resellerRate_txt.TabIndex = 5
        Me.resellerRate_txt.Text = "50"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(99, 133)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(84, 17)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "WholeSeller"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(99, 173)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(94, 17)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Product Code"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(98, 207)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(98, 17)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Product Name"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(98, 245)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(93, 17)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Original Price"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(124, 396)
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
        Me.Label7.Location = New System.Drawing.Point(100, 419)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(79, 17)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Description"
        '
        'description_txt
        '
        Me.description_txt.Location = New System.Drawing.Point(204, 419)
        Me.description_txt.Name = "description_txt"
        Me.description_txt.Size = New System.Drawing.Size(267, 96)
        Me.description_txt.TabIndex = 13
        Me.description_txt.Text = ""
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(56, 288)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(137, 17)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "Reseller commission"
        '
        'sellRate_txt
        '
        Me.sellRate_txt.Location = New System.Drawing.Point(204, 393)
        Me.sellRate_txt.Name = "sellRate_txt"
        Me.sellRate_txt.Size = New System.Drawing.Size(267, 22)
        Me.sellRate_txt.TabIndex = 15
        '
        'wholeSeller_txt
        '
        Me.wholeSeller_txt.FormattingEnabled = True
        Me.wholeSeller_txt.Location = New System.Drawing.Point(203, 126)
        Me.wholeSeller_txt.Name = "wholeSeller_txt"
        Me.wholeSeller_txt.Size = New System.Drawing.Size(268, 24)
        Me.wholeSeller_txt.TabIndex = 16
        '
        'profitPrice_Txt
        '
        Me.profitPrice_Txt.Location = New System.Drawing.Point(481, 416)
        Me.profitPrice_Txt.Name = "profitPrice_Txt"
        Me.profitPrice_Txt.Size = New System.Drawing.Size(267, 22)
        Me.profitPrice_Txt.TabIndex = 18
        Me.profitPrice_Txt.Visible = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(478, 391)
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
        Me.btnSave.Location = New System.Drawing.Point(396, 541)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 28)
        Me.btnSave.TabIndex = 19
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(478, 337)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(38, 17)
        Me.Label10.TabIndex = 20
        Me.Label10.Text = "Date"
        Me.Label10.Visible = False
        '
        'entry_date
        '
        Me.entry_date.Location = New System.Drawing.Point(481, 356)
        Me.entry_date.Name = "entry_date"
        Me.entry_date.Size = New System.Drawing.Size(267, 22)
        Me.entry_date.TabIndex = 21
        '
        'statusMsg_lbl
        '
        Me.statusMsg_lbl.AutoSize = True
        Me.statusMsg_lbl.Location = New System.Drawing.Point(12, 521)
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
        Me.search_txt.Location = New System.Drawing.Point(1137, 70)
        Me.search_txt.Name = "search_txt"
        Me.search_txt.Size = New System.Drawing.Size(267, 22)
        Me.search_txt.TabIndex = 25
        '
        'productID_txt
        '
        Me.productID_txt.Location = New System.Drawing.Point(204, 98)
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
        Me.Asset_Code_txt.Location = New System.Drawing.Point(15, 22)
        Me.Asset_Code_txt.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Asset_Code_txt.Name = "Asset_Code_txt"
        Me.Asset_Code_txt.Size = New System.Drawing.Size(29, 22)
        Me.Asset_Code_txt.TabIndex = 46
        Me.Asset_Code_txt.Visible = False
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(99, 332)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(93, 17)
        Me.Label11.TabIndex = 48
        Me.Label11.Text = "Coupon Price"
        '
        'couponPrice_txt
        '
        Me.couponPrice_txt.Location = New System.Drawing.Point(204, 327)
        Me.couponPrice_txt.Name = "couponPrice_txt"
        Me.couponPrice_txt.Size = New System.Drawing.Size(267, 22)
        Me.couponPrice_txt.TabIndex = 47
        Me.couponPrice_txt.Text = "100"
        '
        'willMillsPrice_txt
        '
        Me.willMillsPrice_txt.Location = New System.Drawing.Point(204, 367)
        Me.willMillsPrice_txt.Name = "willMillsPrice_txt"
        Me.willMillsPrice_txt.Size = New System.Drawing.Size(267, 22)
        Me.willMillsPrice_txt.TabIndex = 50
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(91, 370)
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
        Me.inventory_Grid.Location = New System.Drawing.Point(876, 98)
        Me.inventory_Grid.Name = "inventory_Grid"
        Me.inventory_Grid.RowHeadersWidth = 51
        Me.inventory_Grid.RowTemplate.Height = 24
        Me.inventory_Grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.inventory_Grid.Size = New System.Drawing.Size(528, 481)
        Me.inventory_Grid.TabIndex = 53
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(478, 391)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(105, 17)
        Me.Label13.TabIndex = 17
        Me.Label13.Text = "WillsMills Profit "
        Me.Label13.Visible = False
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(481, 356)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(267, 22)
        Me.DateTimePicker1.TabIndex = 21
        Me.DateTimePicker1.Visible = False
        '
        'inventoryFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1437, 630)
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
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.entry_date)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.profitPrice_Txt)
        Me.Controls.Add(Me.Label9)
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
        Me.Controls.Add(Me.prodctName_txt)
        Me.Controls.Add(Me.prodctCode_txt)
        Me.Controls.Add(Me.productPhoto_picture)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "inventoryFrm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "WillsMills"
        CType(Me.productPhoto_picture, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.inventory_Grid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents productPhoto_picture As PictureBox
    Friend WithEvents prodctCode_txt As TextBox
    Friend WithEvents prodctName_txt As TextBox
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
    Friend WithEvents Label13 As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
End Class
