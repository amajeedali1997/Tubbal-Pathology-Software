Imports System.Data.SqlClient
Imports System.Data
Public Class frm_login

    Private Sub btn_login_Click(sender As Object, e As EventArgs) Handles btn_login.Click
        Try

            If txt_username.Text = "" Or txt_password.Text = "" Then
                MsgBox("Plz Fill All the info", MsgBoxStyle.Exclamation, "Fill the Details")
            Else
                openconnection()
                Dim cmd As New SqlCommand("Select * from tbl_user where username=@username and password=@pass and usertype=@utype", cn)

                cmd.Parameters.Add("@username", SqlDbType.VarChar).Value = txt_username.Text
                cmd.Parameters.Add("@pass", SqlDbType.VarChar).Value = txt_password.Text
                cmd.Parameters.Add("@utype", SqlDbType.VarChar).Value = cbo_usertype.Text
                Dim da As New SqlDataAdapter(cmd)
                Dim table As New DataTable()
                da.Fill(table)
                If table.Rows.Count() <= 0 Then
                    MessageBox.Show("Username or Password or UserType is Incorrect", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Else
                    If cbo_usertype.Text = "USER" Then
                        frm_main.btn_addcompany.Visible = False
                        frm_main.btn_adduser.Visible = False
                        frm_main.btn_addtest.Visible = False
                        frm_main.btn_addgroup.Visible = False
                        frm_main.lbl_user.Text = txt_username.Text
                    ElseIf cbo_usertype.Text = "LAB TECHNICIAN" Then
                        frm_main.btn_addcompany.Visible = False
                        frm_main.btn_adduser.Visible = False
                        frm_main.btn_addtest.Visible = False
                        frm_main.btn_addgroup.Visible = False
                        frm_main.btn_adddoctor.Enabled = False
                        frm_main.btn_allreports.Enabled = False
                        frm_main.btn_commission.Enabled = False
                        frm_main.lbl_user.Text = txt_username.Text
                    End If
                    frm_main.lbl_user.Text = txt_username.Text
                    txt_username.Clear()
                    txt_password.Clear()
                    txt_username.Focus()
                    Me.Hide()
                    frm_main.Show()
                End If
            End If
            closeconnection()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub lbl_forgerpass_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lbl_forgerpass.LinkClicked
        frm_forgetpass.Show()
    End Sub

    Private Sub frm_login_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Private Sub frm_login_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        Application.Exit()
    End Sub
End Class