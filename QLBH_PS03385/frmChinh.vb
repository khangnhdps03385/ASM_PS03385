Public Class frmChinh
    Private Sub ptbLienHe_Click(sender As Object, e As EventArgs) Handles ptbLienHe.Click
        frmLienHe.ShowDialog()
    End Sub

    Private Sub ptbHoaDon_Click(sender As Object, e As EventArgs) Handles ptbHoaDon.Click
        frmHoaDon.ShowDialog()
    End Sub

    Private Sub ptbKhachHang_Click(sender As Object, e As EventArgs) Handles ptbKhachHang.Click
        frmKH.ShowDialog()
    End Sub

    Private Sub ptbSanPham_Click(sender As Object, e As EventArgs) Handles ptbSanPham.Click
        frmSanPham.ShowDialog()
    End Sub

    Private Sub frmChinh_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class