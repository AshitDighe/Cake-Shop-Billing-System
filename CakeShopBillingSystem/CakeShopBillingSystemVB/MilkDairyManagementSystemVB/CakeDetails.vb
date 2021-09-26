Imports System.Data.SqlClient

Public Class CakeDetails
    Private con As Object

    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        '' insert()
        Dim con As New SqlConnection
        Dim cmd As New SqlCommand

        Try
            con.ConnectionString = "Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=CakeShop;"
            con.Open()
            cmd.Connection = con

            cmd = New SqlCommand("insert into ItemDetails ([ItemNO],[Category],[Flavour],[Price]) values('" + textBox1.Text + "','" + textBox2.Text + "','" + TextBox3.Text + "','" + TextBox4.Text + "')", con)

            cmd.ExecuteNonQuery()
            MsgBox("Cake Details Inserted Successfully..")
        Catch ex As Exception

            MessageBox.Show("Invalid" & ex.Message)
        Finally
            con.Close()
        End Try
        ''Me.RecordsTableAdapter.Fill(Me.TrialDataSet1.records)

    End Sub

    Private Sub SetFatePrice_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '' dataGridviewItemDetails.DataSource = GetItemList()

        Dim connectionString As String = "Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=CakeShop;"
        Dim sql As String = "SELECT * FROM ItemDetails"
        Dim connection As New SqlConnection(connectionString)
        Dim dataadapter As New SqlDataAdapter(sql, connection)
        Dim ds As New DataSet()
        connection.Open()
        dataadapter.Fill(ds, "ItemDetails_table")
        connection.Close()
        dataGridviewItemDetails.DataSource = ds
        dataGridviewItemDetails.DataMember = "ItemDetails_table"
        Me.dataGridviewItemDetails.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
    End Sub

    Private Sub pictureBox1_Click(sender As Object, e As EventArgs) Handles pictureBox1.Click

    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Dim con As New SqlConnection
        Dim cmd As New SqlCommand

        Try
            con.ConnectionString = "Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=CakeShop;"
            con.Open()
            cmd.Connection = con

            cmd = New SqlCommand("Update ItemDetails Set ItemNO='" & textBox1.Text & "',Category='" & textBox2.Text & "',Flavour='" & TextBox3.Text & "',Price='" & TextBox4.Text & "'where ItemNO='" & textBox1.Text & "'", con)

            cmd.ExecuteNonQuery()

            MsgBox("Item Details updated Successfully..")
        Catch ex As Exception

            MessageBox.Show("Invalid" & ex.Message)
        Finally
            con.Close()
        End Try
        ''Me.RecordsTableAdapter.Fill(Me.TrialDataSet1.records)
    End Sub

    Private Sub dataGridviewItemDetails_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dataGridviewItemDetails.CellContentClick

    End Sub
End Class


