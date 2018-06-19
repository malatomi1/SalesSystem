<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCategorization
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
        Me.CatName = New System.Windows.Forms.TextBox()
        Me.CatCode = New System.Windows.Forms.TextBox()
        Me.Note = New System.Windows.Forms.TextBox()
        Me.btnclose = New System.Windows.Forms.Button()
        Me.btncatsearch = New System.Windows.Forms.Button()
        Me.btncatdelet = New System.Windows.Forms.Button()
        Me.btncatedit = New System.Windows.Forms.Button()
        Me.btncatsav = New System.Windows.Forms.Button()
        Me.btncatnew = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Txtsearch = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'CatName
        '
        Me.CatName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CatName.Location = New System.Drawing.Point(112, 76)
        Me.CatName.MaxLength = 75
        Me.CatName.Name = "CatName"
        Me.CatName.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.CatName.Size = New System.Drawing.Size(187, 20)
        Me.CatName.TabIndex = 8
        '
        'CatCode
        '
        Me.CatCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CatCode.Location = New System.Drawing.Point(112, 42)
        Me.CatCode.MaxLength = 15
        Me.CatCode.Name = "CatCode"
        Me.CatCode.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.CatCode.Size = New System.Drawing.Size(187, 20)
        Me.CatCode.TabIndex = 8
        '
        'Note
        '
        Me.Note.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Note.Location = New System.Drawing.Point(112, 102)
        Me.Note.MaxLength = 255
        Me.Note.Multiline = True
        Me.Note.Name = "Note"
        Me.Note.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Note.Size = New System.Drawing.Size(218, 145)
        Me.Note.TabIndex = 18
        '
        'btnclose
        '
        Me.btnclose.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnclose.Location = New System.Drawing.Point(6, 251)
        Me.btnclose.Name = "btnclose"
        Me.btnclose.Size = New System.Drawing.Size(75, 40)
        Me.btnclose.TabIndex = 16
        Me.btnclose.Text = "إغلاق"
        Me.btnclose.UseVisualStyleBackColor = True
        '
        'btncatsearch
        '
        Me.btncatsearch.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncatsearch.Location = New System.Drawing.Point(6, 205)
        Me.btncatsearch.Name = "btncatsearch"
        Me.btncatsearch.Size = New System.Drawing.Size(75, 40)
        Me.btncatsearch.TabIndex = 17
        Me.btncatsearch.Text = "بحث"
        Me.btncatsearch.UseVisualStyleBackColor = True
        '
        'btncatdelet
        '
        Me.btncatdelet.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncatdelet.Location = New System.Drawing.Point(6, 163)
        Me.btncatdelet.Name = "btncatdelet"
        Me.btncatdelet.Size = New System.Drawing.Size(75, 36)
        Me.btncatdelet.TabIndex = 15
        Me.btncatdelet.Text = "حذف"
        Me.btncatdelet.UseVisualStyleBackColor = True
        '
        'btncatedit
        '
        Me.btncatedit.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncatedit.Location = New System.Drawing.Point(6, 119)
        Me.btncatedit.Name = "btncatedit"
        Me.btncatedit.Size = New System.Drawing.Size(75, 38)
        Me.btncatedit.TabIndex = 14
        Me.btncatedit.Text = "تعديل"
        Me.btncatedit.UseVisualStyleBackColor = True
        '
        'btncatsav
        '
        Me.btncatsav.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncatsav.Location = New System.Drawing.Point(6, 76)
        Me.btncatsav.Name = "btncatsav"
        Me.btncatsav.Size = New System.Drawing.Size(75, 37)
        Me.btncatsav.TabIndex = 13
        Me.btncatsav.Text = "حفظ"
        Me.btncatsav.UseVisualStyleBackColor = True
        '
        'btncatnew
        '
        Me.btncatnew.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncatnew.Location = New System.Drawing.Point(6, 31)
        Me.btncatnew.Name = "btncatnew"
        Me.btncatnew.Size = New System.Drawing.Size(75, 39)
        Me.btncatnew.TabIndex = 12
        Me.btncatnew.Text = "جديد"
        Me.btncatnew.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(336, 119)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(65, 14)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "ملاحظات :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(311, 43)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(90, 14)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "رمز التصنيف : "
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(319, 77)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(93, 14)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "اسم التصنيف :"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Note)
        Me.GroupBox1.Controls.Add(Me.btnclose)
        Me.GroupBox1.Controls.Add(Me.btncatsearch)
        Me.GroupBox1.Controls.Add(Me.btncatdelet)
        Me.GroupBox1.Controls.Add(Me.btncatedit)
        Me.GroupBox1.Controls.Add(Me.btncatsav)
        Me.GroupBox1.Controls.Add(Me.btncatnew)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.CatName)
        Me.GroupBox1.Controls.Add(Me.CatCode)
        Me.GroupBox1.Location = New System.Drawing.Point(24, 43)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(504, 337)
        Me.GroupBox1.TabIndex = 19
        Me.GroupBox1.TabStop = False
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4})
        Me.DataGridView1.Location = New System.Drawing.Point(53, 110)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(445, 224)
        Me.DataGridView1.TabIndex = 3
        '
        'Column1
        '
        Me.Column1.HeaderText = "اختر"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Column1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'Column2
        '
        Me.Column2.DataPropertyName = "CatCode"
        Me.Column2.HeaderText = "رمز التصنيف"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Width = 150
        '
        'Column3
        '
        Me.Column3.DataPropertyName = "CatName"
        Me.Column3.HeaderText = "اسم التصنيف"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        Me.Column3.Width = 150
        '
        'Column4
        '
        Me.Column4.DataPropertyName = "Note"
        Me.Column4.HeaderText = "ملاحظات"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        Me.Column4.Visible = False
        '
        'Txtsearch
        '
        Me.Txtsearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Txtsearch.Location = New System.Drawing.Point(53, 81)
        Me.Txtsearch.Name = "Txtsearch"
        Me.Txtsearch.Size = New System.Drawing.Size(286, 20)
        Me.Txtsearch.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(359, 87)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(142, 14)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "تصفية حسب التصنيف :"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Button1)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Txtsearch)
        Me.GroupBox2.Controls.Add(Me.DataGridView1)
        Me.GroupBox2.Location = New System.Drawing.Point(-7, -1)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(555, 415)
        Me.GroupBox2.TabIndex = 20
        Me.GroupBox2.TabStop = False
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(228, 340)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 40)
        Me.Button1.TabIndex = 17
        Me.Button1.Text = "إغلاق"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'FrmCategorization
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(540, 405)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "FrmCategorization"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Text = "FrmCategorization"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents CatName As System.Windows.Forms.TextBox
    Friend WithEvents CatCode As System.Windows.Forms.TextBox
    Friend WithEvents Note As System.Windows.Forms.TextBox
    Friend WithEvents btnclose As System.Windows.Forms.Button
    Friend WithEvents btncatsearch As System.Windows.Forms.Button
    Friend WithEvents btncatdelet As System.Windows.Forms.Button
    Friend WithEvents btncatedit As System.Windows.Forms.Button
    Friend WithEvents btncatsav As System.Windows.Forms.Button
    Friend WithEvents btncatnew As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Txtsearch As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
