Public Class frmLogin
    Private Sub btnDN_Click(sender As Object, e As EventArgs) Handles btnDN.Click
        If txtDN.Text = "khang" And txtMK.Text = "123" Then
            MsgBox("Đăng nhập thành công")
            frmChinh.ShowDialog()
        ElseIf txtDN.Text = "" Then
            MsgBox("Chưa nhập tài khoản")
        ElseIf txtMK.Text = "" Then
            MsgBox("Chưa nhập mật khẩu")
        Else
            MsgBox("Đăng nhập thất bại")
        End If
    End Sub

    Private Sub btnHuy_Click(sender As Object, e As EventArgs) Handles btnHuy.Click
        txtDN.Text = ""
        txtMK.Text = ""
    End Sub


End Class