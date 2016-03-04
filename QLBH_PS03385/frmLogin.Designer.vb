<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLogin
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
        Me.txtMK = New System.Windows.Forms.TextBox()
        Me.txtDN = New System.Windows.Forms.TextBox()
        Me.btnHuy = New System.Windows.Forms.Button()
        Me.btnDN = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblDN = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtMK
        '
        Me.txtMK.Location = New System.Drawing.Point(91, 144)
        Me.txtMK.Name = "txtMK"
        Me.txtMK.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtMK.Size = New System.Drawing.Size(171, 20)
        Me.txtMK.TabIndex = 13
        '
        'txtDN
        '
        Me.txtDN.Location = New System.Drawing.Point(91, 109)
        Me.txtDN.Name = "txtDN"
        Me.txtDN.Size = New System.Drawing.Size(171, 20)
        Me.txtDN.TabIndex = 12
        '
        'btnHuy
        '
        Me.btnHuy.Location = New System.Drawing.Point(143, 198)
        Me.btnHuy.Name = "btnHuy"
        Me.btnHuy.Size = New System.Drawing.Size(75, 23)
        Me.btnHuy.TabIndex = 11
        Me.btnHuy.Text = "Hủy bỏ"
        Me.btnHuy.UseVisualStyleBackColor = True
        '
        'btnDN
        '
        Me.btnDN.Location = New System.Drawing.Point(62, 198)
        Me.btnDN.Name = "btnDN"
        Me.btnDN.Size = New System.Drawing.Size(75, 23)
        Me.btnDN.TabIndex = 10
        Me.btnDN.Text = "Đăng nhập"
        Me.btnDN.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(23, 147)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 13)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Mật khẩu : "
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(23, 112)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(61, 13)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Tài khoản :"
        '
        'lblDN
        '
        Me.lblDN.AutoSize = True
        Me.lblDN.BackColor = System.Drawing.Color.Transparent
        Me.lblDN.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!)
        Me.lblDN.Location = New System.Drawing.Point(45, 39)
        Me.lblDN.Name = "lblDN"
        Me.lblDN.Size = New System.Drawing.Size(190, 39)
        Me.lblDN.TabIndex = 7
        Me.lblDN.Text = "Đăng Nhập"
        '
        'frmLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.QLBH_PS03385.My.Resources.Resources.free_wallpaper_16
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.txtMK)
        Me.Controls.Add(Me.txtDN)
        Me.Controls.Add(Me.btnHuy)
        Me.Controls.Add(Me.btnDN)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblDN)
        Me.Name = "frmLogin"
        Me.Text = "Đăng Nhập"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtMK As TextBox
    Friend WithEvents txtDN As TextBox
    Friend WithEvents btnHuy As Button
    Friend WithEvents btnDN As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lblDN As Label
End Class
