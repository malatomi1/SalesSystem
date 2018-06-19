Imports System.IO
Imports System.Drawing.Imaging
Public Class FrmSupliers
    Sub FillCountries(sql As String)
        Country.Items.Clear()
        Dim adp As New SqlClient.SqlDataAdapter(sql, SQlconn)
        Dim ds As New DataSet
        adp.Fill(ds)
        Dim dt = ds.Tables(0)
        '=======================================================================================
        For I = 0 To dt.Rows.Count - 1
            Country.Items.Add(dt.Rows(I).Item("C_NAME"))

        Next
    End Sub

    Private Sub Country_DropDown(sender As Object, e As System.EventArgs) Handles Country.DropDown
        FillCountries("SELECT * FROM Countries ORDER BY C_NAME")

    End Sub
    Sub show_record_data(x)
        OpenFileDialog1.FileName = ""
        supbtnew_Click(Nothing, Nothing)
        Dim sql = "SELECT * FROM Suppliers where SupCode=N'" & (x) & "'"
        Dim adp As New SqlClient.SqlDataAdapter(sql, SQlconn)
        Dim ds As New DataSet
        adp.Fill(ds)
        Dim dt = ds.Tables(0)
        If dt.Rows.Count = 0 Then
            MsgBox("لم يتم العثور على بيانات السجل", MsgBoxStyle.Exclamation, "رسالة تنبية")
        Else

            Dim dr = dt.Rows(0)
            On Error Resume Next
            SupCode.Text = dr!SupCode
            SupName.Text = dr!SupName
            Address.Text = dr!Address
            Country.Text = dr!Country
            City.Text = dr!City
            Fax.Text = dr!Fax
            Mobile.Text = dr!Mobile
            Email.Text = dr!Email
            Facebook.Text = dr!Facebook
            Note.Text = dr!Note
            '===================================================================
            If IsDBNull(dr!Sup_image) = False Then
                Dim imgByteArray() As Byte
                imgByteArray = CType(dr!Sup_image, Byte())
                Dim stream As New MemoryStream(imgByteArray)
                Dim bmp As New Bitmap(stream)
                Sup_image.Image = Image.FromStream(stream)
                stream.Close()
                Label8.Visible = False
            End If
            supbtnew.Enabled = True
            supbtnedit.Enabled = True
            supbtndelet.Enabled = True
            supbtnsave.Enabled = False
            SupName.Focus()

        End If


    End Sub
    Private Sub FrmSupliers_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        supbtnew_Click(Nothing, Nothing)
        supbtnew.Enabled = True
        supbtnedit.Enabled = False
        supbtndelet.Enabled = False
        SupName.Focus()
    End Sub
    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        FrmCountries.ShowDialog()

    End Sub



    Private Sub Country_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles Country.SelectedIndexChanged
        If Country.Items.Count = 0 Then Exit Sub
        City.Items.Clear()
        Dim adp As New SqlClient.SqlDataAdapter("select * from Cities where c_name=N'" & Country.Text & "'order by CT_NAME", SQlconn)
        Dim ds As New DataSet
        adp.Fill(ds)
        Dim dt = ds.Tables(0)
        '============================================================
        For I = 0 To dt.Rows.Count - 1
            City.Items.Add(dt.Rows(I).Item("CT_NAME"))

        Next
    End Sub

    Private Sub supbtnew_Click(sender As System.Object, e As System.EventArgs) Handles supbtnew.Click
        ErrorProvider1.SetError(SupName, "")
        OpenFileDialog1.FileName = ""
        On Error Resume Next
        For i = 0 To GroupBox1.Controls.Count
            If TypeOf GroupBox1.Controls(i) Is TextBox Then GroupBox1.Controls(i).Text = "" ' ينظف المحتويات كلها
            If TypeOf GroupBox1.Controls(i) Is ComboBox Then GroupBox1.Controls(i).Text = ""
        Next
        Sup_image.Image = Nothing
        SupCode.Text = Format(GET_LAST_RECORD("Suppliers", "SuPInternal_ID ") + 1, "SUP000000")
        supbtnsave.Enabled = True
        supbtnedit.Enabled = False
        supbtndelet.Enabled = False
        SupName.Focus()
    End Sub

    Private Sub supbtnsave_Click(sender As System.Object, e As System.EventArgs) Handles supbtnsave.Click
        If Trim(SupName.Text) = "" Then
            ErrorProvider1.SetError(SupName, "يرجى إدخال إسم المورد")
            Exit Sub

        End If
        '===================================================================================================
        Try
            Dim sql = "select * from Suppliers where SupName=N'" & (SupName.Text) & "'"
            Dim adp As New SqlClient.SqlDataAdapter(sql, SQlconn)
            Dim ds As New DataSet
            adp.Fill(ds)
            Dim dt = ds.Tables(0)
            If dt.Rows.Count > 0 Then
                MsgBox("اسم المورد موجود مسبقا ", MsgBoxStyle.Exclamation, "رسالة تنبية")
            Else

                Dim dr = dt.NewRow
                dr!SupCode = SupCode.Text
                dr!SupName = SupName.Text
                dr!Address = Address.Text
                dr!Country = Country.Text
                dr!City = City.Text
                dr!Fax = Fax.Text
                dr!Mobile = Mobile.Text
                dr!Email = Email.Text
                dr!Facebook = Facebook.Text
                dr!Note = Note.Text
                dr!Debit = Val(Debit.Text)
                dr!Credit = Val(Credit.Text)
                dr!Balance = Val(Balance.Text)
                dr!Status = True
                '=======================================     تشفير الصورة=================================================
                If OpenFileDialog1.FileName <> "" Then
                    Dim imgByteArray() As Byte
                    Dim stream As New MemoryStream

                    Sup_image.Image.Save(stream, ImageFormat.Jpeg)
                    imgByteArray = stream.ToArray
                    stream.Close()
                    dr!Sup_image = imgByteArray

                End If
                dt.Rows.Add(dr)
                Dim cmd As New SqlClient.SqlCommandBuilder(adp)
                adp.Update(dt)
                supbtnew_Click(Nothing, Nothing)
                MsgBox("تم حفظ بيانات المورد بنجاح", MsgBoxStyle.Information, "رسالة تأكيد")

            End If


        Catch ex As Exception
            MessageBox.Show(ex.Message, "فشل في عملية الحفظ", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly)

        End Try
    End Sub

    Private Sub SupName_TextChanged(sender As System.Object, e As System.EventArgs) Handles SupName.TextChanged
        ErrorProvider1.SetError(SupName, "")
    End Sub

    Private Sub Sup_image_Click(sender As System.Object, e As System.EventArgs) Handles Sup_image.Click
        OpenFileDialog1.FileName = ""
        OpenFileDialog1.Filter = "Jpeg|*.Jpg|Bitmap|*.Bmp|Gif|*.gif|Png|*.png"
        OpenFileDialog1.ShowDialog()
        If OpenFileDialog1.FileName = "" Then Exit Sub
        Label8.Visible = False
        Sup_image.Image = Image.FromFile(OpenFileDialog1.FileName)
    End Sub

    Private Sub supbtnedit_Click(sender As System.Object, e As System.EventArgs) Handles supbtnedit.Click
        If Trim(SupName.Text) = "" Then
            ErrorProvider1.SetError(SupName, "يرجى إدخال إسم المورد")
            Exit Sub

        End If
        '===================================================================================================
        If MsgBox("سوف يتم حفظ هذه التعديلات ، هل تريد الإستمرار؟", MsgBoxStyle.Question + MsgBoxStyle.YesNo + MsgBoxStyle.DefaultButton2, "رسالة") = MsgBoxResult.No Then Exit Sub
        Try
            Dim sql = "select * from Suppliers where SupCode=N'" & (SupCode.Text) & "'"
            Dim adp As New SqlClient.SqlDataAdapter(sql, SQlconn)
            Dim ds As New DataSet
            adp.Fill(ds)
            Dim dt = ds.Tables(0)
            If dt.Rows.Count = 0 Then
                MsgBox("لم يتم العثور على سجل عميل تحت هذا الرقم يرجى التأكد من الرقم", MsgBoxStyle.Exclamation, "رسالة تنبية")
            Else

                Dim dr = dt.Rows(0)
                dr!SupCode = SupCode.Text
                dr!SupName = SupName.Text
                dr!Address = Address.Text
                dr!Country = Country.Text
                dr!City = City.Text
                dr!Fax = Fax.Text
                dr!Mobile = Mobile.Text
                dr!Email = Email.Text
                dr!Facebook = Facebook.Text
                dr!Note = Note.Text
                dr!Debit = Val(Debit.Text)
                dr!Credit = Val(Credit.Text)
                dr!Balance = Val(Balance.Text)
                dr!Status = True
                '=======================================     تشفير الصورة=================================================
                If OpenFileDialog1.FileName <> "" Then
                    Dim imgByteArray() As Byte
                    Dim stream As New MemoryStream

                    Sup_image.Image.Save(stream, ImageFormat.Jpeg)
                    imgByteArray = stream.ToArray
                    stream.Close()
                    dr!Sup_image = imgByteArray

                End If
                ' dt.Rows.Add(dr) لانحتاجة
                Dim cmd As New SqlClient.SqlCommandBuilder(adp)
                adp.Update(dt)
                supbtnew_Click(Nothing, Nothing)
                MsgBox("تم تعديل بيانات المورد بنجاح", MsgBoxStyle.Information, "رسالة تأكيد")

            End If


        Catch ex As Exception
            MessageBox.Show(ex.Message, "فشل في عملية التعديل", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly)

        End Try
    End Sub

    Private Sub supbtndelet_Click(sender As System.Object, e As System.EventArgs) Handles supbtndelet.Click
        If MsgBox("سوف يتم حذف سجل هذا المورد وحفظه في الارشيف ، هل تريد الإستمرار؟", MsgBoxStyle.Question + MsgBoxStyle.YesNo + MsgBoxStyle.DefaultButton2, "رسالة") = MsgBoxResult.No Then Exit Sub
        Try
            Dim cmdd As New SqlClient.SqlCommand
            cmdd.Connection = SQlconn
            cmdd.CommandText = "UPDATE Suppliers  set Status ='false' WHERE SupCode=N'" & SupCode.Text & "'"
            cmdd.ExecuteNonQuery()
            'جملة الحذف الاخرى ممكن تستخدمها
            'Dim sql = "select * from Suppliers where SupCode=N'" & (SupCode.Text) & "'"
            'Dim adp As New SqlClient.SqlDataAdapter(sql, SQlconn)
            'Dim ds As New DataSet
            'adp.Fill(ds)
            'Dim dt = ds.Tables(0)
            'If dt.Rows.Count = 0 Then
            '    MsgBox("لم يتم العثور على سجل عميل تحت هذا الرقم يرجى التأكد من الرقم", MsgBoxStyle.Exclamation, "رسالة تنبية")
            'Else

            '    Dim dr = dt.Rows(0)
            '    dr!Status = False
            '    Dim cmd As New SqlClient.SqlCommandBuilder(adp)
            '    adp.Update(dt)
            supbtnew_Click(Nothing, Nothing)
            MsgBox("تم حذف بيانات المورد بنجاح", MsgBoxStyle.Information, "رسالة تأكيد")

            'End If


        Catch ex As Exception
            MessageBox.Show(ex.Message, "فشل في عملية الحذف", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly)

        End Try
    End Sub

    Private Sub btnsearch_Click(sender As System.Object, e As System.EventArgs) Handles supbtnsearch.Click
        SearchSuppliers.ShowDialog()

    End Sub

    
End Class