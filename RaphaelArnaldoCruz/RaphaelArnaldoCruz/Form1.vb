Public Class Form1
    Private db1, db2, db3, db4 As Integer

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub q1_TextChanged(sender As Object, e As EventArgs) Handles q1.TextChanged
        db1 = q1.Text

    End Sub

    Private Sub q2_TextChanged(sender As Object, e As EventArgs) Handles q2.TextChanged
        db2 = q2.Text

    End Sub

    Private Sub q3_TextChanged(sender As Object, e As EventArgs) Handles q3.TextChanged
        db3 = q3.Text

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        db4 = (db1 + db2 + db3) / 3
        qa.Text = db4

    End Sub
End Class
