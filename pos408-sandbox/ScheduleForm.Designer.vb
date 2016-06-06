<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ScheduleForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.ScheduleBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.InstructorsScheduleDataSet = New pos408_sandbox.InstructorsScheduleDataSet()
        Me.ScheduleTableAdapter = New pos408_sandbox.InstructorsScheduleDataSetTableAdapters.ScheduleTableAdapter()
        Me.lstInstructor = New System.Windows.Forms.ListBox()
        Me.InstructorsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.InstructorsTableAdapter = New pos408_sandbox.InstructorsScheduleDataSetTableAdapters.InstructorsTableAdapter()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.IDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DayDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TimeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.InstructorIdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.ScheduleBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.InstructorsScheduleDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.InstructorsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ScheduleBindingSource
        '
        Me.ScheduleBindingSource.DataMember = "Schedule"
        Me.ScheduleBindingSource.DataSource = Me.InstructorsScheduleDataSet
        Me.ScheduleBindingSource.Filter = ""
        '
        'InstructorsScheduleDataSet
        '
        Me.InstructorsScheduleDataSet.DataSetName = "InstructorsScheduleDataSet"
        Me.InstructorsScheduleDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ScheduleTableAdapter
        '
        Me.ScheduleTableAdapter.ClearBeforeFill = True
        '
        'lstInstructor
        '
        Me.lstInstructor.DataSource = Me.InstructorsBindingSource
        Me.lstInstructor.DisplayMember = "Last_Name"
        Me.lstInstructor.FormattingEnabled = True
        Me.lstInstructor.Location = New System.Drawing.Point(45, 65)
        Me.lstInstructor.Name = "lstInstructor"
        Me.lstInstructor.Size = New System.Drawing.Size(166, 212)
        Me.lstInstructor.TabIndex = 1
        Me.lstInstructor.ValueMember = "ID"
        '
        'InstructorsBindingSource
        '
        Me.InstructorsBindingSource.DataMember = "Instructors"
        Me.InstructorsBindingSource.DataSource = Me.InstructorsScheduleDataSet
        '
        'InstructorsTableAdapter
        '
        Me.InstructorsTableAdapter.ClearBeforeFill = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDDataGridViewTextBoxColumn, Me.DayDataGridViewTextBoxColumn, Me.TimeDataGridViewTextBoxColumn, Me.InstructorIdDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.ScheduleBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(258, 40)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(591, 342)
        Me.DataGridView1.TabIndex = 2
        '
        'IDDataGridViewTextBoxColumn
        '
        Me.IDDataGridViewTextBoxColumn.DataPropertyName = "ID"
        Me.IDDataGridViewTextBoxColumn.HeaderText = "ID"
        Me.IDDataGridViewTextBoxColumn.Name = "IDDataGridViewTextBoxColumn"
        '
        'DayDataGridViewTextBoxColumn
        '
        Me.DayDataGridViewTextBoxColumn.DataPropertyName = "Day"
        Me.DayDataGridViewTextBoxColumn.HeaderText = "Day"
        Me.DayDataGridViewTextBoxColumn.Name = "DayDataGridViewTextBoxColumn"
        '
        'TimeDataGridViewTextBoxColumn
        '
        Me.TimeDataGridViewTextBoxColumn.DataPropertyName = "Time"
        Me.TimeDataGridViewTextBoxColumn.HeaderText = "Time"
        Me.TimeDataGridViewTextBoxColumn.Name = "TimeDataGridViewTextBoxColumn"
        '
        'InstructorIdDataGridViewTextBoxColumn
        '
        Me.InstructorIdDataGridViewTextBoxColumn.DataPropertyName = "Instructor_Id"
        Me.InstructorIdDataGridViewTextBoxColumn.HeaderText = "Instructor_Id"
        Me.InstructorIdDataGridViewTextBoxColumn.Name = "InstructorIdDataGridViewTextBoxColumn"
        '
        'ScheduleForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(935, 480)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.lstInstructor)
        Me.Name = "ScheduleForm"
        Me.Text = "ScheduleForm"
        CType(Me.ScheduleBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.InstructorsScheduleDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.InstructorsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents InstructorsScheduleDataSet As pos408_sandbox.InstructorsScheduleDataSet
    Friend WithEvents ScheduleBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ScheduleTableAdapter As pos408_sandbox.InstructorsScheduleDataSetTableAdapters.ScheduleTableAdapter
    Friend WithEvents lstInstructor As System.Windows.Forms.ListBox
    Friend WithEvents InstructorsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents InstructorsTableAdapter As pos408_sandbox.InstructorsScheduleDataSetTableAdapters.InstructorsTableAdapter
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents IDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DayDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TimeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents InstructorIdDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
