Public Class gagal

    Private Sub gagal_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Label2.Text = "YAHH... KAMU GAGAL, SCORE MU SEKARANG : " & mainmenu.score
    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        main.Show()
        Me.Hide()
        Me.Close()
        susunangka.Close()
        cariangka.Close()
        cariangka2.Close()
        cariangka3.Close()

    End Sub
End Class