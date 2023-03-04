Public Class Form6
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If TextBox1.Text = TextBox2.Text Then
            My.Settings.PIN = TextBox2.Text
            My.Settings.Save()
            My.Settings.Reload()
            MessageBox.Show("Your PIN Successfully Reset")
        Else
            MessageBox.Show("Your Digit are Not Match")

        End If



    End Sub


    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If TextBox3.Text = My.Settings.AccountNo Then
            TextBox1.Enabled = True
            TextBox2.Enabled = True
        Else
            MessageBox.Show("Your Details Not Veriefy")
        End If
    End Sub
End Class