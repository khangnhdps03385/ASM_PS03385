Imports System.Data.SqlClient
Imports System.Data.DataTable
Public Class frmKH
    Dim db As New DataTable
    Dim chuoiketnoi As String = "workstation id=ps03385.mssql.somee.com;packet size=4096;user id=khangnhdps03385_ASM;pwd=kHANGLATUI1;data source=ps03385.mssql.somee.com;persist security info=False;initial catalog=ps03385"
    Dim connect As SqlConnection = New SqlConnection(chuoiketnoi)

    Private Sub dgvKetqua_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvKetqua.CellContentClick
        Dim click As Integer = dgvKetqua.CurrentCell.RowIndex
        txtMaKH.Text = dgvKetqua.Item(0, click).Value
        txtTenKH.Text = dgvKetqua.Item(1, click).Value
        txtGioitinh.Text = dgvKetqua.Item(2, click).Value
        txtDiachi.Text = dgvKetqua.Item(3, click).Value
        txtSdt.Text = dgvKetqua.Item(4, click).Value
    End Sub
    Private Sub LoadData()
        Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)
        Dim load As SqlDataAdapter = New SqlDataAdapter("select MaKH as 'Mã Khách Hàng',TenKH as 'Tên Khách Hàng', GioiTinh as 'Giới Tính', DiaChi as 'Địa Chỉ', SoDT as 'Số Điện Thoại' from KhachHang", conn)

        conn.Open()
        load.Fill(db)
        dgvKetqua.DataSource = db.DefaultView
    End Sub

    Private Sub btnThem_Click(sender As Object, e As EventArgs) Handles btnThem.Click
        Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)
        Dim query As String = "insert into KhachHang values(@MaKH,@TenKH,@GioiTinh,@DiaChi,@SoDT)"
        Dim save As SqlCommand = New SqlCommand(query, conn)
        conn.Open()
        Try
            txtMaKH.Focus()
            If txtMaKH.Text = "" Then
                MessageBox.Show("Bạn chưa nhập Mã Khách Hàng", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
            Else
                txtTenKH.Focus()
                If txtTenKH.Text = "" Then
                    MessageBox.Show("Bạn chưa nhập Tên Khách Hàng", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
                Else
                    txtGioitinh.Focus()
                    If txtGioitinh.Text = "" Then
                        MessageBox.Show("Bạn chưa nhập Giới Tính", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
                    Else
                        txtDiachi.Focus()
                        If txtDiachi.Text = "" Then
                            MessageBox.Show("Bạn chưa nhập tiền", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
                        Else
                            txtSdt.Focus()
                            If txtSdt.Text = "" Then
                                MessageBox.Show("Bạn chưa nhập Số Điện Thoại", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
                            Else
                                save.Parameters.AddWithValue("@MaKH", txtMaKH.Text)
                                save.Parameters.AddWithValue("@TenKH", txtTenKH.Text)
                                save.Parameters.AddWithValue("@GioiTinh", txtGioitinh.Text)
                                save.Parameters.AddWithValue("@DiaChi", txtDiachi.Text)
                                save.Parameters.AddWithValue("@SoDT", txtSdt.Text)
                                save.ExecuteNonQuery()
                                MessageBox.Show("Lưu thành công")
                                'Sau khi nhập thành công, tự động làm mới các khung textbox, combox và date....
                                txtMaKH.Text = Nothing
                                txtTenKH.Text = Nothing
                                txtGioitinh.Text = Nothing
                                txtDiachi.Text = Nothing
                                txtSdt.Text = Nothing

                            End If
                        End If
                    End If
                End If
            End If
        Catch ex As Exception  'Ngược lại báo lỗi
            MessageBox.Show("Không được trùng Mã Khách Hàng", "Lỗi", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error)
        End Try

        'Làm mới lại bảng sau khi lưu thành công
        Dim refesh As SqlDataAdapter = New SqlDataAdapter("select MaKH as 'Mã Khách Hàng' ,TenKH as 'Tên Khách Hàng',GioiTinh as 'Giới Tính', DiaChi as 'Địa chỉ', SoDT as 'Số Điện Thoại' from KhachHang", conn)
        db.Clear()
        refesh.Fill(db)
        dgvKetqua.DataSource = db.DefaultView
    End Sub



    Private Sub btnCapnhat_Click(sender As Object, e As EventArgs) Handles btnCapnhat.Click
        Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)
        Dim updatequery As String = "update KhachHang Set MaKH=@MaKH, TenKH =@TenKH, GioiTinh =@GioiTinh, DiaChi =@DiaChi, SoDT = SoDT where MaKH=@MaKH"
        Dim addupdate As SqlCommand = New SqlCommand(updatequery, conn)
        conn.Open()
        Try
            txtMaKH.Focus()
            If txtMaKH.Text = "" Then
                MessageBox.Show("Bạn chưa nhập Mã Khách Hàng", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
            Else
                txtTenKH.Focus()
                If txtTenKH.Text = "" Then
                    MessageBox.Show("Bạn chưa nhập Tên Khách Hàng", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
                Else
                    txtGioitinh.Focus()
                    If txtGioitinh.Text = "" Then
                        MessageBox.Show("Bạn chưa nhập Giới Tính", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
                    Else
                        txtDiachi.Focus()
                        If txtDiachi.Text = "" Then
                            MessageBox.Show("Bạn chưa nhập tiền", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
                        Else
                            txtSdt.Focus()
                            If txtSdt.Text = "" Then
                                MessageBox.Show("Bạn chưa nhập Số Điện Thoại", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
                            Else
                                addupdate.Parameters.AddWithValue("@MaKH", txtMaKH.Text)
                                addupdate.Parameters.AddWithValue("@TenKH", txtTenKH.Text)
                                addupdate.Parameters.AddWithValue("@GioiTinh", txtGioitinh.Text)
                                addupdate.Parameters.AddWithValue("@DiaChi", txtDiachi.Text)
                                addupdate.Parameters.AddWithValue("@SoDT", txtSdt.Text)
                                addupdate.ExecuteNonQuery()
                                MessageBox.Show("Lưu thành công")
                                'Sau khi nhập thành công, tự động làm mới các khung textbox, combox và date....
                                txtMaKH.Text = Nothing
                                txtTenKH.Text = Nothing
                                txtGioitinh.Text = Nothing
                                txtDiachi.Text = Nothing
                                txtSdt.Text = Nothing
                            End If
                        End If
                    End If
                End If
            End If
        Catch ex As Exception  'Ngược lại báo lỗi
            MessageBox.Show("Không được trùng Mã Khách Hàng", "Lỗi", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error)
        End Try

        'Sau khi cập nhật xong sẽ tự làm mới lại bảng
        db.Clear()
        dgvKetqua.DataSource = db
        dgvKetqua.DataSource = Nothing
        LoadData()
    End Sub

    Private Sub btnXoa_Click(sender As Object, e As EventArgs) Handles btnXoa.Click
        Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)
        Dim Delete As String = ("DELETE KhachHang WHERE MaKH = @MaKH") 'Truy van xoa
        Dim CONNECT As SqlCommand = New SqlCommand(Delete, conn)
        conn.Open() 'Mo ket noi CSDL
        Try
            txtMaKH.Focus()
            If txtMaKH.Text = "" Then
                MessageBox.Show("Bạn chưa nhập mã khách hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                CONNECT.Parameters.AddWithValue("@MaKH", txtMaKH.Text)
                CONNECT.ExecuteNonQuery()
                conn.Close() 'Dong ket noi CSDL
                MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch EX As Exception
            MessageBox.Show("Xóa thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
        'Lam moi lai CSDL
        db.Clear()
        dgvKetqua.DataSource = db
        dgvKetqua.DataSource = Nothing
        LoadData()
    End Sub

    Private Sub frmKH_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)
        Dim load As SqlDataAdapter = New SqlDataAdapter("select MaKH as 'Mã Khách Hàng',TenKH as 'Tên Khách Hàng', GioiTinh as 'Giới Tính', DiaChi as 'Địa Chỉ', SoDT as 'Số Điện Thoại' from KhachHang", conn)

        conn.Open()
        load.Fill(db)
        dgvKetqua.DataSource = db.DefaultView
    End Sub

End Class