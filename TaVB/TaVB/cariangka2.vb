﻿Public Class cariangka2
    Dim sec As Integer = 0
    Dim persen As Double = 100
    Private Sub cariangka2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Form1.curnt = "cari2"

    End Sub
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick

        ProgressBar1.Increment(2)
        persen -= 1
        sec += 2
        If sec = 100 Then
            MsgBox("gagal")
        End If

    End Sub

    Private Sub Label173_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label173.Click
        main.sc = 10 * persen / 100

        Timer1.Enabled = False
        mainmenu.score += main.sc
        selamat.Show()
        Me.Hide()
    End Sub
End Class