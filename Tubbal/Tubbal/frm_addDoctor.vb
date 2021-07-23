Imports System.Data.SqlClient
Public Class frm_addDoctor
    Public MoveForm As Boolean
    Public MoveForm_MousePosition As Point

    Dim cmd As New SqlCommand
    Dim da As New SqlDataAdapter
    Dim str As String
    Dim dr As SqlDataReader

    Public Sub MoveForm_MouseDown(sender As Object, e As MouseEventArgs) Handles _
    MyBase.MouseDown, Panel1.MouseDown, Label1.MouseDown, PictureBox1.MouseDown

        If e.Button = MouseButtons.Left Then
            MoveForm = True
            Me.Cursor = Cursors.NoMove2D
            MoveForm_MousePosition = e.Location
        End If

    End Sub

    Public Sub MoveForm_MouseMove(sender As Object, e As MouseEventArgs) Handles _
    MyBase.MouseMove, Panel1.MouseMove, Label1.MouseMove, PictureBox1.MouseMove

        If MoveForm Then
            Me.Location = Me.Location + (e.Location - MoveForm_MousePosition)
        End If

    End Sub

    Public Sub MoveForm_MouseUp(sender As Object, e As MouseEventArgs) Handles _
    MyBase.MouseUp, Panel1.MouseUp, Label1.MouseUp, PictureBox1.MouseUp

        If e.Button = MouseButtons.Left Then
            MoveForm = False
            Me.Cursor = Cursors.Default
        End If

    End Sub
    Private Sub BunifuImageButton1_Click(sender As Object, e As EventArgs) Handles BunifuImageButton1.Click
        Me.Close()
    End Sub

    Private Sub frm_addDoctor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        autogen()
        dgv()
        clear()
        btn_save.Enabled = True
        btn_update.Enabled = False
        btn_delete.Enabled = False
    End Sub

    Private Sub btn_save_Click(sender As Object, e As EventArgs) Handles btn_save.Click
        Try
            openconnection()
            str = "insert into tbl_doctor values(" & TextBox4.Text & ",'" & TextBox1.Text & "','" & Textbox2.Text & "'," & Textbox3.Text & ")"
            cmd = New SqlCommand(Str, cn)
            da.InsertCommand = cmd
            da.InsertCommand.ExecuteNonQuery()
            MessageBox.Show("Test Added Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            closeconnection()
            autogen()
            dgv()
            clear()
            btn_save.Enabled = True
            btn_update.Enabled = False
            btn_delete.Enabled = False
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub
    Private Sub autogen()
        openconnection()
        Dim number As Integer
        cmd = New SqlCommand("Select Max(Id) from tbl_doctor", cn)

        If IsDBNull(cmd.ExecuteScalar) Then
            number = 1
            TextBox4.Text = number
        Else
            number = cmd.ExecuteScalar + 1
            TextBox4.Text = number
        End If
        closeconnection()
    End Sub
    Private Sub clear()
        TextBox1.Text = ""
        Textbox2.Text = ""
        Textbox3.Text = ""
    End Sub

    Private Sub btn_update_Click(sender As Object, e As EventArgs) Handles btn_update.Click
        Try
            openconnection()
            str = "Update tbl_doctor SET docname='" & TextBox1.Text & "', contact='" & Textbox2.Text & "', comm=" & Textbox3.Text & " where Id=" & TextBox4.Text & ""
            cmd = New SqlCommand(str, cn)
            da.UpdateCommand = cmd
            da.UpdateCommand.ExecuteNonQuery()
            MessageBox.Show("Test Updated Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            closeconnection()
            autogen()
            dgv()
            clear()
            btn_save.Enabled = True
            btn_update.Enabled = False
            btn_delete.Enabled = False
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
                    str = "delete from tbl_doctor where Id = " & TextBox4.Text & " "
                    cmd = New SqlCommand(str, cn)
                    da.DeleteCommand = cmd
                    da.DeleteCommand.ExecuteNonQuery()
                    closeconnection()
                    autogen()
                    dgv()
                    clear()
                    btn_save.Enabled = True
                    btn_update.Enabled = False
                    btn_delete.Enabled = False
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub
    Private Sub dgv()
        Try
            dgvData.Rows.Clear()
            Dim c, d As Integer
            Dim a, b As String
            openconnection()
            str = "select * from tbl_doctor"
            cmd = New SqlCommand(str, cn)
            dr = cmd.ExecuteReader
            While dr.Read
                d = dr.GetInt32("0")
                a = dr.GetString("1")
                b = dr.GetString("2")
                c = dr.GetInt32("3")
                dgvData.Rows.Add(d, a, b, c)
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
        Dim iRow As Integer
        iRow = dgvData.CurrentRow.Index
        TextBox1.Text = "" & dgvData.Item(1, iRow).Value
        Textbox2.Text = "" & dgvData.Item(2, iRow).Value
        Textbox3.Text = "" & dgvData.Item(3, iRow).Value
        TextBox4.Text = "" & dgvData.Item(0, iRow).Value
        btn_save.Enabled = False
        btn_update.Enabled = True
        btn_delete.Enabled = True
    End Sub

    Private Sub btn_refresh_Click(sender As Object, e As EventArgs) Handles btn_refresh.Click
        autogen()
        dgv()
        clear()
        btn_save.Enabled = True
        btn_update.Enabled = False
        btn_delete.Enabled = False
    End Sub

    Private Sub Textbox2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Textbox2.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub Textbox2_Leave(sender As Object, e As EventArgs) Handles Textbox2.Leave
        If Textbox2.Text.Length < 10 Then
            MessageBox.Show("Mobile Number is Less than 10 Digit", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If

        If Textbox2.Text.Length > 10 Then
            MessageBox.Show("Mobile Number is More than 10 digit", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub Textbox3_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Textbox3.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub Textbox3_Leave(sender As Object, e As EventArgs) Handles Textbox3.Leave
        If Textbox3.Text >= 100 Then
            MessageBox.Show("Given Percentage is more than 100.So it is not valid", "Error")
            Textbox3.Text = ""
        Else
            'Textbox3.text
        End If

    End Sub
End Class