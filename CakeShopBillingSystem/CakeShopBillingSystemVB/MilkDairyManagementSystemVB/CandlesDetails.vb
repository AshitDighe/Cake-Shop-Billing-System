Imports System.Data.SqlClient

Public Class CandlesDetails


    Private Sub button1_Click(sender As Object, e As EventArgs) Handles BtnAdd.Click
        Dim con As New SqlConnection
        Dim cmd As New SqlCommand

        Try
            con.ConnectionString = "Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=CakeShop;"
            con.Open()
            cmd.Connection = con

            cmd = New SqlCommand("insert into CandleDetails ([C_NO],[CandleName],[Price]) values('" + textBox1.Text + "','" + TextBox2.Text + "','" + TextBox3.Text + "')", con)

            cmd.ExecuteNonQuery()
            MsgBox("Candel Details Inserted Successfully..")
        Catch ex As Exception

            MessageBox.Show("Invalid" & ex.Message)
        Finally
            con.Close()
        End Try
        ''Me.RecordsTableAdapter.Fill(Me.TrialDataSet1.records)
    End Sub

    Private Sub dataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dataGridviewCandelsDetails.CellContentClick

    End Sub

    Private Sub candelsDetails_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim connectionString As String = "Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=CakeShop;"
        Dim sql As String = "SELECT * FROM CandleDetails"
        Dim connection As New SqlConnection(connectionString)
        Dim dataadapter As New SqlDataAdapter(sql, connection)
        Dim ds As New DataSet()
        connection.Open()
        dataadapter.Fill(ds, "CandleDetails_table")
        connection.Close()
        dataGridviewCandelsDetails.DataSource = ds
        dataGridviewCandelsDetails.DataMember = "CandleDetails_table"
        Me.dataGridviewCandelsDetails.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
    End Sub

    Private Sub Btnupdate_Click(sender As Object, e As EventArgs) Handles Btnupdate.Click
        Dim con As New SqlConnection
        Dim cmd As New SqlCommand

        Try
            con.ConnectionString = "Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=CakeShop;"
            con.Open()
            cmd.Connection = con

            cmd = New SqlCommand("Update CandleDetails Set C_No='" & textBox1.Text & "',CandleName='" & TextBox2.Text & "',Price='" & TextBox3.Text & "' where C_No='" & textBox1.Text & "'", con)

            cmd.ExecuteNonQuery()

            MsgBox("Item Details updated Successfully..")
        Catch ex As Exception

            MessageBox.Show("Invalid" & ex.Message)
        Finally
            con.Close()
        End Try
        ''Me.RecordsTableAdapter.Fill(Me.TrialDataSet1.records)
    End Sub
End Class