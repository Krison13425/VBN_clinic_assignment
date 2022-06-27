<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Login
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
        Me.LblUID = New System.Windows.Forms.Label()
        Me.LblPW = New System.Windows.Forms.Label()
        Me.LblUT = New System.Windows.Forms.Label()
        Me.TbxUID = New System.Windows.Forms.TextBox()
        Me.TbxPW = New System.Windows.Forms.TextBox()
        Me.BtnLogin = New System.Windows.Forms.Button()
        Me.TbxUT = New System.Windows.Forms.TextBox()
        Me.LblLP = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'LblUID
        '
        Me.LblUID.AutoSize = True
        Me.LblUID.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.LblUID.Location = New System.Drawing.Point(164, 135)
        Me.LblUID.Name = "LblUID"
        Me.LblUID.Size = New System.Drawing.Size(93, 29)
        Me.LblUID.TabIndex = 2
        Me.LblUID.Text = "User ID"
        '
        'LblPW
        '
        Me.LblPW.AutoSize = True
        Me.LblPW.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.LblPW.Location = New System.Drawing.Point(137, 181)
        Me.LblPW.Name = "LblPW"
        Me.LblPW.Size = New System.Drawing.Size(120, 29)
        Me.LblPW.TabIndex = 3
        Me.LblPW.Text = "Password"
        '
        'LblUT
        '
        Me.LblUT.AutoSize = True
        Me.LblUT.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.LblUT.Location = New System.Drawing.Point(132, 229)
        Me.LblUT.Name = "LblUT"
        Me.LblUT.Size = New System.Drawing.Size(125, 29)
        Me.LblUT.TabIndex = 4
        Me.LblUT.Text = "User Type"
        '
        'TbxUID
        '
        Me.TbxUID.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.TbxUID.Location = New System.Drawing.Point(306, 135)
        Me.TbxUID.Name = "TbxUID"
        Me.TbxUID.Size = New System.Drawing.Size(251, 35)
        Me.TbxUID.TabIndex = 0
        '
        'TbxPW
        '
        Me.TbxPW.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.TbxPW.Location = New System.Drawing.Point(306, 181)
        Me.TbxPW.Name = "TbxPW"
        Me.TbxPW.Size = New System.Drawing.Size(251, 35)
        Me.TbxPW.TabIndex = 1
        Me.TbxPW.UseSystemPasswordChar = True
        '
        'BtnLogin
        '
        Me.BtnLogin.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.BtnLogin.Location = New System.Drawing.Point(249, 308)
        Me.BtnLogin.Name = "BtnLogin"
        Me.BtnLogin.Size = New System.Drawing.Size(188, 49)
        Me.BtnLogin.TabIndex = 42
        Me.BtnLogin.Text = "Login"
        Me.BtnLogin.UseVisualStyleBackColor = True
        '
        'TbxUT
        '
        Me.TbxUT.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.TbxUT.Location = New System.Drawing.Point(306, 229)
        Me.TbxUT.Name = "TbxUT"
        Me.TbxUT.Size = New System.Drawing.Size(251, 35)
        Me.TbxUT.TabIndex = 2
        '
        'LblLP
        '
        Me.LblLP.AutoSize = True
        Me.LblLP.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.0!)
        Me.LblLP.Location = New System.Drawing.Point(231, 48)
        Me.LblLP.Name = "LblLP"
        Me.LblLP.Size = New System.Drawing.Size(242, 52)
        Me.LblLP.TabIndex = 43
        Me.LblLP.Text = "Login Page"
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(765, 443)
        Me.Controls.Add(Me.LblLP)
        Me.Controls.Add(Me.TbxUT)
        Me.Controls.Add(Me.BtnLogin)
        Me.Controls.Add(Me.TbxPW)
        Me.Controls.Add(Me.TbxUID)
        Me.Controls.Add(Me.LblUT)
        Me.Controls.Add(Me.LblPW)
        Me.Controls.Add(Me.LblUID)
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Name = "Login"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Text = "Login"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LblUID As Label
    Friend WithEvents LblPW As Label
    Friend WithEvents LblUT As Label
    Friend WithEvents TbxUID As TextBox
    Friend WithEvents TbxPW As TextBox
    Friend WithEvents BtnLogin As Button
    Friend WithEvents TbxUT As TextBox
    Friend WithEvents LblLP As Label
End Class
