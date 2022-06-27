<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Patient_Info
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
        Me.TiltleLabel = New System.Windows.Forms.Label()
        Me.LblName = New System.Windows.Forms.Label()
        Me.LblAge = New System.Windows.Forms.Label()
        Me.LblPN = New System.Windows.Forms.Label()
        Me.LblIC = New System.Windows.Forms.Label()
        Me.LblAdress = New System.Windows.Forms.Label()
        Me.LblWeight = New System.Windows.Forms.Label()
        Me.LblHeight = New System.Windows.Forms.Label()
        Me.LblBT = New System.Windows.Forms.Label()
        Me.LblAllergies = New System.Windows.Forms.Label()
        Me.TbxName = New System.Windows.Forms.TextBox()
        Me.TbxAge = New System.Windows.Forms.TextBox()
        Me.TbxIC = New System.Windows.Forms.TextBox()
        Me.TbxPN = New System.Windows.Forms.TextBox()
        Me.TbxAddress = New System.Windows.Forms.RichTextBox()
        Me.TbxHeight = New System.Windows.Forms.TextBox()
        Me.TbxBT = New System.Windows.Forms.TextBox()
        Me.TbxWeight = New System.Windows.Forms.TextBox()
        Me.TbxAllergies = New System.Windows.Forms.TextBox()
        Me.TbxPhone = New System.Windows.Forms.TextBox()
        Me.LblPhone = New System.Windows.Forms.Label()
        Me.LblEmail = New System.Windows.Forms.Label()
        Me.TbxEMail = New System.Windows.Forms.TextBox()
        Me.BtnCreateNurse = New System.Windows.Forms.Button()
        Me.TbxPID = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'TiltleLabel
        '
        Me.TiltleLabel.AutoSize = True
        Me.TiltleLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TiltleLabel.Location = New System.Drawing.Point(381, 45)
        Me.TiltleLabel.Name = "TiltleLabel"
        Me.TiltleLabel.Size = New System.Drawing.Size(269, 46)
        Me.TiltleLabel.TabIndex = 0
        Me.TiltleLabel.Text = "Patient Profile"
        '
        'LblName
        '
        Me.LblName.AutoSize = True
        Me.LblName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.LblName.Location = New System.Drawing.Point(134, 187)
        Me.LblName.Name = "LblName"
        Me.LblName.Size = New System.Drawing.Size(78, 29)
        Me.LblName.TabIndex = 1
        Me.LblName.Text = "Name"
        '
        'LblAge
        '
        Me.LblAge.AutoSize = True
        Me.LblAge.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.LblAge.Location = New System.Drawing.Point(156, 253)
        Me.LblAge.Name = "LblAge"
        Me.LblAge.Size = New System.Drawing.Size(56, 29)
        Me.LblAge.TabIndex = 2
        Me.LblAge.Text = "Age"
        '
        'LblPN
        '
        Me.LblPN.AutoSize = True
        Me.LblPN.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.LblPN.Location = New System.Drawing.Point(62, 380)
        Me.LblPN.Name = "LblPN"
        Me.LblPN.Size = New System.Drawing.Size(152, 29)
        Me.LblPN.TabIndex = 3
        Me.LblPN.Text = "Passport No."
        '
        'LblIC
        '
        Me.LblIC.AutoSize = True
        Me.LblIC.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.LblIC.Location = New System.Drawing.Point(134, 317)
        Me.LblIC.Name = "LblIC"
        Me.LblIC.Size = New System.Drawing.Size(80, 29)
        Me.LblIC.TabIndex = 4
        Me.LblIC.Text = "IC No."
        '
        'LblAdress
        '
        Me.LblAdress.AutoSize = True
        Me.LblAdress.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.LblAdress.Location = New System.Drawing.Point(112, 488)
        Me.LblAdress.Name = "LblAdress"
        Me.LblAdress.Size = New System.Drawing.Size(102, 29)
        Me.LblAdress.TabIndex = 5
        Me.LblAdress.Text = "Address"
        '
        'LblWeight
        '
        Me.LblWeight.AutoSize = True
        Me.LblWeight.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.LblWeight.Location = New System.Drawing.Point(608, 193)
        Me.LblWeight.Name = "LblWeight"
        Me.LblWeight.Size = New System.Drawing.Size(88, 29)
        Me.LblWeight.TabIndex = 7
        Me.LblWeight.Text = "Weight"
        '
        'LblHeight
        '
        Me.LblHeight.AutoSize = True
        Me.LblHeight.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.LblHeight.Location = New System.Drawing.Point(608, 133)
        Me.LblHeight.Name = "LblHeight"
        Me.LblHeight.Size = New System.Drawing.Size(83, 29)
        Me.LblHeight.TabIndex = 8
        Me.LblHeight.Text = "Height"
        '
        'LblBT
        '
        Me.LblBT.AutoSize = True
        Me.LblBT.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.LblBT.Location = New System.Drawing.Point(608, 263)
        Me.LblBT.Name = "LblBT"
        Me.LblBT.Size = New System.Drawing.Size(138, 29)
        Me.LblBT.TabIndex = 9
        Me.LblBT.Text = "Blood Type"
        '
        'LblAllergies
        '
        Me.LblAllergies.AutoSize = True
        Me.LblAllergies.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.LblAllergies.Location = New System.Drawing.Point(608, 323)
        Me.LblAllergies.Name = "LblAllergies"
        Me.LblAllergies.Size = New System.Drawing.Size(108, 29)
        Me.LblAllergies.TabIndex = 10
        Me.LblAllergies.Text = "Allergies"
        '
        'TbxName
        '
        Me.TbxName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.TbxName.Location = New System.Drawing.Point(251, 187)
        Me.TbxName.Name = "TbxName"
        Me.TbxName.Size = New System.Drawing.Size(292, 35)
        Me.TbxName.TabIndex = 11
        '
        'TbxAge
        '
        Me.TbxAge.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.TbxAge.Location = New System.Drawing.Point(251, 247)
        Me.TbxAge.Name = "TbxAge"
        Me.TbxAge.Size = New System.Drawing.Size(292, 35)
        Me.TbxAge.TabIndex = 12
        '
        'TbxIC
        '
        Me.TbxIC.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.TbxIC.Location = New System.Drawing.Point(251, 317)
        Me.TbxIC.Name = "TbxIC"
        Me.TbxIC.Size = New System.Drawing.Size(292, 35)
        Me.TbxIC.TabIndex = 13
        '
        'TbxPN
        '
        Me.TbxPN.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.TbxPN.Location = New System.Drawing.Point(251, 374)
        Me.TbxPN.Name = "TbxPN"
        Me.TbxPN.Size = New System.Drawing.Size(292, 35)
        Me.TbxPN.TabIndex = 14
        '
        'TbxAddress
        '
        Me.TbxAddress.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.TbxAddress.Location = New System.Drawing.Point(251, 492)
        Me.TbxAddress.Name = "TbxAddress"
        Me.TbxAddress.Size = New System.Drawing.Size(292, 137)
        Me.TbxAddress.TabIndex = 16
        Me.TbxAddress.Text = ""
        '
        'TbxHeight
        '
        Me.TbxHeight.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.TbxHeight.Location = New System.Drawing.Point(741, 133)
        Me.TbxHeight.Name = "TbxHeight"
        Me.TbxHeight.Size = New System.Drawing.Size(292, 35)
        Me.TbxHeight.TabIndex = 18
        '
        'TbxBT
        '
        Me.TbxBT.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.TbxBT.Location = New System.Drawing.Point(741, 263)
        Me.TbxBT.Name = "TbxBT"
        Me.TbxBT.Size = New System.Drawing.Size(292, 35)
        Me.TbxBT.TabIndex = 19
        '
        'TbxWeight
        '
        Me.TbxWeight.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.TbxWeight.Location = New System.Drawing.Point(741, 199)
        Me.TbxWeight.Name = "TbxWeight"
        Me.TbxWeight.Size = New System.Drawing.Size(292, 35)
        Me.TbxWeight.TabIndex = 20
        '
        'TbxAllergies
        '
        Me.TbxAllergies.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.TbxAllergies.Location = New System.Drawing.Point(741, 326)
        Me.TbxAllergies.Name = "TbxAllergies"
        Me.TbxAllergies.Size = New System.Drawing.Size(292, 35)
        Me.TbxAllergies.TabIndex = 21
        '
        'TbxPhone
        '
        Me.TbxPhone.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.TbxPhone.Location = New System.Drawing.Point(251, 429)
        Me.TbxPhone.Name = "TbxPhone"
        Me.TbxPhone.Size = New System.Drawing.Size(292, 35)
        Me.TbxPhone.TabIndex = 23
        '
        'LblPhone
        '
        Me.LblPhone.AutoSize = True
        Me.LblPhone.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.LblPhone.Location = New System.Drawing.Point(85, 435)
        Me.LblPhone.Name = "LblPhone"
        Me.LblPhone.Size = New System.Drawing.Size(127, 29)
        Me.LblPhone.TabIndex = 22
        Me.LblPhone.Text = "Phone No."
        '
        'LblEmail
        '
        Me.LblEmail.AutoSize = True
        Me.LblEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.LblEmail.Location = New System.Drawing.Point(124, 662)
        Me.LblEmail.Name = "LblEmail"
        Me.LblEmail.Size = New System.Drawing.Size(82, 29)
        Me.LblEmail.TabIndex = 6
        Me.LblEmail.Text = "E-Mail"
        '
        'TbxEMail
        '
        Me.TbxEMail.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.TbxEMail.Location = New System.Drawing.Point(251, 656)
        Me.TbxEMail.Name = "TbxEMail"
        Me.TbxEMail.Size = New System.Drawing.Size(292, 35)
        Me.TbxEMail.TabIndex = 17
        '
        'BtnCreateNurse
        '
        Me.BtnCreateNurse.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.BtnCreateNurse.Location = New System.Drawing.Point(741, 578)
        Me.BtnCreateNurse.Name = "BtnCreateNurse"
        Me.BtnCreateNurse.Size = New System.Drawing.Size(193, 72)
        Me.BtnCreateNurse.TabIndex = 24
        Me.BtnCreateNurse.Text = "Create"
        Me.BtnCreateNurse.UseVisualStyleBackColor = True
        '
        'TbxPID
        '
        Me.TbxPID.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.TbxPID.Location = New System.Drawing.Point(251, 133)
        Me.TbxPID.Name = "TbxPID"
        Me.TbxPID.Size = New System.Drawing.Size(292, 35)
        Me.TbxPID.TabIndex = 26
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label1.Location = New System.Drawing.Point(170, 133)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(36, 29)
        Me.Label1.TabIndex = 25
        Me.Label1.Text = "ID"
        '
        'Patient_Info
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1092, 735)
        Me.Controls.Add(Me.TbxPID)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BtnCreateNurse)
        Me.Controls.Add(Me.TbxPhone)
        Me.Controls.Add(Me.LblPhone)
        Me.Controls.Add(Me.TbxAllergies)
        Me.Controls.Add(Me.TbxWeight)
        Me.Controls.Add(Me.TbxBT)
        Me.Controls.Add(Me.TbxHeight)
        Me.Controls.Add(Me.TbxEMail)
        Me.Controls.Add(Me.TbxAddress)
        Me.Controls.Add(Me.TbxPN)
        Me.Controls.Add(Me.TbxIC)
        Me.Controls.Add(Me.TbxAge)
        Me.Controls.Add(Me.TbxName)
        Me.Controls.Add(Me.LblAllergies)
        Me.Controls.Add(Me.LblBT)
        Me.Controls.Add(Me.LblHeight)
        Me.Controls.Add(Me.LblWeight)
        Me.Controls.Add(Me.LblEmail)
        Me.Controls.Add(Me.LblAdress)
        Me.Controls.Add(Me.LblIC)
        Me.Controls.Add(Me.LblPN)
        Me.Controls.Add(Me.LblAge)
        Me.Controls.Add(Me.LblName)
        Me.Controls.Add(Me.TiltleLabel)
        Me.Name = "Patient_Info"
        Me.Text = "Patient_Info"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TiltleLabel As Label
    Friend WithEvents LblName As Label
    Friend WithEvents LblAge As Label
    Friend WithEvents LblPN As Label
    Friend WithEvents LblIC As Label
    Friend WithEvents LblAdress As Label
    Friend WithEvents LblWeight As Label
    Friend WithEvents LblHeight As Label
    Friend WithEvents LblBT As Label
    Friend WithEvents LblAllergies As Label
    Friend WithEvents TbxName As TextBox
    Friend WithEvents TbxAge As TextBox
    Friend WithEvents TbxIC As TextBox
    Friend WithEvents TbxPN As TextBox
    Friend WithEvents TbxAddress As RichTextBox
    Friend WithEvents TbxHeight As TextBox
    Friend WithEvents TbxBT As TextBox
    Friend WithEvents TbxWeight As TextBox
    Friend WithEvents TbxAllergies As TextBox
    Friend WithEvents TbxPhone As TextBox
    Friend WithEvents LblPhone As Label
    Friend WithEvents LblEmail As Label
    Friend WithEvents TbxEMail As TextBox
    Friend WithEvents BtnCreateNurse As Button
    Friend WithEvents TbxPID As TextBox
    Friend WithEvents Label1 As Label
End Class
