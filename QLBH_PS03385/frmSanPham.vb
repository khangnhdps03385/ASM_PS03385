Imports System.Data.SqlClient
Imports System.Data.DataTable
Public Class frmSanPham
    Dim db As New DataTable
    Dim chuoiketnoi As String = "workstation id=ps03385.mssql.somee.com;packet size=4096;user id=khangnhdps03385_ASM;pwd=kHANGLATUI1;data source=ps03385.mssql.somee.com;persist security info=False;initial catalog=ps03385"
    Dim connect As SqlConnection = New SqlConnection(chuoiketnoi)

    Private Sub dgvSanPham_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvSanPham.CellContentClick
        Dim click As Integer = dgvSanPham.CurrentCell.RowIndex
        txtMaSP.Text = dgvSanPham.Item(0, click).Value
        txtMaLSP.Text = dgvSanPham.Item(1, click).Value
        txtSL.Text = dgvSanPham.Item(2, click).Value
        txtChiTietSP.Text = dgvSanPham.Item(3, click).Value
    End Sub
    Private Sub LoadData()
        Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)
        Dim load As SqlDataAdapter = New SqlDataAdapter("select MaSP as 'Mã Sản Phẩm',MaLoaiSP as 'Mã Loại Sản Phẩm',SoLuongSP as 'Số Lượng', ChiTietSP as 'Chi Tiết Sản Phẩm' from SanPham", conn)
        conn.Open()
        load.Fill(db)
        dgvSanPham.DataSource = db.DefaultView
    End Sub
    Private Sub btnCapnhat_Click(sender As Object, e As EventArgs) Handles btnCapnhat.Click
        Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)
        Dim updatequery As String = "update SanPham Set MaSP=@MaSP, MaLoaiSP =@MaLoaiSP, SoLuongSP =@SoLuongSP, ChiTietSP =@ChiTietSP where MaSP=@MaSP"
        Dim addupdate As SqlCommand = New SqlCommand(updatequery, conn)
        conn.Open()
        Try
            txtMaSP.Focus()
            If txtMaSP.Text = "" Then
                MessageBox.Show("Bạn chưa nhập Mã Sản Phẩm", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
            Else
                txtMaLSP.Focus()
                If txtMaLSP.Text = "" Then
                    MessageBox.Show("Bạn chưa nhập Mã Loại Sản Phẩm", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
                Else
                    txtSL.Focus()
                    If txtSL.Text = "" Then
                        MessageBox.Show("Bạn chưa nhập Số Lượng", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
                    Else
                        txtChiTietSP.Focus()
                        If txtChiTietSP.Text = "" Then
                            MessageBox.Show("Bạn chưa nhập Chi Tiết Sản Phẩm", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
                        Else

                            addupdate.Parameters.AddWithValue("@MaSP", txtMaSP.Text)
                            addupdate.Parameters.AddWithValue("@MaLoaiSP", txtMaLSP.Text)
                            addupdate.Parameters.AddWithValue("@SoLuongSP", txtSL.Text)
                            addupdate.Parameters.AddWithValue("@ChiTietSP", txtChiTietSP.Text)
                            addupdate.ExecuteNonQuery()
                            MessageBox.Show("Lưu thành công")
                            'Sau khi nhập thành công, tự động làm mới các khung textbox, combox và date....
                            txtMaSP.Text = Nothing
                            txtMaLSP.Text = Nothing
                            txtSL.Text = Nothing
                            txtChiTietSP.Text = Nothing
                        End If
                        End If
                    End If
                End If

        Catch ex As Exception  'Ngược lại báo lỗi
            MessageBox.Show("Không được trùng Mã Sản Phẩm", "Lỗi", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error)
        End Try

        'Sau khi cập nhật xong sẽ tự làm mới lại bảng
        db.Clear()
        dgvSanPham.DataSource = db
        dgvSanPham.DataSource = Nothing
        LoadData()
    End Sub

    Private Sub btnXoa_Click(sender As Object, e As EventArgs) Handles btnXoa.Click
        Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)
        Dim Delete As String = ("DELETE SanPham WHERE MaSP = @MaSP") 'Truy van xoa
        Dim CONNECT As SqlCommand = New SqlCommand(Delete, conn)
        conn.Open() 'Mo ket noi CSDL
        Try
            txtMaSP.Focus()
            If txtMaSP.Text = "" Then
                MessageBox.Show("Bạn chưa nhập mã khách hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                CONNECT.Parameters.AddWithValue("@MaSP", txtMaSP.Text)
                CONNECT.ExecuteNonQuery()
                conn.Close() 'Dong ket noi CSDL
                MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch EX As Exception
            MessageBox.Show("Xóa thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
        'Lam moi lai CSDL
        db.Clear()
        dgvSanPham.DataSource = db
        dgvSanPham.DataSource = Nothing
        LoadData()
    End Sub
    Private Sub btnThem_Click(sender As Object, e As EventArgs) Handles btnThem.Click
        Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)
        Dim query As String = "insert into SanPham values(@MaSP,@MaLoaiSP,@SoLuongSP,@ChiTietSP)"
        Dim save As SqlCommand = New SqlCommand(query, conn)
        conn.Open()
        Try
            txtMaSP.Focus()
            If txtMaSP.Text = "" Then
                MessageBox.Show("Bạn chưa nhập Mã Sản Phẩm", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
            Else
                txtMaLSP.Focus()
                If txtMaLSP.Text = "" Then
                    MessageBox.Show("Bạn chưa nhập Mã Loại Sản Phẩm", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
                Else
                    txtSL.Focus()
                    If txtSL.Text = "" Then
                        MessageBox.Show("Bạn chưa nhập Số Lượng", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
                    Else
                        txtChiTietSP.Focus()
                        If txtChiTietSP.Text = "" Then
                            MessageBox.Show("Bạn chưa nhập Chi Tiết Sản Phẩm", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
                        Else

                            save.Parameters.AddWithValue("@MaSP", txtMaSP.Text)
                            save.Parameters.AddWithValue("@MaLoaiSP", txtMaLSP.Text)
                            save.Parameters.AddWithValue("@SoLuongSP", txtSL.Text)
                            save.Parameters.AddWithValue("@ChiTietSP", txtChiTietSP.Text)
                            save.ExecuteNonQuery()
                            MessageBox.Show("Lưu thành công")
                            'Sau khi nhập thành công, tự động làm mới các khung textbox, combox và date....
                            txtMaSP.Text = Nothing
                            txtMaLSP.Text = Nothing
                            txtSL.Text = Nothing
                            txtChiTietSP.Text = Nothing
                        End If
                    End If
                End If
            End If
        Catch ex As Exception  'Ngược lại báo lỗi
            MessageBox.Show("Không được trùng Mã Sản Phẩm", "Lỗi", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error)
        End Try

        'Làm mới lại bảng sau khi lưu thành công
        Dim refesh As SqlDataAdapter = New SqlDataAdapter("select MaSP as 'Mã Sản Phẩm',MaLoaiSP as 'Mã Loại Sản Phẩm', SoLuongSP as 'Số Lượng', ChiTietSP as 'Chi Tiết Sản Phẩm' from SanPham", conn)
        db.Clear()
        refesh.Fill(db)
        dgvSanPham.DataSource = db.DefaultView
    End Sub
    Private Sub frmSanPham_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)
        Dim load As SqlDataAdapter = New SqlDataAdapter("select MaSP as 'Mã Sản Phẩm',MaLoaiSP as 'Mã Loại Sản Phẩm', SoLuongSP as 'Số Lượng', ChiTietSP as 'Chi Tiết Sản Phẩm' from SanPham", conn)
        conn.Open()
        load.Fill(db)
        dgvSanPham.DataSource = db.DefaultView
    End Sub

End Class