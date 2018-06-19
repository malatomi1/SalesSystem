<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmSupliers
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
        Me.Label8 = New System.Windows.Forms.Label()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.SupGroupBoxٍ2 = New System.Windows.Forms.GroupBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Status = New System.Windows.Forms.TextBox()
        Me.Balance = New System.Windows.Forms.TextBox()
        Me.Debit = New System.Windows.Forms.TextBox()
        Me.Credit = New System.Windows.Forms.TextBox()
        Me.Sup_image = New System.Windows.Forms.PictureBox()
        Me.SupCode = New System.Windows.Forms.TextBox()
        Me.Mobile = New System.Windows.Forms.TextBox()
        Me.Email = New System.Windows.Forms.TextBox()
        Me.Facebook = New System.Windows.Forms.TextBox()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.supbtnsearch = New System.Windows.Forms.Button()
        Me.supbtndelet = New System.Windows.Forms.Button()
        Me.supbtnedit = New System.Windows.Forms.Button()
        Me.supbtnsave = New System.Windows.Forms.Button()
        Me.Fax = New System.Windows.Forms.TextBox()
        Me.supbtnew = New System.Windows.Forms.Button()
        Me.Note = New System.Windows.Forms.TextBox()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Address = New System.Windows.Forms.TextBox()
        Me.SupName = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.City = New System.Windows.Forms.ComboBox()
        Me.Country = New System.Windows.Forms.ComboBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SupGroupBoxٍ2.SuspendLayout()
        CType(Me.Sup_image, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(58, 110)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(75, 16)
        Me.Label8.TabIndex = 3
        Me.Label8.Text = "ادراج صورة" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'SupGroupBoxٍ2
        '
        Me.SupGroupBoxٍ2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.SupGroupBoxٍ2.Controls.Add(Me.Label10)
        Me.SupGroupBoxٍ2.Controls.Add(Me.Label11)
        Me.SupGroupBoxٍ2.Controls.Add(Me.Label13)
        Me.SupGroupBoxٍ2.Controls.Add(Me.Label12)
        Me.SupGroupBoxٍ2.Controls.Add(Me.Status)
        Me.SupGroupBoxٍ2.Controls.Add(Me.Balance)
        Me.SupGroupBoxٍ2.Controls.Add(Me.Debit)
        Me.SupGroupBoxٍ2.Controls.Add(Me.Credit)
        Me.SupGroupBoxٍ2.Location = New System.Drawing.Point(100, 348)
        Me.SupGroupBoxٍ2.Name = "SupGroupBoxٍ2"
        Me.SupGroupBoxٍ2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.SupGroupBoxٍ2.Size = New System.Drawing.Size(694, 107)
        Me.SupGroupBoxٍ2.TabIndex = 5
        Me.SupGroupBoxٍ2.TabStop = False
        Me.SupGroupBoxٍ2.Text = "حركة رصيد المورد"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(590, 56)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(72, 13)
        Me.Label10.TabIndex = 0
        Me.Label10.Text = " حركة مدين  "
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(434, 56)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(60, 13)
        Me.Label11.TabIndex = 0
        Me.Label11.Text = "حركة دائن"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Black
        Me.Label13.Location = New System.Drawing.Point(293, 56)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(41, 13)
        Me.Label13.TabIndex = 0
        Me.Label13.Text = "الرصيد"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Black
        Me.Label12.Location = New System.Drawing.Point(136, 56)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(38, 13)
        Me.Label12.TabIndex = 0
        Me.Label12.Text = "الحالة"
        '
        'Status
        '
        Me.Status.Location = New System.Drawing.Point(38, 56)
        Me.Status.Name = "Status"
        Me.Status.Size = New System.Drawing.Size(92, 20)
        Me.Status.TabIndex = 1
        '
        'Balance
        '
        Me.Balance.Location = New System.Drawing.Point(195, 56)
        Me.Balance.Name = "Balance"
        Me.Balance.Size = New System.Drawing.Size(92, 20)
        Me.Balance.TabIndex = 1
        '
        'Debit
        '
        Me.Debit.Location = New System.Drawing.Point(343, 53)
        Me.Debit.Name = "Debit"
        Me.Debit.Size = New System.Drawing.Size(82, 20)
        Me.Debit.TabIndex = 1
        '
        'Credit
        '
        Me.Credit.Location = New System.Drawing.Point(492, 53)
        Me.Credit.Name = "Credit"
        Me.Credit.Size = New System.Drawing.Size(92, 20)
        Me.Credit.TabIndex = 1
        '
        'Sup_image
        '
        Me.Sup_image.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Sup_image.Location = New System.Drawing.Point(6, 12)
        Me.Sup_image.Name = "Sup_image"
        Me.Sup_image.Size = New System.Drawing.Size(183, 217)
        Me.Sup_image.TabIndex = 2
        Me.Sup_image.TabStop = False
        '
        'SupCode
        '
        Me.SupCode.Location = New System.Drawing.Point(434, 20)
        Me.SupCode.Name = "SupCode"
        Me.SupCode.Size = New System.Drawing.Size(165, 20)
        Me.SupCode.TabIndex = 1
        '
        'Mobile
        '
        Me.Mobile.Location = New System.Drawing.Point(206, 149)
        Me.Mobile.Name = "Mobile"
        Me.Mobile.Size = New System.Drawing.Size(165, 20)
        Me.Mobile.TabIndex = 1
        '
        'Email
        '
        Me.Email.Location = New System.Drawing.Point(434, 182)
        Me.Email.Name = "Email"
        Me.Email.Size = New System.Drawing.Size(165, 20)
        Me.Email.TabIndex = 1
        '
        'Facebook
        '
        Me.Facebook.Location = New System.Drawing.Point(206, 187)
        Me.Facebook.Name = "Facebook"
        Me.Facebook.Size = New System.Drawing.Size(165, 20)
        Me.Facebook.TabIndex = 1
        '
        'Button7
        '
        Me.Button7.Location = New System.Drawing.Point(8, 327)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(75, 23)
        Me.Button7.TabIndex = 12
        Me.Button7.Text = "إغلاق"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(8, 281)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(75, 23)
        Me.Button6.TabIndex = 10
        Me.Button6.Text = "تعليمات "
        Me.Button6.UseVisualStyleBackColor = True
        '
        'supbtnsearch
        '
        Me.supbtnsearch.Location = New System.Drawing.Point(8, 233)
        Me.supbtnsearch.Name = "supbtnsearch"
        Me.supbtnsearch.Size = New System.Drawing.Size(75, 23)
        Me.supbtnsearch.TabIndex = 9
        Me.supbtnsearch.Text = "بحث"
        Me.supbtnsearch.UseVisualStyleBackColor = True
        '
        'supbtndelet
        '
        Me.supbtndelet.Location = New System.Drawing.Point(8, 188)
        Me.supbtndelet.Name = "supbtndelet"
        Me.supbtndelet.Size = New System.Drawing.Size(75, 23)
        Me.supbtndelet.TabIndex = 8
        Me.supbtndelet.Text = "حذف"
        Me.supbtndelet.UseVisualStyleBackColor = True
        '
        'supbtnedit
        '
        Me.supbtnedit.Location = New System.Drawing.Point(8, 141)
        Me.supbtnedit.Name = "supbtnedit"
        Me.supbtnedit.Size = New System.Drawing.Size(75, 23)
        Me.supbtnedit.TabIndex = 11
        Me.supbtnedit.Text = "تعديل"
        Me.supbtnedit.UseVisualStyleBackColor = True
        '
        'supbtnsave
        '
        Me.supbtnsave.Location = New System.Drawing.Point(8, 95)
        Me.supbtnsave.Name = "supbtnsave"
        Me.supbtnsave.Size = New System.Drawing.Size(75, 23)
        Me.supbtnsave.TabIndex = 6
        Me.supbtnsave.Text = "حفظ"
        Me.supbtnsave.UseVisualStyleBackColor = True
        '
        'Fax
        '
        Me.Fax.Location = New System.Drawing.Point(434, 152)
        Me.Fax.Name = "Fax"
        Me.Fax.Size = New System.Drawing.Size(165, 20)
        Me.Fax.TabIndex = 1
        '
        'supbtnew
        '
        Me.supbtnew.Location = New System.Drawing.Point(8, 58)
        Me.supbtnew.Name = "supbtnew"
        Me.supbtnew.Size = New System.Drawing.Size(75, 23)
        Me.supbtnew.TabIndex = 7
        Me.supbtnew.Text = "جديد"
        Me.supbtnew.UseVisualStyleBackColor = True
        '
        'Note
        '
        Me.Note.Location = New System.Drawing.Point(24, 235)
        Me.Note.Name = "Note"
        Me.Note.Size = New System.Drawing.Size(587, 20)
        Me.Note.TabIndex = 1
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(359, 113)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(43, 13)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "المدينة"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(621, 235)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(53, 13)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "ملاحظات"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(598, 185)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(78, 13)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "بريد إلكتروني"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(605, 152)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(69, 13)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "رقم الفاكس"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(629, 117)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(38, 13)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "الدولة"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(617, 85)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(47, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = " العنوان"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(596, 49)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "اسم المورد"
        '
        'Address
        '
        Me.Address.Location = New System.Drawing.Point(206, 78)
        Me.Address.Name = "Address"
        Me.Address.Size = New System.Drawing.Size(405, 20)
        Me.Address.TabIndex = 1
        '
        'SupName
        '
        Me.SupName.Location = New System.Drawing.Point(206, 46)
        Me.SupName.Name = "SupName"
        Me.SupName.Size = New System.Drawing.Size(387, 20)
        Me.SupName.TabIndex = 1
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.Black
        Me.Label17.Location = New System.Drawing.Point(372, 185)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(63, 13)
        Me.Label17.TabIndex = 0
        Me.Label17.Text = "الفيس بوك"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.Black
        Me.Label16.Location = New System.Drawing.Point(376, 152)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(63, 13)
        Me.Label16.TabIndex = 0
        Me.Label16.Text = "رقم الهاتف"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(599, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "رمز المورد"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.White
        Me.GroupBox1.Controls.Add(Me.City)
        Me.GroupBox1.Controls.Add(Me.Country)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Sup_image)
        Me.GroupBox1.Controls.Add(Me.SupCode)
        Me.GroupBox1.Controls.Add(Me.Mobile)
        Me.GroupBox1.Controls.Add(Me.Facebook)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.Email)
        Me.GroupBox1.Controls.Add(Me.Fax)
        Me.GroupBox1.Controls.Add(Me.Note)
        Me.GroupBox1.Controls.Add(Me.Address)
        Me.GroupBox1.Controls.Add(Me.SupName)
        Me.GroupBox1.Controls.Add(Me.Label17)
        Me.GroupBox1.Controls.Add(Me.Label16)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(100, 46)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.GroupBox1.Size = New System.Drawing.Size(687, 273)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "شاشة بيانات المورد"
        '
        'City
        '
        Me.City.FormattingEnabled = True
        Me.City.Location = New System.Drawing.Point(195, 110)
        Me.City.Name = "City"
        Me.City.Size = New System.Drawing.Size(158, 21)
        Me.City.TabIndex = 4
        '
        'Country
        '
        Me.Country.FormattingEnabled = True
        Me.Country.Items.AddRange(New Object() {"اليمن", "السودان", "مصر"})
        Me.Country.Location = New System.Drawing.Point(463, 110)
        Me.Country.Name = "Country"
        Me.Country.Size = New System.Drawing.Size(150, 21)
        Me.Country.TabIndex = 4
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(424, 104)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(33, 27)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "..."
        Me.ToolTip1.SetToolTip(Me.Button1, "إضافة دولة جديدة")
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ToolTip1
        '
        Me.ToolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.ToolTip1.ToolTipTitle = "مساعدة"
        '
        'FrmSupliers
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(803, 500)
        Me.Controls.Add(Me.SupGroupBoxٍ2)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.supbtnsearch)
        Me.Controls.Add(Me.supbtndelet)
        Me.Controls.Add(Me.supbtnedit)
        Me.Controls.Add(Me.supbtnsave)
        Me.Controls.Add(Me.supbtnew)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "FrmSupliers"
        Me.Text = "FrmSupliers"
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SupGroupBoxٍ2.ResumeLayout(False)
        Me.SupGroupBoxٍ2.PerformLayout()
        CType(Me.Sup_image, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents SupGroupBoxٍ2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Status As System.Windows.Forms.TextBox
    Friend WithEvents Balance As System.Windows.Forms.TextBox
    Friend WithEvents Debit As System.Windows.Forms.TextBox
    Friend WithEvents Credit As System.Windows.Forms.TextBox
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents supbtnsearch As System.Windows.Forms.Button
    Friend WithEvents supbtndelet As System.Windows.Forms.Button
    Friend WithEvents supbtnedit As System.Windows.Forms.Button
    Friend WithEvents supbtnsave As System.Windows.Forms.Button
    Friend WithEvents supbtnew As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Sup_image As System.Windows.Forms.PictureBox
    Friend WithEvents SupCode As System.Windows.Forms.TextBox
    Friend WithEvents Mobile As System.Windows.Forms.TextBox
    Friend WithEvents Facebook As System.Windows.Forms.TextBox
    Friend WithEvents Email As System.Windows.Forms.TextBox
    Friend WithEvents Fax As System.Windows.Forms.TextBox
    Friend WithEvents Note As System.Windows.Forms.TextBox
    Friend WithEvents Address As System.Windows.Forms.TextBox
    Friend WithEvents SupName As System.Windows.Forms.TextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents City As System.Windows.Forms.ComboBox
    Friend WithEvents Country As System.Windows.Forms.ComboBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
End Class
