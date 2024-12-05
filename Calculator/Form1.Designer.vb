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
        Me.num1 = New System.Windows.Forms.Button()
        Me.num2 = New System.Windows.Forms.Button()
        Me.num3 = New System.Windows.Forms.Button()
        Me.num6 = New System.Windows.Forms.Button()
        Me.num5 = New System.Windows.Forms.Button()
        Me.num4 = New System.Windows.Forms.Button()
        Me.num9 = New System.Windows.Forms.Button()
        Me.num8 = New System.Windows.Forms.Button()
        Me.num7 = New System.Windows.Forms.Button()
        Me.num0 = New System.Windows.Forms.Button()
        Me.OpAdd = New System.Windows.Forms.Button()
        Me.OpMinus = New System.Windows.Forms.Button()
        Me.OpMulti = New System.Windows.Forms.Button()
        Me.OpDivide = New System.Windows.Forms.Button()
        Me.Equal = New System.Windows.Forms.Button()
        Me.Txtdisplay = New System.Windows.Forms.TextBox()
        Me.btnclear = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'num1
        '
        Me.num1.Location = New System.Drawing.Point(2, 114)
        Me.num1.Name = "num1"
        Me.num1.Size = New System.Drawing.Size(48, 45)
        Me.num1.TabIndex = 0
        Me.num1.Text = "1"
        Me.num1.UseVisualStyleBackColor = True
        '
        'num2
        '
        Me.num2.Location = New System.Drawing.Point(65, 114)
        Me.num2.Name = "num2"
        Me.num2.Size = New System.Drawing.Size(48, 45)
        Me.num2.TabIndex = 1
        Me.num2.Text = "2"
        Me.num2.UseVisualStyleBackColor = True
        '
        'num3
        '
        Me.num3.Location = New System.Drawing.Point(130, 114)
        Me.num3.Name = "num3"
        Me.num3.Size = New System.Drawing.Size(48, 45)
        Me.num3.TabIndex = 2
        Me.num3.Text = "3"
        Me.num3.UseVisualStyleBackColor = True
        '
        'num6
        '
        Me.num6.Location = New System.Drawing.Point(130, 165)
        Me.num6.Name = "num6"
        Me.num6.Size = New System.Drawing.Size(48, 45)
        Me.num6.TabIndex = 5
        Me.num6.Text = "6"
        Me.num6.UseVisualStyleBackColor = True
        '
        'num5
        '
        Me.num5.Location = New System.Drawing.Point(65, 165)
        Me.num5.Name = "num5"
        Me.num5.Size = New System.Drawing.Size(48, 45)
        Me.num5.TabIndex = 4
        Me.num5.Text = "5"
        Me.num5.UseVisualStyleBackColor = True
        '
        'num4
        '
        Me.num4.Location = New System.Drawing.Point(2, 165)
        Me.num4.Name = "num4"
        Me.num4.Size = New System.Drawing.Size(48, 45)
        Me.num4.TabIndex = 3
        Me.num4.Text = "4"
        Me.num4.UseVisualStyleBackColor = True
        '
        'num9
        '
        Me.num9.Location = New System.Drawing.Point(130, 220)
        Me.num9.Name = "num9"
        Me.num9.Size = New System.Drawing.Size(48, 45)
        Me.num9.TabIndex = 8
        Me.num9.Text = "9"
        Me.num9.UseVisualStyleBackColor = True
        '
        'num8
        '
        Me.num8.Location = New System.Drawing.Point(65, 220)
        Me.num8.Name = "num8"
        Me.num8.Size = New System.Drawing.Size(48, 45)
        Me.num8.TabIndex = 7
        Me.num8.Text = "8"
        Me.num8.UseVisualStyleBackColor = True
        '
        'num7
        '
        Me.num7.Location = New System.Drawing.Point(2, 220)
        Me.num7.Name = "num7"
        Me.num7.Size = New System.Drawing.Size(48, 45)
        Me.num7.TabIndex = 6
        Me.num7.Text = "7"
        Me.num7.UseVisualStyleBackColor = True
        '
        'num0
        '
        Me.num0.Location = New System.Drawing.Point(2, 271)
        Me.num0.Name = "num0"
        Me.num0.Size = New System.Drawing.Size(48, 42)
        Me.num0.TabIndex = 9
        Me.num0.Text = "0"
        Me.num0.UseVisualStyleBackColor = True
        '
        'OpAdd
        '
        Me.OpAdd.Location = New System.Drawing.Point(185, 114)
        Me.OpAdd.Name = "OpAdd"
        Me.OpAdd.Size = New System.Drawing.Size(46, 45)
        Me.OpAdd.TabIndex = 10
        Me.OpAdd.Text = "+"
        Me.OpAdd.UseVisualStyleBackColor = True
        '
        'OpMinus
        '
        Me.OpMinus.Location = New System.Drawing.Point(185, 165)
        Me.OpMinus.Name = "OpMinus"
        Me.OpMinus.Size = New System.Drawing.Size(46, 45)
        Me.OpMinus.TabIndex = 11
        Me.OpMinus.Text = "-"
        Me.OpMinus.UseVisualStyleBackColor = True
        '
        'OpMulti
        '
        Me.OpMulti.Location = New System.Drawing.Point(185, 220)
        Me.OpMulti.Name = "OpMulti"
        Me.OpMulti.Size = New System.Drawing.Size(46, 45)
        Me.OpMulti.TabIndex = 12
        Me.OpMulti.Text = "*"
        Me.OpMulti.UseVisualStyleBackColor = True
        '
        'OpDivide
        '
        Me.OpDivide.Location = New System.Drawing.Point(185, 268)
        Me.OpDivide.Name = "OpDivide"
        Me.OpDivide.Size = New System.Drawing.Size(46, 45)
        Me.OpDivide.TabIndex = 13
        Me.OpDivide.Text = "/"
        Me.OpDivide.UseVisualStyleBackColor = True
        '
        'Equal
        '
        Me.Equal.Location = New System.Drawing.Point(130, 268)
        Me.Equal.Name = "Equal"
        Me.Equal.Size = New System.Drawing.Size(46, 45)
        Me.Equal.TabIndex = 14
        Me.Equal.Text = "="
        Me.Equal.UseVisualStyleBackColor = True
        '
        'Txtdisplay
        '
        Me.Txtdisplay.Font = New System.Drawing.Font("Segoe UI", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txtdisplay.Location = New System.Drawing.Point(2, 13)
        Me.Txtdisplay.Name = "Txtdisplay"
        Me.Txtdisplay.Size = New System.Drawing.Size(229, 57)
        Me.Txtdisplay.TabIndex = 15
        '
        'btnclear
        '
        Me.btnclear.Location = New System.Drawing.Point(65, 272)
        Me.btnclear.Name = "btnclear"
        Me.btnclear.Size = New System.Drawing.Size(48, 41)
        Me.btnclear.TabIndex = 16
        Me.btnclear.Text = "clr"
        Me.btnclear.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(235, 318)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnclear)
        Me.Controls.Add(Me.Txtdisplay)
        Me.Controls.Add(Me.Equal)
        Me.Controls.Add(Me.OpDivide)
        Me.Controls.Add(Me.OpMulti)
        Me.Controls.Add(Me.OpMinus)
        Me.Controls.Add(Me.OpAdd)
        Me.Controls.Add(Me.num0)
        Me.Controls.Add(Me.num9)
        Me.Controls.Add(Me.num8)
        Me.Controls.Add(Me.num7)
        Me.Controls.Add(Me.num6)
        Me.Controls.Add(Me.num5)
        Me.Controls.Add(Me.num4)
        Me.Controls.Add(Me.num3)
        Me.Controls.Add(Me.num2)
        Me.Controls.Add(Me.num1)
        Me.Name = "Form1"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents num1 As Button
    Friend WithEvents num2 As Button
    Friend WithEvents num3 As Button
    Friend WithEvents num6 As Button
    Friend WithEvents num5 As Button
    Friend WithEvents num4 As Button
    Friend WithEvents num9 As Button
    Friend WithEvents num8 As Button
    Friend WithEvents num7 As Button
    Friend WithEvents num0 As Button
    Friend WithEvents OpAdd As Button
    Friend WithEvents OpMinus As Button
    Friend WithEvents OpMulti As Button
    Friend WithEvents OpDivide As Button
    Friend WithEvents Equal As Button
    Friend WithEvents Txtdisplay As TextBox
    Friend WithEvents btnclear As Button
End Class
