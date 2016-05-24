Public Class ComplexConditionalForm
    Private Sub CheckDate()
        Select Case dtpDate.Value.DayOfWeek.ToString()
            Case "Saturday"
                lblHours.Text = "10:00am - 4:00pm"
            Case "Sunday"
                lblHours.Text = "Closed"
            Case Else
                lblHours.Text = "8:00am - 6:00pm"
        End Select
    End Sub

    Private Sub ComplexConditionalForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CheckDate()
    End Sub

    Private Sub dtpDate_ValueChanged(sender As Object, e As EventArgs) Handles dtpDate.ValueChanged
        CheckDate()
    End Sub
End Class