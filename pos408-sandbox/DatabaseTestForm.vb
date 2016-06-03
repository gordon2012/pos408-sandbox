Public Class DatabaseTestForm

   
    Private Sub CustInfoBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles CustInfoBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.CustInfoBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.KudlerCustDBDataSet)

    End Sub

    Private Sub DatabaseTestForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'KudlerCustDBDataSet.CustInfo' table. You can move, or remove it, as needed.
        Me.CustInfoTableAdapter.Fill(Me.KudlerCustDBDataSet.CustInfo)

    End Sub
End Class