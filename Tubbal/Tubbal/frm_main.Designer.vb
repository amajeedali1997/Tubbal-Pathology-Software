<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_main
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_main))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btn_close = New Bunifu.Framework.UI.BunifuImageButton()
        Me.btn_maximize = New Bunifu.Framework.UI.BunifuImageButton()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btn_minimize = New Bunifu.Framework.UI.BunifuImageButton()
        Me.lbl_title = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btn_adduser = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.btn_addcompany = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.btn_addtest = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.btn_addgroup = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btn_rept = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.btn_commission = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.btn_report = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.btn_allreports = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.btn_adddoctor = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.btn_addpatient = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lbl_user = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel3 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.time = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lbl_time = New System.Windows.Forms.ToolStripStatusLabel()
        Me.pnl_container = New System.Windows.Forms.Panel()
        Me.BunifuElipse1 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Panel1.SuspendLayout()
        CType(Me.btn_close, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_maximize, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_minimize, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(87, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.Panel1.Controls.Add(Me.btn_close)
        Me.Panel1.Controls.Add(Me.btn_maximize)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.btn_minimize)
        Me.Panel1.Controls.Add(Me.lbl_title)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1350, 64)
        Me.Panel1.TabIndex = 0
        '
        'btn_close
        '
        Me.btn_close.BackColor = System.Drawing.Color.FromArgb(CType(CType(87, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.btn_close.Image = CType(resources.GetObject("btn_close.Image"), System.Drawing.Image)
        Me.btn_close.ImageActive = Nothing
        Me.btn_close.Location = New System.Drawing.Point(1301, 15)
        Me.btn_close.Name = "btn_close"
        Me.btn_close.Size = New System.Drawing.Size(31, 33)
        Me.btn_close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btn_close.TabIndex = 0
        Me.btn_close.TabStop = False
        Me.btn_close.Zoom = 10
        '
        'btn_maximize
        '
        Me.btn_maximize.BackColor = System.Drawing.Color.FromArgb(CType(CType(87, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.btn_maximize.Image = CType(resources.GetObject("btn_maximize.Image"), System.Drawing.Image)
        Me.btn_maximize.ImageActive = Nothing
        Me.btn_maximize.Location = New System.Drawing.Point(1266, 15)
        Me.btn_maximize.Name = "btn_maximize"
        Me.btn_maximize.Size = New System.Drawing.Size(31, 33)
        Me.btn_maximize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btn_maximize.TabIndex = 0
        Me.btn_maximize.TabStop = False
        Me.btn_maximize.Zoom = 10
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(625, 10)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(50, 50)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'btn_minimize
        '
        Me.btn_minimize.BackColor = System.Drawing.Color.FromArgb(CType(CType(87, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.btn_minimize.Image = CType(resources.GetObject("btn_minimize.Image"), System.Drawing.Image)
        Me.btn_minimize.ImageActive = Nothing
        Me.btn_minimize.Location = New System.Drawing.Point(1231, 15)
        Me.btn_minimize.Name = "btn_minimize"
        Me.btn_minimize.Size = New System.Drawing.Size(31, 33)
        Me.btn_minimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btn_minimize.TabIndex = 0
        Me.btn_minimize.TabStop = False
        Me.btn_minimize.Zoom = 10
        '
        'lbl_title
        '
        Me.lbl_title.AutoSize = True
        Me.lbl_title.Font = New System.Drawing.Font("Verdana", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_title.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lbl_title.Location = New System.Drawing.Point(675, 18)
        Me.lbl_title.Name = "lbl_title"
        Me.lbl_title.Size = New System.Drawing.Size(135, 32)
        Me.lbl_title.TabIndex = 0
        Me.lbl_title.Text = "TUBBAL"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(12, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(161, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "DASHBOARD"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.Panel2.Controls.Add(Me.btn_adduser)
        Me.Panel2.Controls.Add(Me.btn_addcompany)
        Me.Panel2.Controls.Add(Me.btn_addtest)
        Me.Panel2.Controls.Add(Me.btn_addgroup)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.btn_rept)
        Me.Panel2.Controls.Add(Me.btn_commission)
        Me.Panel2.Controls.Add(Me.btn_report)
        Me.Panel2.Controls.Add(Me.btn_allreports)
        Me.Panel2.Controls.Add(Me.btn_adddoctor)
        Me.Panel2.Controls.Add(Me.btn_addpatient)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel2.ForeColor = System.Drawing.Color.Black
        Me.Panel2.Location = New System.Drawing.Point(0, 64)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(184, 665)
        Me.Panel2.TabIndex = 1
        '
        'btn_adduser
        '
        Me.btn_adduser.Activecolor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.btn_adduser.BackColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.btn_adduser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_adduser.BorderRadius = 0
        Me.btn_adduser.ButtonText = "ADD USER"
        Me.btn_adduser.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_adduser.DisabledColor = System.Drawing.Color.Gray
        Me.btn_adduser.Iconcolor = System.Drawing.Color.Transparent
        Me.btn_adduser.Iconimage = Global.Tubbal.My.Resources.Resources.add_user_3_24
        Me.btn_adduser.Iconimage_right = Nothing
        Me.btn_adduser.Iconimage_right_Selected = Nothing
        Me.btn_adduser.Iconimage_Selected = Nothing
        Me.btn_adduser.IconMarginLeft = 0
        Me.btn_adduser.IconMarginRight = 0
        Me.btn_adduser.IconRightVisible = True
        Me.btn_adduser.IconRightZoom = 0.0R
        Me.btn_adduser.IconVisible = True
        Me.btn_adduser.IconZoom = 50.0R
        Me.btn_adduser.IsTab = False
        Me.btn_adduser.Location = New System.Drawing.Point(1, 473)
        Me.btn_adduser.Name = "btn_adduser"
        Me.btn_adduser.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.btn_adduser.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_adduser.OnHoverTextColor = System.Drawing.Color.White
        Me.btn_adduser.selected = False
        Me.btn_adduser.Size = New System.Drawing.Size(185, 48)
        Me.btn_adduser.TabIndex = 3
        Me.btn_adduser.Text = "ADD USER"
        Me.btn_adduser.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btn_adduser.Textcolor = System.Drawing.Color.White
        Me.btn_adduser.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'btn_addcompany
        '
        Me.btn_addcompany.Activecolor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.btn_addcompany.BackColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.btn_addcompany.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_addcompany.BorderRadius = 0
        Me.btn_addcompany.ButtonText = "ADD COMPANY"
        Me.btn_addcompany.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_addcompany.DisabledColor = System.Drawing.Color.Gray
        Me.btn_addcompany.Iconcolor = System.Drawing.Color.Transparent
        Me.btn_addcompany.Iconimage = CType(resources.GetObject("btn_addcompany.Iconimage"), System.Drawing.Image)
        Me.btn_addcompany.Iconimage_right = Nothing
        Me.btn_addcompany.Iconimage_right_Selected = Nothing
        Me.btn_addcompany.Iconimage_Selected = Nothing
        Me.btn_addcompany.IconMarginLeft = 0
        Me.btn_addcompany.IconMarginRight = 0
        Me.btn_addcompany.IconRightVisible = True
        Me.btn_addcompany.IconRightZoom = 0.0R
        Me.btn_addcompany.IconVisible = True
        Me.btn_addcompany.IconZoom = 50.0R
        Me.btn_addcompany.IsTab = False
        Me.btn_addcompany.Location = New System.Drawing.Point(0, 429)
        Me.btn_addcompany.Name = "btn_addcompany"
        Me.btn_addcompany.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.btn_addcompany.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_addcompany.OnHoverTextColor = System.Drawing.Color.White
        Me.btn_addcompany.selected = False
        Me.btn_addcompany.Size = New System.Drawing.Size(185, 48)
        Me.btn_addcompany.TabIndex = 2
        Me.btn_addcompany.Text = "ADD COMPANY"
        Me.btn_addcompany.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btn_addcompany.Textcolor = System.Drawing.Color.White
        Me.btn_addcompany.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'btn_addtest
        '
        Me.btn_addtest.Activecolor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.btn_addtest.BackColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.btn_addtest.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_addtest.BorderRadius = 0
        Me.btn_addtest.ButtonText = "ADD TEST"
        Me.btn_addtest.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_addtest.DisabledColor = System.Drawing.Color.Gray
        Me.btn_addtest.Iconcolor = System.Drawing.Color.Transparent
        Me.btn_addtest.Iconimage = CType(resources.GetObject("btn_addtest.Iconimage"), System.Drawing.Image)
        Me.btn_addtest.Iconimage_right = Nothing
        Me.btn_addtest.Iconimage_right_Selected = Nothing
        Me.btn_addtest.Iconimage_Selected = Nothing
        Me.btn_addtest.IconMarginLeft = 0
        Me.btn_addtest.IconMarginRight = 0
        Me.btn_addtest.IconRightVisible = True
        Me.btn_addtest.IconRightZoom = 0.0R
        Me.btn_addtest.IconVisible = True
        Me.btn_addtest.IconZoom = 50.0R
        Me.btn_addtest.IsTab = False
        Me.btn_addtest.Location = New System.Drawing.Point(2, 375)
        Me.btn_addtest.Name = "btn_addtest"
        Me.btn_addtest.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.btn_addtest.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_addtest.OnHoverTextColor = System.Drawing.Color.White
        Me.btn_addtest.selected = False
        Me.btn_addtest.Size = New System.Drawing.Size(179, 48)
        Me.btn_addtest.TabIndex = 0
        Me.btn_addtest.Text = "ADD TEST"
        Me.btn_addtest.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btn_addtest.Textcolor = System.Drawing.Color.White
        Me.btn_addtest.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'btn_addgroup
        '
        Me.btn_addgroup.Activecolor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.btn_addgroup.BackColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.btn_addgroup.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_addgroup.BorderRadius = 0
        Me.btn_addgroup.ButtonText = "ADD GROUP"
        Me.btn_addgroup.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_addgroup.DisabledColor = System.Drawing.Color.Gray
        Me.btn_addgroup.Iconcolor = System.Drawing.Color.Transparent
        Me.btn_addgroup.Iconimage = CType(resources.GetObject("btn_addgroup.Iconimage"), System.Drawing.Image)
        Me.btn_addgroup.Iconimage_right = Nothing
        Me.btn_addgroup.Iconimage_right_Selected = Nothing
        Me.btn_addgroup.Iconimage_Selected = Nothing
        Me.btn_addgroup.IconMarginLeft = 0
        Me.btn_addgroup.IconMarginRight = 0
        Me.btn_addgroup.IconRightVisible = True
        Me.btn_addgroup.IconRightZoom = 0.0R
        Me.btn_addgroup.IconVisible = True
        Me.btn_addgroup.IconZoom = 60.0R
        Me.btn_addgroup.IsTab = False
        Me.btn_addgroup.Location = New System.Drawing.Point(3, 326)
        Me.btn_addgroup.Name = "btn_addgroup"
        Me.btn_addgroup.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.btn_addgroup.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_addgroup.OnHoverTextColor = System.Drawing.Color.White
        Me.btn_addgroup.selected = False
        Me.btn_addgroup.Size = New System.Drawing.Size(178, 48)
        Me.btn_addgroup.TabIndex = 1
        Me.btn_addgroup.Text = "ADD GROUP"
        Me.btn_addgroup.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btn_addgroup.Textcolor = System.Drawing.Color.White
        Me.btn_addgroup.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label2.Location = New System.Drawing.Point(7, 298)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(178, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "---------------------------------------------------------"
        '
        'btn_rept
        '
        Me.btn_rept.Activecolor = System.Drawing.Color.Blue
        Me.btn_rept.BackColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.btn_rept.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_rept.BorderRadius = 0
        Me.btn_rept.ButtonText = "RESULT"
        Me.btn_rept.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_rept.DisabledColor = System.Drawing.Color.Gray
        Me.btn_rept.Iconcolor = System.Drawing.Color.Transparent
        Me.btn_rept.Iconimage = CType(resources.GetObject("btn_rept.Iconimage"), System.Drawing.Image)
        Me.btn_rept.Iconimage_right = Nothing
        Me.btn_rept.Iconimage_right_Selected = Nothing
        Me.btn_rept.Iconimage_Selected = Nothing
        Me.btn_rept.IconMarginLeft = 0
        Me.btn_rept.IconMarginRight = 0
        Me.btn_rept.IconRightVisible = True
        Me.btn_rept.IconRightZoom = 0.0R
        Me.btn_rept.IconVisible = True
        Me.btn_rept.IconZoom = 40.0R
        Me.btn_rept.IsTab = False
        Me.btn_rept.Location = New System.Drawing.Point(2, 143)
        Me.btn_rept.Name = "btn_rept"
        Me.btn_rept.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.btn_rept.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_rept.OnHoverTextColor = System.Drawing.Color.White
        Me.btn_rept.selected = False
        Me.btn_rept.Size = New System.Drawing.Size(183, 48)
        Me.btn_rept.TabIndex = 0
        Me.btn_rept.Text = "RESULT"
        Me.btn_rept.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btn_rept.Textcolor = System.Drawing.Color.White
        Me.btn_rept.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'btn_commission
        '
        Me.btn_commission.Activecolor = System.Drawing.Color.Blue
        Me.btn_commission.BackColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.btn_commission.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_commission.BorderRadius = 0
        Me.btn_commission.ButtonText = "COMM REPORT"
        Me.btn_commission.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_commission.DisabledColor = System.Drawing.Color.Gray
        Me.btn_commission.Iconcolor = System.Drawing.Color.Transparent
        Me.btn_commission.Iconimage = CType(resources.GetObject("btn_commission.Iconimage"), System.Drawing.Image)
        Me.btn_commission.Iconimage_right = Nothing
        Me.btn_commission.Iconimage_right_Selected = Nothing
        Me.btn_commission.Iconimage_Selected = Nothing
        Me.btn_commission.IconMarginLeft = 0
        Me.btn_commission.IconMarginRight = 0
        Me.btn_commission.IconRightVisible = True
        Me.btn_commission.IconRightZoom = 0.0R
        Me.btn_commission.IconVisible = True
        Me.btn_commission.IconZoom = 40.0R
        Me.btn_commission.IsTab = False
        Me.btn_commission.Location = New System.Drawing.Point(2, 236)
        Me.btn_commission.Name = "btn_commission"
        Me.btn_commission.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.btn_commission.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_commission.OnHoverTextColor = System.Drawing.Color.White
        Me.btn_commission.selected = False
        Me.btn_commission.Size = New System.Drawing.Size(183, 48)
        Me.btn_commission.TabIndex = 0
        Me.btn_commission.Text = "COMM REPORT"
        Me.btn_commission.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btn_commission.Textcolor = System.Drawing.Color.White
        Me.btn_commission.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'btn_report
        '
        Me.btn_report.Activecolor = System.Drawing.Color.Blue
        Me.btn_report.BackColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.btn_report.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_report.BorderRadius = 0
        Me.btn_report.ButtonText = "PENDING REPORT"
        Me.btn_report.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_report.DisabledColor = System.Drawing.Color.Gray
        Me.btn_report.Iconcolor = System.Drawing.Color.Transparent
        Me.btn_report.Iconimage = CType(resources.GetObject("btn_report.Iconimage"), System.Drawing.Image)
        Me.btn_report.Iconimage_right = Nothing
        Me.btn_report.Iconimage_right_Selected = Nothing
        Me.btn_report.Iconimage_Selected = Nothing
        Me.btn_report.IconMarginLeft = 0
        Me.btn_report.IconMarginRight = 0
        Me.btn_report.IconRightVisible = True
        Me.btn_report.IconRightZoom = 0.0R
        Me.btn_report.IconVisible = True
        Me.btn_report.IconZoom = 40.0R
        Me.btn_report.IsTab = False
        Me.btn_report.Location = New System.Drawing.Point(2, 96)
        Me.btn_report.Name = "btn_report"
        Me.btn_report.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.btn_report.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_report.OnHoverTextColor = System.Drawing.Color.White
        Me.btn_report.selected = False
        Me.btn_report.Size = New System.Drawing.Size(183, 48)
        Me.btn_report.TabIndex = 0
        Me.btn_report.Text = "PENDING REPORT"
        Me.btn_report.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btn_report.Textcolor = System.Drawing.Color.White
        Me.btn_report.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'btn_allreports
        '
        Me.btn_allreports.Activecolor = System.Drawing.Color.Blue
        Me.btn_allreports.BackColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.btn_allreports.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_allreports.BorderRadius = 0
        Me.btn_allreports.ButtonText = "ALL REPORTS"
        Me.btn_allreports.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_allreports.DisabledColor = System.Drawing.Color.Gray
        Me.btn_allreports.Iconcolor = System.Drawing.Color.Transparent
        Me.btn_allreports.Iconimage = CType(resources.GetObject("btn_allreports.Iconimage"), System.Drawing.Image)
        Me.btn_allreports.Iconimage_right = Nothing
        Me.btn_allreports.Iconimage_right_Selected = Nothing
        Me.btn_allreports.Iconimage_Selected = Nothing
        Me.btn_allreports.IconMarginLeft = 0
        Me.btn_allreports.IconMarginRight = 0
        Me.btn_allreports.IconRightVisible = True
        Me.btn_allreports.IconRightZoom = 0.0R
        Me.btn_allreports.IconVisible = True
        Me.btn_allreports.IconZoom = 40.0R
        Me.btn_allreports.IsTab = False
        Me.btn_allreports.Location = New System.Drawing.Point(0, 192)
        Me.btn_allreports.Name = "btn_allreports"
        Me.btn_allreports.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.btn_allreports.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_allreports.OnHoverTextColor = System.Drawing.Color.White
        Me.btn_allreports.selected = False
        Me.btn_allreports.Size = New System.Drawing.Size(183, 48)
        Me.btn_allreports.TabIndex = 0
        Me.btn_allreports.Text = "ALL REPORTS"
        Me.btn_allreports.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btn_allreports.Textcolor = System.Drawing.Color.White
        Me.btn_allreports.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'btn_adddoctor
        '
        Me.btn_adddoctor.Activecolor = System.Drawing.Color.Blue
        Me.btn_adddoctor.BackColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.btn_adddoctor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_adddoctor.BorderRadius = 0
        Me.btn_adddoctor.ButtonText = "ADD DOCTOR"
        Me.btn_adddoctor.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_adddoctor.DisabledColor = System.Drawing.Color.Gray
        Me.btn_adddoctor.Iconcolor = System.Drawing.Color.Transparent
        Me.btn_adddoctor.Iconimage = CType(resources.GetObject("btn_adddoctor.Iconimage"), System.Drawing.Image)
        Me.btn_adddoctor.Iconimage_right = Nothing
        Me.btn_adddoctor.Iconimage_right_Selected = Nothing
        Me.btn_adddoctor.Iconimage_Selected = Nothing
        Me.btn_adddoctor.IconMarginLeft = 0
        Me.btn_adddoctor.IconMarginRight = 0
        Me.btn_adddoctor.IconRightVisible = True
        Me.btn_adddoctor.IconRightZoom = 0.0R
        Me.btn_adddoctor.IconVisible = True
        Me.btn_adddoctor.IconZoom = 40.0R
        Me.btn_adddoctor.IsTab = False
        Me.btn_adddoctor.Location = New System.Drawing.Point(0, 49)
        Me.btn_adddoctor.Name = "btn_adddoctor"
        Me.btn_adddoctor.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.btn_adddoctor.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_adddoctor.OnHoverTextColor = System.Drawing.Color.White
        Me.btn_adddoctor.selected = False
        Me.btn_adddoctor.Size = New System.Drawing.Size(189, 48)
        Me.btn_adddoctor.TabIndex = 0
        Me.btn_adddoctor.Text = "ADD DOCTOR"
        Me.btn_adddoctor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btn_adddoctor.Textcolor = System.Drawing.Color.White
        Me.btn_adddoctor.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'btn_addpatient
        '
        Me.btn_addpatient.Activecolor = System.Drawing.Color.Blue
        Me.btn_addpatient.BackColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.btn_addpatient.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_addpatient.BorderRadius = 0
        Me.btn_addpatient.ButtonText = "ADD PATIENT"
        Me.btn_addpatient.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_addpatient.DisabledColor = System.Drawing.Color.Gray
        Me.btn_addpatient.Iconcolor = System.Drawing.Color.Transparent
        Me.btn_addpatient.Iconimage = CType(resources.GetObject("btn_addpatient.Iconimage"), System.Drawing.Image)
        Me.btn_addpatient.Iconimage_right = Nothing
        Me.btn_addpatient.Iconimage_right_Selected = Nothing
        Me.btn_addpatient.Iconimage_Selected = Nothing
        Me.btn_addpatient.IconMarginLeft = 0
        Me.btn_addpatient.IconMarginRight = 0
        Me.btn_addpatient.IconRightVisible = True
        Me.btn_addpatient.IconRightZoom = 0.0R
        Me.btn_addpatient.IconVisible = True
        Me.btn_addpatient.IconZoom = 40.0R
        Me.btn_addpatient.IsTab = False
        Me.btn_addpatient.Location = New System.Drawing.Point(2, 2)
        Me.btn_addpatient.Name = "btn_addpatient"
        Me.btn_addpatient.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.btn_addpatient.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_addpatient.OnHoverTextColor = System.Drawing.Color.White
        Me.btn_addpatient.selected = False
        Me.btn_addpatient.Size = New System.Drawing.Size(183, 48)
        Me.btn_addpatient.TabIndex = 0
        Me.btn_addpatient.Text = "ADD PATIENT"
        Me.btn_addpatient.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btn_addpatient.Textcolor = System.Drawing.Color.White
        Me.btn_addpatient.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'StatusStrip1
        '
        Me.StatusStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(87, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.StatusStrip1.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1, Me.lbl_user, Me.ToolStripStatusLabel3, Me.time, Me.lbl_time})
        Me.StatusStrip1.Location = New System.Drawing.Point(184, 704)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(1166, 25)
        Me.StatusStrip1.TabIndex = 2
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ToolStripStatusLabel1.Image = CType(resources.GetObject("ToolStripStatusLabel1.Image"), System.Drawing.Image)
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(99, 20)
        Me.ToolStripStatusLabel1.Text = "Logged in :"
        '
        'lbl_user
        '
        Me.lbl_user.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lbl_user.Name = "lbl_user"
        Me.lbl_user.Size = New System.Drawing.Size(53, 20)
        Me.lbl_user.Text = "Admin"
        '
        'ToolStripStatusLabel3
        '
        Me.ToolStripStatusLabel3.Name = "ToolStripStatusLabel3"
        Me.ToolStripStatusLabel3.Size = New System.Drawing.Size(33, 20)
        Me.ToolStripStatusLabel3.Text = "      "
        '
        'time
        '
        Me.time.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.time.Image = CType(resources.GetObject("time.Image"), System.Drawing.Image)
        Me.time.Name = "time"
        Me.time.Size = New System.Drawing.Size(65, 20)
        Me.time.Text = "Time :"
        '
        'lbl_time
        '
        Me.lbl_time.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lbl_time.Name = "lbl_time"
        Me.lbl_time.Size = New System.Drawing.Size(71, 20)
        Me.lbl_time.Text = "12.00 AM"
        '
        'pnl_container
        '
        Me.pnl_container.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnl_container.Location = New System.Drawing.Point(184, 64)
        Me.pnl_container.Name = "pnl_container"
        Me.pnl_container.Size = New System.Drawing.Size(1166, 640)
        Me.pnl_container.TabIndex = 3
        '
        'BunifuElipse1
        '
        Me.BunifuElipse1.ElipseRadius = 20
        Me.BunifuElipse1.TargetControl = Me
        '
        'Timer1
        '
        '
        'frm_main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1350, 729)
        Me.Controls.Add(Me.pnl_container)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frm_main"
        Me.Text = "e"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.btn_close, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_maximize, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_minimize, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents lbl_user As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents time As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents lbl_time As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents pnl_container As System.Windows.Forms.Panel
    Friend WithEvents btn_close As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents btn_maximize As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents btn_minimize As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents lbl_title As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btn_rept As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents btn_commission As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents btn_report As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents btn_allreports As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents btn_adddoctor As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents btn_addpatient As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents ToolStripStatusLabel3 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents BunifuElipse1 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btn_addtest As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents btn_addgroup As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents btn_addcompany As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents btn_adduser As Bunifu.Framework.UI.BunifuFlatButton

End Class
