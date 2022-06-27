Public Class Create
    Public SQl As New SQLControl
    Private Sub Create_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MdiParent = Admin
    End Sub
    Private Sub InsertUser()
        'ADD SQL PARAMS & RUN THE COMMAND
        SQl.AddParam("@UserID", TbxUID.Text)
        SQl.AddParam("@UserName", TbxUN.Text)
        SQl.AddParam("@Password", TbxPW.Text)
        SQl.AddParam("@Usertype", TbxUT.Text)

        SQl.ExecQurey("INSERT INTO Admin (UserID,UserName,Password,Usertype)" &
                      "VALUES (@UserID,@UserName,@Password,@Usertype);")
        'REPORT & ABORT ON ERROR
        If SQl.HasExecption(True) Then Exit Sub

        If SQl.DBDT.Rows.Count > 0 Then
            Dim r As DataRow = SQl.DBDT.Rows(0)
            MsgBox(r("LastID").ToString)
        End If
        MsgBox("User Craete Succesfully!")
    End Sub

    Private Sub BtnCreate_Click(sender As Object, e As EventArgs) Handles BtnCreate.Click
        InsertUser()

        'CLEAR FIELDS
        TbxUID.Clear()
        TbxUN.Clear()
        TbxPW.Clear()
        TbxUT.Clear()
        BtnCreate.Enabled = False
    End Sub

    Private Sub TbxFields_TextChanged(sender As Object, e As EventArgs) Handles TbxUN.TextChanged, TbxPW.TextChanged, TbxUT.TextChanged
        'BASIC VALIDATION
        If Not String.IsNullOrWhiteSpace(TbxUID.Text) AndAlso Not String.IsNullOrWhiteSpace(TbxUN.Text) AndAlso Not String.IsNullOrWhiteSpace(TbxPW.Text) AndAlso Not String.IsNullOrWhiteSpace(TbxUT.Text) Then
            BtnCreate.Enabled = True
        End If

    End Sub

    Private Sub TbxUT_KeyDown(sender As Object, e As KeyEventArgs) Handles TbxUT.KeyDown
        If e.KeyCode = Keys.Enter Then
            BtnCreate_Click(Nothing, Nothing)
        End If
    End Sub

    Private Sub TbxUID_KeyDown(sender As Object, e As KeyEventArgs) Handles TbxUID.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.Handled = True
            e.SuppressKeyPress = True
            TbxUN.Focus()
        End If
    End Sub

    Private Sub TbxUN_KeyDown(sender As Object, e As KeyEventArgs) Handles TbxUN.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.Handled = True
            e.SuppressKeyPress = True
            TbxPW.Focus()
        End If
    End Sub

    Private Sub TbxPW_KeyDown(sender As Object, e As KeyEventArgs) Handles TbxPW.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.Handled = True
            e.SuppressKeyPress = True
            TbxUT.Focus()
        End If
    End Sub
End Class