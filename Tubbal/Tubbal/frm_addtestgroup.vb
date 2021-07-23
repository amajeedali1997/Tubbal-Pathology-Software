Imports System.Data.SqlClient
Public Class frm_addtestgroup

    Dim cmd As New SqlCommand
    Dim da As New SqlDataAdapter
    Dim str As String
    Dim dr As SqlDataReader

    Public MoveForm As Boolean
    Public MoveForm_MousePosition As Point
    Public Sub MoveForm_MouseDown(sender As Object, e As MouseEventArgs) Handles _
    MyBase.MouseDown, Panel1.MouseDown, PictureBox1.MouseDown, Label1.MouseDown

        If e.Button = MouseButtons.Left Then
            MoveForm = True
            Me.Cursor = Cursors.NoMove2D
            MoveForm_MousePosition = e.Location
        End If

    End Sub

    Public Sub MoveForm_MouseMove(sender As Object, e As MouseEventArgs) Handles _
    MyBase.MouseMove, Panel1.MouseMove, PictureBox1.MouseMove, Label1.MouseMove

        If MoveForm Then
            Me.Location = Me.Location + (e.Location - MoveForm_MousePosition)
        End If

    End Sub

    Public Sub MoveForm_MouseUp(sender As Object, e As MouseEventArgs) Handles _
    MyBase.MouseUp, Panel1.MouseUp, PictureBox1.MouseUp, Label1.MouseUp

        If e.Button = MouseButtons.Left Then
            MoveForm = False
            Me.Cursor = Cursors.Default
        End If

    End Sub
    Private Sub btn_exit_Click(sender As Object, e As EventArgs) Handles btn_exit.Click
        Me.Close()
    End Sub


    Private Sub btn_save_Click(sender As Object, e As EventArgs) Handles btn_save.Click
        Try
            openconnection()
            str = "insert into tbl_addgroup values('" & TextBox1.Text & "','" & TextBox2.Text & "')"
            cmd = New SqlCommand(Str, cn)
            da.InsertCommand = cmd
            da.InsertCommand.ExecuteNonQuery()
            MessageBox.Show("Group Added Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            closeconnection()
            TextBox1.Text = ""
            TextBox2.Text = ""
            autogen()
            dgv()
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub btn_update_Click(sender As Object, e As EventArgs) Handles btn_update.Click
        Try
            openconnection()
            str = "Update tbl_addgroup SET testgroupname='" & TextBox1.Text & "' where serialno=" & TextBox2.Text & ""
            cmd = New SqlCommand(str, cn)
            da.UpdateCommand = cmd
            da.UpdateCommand.ExecuteNonQuery()
            MessageBox.Show("Group Updated Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            closeconnection()
            TextBox1.Text = ""
            autogen()
            dgv()
            btn_save.Enabled = True
            btn_delete.Enabled = False
            btn_update.Enabled = False
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub btn_delete_Click(sender As Object, e As EventArgs) Handles btn_delete.Click
        Try
            If TextBox1.Text = "" Then
                MessageBox.Show("Select the Data First", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Else
                If MessageBox.Show("Do you really want to Delete this Record?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then
                    openconnection()
                    str = "delete from tbl_addgroup where serialno = " & TextBox2.Text & " "
                    cmd = New SqlCommand(str, cn)
                    da.DeleteCommand = cmd
                    da.DeleteCommand.ExecuteNonQuery()
                    closeconnection()
                    TextBox1.Text = ""
                    TextBox2.Text = ""
                    autogen()
                    dgv()
                    btn_save.Enabled = True
                    btn_delete.Enabled = False
                    btn_update.Enabled = False
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub
    Private Sub autogen()
        Try
            openconnection()
            Dim number As Integer
            cmd = New SqlCommand("Select Max(serialno) from tbl_addgroup", cn)

            If IsDBNull(cmd.ExecuteScalar) Then
                number = 1
                TextBox2.Text = number
            Else
                number = cmd.ExecuteScalar + 1
                TextBox2.Text = number
            End If
            closeconnection()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
       
    End Sub

    Private Sub frm_addtestgroup_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            autogen()
            dgv()
            btn_save.Enabled = True
            btn_delete.Enabled = False
            btn_update.Enabled = False
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
        
    End Sub
    Private Sub dgv()
        Try
            dgvData.Rows.Clear()
            Dim b As Int64
            Dim a As String
            openconnection()
            str = "select * from tbl_addgroup"
            cmd = New SqlCommand(str, cn)
            dr = cmd.ExecuteReader
            While dr.Read
                a = dr.GetString("0")
                b = dr.GetInt64("1")
                dgvData.Rows.Add(a, b)
            End While
            dr.Close()
            With dgvData
                .AlternatingRowsDefaultCellStyle.BackColor = Color.AliceBlue
                ' Adjust Header Styles
                With .ColumnHeadersDefaultCellStyle
                    .BackColor = Color.Navy
                    .ForeColor = Color.Black ' Color.White
                    .Font = New Font("Tahoma", 9, FontStyle.Bold)
                End With
            End With
            closeconnection()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub dgvData_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvData.CellMouseClick
        Try
            Dim iRow As Integer
            iRow = dgvData.CurrentRow.Index
            TextBox1.Text = "" & dgvData.Item(0, iRow).Value
            TextBox2.Text = "" & dgvData.Item(1, iRow).Value
            btn_delete.Enabled = True
            btn_update.Enabled = True
            btn_save.Enabled = False
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
        
    End Sub

    Private Sub btn_refresh_Click(sender As Object, e As EventArgs) Handles btn_refresh.Click
        Try
            autogen()
            dgv()
            btn_save.Enabled = True
            btn_delete.Enabled = False
            btn_update.Enabled = False
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub
End Class