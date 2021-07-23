Imports System.Data.SqlClient
Imports System.Text

Public Class frm_addpatient
    Dim cmd As New SqlCommand
    Dim da As New SqlDataAdapter
    Dim dr As SqlDataReader
    Dim str As String
    Dim gender As String
    Dim j As Integer = 0

    Function checkcount()
        Dim count As Integer = 0
        For i As Integer = 0 To dgvData.Rows.Count - 1
            If CBool(dgvData.Rows(i).Cells("Column1").Value) Then
                count += 1
            End If
        Next
        Return count
    End Function

    Function total()
        Dim sum As Integer = 0
        For i As Integer = 0 To dgvData.Rows.Count - 1
            If CBool(dgvData.Rows(i).Cells("Column1").Value) Then
                sum += Convert.ToInt64(dgvData.Rows(i).Cells(3).Value)
            End If
        Next
        Return sum.ToString("0.00")
    End Function
    
    
    Private Sub frm_addpatient_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        autogen()
        dgv()
        comboDoctor()
        comboGroup()
        comboAccount()
        dgvData.Sort(dgvData.Columns(2), System.ComponentModel.ListSortDirection.Ascending)
        If TextBox5.Text = "" Then
            TextBox5.Text = "0.00"
        ElseIf TextBox6.Text = "" Then
            TextBox6.Text = "0.00"
        End If
    End Sub

    Private Sub btn_addDoctor_Click(sender As Object, e As EventArgs) Handles btn_addDoctor.Click
        frm_addDoctor.Show()
    End Sub

    Private Sub btn_addgroup_Click(sender As Object, e As EventArgs) Handles btn_addgroup.Click
        frm_addtest.Show()
    End Sub
    Private Sub autogen()
        openconnection()
        Dim number As Integer
        cmd = New SqlCommand("Select Max(opd) from tbl_addpatient", cn)

        If IsDBNull(cmd.ExecuteScalar) Then
            number = 1
            TextBox1.Text = number
        Else
            number = cmd.ExecuteScalar + 1
            TextBox1.Text = number
        End If
        closeconnection()
    End Sub
    Private Sub clear()
        BTextbox1.Text = ""
        BTextbox2.Text = ""
        BTextbox4.Text = ""
        BTextbox5.Text = ""
        BTextbox6.Text = ""
        ComboBox1.Text = ""
        ComboBox2.Text = ""
        ComboBox3.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = "0.00"
        TextBox6.Text = "0.00"
        TextBox7.Text = ""
        RadioButton1.Checked = False
        RadioButton2.Checked = False
    End Sub
    Private Sub comboGroup()

        Dim name As String
        Try
            ComboBox2.Refresh()
            ComboBox2.Items.Clear()
            openconnection()
            str = "select * from tbl_addgroup"
            cmd = New SqlCommand(str, cn)
            dr = cmd.ExecuteReader
            While dr.Read
                name = dr.GetString("0")
                ComboBox2.Items.Add(name)
            End While

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        closeconnection()
    End Sub

    Private Sub comboAccount()
        ComboBox1.Items.Clear()
        ComboBox1.Items.Add("Cash")
        ComboBox1.Items.Add("Credit")
    End Sub
    Private Sub comboDoctor()

        Dim name As String
        Try
            ComboBox3.Refresh()
            ComboBox3.Items.Clear()
            openconnection()
            str = "select * from tbl_doctor"
            cmd = New SqlCommand(str, cn)
            dr = cmd.ExecuteReader
            While dr.Read
                name = dr.GetString("1")
                ComboBox3.Items.Add(name)
            End While

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

        closeconnection()
    End Sub

    Private Sub dgv()
        Try
            dgvData.Rows.Clear()
            Dim sda As New SqlDataAdapter("select * from tbl_addtest", cn)
            Dim dt As New DataTable
            sda.Fill(dt)
            For Each item As DataRow In dt.Rows
                Dim n As Integer = dgvData.Rows.Add()
                dgvData.Rows(n).Cells(1).Value = item("testname").ToString()
                dgvData.Rows(n).Cells(2).Value = item("testgroup").ToString()
                dgvData.Rows(n).Cells(3).Value = item("cost").ToString()
                dgvData.Rows(n).Cells(4).Value = item("unit").ToString()
                dgvData.Rows(n).Cells(5).Value = item("normalrange").ToString()
            Next
            dgvData.Columns(4).Visible = False
            dgvData.Columns(5).Visible = False
            closeconnection()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub dgvData_CellLeave(sender As Object, e As DataGridViewCellEventArgs) Handles dgvData.CellLeave
        'TextBox2.Text = checkcount()
        'TextBox4.Text = total()
    End Sub

    Private Sub ComboBox2_MouseClick(sender As Object, e As MouseEventArgs) Handles ComboBox2.MouseClick
        comboGroup()
        'dgv()
    End Sub

    Private Sub TextBox6_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox6.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub TextBox6_MouseClick(sender As Object, e As MouseEventArgs) Handles TextBox6.MouseClick
        TextBox6.SelectAll()
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        If RadioButton1.Checked = True Then
            'gender = "Male"
            RadioButton2.Checked = False
        End If
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        If RadioButton2.Checked = True Then
            'gender = "Male"
            RadioButton1.Checked = False
        End If
    End Sub

    Private Sub btn_refresh_Click(sender As Object, e As EventArgs) Handles btn_refresh.Click
        autogen()
        dgv()
        comboDoctor()
        comboGroup()
        comboAccount()
        dgvData.Sort(dgvData.Columns(2), System.ComponentModel.ListSortDirection.Ascending)
        btn_save.Enabled = True
    End Sub

    Private Sub btn_save_Click(sender As Object, e As EventArgs) Handles btn_save.Click
        If RadioButton1.Checked = True Then
            gender = "Male"
        End If
        If RadioButton2.Checked = True Then
            gender = "Female"
        End If

        Try
            Dim stat, pstat As Integer
            stat = 0
            pstat = 0
            openconnection()
            str = "insert into tbl_addpatient values('" & DTP1.Value.ToString("dd/MM/yyyy") & "'," & TextBox1.Text & ",'" & ComboBox3.Text & "','" & ComboBox1.Text & "','" & BTextbox6.Text & "'," & BTextbox5.Text & ",'" & gender & "','" & BTextbox4.Text & "','" & BTextbox2.Text & "','" & BTextbox1.Text & "'," & TextBox2.Text & "," & TextBox4.Text & "," & TextBox5.Text & "," & TextBox6.Text & "," & TextBox7.Text & "," & stat & "," & pstat & ")"
            cmd = New SqlCommand(str, cn)
            da.InsertCommand = cmd
            da.InsertCommand.ExecuteNonQuery()
            ' MessageBox.Show("Patient Added Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            closeconnection()
            '---------------------------------------------------------------------------------------------------------------
            For i As Integer = 0 To dgvData.Rows.Count - 1
                If CBool(dgvData.Rows(i).Cells("Column1").Value) Then
                    str = " insert into tbl_patienttest(opd,testname,category,cost,unit,normalrange) values (" & TextBox1.Text & ",'" & dgvData.Rows(i).Cells(1).Value & "','" + dgvData.Rows(i).Cells(2).Value & "','" + dgvData.Rows(i).Cells(3).Value & "','" + dgvData.Rows(i).Cells(4).Value & "','" + dgvData.Rows(i).Cells(5).Value & "') "
                    cmd = New SqlCommand(str, cn)
                    openconnection()
                    da.InsertCommand = cmd
                    da.InsertCommand.ExecuteNonQuery()
                End If
            Next
            MessageBox.Show("Patient Added Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            closeconnection()
            '-------------------------------------------------------------------------------------------------------------------
            If MessageBox.Show("Do you want to take a Print", "Print Document", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                print()
            Else
                'Do nothing
            End If
            clear()
            autogen()
            dgv()
            comboAccount()
            comboDoctor()
            comboGroup()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub
    Sub print()
        Try
            Cursor = Cursors.WaitCursor
            Dim rpt As New rpt_pinfo 'The report you created.
            Dim MyCommand, cmd1 As New SqlCommand()
            Dim myDA, DA1 As New SqlDataAdapter()
            Dim myDS As New DataSet 'The DataSet you created.
            MyCommand.Connection = cn
            cmd1.Connection = cn
            MyCommand.CommandText = "SELECT tbl_addpatient.date, tbl_addpatient.opd, tbl_addpatient.refby, tbl_addpatient.patientname, tbl_addpatient.age, tbl_addpatient.gender, tbl_addpatient.nooftest, tbl_addpatient.totalcost, tbl_addpatient.discount, tbl_addpatient.advance, tbl_addpatient.netamt, tbl_patienttest.testname, tbl_patienttest.category, tbl_patienttest.cost, tbl_patienttest.opd FROM tbl_addpatient INNER JOIN tbl_patienttest ON tbl_addpatient.opd = tbl_patienttest.opd  where tbl_addpatient.opd=" & TextBox1.Text & ""
            cmd1.CommandText = "SELECT * from tbl_company"
            MyCommand.CommandType = CommandType.Text
            cmd.CommandType = CommandType.Text
            myDA.SelectCommand = MyCommand
            DA1.SelectCommand = cmd1
            myDA.Fill(myDS, "tbl_addpatient")
            myDA.Fill(myDS, "tbl_patienttest")
            DA1.Fill(myDS, "tbl_company")
            rpt.SetDataSource(myDS)
            frm_CrystalResult.CR_RPT_VIEW.ReportSource = rpt
            frm_CrystalResult.ShowDialog()
        Catch ex As Exception
            MessageBox.Show(ex.ToString) 'ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error
        End Try
    End Sub

    Private Sub TextBox1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBox1.KeyDown
        If e.KeyCode = Keys.Enter Then
            Try
                btn_save.Enabled = False
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If
    End Sub

    Private Sub btn_update_Click(sender As Object, e As EventArgs) Handles btn_update.Click
        Dim id As String = InputBox("Enter the OPD No for Reprint")
        If id <> "" Then
            If MessageBox.Show("Are you sure want to Print the Record", "Confirm Print", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                Try
                    Cursor = Cursors.WaitCursor
                    Dim rpt As New rpt_pinfo 'The report you created.
                    Dim MyCommand, cmd1 As New SqlCommand()
                    Dim myDA, DA1 As New SqlDataAdapter()
                    Dim myDS As New DataSet 'The DataSet you created.
                    MyCommand.Connection = cn
                    cmd1.Connection = cn
                    MyCommand.CommandText = "SELECT tbl_addpatient.date, tbl_addpatient.opd, tbl_addpatient.refby, tbl_addpatient.patientname, tbl_addpatient.age, tbl_addpatient.gender, tbl_addpatient.nooftest, tbl_addpatient.totalcost, tbl_addpatient.discount, tbl_addpatient.advance, tbl_addpatient.netamt, tbl_patienttest.testname, tbl_patienttest.category, tbl_patienttest.cost, tbl_patienttest.opd FROM tbl_addpatient INNER JOIN tbl_patienttest ON tbl_addpatient.opd = tbl_patienttest.opd  where tbl_addpatient.opd=" & id & ""
                    cmd1.CommandText = "SELECT * from tbl_company"
                    MyCommand.CommandType = CommandType.Text
                    cmd.CommandType = CommandType.Text
                    myDA.SelectCommand = MyCommand
                    DA1.SelectCommand = cmd1
                    myDA.Fill(myDS, "tbl_addpatient")
                    myDA.Fill(myDS, "tbl_patienttest")
                    DA1.Fill(myDS, "tbl_company")
                    rpt.SetDataSource(myDS)
                    frm_CrystalResult.CR_RPT_VIEW.ReportSource = rpt
                    frm_CrystalResult.ShowDialog()
                Catch ex As Exception
                    MessageBox.Show(ex.ToString) 'ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error
                End Try
                btn_refresh_Click(btn_refresh, New EventArgs)
            End If
        Else
            Exit Sub

        End If
       
    End Sub

    Private Sub btn_clear_Click(sender As Object, e As EventArgs) Handles btn_clear.Click
        clear()
    End Sub

    Private Sub btn_delete_Click(sender As Object, e As EventArgs) Handles btn_delete.Click
        Try
            Dim id As String = InputBox("Enter the OPD No to Delete")
            If id <> "" Then
                If MessageBox.Show("Are you sure want to delete", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                    str = "delete from tbl_addpatient where opd=" & id & ""
                    cmd = New SqlCommand(str, cn)
                    openconnection()
                    da.InsertCommand = cmd
                    da.InsertCommand.ExecuteNonQuery()
                    closeconnection()
                    '-------------------------------------
                    str = "delete from tbl_patienttest where opd=" & id & ""
                    cmd = New SqlCommand(str, cn)
                    openconnection()
                    da.InsertCommand = cmd
                    da.InsertCommand.ExecuteNonQuery()
                    closeconnection()
                    MessageBox.Show("Record Deleted Successfully", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    btn_refresh_Click(btn_refresh, New EventArgs)
                Else
                    'Do nothing
                End If
            Else
                Exit Sub
            End If
           
            btn_refresh_Click(btn_refresh, New EventArgs)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
       
    End Sub

    Private Sub TextBox5_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox5.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub TextBox5_MouseClick(sender As Object, e As MouseEventArgs) Handles TextBox5.MouseClick
        TextBox5.SelectAll()
    End Sub


    Private Sub TextBox5_TextChanged(sender As Object, e As EventArgs) Handles TextBox5.TextChanged
        TextBox2.Text = checkcount()
        TextBox4.Text = total()
        If TextBox5.Text = "" Then
            TextBox5.Text = "0.00"
        ElseIf TextBox6.Text = "" Then
            TextBox6.Text = "0.00"
        End If
        TextBox7.Text = (Val(TextBox4.Text) - (Val(TextBox5.Text) + Val(TextBox6.Text))).ToString("0.00")
    End Sub

    Private Sub BTextbox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles BTextbox1.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub BTextbox5_KeyPress(sender As Object, e As KeyPressEventArgs) Handles BTextbox5.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub BTextbox1_Leave(sender As Object, e As EventArgs) Handles BTextbox1.Leave
        If BTextbox1.Text.Length < 10 Then
            MessageBox.Show("Mobile Number is Less than 10 Digit", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If

        If BTextbox1.Text.Length > 10 Then
            MessageBox.Show("Mobile Number is More than 10 digit", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub BTextbox5_Leave(sender As Object, e As EventArgs) Handles BTextbox5.Leave
        If BTextbox5.Text.Length > 3 Then
            MessageBox.Show("Age is More than 3 Digit is not valid", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        btn_total_Click(btn_total, New EventArgs)
    End Sub

    Private Sub TextBox6_TextChanged(sender As Object, e As EventArgs) Handles TextBox6.TextChanged
        TextBox2.Text = checkcount()
        TextBox4.Text = total()
        If TextBox5.Text = "" Then
            TextBox5.Text = "0.00"
        ElseIf TextBox6.Text = "" Then
            TextBox6.Text = "0.00"
        End If
        TextBox7.Text = (Val(TextBox4.Text) - (Val(TextBox5.Text) + Val(TextBox6.Text))).ToString("0.00")
    End Sub

    Private Sub dgvData_CellMouseUp1(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvData.CellMouseUp
        'Dim count As Integer = 0
        'Dim c As Boolean
        'For i As Integer = 0 To dgvData.Rows.Count - 1
        '    c = dgvData.Rows(i).Cells("Column1").Value
        '    If c = True Then
        '        count += 1
        '    End If
        'Next
        'TextBox2.Text = count
        'TextBox4.Text = total()
    End Sub

    Private Sub btn_total_Click(sender As Object, e As EventArgs) Handles btn_total.Click
        TextBox2.Text = checkcount()
        TextBox4.Text = total()
        If TextBox5.Text = "" Then
            TextBox5.Text = "0.00"
        ElseIf TextBox6.Text = "" Then
            TextBox6.Text = "0.00"
        End If
        TextBox7.Text = (Val(TextBox4.Text) - (Val(TextBox5.Text) + Val(TextBox6.Text))).ToString("0.00")
    End Sub

End Class