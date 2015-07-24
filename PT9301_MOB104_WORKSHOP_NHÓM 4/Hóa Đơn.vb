Imports System.Data.DataTable
Imports System.Data.SqlClient
Public Class frm_hoadon
    Dim tb As New DataTable
    Dim connectstr As String = "workstation id=tuannvps01907.mssql.somee.com;packet size=4096;user id=PS01907;pwd=ILoveyou123;data source=tuannvps01907.mssql.somee.com;persist security info=False;initial catalog=tuannvps01907"
    Public Sub loadData()
        Dim ketnoi As New SqlConnection(connectstr)
        Dim sqlAdapter As New SqlDataAdapter("select * from HoaDon", ketnoi)
        Try

            ketnoi.Open()
            sqlAdapter.Fill(tb)

        Catch ex As Exception

        End Try
        DataGridView1.DataSource = tb
        ketnoi.Close()
    End Sub

    Private Sub mns_thoat_Click(sender As Object, e As EventArgs) Handles mns_thoat.Click
        Me.Close()
    End Sub

    Private Sub mns_TroLai_Click(sender As Object, e As EventArgs) Handles mns_TroLai.Click
        frm_chinh.Show()
        Me.Hide()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btn_Tinh.Click
        If txt_MaSP.Text = "G001" Then txt_tensanpham.Text = "Batman Arkham City"
        If txt_MaSP.Text = "G002" Then txt_tensanpham.Text = "Assassin's Creed"
        If txt_MaSP.Text = "G003" Then txt_tensanpham.Text = "DOTA2"
        If txt_MaSP.Text = "G004" Then txt_tensanpham.Text = "Warcraft III"

        Dim gia As Double
        gia = (nud_SoLuong.Value * Val(txt_DonGia.Text))
        lbl_tongtien.Text = String.Format("{0:C}", gia)

       

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles btn_nhap.Click
        Dim ketnoi As New SqlConnection(connectstr)


        ketnoi.Open()

        Dim stradd As String = "INSERT INTO HoaDon VALUES (@MaHoaDon , @GiaTriHoaDon,@Ngay ,@NhanVien_MaNhanVien, @KhachHang_MaKH, @SoLuong ,@SanPham_MaSP)"
        Dim com As New SqlCommand(stradd, ketnoi)
        Try
            com.Parameters.AddWithValue("@MaHoaDon", txt_mahoadon.Text)
            com.Parameters.AddWithValue("@GiaTriHoaDon", lbl_tongtien.Text)
            com.Parameters.AddWithValue("@Ngay", DTP_ngay.Value)
            com.Parameters.AddWithValue("@NhanVien_MaNhanVien", txt_MaNhanVien.Text)
            com.Parameters.AddWithValue("@KhachHang_MaKH", txt_MaKH.Text)
            com.Parameters.AddWithValue("@SoLuong", nud_SoLuong.Value)
            com.Parameters.AddWithValue("@SanPham_MaSP", txt_MaSP.Text)

            com.ExecuteNonQuery()


            ketnoi.Close()


        Catch ex As Exception
            MessageBox.Show("Lỗi Kết Nối", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try
        tb.Clear()
        DataGridView1.DataSource = tb
        DataGridView1.DataSource = Nothing
        loadData()

    End Sub

    Private Sub btn_lammoi_Click(sender As Object, e As EventArgs) Handles btn_lammoi.Click
        txt_MaKH.Text = ""
        txt_MaNhanVien.Text = ""
        txt_DonGia.Text = ""
        txt_mahoadon.Text = ""
        txt_MaSP.Text = ""
        txt_tensanpham.Text = ""
        lbl_tongtien.Text = ""
        nud_SoLuong.Value = 0
    End Sub


    Private Sub btn_sua_Click(sender As Object, e As EventArgs) Handles btn_sua.Click
        Dim ketnoi As New SqlConnection(connectstr)
        ketnoi.Open()
        Dim stradd As String = "UPDATE HoaDon SET  GiaTriHoaDon = @GiaTriHoaDon , Ngay = @Ngay ,NhanVien_MaNhanVien = @NhanVien_MaNhanVien, KhachHang_MaKH = @KhachHang_MaKH , SoLuong = @SoLuong ,SanPham_MaSP = @SanPham_MaSP WHERE MaHoaDon = @MaHoaDon"
        Dim com As New SqlCommand(stradd, ketnoi)

        Try
            com.Parameters.AddWithValue("@MaHoaDon", txt_mahoadon.Text)
            com.Parameters.AddWithValue("@GiaTriHoaDon", lbl_tongtien.Text)
            com.Parameters.AddWithValue("@Ngay", DTP_ngay.Value)
            com.Parameters.AddWithValue("@NhanVien_MaNhanVien", txt_MaNhanVien.Text)
            com.Parameters.AddWithValue("@KhachHang_MaKH", txt_MaKH.Text)
            com.Parameters.AddWithValue("@SoLuong", nud_SoLuong.Value)
            com.Parameters.AddWithValue("@SanPham_MaSP", txt_MaSP.Text)

            ketnoi.Close()


        Catch ex As Exception
            MessageBox.Show("Lỗi Kết Nối", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try
        tb.Clear()
        DataGridView1.DataSource = tb
        DataGridView1.DataSource = Nothing
        loadData()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Dim index As Integer = DataGridView1.CurrentCell.RowIndex
        txt_mahoadon.Text = DataGridView1.Item(0, index).Value
        lbl_tongtien.Text = DataGridView1.Item(1, index).Value
        DTP_ngay.Value = DataGridView1.Item(2, index).Value
        txt_MaNhanVien.Text = DataGridView1.Item(3, index).Value
        txt_MaKH.Text = DataGridView1.Item(4, index).Value
        nud_SoLuong.Value = DataGridView1.Item(5, index).Value
        txt_MaSP.Text = DataGridView1.Item(6, index).Value

    End Sub


    Private Sub btn_xoa_Click(sender As Object, e As EventArgs) Handles btn_xoa.Click
        Dim ketnoi As New SqlConnection(connectstr)
        ketnoi.Open()
        Dim stradd As String = "Delete from HoaDon WHERE MaHoaDon =@MaHoaDon"
        Dim com As New SqlCommand(stradd, ketnoi)
        Try
            com.Parameters.AddWithValue("@MaHoaDon", txt_mahoadon.Text)
            com.ExecuteNonQuery()
            ketnoi.Close()

        Catch ex As Exception
            MessageBox.Show("Lỗi Kết Nối", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        tb.Clear()
        DataGridView1.DataSource = tb
        DataGridView1.DataSource = Nothing
        loadData()
    End Sub

    Private Sub frm_hoadon_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim ketnoi As New SqlConnection(connectstr)
        Dim sqlAdapter As New SqlDataAdapter("select * from HoaDon", ketnoi)
        Try

            ketnoi.Open()
            sqlAdapter.Fill(tb)

        Catch ex As Exception

        End Try
        DataGridView1.DataSource = tb
        ketnoi.Close()
    End Sub

End Class