<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_dangnhap
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_dangnhap))
        Me.txt_matkhau = New System.Windows.Forms.TextBox()
        Me.lbl_tendangnhap = New System.Windows.Forms.Label()
        Me.lbl_matkhau = New System.Windows.Forms.Label()
        Me.txt_tendangnnhap = New System.Windows.Forms.TextBox()
        Me.btn_dangnhap = New System.Windows.Forms.Button()
        Me.btn_thoat = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lbl_dangnhap = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txt_matkhau
        '
        Me.txt_matkhau.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_matkhau.Location = New System.Drawing.Point(363, 152)
        Me.txt_matkhau.Name = "txt_matkhau"
        Me.txt_matkhau.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txt_matkhau.Size = New System.Drawing.Size(181, 23)
        Me.txt_matkhau.TabIndex = 2
        '
        'lbl_tendangnhap
        '
        Me.lbl_tendangnhap.AutoSize = True
        Me.lbl_tendangnhap.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_tendangnhap.ForeColor = System.Drawing.Color.Maroon
        Me.lbl_tendangnhap.Location = New System.Drawing.Point(208, 101)
        Me.lbl_tendangnhap.Name = "lbl_tendangnhap"
        Me.lbl_tendangnhap.Size = New System.Drawing.Size(123, 17)
        Me.lbl_tendangnhap.TabIndex = 2
        Me.lbl_tendangnhap.Text = "Tên đăng nhập:"
        '
        'lbl_matkhau
        '
        Me.lbl_matkhau.AutoSize = True
        Me.lbl_matkhau.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_matkhau.ForeColor = System.Drawing.Color.Maroon
        Me.lbl_matkhau.Location = New System.Drawing.Point(208, 152)
        Me.lbl_matkhau.Name = "lbl_matkhau"
        Me.lbl_matkhau.Size = New System.Drawing.Size(79, 17)
        Me.lbl_matkhau.TabIndex = 2
        Me.lbl_matkhau.Text = "Mật khẩu:"
        '
        'txt_tendangnnhap
        '
        Me.txt_tendangnnhap.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_tendangnnhap.Location = New System.Drawing.Point(363, 101)
        Me.txt_tendangnnhap.Name = "txt_tendangnnhap"
        Me.txt_tendangnnhap.Size = New System.Drawing.Size(181, 23)
        Me.txt_tendangnnhap.TabIndex = 1
        '
        'btn_dangnhap
        '
        Me.btn_dangnhap.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_dangnhap.ForeColor = System.Drawing.Color.Maroon
        Me.btn_dangnhap.Location = New System.Drawing.Point(284, 197)
        Me.btn_dangnhap.Name = "btn_dangnhap"
        Me.btn_dangnhap.Size = New System.Drawing.Size(125, 33)
        Me.btn_dangnhap.TabIndex = 3
        Me.btn_dangnhap.Text = "Đăng Nhập"
        Me.btn_dangnhap.UseVisualStyleBackColor = True
        '
        'btn_thoat
        '
        Me.btn_thoat.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_thoat.ForeColor = System.Drawing.Color.Maroon
        Me.btn_thoat.Location = New System.Drawing.Point(442, 197)
        Me.btn_thoat.Name = "btn_thoat"
        Me.btn_thoat.Size = New System.Drawing.Size(102, 33)
        Me.btn_thoat.TabIndex = 4
        Me.btn_thoat.Text = "Thoát"
        Me.btn_thoat.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(202, 251)
        Me.PictureBox1.TabIndex = 5
        Me.PictureBox1.TabStop = False
        '
        'lbl_dangnhap
        '
        Me.lbl_dangnhap.AutoSize = True
        Me.lbl_dangnhap.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_dangnhap.ForeColor = System.Drawing.Color.Navy
        Me.lbl_dangnhap.Location = New System.Drawing.Point(296, 25)
        Me.lbl_dangnhap.Name = "lbl_dangnhap"
        Me.lbl_dangnhap.Size = New System.Drawing.Size(131, 24)
        Me.lbl_dangnhap.TabIndex = 6
        Me.lbl_dangnhap.Text = "ĐĂNG NHẬP"
        '
        'frm_dangnhap
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LimeGreen
        Me.ClientSize = New System.Drawing.Size(556, 253)
        Me.Controls.Add(Me.lbl_dangnhap)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btn_thoat)
        Me.Controls.Add(Me.btn_dangnhap)
        Me.Controls.Add(Me.lbl_matkhau)
        Me.Controls.Add(Me.lbl_tendangnhap)
        Me.Controls.Add(Me.txt_tendangnnhap)
        Me.Controls.Add(Me.txt_matkhau)
        Me.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_dangnhap"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "HỆ THỐNG ĐĂNG NHẬP"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txt_matkhau As System.Windows.Forms.TextBox
    Friend WithEvents lbl_tendangnhap As System.Windows.Forms.Label
    Friend WithEvents lbl_matkhau As System.Windows.Forms.Label
    Friend WithEvents txt_tendangnnhap As System.Windows.Forms.TextBox
    Friend WithEvents btn_dangnhap As System.Windows.Forms.Button
    Friend WithEvents btn_thoat As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents lbl_dangnhap As System.Windows.Forms.Label

End Class
