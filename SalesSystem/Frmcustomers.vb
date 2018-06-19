Imports System.IO
Imports System.Drawing.Imaging

Public Class Frmcustomers
    Sub show_record_data(x)
        OpenFileDialog1.FileName = ""
        btnnew_Click(Nothing, Nothing)
        Dim sql = "SELECT * FROM Customers where CustomerCode=N'" & (x) & "'"
        Dim adp As New SqlClient.SqlDataAdapter(sql, SQlconn)
        Dim ds As New DataSet
        adp.Fill(ds)
        Dim dt = ds.Tables(0)
        If dt.Rows.Count = 0 Then
            MsgBox("لم يتم العثور على بيانات السجل ", MsgBoxStyle.Exclamation, "رسالة تنبية")
        Else
            Dim dr = dt.Rows(0)
            On Error Resume Next
            CustomerCode.Text = dr!CustomerCode
            CustomerName.Text = dr!CustomerName
            Address.Text = dr!Address
            Country.Text = dr!Country
            City.Text = dr!City
            Fax.Text = dr!Fax
            Mobile.Text = dr!Mobile
            Email.Text = dr!Email
            Facebook.Text = dr!Facebook
            Note.Text = dr!Note
            '===========================================================================
            'فك تشفير الصورة

            If IsDBNull(dr!Cust_image) = False Then
                Dim imgByteArray() As Byte
                imgByteArray = CType(dr!Cust_image, Byte())
                Dim stream As New MemoryStream(imgByteArray)
                Dim bmp As New Bitmap(stream)
                Cust_image.Image = Image.FromStream(stream)
                stream.Close()
                Label8.Visible = False
            End If
            '============================================================================
            btnsave.Enabled = False
            btnedit.Enabled = True
            btndelet.Enabled = True
            CustomerName.Focus()

        End If

    End Sub

    Private Sub btnnew_Click(sender As System.Object, e As System.EventArgs) Handles btnnew.Click

        On Error Resume Next
        For i = 0 To GroupBox1.Controls.Count
            If TypeOf GroupBox1.Controls(i) Is TextBox Then GroupBox1.Controls(i).Text = ""
        Next
        Cust_image.Image = Nothing
        CustomerCode.Text = Format(GET_LAST_RECORD("Customers", "Customerid ") + 1, "CUS000000")
        btnsave.Enabled = True
        btnedit.Enabled = False
        btndelet.Enabled = False
        CustomerName.Focus()

    End Sub
    Private Sub Frmcustomers_Load(sender As Object, e As System.EventArgs) Handles MyBase.Load
        CustomerCode.Text = Format(GET_LAST_RECORD("Customers", "Customerid ") + 1, "CUS000000")
        btnnew_Click(Nothing, Nothing)

    End Sub

    Private Sub btnsave_Click(sender As System.Object, e As System.EventArgs) Handles btnsave.Click
        If Trim(CustomerName.Text) = "" Then
            ErrorProvider1.SetError(CustomerName, "يرجى إدخال إسم العميل")
            Exit Sub

        End If
        '===================================================================================================
        Try
            Dim sql = "select * from Customers where CustomerName=N'" & (CustomerName.Text) & "'"
            Dim adp As New SqlClient.SqlDataAdapter(sql, SQlconn)
            Dim ds As New DataSet
            adp.Fill(ds)
            Dim dt = ds.Tables(0)
            If dt.Rows.Count > 0 Then
                MsgBox("اسم العميل موجود مسبقا ", MsgBoxStyle.Exclamation, "رسالة تنبية")
            Else

                Dim dr = dt.NewRow
                dr!CustomerCode = CustomerCode.Text
                dr!CustomerName = CustomerName.Text
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

                    Cust_image.Image.Save(stream, ImageFormat.Jpeg)
                    imgByteArray = stream.ToArray
                    stream.Close()
                    dr!Cust_image = imgByteArray

                End If
                dt.Rows.Add(dr)
                Dim cmd As New SqlClient.SqlCommandBuilder(adp)
                adp.Update(dt)
                btnnew_Click(Nothing, Nothing)
                MsgBox("تم حفظ بيانات العميل بنجاح", MsgBoxStyle.Information, "رسالة تأكيد")

            End If


        Catch ex As Exception
            MessageBox.Show(ex.Message, "فشل في عملية الحفظ", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly)

        End Try
    End Sub

    Private Sub CustomerName_TextChanged(sender As System.Object, e As System.EventArgs) Handles CustomerName.TextChanged
        ErrorProvider1.SetError(CustomerName, "")

    End Sub

    Private Sub OpenFileDialog1_FileOk(sender As System.Object, e As System.ComponentModel.CancelEventArgs) Handles OpenFileDialog1.FileOk

    End Sub


    Private Sub Cust_image_Click_1(sender As System.Object, e As System.EventArgs) Handles Cust_image.Click
        OpenFileDialog1.FileName = ""
        OpenFileDialog1.Filter = "Jpeg|*.Jpg|Bitmap|*.Bmp|Gif|*.gif|Png|*.png"
        OpenFileDialog1.ShowDialog()
        If OpenFileDialog1.FileName = "" Then Exit Sub
        Label8.Visible = False
        Cust_image.Image = Image.FromFile(OpenFileDialog1.FileName)

    End Sub

    Private Sub btnedit_Click(sender As System.Object, e As System.EventArgs) Handles btnedit.Click
        If Trim(CustomerName.Text) = "" Then
            ErrorProvider1.SetError(CustomerName, "يرجى إدخال إسم العميل")
            Exit Sub

        End If
        '===================================================================================================
        If MsgBox("سوف يتم حفظ هذه التعديلات ، هل تريد الإستمرار؟", MsgBoxStyle.Question + MsgBoxStyle.YesNo + MsgBoxStyle.DefaultButton2, "رسالة") = MsgBoxResult.No Then Exit Sub
        Try
            Dim sql = "select * from Customers where CustomerCode=N'" & (CustomerCode.Text) & "'"
            Dim adp As New SqlClient.SqlDataAdapter(sql, SQlconn)
            Dim ds As New DataSet
            adp.Fill(ds)
            Dim dt = ds.Tables(0)
            If dt.Rows.Count = 0 Then
                MsgBox("لم يتم العثور على سجل عميل تحت هذا الرقم يرجى التأكد من الرقم", MsgBoxStyle.Exclamation, "رسالة تنبية")
            Else

                Dim dr = dt.Rows(0)
                dr!CustomerCode = CustomerCode.Text
                dr!CustomerName = CustomerName.Text
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

                    Cust_image.Image.Save(stream, ImageFormat.Jpeg)
                    imgByteArray = stream.ToArray
                    stream.Close()
                    dr!Cust_image = imgByteArray

                End If
                ' dt.Rows.Add(dr) لانحتاجة
                Dim cmd As New SqlClient.SqlCommandBuilder(adp)
                adp.Update(dt)
                btnnew_Click(Nothing, Nothing)
                MsgBox("تم تعديل بيانات العميل بنجاح", MsgBoxStyle.Information, "رسالة تأكيد")

            End If


        Catch ex As Exception
            MessageBox.Show(ex.Message, "فشل في عملية التعديل", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly)

        End Try
    End Sub

    Private Sub btndelet_Click(sender As System.Object, e As System.EventArgs) Handles btndelet.Click


        '===================================================================================================
        If MsgBox("سوف يتم حذف سجل هذا العميل وحفظه في الارشيف ، هل تريد الإستمرار؟", MsgBoxStyle.Question + MsgBoxStyle.YesNo + MsgBoxStyle.DefaultButton2, "رسالة") = MsgBoxResult.No Then Exit Sub
        Try
            Dim sql = "select * from Customers where CustomerCode=N'" & (CustomerCode.Text) & "'"
            Dim adp As New SqlClient.SqlDataAdapter(sql, SQlconn)
            Dim ds As New DataSet
            adp.Fill(ds)
            Dim dt = ds.Tables(0)
            If dt.Rows.Count = 0 Then
                MsgBox("لم يتم العثور على سجل عميل تحت هذا الرقم يرجى التأكد من الرقم", MsgBoxStyle.Exclamation, "رسالة تنبية")
            Else

                Dim dr = dt.Rows(0)
                dr!Status = False
                Dim cmd As New SqlClient.SqlCommandBuilder(adp)
                adp.Update(dt)
                btnnew_Click(Nothing, Nothing)
                MsgBox("تم حذف بيانات العميل بنجاح", MsgBoxStyle.Information, "رسالة تأكيد")

            End If


        Catch ex As Exception
            MessageBox.Show(ex.Message, "فشل في عملية التعديل", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly)

        End Try
    End Sub

    Private Sub Button5_Click(sender As System.Object, e As System.EventArgs) Handles btnsearch.Click
        SearchCustomers.ShowDialog()

    End Sub

    
End Class