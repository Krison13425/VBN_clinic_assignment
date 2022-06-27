Public Class Login
    Private SQL As New SQLControl
    Private Sub Login()
        SQL.AddParam("@userID", TbxUID.Text)
        SQL.AddParam("@password", TbxPW.Text)
        SQL.AddParam("@usertype", TbxUt.Text)

        SQL.ExecQurey("SELECT UserID " &
                      "FROM Admin " &
                      "WHERE UserID=@userID and Password=@password and Usertype=@usertype;")
        If SQL.Recordcount > 0 Then
            MsgBox("Login Successfully")
            If TbxUT.Text = ("Admin") Then
                Admin.Show()
                Me.Hide()
                MsgBox("Hi,Admin")
            ElseIf TbxUt.Text = ("Nurse") Then
                Nurse.Show()
                Me.Hide()
                MsgBox("Hi,Nurse")
            ElseIf TbxUT.Text = ("Doctor") Then
                Doctor.Show()
                Me.Hide()
                MsgBox("Hi,Doctor")
            End If
        Else
            MsgBox("Invalid User")
        End If

    End Sub

    Private Sub BtnLogin_Click(sender As Object, e As EventArgs) Handles BtnLogin.Click
        Login()
        TbxPW.Clear()
        TbxUID.Clear()
        TbxUT.Clear()
    End Sub

    Private Sub TbxUID_KeyDown(sender As Object, e As KeyEventArgs) Handles TbxUID.KeyDown
        If e.KeyCode = Keys.Enter Then
            TbxPW.Focus()
            e.Handled = True
            e.SuppressKeyPress = True
        End If
    End Sub

    Private Sub TbxPW_KeyDown(sender As Object, e As KeyEventArgs) Handles TbxPW.KeyDown
        If e.KeyCode = Keys.Enter Then
            TbxUT.Focus()
            e.Handled = True
            e.SuppressKeyPress = True
        End If
    End Sub

    Private Sub TbxUT_KeyDown(sender As Object, e As KeyEventArgs) Handles TbxUT.KeyDown
        If e.KeyCode = Keys.Enter Then
            BtnLogin_Click(Nothing, Nothing)
            e.Handled = True
            e.SuppressKeyPress = True
        End If
    End Sub

End Class