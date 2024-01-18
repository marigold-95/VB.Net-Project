Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim a, b, c As Double

        a = Val(TextBox1.Text)
        b = Val(TextBox2.Text)

        c = (a ^ 2 + b ^ 2) ^ 0.5

        TextBox3.Text = c
    End Sub
End Class
