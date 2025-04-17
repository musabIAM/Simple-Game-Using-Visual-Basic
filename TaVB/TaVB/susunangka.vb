Public Class susunangka

    Dim angka As Integer
    Dim lanjut As Integer = 1
    Dim nilai As Integer = 0
    Public sudah As Integer = 0
    Dim sec As Integer = 0
    Dim persen As Double = 100

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click
        angka = 18
        If printah.susun = "DSC" Then
            If angka = lanjut Then
                lanjut -= 1
                Label1.Visible = False
            End If
        Else
            If angka = lanjut Then
                nilai += 1
                lanjut += 1
                Label1.Visible = False
            End If
        End If

    End Sub
    Private Sub Label23_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label23.Click
        angka = 16
        If printah.susun = "DSC" Then
            If angka = lanjut Then
                lanjut -= 1
                Label23.Visible = False
            End If
        Else
            If angka = lanjut Then
                nilai += 1
                lanjut += 1
                Label23.Visible = False
            End If
        End If

    End Sub
    Private Sub Label22_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label22.Click
        angka = 9
        If printah.susun = "DSC" Then
            If angka = lanjut Then
                lanjut -= 1
                Label22.Visible = False
            End If
        Else
            If angka = lanjut Then
                nilai += 1
                lanjut += 1
                Label22.Visible = False
            End If
        End If

    End Sub
    Private Sub Label20_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label20.Click
        angka = 19
        If printah.susun = "DSC" Then
            If angka = lanjut Then
                lanjut -= 1
                Label20.Visible = False
            End If
        Else
            If angka = lanjut Then
                nilai += 1
                lanjut += 1
                Label20.Visible = False
            End If
        End If

    End Sub
    Private Sub Label19_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label19.Click
        angka = 24

        If sudah = 1 Then
            printah.susun = "DSC"
        End If
        If printah.susun = "DSC" Then
            If angka = lanjut Then
                lanjut -= 1
                Label19.Visible = False
            End If
        Else
            If nilai = 23 Then
                If angka = lanjut Then
                    lanjut += 1
                    Label19.Visible = False
                    main.sc = 10 * persen / 100
                    mainmenu.score += main.sc
                    printah.susun = "DSC"
                    Form1.curnt = "susunASC"
                    selamat.Show()
                    Me.Close()
                    nilai = 0
                End If
            End If

        End If

    End Sub
    Private Sub Label18_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label18.Click
        angka = 12
        If printah.susun = "DSC" Then
            If angka = lanjut Then
                lanjut -= 1
                Label18.Visible = False
            End If
        Else
            If angka = lanjut Then
                nilai += 1
                lanjut += 1
                Label18.Visible = False
            End If
        End If

    End Sub
    Private Sub Label17_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label17.Click
        angka = 21
        If printah.susun = "DSC" Then
            If angka = lanjut Then
                lanjut -= 1
                Label17.Visible = False
            End If
        Else
            If angka = lanjut Then
                nilai += 1
                lanjut += 1
                Label17.Visible = False
            End If
        End If

    End Sub
    Private Sub Label16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label16.Click
        angka = 3
        If printah.susun = "DSC" Then
            If angka = lanjut Then
                lanjut -= 1
                Label16.Visible = False
            End If
        Else
            If angka = lanjut Then
                nilai += 1
                lanjut += 1
                Label16.Visible = False
            End If
        End If

    End Sub
    Private Sub Label15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label15.Click
        angka = 20
        If printah.susun = "DSC" Then
            If angka = lanjut Then
                lanjut -= 1
                Label15.Visible = False
            End If
        Else
            If angka = lanjut Then
                nilai += 1
                lanjut += 1
                Label15.Visible = False
            End If
        End If

    End Sub
    Private Sub Label14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label14.Click
        angka = 4
        If printah.susun = "DSC" Then
            If angka = lanjut Then
                lanjut -= 1
                Label14.Visible = False
            End If
        Else
            If angka = lanjut Then
                nilai += 1
                lanjut += 1
                Label14.Visible = False
            End If
        End If

    End Sub
    Private Sub Label13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label13.Click
        angka = 11
        If printah.susun = "DSC" Then
            If angka = lanjut Then
                lanjut -= 1
                Label13.Visible = False
            End If
        Else
            If angka = lanjut Then
                nilai += 1
                lanjut += 1
                Label13.Visible = False
            End If
        End If

    End Sub
    Private Sub Label12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label12.Click
        angka = 15
        If printah.susun = "DSC" Then
            If angka = lanjut Then
                lanjut -= 1
                Label12.Visible = False
            End If
        Else
            If angka = lanjut Then
                nilai += 1
                lanjut += 1
                Label12.Visible = False
            End If
        End If

    End Sub
    Private Sub Label11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label11.Click
        angka = 5
        If printah.susun = "DSC" Then
            If angka = lanjut Then
                lanjut -= 1
                Label11.Visible = False
            End If
        Else
            If angka = lanjut Then
                nilai += 1
                lanjut += 1
                Label11.Visible = False
            End If
        End If

    End Sub
    Private Sub Label10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label10.Click
        angka = 10
        If printah.susun = "DSC" Then
            If angka = lanjut Then
                lanjut -= 1
                Label10.Visible = False
            End If
        Else
            If angka = lanjut Then
                nilai += 1
                lanjut += 1
                Label10.Visible = False
            End If
        End If

    End Sub
    Private Sub Label9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label9.Click
        angka = 8
        If printah.susun = "DSC" Then
            If angka = lanjut Then
                lanjut -= 1
                Label9.Visible = False
            End If
        Else
            If angka = lanjut Then
                nilai += 1
                lanjut += 1
                Label9.Visible = False
            End If
        End If

    End Sub
    Private Sub Label8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label8.Click
        angka = 7
        If printah.susun = "DSC" Then
            If angka = lanjut Then
                lanjut -= 1
                Label8.Visible = False
            End If
        Else
            If angka = lanjut Then
                nilai += 1
                lanjut += 1
                Label8.Visible = False
            End If
        End If

    End Sub
    Private Sub Label7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label7.Click
        angka = 6
        If printah.susun = "DSC" Then
            If angka = lanjut Then
                lanjut -= 1
                Label7.Visible = False
            End If
        Else
            If angka = lanjut Then
                nilai += 1
                lanjut += 1
                Label7.Visible = False
            End If
        End If

    End Sub
    Private Sub Label6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label6.Click
        angka = 14
        If printah.susun = "DSC" Then
            If angka = lanjut Then
                lanjut -= 1
                Label6.Visible = False
            End If
        Else
            If angka = lanjut Then
                nilai += 1
                lanjut += 1
                Label6.Visible = False
            End If
        End If

    End Sub
    Private Sub Label5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label5.Click
        angka = 2
        If printah.susun = "DSC" Then
            If angka = lanjut Then
                lanjut -= 1
                Label5.Visible = False
            End If
        Else
            If angka = lanjut Then
                nilai += 1
                lanjut += 1
                Label5.Visible = False
            End If
        End If

    End Sub
    Private Sub Label4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label4.Click
        angka = 13
        If printah.susun = "DSC" Then
            If angka = lanjut Then
                lanjut -= 1
                Label4.Visible = False
            End If
        Else
            If angka = lanjut Then
                nilai += 1
                lanjut += 1
                Label4.Visible = False
            End If
        End If

    End Sub
    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label3.Click
        angka = 22
        If printah.susun = "DSC" Then
            If angka = lanjut Then
                lanjut -= 1
                Label3.Visible = False
            End If
        Else
            If angka = lanjut Then
                nilai += 1
                lanjut += 1
                Label3.Visible = False
            End If
        End If

    End Sub
    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click
        angka = 23
        If printah.susun = "DSC" Then
            If angka = lanjut Then
                lanjut -= 1
                Label2.Visible = False
            End If
        Else
            If angka = lanjut Then
                nilai += 1
                lanjut += 1
                Label2.Visible = False
            End If
        End If

    End Sub
    Private Sub Label21_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label21.Click
        angka = 17
        If printah.susun = "DSC" Then
            If angka = lanjut Then
                lanjut -= 1
                Label21.Visible = False
            End If
        Else
            If angka = lanjut Then
                nilai += 1
                lanjut += 1
                Label21.Visible = False
            End If
        End If

    End Sub
    Private Sub Label24_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label24.Click
        angka = 1
        If printah.susun = "DSC" Then
            If angka = lanjut Then
                lanjut -= 1
                Label24.Visible = False
                main.sc = 10 * persen / 100
                mainmenu.score += main.sc
                Form1.curnt = "susunDSC"
                selamat.Show()
                Me.Close()
            End If
        Else
            If angka = lanjut Then
                nilai += 1
                lanjut += 1
                Label24.Visible = False
            End If
        End If
    End Sub

    Private Sub susunangka_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated

    End Sub

    Private Sub susunangka_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        If printah.susun = "DSC" Then
            lanjut = 24
            sudah += 1
            Label1.Visible = True
            Label10.Visible = True
            Label11.Visible = True
            Label12.Visible = True
            Label13.Visible = True
            Label14.Visible = True
            Label15.Visible = True
            Label16.Visible = True
            Label17.Visible = True
            Label18.Visible = True
            Label19.Visible = True
            Label2.Visible = True
            Label20.Visible = True
            Label21.Visible = True
            Label22.Visible = True
            Label23.Visible = True
            Label24.Visible = True
            Label3.Visible = True
            Label4.Visible = True
            Label5.Visible = True
            Label6.Visible = True
            Label7.Visible = True
            Label8.Visible = True
            Label9.Visible = True

        End If
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        ProgressBar1.Increment(1)
        sec += 1
        persen -= 1
        If sec = 100 Then
            sec = 0
            MsgBox("gagal")
            gagal.Show()
            Me.Close()
        End If

    End Sub
End Class