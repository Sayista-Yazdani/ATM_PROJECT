Public Class Form5
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Clear()

        TextBox3.Clear()
        TextBox4.Clear()


        TextBox5.Clear()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        My.Settings.FirstName = TextBox1.Text

        My.Settings.DOB = TextBox5.Text
        My.Settings.MobileNo = TextBox3.Text
            My.Settings.AccountNo = TextBox4.Text

            My.Settings.Save()
            My.Settings.Reload()
            MessageBox.Show("YOUR ACCOUNT SUCCESESFULLY OPEN")







    End Sub





    Private Sub Number_Only(sender As Object, e As KeyPressEventArgs) Handles TextBox3.KeyPress, TextBox4.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub


End Class