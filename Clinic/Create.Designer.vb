<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Create
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
        Me.LblUID = New System.Windows.Forms.Label()
        Me.LblUN = New System.Windows.Forms.Label()
        Me.LblPW = New System.Windows.Forms.Label()
        Me.LblUT = New System.Windows.Forms.Label()
        Me.TbxUID = New System.Windows.Forms.TextBox()
        Me.TbxUN = New System.Windows.Forms.TextBox()
        Me.TbxPW = New System.Windows.Forms.TextBox()
        Me.TbxUT = New System.Windows.Forms.TextBox()
        Me.BtnCreate = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'LblUID
        '
        Me.LblUID.AutoSize = True
        Me.LblUID.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.LblUID.Location = New System.Drawing.Point(213, 115)
        Me.LblUID.Name = "LblUID"
        Me.LblUID.Size = New System.Drawing.Size(93, 29)
        Me.LblUID.TabIndex = 0
        Me.LblUID.Text = "User ID"
        '
        'LblUN
        '
        Me.LblUN.AutoSize = True
        Me.LblUN.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.LblUN.Location = New System.Drawing.Point(171, 154)
        Me.LblUN.Name = "LblUN"
        Me.LblUN.Size = New System.Drawing.Size(135, 29)
        Me.LblUN.TabIndex = 1
        Me.LblUN.Text = "User Name"
        '
        'LblPW
        '
        Me.LblPW.AutoSize = True
        Me.LblPW.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.LblPW.Location = New System.Drawing.Point(186, 198)
        Me.LblPW.Name = "LblPW"
        Me.LblPW.Size = New System.Drawing.Size(120, 29)
        Me.LblPW.TabIndex = 2
        Me.LblPW.Text = "Password"
        '
        'LblUT
        '
        Me.LblUT.AutoSize = True
        Me.LblUT.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.LblUT.Location = New System.Drawing.Point(181, 246)
        Me.LblUT.Name = "LblUT"
        Me.LblUT.Size = New System.Drawing.Size(125, 29)
        Me.LblUT.TabIndex = 3
        Me.LblUT.Text = "User Type"
        '
        'TbxUID
        '
        Me.TbxUID.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.TbxUID.Location = New System.Drawing.Point(314, 112)
        Me.TbxUID.Name = "TbxUID"
        Me.TbxUID.Size = New System.Drawing.Size(289, 35)
        Me.TbxUID.TabIndex = 4
        '
        'TbxUN
        '
        Me.TbxUN.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.TbxUN.Location = New System.Drawing.Point(314, 154)
        Me.TbxUN.Name = "TbxUN"
        Me.TbxUN.Size = New System.Drawing.Size(289, 35)
        Me.TbxUN.TabIndex = 5
        '
        'TbxPW
        '
        Me.TbxPW.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.TbxPW.Location = New System.Drawing.Point(314, 198)
        Me.TbxPW.Name = "TbxPW"
        Me.TbxPW.Size = New System.Drawing.Size(289, 35)
        Me.TbxPW.TabIndex = 6
        Me.TbxPW.UseSystemPasswordChar = True
        '
        'TbxUT
        '
        Me.TbxUT.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.TbxUT.Location = New System.Drawing.Point(314, 246)
        Me.TbxUT.Name = "TbxUT"
        Me.TbxUT.Size = New System.Drawing.Size(289, 35)
        Me.TbxUT.TabIndex = 7
        '
        'BtnCreate
        '
        Me.BtnCreate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.BtnCreate.Location = New System.Drawing.Point(304, 331)
        Me.BtnCreate.Name = "BtnCreate"
        Me.BtnCreate.Size = New System.Drawing.Size(177, 67)
        Me.BtnCreate.TabIndex = 8
        Me.BtnCreate.Text = "Create"
        Me.BtnCreate.UseVisualStyleBackColor = True
        '
        'Create
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.BtnCreate)
        Me.Controls.Add(Me.TbxUT)
        Me.Controls.Add(Me.TbxPW)
        Me.Controls.Add(Me.TbxUN)
        Me.Controls.Add(Me.TbxUID)
        Me.Controls.Add(Me.LblUT)
        Me.Controls.Add(Me.LblPW)
        Me.Controls.Add(Me.LblUN)
        Me.Controls.Add(Me.LblUID)
        Me.Name = "Create"
        Me.Text = "Create"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LblUID As Label
    Friend WithEvents LblUN As Label
    Friend WithEvents LblPW As Label
    Friend WithEvents LblUT As Label
    Friend WithEvents TbxUID As TextBox
    Friend WithEvents TbxUN As TextBox
    Friend WithEvents TbxPW As TextBox
    Friend WithEvents TbxUT As TextBox
    Friend WithEvents BtnCreate As Button
End Class
