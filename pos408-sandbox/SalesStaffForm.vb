Public Class SalesStaffForm
    Private Sub SalesStaffForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'CompanyDataSet.SalesStaff' table. You can move, or remove it, as needed.
        Me.SalesStaffTableAdapter.Fill(Me.CompanyDataSet.SalesStaff)

        ' ********
        ' Mead(2013)
        '
        'Dim dt As DataTable = CompanyDataSet.SalesStaff
        'cmbSalesStaff.DataSource = dt
        cmbSalesStaff.DrawMode = DrawMode.OwnerDrawFixed
        ' 
        ' ********
    End Sub

    Private Sub cmbSalesStaff_DrawItem(sender As Object, e As DrawItemEventArgs) Handles cmbSalesStaff.DrawItem
        ' ********
        ' Mead(2013)
        '
        e.DrawBackground()

        Dim drv As DataRowView = CType(cmbSalesStaff.Items(e.Index), DataRowView)

        Dim lastName As String = drv("Last_Name").ToString()
        Dim firstName As String = drv("First_Name").ToString()

        Using sb As SolidBrush = New SolidBrush(e.ForeColor)
            e.Graphics.DrawString(lastName + ", " + firstName, e.Font, sb, e.Bounds)
        End Using
        '
        ' ********
    End Sub
End Class

' Code References

' Mead, G. (2013). How to Display Multiple Columns from an Existing Database in
'   a Combo Box Dropdown List. Retrieved June 2016, from vbcity: The .NET
'   Developer Community: http://vbcity.com/blogs/xtab/archive/2013/10/01/how-
'   to-display-multiple-columns-from-an-existing-database-in-a-combo-box-
'   dropdown-list.aspx
