Public Class game

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click

    End Sub

    Private Sub game_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load




        If mainmenu.kanan > mainmenu.kiri Then
            Label2.Text = "WAH..!!! TERNYATA KAMU LEBIH DOMINAN OTAK KANAN"
        ElseIf mainmenu.kanan < mainmenu.kiri Then
            Label2.Text = "WAH..!!! TERNYATA KAMU LEBIH DOMINAN OTAK KANAN"
        Else
            Label2.Text = "WAH..!!! TERNYATA KAMU LEBIH DOMINAN OTAK KANAN KIRI"
        End If


    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Hide()
        printah.Show()

    End Sub
End Class