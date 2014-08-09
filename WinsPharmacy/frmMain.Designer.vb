<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblTime = New System.Windows.Forms.Label()
        Me.btnDiscount = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.lblUserID = New System.Windows.Forms.Label()
        Me.lblFullname = New System.Windows.Forms.Label()
        Me.lblType = New System.Windows.Forms.Label()
        Me.btnCashier = New System.Windows.Forms.Button()
        Me.btnSuppliers = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnUsers = New System.Windows.Forms.Button()
        Me.btnReports = New System.Windows.Forms.Button()
        Me.btnProducts = New System.Windows.Forms.Button()
        Me.btnReturns = New System.Windows.Forms.Button()
        Me.btnInventory = New System.Windows.Forms.Button()
        Me.btnPurchases = New System.Windows.Forms.Button()
        Me.tmrTime = New System.Windows.Forms.Timer(Me.components)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.tmrDisplayWarning = New System.Windows.Forms.Timer(Me.components)
        Me.tmrCritical = New System.Windows.Forms.Timer(Me.components)
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel14 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.tssExpire = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel15 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.tssCL = New System.Windows.Forms.ToolStripStatusLabel()
        Me.tmrExpire = New System.Windows.Forms.Timer(Me.components)
        Me.lblDateToday = New System.Windows.Forms.Label()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel1.Controls.Add(Me.lblTime)
        Me.Panel1.Controls.Add(Me.btnDiscount)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.btnCashier)
        Me.Panel1.Controls.Add(Me.btnSuppliers)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.btnUsers)
        Me.Panel1.Controls.Add(Me.btnReports)
        Me.Panel1.Controls.Add(Me.btnProducts)
        Me.Panel1.Controls.Add(Me.btnReturns)
        Me.Panel1.Controls.Add(Me.btnInventory)
        Me.Panel1.Controls.Add(Me.btnPurchases)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(212, 756)
        Me.Panel1.TabIndex = 2
        '
        'lblTime
        '
        Me.lblTime.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblTime.AutoSize = True
        Me.lblTime.BackColor = System.Drawing.Color.Transparent
        Me.lblTime.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTime.ForeColor = System.Drawing.Color.White
        Me.lblTime.Location = New System.Drawing.Point(27, 9)
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(66, 24)
        Me.lblTime.TabIndex = 194
        Me.lblTime.Text = "Time:"
        '
        'btnDiscount
        '
        Me.btnDiscount.BackgroundImage = CType(resources.GetObject("btnDiscount.BackgroundImage"), System.Drawing.Image)
        Me.btnDiscount.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnDiscount.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDiscount.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnDiscount.Image = CType(resources.GetObject("btnDiscount.Image"), System.Drawing.Image)
        Me.btnDiscount.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDiscount.Location = New System.Drawing.Point(27, 555)
        Me.btnDiscount.Name = "btnDiscount"
        Me.btnDiscount.Size = New System.Drawing.Size(168, 47)
        Me.btnDiscount.TabIndex = 113
        Me.btnDiscount.Text = "VAT/Discount" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Settings"
        Me.btnDiscount.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.LinkLabel1)
        Me.Panel2.Controls.Add(Me.lblUserID)
        Me.Panel2.Controls.Add(Me.lblFullname)
        Me.Panel2.Controls.Add(Me.lblType)
        Me.Panel2.Location = New System.Drawing.Point(27, 608)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(164, 110)
        Me.Panel2.TabIndex = 112
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.BackColor = System.Drawing.Color.Transparent
        Me.LinkLabel1.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel1.LinkColor = System.Drawing.Color.DarkRed
        Me.LinkLabel1.Location = New System.Drawing.Point(15, 84)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(102, 22)
        Me.LinkLabel1.TabIndex = 83
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "SIGN OUT"
        '
        'lblUserID
        '
        Me.lblUserID.AutoSize = True
        Me.lblUserID.BackColor = System.Drawing.Color.Transparent
        Me.lblUserID.Font = New System.Drawing.Font("Arial Narrow", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUserID.Location = New System.Drawing.Point(12, 10)
        Me.lblUserID.Name = "lblUserID"
        Me.lblUserID.Size = New System.Drawing.Size(42, 16)
        Me.lblUserID.TabIndex = 84
        Me.lblUserID.Text = "User ID"
        '
        'lblFullname
        '
        Me.lblFullname.AutoSize = True
        Me.lblFullname.BackColor = System.Drawing.Color.Transparent
        Me.lblFullname.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFullname.Location = New System.Drawing.Point(12, 26)
        Me.lblFullname.Name = "lblFullname"
        Me.lblFullname.Size = New System.Drawing.Size(102, 18)
        Me.lblFullname.TabIndex = 81
        Me.lblFullname.Text = "Name of user"
        '
        'lblType
        '
        Me.lblType.AutoSize = True
        Me.lblType.BackColor = System.Drawing.Color.Transparent
        Me.lblType.Font = New System.Drawing.Font("Arial Narrow", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblType.Location = New System.Drawing.Point(12, 55)
        Me.lblType.Name = "lblType"
        Me.lblType.Size = New System.Drawing.Size(51, 16)
        Me.lblType.TabIndex = 82
        Me.lblType.Text = "User type"
        '
        'btnCashier
        '
        Me.btnCashier.BackgroundImage = CType(resources.GetObject("btnCashier.BackgroundImage"), System.Drawing.Image)
        Me.btnCashier.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnCashier.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCashier.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnCashier.Image = CType(resources.GetObject("btnCashier.Image"), System.Drawing.Image)
        Me.btnCashier.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCashier.Location = New System.Drawing.Point(27, 78)
        Me.btnCashier.Name = "btnCashier"
        Me.btnCashier.Size = New System.Drawing.Size(168, 47)
        Me.btnCashier.TabIndex = 96
        Me.btnCashier.Text = "          &CASHIER"
        Me.btnCashier.UseVisualStyleBackColor = True
        '
        'btnSuppliers
        '
        Me.btnSuppliers.BackgroundImage = CType(resources.GetObject("btnSuppliers.BackgroundImage"), System.Drawing.Image)
        Me.btnSuppliers.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnSuppliers.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSuppliers.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnSuppliers.Image = CType(resources.GetObject("btnSuppliers.Image"), System.Drawing.Image)
        Me.btnSuppliers.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSuppliers.Location = New System.Drawing.Point(27, 290)
        Me.btnSuppliers.Name = "btnSuppliers"
        Me.btnSuppliers.Size = New System.Drawing.Size(168, 47)
        Me.btnSuppliers.TabIndex = 94
        Me.btnSuppliers.Text = "        &SUPPLIERS"
        Me.btnSuppliers.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.BackgroundImage = CType(resources.GetObject("Button1.BackgroundImage"), System.Drawing.Image)
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(27, 396)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(168, 47)
        Me.Button1.TabIndex = 103
        Me.Button1.Text = "          PURCHAS&E" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "          CONFIRMATION"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btnUsers
        '
        Me.btnUsers.BackgroundImage = CType(resources.GetObject("btnUsers.BackgroundImage"), System.Drawing.Image)
        Me.btnUsers.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnUsers.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUsers.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnUsers.Image = CType(resources.GetObject("btnUsers.Image"), System.Drawing.Image)
        Me.btnUsers.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnUsers.Location = New System.Drawing.Point(27, 502)
        Me.btnUsers.Name = "btnUsers"
        Me.btnUsers.Size = New System.Drawing.Size(168, 47)
        Me.btnUsers.TabIndex = 95
        Me.btnUsers.Text = "          &USERS"
        Me.btnUsers.UseVisualStyleBackColor = True
        '
        'btnReports
        '
        Me.btnReports.BackgroundImage = CType(resources.GetObject("btnReports.BackgroundImage"), System.Drawing.Image)
        Me.btnReports.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnReports.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReports.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnReports.Image = CType(resources.GetObject("btnReports.Image"), System.Drawing.Image)
        Me.btnReports.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnReports.Location = New System.Drawing.Point(27, 449)
        Me.btnReports.Name = "btnReports"
        Me.btnReports.Size = New System.Drawing.Size(168, 47)
        Me.btnReports.TabIndex = 101
        Me.btnReports.Text = "           RE&PORTS"
        Me.btnReports.UseVisualStyleBackColor = True
        '
        'btnProducts
        '
        Me.btnProducts.BackgroundImage = CType(resources.GetObject("btnProducts.BackgroundImage"), System.Drawing.Image)
        Me.btnProducts.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnProducts.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnProducts.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnProducts.Image = CType(resources.GetObject("btnProducts.Image"), System.Drawing.Image)
        Me.btnProducts.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnProducts.Location = New System.Drawing.Point(27, 184)
        Me.btnProducts.Name = "btnProducts"
        Me.btnProducts.Size = New System.Drawing.Size(168, 47)
        Me.btnProducts.TabIndex = 93
        Me.btnProducts.Text = "          &PRODUCTS"
        Me.btnProducts.UseVisualStyleBackColor = True
        '
        'btnReturns
        '
        Me.btnReturns.BackgroundImage = CType(resources.GetObject("btnReturns.BackgroundImage"), System.Drawing.Image)
        Me.btnReturns.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnReturns.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReturns.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnReturns.Image = CType(resources.GetObject("btnReturns.Image"), System.Drawing.Image)
        Me.btnReturns.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnReturns.Location = New System.Drawing.Point(27, 131)
        Me.btnReturns.Name = "btnReturns"
        Me.btnReturns.Size = New System.Drawing.Size(168, 47)
        Me.btnReturns.TabIndex = 100
        Me.btnReturns.Text = "         SALES &RETURNS"
        Me.btnReturns.UseVisualStyleBackColor = True
        '
        'btnInventory
        '
        Me.btnInventory.BackgroundImage = CType(resources.GetObject("btnInventory.BackgroundImage"), System.Drawing.Image)
        Me.btnInventory.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnInventory.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnInventory.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnInventory.Image = CType(resources.GetObject("btnInventory.Image"), System.Drawing.Image)
        Me.btnInventory.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnInventory.Location = New System.Drawing.Point(27, 237)
        Me.btnInventory.Name = "btnInventory"
        Me.btnInventory.Size = New System.Drawing.Size(168, 47)
        Me.btnInventory.TabIndex = 98
        Me.btnInventory.Text = "           &INVENTORY"
        Me.btnInventory.UseVisualStyleBackColor = True
        '
        'btnPurchases
        '
        Me.btnPurchases.BackgroundImage = CType(resources.GetObject("btnPurchases.BackgroundImage"), System.Drawing.Image)
        Me.btnPurchases.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnPurchases.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPurchases.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnPurchases.Image = CType(resources.GetObject("btnPurchases.Image"), System.Drawing.Image)
        Me.btnPurchases.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnPurchases.Location = New System.Drawing.Point(27, 343)
        Me.btnPurchases.Name = "btnPurchases"
        Me.btnPurchases.Size = New System.Drawing.Size(168, 47)
        Me.btnPurchases.TabIndex = 97
        Me.btnPurchases.Text = "          PURCHASE &ORDER"
        Me.btnPurchases.UseVisualStyleBackColor = True
        '
        'tmrTime
        '
        Me.tmrTime.Enabled = True
        Me.tmrTime.Interval = 1000
        '
        'Timer1
        '
        '
        'tmrDisplayWarning
        '
        Me.tmrDisplayWarning.Enabled = True
        Me.tmrDisplayWarning.Interval = 1000
        '
        'tmrCritical
        '
        Me.tmrCritical.Enabled = True
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel14, Me.tssExpire, Me.ToolStripStatusLabel15, Me.tssCL})
        Me.StatusStrip1.Location = New System.Drawing.Point(212, 734)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(1017, 22)
        Me.StatusStrip1.TabIndex = 14
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel14
        '
        Me.ToolStripStatusLabel14.Name = "ToolStripStatusLabel14"
        Me.ToolStripStatusLabel14.Size = New System.Drawing.Size(0, 17)
        '
        'tssExpire
        '
        Me.tssExpire.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tssExpire.ForeColor = System.Drawing.Color.Red
        Me.tssExpire.IsLink = True
        Me.tssExpire.LinkColor = System.Drawing.Color.Red
        Me.tssExpire.Name = "tssExpire"
        Me.tssExpire.Size = New System.Drawing.Size(173, 17)
        Me.tssExpire.Text = "View Products Near to Expire"
        Me.tssExpire.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.tssExpire.Visible = False
        '
        'ToolStripStatusLabel15
        '
        Me.ToolStripStatusLabel15.ForeColor = System.Drawing.Color.Transparent
        Me.ToolStripStatusLabel15.Name = "ToolStripStatusLabel15"
        Me.ToolStripStatusLabel15.Size = New System.Drawing.Size(297, 17)
        Me.ToolStripStatusLabel15.Text = "ToolStrmatmmmmmmmmmmmmmmmmmmmmm"
        '
        'tssCL
        '
        Me.tssCL.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tssCL.ForeColor = System.Drawing.Color.Red
        Me.tssCL.IsLink = True
        Me.tssCL.LinkColor = System.Drawing.Color.Red
        Me.tssCL.Name = "tssCL"
        Me.tssCL.Size = New System.Drawing.Size(136, 17)
        Me.tssCL.Text = "View Critical Products."
        Me.tssCL.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.tssCL.Visible = False
        '
        'tmrExpire
        '
        Me.tmrExpire.Enabled = True
        '
        'lblDateToday
        '
        Me.lblDateToday.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblDateToday.BackColor = System.Drawing.Color.Transparent
        Me.lblDateToday.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDateToday.ForeColor = System.Drawing.Color.White
        Me.lblDateToday.Location = New System.Drawing.Point(227, 9)
        Me.lblDateToday.Name = "lblDateToday"
        Me.lblDateToday.Size = New System.Drawing.Size(423, 24)
        Me.lblDateToday.TabIndex = 193
        Me.lblDateToday.Text = "Date Today:"
        '
        'Timer2
        '
        Me.Timer2.Interval = 1000
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1229, 756)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.lblDateToday)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Wins Pharmacy"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btnDiscount As System.Windows.Forms.Button
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents LinkLabel1 As System.Windows.Forms.LinkLabel
    Friend WithEvents lblUserID As System.Windows.Forms.Label
    Friend WithEvents lblFullname As System.Windows.Forms.Label
    Friend WithEvents lblType As System.Windows.Forms.Label
    Friend WithEvents btnCashier As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents btnUsers As System.Windows.Forms.Button
    Friend WithEvents btnReports As System.Windows.Forms.Button
    Friend WithEvents btnProducts As System.Windows.Forms.Button
    Friend WithEvents btnReturns As System.Windows.Forms.Button
    Friend WithEvents btnInventory As System.Windows.Forms.Button
    Friend WithEvents btnSuppliers As System.Windows.Forms.Button
    Friend WithEvents btnPurchases As System.Windows.Forms.Button
    Friend WithEvents tmrTime As System.Windows.Forms.Timer
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents tmrDisplayWarning As System.Windows.Forms.Timer
    Friend WithEvents tmrCritical As System.Windows.Forms.Timer
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStripStatusLabel14 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel15 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents tssCL As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents tmrExpire As System.Windows.Forms.Timer
    Friend WithEvents tssExpire As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents lblTime As System.Windows.Forms.Label
    Friend WithEvents lblDateToday As System.Windows.Forms.Label
    Friend WithEvents Timer2 As System.Windows.Forms.Timer
End Class
