Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim a, b, c, aux As Integer
        a = Convert.ToInt32(TextBox1.Text)
        b = Convert.ToInt32(TextBox2.Text)
        c = Convert.ToInt32(TextBox3.Text)
vol1:
        If a < b Then GoTo cond1
vol2:
        If b < c Then GoTo cond2
        GoTo salir
cond2:
        aux = b
        b = c
        c = aux
        GoTo vol1
cond1:
        aux = a
        a = b
        b = aux
        GoTo vol2
salir:
        TextBox4.Text = c.ToString()
        TextBox5.Text = b.ToString()
        TextBox6.Text = a.ToString()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""
        TextBox6.Text = ""
    End Sub
End Class
