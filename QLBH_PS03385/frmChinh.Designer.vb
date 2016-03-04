<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmChinh
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ptbKhachHang = New System.Windows.Forms.PictureBox()
        Me.ptbSanPham = New System.Windows.Forms.PictureBox()
        Me.ptbHoaDon = New System.Windows.Forms.PictureBox()
        Me.ptbLienHe = New System.Windows.Forms.PictureBox()
        CType(Me.ptbKhachHang, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ptbSanPham, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ptbHoaDon, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ptbLienHe, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(159, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(386, 31)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Phần Mềm Quản Lý Bán Hàng "
        '
        'ptbKhachHang
        '
        Me.ptbKhachHang.BackColor = System.Drawing.Color.Transparent
        Me.ptbKhachHang.BackgroundImage = Global.QLBH_PS03385.My.Resources.Resources.icon_empower2
        Me.ptbKhachHang.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ptbKhachHang.Location = New System.Drawing.Point(165, 90)
        Me.ptbKhachHang.Name = "ptbKhachHang"
        Me.ptbKhachHang.Size = New System.Drawing.Size(96, 83)
        Me.ptbKhachHang.TabIndex = 1
        Me.ptbKhachHang.TabStop = False
        '
        'ptbSanPham
        '
        Me.ptbSanPham.BackColor = System.Drawing.Color.Transparent
        Me.ptbSanPham.BackgroundImage = Global.QLBH_PS03385.My.Resources.Resources.retail_fashion_icon
        Me.ptbSanPham.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ptbSanPham.Location = New System.Drawing.Point(165, 199)
        Me.ptbSanPham.Name = "ptbSanPham"
        Me.ptbSanPham.Size = New System.Drawing.Size(96, 83)
        Me.ptbSanPham.TabIndex = 2
        Me.ptbSanPham.TabStop = False
        '
        'ptbHoaDon
        '
        Me.ptbHoaDon.BackColor = System.Drawing.Color.Transparent
        Me.ptbHoaDon.BackgroundImage = Global.QLBH_PS03385.My.Resources.Resources.report_icon
        Me.ptbHoaDon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ptbHoaDon.Location = New System.Drawing.Point(445, 90)
        Me.ptbHoaDon.Name = "ptbHoaDon"
        Me.ptbHoaDon.Size = New System.Drawing.Size(100, 83)
        Me.ptbHoaDon.TabIndex = 3
        Me.ptbHoaDon.TabStop = False
        '
        'ptbLienHe
        '
        Me.ptbLienHe.BackColor = System.Drawing.Color.Transparent
        Me.ptbLienHe.BackgroundImage = Global.QLBH_PS03385.My.Resources.Resources.phone_icon_hi
        Me.ptbLienHe.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ptbLienHe.Location = New System.Drawing.Point(445, 199)
        Me.ptbLienHe.Name = "ptbLienHe"
        Me.ptbLienHe.Size = New System.Drawing.Size(99, 83)
        Me.ptbLienHe.TabIndex = 4
        Me.ptbLienHe.TabStop = False
        '
        'frmChinh
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.BackgroundImage = Global.QLBH_PS03385.My.Resources.Resources.hinh_nen_powerpoint_dep_nhat_31
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(706, 313)
        Me.Controls.Add(Me.ptbLienHe)
        Me.Controls.Add(Me.ptbHoaDon)
        Me.Controls.Add(Me.ptbSanPham)
        Me.Controls.Add(Me.ptbKhachHang)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmChinh"
        Me.Text = "Trang Chính"
        CType(Me.ptbKhachHang, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ptbSanPham, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ptbHoaDon, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ptbLienHe, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents ptbKhachHang As PictureBox
    Friend WithEvents ptbSanPham As PictureBox
    Friend WithEvents ptbHoaDon As PictureBox
    Friend WithEvents ptbLienHe As PictureBox
End Class
