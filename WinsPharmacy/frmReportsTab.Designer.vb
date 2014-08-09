<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReportsTab
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmReportsTab))
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.rdbSlow = New System.Windows.Forms.RadioButton()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.rdbFast = New System.Windows.Forms.RadioButton()
        Me.cbLogCat = New System.Windows.Forms.ComboBox()
        Me.cbCategory = New System.Windows.Forms.ComboBox()
        Me.dtpLogDate = New System.Windows.Forms.DateTimePicker()
        Me.rbUsersLog = New System.Windows.Forms.RadioButton()
        Me.btnGenGeneral = New System.Windows.Forms.Button()
        Me.rbUsers = New System.Windows.Forms.RadioButton()
        Me.rbSuppliers = New System.Windows.Forms.RadioButton()
        Me.rbProducts = New System.Windows.Forms.RadioButton()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.dtpSeniorStart = New System.Windows.Forms.DateTimePicker()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.dtpSeniorEnd = New System.Windows.Forms.DateTimePicker()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.dtpRetStart = New System.Windows.Forms.DateTimePicker()
        Me.btnGenReturns = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.dtpRetEnd = New System.Windows.Forms.DateTimePicker()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dtpStart = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dtpEnd = New System.Windows.Forms.DateTimePicker()
        Me.btnGenSales = New System.Windows.Forms.Button()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.btngenPurchase = New System.Windows.Forms.Button()
        Me.cbDelivered = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.dtpPurEnd = New System.Windows.Forms.DateTimePicker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.dtpPurStart = New System.Windows.Forms.DateTimePicker()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.dtpDeliveryStart = New System.Windows.Forms.DateTimePicker()
        Me.dtpDeliveryEnd = New System.Windows.Forms.DateTimePicker()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnGenInventory = New System.Windows.Forms.Button()
        Me.dtpInvEnd = New System.Windows.Forms.DateTimePicker()
        Me.dtpInvStart = New System.Windows.Forms.DateTimePicker()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.TabPage4.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Appearance = System.Windows.Forms.TabAppearance.FlatButtons
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage4)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl1.Location = New System.Drawing.Point(12, 22)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(495, 363)
        Me.TabControl1.TabIndex = 2
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.Transparent
        Me.TabPage1.BackgroundImage = CType(resources.GetObject("TabPage1.BackgroundImage"), System.Drawing.Image)
        Me.TabPage1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.TabPage1.Controls.Add(Me.rdbSlow)
        Me.TabPage1.Controls.Add(Me.DateTimePicker1)
        Me.TabPage1.Controls.Add(Me.DateTimePicker2)
        Me.TabPage1.Controls.Add(Me.Label16)
        Me.TabPage1.Controls.Add(Me.Label17)
        Me.TabPage1.Controls.Add(Me.rdbFast)
        Me.TabPage1.Controls.Add(Me.cbLogCat)
        Me.TabPage1.Controls.Add(Me.cbCategory)
        Me.TabPage1.Controls.Add(Me.dtpLogDate)
        Me.TabPage1.Controls.Add(Me.rbUsersLog)
        Me.TabPage1.Controls.Add(Me.btnGenGeneral)
        Me.TabPage1.Controls.Add(Me.rbUsers)
        Me.TabPage1.Controls.Add(Me.rbSuppliers)
        Me.TabPage1.Controls.Add(Me.rbProducts)
        Me.TabPage1.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabPage1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.TabPage1.Location = New System.Drawing.Point(4, 30)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(487, 329)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "GENERAL"
        '
        'rdbSlow
        '
        Me.rdbSlow.AutoSize = True
        Me.rdbSlow.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdbSlow.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.rdbSlow.Location = New System.Drawing.Point(43, 87)
        Me.rdbSlow.Name = "rdbSlow"
        Me.rdbSlow.Size = New System.Drawing.Size(199, 23)
        Me.rdbSlow.TabIndex = 183
        Me.rdbSlow.TabStop = True
        Me.rdbSlow.Text = "Slow moving products"
        Me.rdbSlow.UseVisualStyleBackColor = True
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(293, 87)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(78, 20)
        Me.DateTimePicker1.TabIndex = 182
        Me.DateTimePicker1.Visible = False
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker2.Location = New System.Drawing.Point(293, 63)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(78, 20)
        Me.DateTimePicker2.TabIndex = 181
        Me.DateTimePicker2.Visible = False
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.BackColor = System.Drawing.Color.Transparent
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.White
        Me.Label16.Location = New System.Drawing.Point(259, 94)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(28, 13)
        Me.Label16.TabIndex = 180
        Me.Label16.Text = "TO:"
        Me.Label16.Visible = False
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.BackColor = System.Drawing.Color.Transparent
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.White
        Me.Label17.Location = New System.Drawing.Point(247, 69)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(46, 13)
        Me.Label17.TabIndex = 179
        Me.Label17.Text = "FROM:"
        Me.Label17.Visible = False
        '
        'rdbFast
        '
        Me.rdbFast.AutoSize = True
        Me.rdbFast.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdbFast.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.rdbFast.Location = New System.Drawing.Point(43, 58)
        Me.rdbFast.Name = "rdbFast"
        Me.rdbFast.Size = New System.Drawing.Size(194, 23)
        Me.rdbFast.TabIndex = 8
        Me.rdbFast.TabStop = True
        Me.rdbFast.Text = "Fast moving products"
        Me.rdbFast.UseVisualStyleBackColor = True
        '
        'cbLogCat
        '
        Me.cbLogCat.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbLogCat.FormattingEnabled = True
        Me.cbLogCat.Items.AddRange(New Object() {"All", "Administrator", "Cashier"})
        Me.cbLogCat.Location = New System.Drawing.Point(211, 239)
        Me.cbLogCat.Name = "cbLogCat"
        Me.cbLogCat.Size = New System.Drawing.Size(160, 26)
        Me.cbLogCat.TabIndex = 7
        Me.cbLogCat.Text = "All"
        Me.cbLogCat.Visible = False
        '
        'cbCategory
        '
        Me.cbCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbCategory.FormattingEnabled = True
        Me.cbCategory.Items.AddRange(New Object() {"All"})
        Me.cbCategory.Location = New System.Drawing.Point(197, 20)
        Me.cbCategory.Name = "cbCategory"
        Me.cbCategory.Size = New System.Drawing.Size(147, 26)
        Me.cbCategory.TabIndex = 6
        Me.cbCategory.Text = "All"
        '
        'dtpLogDate
        '
        Me.dtpLogDate.CalendarMonthBackground = System.Drawing.Color.White
        Me.dtpLogDate.CalendarTrailingForeColor = System.Drawing.Color.Transparent
        Me.dtpLogDate.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpLogDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpLogDate.Location = New System.Drawing.Point(211, 208)
        Me.dtpLogDate.Name = "dtpLogDate"
        Me.dtpLogDate.Size = New System.Drawing.Size(160, 25)
        Me.dtpLogDate.TabIndex = 5
        Me.dtpLogDate.Visible = False
        '
        'rbUsersLog
        '
        Me.rbUsersLog.AutoSize = True
        Me.rbUsersLog.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbUsersLog.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.rbUsersLog.Location = New System.Drawing.Point(43, 208)
        Me.rbUsersLog.Name = "rbUsersLog"
        Me.rbUsersLog.Size = New System.Drawing.Size(162, 23)
        Me.rbUsersLog.TabIndex = 4
        Me.rbUsersLog.TabStop = True
        Me.rbUsersLog.Text = "Users Log Report"
        Me.rbUsersLog.UseVisualStyleBackColor = True
        '
        'btnGenGeneral
        '
        Me.btnGenGeneral.BackColor = System.Drawing.SystemColors.Control
        Me.btnGenGeneral.BackgroundImage = CType(resources.GetObject("btnGenGeneral.BackgroundImage"), System.Drawing.Image)
        Me.btnGenGeneral.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnGenGeneral.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGenGeneral.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnGenGeneral.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnGenGeneral.Location = New System.Drawing.Point(251, 293)
        Me.btnGenGeneral.Name = "btnGenGeneral"
        Me.btnGenGeneral.Size = New System.Drawing.Size(120, 30)
        Me.btnGenGeneral.TabIndex = 3
        Me.btnGenGeneral.Text = "Generate"
        Me.btnGenGeneral.UseVisualStyleBackColor = False
        '
        'rbUsers
        '
        Me.rbUsers.AutoSize = True
        Me.rbUsers.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbUsers.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.rbUsers.Location = New System.Drawing.Point(43, 166)
        Me.rbUsers.Name = "rbUsers"
        Me.rbUsers.Size = New System.Drawing.Size(184, 23)
        Me.rbUsers.TabIndex = 2
        Me.rbUsers.TabStop = True
        Me.rbUsers.Text = "List of System Users"
        Me.rbUsers.UseVisualStyleBackColor = True
        '
        'rbSuppliers
        '
        Me.rbSuppliers.AutoSize = True
        Me.rbSuppliers.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbSuppliers.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.rbSuppliers.Location = New System.Drawing.Point(43, 125)
        Me.rbSuppliers.Name = "rbSuppliers"
        Me.rbSuppliers.Size = New System.Drawing.Size(151, 23)
        Me.rbSuppliers.TabIndex = 1
        Me.rbSuppliers.TabStop = True
        Me.rbSuppliers.Text = "List of Suppliers"
        Me.rbSuppliers.UseVisualStyleBackColor = True
        '
        'rbProducts
        '
        Me.rbProducts.AutoSize = True
        Me.rbProducts.Checked = True
        Me.rbProducts.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbProducts.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.rbProducts.Location = New System.Drawing.Point(43, 23)
        Me.rbProducts.Name = "rbProducts"
        Me.rbProducts.Size = New System.Drawing.Size(148, 23)
        Me.rbProducts.TabIndex = 0
        Me.rbProducts.TabStop = True
        Me.rbProducts.Text = "List of Products"
        Me.rbProducts.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.Transparent
        Me.TabPage2.BackgroundImage = CType(resources.GetObject("TabPage2.BackgroundImage"), System.Drawing.Image)
        Me.TabPage2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.TabPage2.Controls.Add(Me.GroupBox3)
        Me.TabPage2.Controls.Add(Me.GroupBox2)
        Me.TabPage2.Controls.Add(Me.GroupBox1)
        Me.TabPage2.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabPage2.Location = New System.Drawing.Point(4, 30)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(487, 329)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Sales Report"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label11)
        Me.GroupBox3.Controls.Add(Me.dtpSeniorStart)
        Me.GroupBox3.Controls.Add(Me.Button2)
        Me.GroupBox3.Controls.Add(Me.Label14)
        Me.GroupBox3.Controls.Add(Me.dtpSeniorEnd)
        Me.GroupBox3.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.GroupBox3.Location = New System.Drawing.Point(19, 223)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(445, 94)
        Me.GroupBox3.TabIndex = 16
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Senior Citizen Monitoring"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(26, 29)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(52, 18)
        Me.Label11.TabIndex = 10
        Me.Label11.Text = "From :"
        '
        'dtpSeniorStart
        '
        Me.dtpSeniorStart.CalendarTrailingForeColor = System.Drawing.Color.Transparent
        Me.dtpSeniorStart.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpSeniorStart.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpSeniorStart.Location = New System.Drawing.Point(84, 22)
        Me.dtpSeniorStart.Name = "dtpSeniorStart"
        Me.dtpSeniorStart.Size = New System.Drawing.Size(157, 25)
        Me.dtpSeniorStart.TabIndex = 7
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.SystemColors.Control
        Me.Button2.BackgroundImage = CType(resources.GetObject("Button2.BackgroundImage"), System.Drawing.Image)
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button2.Location = New System.Drawing.Point(302, 50)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(120, 30)
        Me.Button2.TabIndex = 9
        Me.Button2.Text = "Generate"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(44, 56)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(34, 18)
        Me.Label14.TabIndex = 11
        Me.Label14.Text = "To :"
        '
        'dtpSeniorEnd
        '
        Me.dtpSeniorEnd.CalendarTrailingForeColor = System.Drawing.Color.Transparent
        Me.dtpSeniorEnd.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpSeniorEnd.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpSeniorEnd.Location = New System.Drawing.Point(84, 54)
        Me.dtpSeniorEnd.Name = "dtpSeniorEnd"
        Me.dtpSeniorEnd.Size = New System.Drawing.Size(157, 25)
        Me.dtpSeniorEnd.TabIndex = 8
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.dtpRetStart)
        Me.GroupBox2.Controls.Add(Me.btnGenReturns)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.dtpRetEnd)
        Me.GroupBox2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.GroupBox2.Location = New System.Drawing.Point(19, 123)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(445, 94)
        Me.GroupBox2.TabIndex = 15
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Sales Returns"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(26, 29)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(52, 18)
        Me.Label10.TabIndex = 10
        Me.Label10.Text = "From :"
        '
        'dtpRetStart
        '
        Me.dtpRetStart.CalendarTrailingForeColor = System.Drawing.Color.Transparent
        Me.dtpRetStart.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpRetStart.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpRetStart.Location = New System.Drawing.Point(84, 22)
        Me.dtpRetStart.Name = "dtpRetStart"
        Me.dtpRetStart.Size = New System.Drawing.Size(157, 25)
        Me.dtpRetStart.TabIndex = 7
        '
        'btnGenReturns
        '
        Me.btnGenReturns.BackColor = System.Drawing.SystemColors.Control
        Me.btnGenReturns.BackgroundImage = CType(resources.GetObject("btnGenReturns.BackgroundImage"), System.Drawing.Image)
        Me.btnGenReturns.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnGenReturns.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGenReturns.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnGenReturns.Location = New System.Drawing.Point(302, 50)
        Me.btnGenReturns.Name = "btnGenReturns"
        Me.btnGenReturns.Size = New System.Drawing.Size(120, 30)
        Me.btnGenReturns.TabIndex = 9
        Me.btnGenReturns.Text = "Generate"
        Me.btnGenReturns.UseVisualStyleBackColor = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(44, 56)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(34, 18)
        Me.Label8.TabIndex = 11
        Me.Label8.Text = "To :"
        '
        'dtpRetEnd
        '
        Me.dtpRetEnd.CalendarTrailingForeColor = System.Drawing.Color.Transparent
        Me.dtpRetEnd.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpRetEnd.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpRetEnd.Location = New System.Drawing.Point(84, 54)
        Me.dtpRetEnd.Name = "dtpRetEnd"
        Me.dtpRetEnd.Size = New System.Drawing.Size(157, 25)
        Me.dtpRetEnd.TabIndex = 8
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.dtpStart)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.dtpEnd)
        Me.GroupBox1.Controls.Add(Me.btnGenSales)
        Me.GroupBox1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.GroupBox1.Location = New System.Drawing.Point(19, 16)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(445, 100)
        Me.GroupBox1.TabIndex = 14
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Sales Transactions"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(26, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(52, 18)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "From :"
        '
        'dtpStart
        '
        Me.dtpStart.CalendarTrailingForeColor = System.Drawing.Color.Transparent
        Me.dtpStart.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpStart.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpStart.Location = New System.Drawing.Point(84, 23)
        Me.dtpStart.Name = "dtpStart"
        Me.dtpStart.Size = New System.Drawing.Size(157, 25)
        Me.dtpStart.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(44, 60)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(34, 18)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "To :"
        '
        'dtpEnd
        '
        Me.dtpEnd.CalendarTrailingForeColor = System.Drawing.Color.Transparent
        Me.dtpEnd.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpEnd.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpEnd.Location = New System.Drawing.Point(84, 54)
        Me.dtpEnd.Name = "dtpEnd"
        Me.dtpEnd.Size = New System.Drawing.Size(157, 25)
        Me.dtpEnd.TabIndex = 1
        '
        'btnGenSales
        '
        Me.btnGenSales.BackColor = System.Drawing.SystemColors.Control
        Me.btnGenSales.BackgroundImage = CType(resources.GetObject("btnGenSales.BackgroundImage"), System.Drawing.Image)
        Me.btnGenSales.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnGenSales.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGenSales.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnGenSales.Location = New System.Drawing.Point(302, 54)
        Me.btnGenSales.Name = "btnGenSales"
        Me.btnGenSales.Size = New System.Drawing.Size(120, 30)
        Me.btnGenSales.TabIndex = 4
        Me.btnGenSales.Text = "Generate"
        Me.btnGenSales.UseVisualStyleBackColor = False
        '
        'TabPage4
        '
        Me.TabPage4.BackColor = System.Drawing.Color.Transparent
        Me.TabPage4.BackgroundImage = CType(resources.GetObject("TabPage4.BackgroundImage"), System.Drawing.Image)
        Me.TabPage4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.TabPage4.Controls.Add(Me.GroupBox4)
        Me.TabPage4.Controls.Add(Me.GroupBox5)
        Me.TabPage4.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabPage4.Location = New System.Drawing.Point(4, 30)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage4.Size = New System.Drawing.Size(487, 329)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "Purchase Report"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.btngenPurchase)
        Me.GroupBox4.Controls.Add(Me.cbDelivered)
        Me.GroupBox4.Controls.Add(Me.Label7)
        Me.GroupBox4.Controls.Add(Me.dtpPurEnd)
        Me.GroupBox4.Controls.Add(Me.Label5)
        Me.GroupBox4.Controls.Add(Me.dtpPurStart)
        Me.GroupBox4.Controls.Add(Me.Label6)
        Me.GroupBox4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.GroupBox4.Location = New System.Drawing.Point(20, 22)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(451, 133)
        Me.GroupBox4.TabIndex = 30
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Purchase Reports"
        '
        'btngenPurchase
        '
        Me.btngenPurchase.BackColor = System.Drawing.SystemColors.Control
        Me.btngenPurchase.BackgroundImage = CType(resources.GetObject("btngenPurchase.BackgroundImage"), System.Drawing.Image)
        Me.btngenPurchase.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btngenPurchase.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btngenPurchase.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btngenPurchase.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btngenPurchase.Location = New System.Drawing.Point(316, 89)
        Me.btngenPurchase.Name = "btngenPurchase"
        Me.btngenPurchase.Size = New System.Drawing.Size(120, 30)
        Me.btngenPurchase.TabIndex = 9
        Me.btngenPurchase.Text = "Generate"
        Me.btngenPurchase.UseVisualStyleBackColor = False
        '
        'cbDelivered
        '
        Me.cbDelivered.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbDelivered.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbDelivered.FormattingEnabled = True
        Me.cbDelivered.Items.AddRange(New Object() {"YES", "NO"})
        Me.cbDelivered.Location = New System.Drawing.Point(105, 91)
        Me.cbDelivered.Name = "cbDelivered"
        Me.cbDelivered.Size = New System.Drawing.Size(185, 28)
        Me.cbDelivered.TabIndex = 12
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(17, 97)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(82, 18)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Delivered:"
        '
        'dtpPurEnd
        '
        Me.dtpPurEnd.CalendarTrailingForeColor = System.Drawing.Color.Transparent
        Me.dtpPurEnd.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpPurEnd.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpPurEnd.Location = New System.Drawing.Point(105, 60)
        Me.dtpPurEnd.Name = "dtpPurEnd"
        Me.dtpPurEnd.Size = New System.Drawing.Size(185, 25)
        Me.dtpPurEnd.TabIndex = 8
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(65, 66)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(34, 18)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "To :"
        '
        'dtpPurStart
        '
        Me.dtpPurStart.CalendarTrailingForeColor = System.Drawing.Color.Transparent
        Me.dtpPurStart.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpPurStart.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpPurStart.Location = New System.Drawing.Point(105, 22)
        Me.dtpPurStart.Name = "dtpPurStart"
        Me.dtpPurStart.Size = New System.Drawing.Size(185, 25)
        Me.dtpPurStart.TabIndex = 7
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(47, 29)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(52, 18)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "From :"
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.Label12)
        Me.GroupBox5.Controls.Add(Me.Label13)
        Me.GroupBox5.Controls.Add(Me.dtpDeliveryStart)
        Me.GroupBox5.Controls.Add(Me.dtpDeliveryEnd)
        Me.GroupBox5.Controls.Add(Me.Button1)
        Me.GroupBox5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.GroupBox5.Location = New System.Drawing.Point(20, 176)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(451, 116)
        Me.GroupBox5.TabIndex = 31
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Delivery Logs"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label12.Location = New System.Drawing.Point(65, 76)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(34, 18)
        Me.Label12.TabIndex = 26
        Me.Label12.Text = "To :"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label13.Location = New System.Drawing.Point(47, 41)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(52, 18)
        Me.Label13.TabIndex = 25
        Me.Label13.Text = "From :"
        '
        'dtpDeliveryStart
        '
        Me.dtpDeliveryStart.CalendarTrailingForeColor = System.Drawing.Color.Transparent
        Me.dtpDeliveryStart.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpDeliveryStart.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpDeliveryStart.Location = New System.Drawing.Point(105, 35)
        Me.dtpDeliveryStart.Name = "dtpDeliveryStart"
        Me.dtpDeliveryStart.Size = New System.Drawing.Size(185, 25)
        Me.dtpDeliveryStart.TabIndex = 22
        '
        'dtpDeliveryEnd
        '
        Me.dtpDeliveryEnd.CalendarTrailingForeColor = System.Drawing.Color.Transparent
        Me.dtpDeliveryEnd.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpDeliveryEnd.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpDeliveryEnd.Location = New System.Drawing.Point(105, 70)
        Me.dtpDeliveryEnd.Name = "dtpDeliveryEnd"
        Me.dtpDeliveryEnd.Size = New System.Drawing.Size(185, 25)
        Me.dtpDeliveryEnd.TabIndex = 23
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.Control
        Me.Button1.BackgroundImage = CType(resources.GetObject("Button1.BackgroundImage"), System.Drawing.Image)
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(316, 70)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(120, 30)
        Me.Button1.TabIndex = 24
        Me.Button1.Text = "Generate"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'TabPage3
        '
        Me.TabPage3.BackColor = System.Drawing.Color.Transparent
        Me.TabPage3.BackgroundImage = CType(resources.GetObject("TabPage3.BackgroundImage"), System.Drawing.Image)
        Me.TabPage3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.TabPage3.Controls.Add(Me.GroupBox6)
        Me.TabPage3.Location = New System.Drawing.Point(4, 30)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(487, 329)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Inventory Report"
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.Label3)
        Me.GroupBox6.Controls.Add(Me.Label4)
        Me.GroupBox6.Controls.Add(Me.btnGenInventory)
        Me.GroupBox6.Controls.Add(Me.dtpInvEnd)
        Me.GroupBox6.Controls.Add(Me.dtpInvStart)
        Me.GroupBox6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.GroupBox6.Location = New System.Drawing.Point(34, 70)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(427, 142)
        Me.GroupBox6.TabIndex = 24
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Running Inventory"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(31, 92)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(34, 18)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "To :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(13, 53)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(52, 18)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "From :"
        '
        'btnGenInventory
        '
        Me.btnGenInventory.BackColor = System.Drawing.SystemColors.Control
        Me.btnGenInventory.BackgroundImage = CType(resources.GetObject("btnGenInventory.BackgroundImage"), System.Drawing.Image)
        Me.btnGenInventory.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnGenInventory.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGenInventory.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnGenInventory.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnGenInventory.Location = New System.Drawing.Point(292, 80)
        Me.btnGenInventory.Name = "btnGenInventory"
        Me.btnGenInventory.Size = New System.Drawing.Size(120, 30)
        Me.btnGenInventory.TabIndex = 9
        Me.btnGenInventory.Text = "Generate"
        Me.btnGenInventory.UseVisualStyleBackColor = False
        '
        'dtpInvEnd
        '
        Me.dtpInvEnd.CalendarTrailingForeColor = System.Drawing.Color.Transparent
        Me.dtpInvEnd.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpInvEnd.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpInvEnd.Location = New System.Drawing.Point(71, 86)
        Me.dtpInvEnd.Name = "dtpInvEnd"
        Me.dtpInvEnd.Size = New System.Drawing.Size(192, 25)
        Me.dtpInvEnd.TabIndex = 8
        '
        'dtpInvStart
        '
        Me.dtpInvStart.CalendarTrailingForeColor = System.Drawing.Color.Transparent
        Me.dtpInvStart.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpInvStart.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpInvStart.Location = New System.Drawing.Point(71, 46)
        Me.dtpInvStart.Name = "dtpInvStart"
        Me.dtpInvStart.Size = New System.Drawing.Size(192, 25)
        Me.dtpInvStart.TabIndex = 7
        '
        'frmReportsTab
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(525, 416)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "frmReportsTab"
        Me.Text = "Reports Tab"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.TabPage4.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.TabPage3.ResumeLayout(False)
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents dtpLogDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents rbUsersLog As System.Windows.Forms.RadioButton
    Friend WithEvents btnGenGeneral As System.Windows.Forms.Button
    Friend WithEvents rbUsers As System.Windows.Forms.RadioButton
    Friend WithEvents rbSuppliers As System.Windows.Forms.RadioButton
    Friend WithEvents rbProducts As System.Windows.Forms.RadioButton
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents dtpRetStart As System.Windows.Forms.DateTimePicker
    Friend WithEvents btnGenReturns As System.Windows.Forms.Button
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents dtpRetEnd As System.Windows.Forms.DateTimePicker
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dtpStart As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents dtpEnd As System.Windows.Forms.DateTimePicker
    Friend WithEvents btnGenSales As System.Windows.Forms.Button
    Friend WithEvents TabPage4 As System.Windows.Forms.TabPage
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents cbDelivered As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents btngenPurchase As System.Windows.Forms.Button
    Friend WithEvents dtpPurEnd As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpPurStart As System.Windows.Forms.DateTimePicker
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btnGenInventory As System.Windows.Forms.Button
    Friend WithEvents dtpInvEnd As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpInvStart As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents dtpDeliveryEnd As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpDeliveryStart As System.Windows.Forms.DateTimePicker
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents dtpSeniorStart As System.Windows.Forms.DateTimePicker
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents dtpSeniorEnd As System.Windows.Forms.DateTimePicker
    Friend WithEvents cbCategory As System.Windows.Forms.ComboBox
    Friend WithEvents cbLogCat As System.Windows.Forms.ComboBox
    Friend WithEvents rdbFast As System.Windows.Forms.RadioButton
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents DateTimePicker2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents rdbSlow As System.Windows.Forms.RadioButton
End Class
