Public Class LoginFm
    Private Sub LoginBt_Click(sender As Object, e As EventArgs) Handles LoginBt.Click
        If UsernameTb.Text = My.Settings.Username And
            PasswordTb.Text = My.Settings.Password Then
            WelcomeFm.Show()
            Me.Hide()
        Else
            MsgBox("Incorrect Username or Password", MsgBoxStyle.Information, "Error")
        End If
    End Sub

    Private Sub CreateLL_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles CreateLL.LinkClicked
        Me.Hide()
        CreateFm.Show()
    End Sub

    Private Sub CloseBt_Click(sender As Object, e As EventArgs) Handles CloseBt.Click
        Me.Close()
    End Sub
End Class
