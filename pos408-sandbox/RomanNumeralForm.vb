Public Class RomanNumeralForm
    Private Sub Validation()
        Dim value As Integer
        If Integer.TryParse(txtInput.Text, value) Then
            If value >= 1 And value <= 10 Then
                btnConvert.Enabled = True
                lblValidation.Visible = False
            Else
                btnConvert.Enabled = False
                lblValidation.Text = "Integer out of range"
                lblValidation.Visible = True
            End If
        ElseIf txtInput.Text = String.Empty Then
            btnConvert.Enabled = False
            lblValidation.Visible = False
        Else
            btnConvert.Enabled = False
            lblValidation.Text = "Not a valid integer"
            lblValidation.Visible = True
        End If
    End Sub

    Private Sub RomanNumeralForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Validation()
        lblNumeral.Text = ""
    End Sub
    Private Sub txtInput_TextChanged(sender As Object, e As EventArgs) Handles txtInput.TextChanged
        Validation()
    End Sub

    Private Sub btnConvert_Click(sender As Object, e As EventArgs) Handles btnConvert.Click
        Select Case CInt(txtInput.Text)
            Case 1
                lblNumeral.Text = "I"
            Case 2
                lblNumeral.Text = "II"
            Case 3
                lblNumeral.Text = "III"
            Case 4
                lblNumeral.Text = "IV"
            Case 5
                lblNumeral.Text = "V"
            Case 6
                lblNumeral.Text = "VI"
            Case 7
                lblNumeral.Text = "VII"
            Case 8
                lblNumeral.Text = "VIII"
            Case 9
                lblNumeral.Text = "IX"
            Case 10
                lblNumeral.Text = "X"
        End Select
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
