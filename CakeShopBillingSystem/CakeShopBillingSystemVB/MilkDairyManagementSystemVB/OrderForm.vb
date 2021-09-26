Imports System.Data.SqlClient

Public Class OrderForm

    Private Sub button1_Click(sender As Object, e As EventArgs)


    End Sub

    Private Function count() As Integer
        Throw New NotImplementedException()
    End Function

    Private Sub button2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub MilkDairy_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim connectionString As String = "Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=CakeShop;"
        Dim sql As String = "SELECT * FROM ItemDetails"
        Dim connection As New SqlConnection(connectionString)
        Dim dataadapter As New SqlDataAdapter(sql, connection)
        Dim ds As New DataSet()
        connection.Open()
        dataadapter.Fill(ds, "ItemDetails_table")
        connection.Close()
        Combocatagory.DataSource = ds.Tables(0)
        Combocatagory.ValueMember = "ItemNO"
        Combocatagory.DisplayMember = "Category"
        Flavors()
        Candle()
        TextBox3.Text = "00"
        TextBox4.Text = "00"
        Combocatagory.Text = " "
        ComboFlavors.Text = " "
        ComboCandels.Text = " "
        TxtCandelValue.Text = "00"
        TextBox10.Text = "00"
        TextBox9.Text = "00"
    End Sub

    Private Sub textBox8_TextChanged(sender As Object, e As EventArgs) Handles textBox8.TextChanged

    End Sub

    Private Sub Combocatagory_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Combocatagory.SelectedIndexChanged

    End Sub



    Private Function rd() As SqlDataReader
        Throw New NotImplementedException()
    End Function

    Private Function rd(v As String) As String
        Throw New NotImplementedException()
    End Function

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs)


    End Sub

    Private Sub Btnsave_Click(sender As Object, e As EventArgs) Handles Btnsave.Click
        Dim con As New SqlConnection
        Dim cmd As New SqlCommand

        '' Try
        con.ConnectionString = "Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=CakeShop;"
            con.Open()
            cmd.Connection = con

            cmd = New SqlCommand("insert into OrderDetails ([OrderNo],[Date],[FirstName],[LastName],[Address],[MobNumber],[Category],[Flavours],[Candle],[CakeValue],[CandleValue],[OtherValue],[DeliveryValue],[Total]) values('" + TextBox1.Text + "','" + DateTimePicker1.Text + "','" + textBox5.Text + "','" + textBox6.Text + "','" + textBox7.Text + "','" + textBox8.Text + "','" + Combocatagory.Text + "','" + ComboFlavors.Text + "','" + ComboCandels.Text + "','" + TextBox9.Text + "','" + TxtCandelValue.Text + "','" + TextBox3.Text + "','" + TextBox4.Text + "','" + TextBox10.Text + "')", con)

            cmd.ExecuteNonQuery()
            MsgBox("Order Inserted Successfully")
        ''Catch ex As Exception

        ''MessageBox.Show("Invalid" & ex.Message)
        ''Finally
        con.Close()
        ''End Try
        ''Me.RecordsTableAdapter.Fill(Me.TrialDataSet1.records)
    End Sub

    Private Sub ComboFlavors_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboFlavors.SelectedIndexChanged
        TextBox9.Text = ComboFlavors.GetItemText(ComboFlavors.SelectedValue)
    End Sub
    Function Flavors()
        Dim connectionString As String = "Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=CakeShop;"
        Dim sql As String = "SELECT * FROM ItemDetails"
        Dim connection As New SqlConnection(connectionString)
        Dim dataadapter As New SqlDataAdapter(sql, connection)
        Dim ds As New DataSet()
        connection.Open()
        dataadapter.Fill(ds, "ItemDetails_table")
        connection.Close()
        ComboFlavors.DataSource = ds.Tables(0)
        ComboFlavors.ValueMember = "Price"
        ComboFlavors.DisplayMember = "Flavour"
    End Function
    Function Candle()
        Dim connectionString As String = "Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=CakeShop;"
        Dim sql As String = "SELECT * FROM CandleDetails"
        Dim connection As New SqlConnection(connectionString)
        Dim dataadapter As New SqlDataAdapter(sql, connection)
        Dim ds As New DataSet()
        connection.Open()
        dataadapter.Fill(ds, "CandleDetails_table")
        connection.Close()
        ComboCandels.DataSource = ds.Tables(0)
        ComboCandels.ValueMember = "Price"
        ComboCandels.DisplayMember = "CandleName"
    End Function

    Private Sub ComboCandels_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboCandels.SelectedIndexChanged
        TxtCandelValue.Text = ComboCandels.GetItemText(ComboCandels.SelectedValue)
    End Sub

    Private Sub Btntotal_Click(sender As Object, e As EventArgs) Handles Btntotal.Click
        Dim num1 As Double
        Dim num2 As Double
        Dim num3 As Double
        Dim num4 As Double
        Dim num5 As Double
        num1 = Convert.ToDouble(TextBox9.Text)
        num2 = Convert.ToDouble(TxtCandelValue.Text)
        num3 = Convert.ToDouble(TextBox3.Text)
        num4 = Convert.ToDouble(TextBox4.Text)
        num5 = num1 + num2 + num3 + num4
        TextBox10.Text = CStr(num5)

    End Sub

    Private Sub Btnupdate_Click(sender As Object, e As EventArgs) Handles Btnupdate.Click
        Dim con As New SqlConnection
        Dim cmd As New SqlCommand

        Try
            con.ConnectionString = "Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=CakeShop;"
            con.Open()
            cmd.Connection = con

            cmd = New SqlCommand("Update OrderDetails Set OrderNo='" & TextBox1.Text & "',Date='" + DateTimePicker1.Text + "',FirstName='" + textBox5.Text + "',LastName='" + textBox6.Text + "',Address='" + textBox7.Text + "',MobNumber='" + textBox8.Text + "',Category='" + Combocatagory.Text + "',Flavours='" + ComboFlavors.Text + "',Candle='" + ComboCandels.Text + "',CakeValue='" + TextBox9.Text + "',CandleValue='" + TxtCandelValue.Text + "',OtherValue='" + TextBox3.Text + "',DeliveryValue='" + TextBox4.Text + "',Total='" + TextBox10.Text + "'where OrderNo='" & TextBox1.Text & "'", con)

            cmd.ExecuteNonQuery()

            MsgBox("Order updated Successfully")
        Catch ex As Exception

            MessageBox.Show("Invalid" & ex.Message)
        Finally
            con.Close()
        End Try
        ''Me.RecordsTableAdapter.Fill(Me.TrialDataSet1.records)
    End Sub

    Private Sub Btnclear_Click(sender As Object, e As EventArgs) Handles Btnclear.Click
        TextBox3.Text = "00"
        TextBox4.Text = "00"
        Combocatagory.Text = " "
        ComboFlavors.Text = " "
        ComboCandels.Text = " "
        TxtCandelValue.Text = "00"
        TextBox10.Text = "00"
        TextBox9.Text = "00"
        TextBox1.Text = " "
        textBox5.Text = " "
        textBox6.Text = " "
        textBox7.Text = " "
        textBox8.Text = " "

    End Sub

    Private Sub printpreview_Click(sender As Object, e As EventArgs)
        ''  PrintPreviewDialog1.Document = PrintDocument1
        ''PrintPreviewDialog1.ShowDialog()



    End Sub

    Private Sub Printdocument_Click(sender As Object, e As EventArgs) Handles Printdocument.Click
        Bill.ShowDialog()
    End Sub
End Class