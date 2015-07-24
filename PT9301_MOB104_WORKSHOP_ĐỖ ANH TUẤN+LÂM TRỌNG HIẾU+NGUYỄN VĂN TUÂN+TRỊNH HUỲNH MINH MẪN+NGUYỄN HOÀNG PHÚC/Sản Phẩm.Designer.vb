<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_SanPham
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_SanPham))
        Me.lbl_maSP = New System.Windows.Forms.Label()
        Me.lbl_tenSP = New System.Windows.Forms.Label()
        Me.lbl_Gia = New System.Windows.Forms.Label()
        Me.lbl_theloai = New System.Windows.Forms.Label()
        Me.txt_gia = New System.Windows.Forms.TextBox()
        Me.txt_MaSP = New System.Windows.Forms.TextBox()
        Me.txt_tenSP = New System.Windows.Forms.TextBox()
        Me.txt_theloai = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.btn_them = New System.Windows.Forms.Button()
        Me.btn_sua = New System.Windows.Forms.Button()
        Me.btn_xoa = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.mns_thoat = New System.Windows.Forms.ToolStripMenuItem()
        Me.mns_trolai = New System.Windows.Forms.ToolStripMenuItem()
        Me.btn_lamlai = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lbl_maSP
        '
        Me.lbl_maSP.AutoSize = True
        Me.lbl_maSP.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_maSP.ForeColor = System.Drawing.Color.Red
        Me.lbl_maSP.Location = New System.Drawing.Point(12, 63)
        Me.lbl_maSP.Name = "lbl_maSP"
        Me.lbl_maSP.Size = New System.Drawing.Size(131, 20)
        Me.lbl_maSP.TabIndex = 0
        Me.lbl_maSP.Text = "Mã Sản Phẩm:"
        '
        'lbl_tenSP
        '
        Me.lbl_tenSP.AutoSize = True
        Me.lbl_tenSP.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_tenSP.ForeColor = System.Drawing.Color.Red
        Me.lbl_tenSP.Location = New System.Drawing.Point(12, 115)
        Me.lbl_tenSP.Name = "lbl_tenSP"
        Me.lbl_tenSP.Size = New System.Drawing.Size(137, 20)
        Me.lbl_tenSP.TabIndex = 0
        Me.lbl_tenSP.Text = "Tên Sản Phẩm:"
        '
        'lbl_Gia
        '
        Me.lbl_Gia.AutoSize = True
        Me.lbl_Gia.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Gia.ForeColor = System.Drawing.Color.Red
        Me.lbl_Gia.Location = New System.Drawing.Point(425, 61)
        Me.lbl_Gia.Name = "lbl_Gia"
        Me.lbl_Gia.Size = New System.Drawing.Size(44, 20)
        Me.lbl_Gia.TabIndex = 0
        Me.lbl_Gia.Text = "Giá:"
        '
        'lbl_theloai
        '
        Me.lbl_theloai.AutoSize = True
        Me.lbl_theloai.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_theloai.ForeColor = System.Drawing.Color.Red
        Me.lbl_theloai.Location = New System.Drawing.Point(381, 115)
        Me.lbl_theloai.Name = "lbl_theloai"
        Me.lbl_theloai.Size = New System.Drawing.Size(88, 20)
        Me.lbl_theloai.TabIndex = 0
        Me.lbl_theloai.Text = "Thể Loại:"
        '
        'txt_gia
        '
        Me.txt_gia.Location = New System.Drawing.Point(475, 63)
        Me.txt_gia.Name = "txt_gia"
        Me.txt_gia.Size = New System.Drawing.Size(190, 22)
        Me.txt_gia.TabIndex = 3
        '
        'txt_MaSP
        '
        Me.txt_MaSP.Location = New System.Drawing.Point(155, 63)
        Me.txt_MaSP.Name = "txt_MaSP"
        Me.txt_MaSP.Size = New System.Drawing.Size(190, 22)
        Me.txt_MaSP.TabIndex = 1
        '
        'txt_tenSP
        '
        Me.txt_tenSP.Location = New System.Drawing.Point(155, 115)
        Me.txt_tenSP.Name = "txt_tenSP"
        Me.txt_tenSP.Size = New System.Drawing.Size(190, 22)
        Me.txt_tenSP.TabIndex = 2
        '
        'txt_theloai
        '
        Me.txt_theloai.Location = New System.Drawing.Point(475, 113)
        Me.txt_theloai.Name = "txt_theloai"
        Me.txt_theloai.Size = New System.Drawing.Size(190, 22)
        Me.txt_theloai.TabIndex = 4
        '
        'DataGridView1
        '
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.DataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(125, 247)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(449, 150)
        Me.DataGridView1.TabIndex = 8
        '
        'btn_them
        '
        Me.btn_them.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_them.ForeColor = System.Drawing.Color.Maroon
        Me.btn_them.Image = CType(resources.GetObject("btn_them.Image"), System.Drawing.Image)
        Me.btn_them.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_them.Location = New System.Drawing.Point(137, 174)
        Me.btn_them.Name = "btn_them"
        Me.btn_them.Size = New System.Drawing.Size(87, 28)
        Me.btn_them.TabIndex = 5
        Me.btn_them.Text = "Thêm"
        Me.btn_them.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_them.UseVisualStyleBackColor = True
        '
        'btn_sua
        '
        Me.btn_sua.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_sua.ForeColor = System.Drawing.Color.Maroon
        Me.btn_sua.Image = CType(resources.GetObject("btn_sua.Image"), System.Drawing.Image)
        Me.btn_sua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_sua.Location = New System.Drawing.Point(300, 174)
        Me.btn_sua.Name = "btn_sua"
        Me.btn_sua.Size = New System.Drawing.Size(89, 28)
        Me.btn_sua.TabIndex = 6
        Me.btn_sua.Text = "Sửa"
        Me.btn_sua.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_sua.UseVisualStyleBackColor = True
        '
        'btn_xoa
        '
        Me.btn_xoa.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_xoa.ForeColor = System.Drawing.Color.Maroon
        Me.btn_xoa.Image = CType(resources.GetObject("btn_xoa.Image"), System.Drawing.Image)
        Me.btn_xoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_xoa.Location = New System.Drawing.Point(491, 174)
        Me.btn_xoa.Name = "btn_xoa"
        Me.btn_xoa.Size = New System.Drawing.Size(83, 28)
        Me.btn_xoa.TabIndex = 7
        Me.btn_xoa.Text = "Xóa"
        Me.btn_xoa.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_xoa.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mns_thoat, Me.mns_trolai})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(707, 28)
        Me.MenuStrip1.TabIndex = 4
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'mns_thoat
        '
        Me.mns_thoat.Image = CType(resources.GetObject("mns_thoat.Image"), System.Drawing.Image)
        Me.mns_thoat.Name = "mns_thoat"
        Me.mns_thoat.Size = New System.Drawing.Size(75, 24)
        Me.mns_thoat.Text = "Thoát"
        '
        'mns_trolai
        '
        Me.mns_trolai.Image = CType(resources.GetObject("mns_trolai.Image"), System.Drawing.Image)
        Me.mns_trolai.Name = "mns_trolai"
        Me.mns_trolai.Size = New System.Drawing.Size(82, 24)
        Me.mns_trolai.Text = "Trở Lại"
        '
        'btn_lamlai
        '
        Me.btn_lamlai.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_lamlai.ForeColor = System.Drawing.Color.Maroon
        Me.btn_lamlai.Image = CType(resources.GetObject("btn_lamlai.Image"), System.Drawing.Image)
        Me.btn_lamlai.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_lamlai.Location = New System.Drawing.Point(12, 312)
        Me.btn_lamlai.Name = "btn_lamlai"
        Me.btn_lamlai.Size = New System.Drawing.Size(107, 35)
        Me.btn_lamlai.TabIndex = 9
        Me.btn_lamlai.Text = "Làm Lại"
        Me.btn_lamlai.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_lamlai.UseVisualStyleBackColor = True
        '
        'frm_SanPham
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(707, 409)
        Me.Controls.Add(Me.btn_lamlai)
        Me.Controls.Add(Me.btn_xoa)
        Me.Controls.Add(Me.btn_sua)
        Me.Controls.Add(Me.btn_them)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.txt_theloai)
        Me.Controls.Add(Me.txt_MaSP)
        Me.Controls.Add(Me.txt_tenSP)
        Me.Controls.Add(Me.txt_gia)
        Me.Controls.Add(Me.lbl_theloai)
        Me.Controls.Add(Me.lbl_Gia)
        Me.Controls.Add(Me.lbl_tenSP)
        Me.Controls.Add(Me.lbl_maSP)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frm_SanPham"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Sản Phẩm"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbl_maSP As System.Windows.Forms.Label
    Friend WithEvents lbl_tenSP As System.Windows.Forms.Label
    Friend WithEvents lbl_Gia As System.Windows.Forms.Label
    Friend WithEvents lbl_theloai As System.Windows.Forms.Label
    Friend WithEvents txt_gia As System.Windows.Forms.TextBox
    Friend WithEvents txt_MaSP As System.Windows.Forms.TextBox
    Friend WithEvents txt_tenSP As System.Windows.Forms.TextBox
    Friend WithEvents txt_theloai As System.Windows.Forms.TextBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents btn_them As System.Windows.Forms.Button
    Friend WithEvents btn_sua As System.Windows.Forms.Button
    Friend WithEvents btn_xoa As System.Windows.Forms.Button
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents mns_thoat As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mns_trolai As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btn_lamlai As System.Windows.Forms.Button
End Class
