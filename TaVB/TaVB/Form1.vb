Imports MySql.Data.MySqlClient

Public Class Form1
    Public strconn As String = "server=localhost; uid=root; pwd=; database=vb;"
    'buat objek adapter 
    Dim myadp As MySqlDataAdapter
    'buat perintah query disini 
    Public conn As New MySqlConnection(strconn)


    Public curnt As String
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim mycmd As New MySqlCommand("insert into phonebook (id,nomorHp,nama,email) values ('" & nama.Text & "')", conn)
        Try
            conn.Open()

        Catch ex As Exception

            If mycmd.ExecuteNonQuery() = 1 Then
                MsgBox("insert data berhasil")
                nama.Text = ""
            End If
        End Try

        Me.Hide()
        mainmenu.Show()

    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Button1.Visible = False
    End Sub

    Private Sub nama_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles nama.TextChanged
        If nama.Text <> "" Then
            Button1.Visible = True
        ElseIf nama.Text = "" Then
            Button1.Visible = False
        End If
    End Sub
End Class