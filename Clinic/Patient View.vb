Public Class Patient_View
    Private SQL As New SQLControl
    Private Sub Patient_View_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MdiParent() = Nurse
    End Sub
    Private Sub View0(PatientID As String)
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
    Private Sub View1(PatientID As String)
        SQL.AddParam("@PID", PatientID)
        SQL.ExecQurey("SELECT TOP 1 *" &
                      "FROM Bill " &
                      "WHERE PatientID=@PID")
        If SQL.Recordcount < 1 Then Exit Sub

        For Each r As DataRow In SQL.DBDT.Rows
            CbxLB.Checked = r("Lab_Service")
            CbxXray.Checked = r("XRay")
            CbxCHC.Checked = r("Comprensive_Health_Check")
            CbxPHC.Checked = r("Partial_Health_Check")
            CbxC.Checked = r("Consultation")
        Next
    End Sub
    Private Sub View2(PatientID As String)
        SQL.AddParam("@PID", PatientID)
        SQL.ExecQurey("SELECT TOP 1 *" &
                      "FROM Doctor " &
                      "WHERE PatientID=@PID")
        If SQL.Recordcount < 1 Then Exit Sub

        For Each r As DataRow In SQL.DBDT.Rows
            TbxDia.Text = r("Diagnosis")
            TbxDis.Text = r("Description")
            TbxM.Text = r("Medecine")
        Next
    End Sub

    Private Sub BtnView_Click(sender As Object, e As EventArgs) Handles BtnView.Click
        View0(TbxPID.Text)
        View1(TbxPID.Text)
        View2(TbxPID.Text)
        MsgBox("Here You Go")
    End Sub

    Private Sub TbxPID_KeyDown(sender As Object, e As KeyEventArgs) Handles TbxPID.KeyDown
        If e.KeyCode = Keys.Enter Then
            BtnView_Click(Nothing, Nothing)
        End If
    End Sub
End Class