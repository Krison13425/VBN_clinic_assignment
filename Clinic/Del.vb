Public Class Del
    Private SQL As New SQLControl
    Private Sub Del_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MdiParent = Admin
    End Sub

    Private Sub Search()
        'REFRESH USER LIST
        CLBUN.Items.Clear()

        'ADD PARAM & RUN QUREY
        SQL.AddParam("@UN", "%" & TbxUN.Text & "%")
        SQL.ExecQurey("SELECT UserName " &
                      "FROM Admin " &
                      "WHERE UserName like @UN " &
                      "ORDER BY UserName ASC;")

        'LOOP RPWS & RETURN USERS TO THE LIST
        For Each r As DataRow In SQL.DBDT.Rows
            CLBUN.Items.Add(r("UserName"))
        Next
    End Sub

    Private Sub Del()
        If MsgBox(" The Selected User Will Be Deleted! Are You Sure to Continue?", MsgBoxStyle.YesNo, "Delete User?") = MsgBoxResult.Yes Then

            Dim Delstring As String
            For Each i As String In CLBUN.CheckedItems
                SQL.AddParam("@N", i)
                Delstring += "DELETE FROM Admin WHERE UserName=@N;"
            Next
            SQL.ExecQurey(Delstring)

            If SQL.HasExecption(True) Then Exit Sub
            MsgBox("The Selected Users Have been Deleted Successfully.")
            'REFRESH LIST
            Search()
        End If
    End Sub
    Private Sub TbxUID_KeyDown(sender As Object, e As KeyEventArgs) Handles TbxUN.KeyDown
        If e.KeyCode = Keys.Enter Then
            Search()
            e.Handled = True
            e.SuppressKeyPress = True
        End If
    End Sub

    Private Sub BtnDel_Click(sender As Object, e As EventArgs) Handles BtnDel.Click
        If CLBUN.CheckedItems.Count > 0 Then Del()
    End Sub
End Class
