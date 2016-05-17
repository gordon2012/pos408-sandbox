Public Class OrElseForm
    Private Function TestLeft() As Boolean
        lblAction.Text += "L"
        If txtLeft.Text <> String.Empty Then
            Return True
        End If
        Return False
    End Function

    Private Function TestRight() As Boolean
        lblAction.Text += "R"
        If txtRight.Text <> String.Empty Then
            Return True
        End If
        Return False
    End Function




    Private Sub OrElseForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblLabel.Text = ""
        lblAction.Text = ""
    End Sub

    Private Sub btnOr_Click(sender As Object, e As EventArgs) Handles btnOr.Click
        If TestLeft() Or TestRight() Then
            lblLabel.Text = "TRUE"
        Else
            lblLabel.Text = "FALSE"
        End If
    End Sub

    Private Sub btnOrElse_Click(sender As Object, e As EventArgs) Handles btnOrElse.Click
        If TestLeft() OrElse TestRight() Then
            lblLabel.Text = "TRUE"
        Else
            lblLabel.Text = "FALSE"
        End If
    End Sub
End Class