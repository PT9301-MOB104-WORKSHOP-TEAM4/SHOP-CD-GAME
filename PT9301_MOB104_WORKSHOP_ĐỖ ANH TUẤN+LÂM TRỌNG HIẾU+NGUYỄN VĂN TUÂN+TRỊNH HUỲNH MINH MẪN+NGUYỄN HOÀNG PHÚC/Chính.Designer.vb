<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_chinh
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_chinh))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.mns_HeThong = New System.Windows.Forms.ToolStripMenuItem()
        Me.mns_DangXuat = New System.Windows.Forms.ToolStripMenuItem()
        Me.mns_Thoat = New System.Windows.Forms.ToolStripMenuItem()
        Me.mns_BanHang = New System.Windows.Forms.ToolStripMenuItem()
        Me.mns_SanPhamHot = New System.Windows.Forms.ToolStripMenuItem()
        Me.mns_HoaDon = New System.Windows.Forms.ToolStripMenuItem()
        Me.mns_quanLy = New System.Windows.Forms.ToolStripMenuItem()
        Me.mns_SanPham = New System.Windows.Forms.ToolStripMenuItem()
        Me.nms_KhachHang = New System.Windows.Forms.ToolStripMenuItem()
        Me.mns_NhanVien = New System.Windows.Forms.ToolStripMenuItem()
        Me.mns_GioiThieu = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mns_HeThong, Me.mns_BanHang, Me.mns_quanLy, Me.mns_GioiThieu})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(820, 28)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'mns_HeThong
        '
        Me.mns_HeThong.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mns_DangXuat, Me.mns_Thoat})
        Me.mns_HeThong.Image = CType(resources.GetObject("mns_HeThong.Image"), System.Drawing.Image)
        Me.mns_HeThong.Name = "mns_HeThong"
        Me.mns_HeThong.Size = New System.Drawing.Size(102, 24)
        Me.mns_HeThong.Text = "Hệ Thống"
        '
        'mns_DangXuat
        '
        Me.mns_DangXuat.Image = CType(resources.GetObject("mns_DangXuat.Image"), System.Drawing.Image)
        Me.mns_DangXuat.Name = "mns_DangXuat"
        Me.mns_DangXuat.Size = New System.Drawing.Size(148, 24)
        Me.mns_DangXuat.Text = "Đăng Xuất"
        '
        'mns_Thoat
        '
        Me.mns_Thoat.Image = CType(resources.GetObject("mns_Thoat.Image"), System.Drawing.Image)
        Me.mns_Thoat.Name = "mns_Thoat"
        Me.mns_Thoat.Size = New System.Drawing.Size(148, 24)
        Me.mns_Thoat.Text = "Thoát"
        '
        'mns_BanHang
        '
        Me.mns_BanHang.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mns_SanPhamHot, Me.mns_HoaDon})
        Me.mns_BanHang.Image = CType(resources.GetObject("mns_BanHang.Image"), System.Drawing.Image)
        Me.mns_BanHang.Name = "mns_BanHang"
        Me.mns_BanHang.Size = New System.Drawing.Size(102, 24)
        Me.mns_BanHang.Text = "Bán Hàng"
        '
        'mns_SanPhamHot
        '
        Me.mns_SanPhamHot.Image = CType(resources.GetObject("mns_SanPhamHot.Image"), System.Drawing.Image)
        Me.mns_SanPhamHot.Name = "mns_SanPhamHot"
        Me.mns_SanPhamHot.Size = New System.Drawing.Size(179, 24)
        Me.mns_SanPhamHot.Text = "Sản Phẩm HOT"
        '
        'mns_HoaDon
        '
        Me.mns_HoaDon.Image = CType(resources.GetObject("mns_HoaDon.Image"), System.Drawing.Image)
        Me.mns_HoaDon.Name = "mns_HoaDon"
        Me.mns_HoaDon.Size = New System.Drawing.Size(179, 24)
        Me.mns_HoaDon.Text = "Thêm Hóa Đơn"
        '
        'mns_quanLy
        '
        Me.mns_quanLy.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mns_SanPham, Me.nms_KhachHang, Me.mns_NhanVien})
        Me.mns_quanLy.Image = CType(resources.GetObject("mns_quanLy.Image"), System.Drawing.Image)
        Me.mns_quanLy.Name = "mns_quanLy"
        Me.mns_quanLy.Size = New System.Drawing.Size(90, 24)
        Me.mns_quanLy.Text = "Quản Lý"
        '
        'mns_SanPham
        '
        Me.mns_SanPham.Image = CType(resources.GetObject("mns_SanPham.Image"), System.Drawing.Image)
        Me.mns_SanPham.Name = "mns_SanPham"
        Me.mns_SanPham.Size = New System.Drawing.Size(158, 24)
        Me.mns_SanPham.Text = "Sản Phẩm"
        '
        'nms_KhachHang
        '
        Me.nms_KhachHang.Image = CType(resources.GetObject("nms_KhachHang.Image"), System.Drawing.Image)
        Me.nms_KhachHang.Name = "nms_KhachHang"
        Me.nms_KhachHang.Size = New System.Drawing.Size(158, 24)
        Me.nms_KhachHang.Text = "Khách Hàng"
        '
        'mns_NhanVien
        '
        Me.mns_NhanVien.Image = CType(resources.GetObject("mns_NhanVien.Image"), System.Drawing.Image)
        Me.mns_NhanVien.Name = "mns_NhanVien"
        Me.mns_NhanVien.Size = New System.Drawing.Size(158, 24)
        Me.mns_NhanVien.Text = "Nhân Viên"
        '
        'mns_GioiThieu
        '
        Me.mns_GioiThieu.Image = CType(resources.GetObject("mns_GioiThieu.Image"), System.Drawing.Image)
        Me.mns_GioiThieu.Name = "mns_GioiThieu"
        Me.mns_GioiThieu.Size = New System.Drawing.Size(104, 24)
        Me.mns_GioiThieu.Text = "Giới Thiệu"
        '
        'frm_chinh
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(820, 384)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frm_chinh"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "HỆ THỐNG QUẢN LÝ"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents mns_HeThong As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mns_DangXuat As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mns_Thoat As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mns_BanHang As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mns_SanPhamHot As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mns_HoaDon As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mns_quanLy As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mns_SanPham As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents nms_KhachHang As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mns_NhanVien As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mns_GioiThieu As System.Windows.Forms.ToolStripMenuItem
End Class
