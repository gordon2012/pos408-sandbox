Public Class SoftwareSalesForm
    Private Sub Validation(control As String)
        Dim textbox As Control = Me.Controls.Find("txt" + control, True)(0)
        Dim errorlabel As Control = Me.Controls.Find("lbl" + control, True)(0)

        Dim value As Integer
        If Integer.TryParse(textbox.Text, value) Then
            If value < 0 Then
                errorlabel.Text = "Integer out of range"
                errorlabel.Visible = True
                btnCalculate.Enabled = False
            End If
        ElseIf textbox.Text = String.Empty Then
            btnCalculate.Enabled = False
        Else
            btnCalculate.Enabled = False
            errorlabel.Text = "Not a valid integer"
            errorlabel.Visible = True
        End If
    End Sub

    Private Sub ValidateAll()
        btnCalculate.Enabled = True
        lblA.Visible = False
        lblB.Visible = False
        lblC.Visible = False

        Validation("A")
        Validation("B")
        Validation("C")
    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        txtOutput.Text = ""

        Dim grandTotal As Double = 0

        Dim packages() As String = {"A", "B", "C"}
        Dim prices() As Double = {99, 199, 299}

        For i = 0 To 2
            Dim total As Double
            Dim amt As Integer = CInt(Me.Controls.Find("txt" + packages(i), True)(0).Text)
            Select Case amt
                Case 1 To 9
                    total = amt * prices(i)
                Case 10 To 19
                    total = amt * prices(i) * 0.8
                Case 20 To 49
                    total = amt * prices(i) * 0.7
                Case 50 To 99
                    total = amt * prices(i) * 0.6
                Case Else
                    total = amt * prices(i) * 0.5
            End Select
            txtOutput.Text += "Package " + packages(i) + ": " + FormatCurrency(total) + vbNewLine
            grandTotal += total
        Next
        txtOutput.Text += vbNewLine + "Grand Total: " + FormatCurrency(grandTotal)
    End Sub

    Private Sub SoftwareSalesForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ValidateAll()
    End Sub
    Private Sub txtA_TextChanged(sender As Object, e As EventArgs) Handles txtA.TextChanged
        ValidateAll()
    End Sub
    Private Sub txtB_TextChanged(sender As Object, e As EventArgs) Handles txtB.TextChanged
        ValidateAll()
    End Sub
    Private Sub txtC_TextChanged(sender As Object, e As EventArgs) Handles txtC.TextChanged
        ValidateAll()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtA.Text = ""
        txtB.Text = ""
        txtC.Text = ""
        txtOutput.Text = ""
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub txtOutput_Enter(sender As Object, e As EventArgs) Handles txtOutput.Enter
        Label1.Select()
    End Sub
End Class
