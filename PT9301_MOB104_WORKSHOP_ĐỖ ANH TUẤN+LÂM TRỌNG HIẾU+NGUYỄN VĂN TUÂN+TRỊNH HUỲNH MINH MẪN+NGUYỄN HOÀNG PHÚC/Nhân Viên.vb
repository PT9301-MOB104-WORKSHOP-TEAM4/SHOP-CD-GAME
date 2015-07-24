Imports System.Data.SqlClient
Imports System.Data.DataTable

Public Class frm_nhanvien
    Dim tb As New DataTable
    Dim connectstr As String = "workstation id=tuannvps01907.mssql.somee.com;packet size=4096;user id=PS01907;pwd=ILoveyou123;data source=tuannvps01907.mssql.somee.com;persist security info=False;initial catalog=tuannvps01907"
    Public Sub loadData()
        Dim ketnoi As New SqlConnection(connectstr)
        Dim sqlAdapter As New SqlDataAdapter("select * from NhanVien", ketnoi)
        Try

            ketnoi.Open()
            sqlAdapter.Fill(tb)

        Catch ex As Exception

        End Try
        DataGridView1.DataSource = tb
        ketnoi.Close()
    End Sub

    Private Sub btn_them_Click(sender As Object, e As EventArgs) Handles btn_them.Click
        Dim ketnoi As New SqlConnection(connectstr)


        ketnoi.Open()

        Dim stradd As String = "INSERT INTO NhanVien VALUES (@MaNhanVien , @HoTen,@PhongBan ,@SoDT ,@DiaChi)"
        Dim com As New SqlCommand(stradd, ketnoi)
        Try
            com.Parameters.AddWithValue("@MaNhanVien", txt_MaNV.Text)
            com.Parameters.AddWithValue("@HoTen", txt_HoTen.Text)
            com.Parameters.AddWithValue("@PhongBan", txt_PhongBan.Text)
            com.Parameters.AddWithValue("@SoDT", txt_SoDT.Text)
            com.Parameters.AddWithValue("@DiaChi", txt_DiaChi.Text)

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

    Private Sub btn_Sua_Click(sender As Object, e As EventArgs) Handles btn_Sua.Click
        Dim ketnoi As New SqlConnection(connectstr)
        ketnoi.Open()
        Dim stradd As String = "UPDATE NhanVien SET  HoTen = @HoTen , PhongBan = @PhongBan ,SoDT = @SoDT ,DiaChi = @DiaChi WHERE MaNhanVien = @MaNhanVien"
        Dim com As New SqlCommand(stradd, ketnoi)

        Try
            com.Parameters.AddWithValue("@MaNhanVien", txt_MaNV.Text)
            com.Parameters.AddWithValue("@HoTen", txt_HoTen.Text)
            com.Parameters.AddWithValue("@PhongBan", txt_PhongBan.Text)
            com.Parameters.AddWithValue("@SoDT", txt_SoDT.Text)
            com.Parameters.AddWithValue("@DiaChi", txt_DiaChi.Text)
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

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Dim index As Integer = DataGridView1.CurrentCell.RowIndex
        txt_MaNV.Text = DataGridView1.Item(0, index).Value
        txt_HoTen.Text = DataGridView1.Item(1, index).Value
        txt_PhongBan.Text = DataGridView1.Item(2, index).Value
        txt_SoDT.Text = DataGridView1.Item(3, index).Value
        txt_DiaChi.Text = DataGridView1.Item(4, index).Value
    End Sub

    Private Sub frm_nhanvien_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim ketnoi As New SqlConnection(connectstr)
        Dim sqlAdapter As New SqlDataAdapter("select * from NhanVien", ketnoi)
        Try

            sqlAdapter.Fill(tb)

        Catch ex As Exception

        End Try
        DataGridView1.DataSource = tb
        ketnoi.Close()
    End Sub

    Private Sub btn_xoa_Click(sender As Object, e As EventArgs) Handles btn_xoa.Click
        Dim ketnoi As New SqlConnection(connectstr)
        ketnoi.Open()
        Dim stradd As String = "Delete from NhanVien WHERE MaNhanVien =@MaNhanVien"
        Dim com As New SqlCommand(stradd, ketnoi)
        Try
            com.Parameters.AddWithValue("@MaNhanVien", txt_MaNV.Text)
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

    Private Sub mns_Thoat_Click(sender As Object, e As EventArgs) Handles mns_Thoat.Click
        Me.Close()
    End Sub

    Private Sub mns_TroLai_Click(sender As Object, e As EventArgs) Handles mns_TroLai.Click
        frm_chinh.Show()
        Me.Hide()
    End Sub

    Private Sub btn_LamLai_Click(sender As Object, e As EventArgs) Handles btn_LamLai.Click
        txt_DiaChi.Text = ""
        txt_HoTen.Text = ""
        txt_MaNV.Text = ""
        txt_PhongBan.Text = ""
        txt_SoDT.Text = ""
    End Sub
End Class