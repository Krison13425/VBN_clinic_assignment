Public Class Doctor_Dignosis
    Private SQL As New SQLControl
    Private Sub Doctor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MdiParent = Doctor
    End Sub
    Private Sub Serch(PatientID As String)
        SQL.AddParam("@PID", PatientID)
        SQL.ExecQurey("SELECT TOP 1 *" &
                  "FROM NursePatient " &
                  "WHERE PatientID=@PID;")
        If SQL.Recordcount < 1 Then Exit Sub

        For Each r As DataRow In SQL.DBDT.Rows
            TbxPID.Text = r("PatientID")
            TbxPN.Text = r("PatientName")
            TbxAge.Text = r("Age")
            TbxAllergies.Text = r("Allergies")
            TbxDate.Text = r("Date")
        Next
    End Sub
    Private Sub DBill()
        SQL.AddParam("@PID", TbxPID.Text)
        SQL.AddParam("@PN", TbxPN.Text)
        SQL.AddParam("@LB", CbxLB.Checked)
        SQL.AddParam("@XR", CbxXray.Checked)
        SQL.AddParam("@CHC", CbxCHC.Checked)
        SQL.AddParam("@PHC", CbxPHC.Checked)
        SQL.AddParam("@C", CbxC.Checked)

        SQL.ExecQurey("INSERT INTO Bill (PatientID,PatientName,Lab_Service,XRay,Comprensive_Health_Check,Partial_Health_Check,Consultation,Date)" &
                  "VALUES (@PID,@PN,@LB,@XR,@CHC,@PHC,@C,GETDATE());")
        If SQL.HasExecption(True) Then Exit Sub
    End Sub
    Private Sub Diagnosis()
        SQL.AddParam("@ID", TbxPID.Text)
        SQL.AddParam("@PN", TbxPN.Text)
        SQL.AddParam("@D", TbxDia.Text)
        SQL.AddParam("@M", TbxM.Text)
        SQL.AddParam("@Dis", TbxDis.Text)

        SQL.ExecQurey("INSERT INTO Doctor (PatientID,PatientName,Diagnosis,Medecine,Description,Date)" &
                  "VALUES (@ID,@PN,@D,@M,@Dis,GETDATE());")
        If SQL.HasExecption(True) Then Exit Sub
    End Sub
    Private Sub BtnSearch_Click(sender As Object, e As EventArgs) Handles BtnSearch.Click
        Serch(TbxPID.Text)
    End Sub

    Private Sub BtnD_Click(sender As Object, e As EventArgs) Handles BtnD.Click
        DBill()
        Diagnosis()
        MsgBox("Finished Diagnosis")
    End Sub

    Private Sub TbxPID_KeyDown(sender As Object, e As KeyEventArgs) Handles TbxPID.KeyDown
        If e.KeyCode = Keys.Enter Then
            BtnSearch_Click(Nothing, Nothing)
        End If
    End Sub

    Private Sub TbxDis_KeyDown(sender As Object, e As KeyEventArgs) Handles TbxDis.KeyDown
        If e.KeyCode = Keys.Enter Then
            BtnD_Click(Nothing, Nothing)
        End If
    End Sub
End Class
