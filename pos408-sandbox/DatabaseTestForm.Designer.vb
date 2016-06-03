<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DatabaseTestForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DatabaseTestForm))
        Dim Full_NameLabel As System.Windows.Forms.Label
        Me.KudlerCustDBDataSet = New pos408_sandbox.KudlerCustDBDataSet()
        Me.CustInfoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CustInfoTableAdapter = New pos408_sandbox.KudlerCustDBDataSetTableAdapters.CustInfoTableAdapter()
        Me.TableAdapterManager = New pos408_sandbox.KudlerCustDBDataSetTableAdapters.TableAdapterManager()
        Me.CustInfoBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.CustInfoBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.Full_NameTextBox = New System.Windows.Forms.TextBox()
        Full_NameLabel = New System.Windows.Forms.Label()
        CType(Me.KudlerCustDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustInfoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustInfoBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.CustInfoBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'KudlerCustDBDataSet
        '
        Me.KudlerCustDBDataSet.DataSetName = "KudlerCustDBDataSet"
        Me.KudlerCustDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CustInfoBindingSource
        '
        Me.CustInfoBindingSource.DataMember = "CustInfo"
        Me.CustInfoBindingSource.DataSource = Me.KudlerCustDBDataSet
        '
        'CustInfoTableAdapter
        '
        Me.CustInfoTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CustInfoTableAdapter = Me.CustInfoTableAdapter
        Me.TableAdapterManager.UpdateOrder = pos408_sandbox.KudlerCustDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'CustInfoBindingNavigator
        '
        Me.CustInfoBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.CustInfoBindingNavigator.BindingSource = Me.CustInfoBindingSource
        Me.CustInfoBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.CustInfoBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.CustInfoBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.CustInfoBindingNavigatorSaveItem})
        Me.CustInfoBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.CustInfoBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.CustInfoBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.CustInfoBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.CustInfoBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.CustInfoBindingNavigator.Name = "CustInfoBindingNavigator"
        Me.CustInfoBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.CustInfoBindingNavigator.Size = New System.Drawing.Size(508, 25)
        Me.CustInfoBindingNavigator.TabIndex = 0
        Me.CustInfoBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 15)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 6)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 6)
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'CustInfoBindingNavigatorSaveItem
        '
        Me.CustInfoBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.CustInfoBindingNavigatorSaveItem.Image = CType(resources.GetObject("CustInfoBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.CustInfoBindingNavigatorSaveItem.Name = "CustInfoBindingNavigatorSaveItem"
        Me.CustInfoBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 23)
        Me.CustInfoBindingNavigatorSaveItem.Text = "Save Data"
        '
        'Full_NameLabel
        '
        Full_NameLabel.AutoSize = True
        Full_NameLabel.Location = New System.Drawing.Point(287, 97)
        Full_NameLabel.Name = "Full_NameLabel"
        Full_NameLabel.Size = New System.Drawing.Size(57, 13)
        Full_NameLabel.TabIndex = 1
        Full_NameLabel.Text = "Full Name:"
        '
        'Full_NameTextBox
        '
        Me.Full_NameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustInfoBindingSource, "Full Name", True))
        Me.Full_NameTextBox.Location = New System.Drawing.Point(350, 94)
        Me.Full_NameTextBox.Name = "Full_NameTextBox"
        Me.Full_NameTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Full_NameTextBox.TabIndex = 2
        '
        'DatabaseTestForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(508, 418)
        Me.Controls.Add(Full_NameLabel)
        Me.Controls.Add(Me.Full_NameTextBox)
        Me.Controls.Add(Me.CustInfoBindingNavigator)
        Me.Name = "DatabaseTestForm"
        Me.Text = "DatabaseTestForm"
        CType(Me.KudlerCustDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustInfoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustInfoBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.CustInfoBindingNavigator.ResumeLayout(False)
        Me.CustInfoBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents KudlerCustDBDataSet As pos408_sandbox.KudlerCustDBDataSet
    Friend WithEvents CustInfoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CustInfoTableAdapter As pos408_sandbox.KudlerCustDBDataSetTableAdapters.CustInfoTableAdapter
    Friend WithEvents TableAdapterManager As pos408_sandbox.KudlerCustDBDataSetTableAdapters.TableAdapterManager
    Friend WithEvents CustInfoBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents CustInfoBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents Full_NameTextBox As System.Windows.Forms.TextBox
End Class
