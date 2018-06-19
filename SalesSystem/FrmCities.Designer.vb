<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCities
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
        Me.Country = New System.Windows.Forms.ComboBox()
        Me.btnsaveci = New System.Windows.Forms.Button()
        Me.btnediteci = New System.Windows.Forms.Button()
        Me.btndeleteci = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CT_name = New System.Windows.Forms.TextBox()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'Country
        '
        Me.Country.FormattingEnabled = True
        Me.Country.Location = New System.Drawing.Point(38, 28)
        Me.Country.Name = "Country"
        Me.Country.Size = New System.Drawing.Size(189, 21)
        Me.Country.TabIndex = 0
        '
        'btnsaveci
        '
        Me.btnsaveci.Location = New System.Drawing.Point(249, 303)
        Me.btnsaveci.Name = "btnsaveci"
        Me.btnsaveci.Size = New System.Drawing.Size(83, 34)
        Me.btnsaveci.TabIndex = 1
        Me.btnsaveci.Text = "حفظ"
        Me.btnsaveci.UseVisualStyleBackColor = True
        '
        'btnediteci
        '
        Me.btnediteci.Location = New System.Drawing.Point(144, 305)
        Me.btnediteci.Name = "btnediteci"
        Me.btnediteci.Size = New System.Drawing.Size(83, 32)
        Me.btnediteci.TabIndex = 2
        Me.btnediteci.Text = "تعديل"
        Me.btnediteci.UseVisualStyleBackColor = True
        '
        'btndeleteci
        '
        Me.btndeleteci.Location = New System.Drawing.Point(38, 305)
        Me.btndeleteci.Name = "btndeleteci"
        Me.btndeleteci.Size = New System.Drawing.Size(75, 34)
        Me.btndeleteci.TabIndex = 3
        Me.btndeleteci.Text = "حذف"
        Me.btndeleteci.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(233, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(121, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "اختر الدولة من القائمة"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(233, 60)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(111, 14)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "ادخل اسم المدينة"
        '
        'CT_name
        '
        Me.CT_name.Location = New System.Drawing.Point(38, 60)
        Me.CT_name.Name = "CT_name"
        Me.CT_name.Size = New System.Drawing.Size(189, 20)
        Me.CT_name.TabIndex = 6
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(29, 98)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(312, 186)
        Me.ListBox1.TabIndex = 7
        '
        'FrmCities
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(365, 361)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.CT_name)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btndeleteci)
        Me.Controls.Add(Me.btnediteci)
        Me.Controls.Add(Me.btnsaveci)
        Me.Controls.Add(Me.Country)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmCities"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Text = "قائمة المدن"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Country As System.Windows.Forms.ComboBox
    Friend WithEvents btnsaveci As System.Windows.Forms.Button
    Friend WithEvents btnediteci As System.Windows.Forms.Button
    Friend WithEvents btndeleteci As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents CT_name As System.Windows.Forms.TextBox
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
End Class
