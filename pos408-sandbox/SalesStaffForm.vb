Public Class SalesStaffForm
    Private Sub SalesStaffForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'CompanyDataSet.SalesStaff' table. You can move, or remove it, as needed.
        Me.SalesStaffTableAdapter.Fill(Me.CompanyDataSet.SalesStaff)

    End Sub

    Private Sub SalaryTextBox_TextChanged(sender As Object, e As EventArgs) Handles SalaryTextBox.TextChanged
        SalaryTextBox.Text = FormatCurrency(SalaryTextBox.Text)
    End Sub
End Class

