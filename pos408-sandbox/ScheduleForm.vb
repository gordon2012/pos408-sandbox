Public Class ScheduleForm

    Private Sub ScheduleForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'InstructorsScheduleDataSet.Instructors' table. You can move, or remove it, as needed.
        Me.InstructorsTableAdapter.Fill(Me.InstructorsScheduleDataSet.Instructors)
        'TODO: This line of code loads data into the 'InstructorsScheduleDataSet.Schedule' table. You can move, or remove it, as needed.
        Me.ScheduleTableAdapter.Fill(Me.InstructorsScheduleDataSet.Schedule)

    End Sub


    Private Sub lstInstructor_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstInstructor.SelectedIndexChanged
        Try
            Me.ScheduleTableAdapter.FillByInstructor(Me.InstructorsScheduleDataSet.Schedule, CType(lstInstructor.SelectedValue, Integer))
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub


End Class