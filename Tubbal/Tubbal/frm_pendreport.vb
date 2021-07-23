Imports System.Data.SqlClient

Public Class frm_pendreport
    Dim cmd As New SqlCommand
    Dim dr As SqlDataReader
    Dim str As String
    Dim iRow As Integer


    Private Sub btn_ok_Click(sender As Object, e As EventArgs) Handles btn_ok.Click
        Try
            Dim fdate As String
            fdate = Format(dtpDateFrom.Value, "dd/MM/yyyy")

            Dim tdate As String
            tdate = Format(dtpDateTo.Value, "dd/MM/yyyy")

            dgvData.Rows.Clear()
            Dim b As Integer
            Dim a, c, d, f, g, h, i, j As String
            openconnection()
            str = "SELECT * FROM tbl_addpatient WHERE status=" & 0 & " AND date BETWEEN '" & fdate & "' AND '" & tdate & "' "
            cmd = New SqlCommand(str, cn)
            dr = cmd.ExecuteReader
            While dr.Read
                b = dr.GetInt64("1")
                c = dr.GetString("4")
                d = dr.GetInt32("5")
                a = dr.GetString("6")
                f = dr.GetString("2")
                g = dr.GetString("7")
                h = dr.GetString("8")
                i = dr.GetString("9")
                j = "Take Test"
                dgvData.Rows.Add(b, c, d, a, f, g, h, i, j)
            End While
            dr.Close()
            With dgvData
                '    .AlternatingRowsDefaultCellStyle.BackColor = Color.White
                ' Adjust Header Styles
                With .ColumnHeadersDefaultCellStyle
                    .BackColor = Color.Navy
                    .ForeColor = Color.Black ' Color.White
                    .Font = New Font("Tahoma", 9, FontStyle.Bold)
                End With
            End With
            closeconnection()
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            ' MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub frm_pendreport_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    

    Private Sub btn_search_Click(sender As Object, e As EventArgs) Handles btn_search.Click
        Try
            Dim fdate As String
            fdate = Format(dtpDateFrom.Value, "dd/MM/yyyy")

            Dim tdate As String
            tdate = Format(dtpDateTo.Value, "dd/MM/yyyy")

            dgvData.Rows.Clear()
            Dim b As Integer
            Dim a, c, d, f, g, h, i, j As String
            openconnection()
            str = "SELECT * FROM tbl_addpatient WHERE status=" & 0 & " AND date BETWEEN '" & fdate & "' AND '" & tdate & "' "
            cmd = New SqlCommand(str, cn)
            dr = cmd.ExecuteReader
            While dr.Read
                b = dr.GetInt64("1")
                c = dr.GetString("4")
                d = dr.GetInt32("5")
                a = dr.GetString("6")
                f = dr.GetString("2")
                g = dr.GetString("7")
                h = dr.GetString("8")
                i = dr.GetString("9")
                j = "Take Test"
                dgvData.Rows.Add(b, c, d, a, f, g, h, i, j)
            End While
            dr.Close()
            With dgvData
                '.AlternatingRowsDefaultCellStyle.BackColor = Color.White
                ' Adjust Header Styles
                With .ColumnHeadersDefaultCellStyle
                    .BackColor = Color.Navy
                    .ForeColor = Color.Black ' Color.White
                    .Font = New Font("Tahoma", 9, FontStyle.Bold)
                End With
            End With
            closeconnection()
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            ' MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        TextBox2.Text = ""
        TextBox4.Text = ""
        If TextBox1.Text = "" Then
            Exit Sub
        Else
            Try
                Dim fdate As String
                fdate = Format(dtpDateFrom.Value, "dd/MM/yyyy")

                Dim tdate As String
                tdate = Format(dtpDateTo.Value, "dd/MM/yyyy")

                dgvData.Rows.Clear()
                Dim b As Integer
                Dim a, c, d, f, g, h, i, j As String
                openconnection()
                'status=" & 0 & " AND
                str = "SELECT * FROM tbl_addpatient WHERE  opd=" & TextBox1.Text & " AND date BETWEEN '" & fdate & "' AND '" & tdate & "' "
                cmd = New SqlCommand(str, cn)
                dr = cmd.ExecuteReader
                While dr.Read
                    b = dr.GetInt64("1")
                    c = dr.GetString("4")
                    d = dr.GetInt32("5")
                    a = dr.GetString("6")
                    f = dr.GetString("2")
                    g = dr.GetString("7")
                    h = dr.GetString("8")
                    i = dr.GetString("9")
                    j = "Take Test"
                    dgvData.Rows.Add(b, c, d, a, f, g, h, i, j)
                End While
                dr.Close()
                With dgvData
                    '.AlternatingRowsDefaultCellStyle.BackColor = Color.White
                    ' Adjust Header Styles
                    With .ColumnHeadersDefaultCellStyle
                        .BackColor = Color.Navy
                        .ForeColor = Color.Black ' Color.White
                        .Font = New Font("Tahoma", 9, FontStyle.Bold)
                    End With
                End With
                closeconnection()
            Catch ex As Exception
                MessageBox.Show("No Pending Record Found for the Given OPD", "Record Not Found")
                ' MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
        
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged
        TextBox1.Text = ""
        TextBox4.Text = ""
        If TextBox2.Text = "" Then
            Exit Sub
        Else
            Try
                Dim fdate As String
                fdate = Format(dtpDateFrom.Value, "dd/MM/yyyy")

                Dim tdate As String
                tdate = Format(dtpDateTo.Value, "dd/MM/yyyy")

                dgvData.Rows.Clear()
                Dim b As Integer
                Dim a, c, d, f, g, h, i, j As String
                openconnection()
                str = "SELECT * FROM tbl_addpatient WHERE status=" & 0 & " AND patientname='" & TextBox2.Text & "' AND date BETWEEN '" & fdate & "' AND '" & tdate & "' "
                cmd = New SqlCommand(str, cn)
                ' cmd.Parameters.Add("@d1", SqlDbType.VarChar).Value = dtpDateFrom.Value
                ' cmd.Parameters.Add("@d2", SqlDbType.VarChar).Value = dtpDateTo.Value
                ' cmd.Parameters.Add("@d3", SqlDbType.Int).Value = 1
                dr = cmd.ExecuteReader
                While dr.Read
                    ' a = dr.GetString("0")
                    b = dr.GetInt64("1")
                    c = dr.GetString("4")
                    d = dr.GetInt32("5")
                    a = dr.GetString("6")
                    f = dr.GetString("2")
                    g = dr.GetString("7")
                    h = dr.GetString("8")
                    i = dr.GetString("9")
                    j = "Take Test"
                    dgvData.Rows.Add(b, c, d, a, f, g, h, i, j)
                End While
                dr.Close()
                With dgvData
                    '.AlternatingRowsDefaultCellStyle.BackColor = Color.White
                    ' Adjust Header Styles
                    With .ColumnHeadersDefaultCellStyle
                        .BackColor = Color.Navy
                        .ForeColor = Color.Black ' Color.White
                        .Font = New Font("Tahoma", 9, FontStyle.Bold)
                    End With
                End With
                closeconnection()
            Catch ex As Exception
                MessageBox.Show("No Pending Record Found for the Given Patient Name", "Record Not Found")
                ' MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

   
    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles TextBox4.TextChanged
        TextBox1.Text = ""
        TextBox2.Text = ""
        If TextBox2.Text = "" Then
            Exit Sub
        Else
            Try
                Dim fdate As String
                fdate = Format(dtpDateFrom.Value, "dd/MM/yyyy")

                Dim tdate As String
                tdate = Format(dtpDateTo.Value, "dd/MM/yyyy")

                dgvData.Rows.Clear()
                Dim b As Integer
                Dim a, c, d, f, g, h, i, j As String
                openconnection()
                str = "SELECT * FROM tbl_addpatient WHERE status=" & 0 & " AND contact like '%" & TextBox4.Text & "%' AND date BETWEEN '" & fdate & "' AND '" & tdate & "' "
                cmd = New SqlCommand(str, cn)
                ' cmd.Parameters.Add("@d1", SqlDbType.VarChar).Value = dtpDateFrom.Value
                ' cmd.Parameters.Add("@d2", SqlDbType.VarChar).Value = dtpDateTo.Value
                ' cmd.Parameters.Add("@d3", SqlDbType.Int).Value = 1
                dr = cmd.ExecuteReader
                While dr.Read
                    ' a = dr.GetString("0")
                    b = dr.GetInt64("1")
                    c = dr.GetString("4")
                    d = dr.GetInt32("5")
                    a = dr.GetString("6")
                    f = dr.GetString("2")
                    g = dr.GetString("7")
                    h = dr.GetString("8")
                    i = dr.GetString("9")
                    j = "Take Test"
                    dgvData.Rows.Add(b, c, d, a, f, g, h, i, j)
                End While
                dr.Close()
                With dgvData
                    '.AlternatingRowsDefaultCellStyle.BackColor = Color.White
                    ' Adjust Header Styles
                    With .ColumnHeadersDefaultCellStyle
                        .BackColor = Color.Navy
                        .ForeColor = Color.Black ' Color.White
                        .Font = New Font("Tahoma", 9, FontStyle.Bold)
                    End With
                End With
                closeconnection()
            Catch ex As Exception
                MessageBox.Show("No Pending Record Found for the Given Contact", "Record Not Found")
                ' MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub dgvData_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvData.CellContentClick
        If e.ColumnIndex <> 8 Then
            Exit Sub
        End If
        frm_testreport.Close()
        frm_testreport.TextBox1.Text = dgvData.Rows(e.RowIndex).Cells(0).Value
        frm_testreport.btn_search.PerformClick()
        Try
            frm_testreport.TopLevel = False
            frm_testreport.TopMost = True
            frm_main.pnl_container.Controls.Clear()
            frm_main.pnl_container.Controls.Add(frm_testreport)
            frm_testreport.Show()
        Catch ex As Exception
            MessageBox.Show("Form is Already in Open, Try to Open Another Form")
        End Try
    End Sub
End Class