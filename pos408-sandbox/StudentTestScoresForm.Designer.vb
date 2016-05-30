<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StudentTestScoresForm
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtName0 = New System.Windows.Forms.TextBox()
        Me.txtScore0_0 = New System.Windows.Forms.TextBox()
        Me.txtScore0_1 = New System.Windows.Forms.TextBox()
        Me.txtScore0_2 = New System.Windows.Forms.TextBox()
        Me.txtScore0_3 = New System.Windows.Forms.TextBox()
        Me.txtScore0_4 = New System.Windows.Forms.TextBox()
        Me.txtAverage0 = New System.Windows.Forms.TextBox()
        Me.pnlStudent1 = New System.Windows.Forms.Panel()
        Me.pnlStudent1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(96, 43)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Student Data"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(60, 95)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(245, 95)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(64, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Test Scores"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(384, 95)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(47, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Average"
        '
        'txtName0
        '
        Me.txtName0.Location = New System.Drawing.Point(0, 0)
        Me.txtName0.Name = "txtName0"
        Me.txtName0.Size = New System.Drawing.Size(145, 20)
        Me.txtName0.TabIndex = 0
        '
        'txtScore0_0
        '
        Me.txtScore0_0.Location = New System.Drawing.Point(165, 0)
        Me.txtScore0_0.Name = "txtScore0_0"
        Me.txtScore0_0.Size = New System.Drawing.Size(35, 20)
        Me.txtScore0_0.TabIndex = 1
        '
        'txtScore0_1
        '
        Me.txtScore0_1.Location = New System.Drawing.Point(206, 0)
        Me.txtScore0_1.Name = "txtScore0_1"
        Me.txtScore0_1.Size = New System.Drawing.Size(35, 20)
        Me.txtScore0_1.TabIndex = 2
        '
        'txtScore0_2
        '
        Me.txtScore0_2.Location = New System.Drawing.Point(247, 0)
        Me.txtScore0_2.Name = "txtScore0_2"
        Me.txtScore0_2.Size = New System.Drawing.Size(35, 20)
        Me.txtScore0_2.TabIndex = 3
        '
        'txtScore0_3
        '
        Me.txtScore0_3.Location = New System.Drawing.Point(288, 0)
        Me.txtScore0_3.Name = "txtScore0_3"
        Me.txtScore0_3.Size = New System.Drawing.Size(35, 20)
        Me.txtScore0_3.TabIndex = 4
        '
        'txtScore0_4
        '
        Me.txtScore0_4.Location = New System.Drawing.Point(329, 0)
        Me.txtScore0_4.Name = "txtScore0_4"
        Me.txtScore0_4.Size = New System.Drawing.Size(35, 20)
        Me.txtScore0_4.TabIndex = 5
        '
        'txtAverage0
        '
        Me.txtAverage0.Enabled = False
        Me.txtAverage0.Location = New System.Drawing.Point(384, 0)
        Me.txtAverage0.Name = "txtAverage0"
        Me.txtAverage0.Size = New System.Drawing.Size(35, 20)
        Me.txtAverage0.TabIndex = 6
        Me.txtAverage0.TabStop = False
        '
        'pnlStudent1
        '
        Me.pnlStudent1.Controls.Add(Me.txtAverage0)
        Me.pnlStudent1.Controls.Add(Me.txtName0)
        Me.pnlStudent1.Controls.Add(Me.txtScore0_4)
        Me.pnlStudent1.Controls.Add(Me.txtScore0_0)
        Me.pnlStudent1.Controls.Add(Me.txtScore0_3)
        Me.pnlStudent1.Controls.Add(Me.txtScore0_1)
        Me.pnlStudent1.Controls.Add(Me.txtScore0_2)
        Me.pnlStudent1.Location = New System.Drawing.Point(12, 136)
        Me.pnlStudent1.Name = "pnlStudent1"
        Me.pnlStudent1.Size = New System.Drawing.Size(419, 20)
        Me.pnlStudent1.TabIndex = 11
        '
        'StudentTestScoresForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(505, 417)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.pnlStudent1)
        Me.Name = "StudentTestScoresForm"
        Me.Text = "Student Test Scores"
        Me.pnlStudent1.ResumeLayout(False)
        Me.pnlStudent1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtName0 As System.Windows.Forms.TextBox
    Friend WithEvents txtScore0_0 As System.Windows.Forms.TextBox
    Friend WithEvents txtScore0_1 As System.Windows.Forms.TextBox
    Friend WithEvents txtScore0_2 As System.Windows.Forms.TextBox
    Friend WithEvents txtScore0_3 As System.Windows.Forms.TextBox
    Friend WithEvents txtScore0_4 As System.Windows.Forms.TextBox
    Friend WithEvents txtAverage0 As System.Windows.Forms.TextBox
    Friend WithEvents pnlStudent1 As System.Windows.Forms.Panel
End Class
