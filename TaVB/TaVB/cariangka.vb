Public Class cariangka


    Dim sec As Integer = 0
    Dim persen As Double = 100

    Private Sub lb0_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lb0.Click


        main.sc = 10 * persen / 100

        Timer1.Enabled = False
        mainmenu.score += main.sc
        selamat.Show()
        Me.Hide()
    End Sub

    Private Sub cariangka_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Form1.curnt = "cari"

    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        ProgressBar1.Increment(1)
        sec += 1
        persen -= 1

        If sec = 100 Then
            MsgBox("gagal")
            gagal.Show()
            Me.Close()
        End If

    End Sub
End Class