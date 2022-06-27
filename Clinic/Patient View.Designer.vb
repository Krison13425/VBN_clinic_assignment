<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Patient_View
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
        Me.TbxAllergies = New System.Windows.Forms.TextBox()
        Me.TbxAge = New System.Windows.Forms.TextBox()
        Me.TbxPN = New System.Windows.Forms.TextBox()
        Me.TbxPID = New System.Windows.Forms.TextBox()
        Me.LblAllergies = New System.Windows.Forms.Label()
        Me.LblAge = New System.Windows.Forms.Label()
        Me.LblPN = New System.Windows.Forms.Label()
        Me.LblID = New System.Windows.Forms.Label()
        Me.LblDis = New System.Windows.Forms.Label()
        Me.TbxM = New System.Windows.Forms.RichTextBox()
        Me.LblMedecine = New System.Windows.Forms.Label()
        Me.TbxDia = New System.Windows.Forms.RichTextBox()
        Me.LblDiagnosis = New System.Windows.Forms.Label()
        Me.TbxDate = New System.Windows.Forms.TextBox()
        Me.LblDate = New System.Windows.Forms.Label()
        Me.CbxC = New System.Windows.Forms.CheckBox()
        Me.CbxPHC = New System.Windows.Forms.CheckBox()
        Me.CbxCHC = New System.Windows.Forms.CheckBox()
        Me.CbxXray = New System.Windows.Forms.CheckBox()
        Me.CbxLB = New System.Windows.Forms.CheckBox()
        Me.TbxDis = New System.Windows.Forms.RichTextBox()
        Me.BtnView = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'TbxAllergies
        '
        Me.TbxAllergies.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.TbxAllergies.Location = New System.Drawing.Point(252, 383)
        Me.TbxAllergies.Name = "TbxAllergies"
        Me.TbxAllergies.ReadOnly = True
        Me.TbxAllergies.Size = New System.Drawing.Size(292, 35)
        Me.TbxAllergies.TabIndex = 23
        '
        'TbxAge
        '
        Me.TbxAge.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.TbxAge.Location = New System.Drawing.Point(252, 319)
        Me.TbxAge.Name = "TbxAge"
        Me.TbxAge.ReadOnly = True
        Me.TbxAge.Size = New System.Drawing.Size(292, 35)
        Me.TbxAge.TabIndex = 22
        '
        'TbxPN
        '
        Me.TbxPN.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.TbxPN.Location = New System.Drawing.Point(252, 233)
        Me.TbxPN.Name = "TbxPN"
        Me.TbxPN.ReadOnly = True
        Me.TbxPN.Size = New System.Drawing.Size(292, 35)
        Me.TbxPN.TabIndex = 21
        '
        'TbxPID
        '
        Me.TbxPID.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.TbxPID.Location = New System.Drawing.Point(252, 156)
        Me.TbxPID.Name = "TbxPID"
        Me.TbxPID.Size = New System.Drawing.Size(292, 35)
        Me.TbxPID.TabIndex = 20
        '
        'LblAllergies
        '
        Me.LblAllergies.AutoSize = True
        Me.LblAllergies.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.LblAllergies.Location = New System.Drawing.Point(122, 383)
        Me.LblAllergies.Name = "LblAllergies"
        Me.LblAllergies.Size = New System.Drawing.Size(108, 29)
        Me.LblAllergies.TabIndex = 19
        Me.LblAllergies.Text = "Allergies"
        '
        'LblAge
        '
        Me.LblAge.AutoSize = True
        Me.LblAge.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.LblAge.Location = New System.Drawing.Point(174, 307)
        Me.LblAge.Name = "LblAge"
        Me.LblAge.Size = New System.Drawing.Size(56, 29)
        Me.LblAge.TabIndex = 18
        Me.LblAge.Text = "Age"
        '
        'LblPN
        '
        Me.LblPN.AutoSize = True
        Me.LblPN.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.LblPN.Location = New System.Drawing.Point(72, 231)
        Me.LblPN.Name = "LblPN"
        Me.LblPN.Size = New System.Drawing.Size(158, 29)
        Me.LblPN.TabIndex = 17
        Me.LblPN.Text = "Patient Name"
        '
        'LblID
        '
        Me.LblID.AutoSize = True
        Me.LblID.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.LblID.Location = New System.Drawing.Point(105, 156)
        Me.LblID.Name = "LblID"
        Me.LblID.Size = New System.Drawing.Size(116, 29)
        Me.LblID.TabIndex = 16
        Me.LblID.Text = "Patient ID"
        '
        'LblDis
        '
        Me.LblDis.AutoSize = True
        Me.LblDis.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.LblDis.Location = New System.Drawing.Point(737, 447)
        Me.LblDis.Name = "LblDis"
        Me.LblDis.Size = New System.Drawing.Size(135, 29)
        Me.LblDis.TabIndex = 58
        Me.LblDis.Text = "Description"
        '
        'TbxM
        '
        Me.TbxM.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.TbxM.Location = New System.Drawing.Point(252, 592)
        Me.TbxM.Name = "TbxM"
        Me.TbxM.ReadOnly = True
        Me.TbxM.Size = New System.Drawing.Size(479, 132)
        Me.TbxM.TabIndex = 57
        Me.TbxM.Text = ""
        '
        'LblMedecine
        '
        Me.LblMedecine.AutoSize = True
        Me.LblMedecine.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.LblMedecine.Location = New System.Drawing.Point(101, 611)
        Me.LblMedecine.Name = "LblMedecine"
        Me.LblMedecine.Size = New System.Drawing.Size(120, 29)
        Me.LblMedecine.TabIndex = 56
        Me.LblMedecine.Text = "Medecine"
        '
        'TbxDia
        '
        Me.TbxDia.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.TbxDia.Location = New System.Drawing.Point(252, 442)
        Me.TbxDia.Name = "TbxDia"
        Me.TbxDia.ReadOnly = True
        Me.TbxDia.Size = New System.Drawing.Size(479, 132)
        Me.TbxDia.TabIndex = 55
        Me.TbxDia.Text = ""
        '
        'LblDiagnosis
        '
        Me.LblDiagnosis.AutoSize = True
        Me.LblDiagnosis.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.LblDiagnosis.Location = New System.Drawing.Point(45, 460)
        Me.LblDiagnosis.Name = "LblDiagnosis"
        Me.LblDiagnosis.Size = New System.Drawing.Size(176, 29)
        Me.LblDiagnosis.TabIndex = 54
        Me.LblDiagnosis.Text = "DR's Diagnosis"
        '
        'TbxDate
        '
        Me.TbxDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.TbxDate.Location = New System.Drawing.Point(835, 383)
        Me.TbxDate.Name = "TbxDate"
        Me.TbxDate.ReadOnly = True
        Me.TbxDate.Size = New System.Drawing.Size(292, 35)
        Me.TbxDate.TabIndex = 65
        '
        'LblDate
        '
        Me.LblDate.AutoSize = True
        Me.LblDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.LblDate.Location = New System.Drawing.Point(746, 389)
        Me.LblDate.Name = "LblDate"
        Me.LblDate.Size = New System.Drawing.Size(63, 29)
        Me.LblDate.TabIndex = 64
        Me.LblDate.Text = "Date"
        '
        'CbxC
        '
        Me.CbxC.AutoSize = True
        Me.CbxC.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.CbxC.Location = New System.Drawing.Point(719, 307)
        Me.CbxC.Name = "CbxC"
        Me.CbxC.Size = New System.Drawing.Size(172, 33)
        Me.CbxC.TabIndex = 63
        Me.CbxC.Text = "Consultation"
        Me.CbxC.UseVisualStyleBackColor = True
        '
        'CbxPHC
        '
        Me.CbxPHC.AutoSize = True
        Me.CbxPHC.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.CbxPHC.Location = New System.Drawing.Point(913, 233)
        Me.CbxPHC.Name = "CbxPHC"
        Me.CbxPHC.Size = New System.Drawing.Size(256, 33)
        Me.CbxPHC.TabIndex = 62
        Me.CbxPHC.Text = "Partial Health Check"
        Me.CbxPHC.UseVisualStyleBackColor = True
        '
        'CbxCHC
        '
        Me.CbxCHC.AutoSize = True
        Me.CbxCHC.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.CbxCHC.Location = New System.Drawing.Point(913, 158)
        Me.CbxCHC.Name = "CbxCHC"
        Me.CbxCHC.Size = New System.Drawing.Size(331, 33)
        Me.CbxCHC.TabIndex = 61
        Me.CbxCHC.Text = "Comprensive Health Check"
        Me.CbxCHC.UseVisualStyleBackColor = True
        '
        'CbxXray
        '
        Me.CbxXray.AutoSize = True
        Me.CbxXray.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.CbxXray.Location = New System.Drawing.Point(719, 233)
        Me.CbxXray.Name = "CbxXray"
        Me.CbxXray.Size = New System.Drawing.Size(105, 33)
        Me.CbxXray.TabIndex = 60
        Me.CbxXray.Text = "X-Ray"
        Me.CbxXray.UseVisualStyleBackColor = True
        '
        'CbxLB
        '
        Me.CbxLB.AutoSize = True
        Me.CbxLB.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.CbxLB.Location = New System.Drawing.Point(719, 158)
        Me.CbxLB.Name = "CbxLB"
        Me.CbxLB.Size = New System.Drawing.Size(166, 33)
        Me.CbxLB.TabIndex = 59
        Me.CbxLB.Text = "Lab Service"
        Me.CbxLB.UseVisualStyleBackColor = True
        '
        'TbxDis
        '
        Me.TbxDis.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.TbxDis.Location = New System.Drawing.Point(878, 442)
        Me.TbxDis.Name = "TbxDis"
        Me.TbxDis.ReadOnly = True
        Me.TbxDis.Size = New System.Drawing.Size(345, 273)
        Me.TbxDis.TabIndex = 66
        Me.TbxDis.Text = ""
        '
        'BtnView
        '
        Me.BtnView.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.BtnView.Location = New System.Drawing.Point(616, 761)
        Me.BtnView.Name = "BtnView"
        Me.BtnView.Size = New System.Drawing.Size(193, 72)
        Me.BtnView.TabIndex = 67
        Me.BtnView.Text = "View"
        Me.BtnView.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.0!)
        Me.Label1.Location = New System.Drawing.Point(492, 42)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(265, 52)
        Me.Label1.TabIndex = 68
        Me.Label1.Text = "Patient View"
        '
        'Patient_View
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1389, 915)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BtnView)
        Me.Controls.Add(Me.TbxDis)
        Me.Controls.Add(Me.TbxDate)
        Me.Controls.Add(Me.LblDate)
        Me.Controls.Add(Me.CbxC)
        Me.Controls.Add(Me.CbxPHC)
        Me.Controls.Add(Me.CbxCHC)
        Me.Controls.Add(Me.CbxXray)
        Me.Controls.Add(Me.CbxLB)
        Me.Controls.Add(Me.LblDis)
        Me.Controls.Add(Me.TbxM)
        Me.Controls.Add(Me.LblMedecine)
        Me.Controls.Add(Me.TbxDia)
        Me.Controls.Add(Me.LblDiagnosis)
        Me.Controls.Add(Me.TbxAllergies)
        Me.Controls.Add(Me.TbxAge)
        Me.Controls.Add(Me.TbxPN)
        Me.Controls.Add(Me.TbxPID)
        Me.Controls.Add(Me.LblAllergies)
        Me.Controls.Add(Me.LblAge)
        Me.Controls.Add(Me.LblPN)
        Me.Controls.Add(Me.LblID)
        Me.Name = "Patient_View"
        Me.Text = "Patient_View"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TbxAllergies As TextBox
    Friend WithEvents TbxAge As TextBox
    Friend WithEvents TbxPN As TextBox
    Friend WithEvents TbxPID As TextBox
    Friend WithEvents LblAllergies As Label
    Friend WithEvents LblAge As Label
    Friend WithEvents LblPN As Label
    Friend WithEvents LblID As Label
    Friend WithEvents LblDis As Label
    Friend WithEvents TbxM As RichTextBox
    Friend WithEvents LblMedecine As Label
    Friend WithEvents TbxDia As RichTextBox
    Friend WithEvents LblDiagnosis As Label
    Friend WithEvents TbxDate As TextBox
    Friend WithEvents LblDate As Label
    Friend WithEvents CbxC As CheckBox
    Friend WithEvents CbxPHC As CheckBox
    Friend WithEvents CbxCHC As CheckBox
    Friend WithEvents CbxXray As CheckBox
    Friend WithEvents CbxLB As CheckBox
    Friend WithEvents TbxDis As RichTextBox
    Friend WithEvents BtnView As Button
    Friend WithEvents Label1 As Label
End Class
