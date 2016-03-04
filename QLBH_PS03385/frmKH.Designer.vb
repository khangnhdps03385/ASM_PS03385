<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmKH
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.txtMaKH = New System.Windows.Forms.TextBox()
        Me.btnXoa = New System.Windows.Forms.Button()
        Me.txtGioitinh = New System.Windows.Forms.TextBox()
        Me.dgvKetqua = New System.Windows.Forms.DataGridView()
        Me.btnThem = New System.Windows.Forms.Button()
        Me.btnCapnhat = New System.Windows.Forms.Button()
        Me.txtSdt = New System.Windows.Forms.TextBox()
        Me.txtDiachi = New System.Windows.Forms.TextBox()
        Me.txtTenKH = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        CType(Me.dgvKetqua, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtMaKH
        '
        Me.txtMaKH.Location = New System.Drawing.Point(250, 33)
        Me.txtMaKH.Name = "txtMaKH"
        Me.txtMaKH.Size = New System.Drawing.Size(249, 20)
        Me.txtMaKH.TabIndex = 51
        '
        'btnXoa
        '
        Me.btnXoa.Location = New System.Drawing.Point(516, 294)
        Me.btnXoa.Name = "btnXoa"
        Me.btnXoa.Size = New System.Drawing.Size(75, 23)
        Me.btnXoa.TabIndex = 50
        Me.btnXoa.Text = "Xóa"
        Me.btnXoa.UseVisualStyleBackColor = True
        '
        'txtGioitinh
        '
        Me.txtGioitinh.Location = New System.Drawing.Point(250, 86)
        Me.txtGioitinh.Name = "txtGioitinh"
        Me.txtGioitinh.Size = New System.Drawing.Size(249, 20)
        Me.txtGioitinh.TabIndex = 49
        '
        'dgvKetqua
        '
        Me.dgvKetqua.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvKetqua.Location = New System.Drawing.Point(20, 181)
        Me.dgvKetqua.Name = "dgvKetqua"
        Me.dgvKetqua.Size = New System.Drawing.Size(479, 175)
        Me.dgvKetqua.TabIndex = 48
        '
        'btnThem
        '
        Me.btnThem.Location = New System.Drawing.Point(516, 214)
        Me.btnThem.Name = "btnThem"
        Me.btnThem.Size = New System.Drawing.Size(75, 23)
        Me.btnThem.TabIndex = 46
        Me.btnThem.Text = "Thêm"
        Me.btnThem.UseVisualStyleBackColor = True
        '
        'btnCapnhat
        '
        Me.btnCapnhat.Location = New System.Drawing.Point(516, 255)
        Me.btnCapnhat.Name = "btnCapnhat"
        Me.btnCapnhat.Size = New System.Drawing.Size(75, 23)
        Me.btnCapnhat.TabIndex = 47
        Me.btnCapnhat.Text = "Cập Nhật"
        Me.btnCapnhat.UseVisualStyleBackColor = True
        '
        'txtSdt
        '
        Me.txtSdt.Location = New System.Drawing.Point(250, 138)
        Me.txtSdt.Name = "txtSdt"
        Me.txtSdt.Size = New System.Drawing.Size(249, 20)
        Me.txtSdt.TabIndex = 43
        '
        'txtDiachi
        '
        Me.txtDiachi.Location = New System.Drawing.Point(250, 112)
        Me.txtDiachi.Name = "txtDiachi"
        Me.txtDiachi.Size = New System.Drawing.Size(249, 20)
        Me.txtDiachi.TabIndex = 44
        '
        'txtTenKH
        '
        Me.txtTenKH.Location = New System.Drawing.Point(250, 59)
        Me.txtTenKH.Name = "txtTenKH"
        Me.txtTenKH.Size = New System.Drawing.Size(249, 20)
        Me.txtTenKH.TabIndex = 45
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Location = New System.Drawing.Point(155, 89)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(51, 13)
        Me.Label4.TabIndex = 37
        Me.Label4.Text = "Giới Tính"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Location = New System.Drawing.Point(155, 141)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(75, 13)
        Me.Label5.TabIndex = 38
        Me.Label5.Text = "Số Điện Thoại"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Location = New System.Drawing.Point(155, 115)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(41, 13)
        Me.Label3.TabIndex = 39
        Me.Label3.Text = "Địa Chỉ"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(155, 62)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(89, 13)
        Me.Label2.TabIndex = 40
        Me.Label2.Text = "Tên Khách Hàng"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label6.Location = New System.Drawing.Point(155, 36)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(85, 13)
        Me.Label6.TabIndex = 41
        Me.Label6.Text = "Mã Khách Hàng"
        '
        'frmKH
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.QLBH_PS03385.My.Resources.Resources.hinh_nen_powerpoint_dep_nhat_12
        Me.ClientSize = New System.Drawing.Size(615, 405)
        Me.Controls.Add(Me.txtMaKH)
        Me.Controls.Add(Me.btnXoa)
        Me.Controls.Add(Me.txtGioitinh)
        Me.Controls.Add(Me.dgvKetqua)
        Me.Controls.Add(Me.btnThem)
        Me.Controls.Add(Me.btnCapnhat)
        Me.Controls.Add(Me.txtSdt)
        Me.Controls.Add(Me.txtDiachi)
        Me.Controls.Add(Me.txtTenKH)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label6)
        Me.Name = "frmKH"
        Me.Text = "Khách Hàng"
        CType(Me.dgvKetqua, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtMaKH As TextBox
    Friend WithEvents btnXoa As Button
    Friend WithEvents txtGioitinh As TextBox
    Friend WithEvents dgvKetqua As DataGridView
    Friend WithEvents btnThem As Button
    Friend WithEvents btnCapnhat As Button
    Friend WithEvents txtSdt As TextBox
    Friend WithEvents txtDiachi As TextBox
    Friend WithEvents txtTenKH As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label6 As Label
End Class
