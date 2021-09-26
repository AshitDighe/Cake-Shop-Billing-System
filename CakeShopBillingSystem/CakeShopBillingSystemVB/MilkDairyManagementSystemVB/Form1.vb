Public Class Form1
    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        If textBox1.Text = "Admin" And textBox2.Text = "Ashit@226" Then
            MessageBox.Show("Welcome Admin")


            textBox1.Text = ""
            textBox2.Text = ""
            Hide()
            Home.ShowDialog()

        Else
            MessageBox.Show("login fail")
        End If

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub button2_Click(sender As Object, e As EventArgs) Handles button2.Click

    End Sub
End Class
