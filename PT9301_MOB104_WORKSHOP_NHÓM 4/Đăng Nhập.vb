Imports System.Data.SqlClient
Public Class frm_dangnhap

    Private Sub btn_dangnhap_Click(sender As Object, e As EventArgs) Handles btn_dangnhap.Click

        Dim chuoiketnoi As String = "workstation id=hieult123.mssql.somee.com;packet size=4096;user id=hieulam1612_SQLLogin_1;pwd=19ltpr1k53;data source=hieult123.mssql.somee.com;persist security info=False;initial catalog=hieult123"
        Dim ketnoi As SqlConnection = New SqlConnection(chuoiketnoi)
        Dim sqlAdapter As New SqlDataAdapter("select * from taikhoan where user='" & txt_user.Text & "' and pass='" & txt_pass.Text & "' ", ketnoi)
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
                txt_pass.Text = ""
                txt_user.Text = ""
                txt_user.Focus()
            End If

        Catch ex As Exception

        End Try

    End Sub

    Private Sub btn_thoat_Click(sender As Object, e As EventArgs) Handles btn_thoat.Click
        Me.Close()
    End Sub
    Private Sub txt_matkhau_KeyDown(ByVal sender As Object, _
                  ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_pass.KeyDown
        If e.KeyCode = Keys.Enter Then
            btn_dangnhap.PerformClick()
        End If
    End Sub


    Private Sub frm_dangnhap_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
