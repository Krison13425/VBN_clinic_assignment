<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Reset
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
        Me.LblCP = New System.Windows.Forms.Label()
        Me.TbxUID = New System.Windows.Forms.TextBox()
        Me.TbxUN = New System.Windows.Forms.TextBox()
        Me.TbxPW = New System.Windows.Forms.TextBox()
        Me.TbxCP = New System.Windows.Forms.TextBox()
        Me.BtnSearch = New System.Windows.Forms.Button()
        Me.BtnReset = New System.Windows.Forms.Button()
        Me.LblUT = New System.Windows.Forms.Label()
        Me.TbxUT = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'LblUID
        '
        Me.LblUID.AutoSize = True
        Me.LblUID.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.LblUID.Location = New System.Drawing.Point(220, 179)
        Me.LblUID.Name = "LblUID"
        Me.LblUID.Size = New System.Drawing.Size(93, 29)
        Me.LblUID.TabIndex = 0
        Me.LblUID.Text = "User ID"
        '
        'LblUN
        '
        Me.LblUN.AutoSize = True
        Me.LblUN.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.LblUN.Location = New System.Drawing.Point(178, 220)
        Me.LblUN.Name = "LblUN"
        Me.LblUN.Size = New System.Drawing.Size(135, 29)
        Me.LblUN.TabIndex = 1
        Me.LblUN.Text = "User Name"
        '
        'LblPW
        '
        Me.LblPW.AutoSize = True
        Me.LblPW.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.LblPW.Location = New System.Drawing.Point(137, 303)
        Me.LblPW.Name = "LblPW"
        Me.LblPW.Size = New System.Drawing.Size(176, 29)
        Me.LblPW.TabIndex = 2
        Me.LblPW.Text = "New Password"
        '
        'LblCP
        '
        Me.LblCP.AutoSize = True
        Me.LblCP.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.LblCP.Location = New System.Drawing.Point(103, 347)
        Me.LblCP.Name = "LblCP"
        Me.LblCP.Size = New System.Drawing.Size(210, 29)
        Me.LblCP.TabIndex = 3
        Me.LblCP.Text = "Confirm Password"
        '
        'TbxUID
        '
        Me.TbxUID.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.TbxUID.Location = New System.Drawing.Point(341, 173)
        Me.TbxUID.Name = "TbxUID"
        Me.TbxUID.Size = New System.Drawing.Size(281, 35)
        Me.TbxUID.TabIndex = 0
        '
        'TbxUN
        '
        Me.TbxUN.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.TbxUN.Location = New System.Drawing.Point(341, 214)
        Me.TbxUN.Name = "TbxUN"
        Me.TbxUN.ReadOnly = True
        Me.TbxUN.Size = New System.Drawing.Size(281, 35)
        Me.TbxUN.TabIndex = 1
        '
        'TbxPW
        '
        Me.TbxPW.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.TbxPW.Location = New System.Drawing.Point(341, 297)
        Me.TbxPW.Name = "TbxPW"
        Me.TbxPW.Size = New System.Drawing.Size(281, 35)
        Me.TbxPW.TabIndex = 3
        '
        'TbxCP
        '
        Me.TbxCP.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.TbxCP.Location = New System.Drawing.Point(341, 341)
        Me.TbxCP.Name = "TbxCP"
        Me.TbxCP.Size = New System.Drawing.Size(281, 35)
        Me.TbxCP.TabIndex = 4
        '
        'BtnSearch
        '
        Me.BtnSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.BtnSearch.Location = New System.Drawing.Point(225, 406)
        Me.BtnSearch.Name = "BtnSearch"
        Me.BtnSearch.Size = New System.Drawing.Size(143, 57)
        Me.BtnSearch.TabIndex = 8
        Me.BtnSearch.Text = "Search"
        Me.BtnSearch.UseVisualStyleBackColor = True
        '
        'BtnReset
        '
        Me.BtnReset.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.BtnReset.Location = New System.Drawing.Point(433, 406)
        Me.BtnReset.Name = "BtnReset"
        Me.BtnReset.Size = New System.Drawing.Size(143, 57)
        Me.BtnReset.TabIndex = 9
        Me.BtnReset.Text = "Reset"
        Me.BtnReset.UseVisualStyleBackColor = True
        '
        'LblUT
        '
        Me.LblUT.AutoSize = True
        Me.LblUT.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.LblUT.Location = New System.Drawing.Point(188, 261)
        Me.LblUT.Name = "LblUT"
        Me.LblUT.Size = New System.Drawing.Size(125, 29)
        Me.LblUT.TabIndex = 10
        Me.LblUT.Text = "User Type"
        '
        'TbxUT
        '
        Me.TbxUT.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.TbxUT.Location = New System.Drawing.Point(341, 255)
        Me.TbxUT.Name = "TbxUT"
        Me.TbxUT.ReadOnly = True
        Me.TbxUT.Size = New System.Drawing.Size(281, 35)
        Me.TbxUT.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(184, 47)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(446, 52)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Reset User Password"
        '
        'Reset
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 553)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TbxUT)
        Me.Controls.Add(Me.LblUT)
        Me.Controls.Add(Me.BtnReset)
        Me.Controls.Add(Me.BtnSearch)
        Me.Controls.Add(Me.TbxCP)
        Me.Controls.Add(Me.TbxPW)
        Me.Controls.Add(Me.TbxUN)
        Me.Controls.Add(Me.TbxUID)
        Me.Controls.Add(Me.LblCP)
        Me.Controls.Add(Me.LblPW)
        Me.Controls.Add(Me.LblUN)
        Me.Controls.Add(Me.LblUID)
        Me.Name = "Reset"
        Me.Text = "Reset"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents LblUID As Label
    Friend WithEvents LblUN As Label
    Friend WithEvents LblPW As Label
    Friend WithEvents LblCP As Label
    Friend WithEvents TbxUID As TextBox
    Friend WithEvents TbxUN As TextBox
    Friend WithEvents TbxPW As TextBox
    Friend WithEvents TbxCP As TextBox
    Friend WithEvents BtnSearch As Button
    Friend WithEvents BtnReset As Button
    Friend WithEvents LblUT As Label
    Friend WithEvents TbxUT As TextBox
    Friend WithEvents Label4 As Label
End Class
