Public Class FrmCities
    Sub FillCountries()
        Country.Items.Clear()
        Dim adp As New SqlClient.SqlDataAdapter("select * from Countries order by c_name", SQlconn)
        Dim ds As New DataSet
        adp.Fill(ds)
        Dim dt = ds.Tables(0)
        '=======================================================================================
        For I = 0 To dt.Rows.Count - 1
            Country.Items.Add(dt.Rows(I).Item("C_NAME"))
        Next
    End Sub

    
    Private Sub Country_DropDown(sender As Object, e As System.EventArgs) Handles Country.DropDown
        FillCountries()
    End Sub

    Private Sub Country_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles Country.SelectedIndexChanged
        If Country.Items.Count = 0 Then Exit Sub
        CT_name.Text = ""
        ListBox1.Items.Clear()
        Dim adp As New SqlClient.SqlDataAdapter("select * from Cities where c_name=N'" & Country.Text & "'order by CT_NAME", SQlconn)
        Dim ds As New DataSet
        adp.Fill(ds)
        Dim dt = ds.Tables(0)
        '============================================================
        For I = 0 To dt.Rows.Count - 1
            ListBox1.Items.Add(dt.Rows(I).Item("CT_NAME"))

        Next
    End Sub
    Private Sub FrmCities_Load(sender As Object, e As System.EventArgs) Handles MyBase.Load
        Country.Items.Clear()
        CT_name.Text = ""
        ListBox1.Text = ""
    End Sub
    Private Sub btnsaveci_Click(sender As System.Object, e As System.EventArgs) Handles btnsaveci.Click
        '=================================== التأكد من اختيار الدولة قبل عملية الاضافة =================
        If Country.SelectedIndex < 0 Then
            MsgBox("يرجى ااختيار الدولة من القائمة ", MsgBoxStyle.Critical, "رسالةتنبية")
            Country.Focus()
            Exit Sub
        End If
        '===================== التأكد من ادخال اسم المدينة قبل عملية الحفظ==========================
        If CT_name.Text.Trim = "" Then
            MsgBox("يجب ادخال اسم المدينة قبل اتمام عملية الاضافة ", MsgBoxStyle.Critical, "خطأ")
            CT_name.Focus()
        End If
        '=========================================================================================
        Dim sql = "select * from Cities where CT_NAME=N'" & (CT_name.Text) & "'"
        Dim adp As New SqlClient.SqlDataAdapter(sql, SQlconn)
        Dim ds As New DataSet
        adp.Fill(ds)
        Dim dt = ds.Tables(0)
        If dt.Rows.Count > 0 Then
            MsgBox("اسم المدينة المدخلة  موجود مسبقا ", MsgBoxStyle.Exclamation, "رسالة تنبية")
        Else
            Dim DR = dt.NewRow
            DR!C_name = Country.Text
            DR!CT_NAME = CT_name.Text
            dt.Rows.Add(DR)
            Dim cmd As New SqlClient.SqlCommandBuilder(adp)
            adp.Update(dt)
            Country_SelectedIndexChanged(Nothing, Nothing)
            MsgBox("تم حفظ بيانات المدينة بنجاح", MsgBoxStyle.Information, "رسالة تأكيد")

        End If
    End Sub

    Private Sub btnediteci_Click(sender As System.Object, e As System.EventArgs) Handles btnediteci.Click
        '=================================== التأكد من اختيار الدولة قبل عملية الاضافة =================
        If Country.SelectedIndex < 0 Then
            MsgBox("يرجى ااختيار الدولة من القائمة ", MsgBoxStyle.Critical, "رسالةتنبية")
            Country.Focus()
            Exit Sub
        End If
        '===================== التأكد من ادخال اسم المدينة قبل عملية الحفظ==========================
        If CT_name.Text.Trim = "" Then
            MsgBox("يجب ادخال اسم المدينة قبل اتمام عملية التعديل ", MsgBoxStyle.Critical, "خطأ")
            CT_name.Focus()
        End If
        '=========================================================================================
        Dim sql = "select * from Cities where C_NAME=N'" & Country.Text & "' and CT_NAME=N'" & (ListBox1.Text) & "'"
        Dim adp As New SqlClient.SqlDataAdapter(sql, SQlconn)
        Dim ds As New DataSet
        adp.Fill(ds)
        Dim dt = ds.Tables(0)
        If dt.Rows.Count = 0 Then
            MsgBox("اسم المدينة التي تريد تعديلها غير موجود   ", MsgBoxStyle.Exclamation, "رسالة تنبية")
        Else
            Dim DR = dt.Rows(0)
            DR!C_name = Country.Text
            DR!CT_name = CT_name.Text
            Dim cmd As New SqlClient.SqlCommandBuilder(adp)
            adp.Update(dt)
            Country_SelectedIndexChanged(Nothing, Nothing)
            MsgBox("تم تعديل بيانات المدينة بنجاح", MsgBoxStyle.Information, "رسالة تأكيد")

        End If
    End Sub

    Private Sub btndeleteci_Click(sender As System.Object, e As System.EventArgs) Handles btndeleteci.Click
        '=================================== التأكد من اختيار الدولة قبل عملية الاضافة =================
        If Country.SelectedIndex < 0 Then
            MsgBox("يرجى ااختيار الدولة من القائمة ", MsgBoxStyle.Critical, "رسالةتنبية")
            Country.Focus()
            Exit Sub
        End If
        '===================== التأكد من ادخال اسم المدينة قبل عملية الحفظ==========================
        If CT_name.Text.Trim = "" Then
            MsgBox("يجب ادخال اسم المدينة قبل اتمام عملية الاضافة ", MsgBoxStyle.Critical, "خطأ")
            CT_name.Focus()
        End If
        '=========================================================================================
        Dim sql = "select * from Cities where C_name=N'" & Country.Text & "' and CT_name=N'" & (ListBox1.Text) & "'"
        Dim adp As New SqlClient.SqlDataAdapter(sql, SQlconn)
        Dim ds As New DataSet
        adp.Fill(ds)
        Dim dt = ds.Tables(0)
        If dt.Rows.Count = 0 Then
            MsgBox("اسم المدينة التي تريد حذفها غير موجود   ", MsgBoxStyle.Exclamation, "رسالة تنبية")
        Else
            Dim DR = dt.Rows(0)
            DR.Delete()
            Dim cmd As New SqlClient.SqlCommandBuilder(adp)
            adp.Update(dt)
            Country_SelectedIndexChanged(Nothing, Nothing)
            MsgBox("تم حذف بيانات المدينة بنجاح", MsgBoxStyle.Information, "رسالة تأكيد")
        End If
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles ListBox1.SelectedIndexChanged
        CT_name.Text = ListBox1.Text

    End Sub

    
End Class