Imports System.IO
Imports System.Drawing.Imaging
Public Class FrmItems ' تعبئة combo box
    Private Sub btnnew_Click(sender As System.Object, e As System.EventArgs) Handles btnnew.Click
        itemcode.Text = Format(GET_LAST_RECORD("Catogories", "CatAutoNumber") + 1, "ITM000000")
    End Sub

    Private Sub FrmItems_Load(sender As Object, e As System.EventArgs) Handles MyBase.Load
        itemcode.Text = Format(GET_LAST_RECORD("Catogories", "CatAutoNumber") + 1, "ITM000000")
    End Sub
    Sub FillCatName()
        CatName.Items.Clear()
        Dim adp As New SqlClient.SqlDataAdapter("select * from Catogories order by CatName ", SQlconn)
        Dim ds As New DataSet
        adp.Fill(ds)
        Dim dt = ds.Tables(0)
        '=======================================================================================
        For I = 0 To dt.Rows.Count - 1
            CatName.Items.Add(dt.Rows(I).Item("CatName"))

        Next
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        FrmCategorization.ShowDialog()

    End Sub


    Private Sub CatName_DropDown(sender As Object, e As System.EventArgs) Handles CatName.DropDown
        FillCatName()
    End Sub



    Private Sub itemname_TextChanged(sender As System.Object, e As System.EventArgs) Handles itemname.TextChanged
        ErrorProvider1.SetError(itemname, "")
    End Sub

    Private Sub btnsave_Click(sender As System.Object, e As System.EventArgs) Handles btnsave.Click
        If itemname.Text = "" Then
            ErrorProvider1.SetError(itemname, " ادخل اسم الصنف ")
            itemname.Focus()
            Exit Sub
        End If
        If CatName.Text = "" Then
            ErrorProvider1.SetError(CatName, "ادخل اسم التصنيف الرئيسي للصنف")
            CatName.Focus()
            Exit Sub
        End If
        If FirstUnit.Text = "" Then
            MsgBox("ادخل اسم الوحده الاولى للصنف", MsgBoxStyle.Critical, "تعليمات")
            ErrorProvider1.SetError(FirstUnit, "ادخل اسم الوحده الاولى للصنف ")
            FirstUnit.Focus()
            Exit Sub
        End If
        Try
            Dim STR = "select *from Items where itemname=N'" & itemname.Text.Trim & "'" ' ابحث عن العنصر الذي اسمه ايتم نيم المخزن في جدول الايتمز بدلالة الخانة المدخلة في اسم الصنف
            Dim adp = New SqlClient.SqlDataAdapter(STR, SQlconn)
            Dim ds = New DataSet
            adp.Fill(ds)
            Dim dt As DataTable
            dt = ds.Tables(0)
            If dt.Rows.Count > 0 Then
                MsgBox(" اسم الصنف المدخل موجود مسبقا ", MsgBoxStyle.Exclamation, "رسالة تنبية")
                itemname.Focus()
            Else
                Dim dr = dt.NewRow
                ' اضف سجل جديد في جدول الايتمز
                ' """""""""""""""""""" البيانات الاساسية"""""""""""""""""""""""""
                dr!ItemCode = itemcode.Text
                dr!itemname = itemname.Text
                dr!catname = CatName.Text
                dr!size = size.Text
                dr!origin = origin.Text
                dr!location = location.Text
                dr!company = company.Text
                dr!color = color.Text
                dr!provenance = provenance.Text
                dr!quality = quality.Text
                dr!model = model.Text
                dr!itemserial = itemserial.Text
                If proddate.Text.Equals(String.Empty) Then dr!proddate = proddate.Text
                If exprdate.Text.Equals(String.Empty) Then dr!exprdate = exprdate.Text

                dr!status = True




                '''''''''''''''''''''''''''''''' الوحدات '''''''''''''''''''''''''
                dr!FirstUnit = FirstUnit.Text
                dr!FirstUnitBarcode = FirstUnitBarcode.Text



                dr!SecondUnit = SecondUnit.Text
                dr!SecondUnitBarcode = SecondUnitBarcode.Text
                dr!SecondUnitOperatingConvert = Val(SecondUnitOperatingConvert.Text)


                dr!ThirdUnit = ThirdUnit.Text
                dr!ThirdUnitBarcode = ThirdUnitBarcode.Text
                dr!ThirdUnitOperatingConvert = Val(ThirdUnitOperatingConvert.Text)


                '===================== خيارات الحدود=============== 
                dr!MaxLimitForFirstUnit = Val(MaxLimitForFirstUnit.Text)
                dr!MinLimitForFirstUnit = Val(MinLimitForFirstUnit.Text)
                dr!OrderLimitForFirstUnit = Val(OrderLimitForFirstUnit.Text)


                dr!MaxLimitForSecondUnit = Val(MaxLimitForSecondUnit.Text)
                dr!MinLimitForSecondUnit = Val(MinLimitForSecondUnit.Text)
                dr!OrderLimitForSecondUnit = Val(OrderLimitForSecondUnit.Text)




                dr!MaxLimitForThirdUnit = Val(MaxLimitForThirdUnit.Text)
                dr!MinLimitForThirdUnit = Val(MinLimitForThirdUnit.Text)
                dr!OrderLimitForThirdUnit = Val(OrderLimitForThirdUnit.Text)


                If unitdef1.Checked = True Then dr!unitdefault = 1 'اكواد الافتراضي في الوحدات
                If unitdef2.Checked = True Then dr!unitdefault = 2
                If unitdef3.Checked = True Then dr!unitdefault = 3


                ' ''================ أسعار البيع===================
                'Dim tableName As String = ""
                'Dim flg As Boolean = False


                ''===============================================================
                'Dim STR1
                'If salestrategy.SelectedIndex = 0 Then ' tableName = "ItemNormalPrices"

                '    STR1 = "select * from ItemNormalPrices WHERE ItemCode=N'" & itemname.Text.Trim & "'"
                'ElseIf salestrategy.SelectedIndex = 1 Then 'tableName = "ItemSeasonalPrices"
                '    STR1 = "select * from ItemSeasonalPrices WHERE ItemCode=N'" & itemname.Text.Trim & "'"
                'End If
                'Dim adp1 = New SqlClient.SqlDataAdapter(STR1, SQlconn)
                'Dim Ds1 = New DataSet
                'adp1.Fill(Ds1)
                'Dim Dt1 As DataTable
                'Dt1 = Ds1.Tables(0)
                'Dim dr1 As DataRow
                'If Dt1.Rows.Count = 0 Then
                '    dr1 = Dt1.NewRow
                '    flg = False
                'Else
                '    dr1 = Dt1.Rows(0)

                'End If

                'dr1!ItemCode = itemcode.Text
                'dr1!WholeSealForFirstUnit = Val(WholeSaleForFirstUnit.Text)
                'dr1!WholeSealForSecondUnit = Val(WholeSaleForSecondUnit.Text)
                'dr1!WholeSaleForThirdUnit = Val(WholeSaleForThirdUnit.Text)
                'dr1!HalfWholeSaleForFirstUnit = Val(HalfWholeSaleForFirstUnit.Text)
                'dr1!HalfWholeSaleForSecondUnit = Val(HalfWholeSaleForSecondUnit.Text)
                'dr1!HalfWholeSaleForThirdUnit = Val(HalfWholeSaleForFirstUnit.Text)
                'dr1!DestributorForFirstUnit = Val(DestributorForFirstUnit.Text)
                'dr1!DestributorForSecondUnit = Val(DestributorForThirdUnit.Text)
                'dr1!DestributorForThirdUnit = Val(DestributorForThirdUnit.Text)
                'dr1!ExportSaleForFirstUnit = Val(ExportSaleForFirstUnit.Text)
                'dr1!ExportSaleForSecondUnit = Val(ExportSaleForSecondUnit.Text)
                'dr1!ExportSaleForThirdUnit = Val(ExportSaleForThirdUnit.Text)
                'dr1!EndUserSaleForFirstUnit = Val(ExportSaleForSecondUnit.Text)
                'dr1!EndUserSaleForSecondUnit = Val(EndUserSaleForSecondUnit.Text)
                'dr1!EndUserSaleForThirdUnit = Val(EndUserSaleForThirdUnit.Text)
                'dr1!RetailSaleForFirstUnit = Val(RetailSaleForFirstUnit.Text)
                'dr1!RetailSaleForSecondUnit = Val(RetailSaleForSecondUnit.Text)
                'dr1!RetailSaleForThirdUnit = Val(RetailSaleForThirdUnit.Text)
                'dr1!Amanufacturing = Amanufacturing.Checked

                'If salestrategy.SelectedIndex = 1 Then
                '    dr1!FromDate = FromDate.Value
                '    dr1!ToDate = ToDate.Value

                'End If
                'If PriceDefault1.Checked = True Then dr1!PriceDefault1 = 1
                'If PriceDefault2.Checked = True Then dr1!PriceDefault1 = 2
                'If PriceDefault3.Checked = True Then dr1!PriceDefault1 = 3
                'If PriceDefault4.Checked = True Then dr1!PriceDefault1 = 4
                'If PriceDefault5.Checked = True Then dr1!PriceDefault1 = 5
                'If PriceDefault6.Checked = True Then dr1!PriceDefault1 = 6


                'If flg = False Then Dt1.Rows.Add(dr)
                'Dim cmd1 As New SqlClient.SqlCommandBuilder(adp1)
                'adp1.Update(Dt1)
                '' If FillPriceData(salestrategy.SelectedIndex) = False Then
                'MsgBox("فشل في عملية الحفظ يرجى المحاولة لاحقا", MsgBoxStyle.Critical, "خطأ")


                ' ========================تشفير الصورة ======================
                If OpenFileDialog1.FileName <= "" Then
                    Dim imgBayteArray() As Byte
                    Dim stream As New MemoryStream
                    PicItem.Image.Save(stream, ImageFormat.Jpeg)
                    imgBayteArray = stream.ToArray
                    stream.Close()
                    dr!PicItem = imgBayteArray

                End If
                dt.Rows.Add(dr)
                Dim cmd As New SqlClient.SqlCommandBuilder(adp)
                adp.Update(dt)
                btnnew_Click(Nothing, Nothing)
                MsgBox("تم  حفظ بيانات الصنف في قاعدة البيانات بنجاح ", MsgBoxStyle.Information, "رسالة تأكيد")
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "فشل في عملية الحفظ", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly)

        End Try

    End Sub
    '=================================================== كود التعديل ===================================
    'Private Sub btnedit_Click(sender As System.Object, e As System.EventArgs) Handles btnedit.Click
    '    If itemname.Text = "" Then
    '        ErrorProvider1.SetError(itemname, " ادخل اسم الصنف ")
    '        itemname.Focus()
    '        Exit Sub
    '    End If
    '    If CatName.Text = "" Then
    '        ErrorProvider1.SetError(CatName, "ادخل اسم التصنيف الرئيسي للصنف")
    '        CatName.Focus()
    '        Exit Sub
    '    End If
    '    If FirstUnit.Text = "" Then
    '        MsgBox("ادخل اسم الوحده الاولى للصنف", MsgBoxStyle.Critical, "تعليمات")
    '        ErrorProvider1.SetError(FirstUnit, "ادخل اسم الوحده الاولى للصنف ")
    '        FirstUnit.Focus()
    '        Exit Sub
    '    End If
    '    If MsgBox("سوف يتم حفظ هذه التعديلات ، هل تريد الإستمرار؟", MsgBoxStyle.Question + MsgBoxStyle.YesNo + MsgBoxStyle.DefaultButton2, "رسالة") = MsgBoxResult.No Then Exit Sub
    '    Try
    '        Dim STR = "select *from Items where ItemCode=N'" & ItemCode.Text.Trim & "'"
    '        Dim adp = New SqlClient.SqlDataAdapter(STR, SQlconn)
    '        Dim ds = New DataSet
    '        adp.Fill(ds)
    '        Dim dt As DataTable
    '        dt = ds.Tables(0)
    '        If dt.Rows.Count > 0 Then
    '            MsgBox("رمز الصنف الذي تريد تعديل بياناته غير موجود ", MsgBoxStyle.Exclamation, "رسالة تنبية")

    '        Else
    '            Dim dr = dt.Rows(0)
    '            ' """""""""""""""""""" البيانات الاساسية"""""""""""""""""""""""""
    '            dr!itemname = itemname.Text
    '            dr!CatName = CatName.Text
    '            dr!size = size.Text
    '            dr!origin = origin.Text
    '            dr!location = location.Text
    '            dr!company = company.Text
    '            dr!color = color.Text
    '            dr!provenance = provenance.Text
    '            dr!quality = quality.Text
    '            dr!model = model.Text
    '            dr!itemserial = itemserial.Text
    '            If proddate.Text.Equals(String.Empty) Then dr!proddate = proddate.Text
    '            If exprdate.Text.Equals(String.Empty) Then dr!exprdate = exprdate.Text
    '            dr!salestrategy = label123.Text
    '            dr!status = True




    '            '''''''''''''''''''''''''''''''' الوحدات '''''''''''''''''''''''''
    '            dr!FirstUnit = FirstUnit.Text
    '            dr!FirstUnitBarcode = FirstUnitBarcode.Text



    '            dr!SecondUnit = SecondUnit.Text
    '            dr!SecondUnitBarcode = SecondUnitBarcode.Text
    '            dr!SecondUnitOperatingConvert = Val(SecondUnitOperatingConvert.Text)


    '            dr!ThirdUnit = ThirdUnit.Text
    '            dr!ThirdUnitBarcode = ThirdUnitBarcode.Text
    '            dr!ThirdUnitOperatingConvert = Val(ThirdUnitOperatingConvert.Text)


    '            '===================== خيارات الحدود=============== 
    '            dr!MaxLimitForFirstUnit = (MaxLimitForFirstUnit.Text)
    '            dr!MinLimitForFirstUnit = Val(MinLimitForFirstUnit.Text)
    '            dr!OrderLimitForFirstUnit = Val(OrderLimitForFirstUnit.Text)


    '            dr!MaxLimitForSecondUnit = Val(MaxLimitForSecondUnit.Text)
    '            dr!MinLimitForSecondUnit = Val(MinLimitForSecondUnit.Text)
    '            dr!OrderLimitForSecondUnit = Val(OrderLimitForSecondUnit.Text)




    '            dr!MaxLimitForThirdUnit = Val(MaxLimitForThirdUnit.Text)
    '            dr!MinLimitForThirdUnit = Val(MinLimitForThirdUnit.Text)
    '            dr!OrderLimitForThirdUnit = Val(OrderLimitForThirdUnit.Text)


    '            If unitdef1.Checked = True Then dr!unitdefault = 1 'اكواد الافتراضي في الوحدات
    '            If unitdef2.Checked = True Then dr!unitdefault = 2
    '            If unitdef3.Checked = True Then dr!unitdefault = 3


    '            '================ أسعار البيع===================
    '            Dim tableName As String = ""
    '            Dim flg As Boolean = False
    '            If salestrategy.SelectedIndex = 0 Then tableName = "ItemNormalPrices"
    '            If salestrategy.SelectedIndex = 1 Then tableName = "ItemSeasonalPrices"
    '            '===============================================================
    '            Dim STR1 = "select * from " & tableName & "where ItemCode=N'" & itemcode.Text.Trim & "'"
    '            Dim adp1 = New SqlClient.SqlDataAdapter(STR1, SQlconn)
    '            Dim Ds1 = New DataSet
    '            adp1.Fill(Ds1)
    '            Dim Dt1 As DataTable
    '            Dt1 = Ds1.Tables(0)
    '            Dim dr1 As DataRow
    '            If Dt1.Rows.Count = 0 Then
    '                dr1 = Dt1.NewRow
    '                flg = False
    '            Else
    '                dr1 = Dt1.Rows(0)
    '                flg = True

    '            End If

    '            dr1!ItemCode = itemcode.Text
    '            dr1!WholeSealForFirstUnit = Val(WholeSaleForFirstUnit.Text)
    '            dr1!WholeSealForSecondUnit = Val(WholeSaleForSecondUnit.Text)
    '            dr1!WholeSaleForThirdUnit = Val(WholeSaleForThirdUnit.Text)
    '            dr1!HalfWholeSaleForFirstUnit = Val(HalfWholeSaleForFirstUnit.Text)
    '            dr1!HalfWholeSaleForSecondUnit = Val(HalfWholeSaleForSecondUnit.Text)
    '            dr1!HalfWholeSaleForThirdUnit = Val(HalfWholeSaleForFirstUnit.Text)
    '            dr1!DestributorForFirstUnit = Val(DestributorForFirstUnit.Text)
    '            dr1!DestributorForSecondUnit = Val(DestributorForThirdUnit.Text)
    '            dr1!DestributorForThirdUnit = Val(DestributorForThirdUnit.Text)
    '            dr1!ExportSaleForFirstUnit = Val(ExportSaleForFirstUnit.Text)
    '            dr1!ExportSaleForSecondUnit = Val(ExportSaleForSecondUnit.Text)
    '            dr1!ExportSaleForThirdUnit = Val(ExportSaleForThirdUnit.Text)
    '            dr1!EndUserSaleForFirstUnit = Val(ExportSaleForSecondUnit.Text)
    '            dr1!EndUserSaleForSecondUnit = Val(EndUserSaleForSecondUnit.Text)
    '            dr1!EndUserSaleForThirdUnit = Val(EndUserSaleForThirdUnit.Text)
    '            dr1!RetailSaleForFirstUnit = Val(RetailSaleForFirstUnit.Text)
    '            dr1!RetailSaleForSecondUnit = Val(RetailSaleForSecondUnit.Text)
    '            dr1!RetailSaleForThirdUnit = Val(RetailSaleForThirdUnit.Text)
    '            dr1!Amanufacturing = Amanufacturing.Checked

    '            If salestrategy.SelectedIndex = 1 Then
    '                dr1!FromDate = FromDate.Value
    '                dr1!ToDate = ToDate.Value

    '            End If
    '            If PriceDefault1.Checked = True Then dr1!PriceDefault1 = 1
    '            If PriceDefault2.Checked = True Then dr1!PriceDefault1 = 2
    '            If PriceDefault3.Checked = True Then dr1!PriceDefault1 = 3
    '            If PriceDefault4.Checked = True Then dr1!PriceDefault1 = 4
    '            If PriceDefault5.Checked = True Then dr1!PriceDefault1 = 5
    '            If PriceDefault6.Checked = True Then dr1!PriceDefault1 = 6


    '            If flg = False Then Dt1.Rows.Add(dr)
    '            Dim cmd1 As New SqlClient.SqlCommandBuilder(adp1)
    '            adp1.Update(Dt1)
    '            'If FillPriceData(salestrategy.SelectedIndex) = False Then
    '            'MsgBox("فشل في عملية التعديل يرجى المحاولة لاحقا", MsgBoxStyle.Critical, "خطأ")
    '            'End If
    '            'Exit Try
    '            'End If
    '            '========================تشفير الصورة ======================
    '            If OpenFileDialog1.FileName <= "" Then
    '                Dim imgBayteArray() As Byte
    '                Dim stream As New MemoryStream
    '                PicItem.Image.Save(stream, ImageFormat.Jpeg)
    '                imgBayteArray = stream.ToArray
    '                stream.Close()
    '                dr!PicItem = imgBayteArray

    '            End If
    '            dt.Rows.Add(dr)
    '            Dim cmd As New SqlClient.SqlCommandBuilder(adp)
    '            adp.Update(dt)
    '            MsgBox("تم تعديل بيانات الصنف في قاعدة البيانات بنجاح ", MsgBoxStyle.Information, "رسالة تأكيد")
    '        End If

    '    Catch ex As Exception
    '        MessageBox.Show(ex.Message, "فشل في عملية التعديل", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly)



    '    End Try

    'End Sub




    Private Sub btnsearch_Click(sender As System.Object, e As System.EventArgs) Handles btnsearch.Click
        SearchItems.ShowDialog()
    End Sub
End Class

