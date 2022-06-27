Public Class Doctor
    Private Sub DiagnosisToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DiagnosisToolStripMenuItem.Click
        Doctor_Dignosis.Show()
    End Sub
    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Dim Reply As New MsgBoxResult
        Reply = MessageBox.Show("Do you want to exit?", "Confirm Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If Reply = MsgBoxResult.Yes Then
            Me.Hide()
            Login.Show()
        End If
    End Sub
End Class