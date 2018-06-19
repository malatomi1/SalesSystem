<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frmcustomers
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Cust_image = New System.Windows.Forms.PictureBox()
        Me.CustomerCode = New System.Windows.Forms.TextBox()
        Me.Mobile = New System.Windows.Forms.TextBox()
        Me.Facebook = New System.Windows.Forms.TextBox()
        Me.Email = New System.Windows.Forms.TextBox()
        Me.Fax = New System.Windows.Forms.TextBox()
        Me.Country = New System.Windows.Forms.TextBox()
        Me.Note = New System.Windows.Forms.TextBox()
        Me.Address = New System.Windows.Forms.TextBox()
        Me.CustomerName = New System.Windows.Forms.TextBox()
        Me.City = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Status = New System.Windows.Forms.TextBox()
        Me.Balance = New System.Windows.Forms.TextBox()
        Me.Credit = New System.Windows.Forms.TextBox()
        Me.Debit = New System.Windows.Forms.TextBox()
        Me.btnnew = New System.Windows.Forms.Button()
        Me.btnsave = New System.Windows.Forms.Button()
        Me.btnedit = New System.Windows.Forms.Button()
        Me.btndelet = New System.Windows.Forms.Button()
        Me.btnsearch = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.GroupBox1.SuspendLayout()
        CType(Me.Cust_image, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(599, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(62, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "رمز العميل"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(596, 49)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(71, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = " اسم العميل"
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
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(617, 117)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(38, 13)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "الدولة"
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
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(376, 117)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(43, 13)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "المدينة"
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
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.White
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Cust_image)
        Me.GroupBox1.Controls.Add(Me.CustomerCode)
        Me.GroupBox1.Controls.Add(Me.Mobile)
        Me.GroupBox1.Controls.Add(Me.Facebook)
        Me.GroupBox1.Controls.Add(Me.Email)
        Me.GroupBox1.Controls.Add(Me.Fax)
        Me.GroupBox1.Controls.Add(Me.Country)
        Me.GroupBox1.Controls.Add(Me.Note)
        Me.GroupBox1.Controls.Add(Me.Address)
        Me.GroupBox1.Controls.Add(Me.CustomerName)
        Me.GroupBox1.Controls.Add(Me.City)
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
        Me.GroupBox1.Location = New System.Drawing.Point(118, 41)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.GroupBox1.Size = New System.Drawing.Size(687, 273)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "شاشة بيانات العميل"
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
        'Cust_image
        '
        Me.Cust_image.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Cust_image.Location = New System.Drawing.Point(6, 12)
        Me.Cust_image.Name = "Cust_image"
        Me.Cust_image.Size = New System.Drawing.Size(183, 217)
        Me.Cust_image.TabIndex = 2
        Me.Cust_image.TabStop = False
        '
        'CustomerCode
        '
        Me.CustomerCode.Location = New System.Drawing.Point(434, 20)
        Me.CustomerCode.Name = "CustomerCode"
        Me.CustomerCode.Size = New System.Drawing.Size(165, 20)
        Me.CustomerCode.TabIndex = 1
        '
        'Mobile
        '
        Me.Mobile.Location = New System.Drawing.Point(206, 149)
        Me.Mobile.Name = "Mobile"
        Me.Mobile.Size = New System.Drawing.Size(165, 20)
        Me.Mobile.TabIndex = 1
        '
        'Facebook
        '
        Me.Facebook.Location = New System.Drawing.Point(206, 187)
        Me.Facebook.Name = "Facebook"
        Me.Facebook.Size = New System.Drawing.Size(165, 20)
        Me.Facebook.TabIndex = 1
        '
        'Email
        '
        Me.Email.Location = New System.Drawing.Point(434, 182)
        Me.Email.Name = "Email"
        Me.Email.Size = New System.Drawing.Size(165, 20)
        Me.Email.TabIndex = 1
        '
        'Fax
        '
        Me.Fax.Location = New System.Drawing.Point(434, 152)
        Me.Fax.Name = "Fax"
        Me.Fax.Size = New System.Drawing.Size(165, 20)
        Me.Fax.TabIndex = 1
        '
        'Country
        '
        Me.Country.Location = New System.Drawing.Point(434, 117)
        Me.Country.Name = "Country"
        Me.Country.Size = New System.Drawing.Size(177, 20)
        Me.Country.TabIndex = 1
        '
        'Note
        '
        Me.Note.Location = New System.Drawing.Point(24, 235)
        Me.Note.Name = "Note"
        Me.Note.Size = New System.Drawing.Size(587, 20)
        Me.Note.TabIndex = 1
        '
        'Address
        '
        Me.Address.Location = New System.Drawing.Point(206, 78)
        Me.Address.Name = "Address"
        Me.Address.Size = New System.Drawing.Size(405, 20)
        Me.Address.TabIndex = 1
        '
        'CustomerName
        '
        Me.CustomerName.Location = New System.Drawing.Point(206, 46)
        Me.CustomerName.Name = "CustomerName"
        Me.CustomerName.Size = New System.Drawing.Size(387, 20)
        Me.CustomerName.TabIndex = 1
        '
        'City
        '
        Me.City.Location = New System.Drawing.Point(237, 110)
        Me.City.Name = "City"
        Me.City.Size = New System.Drawing.Size(133, 20)
        Me.City.TabIndex = 1
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
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.Status)
        Me.GroupBox2.Controls.Add(Me.Balance)
        Me.GroupBox2.Controls.Add(Me.Credit)
        Me.GroupBox2.Controls.Add(Me.Debit)
        Me.GroupBox2.Location = New System.Drawing.Point(118, 343)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.GroupBox2.Size = New System.Drawing.Size(694, 107)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "حركة رصيد العميل"
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
        'Credit
        '
        Me.Credit.Location = New System.Drawing.Point(343, 53)
        Me.Credit.Name = "Credit"
        Me.Credit.Size = New System.Drawing.Size(82, 20)
        Me.Credit.TabIndex = 1
        '
        'Debit
        '
        Me.Debit.Location = New System.Drawing.Point(492, 53)
        Me.Debit.Name = "Debit"
        Me.Debit.Size = New System.Drawing.Size(92, 20)
        Me.Debit.TabIndex = 1
        '
        'btnnew
        '
        Me.btnnew.Location = New System.Drawing.Point(26, 53)
        Me.btnnew.Name = "btnnew"
        Me.btnnew.Size = New System.Drawing.Size(75, 23)
        Me.btnnew.TabIndex = 3
        Me.btnnew.Text = "جديد"
        Me.btnnew.UseVisualStyleBackColor = True
        '
        'btnsave
        '
        Me.btnsave.Location = New System.Drawing.Point(26, 90)
        Me.btnsave.Name = "btnsave"
        Me.btnsave.Size = New System.Drawing.Size(75, 23)
        Me.btnsave.TabIndex = 3
        Me.btnsave.Text = "حفظ"
        Me.btnsave.UseVisualStyleBackColor = True
        '
        'btnedit
        '
        Me.btnedit.Location = New System.Drawing.Point(26, 136)
        Me.btnedit.Name = "btnedit"
        Me.btnedit.Size = New System.Drawing.Size(75, 23)
        Me.btnedit.TabIndex = 3
        Me.btnedit.Text = "تعديل"
        Me.btnedit.UseVisualStyleBackColor = True
        '
        'btndelet
        '
        Me.btndelet.Location = New System.Drawing.Point(26, 183)
        Me.btndelet.Name = "btndelet"
        Me.btndelet.Size = New System.Drawing.Size(75, 23)
        Me.btndelet.TabIndex = 3
        Me.btndelet.Text = "حذف"
        Me.btndelet.UseVisualStyleBackColor = True
        '
        'btnsearch
        '
        Me.btnsearch.Location = New System.Drawing.Point(26, 228)
        Me.btnsearch.Name = "btnsearch"
        Me.btnsearch.Size = New System.Drawing.Size(75, 23)
        Me.btnsearch.TabIndex = 3
        Me.btnsearch.Text = "بحث"
        Me.btnsearch.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(26, 276)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(75, 23)
        Me.Button6.TabIndex = 3
        Me.Button6.Text = "تعليمات "
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.Location = New System.Drawing.Point(26, 322)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(75, 23)
        Me.Button7.TabIndex = 3
        Me.Button7.Text = "إغلاق"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Frmcustomers
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Violet
        Me.ClientSize = New System.Drawing.Size(822, 462)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.btnsearch)
        Me.Controls.Add(Me.btndelet)
        Me.Controls.Add(Me.btnedit)
        Me.Controls.Add(Me.btnsave)
        Me.Controls.Add(Me.btnnew)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.ForeColor = System.Drawing.Color.Blue
        Me.Name = "Frmcustomers"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Text = "منظومة البراء للمبيعات"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.Cust_image, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents CustomerCode As System.Windows.Forms.TextBox
    Friend WithEvents Mobile As System.Windows.Forms.TextBox
    Friend WithEvents Facebook As System.Windows.Forms.TextBox
    Friend WithEvents Email As System.Windows.Forms.TextBox
    Friend WithEvents Fax As System.Windows.Forms.TextBox
    Friend WithEvents Country As System.Windows.Forms.TextBox
    Friend WithEvents Address As System.Windows.Forms.TextBox
    Friend WithEvents CustomerName As System.Windows.Forms.TextBox
    Friend WithEvents City As System.Windows.Forms.TextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Note As System.Windows.Forms.TextBox
    Friend WithEvents Debit As System.Windows.Forms.TextBox
    Friend WithEvents Status As System.Windows.Forms.TextBox
    Friend WithEvents Balance As System.Windows.Forms.TextBox
    Friend WithEvents Credit As System.Windows.Forms.TextBox
    Friend WithEvents btnnew As System.Windows.Forms.Button
    Friend WithEvents btnsave As System.Windows.Forms.Button
    Friend WithEvents btnedit As System.Windows.Forms.Button
    Friend WithEvents btndelet As System.Windows.Forms.Button
    Friend WithEvents btnsearch As System.Windows.Forms.Button
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Cust_image As System.Windows.Forms.PictureBox
End Class
