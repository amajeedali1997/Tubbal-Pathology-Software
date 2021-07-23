Imports System.Data.SqlClient
Public Class frm_allreport
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
            Dim sda As New SqlDataAdapter("SELECT tbl_addpatient.date as t1date, tbl_addpatient.opd as t1opd, tbl_addpatient.refby as t1refby, tbl_addpatient.patientname as t1patientname, tbl_addpatient.address  as t1address, tbl_addpatient.city  as t1city, tbl_addpatient.contact  as t1contact, tbl_patienttest.testname  as t2testname, tbl_patienttest.category  as t2category, tbl_patienttest.unit  as t2unit, tbl_patienttest.cost  as t2cost,tbl_patienttest.result  as t2result, tbl_patienttest.opd  as t2opd FROM tbl_addpatient INNER JOIN tbl_patienttest ON tbl_addpatient.opd = tbl_patienttest.opd  where  tbl_addpatient.date BETWEEN '" & fdate & "' AND '" & tdate & "'", cn)
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
                dgvData.Rows(n).Cells(9).Value = item("t1address").ToString()
                dgvData.Rows(n).Cells(10).Value = item("t1city").ToString()
                dgvData.Rows(n).Cells(11).Value = item("t1contact").ToString()
                ' Next
            Next
            closeconnection()
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            ' MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        '-----------------------------------------------------------------------
        Try
            Dim name As String
            Dim fdate As String
            fdate = Format(dtpDateFrom.Value, "dd/MM/yyyy")

            Dim tdate As String
            tdate = Format(dtpDateTo.Value, "dd/MM/yyyy")
            ComboBox2.Refresh()
            ComboBox2.Items.Clear()
            openconnection()
            str = "select * from tbl_addpatient where date BETWEEN '" & fdate & "' AND '" & tdate & "'"
            cmd = New SqlCommand(str, cn)
            dr = cmd.ExecuteReader
            While dr.Read
                name = dr.GetString("4").ToString
                ComboBox2.Items.Add(name)
            End While
            dr.Close()
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try

        Try
            Dim nam As String
            Dim fdate As String
            fdate = Format(dtpDateFrom.Value, "dd/MM/yyyy")

            Dim tdate As String
            tdate = Format(dtpDateTo.Value, "dd/MM/yyyy")
            ComboBox3.Refresh()
            ComboBox3.Items.Clear()
            openconnection()
            str = "select * from tbl_addpatient where date BETWEEN '" & fdate & "' AND '" & tdate & "'"
            cmd = New SqlCommand(str, cn)
            dr = cmd.ExecuteReader
            While dr.Read
                nam = dr.GetString("2").ToString
                ComboBox3.Items.Add(nam)
            End While
            dr.Close()
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try

        '-----------------------
        TextBox1.Text = total()
        '-----------------------
    End Sub
    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged
        patientsearch()
    End Sub
    Sub patientsearch()
        Try
            Dim fdate As String
            fdate = Format(dtpDateFrom.Value, "dd/MM/yyyy")

            Dim tdate As String
            tdate = Format(dtpDateTo.Value, "dd/MM/yyyy")

            dgvData.Rows.Clear()
            openconnection()
            Dim sda As New SqlDataAdapter("SELECT tbl_addpatient.date as t1date, tbl_addpatient.opd as t1opd, tbl_addpatient.refby as t1refby, tbl_addpatient.patientname as t1patientname, tbl_addpatient.address  as t1address, tbl_addpatient.city  as t1city, tbl_addpatient.contact  as t1contact, tbl_patienttest.testname  as t2testname, tbl_patienttest.category  as t2category, tbl_patienttest.unit  as t2unit, tbl_patienttest.cost  as t2cost,tbl_patienttest.result  as t2result, tbl_patienttest.opd  as t2opd FROM tbl_addpatient INNER JOIN tbl_patienttest ON tbl_addpatient.opd = tbl_patienttest.opd  where tbl_addpatient.patientname ='" & ComboBox2.Text & "' AND tbl_addpatient.date BETWEEN '" & fdate & "' AND '" & tdate & "'", cn)
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
                dgvData.Rows(n).Cells(9).Value = item("t1address").ToString()
                dgvData.Rows(n).Cells(10).Value = item("t1city").ToString()
                dgvData.Rows(n).Cells(11).Value = item("t1contact").ToString()
                ' Next
            Next
            closeconnection()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

        '-----------------------
        TextBox1.Text = total()
        '-----------------------

    End Sub
    Sub docsearch()
        Try
            Dim fdate As String
            fdate = Format(dtpDateFrom.Value, "dd/MM/yyyy")

            Dim tdate As String
            tdate = Format(dtpDateTo.Value, "dd/MM/yyyy")

            dgvData.Rows.Clear()
            openconnection()
            Dim sda As New SqlDataAdapter("SELECT tbl_addpatient.date as t1date, tbl_addpatient.opd as t1opd, tbl_addpatient.refby as t1refby, tbl_addpatient.patientname as t1patientname, tbl_addpatient.address  as t1address, tbl_addpatient.city  as t1city, tbl_addpatient.contact  as t1contact, tbl_patienttest.testname  as t2testname, tbl_patienttest.category  as t2category, tbl_patienttest.unit  as t2unit, tbl_patienttest.cost  as t2cost,tbl_patienttest.result  as t2result, tbl_patienttest.opd  as t2opd FROM tbl_addpatient INNER JOIN tbl_patienttest ON tbl_addpatient.opd = tbl_patienttest.opd  where tbl_addpatient.refby ='" & ComboBox3.Text & "' AND tbl_addpatient.date BETWEEN '" & fdate & "' AND '" & tdate & "'", cn)
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
                dgvData.Rows(n).Cells(9).Value = item("t1address").ToString()
                dgvData.Rows(n).Cells(10).Value = item("t1city").ToString()
                dgvData.Rows(n).Cells(11).Value = item("t1contact").ToString()
                ' Next
            Next
            closeconnection()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

        Try
            Dim cm As String

        Catch ex As Exception

        End Try
        '-----------------------
        TextBox1.Text = total()
        '-----------------------

    End Sub

    Private Sub ComboBox3_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox3.SelectedIndexChanged
        docsearch()
    End Sub
End Class