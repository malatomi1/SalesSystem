
Imports System.Data.SqlClient

Public Class SearchCustomers
    Private Sub DataGridView1_Click(sender As Object, e As System.EventArgs) Handles DataGridView1.Click
        Frmcustomers.show_record_data(DataGridView1.CurrentRow.Cells(1).Value)
        Me.Dispose()
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
            sql = "select * from Customers order by CustomerName"
        Else
            Select Case cbosearch.SelectedIndex
                Case 0
                    ' البحث حسب رمز العميل
                    sql = "select * from Customers where CustomerCode like N'" & txtsearch.Text.Trim & "%" & "'" & " order by CustomerCode"
                Case 1
                    'البحث حسب اسم العميل
                    sql = "select * from Customers where CustomerName like N'" & txtsearch.Text.Trim & "%" & "'" & " order by CustomerName"
                Case 2
                    'البحث حسب رقم الهاتف  
                    sql = "select * from Customers where Mobile like N'" & txtsearch.Text.Trim & "%" & "'" & " order by Mobile"

            End Select
            'If cbosearch.SelectedText = 0 Then جملة البحث الاولى
            '    sql = "select * from Customers where CustomerCode like N'" & txtsearch.Text.Trim & "%" & "'" & " order by CustomerCode"
            'ElseIf cbosearch.SelectedText = 1 Then
            '    sql = "select * from Customers where CustomerName like N'" & txtsearch.Text.Trim & "%" & "'" & " order by CustomerName"
            'ElseIf cbosearch.SelectedText = 2 Then
            '    sql = "select * from Customers where Mobile like N'" & txtsearch.Text.Trim & "%" & "'" & " order by Mobile"
            'End If
        End If
        showGrid(sql)
    End Sub
    Sub showGrid(sql)

        Dim adp As New SqlClient.SqlDataAdapter(Sql, SQlconn)
        Dim ds As New DataSet
        adp.Fill(ds)
        Dim dt = ds.Tables(0)
        '=========================================================================================
        DataGridView1.AutoGenerateColumns = False
        DataGridView1.DataSource = dt.DefaultView
        '==========================================================================================

    End Sub


    Private Sub SearchCustomers_Load(sender As Object, e As System.EventArgs) Handles MyBase.Load
        showGrid("select * from Customers order by CustomerName")

    End Sub

End Class