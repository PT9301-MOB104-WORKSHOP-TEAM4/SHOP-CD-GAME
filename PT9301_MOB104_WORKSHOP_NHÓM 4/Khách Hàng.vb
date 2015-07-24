Imports System.Data.SqlClient
Imports System.Data.DataTable
Public Class frm_KhachHang
    Dim tb As New DataTable
    Dim connectstr As String = "workstation id=tuannvps01907.mssql.somee.com;packet size=4096;user id=PS01907;pwd=ILoveyou123;data source=tuannvps01907.mssql.somee.com;persist security info=False;initial catalog=tuannvps01907"
    Public Sub loadData()

        Dim ketnoi As New SqlConnection(connectstr)
        Dim sqlAdapter As New SqlDataAdapter("select * from KhachHang", ketnoi)
        Try
            sqlAdapter.Fill(tb)

        Catch ex As Exception

        End Try
        DataGridView1.DataSource = tb
        ketnoi.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btn_them.Click
        Dim ketnoi As New SqlConnection(connectstr)
        ketnoi.Open()
        Dim stradd As String = "insert into KhachHang values (@MaKH ,@HoTen ,@DiaChi , @SoDT)"
        Dim com As New SqlCommand(stradd, ketnoi)
        Try
            com.Parameters.AddWithValue("@MaKH", txt_MaKH.Text)
            com.Parameters.AddWithValue("@HoTen", Txt_HoTen.Text)
            com.Parameters.AddWithValue("@DiaChi", txt_DiaChi.Text)
            com.Parameters.AddWithValue("@SoDT", txt_SoDT.Text)
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

    Private Sub btn_sua_Click(sender As Object, e As EventArgs) Handles btn_sua.Click
        Dim ketnoi As New SqlConnection(connectstr)
        ketnoi.Open()
        Dim stradd As String = "UPDATE KhachHang SET  HoTen = @HoTen , DiaChi = @DiaChi ,SoDT = @SoDT WHERE MaKH = @MaKH"
        Dim com As New SqlCommand(stradd, ketnoi)
        Try
            com.Parameters.AddWithValue("@MaKH", txt_MaKH.Text)
            com.Parameters.AddWithValue("@HoTen", Txt_HoTen.Text)
            com.Parameters.AddWithValue("@DiaChi", txt_DiaChi.Text)
            com.Parameters.AddWithValue("@SoDT", txt_SoDT.Text)
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

    Private Sub btn_xoa_Click(sender As Object, e As EventArgs) Handles btn_xoa.Click
        Dim ketnoi As New SqlConnection(connectstr)
        ketnoi.Open()
        Dim stradd As String = "Delete from KhachHang WHERE MaKH =@MaKH"
        Dim com As New SqlCommand(stradd, ketnoi)
        Try
            com.Parameters.AddWithValue("@MaKH", txt_MaKH.Text)
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
        txt_MaKH.Text = DataGridView1.Item(0, index).Value
        Txt_HoTen.Text = DataGridView1.Item(1, index).Value
        txt_DiaChi.Text = DataGridView1.Item(2, index).Value
        txt_SoDT.Text = DataGridView1.Item(3, index).Value
    End Sub

    Private Sub frm_KhachHang_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim ketnoi As New SqlConnection(connectstr)
        Dim sqlAdapter As New SqlDataAdapter("select * from KhachHang", ketnoi)
        Try
            ketnoi.Open()
            sqlAdapter.Fill(tb)

        Catch ex As Exception

        End Try
        DataGridView1.DataSource = tb
        ketnoi.Close()
    End Sub

    Private Sub mns_Thoat_Click(sender As Object, e As EventArgs) Handles mns_Thoat.Click
        Me.Close()
    End Sub

    Private Sub mns_trolai_Click(sender As Object, e As EventArgs) Handles mns_trolai.Click
        frm_chinh.Show()
        Me.Hide()
    End Sub

    Private Sub btn_LamLai_Click(sender As Object, e As EventArgs) Handles btn_LamLai.Click

        txt_MaKH.Text = ""
        Txt_HoTen.Text = ""
        txt_DiaChi.Text = ""
        txt_SoDT.Text = ""
    End Sub
End Class