Public Class Bill_Statement
    Private SQL As New SQLControl
    Private Sub Bill_Statement_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MdiParent = Nurse
    End Sub

    Private Sub Search(PatientID As String)
        SQL.AddParam("@PID", PatientID)
        SQL.ExecQurey("SELECT TOP 1 * " &
                      "FROM Bill " &
                      "WHERE PatientID=@PID;")
        If SQL.Recordcount < 1 Then Exit Sub
        For Each r As DataRow In SQL.DBDT.Rows
            TbxPID.Text = r("PatientID")
            TbxPN.Text = r("PatientName")
            TbxD.Text = r("Date")
            CbxLB.Checked = r("Lab_Service")
            CbxXray.Checked = r("XRay")
            CbxCHC.Checked = r("Comprensive_Health_Check")
            CbxPHC.Checked = r("Partial_Health_Check")
            CbxC.Checked = r("Consultation")
            If CbxLB.Checked = True Then
                LblRMLB.Text = 100
                CbxXray.Checked = True
                LblRMXRay.Text = 50
                CbxCHC.Checked = True
                LblRMCHC.Text = 120
                CbxPHC.Checked = True
                LblRMPHC.Text = 75
                CbxC.Checked = True
                LblRMC.Text = 30
            End If
        Next
        If SQL.HasExecption(True) Then Exit Sub
    End Sub
    Private Sub Pay()
        SQL.AddParam("@PID", TbxPID.Text)
        SQL.AddParam("@Medicine", TbxM.Text)
        SQL.AddParam("@T", LblRMTotal.Text)
        SQL.ExecQurey("INSERT INTO BillTotal (PatientID,Medicine,Total)" &
                      "VALUES (@PID,@Medicine,@T);")
        If SQL.HasExecption(True) Then Exit Sub
    End Sub

    Private Sub BtnSearch_Click(sender As Object, e As EventArgs) Handles BtnSearch.Click
        Search(TbxPID.Text)
    End Sub
    Public total As Integer
    Private Sub BtnPay_Click(sender As Object, e As EventArgs) Handles BtnPay.Click
        total = Val(LblRMLB.Text) + Val(LblRMXRay.Text) + Val(LblRMCHC.Text) + Val(LblRMPHC.Text) + Val(LblRMC.Text) + Val(TbxM.Text)
        LblRMTotal.Text = Val(total)
        Pay()
        Cal.Show()
    End Sub

    Private Sub TbxPID_KeyDown(sender As Object, e As KeyEventArgs) Handles TbxPID.KeyDown
        If e.KeyCode = Keys.Enter Then
            BtnSearch_Click(Nothing, Nothing)
            e.Handled = True
            e.SuppressKeyPress = True
        End If
    End Sub

    Private Sub TbxM_KeyDown(sender As Object, e As KeyEventArgs) Handles TbxM.KeyDown
        If e.KeyCode = Keys.Enter Then
            BtnPay_Click(Nothing, Nothing)
            e.Handled = True
            e.SuppressKeyPress = True
        End If
    End Sub
End Class