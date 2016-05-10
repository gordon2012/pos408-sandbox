Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim newform As New Form2

        Me.Hide()
        newform.ShowDialog()
        Me.Close()



    End Sub
End Class
