Public Class AppendForm

    Private Sub btnError_Click(sender As Object, e As EventArgs) Handles btnError.Click

        'Dim text = 

        lblLog.Text += "ERROR: Splines not reticulating" + vbNewLine
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        lblLog.Text = ""
    End Sub

  
    Private Sub btnText_Click(sender As Object, e As EventArgs) Handles btnText.Click
        txtLog.AppendText("ERROR: Reticulating splines" + vbNewLine)

    End Sub
End Class