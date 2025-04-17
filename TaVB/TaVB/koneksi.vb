Imports System.Data.Odbc
Imports System.Data
Module koneksi

    Public conn As OdbcConnection
    Public da As OdbcDataAdapter
    Public ds As DataSet
    Public strcon As String
    Public Sub konek()
        strcon = "Driver={MySQL ODBC 3.51 driver};database=vb;server=localhost;uid=root"
        conn = New OdbcConnection(strcon)
        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If

    End Sub
End Module