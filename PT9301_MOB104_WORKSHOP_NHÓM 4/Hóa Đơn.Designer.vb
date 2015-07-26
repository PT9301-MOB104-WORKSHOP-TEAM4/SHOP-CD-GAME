<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_hoadon
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_hoadon))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btn_Tinh = New System.Windows.Forms.Button()
        Me.lbl_tongtien = New System.Windows.Forms.Label()
        Me.txt_DonGia = New System.Windows.Forms.TextBox()
        Me.txt_MaNhanVien = New System.Windows.Forms.TextBox()
        Me.txt_MaKH = New System.Windows.Forms.TextBox()
        Me.nud_SoLuong = New System.Windows.Forms.NumericUpDown()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.mns_thoat = New System.Windows.Forms.ToolStripMenuItem()
        Me.mns_TroLai = New System.Windows.Forms.ToolStripMenuItem()
        Me.lbl_USD = New System.Windows.Forms.Label()
        Me.btn_nhap = New System.Windows.Forms.Button()
        Me.DTP_ngay = New System.Windows.Forms.DateTimePicker()
        Me.btn_xoa = New System.Windows.Forms.Button()
        Me.btn_sua = New System.Windows.Forms.Button()
        Me.txt_MaSP = New System.Windows.Forms.TextBox()
        Me.txt_tensanpham = New System.Windows.Forms.TextBox()
        Me.btn_lammoi = New System.Windows.Forms.Button()
        Me.txt_mahoadon = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        CType(Me.nud_SoLuong, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(40, 80)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(105, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Mã Sản Phẩm :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Red
        Me.Label2.Location = New System.Drawing.Point(40, 132)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(109, 15)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Tên Sản Phẩm :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Red
        Me.Label3.Location = New System.Drawing.Point(40, 184)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(76, 15)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Số Lượng :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Red
        Me.Label4.Location = New System.Drawing.Point(313, 83)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(95, 15)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Mã Hóa Đơn :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Red
        Me.Label6.Location = New System.Drawing.Point(313, 132)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(113, 15)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Mã Khách Hàng:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Red
        Me.Label7.Location = New System.Drawing.Point(40, 236)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(63, 15)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Đơn Giá:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Red
        Me.Label8.Location = New System.Drawing.Point(313, 184)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(101, 15)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Mã Nhân Viên:"
        '
        'btn_Tinh
        '
        Me.btn_Tinh.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Tinh.ForeColor = System.Drawing.Color.Blue
        Me.btn_Tinh.Image = CType(resources.GetObject("btn_Tinh.Image"), System.Drawing.Image)
        Me.btn_Tinh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_Tinh.Location = New System.Drawing.Point(50, 287)
        Me.btn_Tinh.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btn_Tinh.Name = "btn_Tinh"
        Me.btn_Tinh.Size = New System.Drawing.Size(83, 29)
        Me.btn_Tinh.TabIndex = 10
        Me.btn_Tinh.Text = "Tính"
        Me.btn_Tinh.UseVisualStyleBackColor = True
        '
        'lbl_tongtien
        '
        Me.lbl_tongtien.BackColor = System.Drawing.Color.Transparent
        Me.lbl_tongtien.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbl_tongtien.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_tongtien.ForeColor = System.Drawing.Color.Red
        Me.lbl_tongtien.Location = New System.Drawing.Point(165, 287)
        Me.lbl_tongtien.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_tongtien.Name = "lbl_tongtien"
        Me.lbl_tongtien.Size = New System.Drawing.Size(120, 20)
        Me.lbl_tongtien.TabIndex = 0
        Me.lbl_tongtien.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txt_DonGia
        '
        Me.txt_DonGia.Location = New System.Drawing.Point(141, 236)
        Me.txt_DonGia.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txt_DonGia.Name = "txt_DonGia"
        Me.txt_DonGia.Size = New System.Drawing.Size(73, 20)
        Me.txt_DonGia.TabIndex = 4
        Me.txt_DonGia.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txt_MaNhanVien
        '
        Me.txt_MaNhanVien.Location = New System.Drawing.Point(466, 180)
        Me.txt_MaNhanVien.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txt_MaNhanVien.Name = "txt_MaNhanVien"
        Me.txt_MaNhanVien.Size = New System.Drawing.Size(145, 20)
        Me.txt_MaNhanVien.TabIndex = 8
        '
        'txt_MaKH
        '
        Me.txt_MaKH.Location = New System.Drawing.Point(466, 132)
        Me.txt_MaKH.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txt_MaKH.Name = "txt_MaKH"
        Me.txt_MaKH.Size = New System.Drawing.Size(145, 20)
        Me.txt_MaKH.TabIndex = 7
        '
        'nud_SoLuong
        '
        Me.nud_SoLuong.Location = New System.Drawing.Point(141, 181)
        Me.nud_SoLuong.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.nud_SoLuong.Name = "nud_SoLuong"
        Me.nud_SoLuong.Size = New System.Drawing.Size(56, 20)
        Me.nud_SoLuong.TabIndex = 3
        Me.nud_SoLuong.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mns_thoat, Me.mns_TroLai})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(4, 2, 0, 2)
        Me.MenuStrip1.Size = New System.Drawing.Size(754, 24)
        Me.MenuStrip1.TabIndex = 6
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'mns_thoat
        '
        Me.mns_thoat.Image = CType(resources.GetObject("mns_thoat.Image"), System.Drawing.Image)
        Me.mns_thoat.Name = "mns_thoat"
        Me.mns_thoat.Size = New System.Drawing.Size(66, 20)
        Me.mns_thoat.Text = "Thoát"
        '
        'mns_TroLai
        '
        Me.mns_TroLai.Image = CType(resources.GetObject("mns_TroLai.Image"), System.Drawing.Image)
        Me.mns_TroLai.Name = "mns_TroLai"
        Me.mns_TroLai.Size = New System.Drawing.Size(71, 20)
        Me.mns_TroLai.Text = "Trở Lại"
        '
        'lbl_USD
        '
        Me.lbl_USD.AutoSize = True
        Me.lbl_USD.BackColor = System.Drawing.Color.Transparent
        Me.lbl_USD.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_USD.ForeColor = System.Drawing.Color.Gold
        Me.lbl_USD.Location = New System.Drawing.Point(218, 237)
        Me.lbl_USD.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_USD.Name = "lbl_USD"
        Me.lbl_USD.Size = New System.Drawing.Size(40, 17)
        Me.lbl_USD.TabIndex = 7
        Me.lbl_USD.Text = "USD"
        '
        'btn_nhap
        '
        Me.btn_nhap.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_nhap.ForeColor = System.Drawing.Color.Blue
        Me.btn_nhap.Image = CType(resources.GetObject("btn_nhap.Image"), System.Drawing.Image)
        Me.btn_nhap.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_nhap.Location = New System.Drawing.Point(50, 347)
        Me.btn_nhap.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btn_nhap.Name = "btn_nhap"
        Me.btn_nhap.Size = New System.Drawing.Size(83, 27)
        Me.btn_nhap.TabIndex = 11
        Me.btn_nhap.Text = "Nhập "
        Me.btn_nhap.UseVisualStyleBackColor = True
        '
        'DTP_ngay
        '
        Me.DTP_ngay.Location = New System.Drawing.Point(604, 0)
        Me.DTP_ngay.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.DTP_ngay.Name = "DTP_ngay"
        Me.DTP_ngay.Size = New System.Drawing.Size(151, 20)
        Me.DTP_ngay.TabIndex = 9
        '
        'btn_xoa
        '
        Me.btn_xoa.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_xoa.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btn_xoa.Image = CType(resources.GetObject("btn_xoa.Image"), System.Drawing.Image)
        Me.btn_xoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_xoa.Location = New System.Drawing.Point(50, 434)
        Me.btn_xoa.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btn_xoa.Name = "btn_xoa"
        Me.btn_xoa.Size = New System.Drawing.Size(83, 27)
        Me.btn_xoa.TabIndex = 13
        Me.btn_xoa.Text = "Xóa"
        Me.btn_xoa.UseVisualStyleBackColor = True
        '
        'btn_sua
        '
        Me.btn_sua.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_sua.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btn_sua.Image = CType(resources.GetObject("btn_sua.Image"), System.Drawing.Image)
        Me.btn_sua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_sua.Location = New System.Drawing.Point(50, 391)
        Me.btn_sua.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btn_sua.Name = "btn_sua"
        Me.btn_sua.Size = New System.Drawing.Size(83, 28)
        Me.btn_sua.TabIndex = 12
        Me.btn_sua.Text = "Sửa"
        Me.btn_sua.UseVisualStyleBackColor = True
        '
        'txt_MaSP
        '
        Me.txt_MaSP.Location = New System.Drawing.Point(141, 80)
        Me.txt_MaSP.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txt_MaSP.Name = "txt_MaSP"
        Me.txt_MaSP.Size = New System.Drawing.Size(145, 20)
        Me.txt_MaSP.TabIndex = 1
        '
        'txt_tensanpham
        '
        Me.txt_tensanpham.Location = New System.Drawing.Point(141, 131)
        Me.txt_tensanpham.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txt_tensanpham.Name = "txt_tensanpham"
        Me.txt_tensanpham.Size = New System.Drawing.Size(145, 20)
        Me.txt_tensanpham.TabIndex = 2
        '
        'btn_lammoi
        '
        Me.btn_lammoi.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_lammoi.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btn_lammoi.Image = CType(resources.GetObject("btn_lammoi.Image"), System.Drawing.Image)
        Me.btn_lammoi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_lammoi.Location = New System.Drawing.Point(50, 479)
        Me.btn_lammoi.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btn_lammoi.Name = "btn_lammoi"
        Me.btn_lammoi.Size = New System.Drawing.Size(83, 27)
        Me.btn_lammoi.TabIndex = 14
        Me.btn_lammoi.Text = "Làm Mới"
        Me.btn_lammoi.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_lammoi.UseVisualStyleBackColor = True
        '
        'txt_mahoadon
        '
        Me.txt_mahoadon.Location = New System.Drawing.Point(466, 83)
        Me.txt_mahoadon.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txt_mahoadon.Name = "txt_mahoadon"
        Me.txt_mahoadon.Size = New System.Drawing.Size(145, 20)
        Me.txt_mahoadon.TabIndex = 5
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(165, 332)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(580, 174)
        Me.DataGridView1.TabIndex = 15
        '
        'frm_hoadon
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(754, 527)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.txt_mahoadon)
        Me.Controls.Add(Me.txt_tensanpham)
        Me.Controls.Add(Me.txt_MaSP)
        Me.Controls.Add(Me.btn_sua)
        Me.Controls.Add(Me.btn_lammoi)
        Me.Controls.Add(Me.btn_xoa)
        Me.Controls.Add(Me.DTP_ngay)
        Me.Controls.Add(Me.btn_nhap)
        Me.Controls.Add(Me.lbl_USD)
        Me.Controls.Add(Me.nud_SoLuong)
        Me.Controls.Add(Me.txt_MaKH)
        Me.Controls.Add(Me.txt_MaNhanVien)
        Me.Controls.Add(Me.txt_DonGia)
        Me.Controls.Add(Me.btn_Tinh)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lbl_tongtien)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "frm_hoadon"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Hóa Đơn"
        CType(Me.nud_SoLuong, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents btn_Tinh As System.Windows.Forms.Button
    Friend WithEvents lbl_tongtien As System.Windows.Forms.Label
    Friend WithEvents txt_DonGia As System.Windows.Forms.TextBox
    Friend WithEvents txt_MaNhanVien As System.Windows.Forms.TextBox
    Friend WithEvents txt_MaKH As System.Windows.Forms.TextBox
    Friend WithEvents nud_SoLuong As System.Windows.Forms.NumericUpDown
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents mns_TroLai As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mns_thoat As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lbl_USD As System.Windows.Forms.Label
    Friend WithEvents btn_nhap As System.Windows.Forms.Button
    Friend WithEvents DTP_ngay As System.Windows.Forms.DateTimePicker
    Friend WithEvents btn_xoa As System.Windows.Forms.Button
    Friend WithEvents btn_sua As System.Windows.Forms.Button
    Friend WithEvents txt_MaSP As System.Windows.Forms.TextBox
    Friend WithEvents txt_tensanpham As System.Windows.Forms.TextBox
    Friend WithEvents btn_lammoi As System.Windows.Forms.Button
    Friend WithEvents txt_mahoadon As System.Windows.Forms.TextBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
End Class
