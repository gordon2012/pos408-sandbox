<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
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
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.btnTransparency = New System.Windows.Forms.Button()
        Me.btnByRef = New System.Windows.Forms.Button()
        Me.btnEvent = New System.Windows.Forms.Button()
        Me.btnConstant = New System.Windows.Forms.Button()
        Me.btnAppend = New System.Windows.Forms.Button()
        Me.btnOrElse = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.btnSoftwareSales = New System.Windows.Forms.Button()
        Me.btnRomanNumeral = New System.Windows.Forms.Button()
        Me.btnConditional = New System.Windows.Forms.Button()
        Me.btnFlowchart = New System.Windows.Forms.Button()
        Me.btnErrorLabel = New System.Windows.Forms.Button()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.btnSentences = New System.Windows.Forms.Button()
        Me.btnEmployees = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(150, 9)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(195, 37)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "VB Sandbox"
        '
        'btnTransparency
        '
        Me.btnTransparency.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTransparency.Location = New System.Drawing.Point(12, 24)
        Me.btnTransparency.Name = "btnTransparency"
        Me.btnTransparency.Size = New System.Drawing.Size(124, 37)
        Me.btnTransparency.TabIndex = 0
        Me.btnTransparency.Text = "Transparency"
        Me.btnTransparency.UseVisualStyleBackColor = True
        '
        'btnByRef
        '
        Me.btnByRef.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnByRef.Location = New System.Drawing.Point(12, 67)
        Me.btnByRef.Name = "btnByRef"
        Me.btnByRef.Size = New System.Drawing.Size(124, 37)
        Me.btnByRef.TabIndex = 1
        Me.btnByRef.Text = "ByRef"
        Me.btnByRef.UseVisualStyleBackColor = True
        '
        'btnEvent
        '
        Me.btnEvent.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEvent.Location = New System.Drawing.Point(12, 24)
        Me.btnEvent.Name = "btnEvent"
        Me.btnEvent.Size = New System.Drawing.Size(124, 37)
        Me.btnEvent.TabIndex = 0
        Me.btnEvent.Text = "Event"
        Me.btnEvent.UseVisualStyleBackColor = True
        '
        'btnConstant
        '
        Me.btnConstant.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConstant.Location = New System.Drawing.Point(12, 110)
        Me.btnConstant.Name = "btnConstant"
        Me.btnConstant.Size = New System.Drawing.Size(124, 37)
        Me.btnConstant.TabIndex = 2
        Me.btnConstant.Text = "Constant"
        Me.btnConstant.UseVisualStyleBackColor = True
        '
        'btnAppend
        '
        Me.btnAppend.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAppend.Location = New System.Drawing.Point(12, 153)
        Me.btnAppend.Name = "btnAppend"
        Me.btnAppend.Size = New System.Drawing.Size(124, 37)
        Me.btnAppend.TabIndex = 3
        Me.btnAppend.Text = "Append"
        Me.btnAppend.UseVisualStyleBackColor = True
        '
        'btnOrElse
        '
        Me.btnOrElse.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOrElse.Location = New System.Drawing.Point(12, 24)
        Me.btnOrElse.Name = "btnOrElse"
        Me.btnOrElse.Size = New System.Drawing.Size(124, 37)
        Me.btnOrElse.TabIndex = 0
        Me.btnOrElse.Text = "Or Else"
        Me.btnOrElse.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnTransparency)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(19, 80)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(148, 71)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Week 1"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnEvent)
        Me.GroupBox2.Controls.Add(Me.btnByRef)
        Me.GroupBox2.Controls.Add(Me.btnConstant)
        Me.GroupBox2.Controls.Add(Me.btnAppend)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(173, 80)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(148, 200)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Week 2"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.btnSoftwareSales)
        Me.GroupBox3.Controls.Add(Me.btnRomanNumeral)
        Me.GroupBox3.Controls.Add(Me.btnConditional)
        Me.GroupBox3.Controls.Add(Me.btnFlowchart)
        Me.GroupBox3.Controls.Add(Me.btnErrorLabel)
        Me.GroupBox3.Controls.Add(Me.btnOrElse)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(327, 80)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(148, 288)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Week 3"
        '
        'btnSoftwareSales
        '
        Me.btnSoftwareSales.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSoftwareSales.Location = New System.Drawing.Point(12, 239)
        Me.btnSoftwareSales.Name = "btnSoftwareSales"
        Me.btnSoftwareSales.Size = New System.Drawing.Size(124, 37)
        Me.btnSoftwareSales.TabIndex = 5
        Me.btnSoftwareSales.Text = "Software"
        Me.btnSoftwareSales.UseVisualStyleBackColor = True
        '
        'btnRomanNumeral
        '
        Me.btnRomanNumeral.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRomanNumeral.Location = New System.Drawing.Point(12, 196)
        Me.btnRomanNumeral.Name = "btnRomanNumeral"
        Me.btnRomanNumeral.Size = New System.Drawing.Size(124, 37)
        Me.btnRomanNumeral.TabIndex = 4
        Me.btnRomanNumeral.Text = "Roman"
        Me.btnRomanNumeral.UseVisualStyleBackColor = True
        '
        'btnConditional
        '
        Me.btnConditional.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConditional.Location = New System.Drawing.Point(12, 153)
        Me.btnConditional.Name = "btnConditional"
        Me.btnConditional.Size = New System.Drawing.Size(124, 37)
        Me.btnConditional.TabIndex = 3
        Me.btnConditional.Text = "Conditional"
        Me.btnConditional.UseVisualStyleBackColor = True
        '
        'btnFlowchart
        '
        Me.btnFlowchart.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFlowchart.Location = New System.Drawing.Point(12, 110)
        Me.btnFlowchart.Name = "btnFlowchart"
        Me.btnFlowchart.Size = New System.Drawing.Size(124, 37)
        Me.btnFlowchart.TabIndex = 2
        Me.btnFlowchart.Text = "Flowchart"
        Me.btnFlowchart.UseVisualStyleBackColor = True
        '
        'btnErrorLabel
        '
        Me.btnErrorLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnErrorLabel.Location = New System.Drawing.Point(12, 67)
        Me.btnErrorLabel.Name = "btnErrorLabel"
        Me.btnErrorLabel.Size = New System.Drawing.Size(124, 37)
        Me.btnErrorLabel.TabIndex = 1
        Me.btnErrorLabel.Text = "Error Label"
        Me.btnErrorLabel.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.btnEmployees)
        Me.GroupBox4.Controls.Add(Me.btnSentences)
        Me.GroupBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.Location = New System.Drawing.Point(481, 80)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(148, 120)
        Me.GroupBox4.TabIndex = 3
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Week 4"
        '
        'btnSentences
        '
        Me.btnSentences.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSentences.Location = New System.Drawing.Point(12, 24)
        Me.btnSentences.Name = "btnSentences"
        Me.btnSentences.Size = New System.Drawing.Size(124, 37)
        Me.btnSentences.TabIndex = 0
        Me.btnSentences.Text = "Sentences"
        Me.btnSentences.UseVisualStyleBackColor = True
        '
        'btnEmployees
        '
        Me.btnEmployees.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEmployees.Location = New System.Drawing.Point(12, 67)
        Me.btnEmployees.Name = "btnEmployees"
        Me.btnEmployees.Size = New System.Drawing.Size(124, 37)
        Me.btnEmployees.TabIndex = 1
        Me.btnEmployees.Text = "Employees"
        Me.btnEmployees.UseVisualStyleBackColor = True
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(646, 378)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.lblTitle)
        Me.Name = "MainForm"
        Me.Text = "Sandbox"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents btnTransparency As System.Windows.Forms.Button
    Friend WithEvents btnByRef As System.Windows.Forms.Button
    Friend WithEvents btnEvent As System.Windows.Forms.Button
    Friend WithEvents btnConstant As System.Windows.Forms.Button
    Friend WithEvents btnAppend As System.Windows.Forms.Button
    Friend WithEvents btnOrElse As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents btnErrorLabel As System.Windows.Forms.Button
    Friend WithEvents btnFlowchart As System.Windows.Forms.Button
    Friend WithEvents btnConditional As System.Windows.Forms.Button
    Friend WithEvents btnRomanNumeral As System.Windows.Forms.Button
    Friend WithEvents btnSoftwareSales As System.Windows.Forms.Button
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents btnSentences As System.Windows.Forms.Button
    Friend WithEvents btnEmployees As System.Windows.Forms.Button
End Class
