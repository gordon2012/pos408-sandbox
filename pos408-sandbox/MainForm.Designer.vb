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
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(12, 9)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(195, 37)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "VB Sandbox"
        '
        'btnTransparency
        '
        Me.btnTransparency.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTransparency.Location = New System.Drawing.Point(19, 80)
        Me.btnTransparency.Name = "btnTransparency"
        Me.btnTransparency.Size = New System.Drawing.Size(124, 37)
        Me.btnTransparency.TabIndex = 1
        Me.btnTransparency.Text = "Transparency"
        Me.btnTransparency.UseVisualStyleBackColor = True
        '
        'btnByRef
        '
        Me.btnByRef.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnByRef.Location = New System.Drawing.Point(19, 166)
        Me.btnByRef.Name = "btnByRef"
        Me.btnByRef.Size = New System.Drawing.Size(124, 37)
        Me.btnByRef.TabIndex = 3
        Me.btnByRef.Text = "ByRef"
        Me.btnByRef.UseVisualStyleBackColor = True
        '
        'btnEvent
        '
        Me.btnEvent.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEvent.Location = New System.Drawing.Point(19, 123)
        Me.btnEvent.Name = "btnEvent"
        Me.btnEvent.Size = New System.Drawing.Size(124, 37)
        Me.btnEvent.TabIndex = 4
        Me.btnEvent.Text = "Event"
        Me.btnEvent.UseVisualStyleBackColor = True
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(382, 327)
        Me.Controls.Add(Me.btnEvent)
        Me.Controls.Add(Me.btnByRef)
        Me.Controls.Add(Me.btnTransparency)
        Me.Controls.Add(Me.lblTitle)
        Me.Name = "MainForm"
        Me.Text = "Sandbox"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents btnTransparency As System.Windows.Forms.Button
    Friend WithEvents btnByRef As System.Windows.Forms.Button
    Friend WithEvents btnEvent As System.Windows.Forms.Button
End Class
