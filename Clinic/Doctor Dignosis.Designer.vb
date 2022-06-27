<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Doctor_Dignosis
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
        Me.TbxDis = New System.Windows.Forms.RichTextBox()
        Me.TbxDate = New System.Windows.Forms.TextBox()
        Me.LblDate = New System.Windows.Forms.Label()
        Me.CbxC = New System.Windows.Forms.CheckBox()
        Me.CbxPHC = New System.Windows.Forms.CheckBox()
        Me.CbxCHC = New System.Windows.Forms.CheckBox()
        Me.CbxXray = New System.Windows.Forms.CheckBox()
        Me.CbxLB = New System.Windows.Forms.CheckBox()
        Me.LblDis = New System.Windows.Forms.Label()
        Me.TbxM = New System.Windows.Forms.RichTextBox()
        Me.TbxDia = New System.Windows.Forms.RichTextBox()
        Me.LblDiagnosis = New System.Windows.Forms.Label()
        Me.TbxAllergies = New System.Windows.Forms.TextBox()
        Me.TbxAge = New System.Windows.Forms.TextBox()
        Me.TbxPN = New System.Windows.Forms.TextBox()
        Me.TbxPID = New System.Windows.Forms.TextBox()
        Me.LblAllergies = New System.Windows.Forms.Label()
        Me.LblAge = New System.Windows.Forms.Label()
        Me.LblPN = New System.Windows.Forms.Label()
        Me.LblID = New System.Windows.Forms.Label()
        Me.BtnD = New System.Windows.Forms.Button()
        Me.LblMedecine = New System.Windows.Forms.Label()
        Me.BtnSearch = New System.Windows.Forms.Button()
        Me.LblTreatment = New System.Windows.Forms.Label()
        Me.TitleLable = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'TbxDis
        '
        Me.TbxDis.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.TbxDis.Location = New System.Drawing.Point(928, 459)
        Me.TbxDis.Name = "TbxDis"
        Me.TbxDis.Size = New System.Drawing.Size(345, 273)
        Me.TbxDis.TabIndex = 3
        Me.TbxDis.Text = ""
        '
        'TbxDate
        '
        Me.TbxDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.TbxDate.Location = New System.Drawing.Point(885, 400)
        Me.TbxDate.Name = "TbxDate"
        Me.TbxDate.ReadOnly = True
        Me.TbxDate.Size = New System.Drawing.Size(292, 35)
        Me.TbxDate.TabIndex = 85
        '
        'LblDate
        '
        Me.LblDate.AutoSize = True
        Me.LblDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.LblDate.Location = New System.Drawing.Point(796, 406)
        Me.LblDate.Name = "LblDate"
        Me.LblDate.Size = New System.Drawing.Size(63, 29)
        Me.LblDate.TabIndex = 84
        Me.LblDate.Text = "Date"
        '
        'CbxC
        '
        Me.CbxC.AutoSize = True
        Me.CbxC.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.CbxC.Location = New System.Drawing.Point(769, 324)
        Me.CbxC.Name = "CbxC"
        Me.CbxC.Size = New System.Drawing.Size(172, 33)
        Me.CbxC.TabIndex = 83
        Me.CbxC.Text = "Consultation"
        Me.CbxC.UseVisualStyleBackColor = True
        '
        'CbxPHC
        '
        Me.CbxPHC.AutoSize = True
        Me.CbxPHC.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.CbxPHC.Location = New System.Drawing.Point(963, 250)
        Me.CbxPHC.Name = "CbxPHC"
        Me.CbxPHC.Size = New System.Drawing.Size(256, 33)
        Me.CbxPHC.TabIndex = 82
        Me.CbxPHC.Text = "Partial Health Check"
        Me.CbxPHC.UseVisualStyleBackColor = True
        '
        'CbxCHC
        '
        Me.CbxCHC.AutoSize = True
        Me.CbxCHC.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.CbxCHC.Location = New System.Drawing.Point(963, 175)
        Me.CbxCHC.Name = "CbxCHC"
        Me.CbxCHC.Size = New System.Drawing.Size(331, 33)
        Me.CbxCHC.TabIndex = 81
        Me.CbxCHC.Text = "Comprensive Health Check"
        Me.CbxCHC.UseVisualStyleBackColor = True
        '
        'CbxXray
        '
        Me.CbxXray.AutoSize = True
        Me.CbxXray.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.CbxXray.Location = New System.Drawing.Point(769, 250)
        Me.CbxXray.Name = "CbxXray"
        Me.CbxXray.Size = New System.Drawing.Size(105, 33)
        Me.CbxXray.TabIndex = 80
        Me.CbxXray.Text = "X-Ray"
        Me.CbxXray.UseVisualStyleBackColor = True
        '
        'CbxLB
        '
        Me.CbxLB.AutoSize = True
        Me.CbxLB.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.CbxLB.Location = New System.Drawing.Point(769, 175)
        Me.CbxLB.Name = "CbxLB"
        Me.CbxLB.Size = New System.Drawing.Size(166, 33)
        Me.CbxLB.TabIndex = 79
        Me.CbxLB.Text = "Lab Service"
        Me.CbxLB.UseVisualStyleBackColor = True
        '
        'LblDis
        '
        Me.LblDis.AutoSize = True
        Me.LblDis.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.LblDis.Location = New System.Drawing.Point(787, 464)
        Me.LblDis.Name = "LblDis"
        Me.LblDis.Size = New System.Drawing.Size(135, 29)
        Me.LblDis.TabIndex = 78
        Me.LblDis.Text = "Description"
        '
        'TbxM
        '
        Me.TbxM.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.TbxM.Location = New System.Drawing.Point(302, 609)
        Me.TbxM.Name = "TbxM"
        Me.TbxM.Size = New System.Drawing.Size(479, 132)
        Me.TbxM.TabIndex = 2
        Me.TbxM.Text = ""
        '
        'TbxDia
        '
        Me.TbxDia.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.TbxDia.Location = New System.Drawing.Point(302, 459)
        Me.TbxDia.Name = "TbxDia"
        Me.TbxDia.Size = New System.Drawing.Size(479, 132)
        Me.TbxDia.TabIndex = 1
        Me.TbxDia.Text = ""
        '
        'LblDiagnosis
        '
        Me.LblDiagnosis.AutoSize = True
        Me.LblDiagnosis.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.LblDiagnosis.Location = New System.Drawing.Point(160, 480)
        Me.LblDiagnosis.Name = "LblDiagnosis"
        Me.LblDiagnosis.Size = New System.Drawing.Size(120, 29)
        Me.LblDiagnosis.TabIndex = 75
        Me.LblDiagnosis.Text = "Diagnosis"
        '
        'TbxAllergies
        '
        Me.TbxAllergies.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.TbxAllergies.Location = New System.Drawing.Point(302, 400)
        Me.TbxAllergies.Name = "TbxAllergies"
        Me.TbxAllergies.ReadOnly = True
        Me.TbxAllergies.Size = New System.Drawing.Size(292, 35)
        Me.TbxAllergies.TabIndex = 74
        '
        'TbxAge
        '
        Me.TbxAge.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.TbxAge.Location = New System.Drawing.Point(302, 336)
        Me.TbxAge.Name = "TbxAge"
        Me.TbxAge.ReadOnly = True
        Me.TbxAge.Size = New System.Drawing.Size(292, 35)
        Me.TbxAge.TabIndex = 73
        '
        'TbxPN
        '
        Me.TbxPN.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.TbxPN.Location = New System.Drawing.Point(312, 242)
        Me.TbxPN.Name = "TbxPN"
        Me.TbxPN.ReadOnly = True
        Me.TbxPN.Size = New System.Drawing.Size(292, 35)
        Me.TbxPN.TabIndex = 72
        '
        'TbxPID
        '
        Me.TbxPID.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.TbxPID.Location = New System.Drawing.Point(302, 173)
        Me.TbxPID.Name = "TbxPID"
        Me.TbxPID.Size = New System.Drawing.Size(292, 35)
        Me.TbxPID.TabIndex = 0
        '
        'LblAllergies
        '
        Me.LblAllergies.AutoSize = True
        Me.LblAllergies.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.LblAllergies.Location = New System.Drawing.Point(172, 400)
        Me.LblAllergies.Name = "LblAllergies"
        Me.LblAllergies.Size = New System.Drawing.Size(108, 29)
        Me.LblAllergies.TabIndex = 70
        Me.LblAllergies.Text = "Allergies"
        '
        'LblAge
        '
        Me.LblAge.AutoSize = True
        Me.LblAge.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.LblAge.Location = New System.Drawing.Point(224, 324)
        Me.LblAge.Name = "LblAge"
        Me.LblAge.Size = New System.Drawing.Size(56, 29)
        Me.LblAge.TabIndex = 69
        Me.LblAge.Text = "Age"
        '
        'LblPN
        '
        Me.LblPN.AutoSize = True
        Me.LblPN.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.LblPN.Location = New System.Drawing.Point(122, 248)
        Me.LblPN.Name = "LblPN"
        Me.LblPN.Size = New System.Drawing.Size(158, 29)
        Me.LblPN.TabIndex = 68
        Me.LblPN.Text = "Patient Name"
        '
        'LblID
        '
        Me.LblID.AutoSize = True
        Me.LblID.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.LblID.Location = New System.Drawing.Point(155, 173)
        Me.LblID.Name = "LblID"
        Me.LblID.Size = New System.Drawing.Size(116, 29)
        Me.LblID.TabIndex = 67
        Me.LblID.Text = "Patient ID"
        '
        'BtnD
        '
        Me.BtnD.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.BtnD.Location = New System.Drawing.Point(792, 814)
        Me.BtnD.Name = "BtnD"
        Me.BtnD.Size = New System.Drawing.Size(193, 72)
        Me.BtnD.TabIndex = 88
        Me.BtnD.Text = "Diagnosis"
        Me.BtnD.UseVisualStyleBackColor = True
        '
        'LblMedecine
        '
        Me.LblMedecine.AutoSize = True
        Me.LblMedecine.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.LblMedecine.Location = New System.Drawing.Point(151, 650)
        Me.LblMedecine.Name = "LblMedecine"
        Me.LblMedecine.Size = New System.Drawing.Size(120, 29)
        Me.LblMedecine.TabIndex = 87
        Me.LblMedecine.Text = "Medecine"
        '
        'BtnSearch
        '
        Me.BtnSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.BtnSearch.Location = New System.Drawing.Point(312, 814)
        Me.BtnSearch.Name = "BtnSearch"
        Me.BtnSearch.Size = New System.Drawing.Size(193, 72)
        Me.BtnSearch.TabIndex = 89
        Me.BtnSearch.Text = "Search"
        Me.BtnSearch.UseVisualStyleBackColor = True
        '
        'LblTreatment
        '
        Me.LblTreatment.AutoSize = True
        Me.LblTreatment.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.LblTreatment.Location = New System.Drawing.Point(619, 179)
        Me.LblTreatment.Name = "LblTreatment"
        Me.LblTreatment.Size = New System.Drawing.Size(123, 29)
        Me.LblTreatment.TabIndex = 90
        Me.LblTreatment.Text = "Treatment"
        '
        'TitleLable
        '
        Me.TitleLable.AutoSize = True
        Me.TitleLable.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.0!)
        Me.TitleLable.Location = New System.Drawing.Point(494, 64)
        Me.TitleLable.Name = "TitleLable"
        Me.TitleLable.Size = New System.Drawing.Size(378, 52)
        Me.TitleLable.TabIndex = 91
        Me.TitleLable.Text = "Doctors Diagnosis"
        '
        'Doctor_Dignosis
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1389, 915)
        Me.Controls.Add(Me.TitleLable)
        Me.Controls.Add(Me.LblTreatment)
        Me.Controls.Add(Me.BtnSearch)
        Me.Controls.Add(Me.BtnD)
        Me.Controls.Add(Me.LblMedecine)
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
        Me.Name = "Doctor_Dignosis"
        Me.Text = "Doctor_Dignosis"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TbxDis As RichTextBox
    Friend WithEvents TbxDate As TextBox
    Friend WithEvents LblDate As Label
    Friend WithEvents CbxC As CheckBox
    Friend WithEvents CbxPHC As CheckBox
    Friend WithEvents CbxCHC As CheckBox
    Friend WithEvents CbxXray As CheckBox
    Friend WithEvents CbxLB As CheckBox
    Friend WithEvents LblDis As Label
    Friend WithEvents TbxM As RichTextBox
    Friend WithEvents TbxDia As RichTextBox
    Friend WithEvents LblDiagnosis As Label
    Friend WithEvents TbxAllergies As TextBox
    Friend WithEvents TbxAge As TextBox
    Friend WithEvents TbxPN As TextBox
    Friend WithEvents TbxPID As TextBox
    Friend WithEvents LblAllergies As Label
    Friend WithEvents LblAge As Label
    Friend WithEvents LblPN As Label
    Friend WithEvents LblID As Label
    Friend WithEvents BtnD As Button
    Friend WithEvents LblMedecine As Label
    Friend WithEvents BtnSearch As Button
    Friend WithEvents LblTreatment As Label
    Friend WithEvents TitleLable As Label
End Class
