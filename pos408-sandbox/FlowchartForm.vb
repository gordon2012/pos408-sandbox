Public Class FlowchartForm
    Private Sub DoValidation()
        If Double.TryParse(txtInput.Text, Nothing) Then
            lblInput.Visible = False
            btnCalculate.Enabled = True
        Else
            btnCalculate.Enabled = False
            If txtInput.Text <> "" Then
                lblInput.Text = "Invalid number"
                lblInput.Visible = True
            Else
                lblInput.Visible = False
            End If
        End If
    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim f As Double = Double.Parse(txtInput.Text)
        Dim fi As Integer = CInt(Math.Truncate(f))
        Dim fr As Double = Math.Abs(f) - Math.Abs(fi)

        Dim out As Double

        If fr > 0.5 Then
            out = fi + 1
        ElseIf fr < 0.5 Then
            out = fi
        Else
            If fi Mod 2 = 0 Then
                out = fi
            Else
                out = fi + 1
            End If
        End If

        lblOutput.Text = out.ToString()
    End Sub

    Private Sub FlowchartForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblOutput.Text = ""
        DoValidation()
    End Sub

    Private Sub txtInput_TextChanged(sender As Object, e As EventArgs) Handles txtInput.TextChanged
        DoValidation()
    End Sub
End Class