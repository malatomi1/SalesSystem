<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmReceptionItems
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.showsuppliers = New System.Windows.Forms.Button()
        Me.SupplierInvoicetype = New System.Windows.Forms.ComboBox()
        Me.SupplierName = New System.Windows.Forms.ComboBox()
        Me.SupplierInvoiceDate = New System.Windows.Forms.DateTimePicker()
        Me.VoucherDate = New System.Windows.Forms.DateTimePicker()
        Me.Note = New System.Windows.Forms.TextBox()
        Me.SupplierInvoiceCode = New System.Windows.Forms.TextBox()
        Me.VoucherCode = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TotalDiscount = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.btnsave = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TotalByArabic = New System.Windows.Forms.TextBox()
        Me.TotalVoucher = New System.Windows.Forms.TextBox()
        Me.InsertItem = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.showsuppliers)
        Me.GroupBox1.Controls.Add(Me.SupplierInvoicetype)
        Me.GroupBox1.Controls.Add(Me.SupplierName)
        Me.GroupBox1.Controls.Add(Me.SupplierInvoiceDate)
        Me.GroupBox1.Controls.Add(Me.VoucherDate)
        Me.GroupBox1.Controls.Add(Me.Note)
        Me.GroupBox1.Controls.Add(Me.SupplierInvoiceCode)
        Me.GroupBox1.Controls.Add(Me.VoucherCode)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(106, 29)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.GroupBox1.Size = New System.Drawing.Size(1102, 182)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "بيانات أساسية"
        '
        'showsuppliers
        '
        Me.showsuppliers.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.showsuppliers.Location = New System.Drawing.Point(445, 68)
        Me.showsuppliers.Name = "showsuppliers"
        Me.showsuppliers.Size = New System.Drawing.Size(49, 36)
        Me.showsuppliers.TabIndex = 20
        Me.showsuppliers.Text = "+"
        Me.showsuppliers.UseVisualStyleBackColor = True
        '
        'SupplierInvoicetype
        '
        Me.SupplierInvoicetype.FormattingEnabled = True
        Me.SupplierInvoicetype.Items.AddRange(New Object() {"نقدي", "آجل"})
        Me.SupplierInvoicetype.Location = New System.Drawing.Point(199, 35)
        Me.SupplierInvoicetype.Name = "SupplierInvoicetype"
        Me.SupplierInvoicetype.Size = New System.Drawing.Size(121, 21)
        Me.SupplierInvoicetype.TabIndex = 18
        '
        'SupplierName
        '
        Me.SupplierName.FormattingEnabled = True
        Me.SupplierName.Location = New System.Drawing.Point(500, 73)
        Me.SupplierName.Name = "SupplierName"
        Me.SupplierName.Size = New System.Drawing.Size(121, 21)
        Me.SupplierName.TabIndex = 19
        '
        'SupplierInvoiceDate
        '
        Me.SupplierInvoiceDate.Location = New System.Drawing.Point(147, 75)
        Me.SupplierInvoiceDate.Name = "SupplierInvoiceDate"
        Me.SupplierInvoiceDate.Size = New System.Drawing.Size(173, 20)
        Me.SupplierInvoiceDate.TabIndex = 16
        '
        'VoucherDate
        '
        Me.VoucherDate.Location = New System.Drawing.Point(750, 70)
        Me.VoucherDate.Name = "VoucherDate"
        Me.VoucherDate.Size = New System.Drawing.Size(214, 20)
        Me.VoucherDate.TabIndex = 17
        '
        'Note
        '
        Me.Note.Location = New System.Drawing.Point(193, 135)
        Me.Note.Name = "Note"
        Me.Note.Size = New System.Drawing.Size(771, 20)
        Me.Note.TabIndex = 13
        '
        'SupplierInvoiceCode
        '
        Me.SupplierInvoiceCode.Location = New System.Drawing.Point(18, 36)
        Me.SupplierInvoiceCode.Name = "SupplierInvoiceCode"
        Me.SupplierInvoiceCode.Size = New System.Drawing.Size(60, 20)
        Me.SupplierInvoiceCode.TabIndex = 15
        '
        'VoucherCode
        '
        Me.VoucherCode.Location = New System.Drawing.Point(819, 37)
        Me.VoucherCode.Name = "VoucherCode"
        Me.VoucherCode.Size = New System.Drawing.Size(145, 20)
        Me.VoucherCode.TabIndex = 15
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(785, 104)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(28, 19)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "%"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(970, 136)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(88, 19)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "ملاحظات :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(970, 104)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(121, 19)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "ضريبة مبيعات :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(970, 70)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(107, 19)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "تاريخ  السند :"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(326, 75)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(113, 19)
        Me.Label8.TabIndex = 11
        Me.Label8.Text = "تاريخ الفاتورة :"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(87, 33)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(106, 19)
        Me.Label12.TabIndex = 12
        Me.Label12.Text = "رقم الفاتورة :"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(326, 35)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(103, 19)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "نوع الفاتورة :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(627, 71)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(104, 19)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "اسم المورد :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(970, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(95, 19)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "رقم السند :"
        '
        'TotalDiscount
        '
        Me.TotalDiscount.Location = New System.Drawing.Point(759, 24)
        Me.TotalDiscount.Name = "TotalDiscount"
        Me.TotalDiscount.Size = New System.Drawing.Size(141, 20)
        Me.TotalDiscount.TabIndex = 14
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.DataGridView1)
        Me.GroupBox2.Location = New System.Drawing.Point(180, 231)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.GroupBox2.Size = New System.Drawing.Size(977, 220)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "تفاصيل الأصناف"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6, Me.Column7, Me.Column8, Me.Column9})
        Me.DataGridView1.Location = New System.Drawing.Point(26, 41)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(945, 157)
        Me.DataGridView1.TabIndex = 0
        '
        'Column1
        '
        Me.Column1.HeaderText = "رمز الصنف"
        Me.Column1.Name = "Column1"
        '
        'Column2
        '
        Me.Column2.HeaderText = "اسم الصنف"
        Me.Column2.Name = "Column2"
        '
        'Column3
        '
        Me.Column3.HeaderText = "الوحدة"
        Me.Column3.Name = "Column3"
        '
        'Column4
        '
        Me.Column4.HeaderText = "سعر الوحدة"
        Me.Column4.Name = "Column4"
        '
        'Column5
        '
        Me.Column5.HeaderText = "الكمية"
        Me.Column5.Name = "Column5"
        '
        'Column6
        '
        Me.Column6.HeaderText = "الخصم"
        Me.Column6.Name = "Column6"
        '
        'Column7
        '
        Me.Column7.HeaderText = "إجمالي السعر"
        Me.Column7.Name = "Column7"
        '
        'Column8
        '
        Me.Column8.HeaderText = "+"
        Me.Column8.Name = "Column8"
        '
        'Column9
        '
        Me.Column9.HeaderText = "-"
        Me.Column9.Name = "Column9"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(12, 108)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 53)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "جديد"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'btnsave
        '
        Me.btnsave.Location = New System.Drawing.Point(12, 174)
        Me.btnsave.Name = "btnsave"
        Me.btnsave.Size = New System.Drawing.Size(75, 53)
        Me.btnsave.TabIndex = 1
        Me.btnsave.Text = "حفظ"
        Me.btnsave.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(12, 233)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(75, 53)
        Me.Button4.TabIndex = 1
        Me.Button4.Text = "تعديل"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(12, 292)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(75, 53)
        Me.Button5.TabIndex = 1
        Me.Button5.Text = "حذف"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(12, 351)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(75, 53)
        Me.Button6.TabIndex = 1
        Me.Button6.Text = "بحث"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.Location = New System.Drawing.Point(12, 49)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(75, 53)
        Me.Button7.TabIndex = 1
        Me.Button7.Text = "باركود"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Button8
        '
        Me.Button8.Location = New System.Drawing.Point(12, 409)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(75, 53)
        Me.Button8.TabIndex = 1
        Me.Button8.Text = "إغلاق"
        Me.Button8.UseVisualStyleBackColor = True
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label11)
        Me.GroupBox3.Controls.Add(Me.Label10)
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Controls.Add(Me.TotalByArabic)
        Me.GroupBox3.Controls.Add(Me.TotalVoucher)
        Me.GroupBox3.Controls.Add(Me.TotalDiscount)
        Me.GroupBox3.Location = New System.Drawing.Point(106, 474)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.GroupBox3.Size = New System.Drawing.Size(1045, 62)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "الإجماليات"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(331, 22)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(135, 19)
        Me.Label11.TabIndex = 10
        Me.Label11.Text = "القيمة بالحروف  :"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(620, 22)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(133, 19)
        Me.Label10.TabIndex = 9
        Me.Label10.Text = "اجمالي الفاتورة :"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(906, 22)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(129, 19)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "إجمالي الخصم :"
        '
        'TotalByArabic
        '
        Me.TotalByArabic.Location = New System.Drawing.Point(18, 24)
        Me.TotalByArabic.Name = "TotalByArabic"
        Me.TotalByArabic.Size = New System.Drawing.Size(315, 20)
        Me.TotalByArabic.TabIndex = 14
        '
        'TotalVoucher
        '
        Me.TotalVoucher.Location = New System.Drawing.Point(472, 24)
        Me.TotalVoucher.Name = "TotalVoucher"
        Me.TotalVoucher.Size = New System.Drawing.Size(142, 20)
        Me.TotalVoucher.TabIndex = 14
        '
        'InsertItem
        '
        Me.InsertItem.Location = New System.Drawing.Point(1157, 272)
        Me.InsertItem.Name = "InsertItem"
        Me.InsertItem.Size = New System.Drawing.Size(51, 157)
        Me.InsertItem.TabIndex = 4
        Me.InsertItem.Text = "+"
        Me.InsertItem.UseVisualStyleBackColor = True
        '
        'FrmReceptionItems
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1231, 548)
        Me.Controls.Add(Me.InsertItem)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.Button8)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.btnsave)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.KeyPreview = True
        Me.Name = "FrmReceptionItems"
        Me.Text = "FrmReceptionItems"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents showsuppliers As System.Windows.Forms.Button
    Friend WithEvents SupplierInvoicetype As System.Windows.Forms.ComboBox
    Friend WithEvents SupplierName As System.Windows.Forms.ComboBox
    Friend WithEvents SupplierInvoiceDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents VoucherDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Note As System.Windows.Forms.TextBox
    Friend WithEvents TotalDiscount As System.Windows.Forms.TextBox
    Friend WithEvents VoucherCode As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents btnsave As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents Button8 As System.Windows.Forms.Button
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents TotalByArabic As System.Windows.Forms.TextBox
    Friend WithEvents TotalVoucher As System.Windows.Forms.TextBox
    Friend WithEvents SupplierInvoiceCode As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents InsertItem As System.Windows.Forms.Button
End Class
