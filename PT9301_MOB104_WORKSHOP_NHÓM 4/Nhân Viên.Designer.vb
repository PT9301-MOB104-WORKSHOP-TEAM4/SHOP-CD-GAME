<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_nhanvien
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_nhanvien))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lbl_SoDT = New System.Windows.Forms.Label()
        Me.lbl_DiaChi = New System.Windows.Forms.Label()
        Me.txt_MaNV = New System.Windows.Forms.TextBox()
        Me.txt_HoTen = New System.Windows.Forms.TextBox()
        Me.txt_PhongBan = New System.Windows.Forms.TextBox()
        Me.txt_SoDT = New System.Windows.Forms.TextBox()
        Me.txt_DiaChi = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.btn_Sua = New System.Windows.Forms.Button()
        Me.btn_xoa = New System.Windows.Forms.Button()
        Me.btn_them = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.mns_Thoat = New System.Windows.Forms.ToolStripMenuItem()
        Me.mns_TroLai = New System.Windows.Forms.ToolStripMenuItem()
        Me.btn_LamLai = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(13, 51)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(101, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Mã Nhân Viên:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(62, 116)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 15)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Họ Tên:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(385, 48)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(81, 15)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Phòng Ban:"
        '
        'lbl_SoDT
        '
        Me.lbl_SoDT.AutoSize = True
        Me.lbl_SoDT.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_SoDT.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lbl_SoDT.Location = New System.Drawing.Point(360, 113)
        Me.lbl_SoDT.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_SoDT.Name = "lbl_SoDT"
        Me.lbl_SoDT.Size = New System.Drawing.Size(102, 15)
        Me.lbl_SoDT.TabIndex = 0
        Me.lbl_SoDT.Text = "Số Điện Thoại:"
        '
        'lbl_DiaChi
        '
        Me.lbl_DiaChi.AutoSize = True
        Me.lbl_DiaChi.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_DiaChi.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lbl_DiaChi.Location = New System.Drawing.Point(403, 163)
        Me.lbl_DiaChi.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_DiaChi.Name = "lbl_DiaChi"
        Me.lbl_DiaChi.Size = New System.Drawing.Size(58, 15)
        Me.lbl_DiaChi.TabIndex = 0
        Me.lbl_DiaChi.Text = "Địa Chỉ:"
        '
        'txt_MaNV
        '
        Me.txt_MaNV.Location = New System.Drawing.Point(138, 51)
        Me.txt_MaNV.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_MaNV.Name = "txt_MaNV"
        Me.txt_MaNV.Size = New System.Drawing.Size(216, 21)
        Me.txt_MaNV.TabIndex = 1
        '
        'txt_HoTen
        '
        Me.txt_HoTen.Location = New System.Drawing.Point(138, 113)
        Me.txt_HoTen.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_HoTen.Name = "txt_HoTen"
        Me.txt_HoTen.Size = New System.Drawing.Size(216, 21)
        Me.txt_HoTen.TabIndex = 2
        '
        'txt_PhongBan
        '
        Me.txt_PhongBan.Location = New System.Drawing.Point(494, 48)
        Me.txt_PhongBan.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_PhongBan.Name = "txt_PhongBan"
        Me.txt_PhongBan.Size = New System.Drawing.Size(190, 21)
        Me.txt_PhongBan.TabIndex = 3
        '
        'txt_SoDT
        '
        Me.txt_SoDT.Location = New System.Drawing.Point(494, 110)
        Me.txt_SoDT.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_SoDT.Name = "txt_SoDT"
        Me.txt_SoDT.Size = New System.Drawing.Size(190, 21)
        Me.txt_SoDT.TabIndex = 4
        '
        'txt_DiaChi
        '
        Me.txt_DiaChi.Location = New System.Drawing.Point(494, 163)
        Me.txt_DiaChi.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_DiaChi.Name = "txt_DiaChi"
        Me.txt_DiaChi.Size = New System.Drawing.Size(190, 21)
        Me.txt_DiaChi.TabIndex = 5
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(138, 272)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(4)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(519, 179)
        Me.DataGridView1.TabIndex = 9
        '
        'btn_Sua
        '
        Me.btn_Sua.Image = CType(resources.GetObject("btn_Sua.Image"), System.Drawing.Image)
        Me.btn_Sua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_Sua.Location = New System.Drawing.Point(305, 219)
        Me.btn_Sua.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_Sua.Name = "btn_Sua"
        Me.btn_Sua.Size = New System.Drawing.Size(84, 33)
        Me.btn_Sua.TabIndex = 7
        Me.btn_Sua.Text = "Sửa"
        Me.btn_Sua.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Sua.UseVisualStyleBackColor = True
        '
        'btn_xoa
        '
        Me.btn_xoa.Image = CType(resources.GetObject("btn_xoa.Image"), System.Drawing.Image)
        Me.btn_xoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_xoa.Location = New System.Drawing.Point(494, 219)
        Me.btn_xoa.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_xoa.Name = "btn_xoa"
        Me.btn_xoa.Size = New System.Drawing.Size(85, 32)
        Me.btn_xoa.TabIndex = 8
        Me.btn_xoa.Text = "Xóa"
        Me.btn_xoa.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_xoa.UseVisualStyleBackColor = True
        '
        'btn_them
        '
        Me.btn_them.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_them.Image = CType(resources.GetObject("btn_them.Image"), System.Drawing.Image)
        Me.btn_them.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_them.Location = New System.Drawing.Point(138, 219)
        Me.btn_them.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_them.Name = "btn_them"
        Me.btn_them.Size = New System.Drawing.Size(89, 33)
        Me.btn_them.TabIndex = 6
        Me.btn_them.Text = "Thêm"
        Me.btn_them.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_them.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mns_Thoat, Me.mns_TroLai})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(704, 24)
        Me.MenuStrip1.TabIndex = 10
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'mns_Thoat
        '
        Me.mns_Thoat.Image = CType(resources.GetObject("mns_Thoat.Image"), System.Drawing.Image)
        Me.mns_Thoat.Name = "mns_Thoat"
        Me.mns_Thoat.Size = New System.Drawing.Size(66, 20)
        Me.mns_Thoat.Text = "Thoát"
        '
        'mns_TroLai
        '
        Me.mns_TroLai.Image = CType(resources.GetObject("mns_TroLai.Image"), System.Drawing.Image)
        Me.mns_TroLai.Name = "mns_TroLai"
        Me.mns_TroLai.Size = New System.Drawing.Size(71, 20)
        Me.mns_TroLai.Text = "Trở Lại"
        '
        'btn_LamLai
        '
        Me.btn_LamLai.Image = CType(resources.GetObject("btn_LamLai.Image"), System.Drawing.Image)
        Me.btn_LamLai.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_LamLai.Location = New System.Drawing.Point(32, 351)
        Me.btn_LamLai.Name = "btn_LamLai"
        Me.btn_LamLai.Size = New System.Drawing.Size(98, 34)
        Me.btn_LamLai.TabIndex = 11
        Me.btn_LamLai.Text = "Làm Lại"
        Me.btn_LamLai.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_LamLai.UseVisualStyleBackColor = True
        '
        'frm_nhanvien
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.ClientSize = New System.Drawing.Size(704, 459)
        Me.Controls.Add(Me.btn_LamLai)
        Me.Controls.Add(Me.btn_them)
        Me.Controls.Add(Me.btn_xoa)
        Me.Controls.Add(Me.btn_Sua)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.txt_DiaChi)
        Me.Controls.Add(Me.txt_SoDT)
        Me.Controls.Add(Me.txt_PhongBan)
        Me.Controls.Add(Me.txt_HoTen)
        Me.Controls.Add(Me.txt_MaNV)
        Me.Controls.Add(Me.lbl_DiaChi)
        Me.Controls.Add(Me.lbl_SoDT)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frm_nhanvien"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Nhân Viên"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lbl_SoDT As System.Windows.Forms.Label
    Friend WithEvents lbl_DiaChi As System.Windows.Forms.Label
    Friend WithEvents txt_MaNV As System.Windows.Forms.TextBox
    Friend WithEvents txt_HoTen As System.Windows.Forms.TextBox
    Friend WithEvents txt_PhongBan As System.Windows.Forms.TextBox
    Friend WithEvents txt_SoDT As System.Windows.Forms.TextBox
    Friend WithEvents txt_DiaChi As System.Windows.Forms.TextBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents btn_Sua As System.Windows.Forms.Button
    Friend WithEvents btn_xoa As System.Windows.Forms.Button
    Friend WithEvents btn_them As System.Windows.Forms.Button
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents mns_Thoat As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mns_TroLai As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btn_LamLai As System.Windows.Forms.Button
End Class
