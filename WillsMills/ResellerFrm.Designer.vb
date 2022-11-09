<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ResellerFrm
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
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.profitPrice_Txt = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.sellRate_txt = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.resellerRate_txt = New System.Windows.Forms.TextBox()
        Me.originalPrice_txt = New System.Windows.Forms.TextBox()
        Me.prodctName_txt = New System.Windows.Forms.TextBox()
        Me.prodctCode_txt = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'profitPrice_Txt
        '
        Me.profitPrice_Txt.Location = New System.Drawing.Point(174, 345)
        Me.profitPrice_Txt.Name = "profitPrice_Txt"
        Me.profitPrice_Txt.Size = New System.Drawing.Size(267, 22)
        Me.profitPrice_Txt.TabIndex = 36
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(80, 345)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(77, 17)
        Me.Label9.TabIndex = 35
        Me.Label9.Text = "Profit Price"
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(173, 139)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(268, 24)
        Me.ComboBox1.TabIndex = 34
        '
        'sellRate_txt
        '
        Me.sellRate_txt.Location = New System.Drawing.Point(173, 317)
        Me.sellRate_txt.Name = "sellRate_txt"
        Me.sellRate_txt.Size = New System.Drawing.Size(267, 22)
        Me.sellRate_txt.TabIndex = 33
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(90, 289)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(67, 17)
        Me.Label8.TabIndex = 32
        Me.Label8.Text = "Total Sell"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("OCR A Extended", 28.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(119, 26)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(742, 50)
        Me.Label4.TabIndex = 29
        Me.Label4.Text = "Reseller Selling Account"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(13, 320)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(148, 17)
        Me.Label6.TabIndex = 28
        Me.Label6.Text = "Total Reseller Amount"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(68, 261)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(94, 17)
        Me.Label5.TabIndex = 27
        Me.Label5.Text = "Product Code"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(61, 238)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(101, 17)
        Me.Label3.TabIndex = 26
        Me.Label3.Text = "Reseller Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(64, 177)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(94, 17)
        Me.Label2.TabIndex = 25
        Me.Label2.Text = "Coupen Code"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(102, 142)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 17)
        Me.Label1.TabIndex = 24
        Me.Label1.Text = "Reseller"
        '
        'resellerRate_txt
        '
        Me.resellerRate_txt.Location = New System.Drawing.Point(173, 289)
        Me.resellerRate_txt.Name = "resellerRate_txt"
        Me.resellerRate_txt.Size = New System.Drawing.Size(267, 22)
        Me.resellerRate_txt.TabIndex = 23
        '
        'originalPrice_txt
        '
        Me.originalPrice_txt.Location = New System.Drawing.Point(173, 261)
        Me.originalPrice_txt.Name = "originalPrice_txt"
        Me.originalPrice_txt.Size = New System.Drawing.Size(267, 22)
        Me.originalPrice_txt.TabIndex = 22
        '
        'prodctName_txt
        '
        Me.prodctName_txt.Location = New System.Drawing.Point(173, 233)
        Me.prodctName_txt.Name = "prodctName_txt"
        Me.prodctName_txt.Size = New System.Drawing.Size(267, 22)
        Me.prodctName_txt.TabIndex = 21
        '
        'prodctCode_txt
        '
        Me.prodctCode_txt.Location = New System.Drawing.Point(173, 177)
        Me.prodctCode_txt.Name = "prodctCode_txt"
        Me.prodctCode_txt.Size = New System.Drawing.Size(267, 22)
        Me.prodctCode_txt.TabIndex = 20
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(570, 145)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(48, 17)
        Me.Label10.TabIndex = 37
        Me.Label10.Text = "Status"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(580, 187)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(38, 17)
        Me.Label12.TabIndex = 39
        Me.Label12.Text = "Date"
        '
        'ComboBox2
        '
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(630, 142)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(268, 24)
        Me.ComboBox2.TabIndex = 40
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(630, 182)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(274, 22)
        Me.DateTimePicker1.TabIndex = 45
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(456, 139)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(33, 23)
        Me.Button1.TabIndex = 46
        Me.Button1.Text = "+"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(64, 205)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(93, 17)
        Me.Label7.TabIndex = 48
        Me.Label7.Text = "Coupen Price"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(173, 205)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(267, 22)
        Me.TextBox1.TabIndex = 47
        '
        'ResellerFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(949, 456)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.ComboBox2)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.profitPrice_Txt)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.sellRate_txt)
        Me.Controls.Add(Me.Label8)
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
        Me.Name = "ResellerFrm"
        Me.Text = "ResellerFrm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents profitPrice_Txt As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents sellRate_txt As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents resellerRate_txt As TextBox
    Friend WithEvents originalPrice_txt As TextBox
    Friend WithEvents prodctName_txt As TextBox
    Friend WithEvents prodctCode_txt As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Button1 As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents TextBox1 As TextBox
End Class
