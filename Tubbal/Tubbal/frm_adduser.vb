Imports System.Data.SqlClient

Public Class frm_adduser
    Dim cmd As New SqlCommand
    Dim da As New SqlDataAdapter
    Dim str As String
    Private Sub btn_save_Click(sender As Object, e As EventArgs) Handles btn_save.Click
        Dim Strdate As String
        Strdate = Format(DateTimePicker1.Value, "dd/MM/yyyy")
        If TextBox2.Text <> TextBox3.Text Then
            MessageBox.Show("Password Mismatch", "Incorrect")
        Else
            Try
                openconnection()
                Dim cb As String = "insert into tbl_user(username, password, dob, usertype) VALUES (@d1,@d2,@d3,@d4)"
                cmd = New SqlCommand(cb)
                cmd.Connection = cn
                cmd.Parameters.AddWithValue("@d1", TextBox1.Text)
                cmd.Parameters.AddWithValue("@d2", TextBox2.Text)
                cmd.Parameters.AddWithValue("@d3", Strdate)
                cmd.Parameters.AddWithValue("@d4", ComboBox1.Text)
                cmd.ExecuteNonQuery()
                MessageBox.Show("Successfully Inserted", "ADDED", MessageBoxButtons.OK, MessageBoxIcon.Information)
                closeconnection()
                dgv()
                clear()
            Catch ex As Exception
                MessageBox.Show(ex.ToString)
            End Try
        End If

    End Sub

    Private Sub btn_delete_Click(sender As Object, e As EventArgs) Handles btn_delete.Click
        If MessageBox.Show("Are you sure want to delete", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            str = "Delete from tbl_user where username=" & TextBox1.Text & ""
            cmd = New SqlCommand(str, cn)
            openconnection()
            da.DeleteCommand = cmd
            da.DeleteCommand.ExecuteNonQuery()
            closeconnection()
            dgv()
            clear()
            MessageBox.Show("Record Deleted Successfully", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            'Do nothing
        End If
    End Sub
    Private Sub dgv()
        Try
            Dim rdr As SqlDataReader
            openconnection()
            cmd = New SqlCommand("SELECT RTRIM(username), RTRIM(password), RTRIM(dob),RTRIM(usertype) from tbl_user", cn)
            rdr = cmd.ExecuteReader(CommandBehavior.CloseConnection)
            dgvData.Rows.Clear()
            While (rdr.Read() = True)
                dgvData.Rows.Add(rdr(0), rdr(1), rdr(2), rdr(3))
            End While
            closeconnection()
            btn_update.Enabled = False
            btn_delete.Enabled = False
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub
    Sub clear()
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
    End Sub
   
    Private Sub btn_update_Click(sender As Object, e As EventArgs) Handles btn_update.Click
        Dim Strdate As String
        Strdate = Format(DateTimePicker1.Value, "dd/MM/yyyy")

        If TextBox2.Text <> TextBox3.Text Then
            MessageBox.Show("Password Mismatch", "Incorrect")
        Else
            Try
                openconnection()
                Dim cb As String = "UPDATE tbl_user SET password=@d2, dob=@d3, usertype=@d4 WHERE username='" & TextBox1.Text & "'"
                cmd = New SqlCommand(cb, cn)
                ' cmd.Connection = cn
                'cmd.Parameters.AddWithValue("@d1", TextBox1.Text)
                cmd.Parameters.AddWithValue("@d2", RTrim(TextBox2.Text))
                cmd.Parameters.AddWithValue("@d3", Strdate)
                cmd.Parameters.AddWithValue("@d4", ComboBox1.Text)
                cmd.ExecuteNonQuery()
                MessageBox.Show("Successfully Updated", "UPDATED", MessageBoxButtons.OK, MessageBoxIcon.Information)
                closeconnection()
                dgv()
                clear()
            Catch ex As Exception
                MessageBox.Show(ex.ToString)
            End Try
        End If
    End Sub

    Private Sub btn_close_Click(sender As Object, e As EventArgs) Handles btn_close.Click
        Me.Close()
        Try
            frm_dashboard.TopLevel = False
            frm_dashboard.TopMost = True
            frm_main.pnl_container.Controls.Clear()
            frm_main.pnl_container.Controls.Add(frm_dashboard)
            frm_dashboard.Show()
        Catch ex As Exception
            MessageBox.Show("Form is Already in Open, Try to Open Another Form")
        End Try
    End Sub

    Private Sub frm_adduser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgv()
        clear()
    End Sub


    Private Sub dgvData_MouseClick(sender As Object, e As MouseEventArgs) Handles dgvData.MouseClick
        Try
            Dim iRow As Integer
            iRow = dgvData.CurrentRow.Index
            TextBox1.Text = "" & dgvData.Item(0, iRow).Value
            TextBox2.Text = "" & dgvData.Item(1, iRow).Value
            DateTimePicker1.Value = "" & dgvData.Item(2, iRow).Value
            ComboBox1.Text = "" & dgvData.Item(3, iRow).Value
            btn_delete.Enabled = True
            btn_update.Enabled = True
            btn_save.Enabled = False
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class