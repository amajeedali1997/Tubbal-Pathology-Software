Imports System.IO
Imports System.Data.SqlClient
Module mdl_con
    Public cn As New SqlConnection

    Dim st As String
    Public Function ReadCS() As String
        Using sr As StreamReader = New StreamReader(Application.StartupPath & "\sqlcon.dat")
            st = sr.ReadLine()
        End Using
        Return st
    End Function

    Public ReadOnly cs As String = ReadCS()

    Public Sub openconnection()
        If cn.State <> ConnectionState.Open Then
            cn.ConnectionString = cs
            cn.Open()
        End If
    End Sub
    Public Sub closeconnection()
        cn.Close()
    End Sub
End Module
