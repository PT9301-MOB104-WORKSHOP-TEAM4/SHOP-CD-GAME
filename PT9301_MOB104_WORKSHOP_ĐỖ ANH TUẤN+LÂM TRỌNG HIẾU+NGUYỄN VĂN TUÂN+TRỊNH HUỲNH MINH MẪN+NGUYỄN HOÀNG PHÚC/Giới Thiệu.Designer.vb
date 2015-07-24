<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_gioithieu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_gioithieu))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ptb_ThayAnh = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.mns_exit = New System.Windows.Forms.MenuStrip()
        Me.mns_exit1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ofd_AnhDaiDien = New System.Windows.Forms.OpenFileDialog()
        Me.Label5 = New System.Windows.Forms.Label()
        CType(Me.ptb_ThayAnh, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.mns_exit.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Yellow
        Me.Label1.Location = New System.Drawing.Point(94, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(297, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Phần Mềm Quản Lý Bán Game"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Yellow
        Me.Label2.Location = New System.Drawing.Point(156, 78)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(305, 18)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Sinh Viên Thực Hiện : Nguyễn Văn Tuân"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Yellow
        Me.Label3.Location = New System.Drawing.Point(156, 117)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(131, 18)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "MSSV: PS01907"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Yellow
        Me.Label4.Location = New System.Drawing.Point(156, 162)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(301, 18)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Giáo Viên Hướng Dẫn: Trần Duy Phong"
        '
        'ptb_ThayAnh
        '
        Me.ptb_ThayAnh.BackColor = System.Drawing.Color.Transparent
        Me.ptb_ThayAnh.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.ptb_ThayAnh.Image = CType(resources.GetObject("ptb_ThayAnh.Image"), System.Drawing.Image)
        Me.ptb_ThayAnh.Location = New System.Drawing.Point(0, 55)
        Me.ptb_ThayAnh.Name = "ptb_ThayAnh"
        Me.ptb_ThayAnh.Size = New System.Drawing.Size(150, 208)
        Me.ptb_ThayAnh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.ptb_ThayAnh.TabIndex = 1
        Me.ptb_ThayAnh.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(-9, 287)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(502, 135)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 1
        Me.PictureBox2.TabStop = False
        '
        'mns_exit
        '
        Me.mns_exit.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mns_exit1})
        Me.mns_exit.Location = New System.Drawing.Point(0, 0)
        Me.mns_exit.Name = "mns_exit"
        Me.mns_exit.Size = New System.Drawing.Size(484, 28)
        Me.mns_exit.TabIndex = 4
        '
        'mns_exit1
        '
        Me.mns_exit1.Image = CType(resources.GetObject("mns_exit1.Image"), System.Drawing.Image)
        Me.mns_exit1.Name = "mns_exit1"
        Me.mns_exit1.Size = New System.Drawing.Size(61, 24)
        Me.mns_exit1.Text = "Exit"
        '
        'ofd_AnhDaiDien
        '
        Me.ofd_AnhDaiDien.FileName = "Ảnh Đại Diện"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Yellow
        Me.Label5.Location = New System.Drawing.Point(4, 266)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(146, 18)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Click vào thay ảnh"
        '
        'frm_gioithieu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(484, 414)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.ptb_ThayAnh)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.mns_exit)
        Me.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.mns_exit
        Me.Name = "frm_gioithieu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Giới Thiệu"
        CType(Me.ptb_ThayAnh, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.mns_exit.ResumeLayout(False)
        Me.mns_exit.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents ptb_ThayAnh As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents mns_exit As System.Windows.Forms.MenuStrip
    Friend WithEvents mns_exit1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ofd_AnhDaiDien As System.Windows.Forms.OpenFileDialog
    Friend WithEvents Label5 As System.Windows.Forms.Label
End Class
