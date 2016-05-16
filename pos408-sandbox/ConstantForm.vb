Public Class ConstantForm

    Public Const DaysPerWeek = 7

    Private Sub btnChange_Click(sender As Object, e As EventArgs) Handles btnChange.Click
        ' Would produce an error
        '
        ' DaysPerWeek = 8 
    End Sub

    Private Sub ConstantForm_Paint(sender As Object, e As PaintEventArgs) Handles MyBase.Paint
        lblDays.Text = DaysPerWeek.ToString()
    End Sub
End Class