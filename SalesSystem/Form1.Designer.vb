<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.btnFrmItems = New System.Windows.Forms.Button()
        Me.btnitem = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Button1.Location = New System.Drawing.Point(693, 21)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(133, 56)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "شاشة بيانات العملاء"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Button2.Location = New System.Drawing.Point(693, 83)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(133, 54)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "شاشة بيانات الموردين"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'btnFrmItems
        '
        Me.btnFrmItems.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnFrmItems.Location = New System.Drawing.Point(693, 204)
        Me.btnFrmItems.Name = "btnFrmItems"
        Me.btnFrmItems.Size = New System.Drawing.Size(133, 55)
        Me.btnFrmItems.TabIndex = 2
        Me.btnFrmItems.Text = "توريد الأصناف إلى المخزن"
        Me.btnFrmItems.UseVisualStyleBackColor = False
        '
        'btnitem
        '
        Me.btnitem.BackColor = System.Drawing.Color.LightSteelBlue
        Me.btnitem.Location = New System.Drawing.Point(693, 143)
        Me.btnitem.Name = "btnitem"
        Me.btnitem.Size = New System.Drawing.Size(133, 55)
        Me.btnitem.TabIndex = 3
        Me.btnitem.Text = "شاشة إضافة الأصناف"
        Me.btnitem.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(857, 443)
        Me.Controls.Add(Me.btnitem)
        Me.Controls.Add(Me.btnFrmItems)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents btnFrmItems As System.Windows.Forms.Button
    Friend WithEvents btnitem As System.Windows.Forms.Button

End Class
