<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Cal
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
        Me.LblTotal = New System.Windows.Forms.Label()
        Me.LblPay = New System.Windows.Forms.Label()
        Me.LblChanged = New System.Windows.Forms.Label()
        Me.LblRMT = New System.Windows.Forms.Label()
        Me.LblRMC = New System.Windows.Forms.Label()
        Me.TbxRMP = New System.Windows.Forms.TextBox()
        Me.BtnPay = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'LblTotal
        '
        Me.LblTotal.AutoSize = True
        Me.LblTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.LblTotal.Location = New System.Drawing.Point(136, 109)
        Me.LblTotal.Name = "LblTotal"
        Me.LblTotal.Size = New System.Drawing.Size(68, 29)
        Me.LblTotal.TabIndex = 1
        Me.LblTotal.Text = "Total"
        '
        'LblPay
        '
        Me.LblPay.AutoSize = True
        Me.LblPay.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.LblPay.Location = New System.Drawing.Point(136, 189)
        Me.LblPay.Name = "LblPay"
        Me.LblPay.Size = New System.Drawing.Size(81, 29)
        Me.LblPay.TabIndex = 2
        Me.LblPay.Text = "Payed"
        '
        'LblChanged
        '
        Me.LblChanged.AutoSize = True
        Me.LblChanged.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.LblChanged.Location = New System.Drawing.Point(136, 288)
        Me.LblChanged.Name = "LblChanged"
        Me.LblChanged.Size = New System.Drawing.Size(111, 29)
        Me.LblChanged.TabIndex = 3
        Me.LblChanged.Text = "Changed"
        '
        'LblRMT
        '
        Me.LblRMT.AutoSize = True
        Me.LblRMT.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.LblRMT.Location = New System.Drawing.Point(481, 109)
        Me.LblRMT.Name = "LblRMT"
        Me.LblRMT.Size = New System.Drawing.Size(21, 29)
        Me.LblRMT.TabIndex = 4
        Me.LblRMT.Text = "-"
        '
        'LblRMC
        '
        Me.LblRMC.AutoSize = True
        Me.LblRMC.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.LblRMC.Location = New System.Drawing.Point(481, 288)
        Me.LblRMC.Name = "LblRMC"
        Me.LblRMC.Size = New System.Drawing.Size(21, 29)
        Me.LblRMC.TabIndex = 5
        Me.LblRMC.Text = "-"
        '
        'TbxRMP
        '
        Me.TbxRMP.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.TbxRMP.Location = New System.Drawing.Point(427, 189)
        Me.TbxRMP.Name = "TbxRMP"
        Me.TbxRMP.Size = New System.Drawing.Size(135, 35)
        Me.TbxRMP.TabIndex = 20
        '
        'BtnPay
        '
        Me.BtnPay.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.BtnPay.Location = New System.Drawing.Point(436, 369)
        Me.BtnPay.Name = "BtnPay"
        Me.BtnPay.Size = New System.Drawing.Size(165, 50)
        Me.BtnPay.TabIndex = 40
        Me.BtnPay.Text = "Pay"
        Me.BtnPay.UseVisualStyleBackColor = True
        '
        'Cal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.BtnPay)
        Me.Controls.Add(Me.TbxRMP)
        Me.Controls.Add(Me.LblRMC)
        Me.Controls.Add(Me.LblRMT)
        Me.Controls.Add(Me.LblChanged)
        Me.Controls.Add(Me.LblPay)
        Me.Controls.Add(Me.LblTotal)
        Me.Name = "Cal"
        Me.Text = "Cal"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LblTotal As Label
    Friend WithEvents LblPay As Label
    Friend WithEvents LblChanged As Label
    Friend WithEvents LblRMT As Label
    Friend WithEvents LblRMC As Label
    Friend WithEvents TbxRMP As TextBox
    Friend WithEvents BtnPay As Button
End Class
