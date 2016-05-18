Public Class ErrorLabelForm
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        If txtUsername.Text <> "student" Then
            errUsername.SetError(txtUsername, "Invalid username")
        Else
            errUsername.SetError(txtUsername, String.Empty)
        End If
    End Sub
End Class