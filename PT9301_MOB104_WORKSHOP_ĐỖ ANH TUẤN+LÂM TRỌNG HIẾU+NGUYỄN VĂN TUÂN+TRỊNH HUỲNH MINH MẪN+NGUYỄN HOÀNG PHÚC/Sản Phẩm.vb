Imports System.Data.SqlClient
Imports System.Data.DataTable

Public Class frm_SanPham
    Dim tb As New DataTable
    Dim connectstr As String = "workstation id=tuannvps01907.mssql.somee.com;packet size=4096;user id=PS01907;pwd=ILoveyou123;data source=tuannvps01907.mssql.somee.com;persist security info=False;initial catalog=tuannvps01907"
    Public Sub loadData()
        Dim ketnoi As New SqlConnection(connectstr)
        Dim sqlAdapter As New SqlDataAdapter("select * from SanPham", ketnoi)
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

        Dim stradd As String = "INSERT INTO SanPham VALUES (@MaSp , @TenSp,@Gia ,@LoaiSanPham)"
        Dim com As New SqlCommand(stradd, ketnoi)
        Try
            com.Parameters.AddWithValue("@MaSp", txt_MaSP.Text)
            com.Parameters.AddWithValue("@Tensp", txt_tenSP.Text)
            com.Parameters.AddWithValue("@Gia", txt_gia.Text)
            com.Parameters.AddWithValue("@LoaiSanPham", txt_theloai.Text)

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
        Dim stradd As String = "UPDATE SanPham SET  TenSp = @TenSp,Gia = @Gia,LoaiSanPham = @LoaiSanPham WHERE Masp = @MaSp"
        Dim com As New SqlCommand(stradd, ketnoi)

        Try
            com.Parameters.AddWithValue("@MaSp", txt_MaSP.Text)
            com.Parameters.AddWithValue("@TenSp", txt_tenSP.Text)
            com.Parameters.AddWithValue("@Gia", txt_gia.Text)
            com.Parameters.AddWithValue("@LoaiSanPham", txt_theloai.Text)
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
        Dim stradd As String = "Delete from SanPham WHERE MaSP =@MaSP"
        Dim com As New SqlCommand(stradd, ketnoi)
        Try
            com.Parameters.AddWithValue("@MaSP", txt_MaSP.Text)
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
        txt_MaSP.Text = DataGridView1.Item(0, index).Value
        txt_tenSP.Text = DataGridView1.Item(1, index).Value
        txt_gia.Text = DataGridView1.Item(2, index).Value
        txt_theloai.Text = DataGridView1.Item(3, index).Value
    End Sub

    Private Sub frm_SanPham_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim ketnoi As New SqlConnection(connectstr)
        Dim sqlAdapter As New SqlDataAdapter("select * from SanPham", ketnoi)
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

    Private Sub mns_trolai_Click(sender As Object, e As EventArgs) Handles mns_trolai.Click
        frm_chinh.Show()
        Me.Hide()
    End Sub

    Private Sub btn_lamlai_Click(sender As Object, e As EventArgs) Handles btn_lamlai.Click
        txt_gia.Text = ""
        txt_MaSP.Text = ""
        txt_tenSP.Text = ""
        txt_theloai.Text = ""
    End Sub
End Class