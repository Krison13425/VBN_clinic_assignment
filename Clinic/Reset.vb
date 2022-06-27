Public Class Reset
    Private SQL As New SQLControl
    Private Sub Reset_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MdiParent = Admin
    End Sub
    Private Sub Search(UserID As String)
        SQL.AddParam("@UserID", UserID)
        SQL.ExecQurey("SELECT TOP 1 * " &
                        "FROM Admin " &
                        "WHERE UserID=@UserID;")

        If SQL.Recordcount < 1 Then Exit Sub

        For Each r As DataRow In SQL.DBDT.Rows
            TbxUID.Text = r("UserID")
            TbxUN.Text = r("UserName")
            TbxUT.Text = r("Usertype")
            TbxPW.Text = r("Password")
        Next

    End Sub

    Private Sub Reset()
        SQL.AddParam("@Password", TbxPW.Text)
        SQL.AddParam(“@UserID", TbxUID.Text)
        SQL.ExecQurey("UPDATE Admin " &
                      "SET Password=@Password " &
                      "WHERE UserID=@UserID ;")
        If SQL.HasExecption(True) Then Exit Sub

        MsgBox("Reset Sucessfully")
        BtnReset.Enabled = True

    End Sub

    Private Sub BtnSearch_Click(sender As Object, e As EventArgs) Handles BtnSearch.Click
        Search(TbxUID.Text)
    End Sub

    Private Sub BtnReset_Click(sender As Object, e As EventArgs) Handles BtnReset.Click
        If TbxPW.Text <> TbxCP.Text Then
            MsgBox("Password not Match")
            TbxPW.Clear()
            TbxCP.Clear()
            Exit Sub
        End If
        If TbxPW.Text = TbxCP.Text Then
            Reset()
            TbxUID.Clear()
            TbxUN.Clear()
            TbxUT.Clear()
            TbxPW.Clear()
            TbxCP.Clear()
        End If

    End Sub

    Private Sub TbxPW_KeyDown(sender As Object, e As KeyEventArgs) Handles TbxPW.KeyDown
        If e.KeyCode = Keys.Enter Then
            TbxCP.Focus()
            e.Handled = True
            e.SuppressKeyPress = True
        End If
    End Sub

    Private Sub TbxCP_KeyDown(sender As Object, e As KeyEventArgs) Handles TbxCP.KeyDown
        If e.KeyCode = Keys.Enter Then
            BtnReset_Click(Nothing, Nothing)
            e.Handled = True
            e.SuppressKeyPress = True
        End If
    End Sub

    Private Sub TbxUID_KeyDown(sender As Object, e As KeyEventArgs) Handles TbxUID.KeyDown
        If e.KeyCode = Keys.Enter Then
            BtnSearch_Click(Nothing, Nothing)
            e.Handled = True
            e.SuppressKeyPress = True
        End If
    End Sub
End Class