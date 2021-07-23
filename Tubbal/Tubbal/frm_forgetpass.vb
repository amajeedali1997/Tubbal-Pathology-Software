Imports System.Data.SqlClient
Imports System.Data
Public Class frm_forgetpass
    Dim str, pass As String
    Private Sub btn_getpass_Click(sender As Object, e As EventArgs) Handles btn_getpass.Click
        Dim Strdate As String
        Strdate = Format(DateTimePicker1.Value, "dd/MM/yyyy")

        openconnection()
        Dim cmd As New SqlCommand("Select * from tbl_user where username=@username and dob=@dob", cn)

        cmd.Parameters.Add("@username", SqlDbType.VarChar).Value = TextBox1.Text
        cmd.Parameters.Add("@dob", SqlDbType.VarChar).Value = Strdate

        Dim da As New SqlDataAdapter(cmd)
        Dim table As New DataTable()
        da.Fill(table)
        If table.Rows.Count() <= 0 Then
            MsgBox("Given information is incorrect", MsgBoxStyle.Critical, "Incorrect")
        Else

            str = "select * from tbl_user"
            Dim cmd1 As New SqlCommand
            cmd1 = New SqlCommand(Str, cn)
            Dim reader As SqlDataReader = cmd.ExecuteReader
            While reader.Read()
                pass += reader(1)
            End While
            MsgBox("Your Password is   " & pass)
            reader.Close()
            pass = ""
            TextBox1.Text = ""
        End If
        closeconnection()
    End Sub
End Class