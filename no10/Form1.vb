Public Class Form1
    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles txtpassword.TextChanged

    End Sub

    Private Sub txtusername_TextChanged(sender As Object, e As EventArgs) Handles txtpassword.TextChanged
        Dim yi As TextBox = CType(sender, TextBox)
        If (String.IsNullOrEmpty(yi.Text)) Then
            yi.BackColor = Color.MistyRose

        End If
    End Sub
    Private Sub txtpassword_TextChanged(sender As Object, e As EventArgs) Handles txtpassword.TextChanged
        Dim yi As TextBox = CType(sender, TextBox)
        If (String.IsNullOrEmpty(yi.Text)) Then
            yi.BackColor = Color.MistyRose

        End If
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If txtusername.Text = "login" And txtpassword.text = "abc123" Then

            MessageBox.Show("帳戶密碼正確")
            End

        Else

            MessageBox.Show("帳號密碼錯誤")

        End If


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        End

    End Sub
End Class
