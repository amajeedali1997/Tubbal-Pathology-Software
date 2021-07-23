Imports System.Data.SqlClient
Imports System.IO
Public Class frm_company
    Dim cmd As New SqlCommand
    Dim da As New SqlDataAdapter
    Dim str As String

    Private Sub frm_company_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgv()
        If dgvData.RowCount = 1 Then
            btn_save.Enabled = False
        Else
            btn_save.Enabled = True
        End If
    End Sub

    Private Sub btn_Browse_Click(sender As Object, e As EventArgs) Handles btn_Browse.Click
        Try
            With OpenFileDialog1
                .Filter = ("Images |*.png; *.bmp; *.jpg;*.jpeg; *.gif;*.ico;")
                .FilterIndex = 4
            End With
            'Clear the file name
            OpenFileDialog1.FileName = ""
            If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
                PictureBox1.Image = Image.FromFile(OpenFileDialog1.FileName)
            End If
        Catch ex As Exception
            MsgBox(ex.ToString())
        End Try
    End Sub

    Private Sub btn_save_Click(sender As Object, e As EventArgs) Handles btn_save.Click
        Try
            openconnection()
        Dim cb As String = "insert into tbl_company(companyname, address, city, state, phone, img) VALUES (@d1,@d2,@d3,@d4,@d5,@d6)"
        cmd = New SqlCommand(cb)
        cmd.Connection = cn
        cmd.Parameters.AddWithValue("@d1", TextBox1.Text)
        cmd.Parameters.AddWithValue("@d2", TextBox2.Text)
        cmd.Parameters.AddWithValue("@d3", TextBox3.Text)
        cmd.Parameters.AddWithValue("@d4", TextBox4.Text)
        cmd.Parameters.AddWithValue("@d5", TextBox5.Text)
        Dim ms As New MemoryStream()
        Dim bmpImage As New Bitmap(PictureBox1.Image)
        bmpImage.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg)
        Dim data As Byte() = ms.GetBuffer()
        Dim p As New SqlParameter("@d6", SqlDbType.Image)
        p.Value = data
        cmd.Parameters.Add(p)
            cmd.ExecuteNonQuery()
            MessageBox.Show("Successfully Inserted", "ADDED", MessageBoxButtons.OK, MessageBoxIcon.Information)
            closeconnection()
            dgv()
            clear()
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub btn_update_Click(sender As Object, e As EventArgs) Handles btn_update.Click
        Try
            openconnection()
            Dim cb As String = "Update tbl_company set companyname=@d1, address=@d2, city=@d3, state=@d4, phone=@d5, img=@d6 where Id=" & txtID.Text & ""
            cmd = New SqlCommand(cb)
            cmd.Connection = cn
            cmd.Parameters.AddWithValue("@d1", TextBox1.Text)
            cmd.Parameters.AddWithValue("@d2", TextBox2.Text)
            cmd.Parameters.AddWithValue("@d3", TextBox3.Text)
            cmd.Parameters.AddWithValue("@d4", TextBox4.Text)
            cmd.Parameters.AddWithValue("@d5", TextBox5.Text)
            Dim ms As New MemoryStream()
            Dim bmpImage As New Bitmap(PictureBox1.Image)
            bmpImage.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg)
            Dim data As Byte() = ms.GetBuffer()
            Dim p As New SqlParameter("@d6", SqlDbType.Image)
            p.Value = data
            cmd.Parameters.Add(p)
            cmd.ExecuteNonQuery()
            MessageBox.Show("Successfully Updated", "UPDATED", MessageBoxButtons.OK, MessageBoxIcon.Information)
            closeconnection()
            dgv()
            clear()
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub btn_delete_Click(sender As Object, e As EventArgs) Handles btn_delete.Click
        Dim sno As Integer = InputBox("Enter the ID to Delete")
        If MessageBox.Show("Are you sure want to delete", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            str = "Delete from tbl_company where Id=" & sno & ""
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
            cmd = New SqlCommand("SELECT RTRIM(Id), RTRIM(companyname), RTRIM(address),RTRIM(city), RTRIM(state), RTRIM(phone), img from tbl_company", cn)
            rdr = cmd.ExecuteReader(CommandBehavior.CloseConnection)
            dgvData.Rows.Clear()
            While (rdr.Read() = True)
                dgvData.Rows.Add(rdr(0), rdr(1), rdr(2), rdr(3), rdr(4), rdr(5), rdr(6))
            End While
            closeconnection()
            dgvData.Columns(6).Visible = False
            btn_update.Enabled = False
            btn_delete.Enabled = False
            If dgvData.RowCount = 1 Then
                btn_save.Enabled = False
            Else
                btn_save.Enabled = True
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub btn_exit_Click(sender As Object, e As EventArgs) Handles btn_exit.Click
        Me.Close()
    End Sub

    Private Sub dgvData_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvData.CellClick
        Dim index As Integer = e.RowIndex
        dgvData.Rows(index).Selected = True
    End Sub

    Private Sub dgvData_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles dgvData.MouseClick
        Try
           
            If dgvData.Rows.Count > 0 Then

                Dim dr As DataGridViewRow = dgvData.SelectedRows(0)
                txtID.Text = dr.Cells(0).Value.ToString()
                TextBox1.Text = dr.Cells(1).Value.ToString()
                TextBox2.Text = dr.Cells(2).Value.ToString()
                TextBox3.Text = dr.Cells(3).Value.ToString()
                TextBox4.Text = dr.Cells(4).Value.ToString()
                TextBox5.Text = dr.Cells(5).Value.ToString()
                Dim data As Byte() = DirectCast(dr.Cells(6).Value, Byte())
                Dim ms As New MemoryStream(data)
                Me.PictureBox1.Image = Image.FromStream(ms)
                btn_update.Enabled = True
                btn_save.Enabled = False
                btn_delete.Enabled = True
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            'MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Sub clear()
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""
        PictureBox1.Image = Nothing
    End Sub

    Private Sub dgvData_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvData.CellContentClick

    End Sub

    Private Sub TextBox5_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox5.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub TextBox5_Leave(sender As Object, e As EventArgs) Handles TextBox5.Leave
        If TextBox5.Text.Length < 10 Then
            MessageBox.Show("Mobile Number is Less than 10 Digit", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If

        If TextBox5.Text.Length > 10 Then
            MessageBox.Show("Mobile Number is More than 10 digit", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub TextBox5_TextChanged(sender As Object, e As EventArgs) Handles TextBox5.TextChanged

    End Sub
End Class