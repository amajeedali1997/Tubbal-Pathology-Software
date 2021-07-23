<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_addpatient
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_addpatient))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DTP1 = New System.Windows.Forms.DateTimePicker()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.BTextbox1 = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.BTextbox2 = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.BTextbox4 = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.BTextbox5 = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.BTextbox6 = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.dgvData = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ComboBox3 = New System.Windows.Forms.ComboBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TextBox7 = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.btn_save = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.btn_update = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.btn_clear = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.btn_delete = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.btn_addDoctor = New Bunifu.Framework.UI.BunifuImageButton()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btn_addgroup = New Bunifu.Framework.UI.BunifuImageButton()
        Me.btn_refresh = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.btn_total = New System.Windows.Forms.Button()
        CType(Me.dgvData, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_addDoctor, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_addgroup, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(76, 86)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 19)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Date"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(270, 88)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 19)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "OPD No"
        '
        'DTP1
        '
        Me.DTP1.CustomFormat = "dd/MM/yyyy"
        Me.DTP1.Enabled = False
        Me.DTP1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DTP1.Location = New System.Drawing.Point(133, 84)
        Me.DTP1.Margin = New System.Windows.Forms.Padding(4)
        Me.DTP1.Name = "DTP1"
        Me.DTP1.Size = New System.Drawing.Size(129, 26)
        Me.DTP1.TabIndex = 1
        '
        'TextBox1
        '
        Me.TextBox1.Enabled = False
        Me.TextBox1.Location = New System.Drawing.Point(343, 86)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(128, 26)
        Me.TextBox1.TabIndex = 2
        Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'BTextbox1
        '
        Me.BTextbox1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.BTextbox1.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTextbox1.ForeColor = System.Drawing.Color.Black
        Me.BTextbox1.HintForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BTextbox1.HintText = "Contact No"
        Me.BTextbox1.isPassword = False
        Me.BTextbox1.LineFocusedColor = System.Drawing.Color.Blue
        Me.BTextbox1.LineIdleColor = System.Drawing.Color.Gray
        Me.BTextbox1.LineMouseHoverColor = System.Drawing.Color.Blue
        Me.BTextbox1.LineThickness = 4
        Me.BTextbox1.Location = New System.Drawing.Point(75, 427)
        Me.BTextbox1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BTextbox1.Name = "BTextbox1"
        Me.BTextbox1.Size = New System.Drawing.Size(313, 52)
        Me.BTextbox1.TabIndex = 3
        Me.BTextbox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'BTextbox2
        '
        Me.BTextbox2.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.BTextbox2.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTextbox2.ForeColor = System.Drawing.Color.Black
        Me.BTextbox2.HintForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BTextbox2.HintText = "City/Village"
        Me.BTextbox2.isPassword = False
        Me.BTextbox2.LineFocusedColor = System.Drawing.Color.Blue
        Me.BTextbox2.LineIdleColor = System.Drawing.Color.Gray
        Me.BTextbox2.LineMouseHoverColor = System.Drawing.Color.Blue
        Me.BTextbox2.LineThickness = 4
        Me.BTextbox2.Location = New System.Drawing.Point(76, 371)
        Me.BTextbox2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BTextbox2.Name = "BTextbox2"
        Me.BTextbox2.Size = New System.Drawing.Size(313, 52)
        Me.BTextbox2.TabIndex = 3
        Me.BTextbox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'BTextbox4
        '
        Me.BTextbox4.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.BTextbox4.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTextbox4.ForeColor = System.Drawing.Color.Black
        Me.BTextbox4.HintForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BTextbox4.HintText = "Address"
        Me.BTextbox4.isPassword = False
        Me.BTextbox4.LineFocusedColor = System.Drawing.Color.Blue
        Me.BTextbox4.LineIdleColor = System.Drawing.Color.Gray
        Me.BTextbox4.LineMouseHoverColor = System.Drawing.Color.Blue
        Me.BTextbox4.LineThickness = 4
        Me.BTextbox4.Location = New System.Drawing.Point(76, 316)
        Me.BTextbox4.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BTextbox4.Name = "BTextbox4"
        Me.BTextbox4.Size = New System.Drawing.Size(313, 52)
        Me.BTextbox4.TabIndex = 3
        Me.BTextbox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'BTextbox5
        '
        Me.BTextbox5.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.BTextbox5.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTextbox5.ForeColor = System.Drawing.Color.Black
        Me.BTextbox5.HintForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BTextbox5.HintText = "Age"
        Me.BTextbox5.isPassword = False
        Me.BTextbox5.LineFocusedColor = System.Drawing.Color.Blue
        Me.BTextbox5.LineIdleColor = System.Drawing.Color.Gray
        Me.BTextbox5.LineMouseHoverColor = System.Drawing.Color.Blue
        Me.BTextbox5.LineThickness = 4
        Me.BTextbox5.Location = New System.Drawing.Point(76, 207)
        Me.BTextbox5.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BTextbox5.Name = "BTextbox5"
        Me.BTextbox5.Size = New System.Drawing.Size(313, 52)
        Me.BTextbox5.TabIndex = 3
        Me.BTextbox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'BTextbox6
        '
        Me.BTextbox6.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.BTextbox6.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTextbox6.ForeColor = System.Drawing.Color.Black
        Me.BTextbox6.HintForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BTextbox6.HintText = "Patient Name"
        Me.BTextbox6.isPassword = False
        Me.BTextbox6.LineFocusedColor = System.Drawing.Color.Blue
        Me.BTextbox6.LineIdleColor = System.Drawing.Color.Gray
        Me.BTextbox6.LineMouseHoverColor = System.Drawing.Color.Blue
        Me.BTextbox6.LineThickness = 4
        Me.BTextbox6.Location = New System.Drawing.Point(76, 155)
        Me.BTextbox6.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BTextbox6.Name = "BTextbox6"
        Me.BTextbox6.Size = New System.Drawing.Size(313, 52)
        Me.BTextbox6.TabIndex = 3
        Me.BTextbox6.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.RadioButton1.Location = New System.Drawing.Point(78, 286)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(67, 25)
        Me.RadioButton1.TabIndex = 4
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "Male"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.RadioButton2.Location = New System.Drawing.Point(250, 286)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(85, 25)
        Me.RadioButton2.TabIndex = 4
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "Female"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'dgvData
        '
        Me.dgvData.AllowUserToAddRows = False
        Me.dgvData.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvData.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6})
        Me.dgvData.Location = New System.Drawing.Point(405, 177)
        Me.dgvData.Name = "dgvData"
        Me.dgvData.Size = New System.Drawing.Size(486, 246)
        Me.dgvData.TabIndex = 5
        '
        'Column1
        '
        Me.Column1.HeaderText = ""
        Me.Column1.Name = "Column1"
        Me.Column1.Width = 20
        '
        'Column2
        '
        Me.Column2.HeaderText = "Test Name"
        Me.Column2.Name = "Column2"
        Me.Column2.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Column2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.Column2.Width = 200
        '
        'Column3
        '
        Me.Column3.HeaderText = "Test Group"
        Me.Column3.Name = "Column3"
        Me.Column3.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Column3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.Column3.Width = 150
        '
        'Column4
        '
        Me.Column4.HeaderText = "Cost"
        Me.Column4.Name = "Column4"
        Me.Column4.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Column4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.Column4.Width = 80
        '
        'Column5
        '
        Me.Column5.HeaderText = "Unit"
        Me.Column5.Name = "Column5"
        '
        'Column6
        '
        Me.Column6.HeaderText = "Normal Range"
        Me.Column6.Name = "Column6"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(803, 91)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(80, 19)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Acc Name"
        '
        'ComboBox1
        '
        Me.ComboBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.ComboBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Cash", "Card"})
        Me.ComboBox1.Location = New System.Drawing.Point(888, 85)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(167, 26)
        Me.ComboBox1.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(454, 229)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(134, 19)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Select Test Group"
        '
        'ComboBox2
        '
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(615, 225)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(167, 26)
        Me.ComboBox2.TabIndex = 6
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(492, 88)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(59, 19)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Ref By."
        '
        'ComboBox3
        '
        Me.ComboBox3.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.ComboBox3.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.ComboBox3.FormattingEnabled = True
        Me.ComboBox3.Location = New System.Drawing.Point(558, 86)
        Me.ComboBox3.Name = "ComboBox3"
        Me.ComboBox3.Size = New System.Drawing.Size(167, 26)
        Me.ComboBox3.TabIndex = 6
        '
        'TextBox2
        '
        Me.TextBox2.BackColor = System.Drawing.SystemColors.Control
        Me.TextBox2.Location = New System.Drawing.Point(566, 466)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(142, 26)
        Me.TextBox2.TabIndex = 8
        Me.TextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(562, 444)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(148, 20)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "No.of Test Selected"
        '
        'TextBox3
        '
        Me.TextBox3.BackColor = System.Drawing.SystemColors.Control
        Me.TextBox3.Location = New System.Drawing.Point(721, 373)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(142, 26)
        Me.TextBox3.TabIndex = 10
        Me.TextBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.TextBox3.Visible = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(717, 351)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(106, 20)
        Me.Label7.TabIndex = 9
        Me.Label7.Text = "No.of Groups"
        Me.Label7.Visible = False
        '
        'TextBox4
        '
        Me.TextBox4.BackColor = System.Drawing.SystemColors.Control
        Me.TextBox4.Enabled = False
        Me.TextBox4.ForeColor = System.Drawing.Color.Blue
        Me.TextBox4.Location = New System.Drawing.Point(504, 528)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(142, 26)
        Me.TextBox4.TabIndex = 12
        Me.TextBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(500, 506)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(79, 20)
        Me.Label8.TabIndex = 11
        Me.Label8.Text = "Total Cost"
        '
        'TextBox5
        '
        Me.TextBox5.BackColor = System.Drawing.SystemColors.Control
        Me.TextBox5.ForeColor = System.Drawing.Color.Blue
        Me.TextBox5.Location = New System.Drawing.Point(690, 528)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(142, 26)
        Me.TextBox5.TabIndex = 14
        Me.TextBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(686, 506)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(125, 20)
        Me.Label9.TabIndex = 13
        Me.Label9.Text = "Discount (if any)"
        '
        'TextBox6
        '
        Me.TextBox6.BackColor = System.Drawing.SystemColors.Control
        Me.TextBox6.ForeColor = System.Drawing.Color.Blue
        Me.TextBox6.Location = New System.Drawing.Point(504, 593)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(142, 26)
        Me.TextBox6.TabIndex = 16
        Me.TextBox6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(500, 571)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(132, 20)
        Me.Label10.TabIndex = 15
        Me.Label10.Text = "Advance (if any)"
        '
        'TextBox7
        '
        Me.TextBox7.BackColor = System.Drawing.SystemColors.Control
        Me.TextBox7.Enabled = False
        Me.TextBox7.ForeColor = System.Drawing.Color.Blue
        Me.TextBox7.Location = New System.Drawing.Point(690, 593)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New System.Drawing.Size(142, 26)
        Me.TextBox7.TabIndex = 18
        Me.TextBox7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(686, 571)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(96, 20)
        Me.Label11.TabIndex = 17
        Me.Label11.Text = "Net Amount"
        '
        'btn_save
        '
        Me.btn_save.Activecolor = System.Drawing.Color.DodgerBlue
        Me.btn_save.BackColor = System.Drawing.Color.DodgerBlue
        Me.btn_save.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_save.BorderRadius = 0
        Me.btn_save.ButtonText = "SAVE"
        Me.btn_save.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_save.DisabledColor = System.Drawing.Color.Gray
        Me.btn_save.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_save.Iconcolor = System.Drawing.Color.Transparent
        Me.btn_save.Iconimage = CType(resources.GetObject("btn_save.Iconimage"), System.Drawing.Image)
        Me.btn_save.Iconimage_right = Nothing
        Me.btn_save.Iconimage_right_Selected = Nothing
        Me.btn_save.Iconimage_Selected = Nothing
        Me.btn_save.IconMarginLeft = 0
        Me.btn_save.IconMarginRight = 0
        Me.btn_save.IconRightVisible = True
        Me.btn_save.IconRightZoom = 0.0R
        Me.btn_save.IconVisible = True
        Me.btn_save.IconZoom = 90.0R
        Me.btn_save.IsTab = False
        Me.btn_save.Location = New System.Drawing.Point(901, 181)
        Me.btn_save.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_save.Name = "btn_save"
        Me.btn_save.Normalcolor = System.Drawing.Color.DodgerBlue
        Me.btn_save.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.btn_save.OnHoverTextColor = System.Drawing.Color.White
        Me.btn_save.selected = False
        Me.btn_save.Size = New System.Drawing.Size(150, 43)
        Me.btn_save.TabIndex = 0
        Me.btn_save.Text = "SAVE"
        Me.btn_save.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_save.Textcolor = System.Drawing.Color.White
        Me.btn_save.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'btn_update
        '
        Me.btn_update.Activecolor = System.Drawing.Color.MediumOrchid
        Me.btn_update.BackColor = System.Drawing.Color.MediumOrchid
        Me.btn_update.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_update.BorderRadius = 0
        Me.btn_update.ButtonText = "RE PRINT"
        Me.btn_update.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_update.DisabledColor = System.Drawing.Color.Gray
        Me.btn_update.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_update.Iconcolor = System.Drawing.Color.Transparent
        Me.btn_update.Iconimage = CType(resources.GetObject("btn_update.Iconimage"), System.Drawing.Image)
        Me.btn_update.Iconimage_right = Nothing
        Me.btn_update.Iconimage_right_Selected = Nothing
        Me.btn_update.Iconimage_Selected = Nothing
        Me.btn_update.IconMarginLeft = 0
        Me.btn_update.IconMarginRight = 0
        Me.btn_update.IconRightVisible = True
        Me.btn_update.IconRightZoom = 0.0R
        Me.btn_update.IconVisible = True
        Me.btn_update.IconZoom = 90.0R
        Me.btn_update.IsTab = False
        Me.btn_update.Location = New System.Drawing.Point(902, 229)
        Me.btn_update.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.btn_update.Name = "btn_update"
        Me.btn_update.Normalcolor = System.Drawing.Color.MediumOrchid
        Me.btn_update.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.btn_update.OnHoverTextColor = System.Drawing.Color.White
        Me.btn_update.selected = False
        Me.btn_update.Size = New System.Drawing.Size(150, 43)
        Me.btn_update.TabIndex = 0
        Me.btn_update.Text = "RE PRINT"
        Me.btn_update.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_update.Textcolor = System.Drawing.Color.White
        Me.btn_update.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'btn_clear
        '
        Me.btn_clear.Activecolor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_clear.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_clear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_clear.BorderRadius = 0
        Me.btn_clear.ButtonText = "CLEAR"
        Me.btn_clear.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_clear.DisabledColor = System.Drawing.Color.Gray
        Me.btn_clear.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_clear.Iconcolor = System.Drawing.Color.Transparent
        Me.btn_clear.Iconimage = CType(resources.GetObject("btn_clear.Iconimage"), System.Drawing.Image)
        Me.btn_clear.Iconimage_right = Nothing
        Me.btn_clear.Iconimage_right_Selected = Nothing
        Me.btn_clear.Iconimage_Selected = Nothing
        Me.btn_clear.IconMarginLeft = 0
        Me.btn_clear.IconMarginRight = 0
        Me.btn_clear.IconRightVisible = True
        Me.btn_clear.IconRightZoom = 0.0R
        Me.btn_clear.IconVisible = True
        Me.btn_clear.IconZoom = 90.0R
        Me.btn_clear.IsTab = False
        Me.btn_clear.Location = New System.Drawing.Point(901, 324)
        Me.btn_clear.Margin = New System.Windows.Forms.Padding(7, 8, 7, 8)
        Me.btn_clear.Name = "btn_clear"
        Me.btn_clear.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_clear.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.btn_clear.OnHoverTextColor = System.Drawing.Color.White
        Me.btn_clear.selected = False
        Me.btn_clear.Size = New System.Drawing.Size(150, 43)
        Me.btn_clear.TabIndex = 0
        Me.btn_clear.Text = "CLEAR"
        Me.btn_clear.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_clear.Textcolor = System.Drawing.Color.White
        Me.btn_clear.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'btn_delete
        '
        Me.btn_delete.Activecolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.btn_delete.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btn_delete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_delete.BorderRadius = 0
        Me.btn_delete.ButtonText = "DELETE"
        Me.btn_delete.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_delete.DisabledColor = System.Drawing.Color.Gray
        Me.btn_delete.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_delete.Iconcolor = System.Drawing.Color.Transparent
        Me.btn_delete.Iconimage = CType(resources.GetObject("btn_delete.Iconimage"), System.Drawing.Image)
        Me.btn_delete.Iconimage_right = Nothing
        Me.btn_delete.Iconimage_right_Selected = Nothing
        Me.btn_delete.Iconimage_Selected = Nothing
        Me.btn_delete.IconMarginLeft = 0
        Me.btn_delete.IconMarginRight = 0
        Me.btn_delete.IconRightVisible = True
        Me.btn_delete.IconRightZoom = 0.0R
        Me.btn_delete.IconVisible = True
        Me.btn_delete.IconZoom = 90.0R
        Me.btn_delete.IsTab = False
        Me.btn_delete.Location = New System.Drawing.Point(901, 276)
        Me.btn_delete.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.btn_delete.Name = "btn_delete"
        Me.btn_delete.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btn_delete.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.btn_delete.OnHoverTextColor = System.Drawing.Color.White
        Me.btn_delete.selected = False
        Me.btn_delete.Size = New System.Drawing.Size(150, 43)
        Me.btn_delete.TabIndex = 0
        Me.btn_delete.Text = "DELETE"
        Me.btn_delete.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_delete.Textcolor = System.Drawing.Color.White
        Me.btn_delete.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'btn_addDoctor
        '
        Me.btn_addDoctor.BackColor = System.Drawing.SystemColors.Control
        Me.btn_addDoctor.Image = CType(resources.GetObject("btn_addDoctor.Image"), System.Drawing.Image)
        Me.btn_addDoctor.ImageActive = Nothing
        Me.btn_addDoctor.Location = New System.Drawing.Point(731, 84)
        Me.btn_addDoctor.Name = "btn_addDoctor"
        Me.btn_addDoctor.Size = New System.Drawing.Size(31, 30)
        Me.btn_addDoctor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btn_addDoctor.TabIndex = 20
        Me.btn_addDoctor.TabStop = False
        Me.btn_addDoctor.Zoom = 10
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.DimGray
        Me.Label12.Location = New System.Drawing.Point(71, 27)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(142, 23)
        Me.Label12.TabIndex = 22
        Me.Label12.Text = "ADD PATIENT"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(12, 9)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(53, 49)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 21
        Me.PictureBox1.TabStop = False
        '
        'btn_addgroup
        '
        Me.btn_addgroup.BackColor = System.Drawing.Color.Transparent
        Me.btn_addgroup.Image = CType(resources.GetObject("btn_addgroup.Image"), System.Drawing.Image)
        Me.btn_addgroup.ImageActive = Nothing
        Me.btn_addgroup.Location = New System.Drawing.Point(789, 221)
        Me.btn_addgroup.Name = "btn_addgroup"
        Me.btn_addgroup.Size = New System.Drawing.Size(30, 30)
        Me.btn_addgroup.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btn_addgroup.TabIndex = 23
        Me.btn_addgroup.TabStop = False
        Me.btn_addgroup.Zoom = 10
        '
        'btn_refresh
        '
        Me.btn_refresh.Activecolor = System.Drawing.Color.Tomato
        Me.btn_refresh.BackColor = System.Drawing.Color.Tomato
        Me.btn_refresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_refresh.BorderRadius = 0
        Me.btn_refresh.ButtonText = "REFRESH"
        Me.btn_refresh.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_refresh.DisabledColor = System.Drawing.Color.Gray
        Me.btn_refresh.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_refresh.Iconcolor = System.Drawing.Color.Transparent
        Me.btn_refresh.Iconimage = CType(resources.GetObject("btn_refresh.Iconimage"), System.Drawing.Image)
        Me.btn_refresh.Iconimage_right = Nothing
        Me.btn_refresh.Iconimage_right_Selected = Nothing
        Me.btn_refresh.Iconimage_Selected = Nothing
        Me.btn_refresh.IconMarginLeft = 0
        Me.btn_refresh.IconMarginRight = 0
        Me.btn_refresh.IconRightVisible = True
        Me.btn_refresh.IconRightZoom = 0.0R
        Me.btn_refresh.IconVisible = True
        Me.btn_refresh.IconZoom = 90.0R
        Me.btn_refresh.IsTab = False
        Me.btn_refresh.Location = New System.Drawing.Point(901, 373)
        Me.btn_refresh.Margin = New System.Windows.Forms.Padding(7, 8, 7, 8)
        Me.btn_refresh.Name = "btn_refresh"
        Me.btn_refresh.Normalcolor = System.Drawing.Color.Tomato
        Me.btn_refresh.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.btn_refresh.OnHoverTextColor = System.Drawing.Color.White
        Me.btn_refresh.selected = False
        Me.btn_refresh.Size = New System.Drawing.Size(150, 43)
        Me.btn_refresh.TabIndex = 0
        Me.btn_refresh.Text = "REFRESH"
        Me.btn_refresh.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_refresh.Textcolor = System.Drawing.Color.White
        Me.btn_refresh.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'Timer1
        '
        Me.Timer1.Interval = 400
        '
        'btn_total
        '
        Me.btn_total.BackColor = System.Drawing.Color.Green
        Me.btn_total.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_total.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btn_total.Location = New System.Drawing.Point(715, 465)
        Me.btn_total.Name = "btn_total"
        Me.btn_total.Size = New System.Drawing.Size(77, 28)
        Me.btn_total.TabIndex = 24
        Me.btn_total.Text = "Total"
        Me.btn_total.UseVisualStyleBackColor = False
        '
        'frm_addpatient
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(1166, 640)
        Me.Controls.Add(Me.btn_total)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btn_addDoctor)
        Me.Controls.Add(Me.btn_refresh)
        Me.Controls.Add(Me.btn_clear)
        Me.Controls.Add(Me.btn_delete)
        Me.Controls.Add(Me.btn_update)
        Me.Controls.Add(Me.btn_save)
        Me.Controls.Add(Me.TextBox7)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.TextBox6)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.TextBox5)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.ComboBox3)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.dgvData)
        Me.Controls.Add(Me.RadioButton2)
        Me.Controls.Add(Me.RadioButton1)
        Me.Controls.Add(Me.BTextbox6)
        Me.Controls.Add(Me.BTextbox5)
        Me.Controls.Add(Me.BTextbox4)
        Me.Controls.Add(Me.BTextbox2)
        Me.Controls.Add(Me.BTextbox1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.DTP1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btn_addgroup)
        Me.Controls.Add(Me.ComboBox2)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.Label7)
        Me.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frm_addpatient"
        Me.Text = "frm_addpatient"
        CType(Me.dgvData, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_addDoctor, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_addgroup, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents DTP1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents BTextbox1 As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents BTextbox2 As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents BTextbox4 As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents BTextbox5 As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents BTextbox6 As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton2 As System.Windows.Forms.RadioButton
    Friend WithEvents dgvData As System.Windows.Forms.DataGridView
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents ComboBox2 As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents ComboBox3 As System.Windows.Forms.ComboBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents TextBox5 As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents TextBox6 As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents TextBox7 As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents btn_save As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents btn_update As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents btn_clear As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents btn_delete As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents btn_addDoctor As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents btn_addgroup As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents btn_refresh As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents btn_total As System.Windows.Forms.Button
End Class
