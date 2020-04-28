<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Форма переопределяет dispose для очистки списка компонентов.
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

    'Является обязательной для конструктора форм Windows Forms
    Private components As System.ComponentModel.IContainer

    'Примечание: следующая процедура является обязательной для конструктора форм Windows Forms
    'Для ее изменения используйте конструктор форм Windows Form.  
    'Не изменяйте ее в редакторе исходного кода.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.B1 = New System.Windows.Forms.Button()
        Me.T2 = New System.Windows.Forms.TextBox()
        Me.T1 = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'B1
        '
        Me.B1.Location = New System.Drawing.Point(67, 421)
        Me.B1.Name = "B1"
        Me.B1.Size = New System.Drawing.Size(328, 61)
        Me.B1.TabIndex = 1
        Me.B1.Text = "Виконати"
        Me.B1.UseVisualStyleBackColor = True
        '
        'T2
        '
        Me.T2.Location = New System.Drawing.Point(266, 12)
        Me.T2.Multiline = True
        Me.T2.Name = "T2"
        Me.T2.Size = New System.Drawing.Size(178, 363)
        Me.T2.TabIndex = 2
        '
        'T1
        '
        Me.T1.Location = New System.Drawing.Point(31, 12)
        Me.T1.Multiline = True
        Me.T1.Name = "T1"
        Me.T1.Size = New System.Drawing.Size(178, 363)
        Me.T1.TabIndex = 2
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(477, 572)
        Me.Controls.Add(Me.T1)
        Me.Controls.Add(Me.T2)
        Me.Controls.Add(Me.B1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents B1 As Button
    Friend WithEvents T2 As TextBox
    Friend WithEvents T1 As TextBox
End Class
