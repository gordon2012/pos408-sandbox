Public Class StudentTestScoresForm

    'Student Test Scores
    'A teacher has six students and wants you to create an application that stores their
    'grade data in a file and prints a grade report. The application should have a structure
    'that stores the following student data: Name (a string), Test Scores (an array of
    'five Doubles), and Average (a Double). Because the teacher has six students, the application
    'should use an array of six structure variables.
    'The application should allow the user to enter data for each student, and calculate
    'the average test score.

    Structure Student
        Dim name As String
        Dim scores() As Double
        Dim average As Double
    End Structure

    Dim students(6) As Student



    Private Sub StudentTestScoresForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim count As Integer = 0
        Debug.WriteLine(pnlStudent1.Controls.ToString())

        For Each child As Control In pnlStudent1.Controls
            child.Text = count.ToString()
            count = count + 1
        Next

        'pnlStudent1.ch()


    End Sub
End Class