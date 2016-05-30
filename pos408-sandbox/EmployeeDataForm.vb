Imports System.IO

Public Class EmployeeDataForm
    Dim filename As String = ""
    Dim textFile As StreamWriter

    Private Sub EmployeeDataForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        While filename = ""
            filename = InputBox("Enter filename (without extension)")
        End While
        filename += ".txt"
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If File.Exists(filename) Then
            Debug.WriteLine("exists")
            textFile = File.AppendText(filename)
        Else
            Debug.WriteLine("not exists")
            textFile = File.CreateText(filename)
        End If

        textFile.WriteLine(txtFirstName.Text)
        textFile.WriteLine(txtMiddleName.Text)
        textFile.WriteLine(txtLastName.Text)
        textFile.WriteLine(txtEmployeeNumber.Text)
        textFile.WriteLine(If(cmbDepartment.SelectedIndex = -1, "", cmbDepartment.Items(cmbDepartment.SelectedIndex)))
        textFile.WriteLine(txtTelephoneNumber.Text)
        textFile.WriteLine(txtTelephoneExtension.Text)
        textFile.WriteLine(txtEmailAddress.Text)

        textFile.Close()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtFirstName.Text = ""
        txtMiddleName.Text = ""
        txtLastName.Text = ""
        txtEmployeeNumber.Text = ""
        cmbDepartment.SelectedIndex = -1
        txtTelephoneNumber.Text = ""
        txtTelephoneExtension.Text = ""
        txtEmailAddress.Text = ""
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
    End Sub
End Class