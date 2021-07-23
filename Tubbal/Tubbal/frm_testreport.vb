Imports System.Data.SqlClient
Public Class frm_testreport
    Dim cmd, cmt As New SqlCommand
    Dim dr As SqlDataReader
    Dim str, st, rt As String
    Dim da As New SqlDataAdapter

    Private Sub TextBox1_Click(sender As Object, e As EventArgs) Handles TextBox1.Click
        TextBox1.SelectAll()
    End Sub
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub
    Private Sub TextBox1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBox1.KeyDown
        If e.KeyCode = Keys.Enter Then
            Try
                openconnection()
                str = "SELECT * FROM tbl_addpatient WHERE status=" & 0 & " AND opd=" & TextBox1.Text & " "
                cmd = New SqlCommand(str, cn)
                dr = cmd.ExecuteReader
                While dr.Read
                    DTP1.Value = dr.GetString("0")
                    TextBox2.Text = dr.GetString("4")
                    TextBox3.Text = dr.GetInt32("5").ToString
                    ComboBox1.Text = dr.GetString("6")
                    ComboBox2.Text = dr.GetString("2")
                    ComboBox3.Text = dr.GetString("3")
                    TextBox4.Text = dr.GetString("7")
                    TextBox5.Text = dr.GetString("8")
                    TextBox6.Text = dr.GetString("9")
                    lbl_totalcost.Text = dr.GetDecimal("11").ToString("0.00")
                    txt_discount.Text = dr.GetDecimal("12").ToString("0.00")
                    lbl_advance.Text = dr.GetDecimal("13").ToString("0.00")
                    lbl_netamt.Text = dr.GetDecimal("14").ToString("0.00")
                End While
                dr.Close()
                closeconnection()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
            '-------------------------------------------------------------------------------------------
            '-------------------------------------------------------------------------------------------
            Try
                dgvData.Rows.Clear()
                Dim sda As New SqlDataAdapter("select * from tbl_patienttest where opd =" & TextBox1.Text & "", cn)
                Dim dt As New DataTable
                sda.Fill(dt)
                For Each item As DataRow In dt.Rows
                    Dim n As Integer = dgvData.Rows.Add()
                    dgvData.Rows(n).Cells(1).Value = item("category").ToString()
                    dgvData.Rows(n).Cells(2).Value = item("testname").ToString()
                    dgvData.Rows(n).Cells(4).Value = item("unit").ToString()
                    dgvData.Rows(n).Cells(5).Value = item("normalrange").ToString()
                    dgvData.Rows(n).Cells(7).Value = item("cost").ToString()
                    dgvData.Rows(n).Cells(3).Value = item("result").ToString()
                    dgvData.Rows(n).Cells(6).Value = item("notes").ToString()
                    dgvData.Rows(n).Cells(8).Value = item("sno").ToString()
                Next
                dgvData.Columns(8).Visible = False
                closeconnection()
                secure()
            Catch ex As Exception

            End Try
        End If
    End Sub

    Private Sub dgvData_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvData.CellContentClick

    End Sub

    Private Sub dgvData_RowPostPaint(sender As Object, e As DataGridViewRowPostPaintEventArgs) Handles dgvData.RowPostPaint
        dgvData.Rows(e.RowIndex).Cells(0).Value = (e.RowIndex + 1).ToString()
    End Sub

    Private Sub txt_receivedamt_Click(sender As Object, e As EventArgs) Handles txt_receivedamt.Click
        txt_receivedamt.SelectAll()
    End Sub

    Private Sub txt_receivedamt_TextChanged(sender As Object, e As EventArgs) Handles txt_receivedamt.TextChanged
        txt_balamt.Text = Val(lbl_netamt.Text) - Val(txt_receivedamt.Text)
    End Sub

    Private Sub frm_testreport_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If TextBox1.Text = "" Then
            TextBox1.Focus()
        Else
            btn_search_Click(btn_search, New EventArgs)
        End If
        secure()

    End Sub

    Private Sub btn_cancel_Click(sender As Object, e As EventArgs) Handles btn_cancel.Click
        clear()
    End Sub

    Private Sub btn_save_Click(sender As Object, e As EventArgs) Handles btn_save.Click
        Try
            For i As Integer = 0 To dgvData.Rows.Count - 1
                str = " UPDATE tbl_patienttest SET result = '" + dgvData.Rows(i).Cells(3).Value & "', notes = '" + dgvData.Rows(i).Cells(6).Value & "' WHERE sno = '" + dgvData.Rows(i).Cells(8).Value & "'"
                cmd = New SqlCommand(str, cn)
                openconnection()
                da.InsertCommand = cmd
                da.InsertCommand.ExecuteNonQuery()
            Next
            closeconnection()
            '------------------------------------------------------------------------------------------------------
            Dim r As Integer
            If chk_paid.Checked = True Then
                r = 1
            Else
                r = 0
            End If
            st = "UPDATE tbl_addpatient set status=" & 1 & ",paidstatus=" & r & " where opd=" & TextBox1.Text & ""
            cmd = New SqlCommand(st, cn)
            openconnection()
            da.UpdateCommand = cmd
            da.UpdateCommand.ExecuteNonQuery()
            MessageBox.Show("Report Saved Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            closeconnection()
            '-------------------------------------------------------------------------------------------------------------------
            If MessageBox.Show("Do you want to take a Print?", "Print Document", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                If r = 1 Then
                    print()
                Else
                    MessageBox.Show("Patient not paid the full Amount, Kindly Pay before take a Print", "Not Paid")
                End If
            Else
                'Do nothing
            End If
            clear()
            frm_pendreport.btn_search.PerformClick()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error")
        End Try
    End Sub
    Sub clear()
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        ComboBox1.Text = ""
        ComboBox2.Text = ""
        ComboBox3.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""
        TextBox6.Text = ""
        txt_balamt.Text = "0.00"
        txt_discount.Text = "0.00"
        txt_receivedamt.Text = "0.00"
        lbl_advance.Text = "0.00"
        lbl_netamt.Text = "0.00"
        lbl_totalcost.Text = "0.00"
        dgvData.Rows.Clear()
        chk_paid.Checked = False
        txt_id.Text = ""
    End Sub
    Sub print()
        Try
            openconnection()
            Cursor = Cursors.WaitCursor
            Dim rept As New Report1  'The report you created.
            Dim cmd, cmd1 As New SqlCommand()
            Dim DA, DA1 As New SqlDataAdapter()
            Dim DS As New DataSet 'The DataSet you created.
            cmd.Connection = cn
            cmd1.Connection = cn
            cmd.CommandText = "SELECT tbl_addpatient.date, tbl_addpatient.opd, tbl_addpatient.refby, tbl_addpatient.patientname, tbl_addpatient.age, tbl_addpatient.gender,  tbl_patienttest.testname, tbl_patienttest.category, tbl_patienttest.unit, tbl_patienttest.normalrange,tbl_patienttest.result,tbl_patienttest.notes, tbl_patienttest.opd FROM tbl_addpatient INNER JOIN tbl_patienttest ON tbl_addpatient.opd = tbl_patienttest.opd  where tbl_patienttest.opd = " & TextBox1.Text & ""
            cmd1.CommandText = "SELECT * from tbl_company"
            cmd.CommandType = CommandType.Text
            cmd1.CommandType = CommandType.Text
            DA.SelectCommand = cmd
            DA1.SelectCommand = cmd1
            DA.Fill(DS, "tbl_addpatient")
            DA.Fill(DS, "tbl_patienttest")
            DA1.Fill(DS, "tbl_company")
            rept.SetDataSource(DS)
            frm_CrystalResult.CR_RPT_VIEW.ReportSource = rept
            frm_CrystalResult.ShowDialog()
            closeconnection()
        Catch ex As Exception
            MessageBox.Show(ex.ToString) 'ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error
        End Try
        clear()

    End Sub

    Private Sub btn_reprint_Click(sender As Object, e As EventArgs) Handles btn_reprint.Click
        Dim id As String = InputBox("Enter the OPD No for Reprint")
        txt_id.Text = id
        If id = "" Then
            Exit Sub
        Else
            If MessageBox.Show("Are you sure want to Reprint", "Confirm Reprint", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                Try
                    openconnection()
                    Dim cmt As New SqlCommand("Select * from tbl_addpatient where opd=@opd and paidstatus=@statu", cn)

                    cmt.Parameters.AddWithValue("@opd", id)
                    cmt.Parameters.AddWithValue("@statu", 1)

                    Dim dap As New SqlDataAdapter(cmt)
                    Dim table As New DataTable()
                    dap.Fill(table)
                    If table.Rows.Count() <= 0 Then
                        MessageBox.Show("Patient not paid the full Amount, Kindly Pay before take a Print", "Not Paid", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                    Else
                        Cursor = Cursors.WaitCursor
                        Dim rept As New Report1  'The report you created.
                        Dim cmd, cmd1 As New SqlCommand()
                        Dim DA, DA1 As New SqlDataAdapter()
                        Dim DS As New DataSet 'The DataSet you created.
                        cmd.Connection = cn
                        cmd1.Connection = cn
                        cmd.CommandText = "SELECT tbl_addpatient.date, tbl_addpatient.opd, tbl_addpatient.refby, tbl_addpatient.patientname, tbl_addpatient.age, tbl_addpatient.gender,  tbl_patienttest.testname, tbl_patienttest.category, tbl_patienttest.unit, tbl_patienttest.normalrange,tbl_patienttest.result,tbl_patienttest.notes, tbl_patienttest.opd FROM tbl_addpatient INNER JOIN tbl_patienttest ON tbl_addpatient.opd = tbl_patienttest.opd  where tbl_patienttest.opd = " & id & ""
                        cmd1.CommandText = "SELECT * from tbl_company"
                        cmd.CommandType = CommandType.Text
                        cmd1.CommandType = CommandType.Text
                        DA.SelectCommand = cmd
                        DA1.SelectCommand = cmd1
                        DA.Fill(DS, "tbl_addpatient")
                        DA.Fill(DS, "tbl_patienttest")
                        DA1.Fill(DS, "tbl_company")
                        rept.SetDataSource(DS)
                        frm_CrystalResult.CR_RPT_VIEW.ReportSource = rept
                        frm_CrystalResult.ShowDialog()
                        closeconnection()
                    End If
                Catch ex As Exception
                    MessageBox.Show(ex.ToString) 'ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error
                End Try
            End If
            clear()
        End If
    End Sub

    Private Sub btn_delete_Click(sender As Object, e As EventArgs) Handles btn_delete.Click
        Try
            Dim id As String = InputBox("Enter the OPD No to Delete")
            If id = "" Then
                Exit Sub
            Else
                If MessageBox.Show("Are you sure want to delete", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                    str = "delete from tbl_addpatient where opd=" & id & ""
                    cmd = New SqlCommand(str, cn)
                    openconnection()
                    da.DeleteCommand = cmd
                    da.DeleteCommand.ExecuteNonQuery()
                    closeconnection()
                    '-------------------------------------
                    str = "delete from tbl_patienttest where opd=" & id & ""
                    cmd = New SqlCommand(str, cn)
                    openconnection()
                    da.DeleteCommand = cmd
                    da.DeleteCommand.ExecuteNonQuery()
                    closeconnection()
                    '--------------------------------------------------
                    MessageBox.Show("Record Deleted Successfully", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
                clear()
            End If

        Catch ex As Exception
            clear()
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub btn_search_Click(sender As Object, e As EventArgs) Handles btn_search.Click
        Try
            openconnection()
            str = "SELECT * FROM tbl_addpatient WHERE opd=" & TextBox1.Text & " "
            cmd = New SqlCommand(str, cn)
            dr = cmd.ExecuteReader
            While dr.Read
                DTP1.Value = dr.GetString("0")
                TextBox2.Text = dr.GetString("4")
                TextBox3.Text = dr.GetInt32("5").ToString
                ComboBox1.Text = dr.GetString("6")
                ComboBox2.Text = dr.GetString("2")
                ComboBox3.Text = dr.GetString("3")
                TextBox4.Text = dr.GetString("7")
                TextBox5.Text = dr.GetString("8")
                TextBox6.Text = dr.GetString("9")
                lbl_totalcost.Text = dr.GetDecimal("11").ToString("0.00")
                txt_discount.Text = dr.GetDecimal("12").ToString("0.00")
                lbl_advance.Text = dr.GetDecimal("13").ToString("0.00")
                lbl_netamt.Text = dr.GetDecimal("14").ToString("0.00")

            End While
            dr.Close()
            closeconnection()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        '-------------------------------------------------------------------------------------------
        '-------------------------------------------------------------------------------------------
        Try
            dgvData.Rows.Clear()
            Dim sda As New SqlDataAdapter("select * from tbl_patienttest where opd =" & TextBox1.Text & "", cn)
            Dim dt As New DataTable
            sda.Fill(dt)
            For Each item As DataRow In dt.Rows
                Dim n As Integer = dgvData.Rows.Add()
                dgvData.Rows(n).Cells(1).Value = item("category").ToString()
                dgvData.Rows(n).Cells(2).Value = item("testname").ToString()
                dgvData.Rows(n).Cells(4).Value = item("unit").ToString()
                dgvData.Rows(n).Cells(5).Value = item("normalrange").ToString()
                dgvData.Rows(n).Cells(7).Value = item("cost").ToString()
                dgvData.Rows(n).Cells(3).Value = item("result").ToString()
                dgvData.Rows(n).Cells(6).Value = item("notes").ToString()
                dgvData.Rows(n).Cells(8).Value = item("sno").ToString()
            Next
            dgvData.Columns(8).Visible = False
            closeconnection()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        secure()
    End Sub
    Sub secure()
        dgvData.Columns(0).ReadOnly = True
        dgvData.Columns(1).ReadOnly = True
        dgvData.Columns(2).ReadOnly = True
        dgvData.Columns(3).ReadOnly = False
        dgvData.Columns(4).ReadOnly = True
        dgvData.Columns(5).ReadOnly = True
        dgvData.Columns(6).ReadOnly = False
        dgvData.Columns(7).ReadOnly = True
    End Sub

    Private Sub btn_update_Click(sender As Object, e As EventArgs) Handles btn_update.Click
        Dim op As String = InputBox("Enter the OPD No to Search")
        If op = "" Then
            Exit Sub
        Else
            Try
                openconnection()
                str = "SELECT * FROM tbl_addpatient WHERE opd=" & op & " "
                cmd = New SqlCommand(str, cn)
                dr = cmd.ExecuteReader
                While dr.Read
                    DTP1.Value = dr.GetString("0")
                    TextBox1.Text = dr.GetInt64("1").ToString
                    TextBox2.Text = dr.GetString("4")
                    TextBox3.Text = dr.GetInt32("5").ToString
                    ComboBox1.Text = dr.GetString("6")
                    ComboBox2.Text = dr.GetString("2")
                    ComboBox3.Text = dr.GetString("3")
                    TextBox4.Text = dr.GetString("7")
                    TextBox5.Text = dr.GetString("8")
                    TextBox6.Text = dr.GetString("9")
                    lbl_totalcost.Text = dr.GetDecimal("11").ToString("0.00")
                    txt_discount.Text = dr.GetDecimal("12").ToString("0.00")
                    lbl_advance.Text = dr.GetDecimal("13").ToString("0.00")
                    lbl_netamt.Text = dr.GetDecimal("14").ToString("0.00")
                    rt = dr.GetInt32("16").ToString
                End While
                dr.Close()
                If rt = 1 Then
                    chk_paid.Checked = True
                Else
                    chk_paid.Checked = False
                End If
                closeconnection()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
            '-------------------------------------------------------------------------------------------
            '-------------------------------------------------------------------------------------------
            Try
                dgvData.Rows.Clear()
                Dim sda As New SqlDataAdapter("select * from tbl_patienttest where opd =" & op & "", cn)
                Dim dt As New DataTable
                sda.Fill(dt)
                For Each item As DataRow In dt.Rows
                    Dim n As Integer = dgvData.Rows.Add()
                    dgvData.Rows(n).Cells(1).Value = item("category").ToString()
                    dgvData.Rows(n).Cells(2).Value = item("testname").ToString()
                    dgvData.Rows(n).Cells(4).Value = item("unit").ToString()
                    dgvData.Rows(n).Cells(5).Value = item("normalrange").ToString()
                    dgvData.Rows(n).Cells(7).Value = item("cost").ToString()
                    dgvData.Rows(n).Cells(3).Value = item("result").ToString()
                    dgvData.Rows(n).Cells(6).Value = item("notes").ToString()
                    dgvData.Rows(n).Cells(8).Value = item("sno").ToString()
                Next
                dgvData.Columns(8).Visible = False
                closeconnection()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
            secure()
        End If
    End Sub

    Private Sub btn_clr_Click(sender As Object, e As EventArgs) Handles btn_clr.Click
        clear()
    End Sub
End Class