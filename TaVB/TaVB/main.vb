Public Class main
    Public aa As Integer
    Public ap As Integer = 0
    Public sc As Double = 0
    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        Me.Hide()
        Form1.Show()
    End Sub

    Private Sub PictureBox1_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox1.MouseHover
        'PictureBox1.Size = New Size(480, 220)
        'PictureBox1.Location = New Point(538, 371)
    End Sub

    Private Sub PictureBox1_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox1.MouseLeave
        'PictureBox1.Size = New Size(440, 180)
        'PictureBox1.Location = New Point(604, 410)
    End Sub

    Private Sub main_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class
