Public Class MainForm
    Private Sub ShowModal(form As Form)
        Me.Hide()
        form.ShowDialog()
        Me.Show()
    End Sub


    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'ShowModal(New RomanNumeralForm)
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

    Private Sub btnErrorLabel_Click(sender As Object, e As EventArgs) Handles btnErrorLabel.Click
        ShowModal(New ErrorLabelForm)
    End Sub

    Private Sub btnFlowchart_Click(sender As Object, e As EventArgs) Handles btnFlowchart.Click
        ShowModal(New FlowchartForm)
    End Sub

    Private Sub btnConditional_Click(sender As Object, e As EventArgs) Handles btnConditional.Click
        ShowModal(New ComplexConditionalForm)
    End Sub

    Private Sub btnRomanNumeral_Click(sender As Object, e As EventArgs) Handles btnRomanNumeral.Click
        ShowModal(New RomanNumeralForm)
    End Sub
End Class