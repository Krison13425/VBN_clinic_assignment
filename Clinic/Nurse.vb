Public Class Nurse
    Private Sub PatientToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PatientToolStripMenuItem.Click
        Patient_Info.Show()
    End Sub

    Private Sub BillToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BillToolStripMenuItem.Click
        Bill_Statement.Show()
    End Sub

    Private Sub PreviewPatientToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PreviewPatientToolStripMenuItem.Click
        Patient_View.Show()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Dim Reply As New MsgBoxResult
        Reply = MessageBox.Show("Do you want to exit?", "Confirm Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If Reply = MsgBoxResult.Yes Then
            Login.Show()
            Me.Hide()
        End If
    End Sub
End Class