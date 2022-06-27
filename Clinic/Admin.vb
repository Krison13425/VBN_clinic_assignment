Public Class Admin
    Private Sub CreateToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CreateToolStripMenuItem.Click
        Create.Show()
        Reset.Hide()
        Del.Hide()
    End Sub

    Private Sub ResetToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ResetToolStripMenuItem.Click
        Reset.Show()
        Create.Hide()
        Del.Hide()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Dim Reply As New MsgBoxResult
        Reply = MessageBox.Show("Do you want to exit?", "Confirm Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If Reply = MsgBoxResult.Yes Then
            Login.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub DelToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DelToolStripMenuItem.Click
        Del.Show()
        Reset.Hide()
        Create.Hide()
    End Sub
End Class
