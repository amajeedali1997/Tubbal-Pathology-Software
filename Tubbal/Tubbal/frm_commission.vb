Imports System.Data.SqlClient
Public Class frm_commission
    Dim cmd As New SqlCommand
    Dim dr As SqlDataReader
    Dim str As String
    Dim iRow As Integer
    Function total()
        Dim sum As Integer = 0
        For i As Integer = 0 To dgvData.Rows.Count - 1
            sum += Convert.ToInt64(dgvData.Rows(i).Cells(7).Value)
        Next
        Return sum.ToString("0.00")
    End Function
    Function comm()
        Dim cm As Integer = 0
        cm = lbl_totalcost.Text * Val(TextBox1.Text) / 100
        Return cm.ToString("0.00")
    End Function

    Private Sub frm_commission_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            ComboBox2.Refresh()
            ComboBox2.Items.Clear()
            openconnection()
            str = "select * from tbl_doctor"
            cmd = New SqlCommand(str, cn)
            dr = cmd.ExecuteReader
            While dr.Read
                Name = dr.GetString("1").ToString
                ComboBox2.Items.Add(Name)
            End While
            dr.Close()
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub btn_ok_Click(sender As Object, e As EventArgs) Handles btn_ok.Click
        loadall()
    End Sub
    Sub loadall()
        Try
            Dim fdate As String
            fdate = Format(dtpDateFrom.Value, "dd/MM/yyyy")

            Dim tdate As String
            tdate = Format(dtpDateTo.Value, "dd/MM/yyyy")

            dgvData.Rows.Clear()
            openconnection()
            Dim sda As New SqlDataAdapter("SELECT tbl_addpatient.date as t1date, tbl_addpatient.opd as t1opd, tbl_addpatient.refby as t1refby, tbl_addpatient.patientname as t1patientname, tbl_addpatient.address  as t1address, tbl_patienttest.testname  as t2testname, tbl_patienttest.category  as t2category, tbl_patienttest.unit  as t2unit, tbl_patienttest.result  as t2result, tbl_patienttest.cost  as t2cost, tbl_patienttest.opd  as t2opd FROM tbl_addpatient INNER JOIN tbl_patienttest ON tbl_addpatient.opd = tbl_patienttest.opd  where tbl_addpatient.refby='" & ComboBox2.Text & "' AND  tbl_addpatient.date BETWEEN '" & fdate & "' AND '" & tdate & "'", cn)
            Dim dt As New DataTable
            sda.Fill(dt)
            For Each item As DataRow In dt.Rows
                ' For Each col As DataColumn In dt.Columns
                Dim n As Integer = dgvData.Rows.Add()
                dgvData.Rows(n).Cells(0).Value = item("t1date").ToString
                dgvData.Rows(n).Cells(1).Value = item("t1opd").ToString()
                dgvData.Rows(n).Cells(2).Value = item("t1patientname").ToString()
                dgvData.Rows(n).Cells(3).Value = item("t2category").ToString()
                dgvData.Rows(n).Cells(4).Value = item("t2testname").ToString()
                dgvData.Rows(n).Cells(5).Value = item("t2result").ToString()
                dgvData.Rows(n).Cells(6).Value = item("t2unit").ToString()
                dgvData.Rows(n).Cells(7).Value = item("t2cost").ToString()
                dgvData.Rows(n).Cells(8).Value = item("t1refby").ToString()
            Next
            dgvData.Columns(8).Visible = False
            closeconnection()
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            ' MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        '-----------------------------------------------------------------------
       

        '-----------------------
        lbl_totalcost.Text = total()
        lbl_comm.Text = comm()
        '-----------------------
    End Sub

    Sub clear()
        ComboBox2.Text = ""
        TextBox1.Text = ""
        lbl_comm.Text = "0.00"
        lbl_totalcost.Text = "0.00"
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged
        Try
            openconnection()
            str = "select * from tbl_doctor where docname='" & ComboBox2.Text & "'"
            cmd = New SqlCommand(str, cn)
            dr = cmd.ExecuteReader
            While dr.Read
                TextBox1.Text = dr.GetInt32("3").ToString
            End While
            dr.Close()
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    
    Private Sub btn_clear_Click(sender As Object, e As EventArgs) Handles btn_clear.Click
        clear()
        Try
            ComboBox2.Refresh()
            ComboBox2.Items.Clear()
            openconnection()
            str = "select * from tbl_doctor"
            cmd = New SqlCommand(str, cn)
            dr = cmd.ExecuteReader
            While dr.Read
                Name = dr.GetString("1").ToString
                ComboBox2.Items.Add(Name)
            End While
            dr.Close()
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub
End Class