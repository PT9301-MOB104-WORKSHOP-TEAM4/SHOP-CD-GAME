Imports System.Data.SqlClient
Public Class frm_dangnhap



    Private Sub btn_dangnhap_Click(sender As Object, e As EventArgs) Handles btn_dangnhap.Click
        Dim chuoiketnoi As String = "workstation id=tuannvps01907.mssql.somee.com;packet size=4096;user id=PS01907;pwd=ILoveyou123;data source=tuannvps01907.mssql.somee.com;persist security info=False;initial catalog=tuannvps01907"
        Dim ketnoi As SqlConnection = New SqlConnection(chuoiketnoi)
        Dim sqlAdapter As New SqlDataAdapter("select * from TaiKhoan where Ten_DangNhap ='" & txt_tendangnnhap.Text & "' and MatKhau='" & txt_matkhau.Text & "' ", ketnoi)
        Dim tb As New DataTable

        Try
            ketnoi.Open()
            sqlAdapter.Fill(tb)
            If tb.Rows.Count > 0 Then
                MessageBox.Show("kết nối thành công")
                frm_chinh.Show()
                Me.Hide()
            Else
                MessageBox.Show("Sai Tai Khoan hoac Mat Khau")
                txt_matkhau.Text = ""
                txt_tendangnnhap.Text = ""
                txt_tendangnnhap.Focus()
            End If

        Catch ex As Exception

        End Try

    End Sub

    Private Sub btn_thoat_Click(sender As Object, e As EventArgs) Handles btn_thoat.Click
        Me.Close()
    End Sub
    Private Sub txt_matkhau_KeyDown(ByVal sender As Object, _
                  ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_matkhau.KeyDown
        If e.KeyCode = Keys.Enter Then      'nếu nhấn phím enter
            btn_dangnhap.PerformClick()          'chuyển sang sự kiện click nút đăng nhập
        End If
    End Sub


End Class
