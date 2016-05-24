<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RomanNumeralForm
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
        Me.lblNumeral = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtInput = New System.Windows.Forms.TextBox()
        Me.btnConvert = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblValidation = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(32, 41)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(141, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Enter integer between 1 - 10"
        '
        'lblNumeral
        '
        Me.lblNumeral.AutoSize = True
        Me.lblNumeral.Location = New System.Drawing.Point(191, 156)
        Me.lblNumeral.Name = "lblNumeral"
        Me.lblNumeral.Size = New System.Drawing.Size(19, 13)
        Me.lblNumeral.TabIndex = 1
        Me.lblNumeral.Text = "...."
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(87, 156)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(86, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Roman Numeral:"
        '
        'txtInput
        '
        Me.txtInput.Location = New System.Drawing.Point(194, 38)
        Me.txtInput.Name = "txtInput"
        Me.txtInput.Size = New System.Drawing.Size(138, 20)
        Me.txtInput.TabIndex = 4
        '
        'btnConvert
        '
        Me.btnConvert.Location = New System.Drawing.Point(35, 84)
        Me.btnConvert.Name = "btnConvert"
        Me.btnConvert.Size = New System.Drawing.Size(138, 41)
        Me.btnConvert.TabIndex = 5
        Me.btnConvert.Text = "Convert"
        Me.btnConvert.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(194, 84)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(138, 41)
        Me.btnExit.TabIndex = 6
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lblValidation
        '
        Me.lblValidation.AutoSize = True
        Me.lblValidation.ForeColor = System.Drawing.Color.Red
        Me.lblValidation.Location = New System.Drawing.Point(351, 41)
        Me.lblValidation.Name = "lblValidation"
        Me.lblValidation.Size = New System.Drawing.Size(19, 13)
        Me.lblValidation.TabIndex = 7
        Me.lblValidation.Text = "!!!!"
        '
        'RomanNumeralForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(557, 216)
        Me.Controls.Add(Me.lblValidation)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnConvert)
        Me.Controls.Add(Me.txtInput)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lblNumeral)
        Me.Controls.Add(Me.Label1)
        Me.Name = "RomanNumeralForm"
        Me.Text = "RomanNumeralForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblNumeral As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtInput As System.Windows.Forms.TextBox
    Friend WithEvents btnConvert As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents lblValidation As System.Windows.Forms.Label
End Class
