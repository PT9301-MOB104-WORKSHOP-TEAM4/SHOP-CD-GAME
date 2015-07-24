Public Class frm_chinh

    Private Sub ĐăngXuấtToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles mns_DangXuat.Click
        frm_dangnhap.Show() 'hiện form đăng nhập
        Me.Hide() 'ẩn form chính

    End Sub

    Private Sub ThoátToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles mns_Thoat.Click
        Me.Close() 'thoát
    End Sub

    

    Private Sub ThêmHóaĐơnToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles mns_HoaDon.Click
        frm_hoadon.Show()
        Me.Hide()
    End Sub

    Private Sub mns_SanPham_Click(sender As Object, e As EventArgs) Handles mns_SanPhamHot.Click
        frm_DanhSach.Show()
        Me.Hide()

    End Sub

   
    Private Sub mns_BanHang_Click(sender As Object, e As EventArgs) Handles mns_BanHang.Click

    End Sub

    Private Sub mns_SanPham_Click_1(sender As Object, e As EventArgs) Handles mns_SanPham.Click
        frm_SanPham.Show()
        Me.Hide()
    End Sub

    Private Sub nms_KhachHang_Click(sender As Object, e As EventArgs) Handles nms_KhachHang.Click
        frm_KhachHang.Show()
        Me.Hide()
    End Sub

    Private Sub mns_NhanVien_Click(sender As Object, e As EventArgs) Handles mns_NhanVien.Click
        Me.Hide()
        frm_nhanvien.Show()
    End Sub

    Private Sub mns_GioiThieu_Click(sender As Object, e As EventArgs) Handles mns_GioiThieu.Click
        frm_gioithieu.Show()
    End Sub

    Private Sub frm_chinh_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class