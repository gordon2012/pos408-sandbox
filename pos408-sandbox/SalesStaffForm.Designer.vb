<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SalesStaffForm
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
        Dim IDLabel As System.Windows.Forms.Label
        Dim Full_TimeLabel As System.Windows.Forms.Label
        Dim Hire_DateLabel As System.Windows.Forms.Label
        Dim SalaryLabel As System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.SalaryTextBox = New System.Windows.Forms.TextBox()
        Me.SalesStaffBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CompanyDataSet = New pos408_sandbox.CompanyDataSet()
        Me.Hire_DateDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Full_TimeCheckBox = New System.Windows.Forms.CheckBox()
        Me.IDTextBox = New System.Windows.Forms.TextBox()
        Me.SalesStaffTableAdapter = New pos408_sandbox.CompanyDataSetTableAdapters.SalesStaffTableAdapter()
        Me.TableAdapterManager = New pos408_sandbox.CompanyDataSetTableAdapters.TableAdapterManager()
        Me.cmbSalesStaff = New System.Windows.Forms.ComboBox()
        IDLabel = New System.Windows.Forms.Label()
        Full_TimeLabel = New System.Windows.Forms.Label()
        Hire_DateLabel = New System.Windows.Forms.Label()
        SalaryLabel = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.SalesStaffBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CompanyDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'IDLabel
        '
        IDLabel.AutoSize = True
        IDLabel.Location = New System.Drawing.Point(54, 35)
        IDLabel.Name = "IDLabel"
        IDLabel.Size = New System.Drawing.Size(21, 13)
        IDLabel.TabIndex = 0
        IDLabel.Text = "ID:"
        '
        'Full_TimeLabel
        '
        Full_TimeLabel.AutoSize = True
        Full_TimeLabel.Location = New System.Drawing.Point(23, 63)
        Full_TimeLabel.Name = "Full_TimeLabel"
        Full_TimeLabel.Size = New System.Drawing.Size(52, 13)
        Full_TimeLabel.TabIndex = 2
        Full_TimeLabel.Text = "Full Time:"
        '
        'Hire_DateLabel
        '
        Hire_DateLabel.AutoSize = True
        Hire_DateLabel.Location = New System.Drawing.Point(20, 92)
        Hire_DateLabel.Name = "Hire_DateLabel"
        Hire_DateLabel.Size = New System.Drawing.Size(55, 13)
        Hire_DateLabel.TabIndex = 4
        Hire_DateLabel.Text = "Hire Date:"
        '
        'SalaryLabel
        '
        SalaryLabel.AutoSize = True
        SalaryLabel.Location = New System.Drawing.Point(36, 117)
        SalaryLabel.Name = "SalaryLabel"
        SalaryLabel.Size = New System.Drawing.Size(39, 13)
        SalaryLabel.TabIndex = 6
        SalaryLabel.Text = "Salary:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Select a Name:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(SalaryLabel)
        Me.GroupBox1.Controls.Add(Me.SalaryTextBox)
        Me.GroupBox1.Controls.Add(Hire_DateLabel)
        Me.GroupBox1.Controls.Add(Me.Hire_DateDateTimePicker)
        Me.GroupBox1.Controls.Add(Full_TimeLabel)
        Me.GroupBox1.Controls.Add(Me.Full_TimeCheckBox)
        Me.GroupBox1.Controls.Add(IDLabel)
        Me.GroupBox1.Controls.Add(Me.IDTextBox)
        Me.GroupBox1.Location = New System.Drawing.Point(202, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(211, 159)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Sales Staff Information"
        '
        'SalaryTextBox
        '
        Me.SalaryTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SalesStaffBindingSource, "Salary", True))
        Me.SalaryTextBox.Location = New System.Drawing.Point(81, 114)
        Me.SalaryTextBox.Name = "SalaryTextBox"
        Me.SalaryTextBox.ReadOnly = True
        Me.SalaryTextBox.Size = New System.Drawing.Size(100, 20)
        Me.SalaryTextBox.TabIndex = 7
        '
        'SalesStaffBindingSource
        '
        Me.SalesStaffBindingSource.DataMember = "SalesStaff"
        Me.SalesStaffBindingSource.DataSource = Me.CompanyDataSet
        '
        'CompanyDataSet
        '
        Me.CompanyDataSet.DataSetName = "CompanyDataSet"
        Me.CompanyDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Hire_DateDateTimePicker
        '
        Me.Hire_DateDateTimePicker.CustomFormat = "MM/dd/yyyy"
        Me.Hire_DateDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.SalesStaffBindingSource, "Hire_Date", True))
        Me.Hire_DateDateTimePicker.Enabled = False
        Me.Hire_DateDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.Hire_DateDateTimePicker.Location = New System.Drawing.Point(81, 88)
        Me.Hire_DateDateTimePicker.Name = "Hire_DateDateTimePicker"
        Me.Hire_DateDateTimePicker.Size = New System.Drawing.Size(100, 20)
        Me.Hire_DateDateTimePicker.TabIndex = 5
        '
        'Full_TimeCheckBox
        '
        Me.Full_TimeCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.SalesStaffBindingSource, "Full_Time", True))
        Me.Full_TimeCheckBox.Enabled = False
        Me.Full_TimeCheckBox.Location = New System.Drawing.Point(81, 58)
        Me.Full_TimeCheckBox.Name = "Full_TimeCheckBox"
        Me.Full_TimeCheckBox.Size = New System.Drawing.Size(104, 24)
        Me.Full_TimeCheckBox.TabIndex = 3
        Me.Full_TimeCheckBox.UseVisualStyleBackColor = True
        '
        'IDTextBox
        '
        Me.IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SalesStaffBindingSource, "ID", True))
        Me.IDTextBox.Location = New System.Drawing.Point(81, 32)
        Me.IDTextBox.Name = "IDTextBox"
        Me.IDTextBox.ReadOnly = True
        Me.IDTextBox.Size = New System.Drawing.Size(100, 20)
        Me.IDTextBox.TabIndex = 1
        '
        'SalesStaffTableAdapter
        '
        Me.SalesStaffTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.SalesStaffTableAdapter = Me.SalesStaffTableAdapter
        Me.TableAdapterManager.UpdateOrder = pos408_sandbox.CompanyDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'cmbSalesStaff
        '
        Me.cmbSalesStaff.DataSource = Me.SalesStaffBindingSource
        Me.cmbSalesStaff.DisplayMember = "Full_Name"
        Me.cmbSalesStaff.FormattingEnabled = True
        Me.cmbSalesStaff.Location = New System.Drawing.Point(12, 44)
        Me.cmbSalesStaff.Name = "cmbSalesStaff"
        Me.cmbSalesStaff.Size = New System.Drawing.Size(175, 21)
        Me.cmbSalesStaff.TabIndex = 3
        Me.cmbSalesStaff.ValueMember = "ID"
        '
        'SalesStaffForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(437, 194)
        Me.Controls.Add(Me.cmbSalesStaff)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "SalesStaffForm"
        Me.Text = "Selecting Sales Staff"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.SalesStaffBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CompanyDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents CompanyDataSet As pos408_sandbox.CompanyDataSet
    Friend WithEvents SalesStaffBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SalesStaffTableAdapter As pos408_sandbox.CompanyDataSetTableAdapters.SalesStaffTableAdapter
    Friend WithEvents TableAdapterManager As pos408_sandbox.CompanyDataSetTableAdapters.TableAdapterManager
    Friend WithEvents IDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents cmbSalesStaff As System.Windows.Forms.ComboBox
    Friend WithEvents SalaryTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Hire_DateDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents Full_TimeCheckBox As System.Windows.Forms.CheckBox
End Class
