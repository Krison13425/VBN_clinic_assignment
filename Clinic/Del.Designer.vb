<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Del
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.TbxUN = New System.Windows.Forms.TextBox()
        Me.CLBUN = New System.Windows.Forms.CheckedListBox()
        Me.BtnDel = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'TbxUN
        '
        Me.TbxUN.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.TbxUN.Location = New System.Drawing.Point(121, 64)
        Me.TbxUN.Name = "TbxUN"
        Me.TbxUN.Size = New System.Drawing.Size(227, 35)
        Me.TbxUN.TabIndex = 0
        '
        'CLBUN
        '
        Me.CLBUN.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.CLBUN.FormattingEnabled = True
        Me.CLBUN.Location = New System.Drawing.Point(121, 117)
        Me.CLBUN.Name = "CLBUN"
        Me.CLBUN.Size = New System.Drawing.Size(227, 292)
        Me.CLBUN.TabIndex = 1
        '
        'BtnDel
        '
        Me.BtnDel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.BtnDel.Location = New System.Drawing.Point(140, 437)
        Me.BtnDel.Name = "BtnDel"
        Me.BtnDel.Size = New System.Drawing.Size(182, 48)
        Me.BtnDel.TabIndex = 2
        Me.BtnDel.Text = "Delete"
        Me.BtnDel.UseVisualStyleBackColor = True
        '
        'Del
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(480, 544)
        Me.Controls.Add(Me.BtnDel)
        Me.Controls.Add(Me.CLBUN)
        Me.Controls.Add(Me.TbxUN)
        Me.Name = "Del"
        Me.Text = "Del"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TbxUN As TextBox
    Friend WithEvents CLBUN As CheckedListBox
    Friend WithEvents BtnDel As Button
End Class
