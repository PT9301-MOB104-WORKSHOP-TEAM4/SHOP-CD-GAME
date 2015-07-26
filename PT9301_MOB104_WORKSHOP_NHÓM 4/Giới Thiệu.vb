Imports System.IO
Public Class frm_gioithieu



    Private Sub mns_exit1_Click(sender As Object, e As EventArgs) Handles mns_exit1.Click
        Me.Close()
    End Sub


    Private Sub ptb_ThayAnh_Click(sender As Object, e As EventArgs)
        If (ofd_AnhDaiDien.ShowDialog() = Windows.Forms.DialogResult.OK) Then

            Dim formpath As String = ofd_AnhDaiDien.FileName
            Dim topath As String = "hinh\" & ofd_AnhDaiDien.SafeFileName
            File.Copy(formpath, topath, True)

            ptb_ThayAnh.ImageLocation = topath



        End If
    End Sub
End Class