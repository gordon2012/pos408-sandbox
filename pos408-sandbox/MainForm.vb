Public Class MainForm
    Private Sub btnTransparency_Click(sender As Object, e As EventArgs) Handles btnTransparency.Click
        Dim frmTransparency As New Transparency
        Me.Hide()
        frmTransparency.ShowDialog()
        Me.Show()
    End Sub

    Private Sub btnEvent_Click(sender As Object, e As EventArgs) Handles btnEvent.Click
        Dim frmEvent As New EventHandlers
        Me.Hide()
        frmEvent.ShowDialog()
        Me.Show()
    End Sub
End Class