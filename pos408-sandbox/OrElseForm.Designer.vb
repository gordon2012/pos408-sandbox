<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class OrElseForm
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
        Me.txtLeft = New System.Windows.Forms.TextBox()
        Me.txtRight = New System.Windows.Forms.TextBox()
        Me.lblLabel = New System.Windows.Forms.Label()
        Me.btnOr = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblAction = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnOrElse = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtLeft
        '
        Me.txtLeft.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLeft.Location = New System.Drawing.Point(12, 12)
        Me.txtLeft.Name = "txtLeft"
        Me.txtLeft.Size = New System.Drawing.Size(120, 26)
        Me.txtLeft.TabIndex = 0
        '
        'txtRight
        '
        Me.txtRight.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRight.Location = New System.Drawing.Point(138, 12)
        Me.txtRight.Name = "txtRight"
        Me.txtRight.Size = New System.Drawing.Size(120, 26)
        Me.txtRight.TabIndex = 1
        '
        'lblLabel
        '
        Me.lblLabel.AutoSize = True
        Me.lblLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLabel.Location = New System.Drawing.Point(6, 30)
        Me.lblLabel.Name = "lblLabel"
        Me.lblLabel.Size = New System.Drawing.Size(82, 20)
        Me.lblLabel.TabIndex = 2
        Me.lblLabel.Text = "Label Text"
        '
        'btnOr
        '
        Me.btnOr.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOr.Location = New System.Drawing.Point(12, 44)
        Me.btnOr.Name = "btnOr"
        Me.btnOr.Size = New System.Drawing.Size(120, 37)
        Me.btnOr.TabIndex = 3
        Me.btnOr.Text = "Or"
        Me.btnOr.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblAction)
        Me.GroupBox1.Location = New System.Drawing.Point(138, 87)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(120, 160)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        '
        'lblAction
        '
        Me.lblAction.AutoSize = True
        Me.lblAction.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAction.Location = New System.Drawing.Point(6, 30)
        Me.lblAction.Name = "lblAction"
        Me.lblAction.Size = New System.Drawing.Size(82, 20)
        Me.lblAction.TabIndex = 3
        Me.lblAction.Text = "Label Text"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lblLabel)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 87)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(120, 160)
        Me.GroupBox2.TabIndex = 5
        Me.GroupBox2.TabStop = False
        '
        'btnOrElse
        '
        Me.btnOrElse.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOrElse.Location = New System.Drawing.Point(138, 44)
        Me.btnOrElse.Name = "btnOrElse"
        Me.btnOrElse.Size = New System.Drawing.Size(120, 37)
        Me.btnOrElse.TabIndex = 6
        Me.btnOrElse.Text = "OrElse"
        Me.btnOrElse.UseVisualStyleBackColor = True
        '
        'OrElseForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(271, 254)
        Me.Controls.Add(Me.btnOrElse)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnOr)
        Me.Controls.Add(Me.txtRight)
        Me.Controls.Add(Me.txtLeft)
        Me.Name = "OrElseForm"
        Me.Text = "Or Else"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtLeft As System.Windows.Forms.TextBox
    Friend WithEvents txtRight As System.Windows.Forms.TextBox
    Friend WithEvents lblLabel As System.Windows.Forms.Label
    Friend WithEvents btnOr As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lblAction As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents btnOrElse As System.Windows.Forms.Button
End Class
