Public Class Form4
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = My.Settings.PIN And TextBox2.Text = TextBox3.Text Then
            My.Settings.PIN = TextBox3.Text
            My.Settings.Save()
            My.Settings.Reload()
            MessageBox.Show("Your PIN sucessfully Change")
        Else
            MessageBox.Show("Old PIN Or New PIN And Conform PIN Not Match")
        End If
    End Sub

    Private Sub Number_Only(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress, TextBox3.KeyPress, TextBox2.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()

    End Sub
End Class