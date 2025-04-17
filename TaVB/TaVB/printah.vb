Public Class printah

    Public susun As String


    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

        main.ap += 1
        If Form1.curnt = "cari" Then
            cariangka2.Show()
            Me.Close()
        ElseIf Form1.curnt = "cari2" Then
            cariangka3.Show()
            Me.Close()
        ElseIf Form1.curnt = "cari3" Then
            susunangka.Show()
            Me.Close()
        ElseIf Form1.curnt = "susunASC" Then
            susunangka.Show()
            Me.Close()
        Else
            cariangka.Show()
            Me.Close()

        End If


    End Sub

    Private Sub printah_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        If main.ap = 0 Then
            Label2.Text = "CARI ANGKA 0"
        ElseIf main.ap = 1 Then
            Label2.Text = "CARI ANGKA 8"
        ElseIf main.ap = 2 Then
            Label2.Text = "CARI ANGKA 3"
        ElseIf main.ap = 3 Then
            Label2.Location = New Point(456, 390)
            Label2.Text = "SUSUN ANGKA DARI 1 - 24"
        ElseIf main.ap = 4 Then
            Label2.Location = New Point(456, 390)
            Label2.Text = "SUSUN ANGKA DARI 24 - 1"
        Else
            Label2.Text = "aaaaaaaaaaaaaaaa"
        End If
    End Sub
End Class