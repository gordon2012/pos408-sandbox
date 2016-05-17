<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AppendForm
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
        Me.btnError = New System.Windows.Forms.Button()
        Me.lblLog = New System.Windows.Forms.Label()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnText = New System.Windows.Forms.Button()
        Me.txtLog = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btnError
        '
        Me.btnError.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnError.Location = New System.Drawing.Point(31, 22)
        Me.btnError.Name = "btnError"
        Me.btnError.Size = New System.Drawing.Size(124, 37)
        Me.btnError.TabIndex = 7
        Me.btnError.Text = "Error"
        Me.btnError.UseVisualStyleBackColor = True
        '
        'lblLog
        '
        Me.lblLog.AutoSize = True
        Me.lblLog.BackColor = System.Drawing.Color.Black
        Me.lblLog.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLog.ForeColor = System.Drawing.Color.Red
        Me.lblLog.Location = New System.Drawing.Point(27, 80)
        Me.lblLog.Name = "lblLog"
        Me.lblLog.Size = New System.Drawing.Size(0, 20)
        Me.lblLog.TabIndex = 8
        '
        'btnClear
        '
        Me.btnClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(161, 22)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(124, 37)
        Me.btnClear.TabIndex = 9
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnText
        '
        Me.btnText.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnText.Location = New System.Drawing.Point(291, 22)
        Me.btnText.Name = "btnText"
        Me.btnText.Size = New System.Drawing.Size(124, 37)
        Me.btnText.TabIndex = 10
        Me.btnText.Text = "Error"
        Me.btnText.UseVisualStyleBackColor = True
        '
        'txtLog
        '
        Me.txtLog.Location = New System.Drawing.Point(291, 82)
        Me.txtLog.Multiline = True
        Me.txtLog.Name = "txtLog"
        Me.txtLog.ReadOnly = True
        Me.txtLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtLog.Size = New System.Drawing.Size(184, 134)
        Me.txtLog.TabIndex = 11
        '
        'AppendForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(540, 293)
        Me.Controls.Add(Me.txtLog)
        Me.Controls.Add(Me.btnText)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.lblLog)
        Me.Controls.Add(Me.btnError)
        Me.Name = "AppendForm"
        Me.Text = "AppendForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnError As System.Windows.Forms.Button
    Friend WithEvents lblLog As System.Windows.Forms.Label
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnText As System.Windows.Forms.Button
    Friend WithEvents txtLog As System.Windows.Forms.TextBox
End Class
