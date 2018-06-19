Public Class SearchSuppliers
    Private Sub SearchSuppliers_Click(sender As Object, e As System.EventArgs) Handles DataGridView1.Click
        FrmSupliers.show_record_data(DataGridView1.CurrentRow.Cells(1).Value)
        Me.Dispose()
    End Sub
    Private Sub SearchSuppliers_Load(sender As Object, e As System.EventArgs) Handles MyBase.Load
        txtsearch.Text = ""
        cbosearch.SelectedIndex = -1


    End Sub

    Private Sub txtsearch_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtsearch.TextChanged
        Dim sql As String = ""
        If txtsearch.Text.Length = 0 Then
            sql = "select * from Suppliers order by SupName"
        Else
            Select Case cbosearch.SelectedIndex
                Case 0
                    ' البحث حسب رمز المورد
                    sql = "select * from Suppliers where SupCode like N'" & txtsearch.Text.Trim & "%" & "'" & " order by SupCode"
                Case 1
                    'البحث حسب اسم المورد
                    sql = "select * from Suppliers where SupName like N'" & txtsearch.Text.Trim & "%" & "'" & " order by SupName"
                Case 2
                    'البحث حسب رقم الهاتف  
                    sql = "select * from Suppliers where Mobile like N'" & txtsearch.Text.Trim & "%" & "'" & " order by Mobile"

            End Select
        End If
        showGrid(sql)
    End Sub
    Sub showGrid(sql)

        Dim adp As New SqlClient.SqlDataAdapter(sql, SQlconn)
        Dim ds As New DataSet
        adp.Fill(ds)
        Dim dt = ds.Tables(0)
        '=========================================================================================
        DataGridView1.AutoGenerateColumns = False
        DataGridView1.DataSource = dt.DefaultView
        '==========================================================================================

    End Sub



    Private Sub SearchCustomers_Load(sender As Object, e As System.EventArgs) Handles MyBase.Load
        showGrid("select * from Suppliers order by SupName")

    End Sub



    'Private Sub DataGridView1_Click(sender As Object, e As System.EventArgs) Handles DataGridView1.Click
    '    FrmSupliers.show_record_data(DataGridView1.CurrentRow.Cells(1).Value)
    'End Sub

    Private Sub DataGridView1_RowsAdded(sender As Object, e As System.Windows.Forms.DataGridViewRowsAddedEventArgs) Handles DataGridView1.RowsAdded
        For I = 0 To DataGridView1.Rows.Count - 1
            DataGridView1.Rows(I).Cells(0).Value = "التفاصيل"
            Dim row As DataGridViewRow = DataGridView1.Rows(I)
            row.Height = 23

        Next
    End Sub


   
    
End Class