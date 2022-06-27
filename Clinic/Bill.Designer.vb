<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Bill_Statement
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
        Me.LblPN = New System.Windows.Forms.Label()
        Me.LblPID = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.FileSystemWatcher1 = New System.IO.FileSystemWatcher()
        Me.TbxPID = New System.Windows.Forms.TextBox()
        Me.TbxPN = New System.Windows.Forms.TextBox()
        Me.TbxD = New System.Windows.Forms.TextBox()
        Me.LblDate = New System.Windows.Forms.Label()
        Me.LblActivities = New System.Windows.Forms.Label()
        Me.LblCharges = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.LblRMXRay = New System.Windows.Forms.Label()
        Me.LblRMCHC = New System.Windows.Forms.Label()
        Me.LblRMPHC = New System.Windows.Forms.Label()
        Me.LblRMC = New System.Windows.Forms.Label()
        Me.LblRMLB = New System.Windows.Forms.Label()
        Me.TbxM = New System.Windows.Forms.TextBox()
        Me.BtnPay = New System.Windows.Forms.Button()
        Me.LblTotal = New System.Windows.Forms.Label()
        Me.LblRMTotal = New System.Windows.Forms.Label()
        Me.BtnSearch = New System.Windows.Forms.Button()
        Me.CbxLB = New System.Windows.Forms.CheckBox()
        Me.CbxXray = New System.Windows.Forms.CheckBox()
        Me.CbxCHC = New System.Windows.Forms.CheckBox()
        Me.CbxPHC = New System.Windows.Forms.CheckBox()
        Me.CbxC = New System.Windows.Forms.CheckBox()
        Me.LblM = New System.Windows.Forms.Label()
        CType(Me.FileSystemWatcher1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LblPN
        '
        Me.LblPN.AutoSize = True
        Me.LblPN.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.LblPN.Location = New System.Drawing.Point(337, 104)
        Me.LblPN.Name = "LblPN"
        Me.LblPN.Size = New System.Drawing.Size(158, 29)
        Me.LblPN.TabIndex = 0
        Me.LblPN.Text = "Patient Name"
        '
        'LblPID
        '
        Me.LblPID.AutoSize = True
        Me.LblPID.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.LblPID.Location = New System.Drawing.Point(56, 104)
        Me.LblPID.Name = "LblPID"
        Me.LblPID.Size = New System.Drawing.Size(116, 29)
        Me.LblPID.TabIndex = 1
        Me.LblPID.Text = "Patient ID"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(486, 28)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(266, 46)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Bill Statement"
        '
        'FileSystemWatcher1
        '
        Me.FileSystemWatcher1.EnableRaisingEvents = True
        Me.FileSystemWatcher1.SynchronizingObject = Me
        '
        'TbxPID
        '
        Me.TbxPID.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.TbxPID.Location = New System.Drawing.Point(178, 104)
        Me.TbxPID.Name = "TbxPID"
        Me.TbxPID.Size = New System.Drawing.Size(135, 35)
        Me.TbxPID.TabIndex = 19
        '
        'TbxPN
        '
        Me.TbxPN.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.TbxPN.Location = New System.Drawing.Point(501, 104)
        Me.TbxPN.Name = "TbxPN"
        Me.TbxPN.ReadOnly = True
        Me.TbxPN.Size = New System.Drawing.Size(251, 35)
        Me.TbxPN.TabIndex = 20
        '
        'TbxD
        '
        Me.TbxD.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.TbxD.Location = New System.Drawing.Point(900, 104)
        Me.TbxD.Name = "TbxD"
        Me.TbxD.ReadOnly = True
        Me.TbxD.Size = New System.Drawing.Size(251, 35)
        Me.TbxD.TabIndex = 22
        '
        'LblDate
        '
        Me.LblDate.AutoSize = True
        Me.LblDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.LblDate.Location = New System.Drawing.Point(831, 110)
        Me.LblDate.Name = "LblDate"
        Me.LblDate.Size = New System.Drawing.Size(63, 29)
        Me.LblDate.TabIndex = 21
        Me.LblDate.Text = "Date"
        '
        'LblActivities
        '
        Me.LblActivities.AutoSize = True
        Me.LblActivities.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.LblActivities.Location = New System.Drawing.Point(242, 204)
        Me.LblActivities.Name = "LblActivities"
        Me.LblActivities.Size = New System.Drawing.Size(107, 29)
        Me.LblActivities.TabIndex = 23
        Me.LblActivities.Text = "Activities"
        '
        'LblCharges
        '
        Me.LblCharges.AutoSize = True
        Me.LblCharges.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.LblCharges.Location = New System.Drawing.Point(924, 204)
        Me.LblCharges.Name = "LblCharges"
        Me.LblCharges.Size = New System.Drawing.Size(163, 29)
        Me.LblCharges.TabIndex = 30
        Me.LblCharges.Text = "Charges (RM)"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label2.Location = New System.Drawing.Point(924, 291)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(0, 29)
        Me.Label2.TabIndex = 31
        '
        'LblRMXRay
        '
        Me.LblRMXRay.AutoSize = True
        Me.LblRMXRay.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.LblRMXRay.Location = New System.Drawing.Point(924, 344)
        Me.LblRMXRay.Name = "LblRMXRay"
        Me.LblRMXRay.Size = New System.Drawing.Size(21, 29)
        Me.LblRMXRay.TabIndex = 32
        Me.LblRMXRay.Text = "-"
        '
        'LblRMCHC
        '
        Me.LblRMCHC.AutoSize = True
        Me.LblRMCHC.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.LblRMCHC.Location = New System.Drawing.Point(924, 391)
        Me.LblRMCHC.Name = "LblRMCHC"
        Me.LblRMCHC.Size = New System.Drawing.Size(21, 29)
        Me.LblRMCHC.TabIndex = 33
        Me.LblRMCHC.Text = "-"
        '
        'LblRMPHC
        '
        Me.LblRMPHC.AutoSize = True
        Me.LblRMPHC.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.LblRMPHC.Location = New System.Drawing.Point(924, 448)
        Me.LblRMPHC.Name = "LblRMPHC"
        Me.LblRMPHC.Size = New System.Drawing.Size(21, 29)
        Me.LblRMPHC.TabIndex = 34
        Me.LblRMPHC.Text = "-"
        '
        'LblRMC
        '
        Me.LblRMC.AutoSize = True
        Me.LblRMC.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.LblRMC.Location = New System.Drawing.Point(924, 502)
        Me.LblRMC.Name = "LblRMC"
        Me.LblRMC.Size = New System.Drawing.Size(21, 29)
        Me.LblRMC.TabIndex = 35
        Me.LblRMC.Text = "-"
        '
        'LblRMLB
        '
        Me.LblRMLB.AutoSize = True
        Me.LblRMLB.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.LblRMLB.Location = New System.Drawing.Point(924, 291)
        Me.LblRMLB.Name = "LblRMLB"
        Me.LblRMLB.Size = New System.Drawing.Size(21, 29)
        Me.LblRMLB.TabIndex = 37
        Me.LblRMLB.Text = "-"
        '
        'TbxM
        '
        Me.TbxM.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.TbxM.Location = New System.Drawing.Point(929, 551)
        Me.TbxM.Name = "TbxM"
        Me.TbxM.Size = New System.Drawing.Size(251, 35)
        Me.TbxM.TabIndex = 38
        '
        'BtnPay
        '
        Me.BtnPay.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.BtnPay.Location = New System.Drawing.Point(944, 682)
        Me.BtnPay.Name = "BtnPay"
        Me.BtnPay.Size = New System.Drawing.Size(175, 49)
        Me.BtnPay.TabIndex = 39
        Me.BtnPay.Text = "Pay"
        Me.BtnPay.UseVisualStyleBackColor = True
        '
        'LblTotal
        '
        Me.LblTotal.AutoSize = True
        Me.LblTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.LblTotal.Location = New System.Drawing.Point(856, 627)
        Me.LblTotal.Name = "LblTotal"
        Me.LblTotal.Size = New System.Drawing.Size(68, 29)
        Me.LblTotal.TabIndex = 40
        Me.LblTotal.Text = "Total"
        '
        'LblRMTotal
        '
        Me.LblRMTotal.AutoSize = True
        Me.LblRMTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.LblRMTotal.Location = New System.Drawing.Point(939, 627)
        Me.LblRMTotal.Name = "LblRMTotal"
        Me.LblRMTotal.Size = New System.Drawing.Size(21, 29)
        Me.LblRMTotal.TabIndex = 41
        Me.LblRMTotal.Text = "-"
        '
        'BtnSearch
        '
        Me.BtnSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.BtnSearch.Location = New System.Drawing.Point(292, 682)
        Me.BtnSearch.Name = "BtnSearch"
        Me.BtnSearch.Size = New System.Drawing.Size(186, 49)
        Me.BtnSearch.TabIndex = 42
        Me.BtnSearch.Text = "Search"
        Me.BtnSearch.UseVisualStyleBackColor = True
        '
        'CbxLB
        '
        Me.CbxLB.AutoSize = True
        Me.CbxLB.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.CbxLB.Location = New System.Drawing.Point(222, 291)
        Me.CbxLB.Name = "CbxLB"
        Me.CbxLB.Size = New System.Drawing.Size(166, 33)
        Me.CbxLB.TabIndex = 43
        Me.CbxLB.Text = "Lab Service"
        Me.CbxLB.UseVisualStyleBackColor = True
        '
        'CbxXray
        '
        Me.CbxXray.AutoSize = True
        Me.CbxXray.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.CbxXray.Location = New System.Drawing.Point(222, 340)
        Me.CbxXray.Name = "CbxXray"
        Me.CbxXray.Size = New System.Drawing.Size(105, 33)
        Me.CbxXray.TabIndex = 44
        Me.CbxXray.Text = "X-Ray"
        Me.CbxXray.UseVisualStyleBackColor = True
        '
        'CbxCHC
        '
        Me.CbxCHC.AutoSize = True
        Me.CbxCHC.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.CbxCHC.Location = New System.Drawing.Point(222, 387)
        Me.CbxCHC.Name = "CbxCHC"
        Me.CbxCHC.Size = New System.Drawing.Size(331, 33)
        Me.CbxCHC.TabIndex = 45
        Me.CbxCHC.Text = "Comprensive Health Check"
        Me.CbxCHC.UseVisualStyleBackColor = True
        '
        'CbxPHC
        '
        Me.CbxPHC.AutoSize = True
        Me.CbxPHC.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.CbxPHC.Location = New System.Drawing.Point(222, 444)
        Me.CbxPHC.Name = "CbxPHC"
        Me.CbxPHC.Size = New System.Drawing.Size(256, 33)
        Me.CbxPHC.TabIndex = 46
        Me.CbxPHC.Text = "Partial Health Check"
        Me.CbxPHC.UseVisualStyleBackColor = True
        '
        'CbxC
        '
        Me.CbxC.AutoSize = True
        Me.CbxC.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.CbxC.Location = New System.Drawing.Point(222, 501)
        Me.CbxC.Name = "CbxC"
        Me.CbxC.Size = New System.Drawing.Size(172, 33)
        Me.CbxC.TabIndex = 47
        Me.CbxC.Text = "Consultation"
        Me.CbxC.UseVisualStyleBackColor = True
        '
        'LblM
        '
        Me.LblM.AutoSize = True
        Me.LblM.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.LblM.Location = New System.Drawing.Point(242, 551)
        Me.LblM.Name = "LblM"
        Me.LblM.Size = New System.Drawing.Size(124, 29)
        Me.LblM.TabIndex = 48
        Me.LblM.Text = "Medicines"
        '
        'Bill_Statement
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1229, 808)
        Me.Controls.Add(Me.LblM)
        Me.Controls.Add(Me.CbxC)
        Me.Controls.Add(Me.CbxPHC)
        Me.Controls.Add(Me.CbxCHC)
        Me.Controls.Add(Me.CbxXray)
        Me.Controls.Add(Me.CbxLB)
        Me.Controls.Add(Me.BtnSearch)
        Me.Controls.Add(Me.LblRMTotal)
        Me.Controls.Add(Me.LblTotal)
        Me.Controls.Add(Me.BtnPay)
        Me.Controls.Add(Me.TbxM)
        Me.Controls.Add(Me.LblRMLB)
        Me.Controls.Add(Me.LblRMC)
        Me.Controls.Add(Me.LblRMPHC)
        Me.Controls.Add(Me.LblRMCHC)
        Me.Controls.Add(Me.LblRMXRay)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.LblCharges)
        Me.Controls.Add(Me.LblActivities)
        Me.Controls.Add(Me.TbxD)
        Me.Controls.Add(Me.LblDate)
        Me.Controls.Add(Me.TbxPN)
        Me.Controls.Add(Me.TbxPID)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.LblPID)
        Me.Controls.Add(Me.LblPN)
        Me.Name = "Bill_Statement"
        Me.Text = "Bill_Statement"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.FileSystemWatcher1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LblPN As Label
    Friend WithEvents LblPID As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents FileSystemWatcher1 As IO.FileSystemWatcher
    Friend WithEvents LblActivities As Label
    Friend WithEvents TbxD As TextBox
    Friend WithEvents LblDate As Label
    Friend WithEvents TbxPN As TextBox
    Friend WithEvents TbxPID As TextBox
    Friend WithEvents LblRMTotal As Label
    Friend WithEvents LblTotal As Label
    Friend WithEvents BtnPay As Button
    Friend WithEvents TbxM As TextBox
    Friend WithEvents LblRMLB As Label
    Friend WithEvents LblRMC As Label
    Friend WithEvents LblRMPHC As Label
    Friend WithEvents LblRMCHC As Label
    Friend WithEvents LblRMXRay As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents LblCharges As Label
    Friend WithEvents BtnSearch As Button
    Friend WithEvents CbxC As CheckBox
    Friend WithEvents CbxPHC As CheckBox
    Friend WithEvents CbxCHC As CheckBox
    Friend WithEvents CbxXray As CheckBox
    Friend WithEvents CbxLB As CheckBox
    Friend WithEvents LblM As Label
End Class
