<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPurchaseConfirmation
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPurchaseConfirmation))
        Me.txtPurchaseID = New System.Windows.Forms.TextBox()
        Me.lblID = New System.Windows.Forms.Label()
        Me.lvItems = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.tmrChange = New System.Windows.Forms.Timer(Me.components)
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtReceipt = New System.Windows.Forms.TextBox()
        Me.btnConfirm = New System.Windows.Forms.Button()
        Me.btnBrowse = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.lblSubTotal = New System.Windows.Forms.Label()
        Me.tmrPurchaseID = New System.Windows.Forms.Timer(Me.components)
        Me.btnPending = New System.Windows.Forms.Button()
        Me.lblPendingTotal = New System.Windows.Forms.Label()
        Me.tmrCode = New System.Windows.Forms.Timer(Me.components)
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lblDirection = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblItemName = New System.Windows.Forms.Label()
        Me.lblSupplier = New System.Windows.Forms.Label()
        Me.lblPrice = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.lvPending = New System.Windows.Forms.ListView()
        Me.ColumnHeader11 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader12 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader13 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader14 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader15 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnGo = New System.Windows.Forms.Button()
        Me.btnProducts = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.dtpDelivery = New System.Windows.Forms.DateTimePicker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.lnkChange = New System.Windows.Forms.LinkLabel()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtCode = New System.Windows.Forms.TextBox()
        Me.txtCount = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtPurchaseID
        '
        Me.txtPurchaseID.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPurchaseID.Location = New System.Drawing.Point(132, 30)
        Me.txtPurchaseID.Name = "txtPurchaseID"
        Me.txtPurchaseID.Size = New System.Drawing.Size(187, 25)
        Me.txtPurchaseID.TabIndex = 58
        '
        'lblID
        '
        Me.lblID.AutoSize = True
        Me.lblID.BackColor = System.Drawing.Color.Transparent
        Me.lblID.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblID.ForeColor = System.Drawing.Color.White
        Me.lblID.Location = New System.Drawing.Point(18, 34)
        Me.lblID.Name = "lblID"
        Me.lblID.Size = New System.Drawing.Size(108, 19)
        Me.lblID.TabIndex = 59
        Me.lblID.Text = "Purchase ID:"
        '
        'lvItems
        '
        Me.lvItems.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5})
        Me.lvItems.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvItems.FullRowSelect = True
        Me.lvItems.GridLines = True
        Me.lvItems.Location = New System.Drawing.Point(22, 60)
        Me.lvItems.Name = "lvItems"
        Me.lvItems.Size = New System.Drawing.Size(541, 156)
        Me.lvItems.TabIndex = 80
        Me.lvItems.UseCompatibleStateImageBehavior = False
        Me.lvItems.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Code"
        Me.ColumnHeader1.Width = 71
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Item "
        Me.ColumnHeader2.Width = 216
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Qty"
        Me.ColumnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Price"
        Me.ColumnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader4.Width = 78
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Total"
        Me.ColumnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader5.Width = 112
        '
        'tmrChange
        '
        Me.tmrChange.Enabled = True
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtReceipt)
        Me.GroupBox1.Controls.Add(Me.btnConfirm)
        Me.GroupBox1.Controls.Add(Me.btnBrowse)
        Me.GroupBox1.Controls.Add(Me.lblID)
        Me.GroupBox1.Controls.Add(Me.txtPurchaseID)
        Me.GroupBox1.Controls.Add(Me.btnClear)
        Me.GroupBox1.Location = New System.Drawing.Point(21, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(372, 423)
        Me.GroupBox1.TabIndex = 106
        Me.GroupBox1.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(17, 79)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(139, 19)
        Me.Label2.TabIndex = 109
        Me.Label2.Text = "Delivery Receipt:"
        '
        'txtReceipt
        '
        Me.txtReceipt.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtReceipt.Location = New System.Drawing.Point(162, 75)
        Me.txtReceipt.Name = "txtReceipt"
        Me.txtReceipt.Size = New System.Drawing.Size(196, 25)
        Me.txtReceipt.TabIndex = 108
        '
        'btnConfirm
        '
        Me.btnConfirm.BackgroundImage = CType(resources.GetObject("btnConfirm.BackgroundImage"), System.Drawing.Image)
        Me.btnConfirm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnConfirm.Enabled = False
        Me.btnConfirm.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConfirm.Location = New System.Drawing.Point(238, 106)
        Me.btnConfirm.Name = "btnConfirm"
        Me.btnConfirm.Size = New System.Drawing.Size(120, 30)
        Me.btnConfirm.TabIndex = 94
        Me.btnConfirm.Text = "Confirm Purchase"
        Me.btnConfirm.UseVisualStyleBackColor = True
        '
        'btnBrowse
        '
        Me.btnBrowse.BackgroundImage = CType(resources.GetObject("btnBrowse.BackgroundImage"), System.Drawing.Image)
        Me.btnBrowse.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBrowse.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnBrowse.Location = New System.Drawing.Point(325, 32)
        Me.btnBrowse.Name = "btnBrowse"
        Me.btnBrowse.Size = New System.Drawing.Size(34, 26)
        Me.btnBrowse.TabIndex = 77
        Me.btnBrowse.Text = "..."
        Me.btnBrowse.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnBrowse.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.BackgroundImage = CType(resources.GetObject("btnClear.BackgroundImage"), System.Drawing.Image)
        Me.btnClear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnClear.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnClear.Location = New System.Drawing.Point(112, 106)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(120, 30)
        Me.btnClear.TabIndex = 101
        Me.btnClear.Text = "Reset"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.BackgroundImage = CType(resources.GetObject("btnDelete.BackgroundImage"), System.Drawing.Image)
        Me.btnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnDelete.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.Location = New System.Drawing.Point(357, 24)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(100, 30)
        Me.btnDelete.TabIndex = 89
        Me.btnDelete.Text = "Cancel Item"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'lblSubTotal
        '
        Me.lblSubTotal.BackColor = System.Drawing.Color.Transparent
        Me.lblSubTotal.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSubTotal.ForeColor = System.Drawing.Color.White
        Me.lblSubTotal.Location = New System.Drawing.Point(459, 219)
        Me.lblSubTotal.Name = "lblSubTotal"
        Me.lblSubTotal.Size = New System.Drawing.Size(104, 21)
        Me.lblSubTotal.TabIndex = 85
        Me.lblSubTotal.Text = "SubTotal"
        Me.lblSubTotal.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'tmrPurchaseID
        '
        Me.tmrPurchaseID.Enabled = True
        '
        'btnPending
        '
        Me.btnPending.BackgroundImage = CType(resources.GetObject("btnPending.BackgroundImage"), System.Drawing.Image)
        Me.btnPending.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnPending.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPending.Location = New System.Drawing.Point(463, 24)
        Me.btnPending.Name = "btnPending"
        Me.btnPending.Size = New System.Drawing.Size(100, 30)
        Me.btnPending.TabIndex = 92
        Me.btnPending.Text = "Pending"
        Me.btnPending.UseVisualStyleBackColor = True
        '
        'lblPendingTotal
        '
        Me.lblPendingTotal.BackColor = System.Drawing.Color.Transparent
        Me.lblPendingTotal.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblPendingTotal.Location = New System.Drawing.Point(874, 544)
        Me.lblPendingTotal.Name = "lblPendingTotal"
        Me.lblPendingTotal.Size = New System.Drawing.Size(104, 21)
        Me.lblPendingTotal.TabIndex = 93
        Me.lblPendingTotal.Text = "SubTotal"
        Me.lblPendingTotal.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'tmrCode
        '
        Me.tmrCode.Enabled = True
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.lblDirection)
        Me.GroupBox2.Controls.Add(Me.lvItems)
        Me.GroupBox2.Controls.Add(Me.btnDelete)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.lblSubTotal)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.btnPending)
        Me.GroupBox2.Controls.Add(Me.lblItemName)
        Me.GroupBox2.Controls.Add(Me.lblSupplier)
        Me.GroupBox2.Controls.Add(Me.lblPrice)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GroupBox2.Location = New System.Drawing.Point(412, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(579, 250)
        Me.GroupBox2.TabIndex = 107
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "For Confirmation"
        Me.GroupBox2.UseCompatibleTextRendering = True
        '
        'lblDirection
        '
        Me.lblDirection.AutoSize = True
        Me.lblDirection.BackColor = System.Drawing.Color.Transparent
        Me.lblDirection.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDirection.ForeColor = System.Drawing.Color.White
        Me.lblDirection.Location = New System.Drawing.Point(29, 219)
        Me.lblDirection.Name = "lblDirection"
        Me.lblDirection.Size = New System.Drawing.Size(185, 14)
        Me.lblDirection.TabIndex = 95
        Me.lblDirection.Text = "(Double-click to edit item's quantity)"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(216, 147)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 15)
        Me.Label3.TabIndex = 107
        Me.Label3.Text = "Supplier"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(218, 93)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(69, 15)
        Me.Label1.TabIndex = 106
        Me.Label1.Text = "Item Name"
        '
        'lblItemName
        '
        Me.lblItemName.AutoSize = True
        Me.lblItemName.BackColor = System.Drawing.Color.Transparent
        Me.lblItemName.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblItemName.ForeColor = System.Drawing.Color.Black
        Me.lblItemName.Location = New System.Drawing.Point(117, 91)
        Me.lblItemName.Name = "lblItemName"
        Me.lblItemName.Size = New System.Drawing.Size(95, 19)
        Me.lblItemName.TabIndex = 97
        Me.lblItemName.Text = "Item Name:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'lblSupplier
        '
        Me.lblSupplier.AutoSize = True
        Me.lblSupplier.BackColor = System.Drawing.Color.Transparent
        Me.lblSupplier.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSupplier.ForeColor = System.Drawing.Color.Black
        Me.lblSupplier.Location = New System.Drawing.Point(133, 144)
        Me.lblSupplier.Name = "lblSupplier"
        Me.lblSupplier.Size = New System.Drawing.Size(79, 19)
        Me.lblSupplier.TabIndex = 102
        Me.lblSupplier.Text = "Supplier:"
        '
        'lblPrice
        '
        Me.lblPrice.AutoSize = True
        Me.lblPrice.BackColor = System.Drawing.Color.Transparent
        Me.lblPrice.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrice.Location = New System.Drawing.Point(218, 122)
        Me.lblPrice.Name = "lblPrice"
        Me.lblPrice.Size = New System.Drawing.Size(35, 15)
        Me.lblPrice.TabIndex = 98
        Me.lblPrice.Text = "Price"
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(117, 119)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(108, 25)
        Me.Label6.TabIndex = 105
        Me.Label6.Text = " Unit Price:"
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox3.Controls.Add(Me.lvPending)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Controls.Add(Me.Button1)
        Me.GroupBox3.Controls.Add(Me.btnGo)
        Me.GroupBox3.Controls.Add(Me.btnProducts)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.dtpDelivery)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.Label11)
        Me.GroupBox3.Controls.Add(Me.lnkChange)
        Me.GroupBox3.Controls.Add(Me.Label10)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Controls.Add(Me.Button2)
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Controls.Add(Me.txtCode)
        Me.GroupBox3.Controls.Add(Me.txtCount)
        Me.GroupBox3.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GroupBox3.Location = New System.Drawing.Point(412, 273)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(579, 228)
        Me.GroupBox3.TabIndex = 108
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Pending Orders"
        Me.GroupBox3.UseCompatibleTextRendering = True
        '
        'lvPending
        '
        Me.lvPending.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader11, Me.ColumnHeader12, Me.ColumnHeader13, Me.ColumnHeader14, Me.ColumnHeader15})
        Me.lvPending.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvPending.FullRowSelect = True
        Me.lvPending.GridLines = True
        Me.lvPending.Location = New System.Drawing.Point(19, 31)
        Me.lvPending.Name = "lvPending"
        Me.lvPending.Size = New System.Drawing.Size(541, 167)
        Me.lvPending.TabIndex = 80
        Me.lvPending.UseCompatibleStateImageBehavior = False
        Me.lvPending.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader11
        '
        Me.ColumnHeader11.Text = "Code"
        Me.ColumnHeader11.Width = 71
        '
        'ColumnHeader12
        '
        Me.ColumnHeader12.Text = "Item "
        Me.ColumnHeader12.Width = 216
        '
        'ColumnHeader13
        '
        Me.ColumnHeader13.Text = "Qty"
        Me.ColumnHeader13.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'ColumnHeader14
        '
        Me.ColumnHeader14.Text = "Price"
        Me.ColumnHeader14.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader14.Width = 78
        '
        'ColumnHeader15
        '
        Me.ColumnHeader15.Text = "Total"
        Me.ColumnHeader15.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader15.Width = 112
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(456, 201)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(104, 21)
        Me.Label7.TabIndex = 85
        Me.Label7.Text = "SubTotal"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Button1
        '
        Me.Button1.BackgroundImage = CType(resources.GetObject("Button1.BackgroundImage"), System.Drawing.Image)
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.Button1.Location = New System.Drawing.Point(296, 83)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(115, 43)
        Me.Button1.TabIndex = 99
        Me.Button1.Text = "Reset"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btnGo
        '
        Me.btnGo.BackgroundImage = CType(resources.GetObject("btnGo.BackgroundImage"), System.Drawing.Image)
        Me.btnGo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnGo.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.btnGo.Location = New System.Drawing.Point(66, 53)
        Me.btnGo.Name = "btnGo"
        Me.btnGo.Size = New System.Drawing.Size(115, 43)
        Me.btnGo.TabIndex = 98
        Me.btnGo.Text = "Add to Cart"
        Me.btnGo.UseVisualStyleBackColor = True
        '
        'btnProducts
        '
        Me.btnProducts.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.btnProducts.Location = New System.Drawing.Point(398, 31)
        Me.btnProducts.Name = "btnProducts"
        Me.btnProducts.Size = New System.Drawing.Size(33, 27)
        Me.btnProducts.TabIndex = 106
        Me.btnProducts.Text = "..."
        Me.btnProducts.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnProducts.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label4.Location = New System.Drawing.Point(180, 97)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(37, 15)
        Me.Label4.TabIndex = 105
        Me.Label4.Text = "Price"
        '
        'dtpDelivery
        '
        Me.dtpDelivery.Enabled = False
        Me.dtpDelivery.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.dtpDelivery.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpDelivery.Location = New System.Drawing.Point(230, 32)
        Me.dtpDelivery.Name = "dtpDelivery"
        Me.dtpDelivery.Size = New System.Drawing.Size(162, 26)
        Me.dtpDelivery.TabIndex = 100
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label5.Location = New System.Drawing.Point(180, 74)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(89, 19)
        Me.Label5.TabIndex = 104
        Me.Label5.Text = "Item Name"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.Label11.Location = New System.Drawing.Point(70, 34)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(102, 18)
        Me.Label11.TabIndex = 101
        Me.Label11.Text = "Delivery Date"
        '
        'lnkChange
        '
        Me.lnkChange.AutoSize = True
        Me.lnkChange.BackColor = System.Drawing.Color.Transparent
        Me.lnkChange.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.lnkChange.Location = New System.Drawing.Point(180, 149)
        Me.lnkChange.Name = "lnkChange"
        Me.lnkChange.Size = New System.Drawing.Size(114, 16)
        Me.lnkChange.TabIndex = 109
        Me.lnkChange.TabStop = True
        Me.lnkChange.Text = "Change Supplier"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.Label10.Location = New System.Drawing.Point(256, 75)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(68, 18)
        Me.Label10.TabIndex = 102
        Me.Label10.Text = "Quantity:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Bold)
        Me.Label8.Location = New System.Drawing.Point(180, 119)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(53, 14)
        Me.Label8.TabIndex = 108
        Me.Label8.Text = "Supplier"
        '
        'Button2
        '
        Me.Button2.BackgroundImage = CType(resources.GetObject("Button2.BackgroundImage"), System.Drawing.Image)
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button2.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.Button2.Location = New System.Drawing.Point(389, 69)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(115, 43)
        Me.Button2.TabIndex = 107
        Me.Button2.Text = "Remove"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.Label9.Location = New System.Drawing.Point(108, 32)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(55, 18)
        Me.Label9.TabIndex = 103
        Me.Label9.Text = "Code: "
        '
        'txtCode
        '
        Me.txtCode.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.txtCode.Location = New System.Drawing.Point(183, 32)
        Me.txtCode.Name = "txtCode"
        Me.txtCode.Size = New System.Drawing.Size(208, 26)
        Me.txtCode.TabIndex = 96
        '
        'txtCount
        '
        Me.txtCount.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.txtCount.Location = New System.Drawing.Point(183, 170)
        Me.txtCount.Name = "txtCount"
        Me.txtCount.Size = New System.Drawing.Size(100, 26)
        Me.txtCount.TabIndex = 97
        '
        'frmPurchaseConfirmation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1010, 527)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.lblPendingTotal)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmPurchaseConfirmation"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Purchase Confirmation Module"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txtPurchaseID As System.Windows.Forms.TextBox
    Friend WithEvents lblID As System.Windows.Forms.Label
    Friend WithEvents lvItems As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents tmrChange As System.Windows.Forms.Timer
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnBrowse As System.Windows.Forms.Button
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents lblSubTotal As System.Windows.Forms.Label
    Friend WithEvents tmrPurchaseID As System.Windows.Forms.Timer
    Friend WithEvents btnConfirm As System.Windows.Forms.Button
    Friend WithEvents btnPending As System.Windows.Forms.Button
    Friend WithEvents lblPendingTotal As System.Windows.Forms.Label
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents tmrCode As System.Windows.Forms.Timer
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents lblDirection As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents lvPending As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader11 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader12 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader13 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader14 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader15 As System.Windows.Forms.ColumnHeader
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtReceipt As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents btnGo As System.Windows.Forms.Button
    Friend WithEvents btnProducts As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents dtpDelivery As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents lnkChange As System.Windows.Forms.LinkLabel
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtCode As System.Windows.Forms.TextBox
    Friend WithEvents txtCount As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblItemName As System.Windows.Forms.Label
    Friend WithEvents lblSupplier As System.Windows.Forms.Label
    Friend WithEvents lblPrice As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
End Class
