Public Class FrmCountries
    Sub FillCountries(sql As String)
        ListBox1.Items.Clear()
        C_NAME.Text = ""
        C_NAME.Focus()
        Dim adp As New SqlClient.SqlDataAdapter(sql, SQlconn)
        Dim ds As New DataSet
        adp.Fill(ds)
        Dim dt = ds.Tables(0)
        '=======================================================================================
        For I = 0 To dt.Rows.Count - 1
            ListBox1.Items.Add(dt.Rows(I).Item("C_NAME"))

        Next
    End Sub

    Private Sub cusave_Click(sender As System.Object, e As System.EventArgs) Handles cusave.Click
        If C_NAME.Text.Trim = "" Then
            MsgBox("يجب ادخال اسم الدولة قبل اتمام عملية الاضافة ", MsgBoxStyle.Critical, "خطأ")
            C_NAME.Focus()
        End If
        '=========================================================================================
        Dim sql = "select * from Countries where C_NAME=N'" & (C_NAME.Text) & "'"
        Dim adp As New SqlClient.SqlDataAdapter(sql, SQlconn)
        Dim ds As New DataSet
        adp.Fill(ds)
        Dim dt = ds.Tables(0)
        If dt.Rows.Count > 0 Then
            MsgBox("اسم الدولة المدخلة  موجود مسبقا ", MsgBoxStyle.Exclamation, "رسالة تنبية")
        Else
            Dim DR = dt.NewRow
            DR!C_NAME = C_NAME.Text
            dt.Rows.Add(DR)
            Dim cmd As New SqlClient.SqlCommandBuilder(adp)
            adp.Update(dt)
            FillCountries("SELECT * FROM Countries ORDER BY C_NAME")
            MsgBox("تم حفظ بيانات الدولة بنجاح", MsgBoxStyle.Information, "رسالة تأكيد")

        End If
    End Sub

    Private Sub FrmCountries_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        FillCountries("SELECT * FROM Countries ORDER BY C_NAME")

    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles ListBox1.SelectedIndexChanged
        C_NAME.Text = ListBox1.Text 'تغيير اسم الدوله عند النقر عليها 

    End Sub

    
    Private Sub cuedit_Click(sender As System.Object, e As System.EventArgs) Handles cuedit.Click
        If C_NAME.Text.Trim = "" Then
            MsgBox("يجب ادخال اسم الدولة قبل  عملية االتعديل ", MsgBoxStyle.Critical, "خطأ")
            C_NAME.Focus()
        End If
        '=========================================================================================
        Dim sql = "select * from Countries where C_NAME=N'" & (ListBox1.Text) & "'"
        Dim adp As New SqlClient.SqlDataAdapter(sql, SQlconn)
        Dim ds As New DataSet
        adp.Fill(ds)
        Dim dt = ds.Tables(0)
        If dt.Rows.Count = 0 Then
            MsgBox("اسم الدولة التي تريد تعديلها غير  موجود  ", MsgBoxStyle.Exclamation, "رسالة تنبية")
        Else
            Dim DR = dt.Rows(0)
            DR!C_NAME = C_NAME.Text
            Dim cmd As New SqlClient.SqlCommandBuilder(adp)
            adp.Update(dt)
            '==================================== تعديل اسم الدولة الحالية في جدول المدن================
            Dim cmdd As New SqlClient.SqlCommand
            cmdd.Connection = SQlconn
            cmdd.CommandText = "UPDATE Cities set C_name=N'" & C_NAME.Text & "' WHERE  C_name=N'" & ListBox1.Text & "'"
            cmdd.ExecuteNonQuery()
            '=================================================================================================
            FillCountries("SELECT * FROM Countries ORDER BY C_NAME") ' عرض سجلات الدول
            MsgBox("تم تعديل بيانات الدولة بنجاح", MsgBoxStyle.Information, "رسالة تأكيد")

        End If
    End Sub

    Private Sub btcudelete_Click(sender As System.Object, e As System.EventArgs) Handles btcudelete.Click
        If C_NAME.Text.Trim = "" Then
            MsgBox("يجب ادخال اسم الدولة قبل  عملية الحذف ", MsgBoxStyle.Critical, "خطأ")
            C_NAME.Focus()
        End If
        '=========================================================================================
        Dim sql = "select * from Countries where C_NAME=N'" & (ListBox1.Text) & "'"
        Dim adp As New SqlClient.SqlDataAdapter(sql, SQlconn)
        Dim ds As New DataSet
        adp.Fill(ds)
        Dim dt = ds.Tables(0)
        If dt.Rows.Count = 0 Then
            MsgBox("اسم الدولة التي تريد حذفها غير  موجود  ", MsgBoxStyle.Exclamation, "رسالة تنبية")
        Else
            Dim DR = dt.Rows(0)
            DR.Delete()
            Dim cmd As New SqlClient.SqlCommandBuilder(adp)
            adp.Update(dt)
            FillCountries("SELECT * FROM Countries ORDER BY C_NAME") ' عرض سجلات الدول
            MsgBox("تم حذف بيانات الدولة بنجاح", MsgBoxStyle.Information, "رسالة تأكيد")

        End If
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        FrmCities.ShowDialog()

    End Sub
End Class