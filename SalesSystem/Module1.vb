Imports System.Data.SqlClient
Module Module1

    Public SQlconn As New SqlClient.SqlConnection
    Public frmOp As Integer = 0
    Public Sub puFillDataGridView(MyDataGridView As DataGridView, sqlstr As String)
        MyDataGridView.DataSource = Nothing
        Dim ADP = New SqlClient.SqlDataAdapter(sqlstr, SQlconn)
        Dim ds = New DataSet
        ADP.Fill(ds)
        Dim dt = ds.Tables(0)
        '===========================================
        MyDataGridView.AutoGenerateColumns = False
        MyDataGridView.DataSource = dt.DefaultView
        MyDataGridView.ColumnHeadersDefaultCellStyle.Font = New Font("Tahoma", 9, FontStyle.Regular, GraphicsUnit.Point)
        MyDataGridView.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.[Single]
        MyDataGridView.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        MyDataGridView.DefaultCellStyle.Font = New Font("Tahoma", 8, FontStyle.Regular, GraphicsUnit.Point)

    End Sub
    Public Sub OPENCONNECTION()
        If SQlconn.State = 1 Then SQlconn.Close()
        Try
            SQlconn.ConnectionString = "server=SABER-PC\SQLEXPRESS;database=SaleSystem;integrated security=True"
            SQlconn.Open()

        Catch ex As Exception
            MessageBox.Show(ex.Message, "فشل في عملية الإتصال", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign)
            SQlconn.Close()

        End Try

    End Sub

    Function GET_LAST_RECORD(TableName, OrderbyField) As Integer
        GET_LAST_RECORD = 0
        Dim STR = "select * from " & TableName & " Order by " & OrderbyField
        Dim Adp = New SqlClient.SqlDataAdapter(STR, SQlconn)
        Dim Ds = New DataSet
        Adp.Fill(Ds)
        Dim DT As DataTable
        DT = Ds.Tables(0)
        If DT.Rows.Count <> 0 Then
            Dim i = DT.Rows.Count - 1
            GET_LAST_RECORD = Val(DT.Rows(i).Item(0))

        End If

    End Function


End Module
