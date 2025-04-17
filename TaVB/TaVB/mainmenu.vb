Public Class mainmenu

    Public kanan As Integer = 0
    Public kiri As Integer = 0
    Public lan As Integer = 0
    Public score As Integer = 0



    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        kiri += 1
        If lan = 0 Then
            PictureBox1.Image = My.Resources.keduaA
            PictureBox2.Image = My.Resources.keduaB_png
            lan += 1
        ElseIf lan = 1 Then
            PictureBox1.Image = My.Resources.ketigaA
            PictureBox2.Image = My.Resources.ketigaB
            lan += 1
        ElseIf lan = 2 Then
            PictureBox1.Image = My.Resources.keempat
            PictureBox2.Image = My.Resources.keempatB
            lan += 1
        ElseIf lan = 3 Then
            game.Show()
            Me.Hide()
        End If

    End Sub

    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click
        kanan += 1
        If lan = 0 Then
            PictureBox1.Image = My.Resources.keduaA
            PictureBox2.Image = My.Resources.keduaB_png
            lan += 1
        ElseIf lan = 1 Then
            PictureBox1.Image = My.Resources.ketigaA
            PictureBox2.Image = My.Resources.ketigaB
            lan += 1
        ElseIf lan = 2 Then
            PictureBox1.Image = My.Resources.keempat
            PictureBox2.Image = My.Resources.keempatB
            lan += 1
        ElseIf lan = 3 Then
            game.Show()
            Me.Hide()
        End If

    End Sub

   
End Class