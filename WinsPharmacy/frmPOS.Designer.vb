<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPOS
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPOS))
        Me.PrintReceipt = New System.Drawing.Printing.PrintDocument()
        Me.lblVATable = New System.Windows.Forms.Label()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Label13 = New System.Windows.Forms.Label()
        Me.lblVatName = New System.Windows.Forms.Label()
        Me.lblVat = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.rdbNonSenior = New System.Windows.Forms.RadioButton()
        Me.rdbSenior = New System.Windows.Forms.RadioButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.btnViewClients = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtSenID = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtCustName = New System.Windows.Forms.TextBox()
        Me.lblItemName = New System.Windows.Forms.Label()
        Me.lvItems = New System.Windows.Forms.ListView()
        Me.btnProducts = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.lblUserID = New System.Windows.Forms.Label()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.lblType = New System.Windows.Forms.Label()
        Me.lblFullname = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblChange = New System.Windows.Forms.Label()
        Me.txtCode = New System.Windows.Forms.TextBox()
        Me.lblTotalAmount = New System.Windows.Forms.Label()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.lblTotalDue = New System.Windows.Forms.Label()
        Me.lblTime = New System.Windows.Forms.Label()
        Me.lblDateToday = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnRemoveItem = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblDiscount = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtCashAmount = New System.Windows.Forms.TextBox()
        Me.btnTransact = New System.Windows.Forms.Button()
        Me.LinkLabel2 = New System.Windows.Forms.LinkLabel()
        Me.lblDiscountSign = New System.Windows.Forms.Label()
        Me.lblDiscLbl = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.chkDiscount = New System.Windows.Forms.CheckBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.chkMulti = New System.Windows.Forms.CheckBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.lblPrice = New System.Windows.Forms.Label()
        Me.btnGo = New System.Windows.Forms.Button()
        Me.lblOriginal = New System.Windows.Forms.Label()
        Me.chkWithDiscount = New System.Windows.Forms.CheckBox()
        Me.tmrTime = New System.Windows.Forms.Timer(Me.components)
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblVATable
        '
        Me.lblVATable.BackColor = System.Drawing.Color.Transparent
        Me.lblVATable.Font = New System.Drawing.Font("Segoe UI Symbol", 22.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVATable.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblVATable.Location = New System.Drawing.Point(920, 446)
        Me.lblVATable.Name = "lblVATable"
        Me.lblVATable.Size = New System.Drawing.Size(112, 40)
        Me.lblVATable.TabIndex = 174
        Me.lblVATable.Text = "0.00"
        Me.lblVATable.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Code"
        Me.ColumnHeader1.Width = 115
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Item "
        Me.ColumnHeader2.Width = 186
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Quantity"
        Me.ColumnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader3.Width = 85
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Font = New System.Drawing.Font("Segoe UI Symbol", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label13.Location = New System.Drawing.Point(811, 432)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(82, 25)
        Me.Label13.TabIndex = 175
        Me.Label13.Text = "VATable"
        '
        'lblVatName
        '
        Me.lblVatName.AutoSize = True
        Me.lblVatName.BackColor = System.Drawing.Color.Transparent
        Me.lblVatName.Font = New System.Drawing.Font("Segoe UI Symbol", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVatName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblVatName.Location = New System.Drawing.Point(812, 484)
        Me.lblVatName.Name = "lblVatName"
        Me.lblVatName.Size = New System.Drawing.Size(82, 25)
        Me.lblVatName.TabIndex = 171
        Me.lblVatName.Text = "12%VAT"
        '
        'lblVat
        '
        Me.lblVat.BackColor = System.Drawing.Color.Transparent
        Me.lblVat.Font = New System.Drawing.Font("Segoe UI Symbol", 22.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVat.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblVat.Location = New System.Drawing.Point(898, 513)
        Me.lblVat.Name = "lblVat"
        Me.lblVat.Size = New System.Drawing.Size(134, 33)
        Me.lblVat.TabIndex = 170
        Me.lblVat.Text = "0.00"
        Me.lblVat.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Segoe UI Symbol", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label10.Location = New System.Drawing.Point(807, 549)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(138, 37)
        Me.Label10.TabIndex = 167
        Me.Label10.Text = "Total Due:"
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Price"
        Me.ColumnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader4.Width = 118
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Subtotal"
        Me.ColumnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader5.Width = 133
        '
        'rdbNonSenior
        '
        Me.rdbNonSenior.AutoSize = True
        Me.rdbNonSenior.Checked = True
        Me.rdbNonSenior.ForeColor = System.Drawing.Color.White
        Me.rdbNonSenior.Location = New System.Drawing.Point(6, 30)
        Me.rdbNonSenior.Name = "rdbNonSenior"
        Me.rdbNonSenior.Size = New System.Drawing.Size(129, 19)
        Me.rdbNonSenior.TabIndex = 131
        Me.rdbNonSenior.TabStop = True
        Me.rdbNonSenior.Text = "Non-Senior Citizen"
        Me.rdbNonSenior.UseVisualStyleBackColor = True
        '
        'rdbSenior
        '
        Me.rdbSenior.AutoSize = True
        Me.rdbSenior.ForeColor = System.Drawing.Color.White
        Me.rdbSenior.Location = New System.Drawing.Point(6, 55)
        Me.rdbSenior.Name = "rdbSenior"
        Me.rdbSenior.Size = New System.Drawing.Size(103, 19)
        Me.rdbSenior.TabIndex = 132
        Me.rdbSenior.Text = "Senior Citizen"
        Me.rdbSenior.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.rdbSenior)
        Me.GroupBox2.Controls.Add(Me.rdbNonSenior)
        Me.GroupBox2.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GroupBox2.Location = New System.Drawing.Point(232, 62)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(141, 89)
        Me.GroupBox2.TabIndex = 182
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Mode of Payment"
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox3.Controls.Add(Me.btnViewClients)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.txtSenID)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.txtCustName)
        Me.GroupBox3.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GroupBox3.Location = New System.Drawing.Point(379, 23)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(286, 128)
        Me.GroupBox3.TabIndex = 166
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Senior Citizen Information"
        '
        'btnViewClients
        '
        Me.btnViewClients.BackgroundImage = CType(resources.GetObject("btnViewClients.BackgroundImage"), System.Drawing.Image)
        Me.btnViewClients.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnViewClients.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnViewClients.Location = New System.Drawing.Point(252, 42)
        Me.btnViewClients.Name = "btnViewClients"
        Me.btnViewClients.Size = New System.Drawing.Size(25, 21)
        Me.btnViewClients.TabIndex = 194
        Me.btnViewClients.Text = "..."
        Me.btnViewClients.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnViewClients.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(6, 68)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(101, 15)
        Me.Label3.TabIndex = 193
        Me.Label3.Text = "Senior Citizen ID:"
        '
        'txtSenID
        '
        Me.txtSenID.Enabled = False
        Me.txtSenID.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSenID.Location = New System.Drawing.Point(27, 86)
        Me.txtSenID.Name = "txtSenID"
        Me.txtSenID.Size = New System.Drawing.Size(219, 25)
        Me.txtSenID.TabIndex = 192
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(6, 21)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(102, 15)
        Me.Label2.TabIndex = 191
        Me.Label2.Text = "Customer Name:"
        '
        'txtCustName
        '
        Me.txtCustName.Enabled = False
        Me.txtCustName.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCustName.Location = New System.Drawing.Point(27, 39)
        Me.txtCustName.Name = "txtCustName"
        Me.txtCustName.Size = New System.Drawing.Size(219, 25)
        Me.txtCustName.TabIndex = 0
        '
        'lblItemName
        '
        Me.lblItemName.BackColor = System.Drawing.Color.Transparent
        Me.lblItemName.Font = New System.Drawing.Font("Segoe UI Symbol", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblItemName.ForeColor = System.Drawing.Color.White
        Me.lblItemName.Location = New System.Drawing.Point(80, 68)
        Me.lblItemName.Name = "lblItemName"
        Me.lblItemName.Size = New System.Drawing.Size(150, 36)
        Me.lblItemName.TabIndex = 148
        Me.lblItemName.Text = "Item Name"
        '
        'lvItems
        '
        Me.lvItems.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5})
        Me.lvItems.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvItems.FullRowSelect = True
        Me.lvItems.GridLines = True
        Me.lvItems.Location = New System.Drawing.Point(21, 171)
        Me.lvItems.Name = "lvItems"
        Me.lvItems.Size = New System.Drawing.Size(644, 316)
        Me.lvItems.TabIndex = 146
        Me.lvItems.UseCompatibleStateImageBehavior = False
        Me.lvItems.View = System.Windows.Forms.View.Details
        '
        'btnProducts
        '
        Me.btnProducts.BackgroundImage = CType(resources.GetObject("btnProducts.BackgroundImage"), System.Drawing.Image)
        Me.btnProducts.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnProducts.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnProducts.Location = New System.Drawing.Point(353, 24)
        Me.btnProducts.Name = "btnProducts"
        Me.btnProducts.Size = New System.Drawing.Size(25, 21)
        Me.btnProducts.TabIndex = 161
        Me.btnProducts.Text = "..."
        Me.btnProducts.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnProducts.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 10
        '
        'lblUserID
        '
        Me.lblUserID.AutoSize = True
        Me.lblUserID.BackColor = System.Drawing.Color.Transparent
        Me.lblUserID.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUserID.Location = New System.Drawing.Point(10, 617)
        Me.lblUserID.Name = "lblUserID"
        Me.lblUserID.Size = New System.Drawing.Size(39, 14)
        Me.lblUserID.TabIndex = 160
        Me.lblUserID.Text = "UserID"
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.BackColor = System.Drawing.Color.Transparent
        Me.LinkLabel1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel1.LinkColor = System.Drawing.Color.Red
        Me.LinkLabel1.Location = New System.Drawing.Point(9, 675)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(71, 16)
        Me.LinkLabel1.TabIndex = 159
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "SIGN OUT"
        '
        'lblType
        '
        Me.lblType.AutoSize = True
        Me.lblType.BackColor = System.Drawing.Color.Transparent
        Me.lblType.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblType.Location = New System.Drawing.Point(10, 598)
        Me.lblType.Name = "lblType"
        Me.lblType.Size = New System.Drawing.Size(54, 14)
        Me.lblType.TabIndex = 158
        Me.lblType.Text = "User type"
        '
        'lblFullname
        '
        Me.lblFullname.AutoSize = True
        Me.lblFullname.BackColor = System.Drawing.Color.Transparent
        Me.lblFullname.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFullname.Location = New System.Drawing.Point(10, 582)
        Me.lblFullname.Name = "lblFullname"
        Me.lblFullname.Size = New System.Drawing.Size(81, 14)
        Me.lblFullname.TabIndex = 157
        Me.lblFullname.Text = "Name of user"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(28, 154)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(153, 14)
        Me.Label7.TabIndex = 156
        Me.Label7.Text = "(Double-click to edit quantity)"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(23, 25)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(56, 19)
        Me.Label4.TabIndex = 153
        Me.Label4.Text = "Code:"
        '
        'lblChange
        '
        Me.lblChange.AutoSize = True
        Me.lblChange.BackColor = System.Drawing.Color.Transparent
        Me.lblChange.Font = New System.Drawing.Font("Segoe UI Symbol", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblChange.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblChange.Location = New System.Drawing.Point(554, 526)
        Me.lblChange.Name = "lblChange"
        Me.lblChange.Size = New System.Drawing.Size(71, 40)
        Me.lblChange.TabIndex = 152
        Me.lblChange.Text = "0.00"
        '
        'txtCode
        '
        Me.txtCode.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCode.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCode.Location = New System.Drawing.Point(85, 20)
        Me.txtCode.Name = "txtCode"
        Me.txtCode.Size = New System.Drawing.Size(262, 25)
        Me.txtCode.TabIndex = 145
        '
        'lblTotalAmount
        '
        Me.lblTotalAmount.BackColor = System.Drawing.Color.Transparent
        Me.lblTotalAmount.Font = New System.Drawing.Font("Arial", 22.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalAmount.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblTotalAmount.Location = New System.Drawing.Point(807, 334)
        Me.lblTotalAmount.Name = "lblTotalAmount"
        Me.lblTotalAmount.Size = New System.Drawing.Size(227, 55)
        Me.lblTotalAmount.TabIndex = 147
        Me.lblTotalAmount.Text = "0.00"
        Me.lblTotalAmount.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'PrintPreviewDialog1
        '
        Me.PrintPreviewDialog1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog1.Enabled = True
        Me.PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        Me.PrintPreviewDialog1.Visible = False
        '
        'Timer2
        '
        Me.Timer2.Enabled = True
        '
        'lblTotalDue
        '
        Me.lblTotalDue.BackColor = System.Drawing.Color.Transparent
        Me.lblTotalDue.Font = New System.Drawing.Font("Segoe UI Symbol", 37.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalDue.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblTotalDue.Location = New System.Drawing.Point(846, 587)
        Me.lblTotalDue.Name = "lblTotalDue"
        Me.lblTotalDue.Size = New System.Drawing.Size(194, 72)
        Me.lblTotalDue.TabIndex = 183
        Me.lblTotalDue.Text = "0.00"
        Me.lblTotalDue.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblTime
        '
        Me.lblTime.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblTime.AutoSize = True
        Me.lblTime.BackColor = System.Drawing.Color.Transparent
        Me.lblTime.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTime.ForeColor = System.Drawing.Color.White
        Me.lblTime.Location = New System.Drawing.Point(27, 73)
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(66, 24)
        Me.lblTime.TabIndex = 192
        Me.lblTime.Text = "Time:"
        '
        'lblDateToday
        '
        Me.lblDateToday.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblDateToday.AutoSize = True
        Me.lblDateToday.BackColor = System.Drawing.Color.Transparent
        Me.lblDateToday.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDateToday.ForeColor = System.Drawing.Color.White
        Me.lblDateToday.Location = New System.Drawing.Point(27, 23)
        Me.lblDateToday.Name = "lblDateToday"
        Me.lblDateToday.Size = New System.Drawing.Size(129, 24)
        Me.lblDateToday.TabIndex = 191
        Me.lblDateToday.Text = "Date Today:"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.btnReset)
        Me.GroupBox1.Controls.Add(Me.btnRemoveItem)
        Me.GroupBox1.Controls.Add(Me.lblItemName)
        Me.GroupBox1.Controls.Add(Me.btnProducts)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtCode)
        Me.GroupBox1.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GroupBox1.Location = New System.Drawing.Point(686, 23)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(397, 262)
        Me.GroupBox1.TabIndex = 193
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Item Information"
        '
        'btnReset
        '
        Me.btnReset.BackgroundImage = CType(resources.GetObject("btnReset.BackgroundImage"), System.Drawing.Image)
        Me.btnReset.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReset.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnReset.Location = New System.Drawing.Point(261, 215)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(130, 35)
        Me.btnReset.TabIndex = 172
        Me.btnReset.Text = "Reset"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'btnRemoveItem
        '
        Me.btnRemoveItem.BackgroundImage = CType(resources.GetObject("btnRemoveItem.BackgroundImage"), System.Drawing.Image)
        Me.btnRemoveItem.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRemoveItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnRemoveItem.Location = New System.Drawing.Point(127, 215)
        Me.btnRemoveItem.Name = "btnRemoveItem"
        Me.btnRemoveItem.Size = New System.Drawing.Size(130, 35)
        Me.btnRemoveItem.TabIndex = 171
        Me.btnRemoveItem.Text = "Remove"
        Me.btnRemoveItem.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Symbol", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(812, 370)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(95, 30)
        Me.Label1.TabIndex = 194
        Me.Label1.Text = "Discount"
        '
        'lblDiscount
        '
        Me.lblDiscount.BackColor = System.Drawing.Color.Transparent
        Me.lblDiscount.Font = New System.Drawing.Font("Segoe UI Symbol", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDiscount.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblDiscount.Location = New System.Drawing.Point(838, 400)
        Me.lblDiscount.Name = "lblDiscount"
        Me.lblDiscount.Size = New System.Drawing.Size(194, 32)
        Me.lblDiscount.TabIndex = 195
        Me.lblDiscount.Text = "0.00"
        Me.lblDiscount.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Segoe UI Symbol", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(809, 304)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(144, 30)
        Me.Label8.TabIndex = 196
        Me.Label8.Text = "Total Amount"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Segoe UI Symbol", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(26, 491)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(156, 30)
        Me.Label5.TabIndex = 197
        Me.Label5.Text = "Cash Tendered:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Segoe UI Symbol", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(475, 491)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(89, 30)
        Me.Label6.TabIndex = 198
        Me.Label6.Text = "Change:"
        '
        'txtCashAmount
        '
        Me.txtCashAmount.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCashAmount.Location = New System.Drawing.Point(30, 523)
        Me.txtCashAmount.Name = "txtCashAmount"
        Me.txtCashAmount.Size = New System.Drawing.Size(263, 47)
        Me.txtCashAmount.TabIndex = 202
        '
        'btnTransact
        '
        Me.btnTransact.BackgroundImage = CType(resources.GetObject("btnTransact.BackgroundImage"), System.Drawing.Image)
        Me.btnTransact.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTransact.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnTransact.Location = New System.Drawing.Point(297, 534)
        Me.btnTransact.Name = "btnTransact"
        Me.btnTransact.Size = New System.Drawing.Size(130, 35)
        Me.btnTransact.TabIndex = 203
        Me.btnTransact.Text = "Transact"
        Me.btnTransact.UseVisualStyleBackColor = True
        '
        'LinkLabel2
        '
        Me.LinkLabel2.AutoSize = True
        Me.LinkLabel2.BackColor = System.Drawing.Color.Transparent
        Me.LinkLabel2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel2.LinkColor = System.Drawing.Color.Red
        Me.LinkLabel2.Location = New System.Drawing.Point(9, 643)
        Me.LinkLabel2.Name = "LinkLabel2"
        Me.LinkLabel2.Size = New System.Drawing.Size(71, 16)
        Me.LinkLabel2.TabIndex = 204
        Me.LinkLabel2.TabStop = True
        Me.LinkLabel2.Text = "SIGN OUT"
        '
        'lblDiscountSign
        '
        Me.lblDiscountSign.AutoSize = True
        Me.lblDiscountSign.BackColor = System.Drawing.Color.Transparent
        Me.lblDiscountSign.Font = New System.Drawing.Font("Arial", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.lblDiscountSign.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.lblDiscountSign.Location = New System.Drawing.Point(349, 259)
        Me.lblDiscountSign.Name = "lblDiscountSign"
        Me.lblDiscountSign.Size = New System.Drawing.Size(131, 18)
        Me.lblDiscountSign.TabIndex = 179
        Me.lblDiscountSign.Text = "Discounted total"
        Me.lblDiscountSign.Visible = False
        '
        'lblDiscLbl
        '
        Me.lblDiscLbl.AutoSize = True
        Me.lblDiscLbl.BackColor = System.Drawing.Color.Transparent
        Me.lblDiscLbl.Font = New System.Drawing.Font("Arial", 14.0!)
        Me.lblDiscLbl.Location = New System.Drawing.Point(347, 206)
        Me.lblDiscLbl.Name = "lblDiscLbl"
        Me.lblDiscLbl.Size = New System.Drawing.Size(89, 22)
        Me.lblDiscLbl.TabIndex = 178
        Me.lblDiscLbl.Text = "Discount:"
        Me.lblDiscLbl.Visible = False
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.Transparent
        Me.Label15.Font = New System.Drawing.Font("Arial", 15.0!)
        Me.Label15.Location = New System.Drawing.Point(442, 206)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(21, 23)
        Me.Label15.TabIndex = 177
        Me.Label15.Text = "0"
        Me.Label15.Visible = False
        '
        'chkDiscount
        '
        Me.chkDiscount.AutoSize = True
        Me.chkDiscount.BackColor = System.Drawing.Color.Transparent
        Me.chkDiscount.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.chkDiscount.Location = New System.Drawing.Point(352, 181)
        Me.chkDiscount.Name = "chkDiscount"
        Me.chkDiscount.Size = New System.Drawing.Size(212, 22)
        Me.chkDiscount.TabIndex = 176
        Me.chkDiscount.Text = "Discounted [Senior citizen]"
        Me.chkDiscount.UseVisualStyleBackColor = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Arial", 14.0!)
        Me.Label9.Location = New System.Drawing.Point(266, 209)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(65, 22)
        Me.Label9.TabIndex = 175
        Me.Label9.Text = "Count:"
        '
        'chkMulti
        '
        Me.chkMulti.AutoSize = True
        Me.chkMulti.BackColor = System.Drawing.Color.Transparent
        Me.chkMulti.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.chkMulti.Location = New System.Drawing.Point(340, 244)
        Me.chkMulti.Name = "chkMulti"
        Me.chkMulti.Size = New System.Drawing.Size(59, 22)
        Me.chkMulti.TabIndex = 174
        Me.chkMulti.Text = "Multi"
        Me.chkMulti.UseVisualStyleBackColor = False
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Arial", 14.0!)
        Me.TextBox1.Location = New System.Drawing.Point(340, 209)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(176, 29)
        Me.TextBox1.TabIndex = 173
        '
        'lblPrice
        '
        Me.lblPrice.AutoSize = True
        Me.lblPrice.BackColor = System.Drawing.Color.Transparent
        Me.lblPrice.Font = New System.Drawing.Font("Arial", 2.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrice.Location = New System.Drawing.Point(176, 221)
        Me.lblPrice.Name = "lblPrice"
        Me.lblPrice.Size = New System.Drawing.Size(11, 4)
        Me.lblPrice.TabIndex = 172
        Me.lblPrice.Text = "Price"
        '
        'btnGo
        '
        Me.btnGo.BackgroundImage = CType(resources.GetObject("btnGo.BackgroundImage"), System.Drawing.Image)
        Me.btnGo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnGo.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.btnGo.Location = New System.Drawing.Point(254, 343)
        Me.btnGo.Name = "btnGo"
        Me.btnGo.Size = New System.Drawing.Size(50, 40)
        Me.btnGo.TabIndex = 180
        Me.btnGo.Text = "Add to Cart"
        Me.btnGo.UseVisualStyleBackColor = True
        '
        'lblOriginal
        '
        Me.lblOriginal.BackColor = System.Drawing.Color.Transparent
        Me.lblOriginal.Font = New System.Drawing.Font("Arial", 38.0!, System.Drawing.FontStyle.Bold)
        Me.lblOriginal.Location = New System.Drawing.Point(134, 336)
        Me.lblOriginal.Name = "lblOriginal"
        Me.lblOriginal.Size = New System.Drawing.Size(293, 55)
        Me.lblOriginal.TabIndex = 182
        Me.lblOriginal.Text = "0.00"
        Me.lblOriginal.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'chkWithDiscount
        '
        Me.chkWithDiscount.AutoSize = True
        Me.chkWithDiscount.Location = New System.Drawing.Point(88, 452)
        Me.chkWithDiscount.Name = "chkWithDiscount"
        Me.chkWithDiscount.Size = New System.Drawing.Size(68, 17)
        Me.chkWithDiscount.TabIndex = 181
        Me.chkWithDiscount.Text = "Discount"
        Me.chkWithDiscount.UseVisualStyleBackColor = True
        '
        'tmrTime
        '
        Me.tmrTime.Enabled = True
        Me.tmrTime.Interval = 1000
        '
        'frmPOS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1098, 666)
        Me.Controls.Add(Me.LinkLabel2)
        Me.Controls.Add(Me.btnTransact)
        Me.Controls.Add(Me.txtCashAmount)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.lblDiscount)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.lblTime)
        Me.Controls.Add(Me.lblDateToday)
        Me.Controls.Add(Me.lblVATable)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.lblVatName)
        Me.Controls.Add(Me.lblVat)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.lvItems)
        Me.Controls.Add(Me.lblUserID)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.lblType)
        Me.Controls.Add(Me.lblFullname)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.lblChange)
        Me.Controls.Add(Me.lblTotalAmount)
        Me.Controls.Add(Me.lblTotalDue)
        Me.Controls.Add(Me.lblDiscountSign)
        Me.Controls.Add(Me.lblDiscLbl)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.chkDiscount)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.chkMulti)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.lblPrice)
        Me.Controls.Add(Me.btnGo)
        Me.Controls.Add(Me.lblOriginal)
        Me.Controls.Add(Me.chkWithDiscount)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmPOS"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Point of Sales"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PrintReceipt As System.Drawing.Printing.PrintDocument
    Friend WithEvents lblVATable As System.Windows.Forms.Label
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents lblVatName As System.Windows.Forms.Label
    Friend WithEvents lblVat As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents rdbNonSenior As System.Windows.Forms.RadioButton
    Friend WithEvents rdbSenior As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents lblItemName As System.Windows.Forms.Label
    Friend WithEvents lvItems As System.Windows.Forms.ListView
    Friend WithEvents btnProducts As System.Windows.Forms.Button
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents lblUserID As System.Windows.Forms.Label
    Friend WithEvents LinkLabel1 As System.Windows.Forms.LinkLabel
    Friend WithEvents lblType As System.Windows.Forms.Label
    Friend WithEvents lblFullname As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lblChange As System.Windows.Forms.Label
    Friend WithEvents txtCode As System.Windows.Forms.TextBox
    Friend WithEvents lblTotalAmount As System.Windows.Forms.Label
    Friend WithEvents PrintPreviewDialog1 As System.Windows.Forms.PrintPreviewDialog
    Friend WithEvents Timer2 As System.Windows.Forms.Timer
    Friend WithEvents lblTotalDue As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtSenID As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtCustName As System.Windows.Forms.TextBox
    Friend WithEvents lblTime As System.Windows.Forms.Label
    Friend WithEvents lblDateToday As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnRemoveItem As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblDiscount As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtCashAmount As System.Windows.Forms.TextBox
    Friend WithEvents btnTransact As System.Windows.Forms.Button
    Friend WithEvents LinkLabel2 As System.Windows.Forms.LinkLabel
    Friend WithEvents lblDiscountSign As System.Windows.Forms.Label
    Friend WithEvents lblDiscLbl As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents chkDiscount As System.Windows.Forms.CheckBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents chkMulti As System.Windows.Forms.CheckBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents lblPrice As System.Windows.Forms.Label
    Friend WithEvents btnGo As System.Windows.Forms.Button
    Friend WithEvents lblOriginal As System.Windows.Forms.Label
    Friend WithEvents chkWithDiscount As System.Windows.Forms.CheckBox
    Friend WithEvents btnReset As System.Windows.Forms.Button
    Friend WithEvents tmrTime As System.Windows.Forms.Timer
    Friend WithEvents btnViewClients As System.Windows.Forms.Button
End Class
