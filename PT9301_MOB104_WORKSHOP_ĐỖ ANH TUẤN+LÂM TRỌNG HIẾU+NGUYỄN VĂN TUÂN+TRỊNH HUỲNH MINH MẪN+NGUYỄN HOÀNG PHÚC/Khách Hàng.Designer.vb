<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_KhachHang
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_KhachHang))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_MaKH = New System.Windows.Forms.TextBox()
        Me.Txt_HoTen = New System.Windows.Forms.TextBox()
        Me.txt_DiaChi = New System.Windows.Forms.TextBox()
        Me.txt_SoDT = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.btn_them = New System.Windows.Forms.Button()
        Me.btn_sua = New System.Windows.Forms.Button()
        Me.btn_xoa = New System.Windows.Forms.Button()
        Me.btn_LamLai = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.mns_Thoat = New System.Windows.Forms.ToolStripMenuItem()
        Me.mns_trolai = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(12, 63)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(132, 18)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Mã Khách Hàng:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(12, 122)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 18)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Họ Tên:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(383, 59)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(68, 18)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Địa Chỉ:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(383, 120)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(120, 18)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Số Điện Thoại:"
        '
        'txt_MaKH
        '
        Me.txt_MaKH.Location = New System.Drawing.Point(162, 59)
        Me.txt_MaKH.Name = "txt_MaKH"
        Me.txt_MaKH.Size = New System.Drawing.Size(215, 22)
        Me.txt_MaKH.TabIndex = 1
        '
        'Txt_HoTen
        '
        Me.Txt_HoTen.Location = New System.Drawing.Point(162, 118)
        Me.Txt_HoTen.Name = "Txt_HoTen"
        Me.Txt_HoTen.Size = New System.Drawing.Size(215, 22)
        Me.Txt_HoTen.TabIndex = 2
        '
        'txt_DiaChi
        '
        Me.txt_DiaChi.Location = New System.Drawing.Point(519, 59)
        Me.txt_DiaChi.Name = "txt_DiaChi"
        Me.txt_DiaChi.Size = New System.Drawing.Size(215, 22)
        Me.txt_DiaChi.TabIndex = 3
        '
        'txt_SoDT
        '
        Me.txt_SoDT.Location = New System.Drawing.Point(519, 118)
        Me.txt_SoDT.Name = "txt_SoDT"
        Me.txt_SoDT.Size = New System.Drawing.Size(215, 22)
        Me.txt_SoDT.TabIndex = 4
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(162, 230)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(525, 150)
        Me.DataGridView1.TabIndex = 9
        '
        'btn_them
        '
        Me.btn_them.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_them.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn_them.Image = CType(resources.GetObject("btn_them.Image"), System.Drawing.Image)
        Me.btn_them.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_them.Location = New System.Drawing.Point(162, 178)
        Me.btn_them.Name = "btn_them"
        Me.btn_them.Size = New System.Drawing.Size(90, 37)
        Me.btn_them.TabIndex = 5
        Me.btn_them.Text = "Thêm"
        Me.btn_them.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_them.UseVisualStyleBackColor = True
        '
        'btn_sua
        '
        Me.btn_sua.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_sua.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn_sua.Image = CType(resources.GetObject("btn_sua.Image"), System.Drawing.Image)
        Me.btn_sua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_sua.Location = New System.Drawing.Point(391, 178)
        Me.btn_sua.Name = "btn_sua"
        Me.btn_sua.Size = New System.Drawing.Size(90, 37)
        Me.btn_sua.TabIndex = 6
        Me.btn_sua.Text = "Sửa"
        Me.btn_sua.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_sua.UseVisualStyleBackColor = True
        '
        'btn_xoa
        '
        Me.btn_xoa.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_xoa.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn_xoa.Image = CType(resources.GetObject("btn_xoa.Image"), System.Drawing.Image)
        Me.btn_xoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_xoa.Location = New System.Drawing.Point(597, 178)
        Me.btn_xoa.Name = "btn_xoa"
        Me.btn_xoa.Size = New System.Drawing.Size(90, 37)
        Me.btn_xoa.TabIndex = 7
        Me.btn_xoa.Text = "Xóa"
        Me.btn_xoa.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_xoa.UseVisualStyleBackColor = True
        '
        'btn_LamLai
        '
        Me.btn_LamLai.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_LamLai.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn_LamLai.Image = CType(resources.GetObject("btn_LamLai.Image"), System.Drawing.Image)
        Me.btn_LamLai.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_LamLai.Location = New System.Drawing.Point(32, 315)
        Me.btn_LamLai.Name = "btn_LamLai"
        Me.btn_LamLai.Size = New System.Drawing.Size(90, 37)
        Me.btn_LamLai.TabIndex = 8
        Me.btn_LamLai.Text = "Làm Lại"
        Me.btn_LamLai.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_LamLai.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mns_Thoat, Me.mns_trolai})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(746, 28)
        Me.MenuStrip1.TabIndex = 4
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'mns_Thoat
        '
        Me.mns_Thoat.Image = CType(resources.GetObject("mns_Thoat.Image"), System.Drawing.Image)
        Me.mns_Thoat.Name = "mns_Thoat"
        Me.mns_Thoat.Size = New System.Drawing.Size(75, 24)
        Me.mns_Thoat.Text = "Thoát"
        '
        'mns_trolai
        '
        Me.mns_trolai.Image = CType(resources.GetObject("mns_trolai.Image"), System.Drawing.Image)
        Me.mns_trolai.Name = "mns_trolai"
        Me.mns_trolai.Size = New System.Drawing.Size(82, 24)
        Me.mns_trolai.Text = "Trở Lại"
        '
        'frm_KhachHang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.ClientSize = New System.Drawing.Size(746, 408)
        Me.Controls.Add(Me.btn_LamLai)
        Me.Controls.Add(Me.btn_xoa)
        Me.Controls.Add(Me.btn_sua)
        Me.Controls.Add(Me.btn_them)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.txt_SoDT)
        Me.Controls.Add(Me.Txt_HoTen)
        Me.Controls.Add(Me.txt_DiaChi)
        Me.Controls.Add(Me.txt_MaKH)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frm_KhachHang"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Khách Hàng"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txt_MaKH As System.Windows.Forms.TextBox
    Friend WithEvents Txt_HoTen As System.Windows.Forms.TextBox
    Friend WithEvents txt_DiaChi As System.Windows.Forms.TextBox
    Friend WithEvents txt_SoDT As System.Windows.Forms.TextBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents btn_them As System.Windows.Forms.Button
    Friend WithEvents btn_sua As System.Windows.Forms.Button
    Friend WithEvents btn_xoa As System.Windows.Forms.Button
    Friend WithEvents btn_LamLai As System.Windows.Forms.Button
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents mns_Thoat As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mns_trolai As System.Windows.Forms.ToolStripMenuItem
End Class
