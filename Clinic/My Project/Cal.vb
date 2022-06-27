Public Class Cal
    Private Sub Cal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LblRMT.Text = Bill_Statement.total
    End Sub

    Private Sub BtnPay_Click(sender As Object, e As EventArgs) Handles BtnPay.Click
        Dim Change As Integer
        Change = Val(TbxRMP.Text) - Val(Bill_Statement.total)
        LblRMC.Text = Val(Change)
    End Sub

    Private Sub TbxRMP_KeyDown(sender As Object, e As KeyEventArgs) Handles TbxRMP.KeyDown
        If e.KeyCode = Keys.Enter Then
            BtnPay_Click(Nothing, Nothing)
        End If
    End Sub
End Class