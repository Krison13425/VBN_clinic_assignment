Public Class Patient_Info
    Private SQL As New SQLControl
    Private Sub Patient_Info_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MdiParent = Nurse
    End Sub
    Private Sub Patient()
        SQL.AddParam("@ID", TbxPID.Text)
        SQL.AddParam("@Name", TbxName.Text)
        SQL.AddParam("@Age", TbxAge.Text)
        SQL.AddParam("@IC", TbxIC.Text)
        SQL.AddParam("@PN"， TbxPN.Text)
        SQL.AddParam("@Phone", TbxPhone.Text)
        SQL.AddParam("@Address", TbxAddress.Text)
        SQL.AddParam("@Email", TbxEMail.Text)
        SQL.AddParam("@H", TbxHeight.Text)
        SQL.AddParam("@W", TbxWeight.Text)
        SQL.AddParam("@BT", TbxBT.Text)
        SQL.AddParam("@A", TbxAllergies.Text)

        SQL.ExecQurey("INSERT INTO NursePatient (PatientID,PatientName,Age,IC_Num,Passport_Num,Phone_No,Address,Email,Height,Weight,Bloodtype,Allergies,Date)" &
                      "VALUES (@ID,@Name,@Age,@IC,@PN,@Phone,@Address,@Email,@H,@W,@BT,@A,GETDATE());")
        'REPORT & ARBORT ON ERROR
        If SQL.HasExecption(True) Then Exit Sub

        If SQL.DBDT.Rows.Count > 0 Then
            Dim r As DataRow = SQL.DBDT.Rows(0)
            MsgBox(r("LastID").ToString)
        End If
        MsgBox("Patient Info Create Successfully!")

    End Sub
    Private Sub BtnCreateNurse_Click(sender As Object, e As EventArgs) Handles BtnCreateNurse.Click
        Patient()
    End Sub
    Private Sub TxtFeilds_TextChanged(sender As Object, e As EventArgs) Handles TbxName.TextChanged, TbxAge.TextChanged, TbxIC.TextChanged, TbxPN.TextChanged, TbxPhone.TextChanged, TbxAddress.TextChanged, TbxEMail.TextChanged, TbxHeight.TextChanged, TbxWeight.TextChanged, TbxBT.TextChanged, TbxAllergies.TextChanged
        'BASIC VALIDATION
        If Not String.IsNullOrEmpty(TbxName.Text) AndAlso Not String.IsNullOrEmpty(TbxAge.Text) AndAlso Not String.IsNullOrEmpty(TbxIC.Text) AndAlso Not String.IsNullOrEmpty(TbxPN.Text) AndAlso Not String.IsNullOrEmpty(TbxPhone.Text) AndAlso Not String.IsNullOrEmpty(TbxAddress.Text) AndAlso Not String.IsNullOrEmpty(TbxEMail.Text) AndAlso Not String.IsNullOrEmpty(TbxHeight.Text) AndAlso Not String.IsNullOrEmpty(TbxWeight.Text) AndAlso Not String.IsNullOrEmpty(TbxBT.Text) AndAlso Not String.IsNullOrEmpty(TbxAllergies.Text) Then
            BtnCreateNurse.Enabled = True
        End If
    End Sub

    Private Sub TbxName_KeyDown(sender As Object, e As KeyEventArgs) Handles TbxName.KeyDown
        If e.KeyCode = Keys.Enter Then
            TbxAge.Focus()
        End If
    End Sub

    Private Sub TbxAge_KeyDown(sender As Object, e As KeyEventArgs) Handles TbxAge.KeyDown
        If e.KeyCode = Keys.Enter Then
            TbxIC.Focus()
        End If
    End Sub

    Private Sub TbxIC_KeyDown(sender As Object, e As KeyEventArgs) Handles TbxIC.KeyDown
        If e.KeyCode = Keys.Enter Then
            TbxPN.Focus()
        End If
    End Sub

    Private Sub TbxPN_KeyDown(sender As Object, e As KeyEventArgs) Handles TbxPN.KeyDown
        If e.KeyCode = Keys.Enter Then
            TbxPhone.Focus()
        End If
    End Sub

    Private Sub TbxAddress_KeyDown(sender As Object, e As KeyEventArgs) Handles TbxAddress.KeyDown
        If e.KeyCode = Keys.Enter Then
            TbxEMail.Focus()
        End If
    End Sub

    Private Sub TbxEMail_KeyDown(sender As Object, e As KeyEventArgs) Handles TbxEMail.KeyDown
        If e.KeyCode = Keys.Enter Then
            TbxHeight.Focus()
        End If
    End Sub

    Private Sub TbxHeight_KeyDown(sender As Object, e As KeyEventArgs) Handles TbxHeight.KeyDown
        If e.KeyCode = Keys.Enter Then
            TbxWeight.Focus()
        End If
    End Sub

    Private Sub TbxBT_KeyDown(sender As Object, e As KeyEventArgs) Handles TbxBT.KeyDown
        If e.KeyCode = Keys.Enter Then
            TbxAllergies.Focus()
        End If
    End Sub

    Private Sub TbxAllergies_KeyDown(sender As Object, e As KeyEventArgs) Handles TbxAllergies.KeyDown
        If e.KeyCode = Keys.Enter Then
            BtnCreateNurse_Click(Nothing, Nothing)
        End If
    End Sub
    Private Sub TbxPhone_KeyDown(sender As Object, e As KeyEventArgs) Handles TbxPhone.KeyDown
        If e.KeyCode = Keys.Enter Then
            TbxAddress.Focus()
        End If
    End Sub

End Class