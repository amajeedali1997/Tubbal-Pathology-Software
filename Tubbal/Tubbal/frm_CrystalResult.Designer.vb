<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_CrystalResult
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.CR_RPT_VIEW = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.RPT21 = New Tubbal.RPT2()
        Me.SuspendLayout()
        '
        'CR_RPT_VIEW
        '
        Me.CR_RPT_VIEW.ActiveViewIndex = 0
        Me.CR_RPT_VIEW.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CR_RPT_VIEW.Cursor = System.Windows.Forms.Cursors.Default
        Me.CR_RPT_VIEW.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CR_RPT_VIEW.Location = New System.Drawing.Point(0, 0)
        Me.CR_RPT_VIEW.Name = "CR_RPT_VIEW"
        Me.CR_RPT_VIEW.ReportSource = Me.RPT21
        Me.CR_RPT_VIEW.Size = New System.Drawing.Size(284, 261)
        Me.CR_RPT_VIEW.TabIndex = 0
        '
        'frm_CrystalResult
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.CR_RPT_VIEW)
        Me.Name = "frm_CrystalResult"
        Me.Text = "frm_CrystalResult"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents CR_RPT_VIEW As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents RPT21 As Tubbal.RPT2
End Class
