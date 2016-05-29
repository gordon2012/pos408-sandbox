<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RandomSentencesForm
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
        Me.lstSentences = New System.Windows.Forms.ListBox()
        Me.btnNew = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lstSentences
        '
        Me.lstSentences.FormattingEnabled = True
        Me.lstSentences.Location = New System.Drawing.Point(12, 12)
        Me.lstSentences.Name = "lstSentences"
        Me.lstSentences.Size = New System.Drawing.Size(488, 186)
        Me.lstSentences.TabIndex = 0
        '
        'btnNew
        '
        Me.btnNew.Location = New System.Drawing.Point(12, 213)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(148, 48)
        Me.btnNew.TabIndex = 1
        Me.btnNew.Text = "New Sentence"
        Me.btnNew.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(352, 213)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(148, 48)
        Me.btnExit.TabIndex = 2
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(181, 213)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(148, 48)
        Me.btnClear.TabIndex = 3
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'RandomSentencesForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(512, 279)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnNew)
        Me.Controls.Add(Me.lstSentences)
        Me.Name = "RandomSentencesForm"
        Me.Text = "Random Sentences"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lstSentences As System.Windows.Forms.ListBox
    Friend WithEvents btnNew As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
End Class
