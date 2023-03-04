Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Button5.Enabled = False
        Button6.Enabled = False
        Button7.Enabled = False
        Button8.Enabled = False
        Button1.Enabled = False
        Button2.Enabled = False
        Button3.Enabled = False
        Button4.Enabled = False
        label6.Visible = False
        Label7.Visible = False
        Label8.Visible = False
        Label9.Visible = False
        Button1.Enabled = False
        Button2.Enabled = False
        Button3.Enabled = False
        Button4.Enabled = False

    End Sub

    Private Sub TextBox6_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        TabControl1.SelectedTab = TabPage4
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        TabControl1.SelectedTab = TabPage2
        ComboBox1.SelectedIndex = 0
        ComboBox2.SelectedIndex = 0

    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        TabControl1.SelectedTab = TabPage1

        Button1.Enabled = True
        Button2.Enabled = True
        Button3.Enabled = True
        Button4.Enabled = True



    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        TabControl1.SelectedTab = TabPage3
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim Ex As DialogResult
        Ex = MessageBox.Show("You Want To Exit ", "Exit Application", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If Ex = DialogResult.Yes Then
            Application.Exit()

        End If
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        Dim Ex As DialogResult
        Ex = MessageBox.Show("You Want To Exit ", "Exit Application", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If Ex = DialogResult.Yes Then
            Application.Exit()

        End If
    End Sub

    Private Sub Button20_Click(sender As Object, e As EventArgs) Handles Button20.Click

        Try

            If My.Settings.PIN = Label10.Text Then
                Button5.Enabled = True
                Button6.Enabled = True
                Button7.Enabled = True
                Button8.Enabled = True
                label6.Visible = True
                Label7.Visible = True
                Label8.Visible = True
                Label9.Visible = True
            Else
                MessageBox.Show("Invalid PIN")
            End If
        Catch ex As Exception

        End Try

    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Label10.Text = Label10.Text + "1"
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        Label10.Text = Label10.Text + "2"
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        Label10.Text = Label10.Text + "3"
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        Label10.Text = Label10.Text + "4"
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        Label10.Text = Label10.Text + "5"
    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        Label10.Text = Label10.Text + "6"
    End Sub

    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click
        Label10.Text = Label10.Text + "7"
    End Sub

    Private Sub Button18_Click(sender As Object, e As EventArgs) Handles Button18.Click
        Label10.Text = Label10.Text + "8"
    End Sub

    Private Sub Button19_Click(sender As Object, e As EventArgs) Handles Button19.Click
        Label10.Text = Label10.Text + "9"
    End Sub

    Private Sub Button22_Click(sender As Object, e As EventArgs) Handles Button22.Click
        Label10.Text = Label10.Text + "0"
    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        Label10.Text = ""
        Button5.Enabled = False
        Button6.Enabled = False
        Button7.Enabled = False
        Button8.Enabled = False
        Button1.Enabled = False
        Button2.Enabled = False
        Button3.Enabled = False
        Button4.Enabled = False
        label6.Visible = False
        Label7.Visible = False
        Label8.Visible = False
        Label9.Visible = False

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()
        TextBox5.Clear()
        RichTextBox1.Clear()

    End Sub

    Private Sub Number_Only(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress, TextBox2.KeyPress, TextBox3.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TextBox5.Text = (TextBox1.Text * TextBox2.Text * TextBox3.Text) / 100 + TextBox1.Text
        TextBox4.Text = (TextBox5.Text / 12)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        RichTextBox1.AppendText("Receipt of Loan" + vbNewLine)
        RichTextBox1.AppendText(Label1.Text + vbTab + TextBox1.Text + vbNewLine)
        RichTextBox1.AppendText(Label2.Text + vbTab + TextBox2.Text + vbNewLine)
        RichTextBox1.AppendText(Label3.Text + vbTab + TextBox3.Text + vbNewLine)
        RichTextBox1.AppendText(Label4.Text + vbTab + TextBox4.Text + vbNewLine)
        RichTextBox1.AppendText(Label5.Text + vbTab + TextBox5.Text + vbNewLine)
        RichTextBox1.AppendText("Thankyou")
    End Sub

    Private Sub Button26_Click(sender As Object, e As EventArgs) Handles Button26.Click
        TextBox6.Clear()
        TextBox7.Clear()
        ComboBox1.SelectedIndex = 0
        ComboBox2.SelectedIndex = 0


    End Sub

    Private Sub Button25_Click(sender As Object, e As EventArgs) Handles Button25.Click
        If ComboBox1.SelectedIndex = 1 And ComboBox2.SelectedIndex = 4 Then
            TextBox7.Text = TextBox6.Text * 102
        ElseIf ComboBox1.SelectedIndex = 4 And ComboBox2.SelectedIndex = 1 Then
            TextBox7.Text = TextBox6.Text / 102
        ElseIf ComboBox1.SelectedIndex = 6 And ComboBox2.SelectedIndex = 4 Then
            TextBox7.Text = TextBox6.Text * 72
        ElseIf ComboBox1.SelectedIndex = 4 And ComboBox2.SelectedIndex = 6 Then
            TextBox7.Text = TextBox6.Text / 72
        ElseIf ComboBox1.SelectedIndex = 2 And ComboBox2.SelectedIndex = 4 Then
            TextBox7.Text = TextBox6.Text * 88
        ElseIf ComboBox1.SelectedIndex = 4 And ComboBox2.SelectedIndex = 2 Then
            TextBox7.Text = TextBox6.Text / 88
        ElseIf ComboBox1.SelectedIndex = 3 And ComboBox2.SelectedIndex = 4 Then
            TextBox7.Text = TextBox6.Text * 240
        ElseIf ComboBox1.SelectedIndex = 4 And ComboBox2.SelectedIndex = 3 Then
            TextBox7.Text = TextBox6.Text / 240
        ElseIf ComboBox1.SelectedIndex = 5 And ComboBox2.SelectedIndex = 4 Then
            TextBox7.Text = TextBox6.Text * 80
        ElseIf ComboBox1.SelectedIndex = 4 And ComboBox2.SelectedIndex = 5 Then
            TextBox7.Text = TextBox6.Text / 80
        End If
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Button27_Click(sender As Object, e As EventArgs) Handles Button27.Click
        If TextBox8.Text = My.Settings.FirstName And TextBox9.Text = My.Settings.AccountNo Then
            My.Settings.Amt = TextBox10.Text
            My.Settings.Save()
            My.Settings.Reload()
            MessageBox.Show("Your Amount Sucessfully Credit")
        Else
            MessageBox.Show("Invalid Details")
        End If
    End Sub

    Private Sub Button30_Click(sender As Object, e As EventArgs) Handles Button30.Click
        If TextBox11.Text = My.Settings.FirstName And TextBox12.Text = My.Settings.AccountNo And My.Settings.Amt >= TextBox13.Text Then
            My.Settings.Save()
            My.Settings.Reload()
            MessageBox.Show("Your Amount Sucessfully Debit")
        Else
            MessageBox.Show("Invalid Details")
        End If
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged

    End Sub

    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles TextBox4.TextChanged

    End Sub
End Class
