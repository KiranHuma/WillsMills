﻿Option Explicit On
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
            cmd.CommandText = "insert into inventory_tb(Product_Code,WholeSeller_Name,Product_Name,Original_Price,Reseller_Rate,Sell_Price,Product_Description,Product_Image,Profit_Price,Product_Date)values('" & prodctCode_txt.Text & "','" & wholeSeller_txt.Text & "','" & prodctName_txt.Text & "','" & originalPrice_txt.Text & "','" & resellerRate_txt.Text & "','" & sellRate_txt.Text & "','" & description_txt.Text & "',@photo,'" & profitPrice_Txt.Text & "','" & entry_date.Value & "')"
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
            Dim curValue As Integer
            Dim result As String
            Using con As SqlConnection = New SqlConnection(cs)
                con.Open()
                Dim cmd = New SqlCommand("select Max(Product_Code) from inventory_tb", con)
                result = cmd.ExecuteScalar().ToString()
                If String.IsNullOrEmpty(result) Then
                    result = "PRO-0000"
                End If

                result = result.Substring(3)
                Int32.TryParse(result, curValue)
                curValue = curValue + 1
                result = "PRO" + curValue.ToString("D4")
                prodctCode_txt.Text = result
            End Using
        Catch ex As Exception
            MessageBox.Show("Failed:AutoIncrement of ProductID" & ex.Message)
            Me.Dispose()
        End Try
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        product_FillCombo()
        inventory_getdata()
        productCode_autogenerated()
    End Sub


    'services get data
    Private Sub inventory_getdata()
        Try
            Dim con As New SqlConnection(cs)
            con.Open()
            Dim da As New SqlDataAdapter("Select * from inventory_tb ", con)
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
            da = New SqlDataAdapter("SELECT WholeSeller_Name from inventory_tb", myConnToAccess)
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
    Private Sub Button2_Click(sender As Object, e As EventArgs)

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
        inventory_getdata()
        productCode_autogenerated()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        productCode_autogenerated()
    End Sub
End Class
