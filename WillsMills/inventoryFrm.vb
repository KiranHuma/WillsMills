Option Explicit On
Imports System.Data
Imports System.Data.OleDb
Imports System.Data.Odbc
Imports System.Data.DataTable
Imports System.Data.SqlClient   'FOR SQL CONNECTION AND COMMAND.
Imports System.IO
'Imports Excel = Microsoft.Office.Interop.Excel      ' EXCEL APPLICATION.
'Imports ExcelAutoFormat = Microsoft.Office.Interop.Excel.XlRangeAutoFormat      ' TO AUTOFORMAT THE SHEET.
Imports System.Drawing.Imaging
Imports System.Security.Cryptography
Imports System.Text
Public Class inventoryFrm
    Private bitmap As Bitmap 'for print grid
    Dim rdr As SqlDataReader
    Dim provider As String
    Dim dataFile As String
    Dim connString As String
    Dim myConnection As SqlConnection = New SqlConnection
    Dim ds As DataSet = New DataSet
    Dim da As SqlDataAdapter
    Dim tables As DataTableCollection = ds.Tables
    Dim source1 As New BindingSource()
    Dim source2 As New BindingSource()
    Dim con As New SqlClient.SqlConnection
    Dim cmd As New SqlClient.SqlCommand
    Dim dt As New DataTable
    Dim cs As String = "Data Source=ANIRUDH;Initial Catalog=willsMills_db;Integrated Security=True"
    'Database Connection
    Private Sub dbaccessconnection()
        Try
            con.ConnectionString = cs
            cmd.Connection = con
        Catch ex As Exception
            MsgBox("DataBase not connected due to the reason because " & ex.Message)
            Me.Dispose()
        End Try
    End Sub
    '>>>>>>>>>>>>>>>>>>>>>>>>Product inventory>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>

    'insert Function
    Private Sub insert()
        Try
            dbaccessconnection()
            con.Open()
            cmd.CommandText = "insert into inventory_tb(Product_Code,WholeSeller_Name,Product_Name,Product_Color,Product_Size,Product_Category,Season,Original_Price,Reseller_Rate,Coupon_Price,Sell_Price,WillsMills_Price,Product_Description,Product_Image,Profit_Price,Product_Date,Prodcut_Status)values('" & prodctCode_txt.Text & "','" & wholeSeller_txt.Text & "','" & prodctName_txt.Text & "',
    '" & productColor_txt.Text & "','" & productSize_txt.Text & "','" & productCategory_txt.Text & "','" & productSize_txt.Text & "',
'" & originalPrice_txt.Text & "','" & resellerRate_txt.Text & "','" & couponPrice_txt.Text & "','" & sellRate_txt.Text & "','" & willMillsPrice_txt.Text & "','" & description_txt.Text & "',@photo,'" & profitPrice_Txt.Text & "','" & entry_date.Value & "' ,'" & productStatus_txt.Text & "')"
            Dim ms As New MemoryStream()
            Dim bmpImage As New Bitmap(productPhoto_picture.Image)
            bmpImage.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg)
            Dim data As Byte() = ms.GetBuffer()
            Dim p As New SqlParameter("@photo", SqlDbType.Image)
            p.Value = data
            cmd.Parameters.Add(p)

            ms.Close()
            ms.Dispose()

            cmd.ExecuteNonQuery()
            cmd.Parameters.Clear()


            If bmpImage IsNot Nothing Then
                bmpImage.Dispose()
            End If
            statusMsg_lbl.ForeColor = System.Drawing.Color.DarkGreen
            statusMsg_lbl.Text = "'" & prodctName_txt.Text & "'  details saved successfully!"
            con.Close()
        Catch ex As Exception
            MsgBox("Data Inserted Failed because " & ex.Message)
            Me.Dispose()
        End Try
    End Sub
    'insert Function
    Private Sub insert_test()
        Try
            dbaccessconnection()
            con.Open()
            cmd.CommandText = "insert into Table_test_inventory(Product_Code,WholeSeller_Name,Product_Name,Product_Color,Product_Size,Product_Category,Season,Original_Price,Reseller_Rate,Coupon_Price,Sell_Price,WillsMills_Price,Product_Description,Product_Image,Profit_Price,Product_Date,Prodcut_Status)values('" & prodctCode_txt.Text & "','" & wholeSeller_txt.Text & "','" & prodctName_txt.Text & "',
    '" & productColor_txt.Text & "','" & productSize_txt.Text & "','" & productCategory_txt.Text & "','" & productSeason_txt.Text & "',
