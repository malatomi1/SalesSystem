Public Class SearchItems

    Private Sub SearchItems_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        puFillDataGridView(DataGridView1, "select * from items order by itemname")

    End Sub

    Private Sub DataGridView1_RowsAdded(sender As Object, e As System.Windows.Forms.DataGridViewRowsAddedEventArgs) Handles DataGridView1.RowsAdded
        For I = 0 To DataGridView1.Rows.Count - 1
            DataGridView1.Rows(I).Cells(0).Value = "التفاصيل"
            Dim row As DataGridViewRow = DataGridView1.Rows(I)
            row.Height = 23

        Next
    End Sub

    Private Sub txtsearch_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtsearch.TextChanged
        Dim sql As String = ""
        If txtsearch.Text.Length = 0 Then
            Sql = "select * from Items order by itemname"
            Select Case cbosearch.SelectedIndex
                Case 0
                    puFillDataGridView(DataGridView1, "select * from Items where status='true'order by itemname")
                Case 1
                    puFillDataGridView(DataGridView1, "select * from Items where status='false'order by itemname")
            End Select
        End If

    End Sub

    
End Class