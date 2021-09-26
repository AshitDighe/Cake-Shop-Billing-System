Imports System.Data.SqlClient

Public Class OrderDetails

    Private Sub SearchMilkDairyRecord_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim connectionString As String = "Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=CakeShop;"
        Dim sql As String = "SELECT * FROM OrderDetails"
        Dim connection As New SqlConnection(connectionString)
        Dim dataadapter As New SqlDataAdapter(sql, connection)
        Dim ds As New DataSet()
        connection.Open()
        dataadapter.Fill(ds, "OrderDetails_table")
        connection.Close()
        dataGridViewOrderDetailRcord.DataSource = ds
        dataGridViewOrderDetailRcord.DataMember = "OrderDetails_table"
        Me.dataGridViewOrderDetailRcord.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
    End Sub
End Class