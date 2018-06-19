Public Class FrmReceptionItems

    Private Sub FrmReceptionItems_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Button2_Click(Nothing, Nothing) ' توليد كود رقم السند اول مايحمل اللود استدعاء كود الجديد
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        VoucherCode.Text = Format(GET_LAST_RECORD("ReceiptOfItems", "Voucherid") + 1, "ROF000000") ' كود توليد الرقم في جديد وبعدين نضيفه في اللود  الخاص بالفورم 
    End Sub
    Private Sub showsuppliers_Click(sender As System.Object, e As System.EventArgs) Handles showsuppliers.Click
        FrmSupliers.ShowDialog() ' ربط بوتون اسم المورد بشاشة الموردين
    End Sub

    Sub FillSupplierName() ' تعبة كومبو بوكس اسم المورد من شاشة الموردين
        SupplierName.Items.Clear() ' وهذا الاجراء  يتم ربطه في حدث الدروب داون في الكوموبو بوكس
        Dim adp As New SqlClient.SqlDataAdapter("select * from Suppliers order by SupName", SQlconn)
        Dim ds As New DataSet
        adp.Fill(ds)
        Dim dt = ds.Tables(0)
        '=======================================================================================
        For I = 0 To dt.Rows.Count - 1
            SupplierName.Items.Add(dt.Rows(I).Item("SupName")) ' تعبة كومبو بوكس اسم المورد من شاشة الموردين

        Next
    End Sub

    Private Sub SupplierName_DropDown(sender As Object, e As System.EventArgs) Handles SupplierName.DropDown
        FillSupplierName() ' استدعاء الاجراء الذي يقوم بتعبئة كومبو بوكس باسماء الموردين من جدول الموردين
    End Sub

    Private Sub btnsave_Click(sender As System.Object, e As System.EventArgs) Handles btnsave.Click
        If SupplierName.SelectedIndex < 0 Then ' اسم المورد يجب ان يكون موجود 
            ErrorProvider1.SetError(Label6, "يجب اختيار المورد من القائمة")

            Exit Sub
        End If
        If Format(SupplierInvoiceDate.Value, "yyyy/MM/dd") < Format(VoucherDate.Value, "yyyy/MM/dd") Then
            MsgBox("تاريخ سند استلام المواد أكبر من تاريخ فاتورة المورد", MsgBoxStyle.Critical, "خطأ")
            Exit Sub
        End If
        Try       ' البحث عن سجل بدلالة رقم السند تفاديا للتكرار في حال كان هناك اكثر من موظف على نفس الشبكة 
            Dim sql = "select * from ReceiptOfItems where VoucherCode=N'" & (VoucherCode.Text) & "'"  ' نبحث عن رقم السجل
            Dim adp As New SqlClient.SqlDataAdapter(sql, SQlconn)    ' بعد عملية التصفية لو الرقم موجود نروح نولد رقم  جديد
            Dim ds As New DataSet
            adp.Fill(ds)
            Dim dt = ds.Tables(0)
            If dt.Rows.Count > 0 Then
                VoucherCode.Text = Format(GET_LAST_RECORD("ReceiptOfItems", "Voucherid") = 1, "RFO000000")
            Else ' فيما عدا ذلك استمر في عملية الاضافة كمايلي
                Dim dr = dt.NewRow
                dr!VoucherCode = VoucherCode.Text
                dr!VoucherDate = VoucherDate.Value
                dr!SalesTax = Val(TotalDiscount.Text)
                'dr!Ordercode = Ordercode.Text
                'dr!SupplierCode = SupplierCode.Text
                dr!Note = Note.Text
                dr!SupplierInvoicetype = SupplierInvoicetype.Text
                dr!SupplierInvoiceCode = SupplierInvoiceCode.Text
                dr!TotalDiscount = Val(TotalDiscount.Text)
                dr!TotalVoucher = Val(TotalVoucher.Text)
                dr!TotalByArabic = TotalByArabic.Text
                dt.Rows.Add(dr)
                Dim cmd As New SqlClient.SqlCommandBuilder(adp)
                adp.Update(dt)





            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub InsertItem_Click(sender As System.Object, e As System.EventArgs) Handles InsertItem.Click
        SearchItems.ShowDialog()
    End Sub

    Private Sub InsertItem_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles InsertItem.KeyDown
        If e.KeyCode = Keys.F2 Then
            SearchItems.ShowDialog()

        End If
    End Sub
End Class