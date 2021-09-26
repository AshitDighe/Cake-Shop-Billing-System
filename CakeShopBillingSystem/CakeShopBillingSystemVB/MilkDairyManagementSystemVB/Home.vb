Public Class Home
    Private Sub milkDairyToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles milkDairyToolStripMenuItem.Click
        OrderForm.ShowDialog()
    End Sub

    Private Sub setFatePriceToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles setFatePriceToolStripMenuItem.Click
        CakeDetails.ShowDialog()
    End Sub

    Private Sub searchAccountToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles searchAccountToolStripMenuItem.Click
        CandlesDetails.ShowDialog()
    End Sub

    Private Sub searchMilkDairyRecordToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RecordToolStripMenuItem.Click
        OrderDetails.ShowDialog()

    End Sub

    Private Sub newAccountToolStripMenuItem_Click(sender As Object, e As EventArgs)
        '' NewAccount.ShowDialog()
    End Sub

    Private Sub pictureBox1_Click(sender As Object, e As EventArgs) Handles pictureBox1.Click

    End Sub

    Private Sub exitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles exitToolStripMenuItem.Click
        Application.Exit()

    End Sub

    Private Sub Home_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class