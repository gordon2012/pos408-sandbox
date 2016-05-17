Public Class MainForm
    Private Sub ShowModal(form As Form)
        Me.Hide()
        form.ShowDialog()
        Me.Show()
    End Sub



    Private Sub btnTransparency_Click(sender As Object, e As EventArgs) Handles btnTransparency.Click
        ShowModal(New TransparencyForm)
    End Sub

    Private Sub btnEvent_Click(sender As Object, e As EventArgs) Handles btnEvent.Click
        ShowModal(New EventForm)
    End Sub

    Private Sub btnByRef_Click(sender As Object, e As EventArgs) Handles btnByRef.Click
        ShowModal(New ByRefForm)
    End Sub

    Private Sub btnConstant_Click(sender As Object, e As EventArgs) Handles btnConstant.Click
        ShowModal(New ConstantForm)
    End Sub

    Private Sub btnAppend_Click(sender As Object, e As EventArgs) Handles btnAppend.Click
        ShowModal(New AppendForm)
    End Sub

    Private Sub btnOrElse_Click(sender As Object, e As EventArgs) Handles btnOrElse.Click
        ShowModal(New OrElseForm)
    End Sub
End Class