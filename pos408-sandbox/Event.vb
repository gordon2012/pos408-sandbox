Public Class EventHandlers

    Private Sub Apple_Banana_Orange(sender As Object, e As EventArgs) Handles btnPrint.Click
        lblPrint.Text = lblPrint.Text + "*"
    End Sub

    Private Sub EventHandlers_MouseMove(sender As Object, e As MouseEventArgs) Handles MyBase.MouseMove
        lblPrint.Text = e.X.ToString() + ", " + e.Y.ToString()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lblPrint.Text = lblPrint.Text + "."
    End Sub
End Class