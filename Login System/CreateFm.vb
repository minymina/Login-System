Public Class CreateFm
    Private Sub CreateBt_Click(sender As Object, e As EventArgs) Handles CreateBt.Click
        My.Settings.Username = UsernameTb.Text
        My.Settings.Password = PasswordTb.Text
        My.Settings.Save()
        MsgBox("Create Account", MsgBoxStyle.Information, "Create")
        Me.Hide()
        LoginFm.Show()
    End Sub

    Private Sub CloseBt_Click(sender As Object, e As EventArgs) Handles CloseBt.Click
        Me.Hide()
        LoginFm.Show()
    End Sub
End Class