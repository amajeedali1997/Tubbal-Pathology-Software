Public Class frm_main
    Public MoveForm As Boolean
    Public MoveForm_MousePosition As Point

    Public Sub MoveForm_MouseDown(sender As Object, e As MouseEventArgs) Handles _
    MyBase.MouseDown, lbl_title.MouseDown, Panel1.MouseDown, PictureBox1.MouseDown, Label1.MouseDown

        If e.Button = MouseButtons.Left Then
            MoveForm = True
            Me.Cursor = Cursors.NoMove2D
            MoveForm_MousePosition = e.Location
        End If

    End Sub

    Public Sub MoveForm_MouseMove(sender As Object, e As MouseEventArgs) Handles _
    MyBase.MouseMove, lbl_title.MouseMove, Panel1.MouseMove, PictureBox1.MouseMove, Label1.MouseMove

        If MoveForm Then
            Me.Location = Me.Location + (e.Location - MoveForm_MousePosition)
        End If

    End Sub

    Public Sub MoveForm_MouseUp(sender As Object, e As MouseEventArgs) Handles _
    MyBase.MouseUp, lbl_title.MouseUp, Panel1.MouseUp, PictureBox1.MouseUp, Label1.MouseUp

        If e.Button = MouseButtons.Left Then
            MoveForm = False
            Me.Cursor = Cursors.Default
        End If

    End Sub

    Private Sub btn_close_Click(sender As Object, e As EventArgs) Handles btn_close.Click
        If (MessageBox.Show("Are you Sure to Log Out", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes) Then
            Me.Close()
            frm_login.Show()
        Else
            'Do Nothing
        End If
       
    End Sub

    Private Sub btn_minimize_Click(sender As Object, e As EventArgs) Handles btn_minimize.Click
        WindowState = FormWindowState.Minimized
    End Sub

    Private Sub btn_maximize_Click(sender As Object, e As EventArgs) Handles btn_maximize.Click
        If WindowState = FormWindowState.Maximized Then
            WindowState = FormWindowState.Normal
        Else
            WindowState = FormWindowState.Maximized
        End If
    End Sub

    Private Sub btn_addpatient_Click(sender As Object, e As EventArgs) Handles btn_addpatient.Click
        Try
            frm_addpatient.TopLevel = False
            frm_addpatient.TopMost = True
            Me.pnl_container.Controls.Clear()
            Me.pnl_container.Controls.Add(frm_addpatient)
            frm_addpatient.Show()
        Catch ex As Exception
            MessageBox.Show("Form is Already in Open, Try to Open Another Form")
        End Try
    End Sub

    Private Sub btn_adddoctor_Click(sender As Object, e As EventArgs) Handles btn_adddoctor.Click
        Try
            frm_addDoctor.TopLevel = False
            frm_addDoctor.TopMost = True
            Me.pnl_container.Controls.Clear()
            Me.pnl_container.Controls.Add(frm_addDoctor)
            frm_addDoctor.Show()
        Catch ex As Exception
            MessageBox.Show("Form is Already in Open, Try to Open Another Form")
        End Try
    End Sub

    Private Sub btn_report_Click(sender As Object, e As EventArgs) Handles btn_report.Click
        Try
            frm_pendreport.TopLevel = False
            frm_pendreport.TopMost = True
            Me.pnl_container.Controls.Clear()
            Me.pnl_container.Controls.Add(frm_pendreport)
            frm_pendreport.Show()
        Catch ex As Exception
            MessageBox.Show("Form is Already in Open, Try to Open Another Form")
        End Try
    End Sub

    Private Sub btn_rept_Click(sender As Object, e As EventArgs) Handles btn_rept.Click
        Try
            frm_testreport.TopLevel = False
            frm_testreport.TopMost = True
            Me.pnl_container.Controls.Clear()
            Me.pnl_container.Controls.Add(frm_testreport)
            frm_testreport.Show()
        Catch ex As Exception
            MessageBox.Show("Form is Already in Open, Try to Open Another Form")
        End Try
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lbl_time.Text = TimeOfDay.ToString("h:mm:ss tt")
    End Sub

    Private Sub frm_main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Enabled = True
        Try
            frm_dashboard.TopLevel = False
            frm_dashboard.TopMost = True
            Me.pnl_container.Controls.Clear()
            Me.pnl_container.Controls.Add(frm_dashboard)
            frm_dashboard.Show()
        Catch ex As Exception
            MessageBox.Show("Form is Already in Open, Try to Open Another Form")
        End Try
    End Sub

    Private Sub btn_allreports_Click(sender As Object, e As EventArgs) Handles btn_allreports.Click

        Try
            frm_allreport.TopLevel = False
            frm_allreport.TopMost = True
            Me.pnl_container.Controls.Clear()
            Me.pnl_container.Controls.Add(frm_allreport)
            frm_allreport.Show()
        Catch ex As Exception
            MessageBox.Show("Form is Already in Open, Try to Open Another Form")
        End Try
    End Sub

    Private Sub btn_commission_Click(sender As Object, e As EventArgs) Handles btn_commission.Click
        Try
            frm_commission.TopLevel = False
            frm_commission.TopMost = True
            Me.pnl_container.Controls.Clear()
            Me.pnl_container.Controls.Add(frm_commission)
            frm_commission.Show()
        Catch ex As Exception
            MessageBox.Show("Form is Already in Open, Try to Open Another Form")
        End Try
    End Sub

    Private Sub btn_addgroup_Click(sender As Object, e As EventArgs) Handles btn_addgroup.Click
        Try
            frm_addtestgroup.TopLevel = False
            frm_addtestgroup.TopMost = True
            Me.pnl_container.Controls.Clear()
            Me.pnl_container.Controls.Add(frm_addtestgroup)
            frm_addtestgroup.Show()
        Catch ex As Exception
            MessageBox.Show("Form is Already in Open, Try to Open Another Form")
        End Try
    End Sub

    Private Sub btn_addtest_Click(sender As Object, e As EventArgs) Handles btn_addtest.Click
        Try
            frm_addtest.TopLevel = False
            frm_addtest.TopMost = True
            Me.pnl_container.Controls.Clear()
            Me.pnl_container.Controls.Add(frm_addtest)
            frm_addtest.Show()
        Catch ex As Exception
            MessageBox.Show("Form is Already in Open, Try to Open Another Form")
        End Try
        
    End Sub

    Private Sub btn_addcompany_Click(sender As Object, e As EventArgs) Handles btn_addcompany.Click
        Try
            frm_company.TopLevel = False
            frm_company.TopMost = True
            Me.pnl_container.Controls.Clear()
            Me.pnl_container.Controls.Add(frm_company)
            frm_company.Show()
        Catch ex As Exception
            MessageBox.Show("Form is Already in Open, Try to Open Another Form")
        End Try
    End Sub

    Private Sub btn_adduser_Click(sender As Object, e As EventArgs) Handles btn_adduser.Click
        Try
            frm_adduser.TopLevel = False
            frm_adduser.TopMost = True
            Me.pnl_container.Controls.Clear()
            Me.pnl_container.Controls.Add(frm_adduser)
            frm_adduser.Show()
        Catch ex As Exception
            MessageBox.Show("Form is Already in Open, Try to Open Another Form")
        End Try
    End Sub
End Class
