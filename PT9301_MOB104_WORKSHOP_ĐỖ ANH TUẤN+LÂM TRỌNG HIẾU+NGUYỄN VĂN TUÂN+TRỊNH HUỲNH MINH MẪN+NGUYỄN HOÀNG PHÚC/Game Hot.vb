Public Class frm_DanhSach


   
    

    Private Sub ThoátToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ThoátToolStripMenuItem.Click
        Me.Close()

    End Sub

    Private Sub TrởLạiToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TrởLạiToolStripMenuItem.Click
        frm_chinh.Show()
        Me.Hide()

    End Sub

End Class