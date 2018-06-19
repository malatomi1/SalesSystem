Public Class FrmCategorization

    Private Sub btncatnew_Click(sender As System.Object, e As System.EventArgs) Handles btncatnew.Click
        ' ================================= كود التنظيف
        GroupBox2.Visible = False
        GroupBox1.Visible = True
        GroupBox1.BringToFront()
        btncatedit.Enabled = False
        btncatdelet.Enabled = False
        btncatsav.Enabled = True
        CatName.Text = ""
        Note.Text = ""
        CatCode.Text = Format(GET_LAST_RECORD("Catogories", "CatAutoNumber") + 1, "CTS000000") 'تعبئة الحلق رمز الصنف تلقائيا

    End Sub
    Private Sub btncatsav_Click(sender As System.Object, e As System.EventArgs) Handles btncatsav.Click
        If CatName.Text.Trim = "" Then
            MsgBox("يرجى ادخال اسم التصنيف", MsgBoxStyle.Exclamation, "خطأ")
            CatName.Focus()
        Else
            Dim Adp = New SqlClient.SqlDataAdapter("select * from Catogories where CatName=N'" & CatName.Text & "'", SQlconn)
            Dim Ds = New DataSet
            Adp.Fill(Ds)
            Dim DT = Ds.Tables(0)
            If DT.Rows.Count > 0 Then
                MsgBox("  :اسم التصنيف المدخل موجود تحت رقم" & DT.Rows(0).Item("CatCode"), MsgBoxStyle.Information, "رسالة تنبية")
            Else
                Dim dr = DT.NewRow
                dr!CatCode = CatCode.Text
                dr!CatName = CatName.Text
                dr!Note = Note.Text
                DT.Rows.Add(dr)
                Dim cmd As New SqlClient.SqlCommandBuilder(Adp)
                Adp.Update(DT)
                btncatnew_Click(sender, e)
                MsgBox("تم حفظ بيانات التصنيف بنجاح", MsgBoxStyle.Information, "رسالة تأكيد")
            End If
        End If
    End Sub
    Private Sub btncatedit_Click(sender As System.Object, e As System.EventArgs) Handles btncatedit.Click
        If CatName.Text.Trim = "" Then
            MsgBox("يرجى ادخال اسم التصنيف", MsgBoxStyle.Exclamation, "خطأ")
            CatName.Focus()
            Exit Sub
        End If
        '===================================================================================================
        If MsgBox("سوف يتم حفظ هذه التعديلات ، هل تريد الإستمرار؟", MsgBoxStyle.Question + MsgBoxStyle.YesNo + MsgBoxStyle.DefaultButton2, "رسالة") = MsgBoxResult.No Then Exit Sub

        Dim STR = "select * from Catogories where CatCode=N'" & (CatCode.Text) & "'"
        Dim adp As New SqlClient.SqlDataAdapter(STR, SQlconn)
        Dim Ds = New DataSet
        adp.Fill(Ds)
        Dim DT As DataTable
        DT = Ds.Tables(0)
        If DT.Rows.Count = 0 Then
            MsgBox("لم يتم العثور على البيانات يرجى التأكد من الرمز", MsgBoxStyle.Exclamation, "رسالة تنبية")
        Else
            Dim dr = DT.Rows(0)
            dr!CatName = CatName.Text
            dr!Note = Note.Text
            Dim cmd As New SqlClient.SqlCommandBuilder(adp)
            adp.Update(DT)
            btncatnew_Click(sender, e)
            MsgBox("تم تعديل بيانات التصنيف بنجاح", MsgBoxStyle.Information, "رسالة تأكيد")
        End If

    End Sub
    Private Sub btncatdelet_Click(sender As System.Object, e As System.EventArgs) Handles btncatdelet.Click
        If CatName.Text.Trim = "" Then
            MsgBox("يرجى ادخال اسم التصنيف", MsgBoxStyle.Exclamation, "خطأ")
            CatName.Focus()
            Exit Sub
        End If
        If MsgBox("سوف يتم حذف هذه البيانات ، هل تريد الإستمرار؟", MsgBoxStyle.Question + MsgBoxStyle.YesNo + MsgBoxStyle.DefaultButton2, "رسالة") = MsgBoxResult.No Then Exit Sub

        Dim STR = "select * from Catogories where CatCode=N'" & (CatCode.Text) & "'"
        Dim adp As New SqlClient.SqlDataAdapter(STR, SQlconn)
        Dim Ds = New DataSet
        adp.Fill(Ds)
        Dim DT As DataTable
        DT = Ds.Tables(0)
        If DT.Rows.Count = 0 Then
            MsgBox("لم يتم العثور على البيانات يرجى التأكد من الرمز", MsgBoxStyle.Exclamation, "رسالة تنبية")
        Else
            Dim dr = DT.Rows(0)
            dr.Delete()
            Dim cmd As New SqlClient.SqlCommandBuilder(adp)
            adp.Update(DT)
            btncatnew_Click(sender, e)
            MsgBox("تم حذف بيانات التصنيف بنجاح", MsgBoxStyle.Information, "رسالة تأكيد")
        End If
    End Sub

    Private Sub FrmCategorization_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        showGrid("select * from Catogories order by CatName")
        btncatnew_Click(Nothing, Nothing)
    End Sub

    Private Sub btncatsearch_Click(sender As System.Object, e As System.EventArgs) Handles btncatsearch.Click


        GroupBox2.Visible = True
        GroupBox1.Visible = False
        GroupBox2.BringToFront()

    End Sub

    
    Private Sub Button1_Click_1(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        GroupBox2.Visible = False
        GroupBox1.Visible = True
        GroupBox1.BringToFront()
    End Sub
    Private Sub DataGridView1_Click(sender As Object, e As System.EventArgs) Handles DataGridView1.Click
        If DataGridView1.Rows.Count = 0 Then Exit Sub ' اذاكانت فاضي اطلع من الاجراء 
        ' اذا فيها 
        'With DataGridView1.CurrentRow ' مع السجل الحالي
        '    CatCode.Text = .Cells(1).Value
        '    CatName.Text = .Cells(2).Value طريقة اولى وتحتها طريقة ثانية
        '    Note.Text = .Cells(3).Value
        'End With
        CatCode.Text = DataGridView1.CurrentRow.Cells(1).Value
        CatName.Text = DataGridView1.CurrentRow.Cells(2).Value
        Note.Text = DataGridView1.CurrentRow.Cells(3).Value
        btncatsav.Enabled = False
        btncatedit.Enabled = True
        btncatdelet.Enabled = True
        CatName.Focus()
        GroupBox2.Visible = False
        GroupBox1.Visible = True
        GroupBox1.BringToFront()


    End Sub

    Private Sub Txtsearch_TextChanged(sender As System.Object, e As System.EventArgs) Handles Txtsearch.TextChanged
        Dim sql As String = "" ' متغير لاستخدامه في عملية الاستعلام فيما بعد
        If Txtsearch.Text.Length = 0 Then
            sql = "select * from Catogories order by CatName"
        Else
            sql = "select * from Catogories where CatName like N'" & Txtsearch.Text.Trim & "%" & "'" & " order by CatName"

        End If
        
        showGrid(sql)

    End Sub
    Sub showGrid(sql)
        Dim adp As New SqlClient.SqlDataAdapter(sql, SQlconn) ' اجراء عرض كامل السجلات 
        Dim ds As New DataSet
        adp.Fill(ds)
        Dim dt = ds.Tables(0)
        '========================================= تعبئة الداتا جرد بالبيانات 
        DataGridView1.AutoGenerateColumns = False
        DataGridView1.DataSource = dt.DefaultView

    End Sub

    
    
    Private Sub DataGridView1_RowsAdded(sender As Object, e As System.Windows.Forms.DataGridViewRowsAddedEventArgs) Handles DataGridView1.RowsAdded
        For I = 0 To DataGridView1.Rows.Count - 1
            DataGridView1.Rows(I).Cells(0).Value = "عرض"
            Dim row As DataGridViewRow = DataGridView1.Rows(I)
            row.Height = 23

        Next
    End Sub

    'Private Sub DataGridView1_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
    '    If e.ColumnIndex = -1 Then Exit Sub
    '    Dim colName=CType sender 
    'End Sub
End Class