'" & originalPrice_txt.Text & "','" & resellerRate_txt.Text & "','" & couponPrice_txt.Text & "','" & sellRate_txt.Text & "','" & willMillsPrice_txt.Text & "','" & description_txt.Text & "',@photo,'" & profitPrice_Txt.Text & "','" & entry_date.Value & "' ,'" & productStatus_txt.Text & "')"
            Dim ms As New MemoryStream()
            Dim bmpImage As New Bitmap(productPhoto_picture.Image)
            bmpImage.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg)
            Dim data As Byte() = ms.GetBuffer()
            Dim p As New SqlParameter("@photo", SqlDbType.Image)
            p.Value = data
            cmd.Parameters.Add(p)

            ms.Close()
            ms.Dispose()

            cmd.ExecuteNonQuery()
            cmd.Parameters.Clear()


            If bmpImage IsNot Nothing Then
                bmpImage.Dispose()
            End If
            statusMsg_lbl.ForeColor = System.Drawing.Color.DarkGreen
            statusMsg_lbl.Text = "'" & prodctName_txt.Text & "'  details saved successfully!"
            con.Close()
        Catch ex As Exception
            MsgBox("Data Inserted Failed because " & ex.Message)
            Me.Dispose()
        End Try
    End Sub
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
    'auto increment alphanumeric id
    Private Sub productCode_autogenerated()
        Try
            Dim num As New Integer
            Dim constr As String = cs
            Using con As SqlConnection = New SqlConnection(constr)
                Using cmd As SqlCommand = New SqlCommand("SELECT MAX(Product_ID) FROM inventory_tb ")
                    cmd.CommandType = CommandType.Text
                    cmd.Connection = con
                    con.Open()



                    If (IsDBNull(cmd.ExecuteScalar)) Then
                        num = 1
                        productID_txt.Text = num.ToString.ToString.PadLeft(4, "0")
                    Else

                        num = cmd.ExecuteScalar + 1
                        productID_txt.Text = num.ToString.ToString.PadLeft(4, "0")
                        ' getvaluedb()

                    End If

                    con.Close()

                End Using
            End Using
        Catch ex As Exception
            MsgBox("Failed:Autoincrement  " & ex.Message)
            Me.Dispose()
        End Try

    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        product_FillCombo()
        product_color_fillcombo()
        product_size_fillcombo()
        product_category_fillcombo()
        product_season_fillcombo()
        inventory_getdata()
        productCode_autogenerated()



    End Sub


    'services get data
    Private Sub inventory_getdata()
        Try
            Dim con As New SqlConnection(cs)
            con.Open()
            Dim da As New SqlDataAdapter("Select * from inventory_tb ORDER BY Product_ID DESC", con)
            Dim dt As New DataTable
            da.Fill(dt)
            source2.DataSource = dt
            inventory_Grid.DataSource = dt
            inventory_Grid.Refresh()
        Catch ex As Exception
            MessageBox.Show("Failed:Retrieving Services Data" & ex.Message)
            Me.Dispose()
        End Try
    End Sub
    Private Sub uploadProduct_btn_Click(sender As Object, e As EventArgs) Handles uploadProduct_btn.Click
        Try
            With OpenFileDialog1
                .Filter = ("Images |*.png; *.bmp; *.jpg;*.jpeg; *.gif;")
                .FilterIndex = 4
            End With
            'Clear the file name
            OpenFileDialog1.FileName = ""
            If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
                productPhoto_picture.Image = Image.FromFile(OpenFileDialog1.FileName)
            End If
        Catch ex As Exception
            MsgBox(ex.ToString())
        End Try
    End Sub
    Sub creatingProductCode()
        Dim strMyString As String = wholeSeller_txt.Text
        Asset_Code_txt.Text = Microsoft.VisualBasic.Left(strMyString, 2)
        'Dim strMyString2 As String = Assett_Name_txt.Text
        Dim usertext As String = "WIMI-"
        Asset_Code_txt.Text = usertext + Microsoft.VisualBasic.Left(strMyString, 2)

        prodctCode_txt.Text = Asset_Code_txt.Text + separater_txt.Text + productID_txt.Text
        code_check()
    End Sub
    'get recent names of products in dropdown
    Private Sub product_FillCombo()
        Try
            Dim myConnToAccess As SqlConnection
            Dim ds As DataSet
            Dim da As SqlDataAdapter
            Dim tables As DataTableCollection
            myConnToAccess = New SqlConnection(cs)
            myConnToAccess.Open()
            ds = New DataSet
            tables = ds.Tables
            da = New SqlDataAdapter("SELECT DISTINCT WholeSeller_Name  from inventory_tb where  Len(WholeSeller_Name) > 0 ", myConnToAccess)
            da.Fill(ds, "inventory_tb")
            Dim view1 As New DataView(tables(0))
            With wholeSeller_txt
                .DataSource = ds.Tables("inventory_tb")
                .DisplayMember = "WholeSeller_Name"
                .ValueMember = "WholeSeller_Name"
                .SelectedIndex = -1
                .AutoCompleteMode = AutoCompleteMode.SuggestAppend
                .AutoCompleteSource = AutoCompleteSource.ListItems
            End With
        Catch ex As Exception
            MessageBox.Show(" Failed:Retrieving RecentNames " & ex.Message)
            Me.Dispose()
        End Try
    End Sub
    Private Sub product_color_fillcombo()
        Try
            Dim myConnToAccess As SqlConnection
            Dim ds As DataSet
            Dim da As SqlDataAdapter
            Dim tables As DataTableCollection
            myConnToAccess = New SqlConnection(cs)
            myConnToAccess.Open()
            ds = New DataSet
            tables = ds.Tables
            da = New SqlDataAdapter("SELECT DISTINCT Product_Color from inventory_tb where  Len(Product_Color) > 0", myConnToAccess)
            da.Fill(ds, "inventory_tb")
            Dim view1 As New DataView(tables(0))
            With productColor_txt
                .DataSource = ds.Tables("inventory_tb")
                .DisplayMember = "Product_Color"
                .ValueMember = "Product_Color"
                .SelectedIndex = -1
                .AutoCompleteMode = AutoCompleteMode.SuggestAppend
                .AutoCompleteSource = AutoCompleteSource.ListItems
            End With
        Catch ex As Exception
            MessageBox.Show(" Failed:Retrieving Recentcolor " & ex.Message)
            Me.Dispose()
        End Try
    End Sub

    Private Sub product_size_fillcombo()
        Try
            Dim myConnToAccess As SqlConnection
            Dim ds As DataSet
            Dim da As SqlDataAdapter
            Dim tables As DataTableCollection
            myConnToAccess = New SqlConnection(cs)
            myConnToAccess.Open()
            ds = New DataSet
            tables = ds.Tables
            da = New SqlDataAdapter("SELECT DISTINCT Product_Size from inventory_tb where  Len(Product_Size) > 0 ", myConnToAccess)
            da.Fill(ds, "inventory_tb")
            Dim view1 As New DataView(tables(0))
            With productSize_txt
                .DataSource = ds.Tables("inventory_tb")
                .DisplayMember = "Product_Size"
                .ValueMember = "Product_Size"
                .SelectedIndex = -1
                .AutoCompleteMode = AutoCompleteMode.SuggestAppend
                .AutoCompleteSource = AutoCompleteSource.ListItems
            End With
        Catch ex As Exception
            MessageBox.Show(" Failed:Retrieving Recentcolor " & ex.Message)
            Me.Dispose()
        End Try
    End Sub

    Private Sub product_category_fillcombo()
        Try
            Dim myConnToAccess As SqlConnection
            Dim ds As DataSet
            Dim da As SqlDataAdapter
            Dim tables As DataTableCollection
            myConnToAccess = New SqlConnection(cs)
            myConnToAccess.Open()
            ds = New DataSet
            tables = ds.Tables
            da = New SqlDataAdapter("SELECT DISTINCT Product_Category from inventory_tb where  Len(Product_Category) > 0 ", myConnToAccess)
            da.Fill(ds, "inventory_tb")
            Dim view1 As New DataView(tables(0))
            With productCategory_txt
                .DataSource = ds.Tables("inventory_tb")
                .DisplayMember = "Product_Category"
                .ValueMember = "Product_Category"
                .SelectedIndex = -1
                .AutoCompleteMode = AutoCompleteMode.SuggestAppend
                .AutoCompleteSource = AutoCompleteSource.ListItems
            End With
        Catch ex As Exception
            MessageBox.Show(" Failed:Retrieving Recentcolor " & ex.Message)
            Me.Dispose()
        End Try
    End Sub

    Private Sub product_season_fillcombo()
        Try
            Dim myConnToAccess As SqlConnection
            Dim ds As DataSet
            Dim da As SqlDataAdapter
            Dim tables As DataTableCollection
            myConnToAccess = New SqlConnection(cs)
            myConnToAccess.Open()
            ds = New DataSet
            tables = ds.Tables
            da = New SqlDataAdapter("SELECT DISTINCT Season from inventory_tb where  Len(Season) > 0 ", myConnToAccess)
            da.Fill(ds, "inventory_tb")
            Dim view1 As New DataView(tables(0))
            With productSeason_txt
                .DataSource = ds.Tables("inventory_tb")
                .DisplayMember = "Season"
                .ValueMember = "Season"
                .SelectedIndex = -1
                .AutoCompleteMode = AutoCompleteMode.SuggestAppend
                .AutoCompleteSource = AutoCompleteSource.ListItems
            End With
        Catch ex As Exception
            MessageBox.Show(" Failed:Retrieving Recentcolor " & ex.Message)
            Me.Dispose()
        End Try
    End Sub
    Sub productCalculation()

        Dim originalPrice As Double
        Dim resellercommission As Double
        Dim couponPrice As Double
        Dim willmillsProfit As Double
        Dim willssellprice As Double
        Dim num5 As Double
        originalPrice = Convert.ToDouble(originalPrice_txt.Text)
        resellercommission = Convert.ToDouble(resellerRate_txt.Text)
        couponPrice = Convert.ToDouble(couponPrice_txt.Text)
        willssellprice = Convert.ToDouble(willMillsPrice_txt.Text)
        num5 = originalPrice + resellercommission + couponPrice + willssellprice
        sellRate_txt.Text = CStr(num5)
        willmillsProfit = num5 - originalPrice - resellercommission - couponPrice
        profitPrice_Txt.Text = CStr(willmillsProfit)
    End Sub
    Private Sub searchProduct_txt()
        dbaccessconnection()
        Dim str As String
        Try
            con.Open()
            str = "Select * from inventory_tb where WholeSeller_Name like '" & search_txt.Text & "%' Or Product_Name like '" & search_txt.Text & "%'"
            cmd = New SqlCommand(str, con)
            da = New SqlDataAdapter(cmd)
            ds = New DataSet
            da.Fill(ds, "inventory_tb")
            con.Close()
            inventory_Grid.DataSource = ds
            inventory_Grid.DataMember = "inventory_tb"
            inventory_Grid.Visible = True
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Failed:Product Name Search", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.Dispose()
        End Try
    End Sub
    Private Sub search_txt_TextChanged(sender As Object, e As EventArgs) Handles search_txt.TextChanged
        searchProduct_txt()
    End Sub



    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        insert()
        product_FillCombo()
        product_color_fillcombo()
        product_size_fillcombo()
        product_category_fillcombo()
        product_season_fillcombo()
        inventory_getdata()
        productCode_autogenerated()
        Call (New inventoryFrm()).Show()
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        productCode_autogenerated()
    End Sub
    Public Sub code_check()
        Dim str As String
        Dim com As SqlCommand
        Dim con As New SqlConnection(cs)
        con.Open()
        str = "select count(*)from inventory_tb where Product_Code='" & prodctCode_txt.Text & "'"
        com = New SqlCommand(Str, con)
        Dim count As Integer = Convert.ToInt32(com.ExecuteScalar())
        con.Close()
        If count > 0 Then
            statusMsg_lbl.Visible = True
            statusMsg_lbl.Text = "Sorry! Already registered"
            statusMsg_lbl.ForeColor = Color.Red
            'label7.Text = "";
        Else
            statusMsg_lbl.Text = ""
            statusMsg_lbl.Visible = False

        End If

    End Sub
    Private Sub prodctCode_txt_TextChanged(sender As Object, e As EventArgs) Handles prodctCode_txt.TextChanged
        creatingProductCode()
        code_check()
    End Sub



    Private Sub wholeSeller_txt_SelectedIndexChanged(sender As Object, e As EventArgs) Handles wholeSeller_txt.SelectedIndexChanged
        creatingProductCode()

    End Sub



    Private Sub originalPrice_txt_TextChanged(sender As Object, e As EventArgs) Handles originalPrice_txt.TextChanged

    End Sub

    Private Sub sellRate_txt_TextChanged(sender As Object, e As EventArgs) Handles sellRate_txt.TextChanged
        productCalculation()
    End Sub

    Private Sub willMillsPrice_txt_TextChanged(sender As Object, e As EventArgs) Handles willMillsPrice_txt.TextChanged

        productCalculation()
    End Sub

    Private Sub wholeSeller_txt_KeyPress(sender As Object, e As KeyPressEventArgs) Handles wholeSeller_txt.KeyPress
        e.KeyChar = e.KeyChar.ToUpper(e.KeyChar)
    End Sub

    Private Sub productID_txt_TextChanged(sender As Object, e As EventArgs) Handles productID_txt.TextChanged

    End Sub

    Private Sub prodctCode_txt_Enter(sender As Object, e As EventArgs) Handles prodctCode_txt.Enter
        creatingProductCode()
    End Sub

    Private Sub inventory_Grid_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles inventory_Grid.CellContentClick

    End Sub

    Private Sub inventory_Grid_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles inventory_Grid.CellMouseClick
        Me.foredit_txt.Text = inventory_Grid.CurrentRow.Cells(0).Value.ToString
        Me.prodctCode_txt.Text = inventory_Grid.CurrentRow.Cells(1).Value.ToString
        Me.wholeSeller_txt.Text = inventory_Grid.CurrentRow.Cells(2).Value.ToString
        Me.prodctName_txt.Text = inventory_Grid.CurrentRow.Cells(3).Value.ToString

        Me.productColor_txt.Text = inventory_Grid.CurrentRow.Cells(4).Value.ToString



        Me.productSize_txt.Text = inventory_Grid.CurrentRow.Cells(5).Value.ToString
        Me.productCategory_txt.Text = inventory_Grid.CurrentRow.Cells(6).Value.ToString
        Me.productSeason_txt.Text = inventory_Grid.CurrentRow.Cells(7).Value.ToString
        Me.originalPrice_txt.Text = inventory_Grid.CurrentRow.Cells(8).Value.ToString
        Me.resellerRate_txt.Text = inventory_Grid.CurrentRow.Cells(9).Value.ToString


        Me.couponPrice_txt.Text = inventory_Grid.CurrentRow.Cells(10).Value.ToString
        Me.willMillsPrice_txt.Text = inventory_Grid.CurrentRow.Cells(12).Value.ToString
        Me.sellRate_txt.Text = inventory_Grid.CurrentRow.Cells(11).Value.ToString
        ' Me.willMillsPrice_txt.Text = inventory_Grid.CurrentRow.Cells(12).Value.ToString

        Me.description_txt.Text = inventory_Grid.CurrentRow.Cells(13).Value.ToString
        Me.profitPrice_Txt.Text = inventory_Grid.CurrentRow.Cells(15).Value.ToString
        Me.entry_date.Value = inventory_Grid.CurrentRow.Cells(16).Value.ToString
        Me.productStatus_txt.Text = inventory_Grid.CurrentRow.Cells(17).Value.ToString



        ' Image()
        Dim i As Integer
        i = inventory_Grid.CurrentRow.Index
        Dim bytes As [Byte]() = (Me.inventory_Grid.Item(14, i).Value)
        Dim ms As New MemoryStream(bytes)
        productPhoto_picture.Image = Image.FromStream(ms)
    End Sub
    Private Sub inventory_edit()
        dbaccessconnection()
        Try
            con.Open()
            cmd.CommandText = ("UPDATE inventory_tb SET Product_Image=@photo where Product_ID=" & foredit_txt.Text & "")
            Dim ms As New MemoryStream()
            Dim bmpImage As New Bitmap(productPhoto_picture.Image)
            bmpImage.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg)
            Dim data As Byte() = ms.GetBuffer()
            Dim p As New SqlParameter("@photo", SqlDbType.Image)
            p.Value = data
            cmd.Parameters.Add(p)
            cmd.ExecuteNonQuery()
            cmd.Parameters.Clear()
            statusMsg_lbl.ForeColor = System.Drawing.Color.DarkGreen
            statusMsg_lbl.Text = "'" & statusMsg_lbl.Text & "'  details update successfully!"

            con.Close()

        Catch ex As Exception
            MessageBox.Show("Data Not Updated" & ex.Message)
            statusMsg_lbl.ForeColor = System.Drawing.Color.Red
            Me.Dispose()
        End Try
    End Sub
    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        insert_test()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        inventory_edit()
    End Sub
End Class
