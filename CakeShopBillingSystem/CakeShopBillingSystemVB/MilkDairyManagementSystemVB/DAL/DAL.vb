Public Class DAL

    Public Function GetItemDetailsbyId(Id As Integer)

        Dim ds As DataSet = New DataSet()

        Dim connetionString As String = Nothing
        Dim command As SqlCommand
        Dim adapter As SqlDataAdapter = New SqlDataAdapter()

        Dim i As Integer = 0
        Dim sql As String = Nothing

        Using _Con As SqlConnection = New SqlConnection("Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=CakeShop;")
            sql = "select * from ItemDetails where Id=" & Id

            If _Con.State = ConnectionState.Closed Then
                _Con.Open()
            End If

            command = New SqlCommand(sql, _Con)
            adapter.SelectCommand = command
            adapter.Fill(ds)

            adapter.Dispose()
            command.Dispose()
            Return ds



            _Con.Close()
        End Using
    End Function