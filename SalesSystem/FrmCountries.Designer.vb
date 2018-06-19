<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCountries
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
        Me.cusave = New System.Windows.Forms.Button()
        Me.cuedit = New System.Windows.Forms.Button()
        Me.btcudelete = New System.Windows.Forms.Button()
        Me.C_NAME = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.SuspendLayout()
        '
        'cusave
        '
        Me.cusave.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cusave.Location = New System.Drawing.Point(250, 315)
        Me.cusave.Name = "cusave"
        Me.cusave.Size = New System.Drawing.Size(75, 37)
        Me.cusave.TabIndex = 0
        Me.cusave.Text = "حفظ"
        Me.cusave.UseVisualStyleBackColor = True
        '
        'cuedit
        '
        Me.cuedit.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cuedit.Location = New System.Drawing.Point(158, 315)
        Me.cuedit.Name = "cuedit"
        Me.cuedit.Size = New System.Drawing.Size(75, 37)
        Me.cuedit.TabIndex = 1
        Me.cuedit.Text = "تعديل"
        Me.cuedit.UseVisualStyleBackColor = True
        '
        'btcudelete
        '
        Me.btcudelete.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btcudelete.Location = New System.Drawing.Point(64, 315)
        Me.btcudelete.Name = "btcudelete"
        Me.btcudelete.Size = New System.Drawing.Size(75, 37)
        Me.btcudelete.TabIndex = 2
        Me.btcudelete.Text = "حذف"
        Me.btcudelete.UseVisualStyleBackColor = True
        '
        'C_NAME
        '
        Me.C_NAME.Location = New System.Drawing.Point(95, 28)
        Me.C_NAME.Name = "C_NAME"
        Me.C_NAME.Size = New System.Drawing.Size(165, 20)
        Me.C_NAME.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(266, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(95, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "أدخل اسم الدولة"
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(22, 68)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.ListBox1.Size = New System.Drawing.Size(322, 212)
        Me.ListBox1.TabIndex = 5
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(37, 28)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(41, 20)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "..."
        Me.ToolTip1.SetToolTip(Me.Button1, "إضافة المدن")
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ToolTip1
        '
        Me.ToolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.ToolTip1.ToolTipTitle = "مساعدة"
        '
        'FrmCountries
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(373, 390)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.C_NAME)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btcudelete)
        Me.Controls.Add(Me.cuedit)
        Me.Controls.Add(Me.cusave)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmCountries"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "قائمة الدول"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cusave As System.Windows.Forms.Button
    Friend WithEvents cuedit As System.Windows.Forms.Button
    Friend WithEvents btcudelete As System.Windows.Forms.Button
    Friend WithEvents C_NAME As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
End Class
