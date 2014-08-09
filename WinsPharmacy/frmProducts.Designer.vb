<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProducts
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmProducts))
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lvProducts = New System.Windows.Forms.ListView()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.btnRemove = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.cbFields = New System.Windows.Forms.ComboBox()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.gb1 = New System.Windows.Forms.GroupBox()
        Me.label22 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.dtpExpirationDate = New System.Windows.Forms.DateTimePicker()
        Me.txtQuantity = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtDescription = New System.Windows.Forms.TextBox()
        Me.btnGBCode = New System.Windows.Forms.Button()
        Me.btnAddCat = New System.Windows.Forms.Button()
        Me.btnAddSupp = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cbCategory = New System.Windows.Forms.ComboBox()
        Me.cbSupplier = New System.Windows.Forms.ComboBox()
        Me.numCritical = New System.Windows.Forms.NumericUpDown()
        Me.txtUnitPrice = New System.Windows.Forms.TextBox()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.txtCode = New System.Windows.Forms.TextBox()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.gb1.SuspendLayout()
        CType(Me.numCritical, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnPrint
        '
        Me.btnPrint.BackgroundImage = CType(resources.GetObject("btnPrint.BackgroundImage"), System.Drawing.Image)
        Me.btnPrint.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrint.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnPrint.Location = New System.Drawing.Point(855, 441)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(90, 35)
        Me.btnPrint.TabIndex = 75
        Me.btnPrint.Text = "Print"
        Me.btnPrint.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(388, 220)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(101, 19)
        Me.Label8.TabIndex = 74
        Me.Label8.Text = "Search text:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(25, 220)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(92, 19)
        Me.Label7.TabIndex = 73
        Me.Label7.Text = "Search by:"
        '
        'lvProducts
        '
        Me.lvProducts.FullRowSelect = True
        Me.lvProducts.GridLines = True
        Me.lvProducts.Location = New System.Drawing.Point(12, 245)
        Me.lvProducts.Name = "lvProducts"
        Me.lvProducts.Size = New System.Drawing.Size(824, 246)
        Me.lvProducts.TabIndex = 65
        Me.lvProducts.UseCompatibleStateImageBehavior = False
        Me.lvProducts.View = System.Windows.Forms.View.Details
        '
        'txtSearch
        '
        Me.txtSearch.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.txtSearch.Location = New System.Drawing.Point(495, 215)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(318, 23)
        Me.txtSearch.TabIndex = 71
        '
        'btnRemove
        '
        Me.btnRemove.BackgroundImage = CType(resources.GetObject("btnRemove.BackgroundImage"), System.Drawing.Image)
        Me.btnRemove.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnRemove.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRemove.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnRemove.Location = New System.Drawing.Point(855, 114)
        Me.btnRemove.Name = "btnRemove"
        Me.btnRemove.Size = New System.Drawing.Size(90, 35)
        Me.btnRemove.TabIndex = 68
        Me.btnRemove.Text = "Remove"
        Me.btnRemove.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.BackgroundImage = CType(resources.GetObject("btnCancel.BackgroundImage"), System.Drawing.Image)
        Me.btnCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnCancel.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnCancel.Location = New System.Drawing.Point(855, 155)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(90, 35)
        Me.btnCancel.TabIndex = 69
        Me.btnCancel.Text = "Reset"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'cbFields
        '
        Me.cbFields.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbFields.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.cbFields.FormattingEnabled = True
        Me.cbFields.Location = New System.Drawing.Point(123, 215)
        Me.cbFields.Name = "cbFields"
        Me.cbFields.Size = New System.Drawing.Size(195, 24)
        Me.cbFields.TabIndex = 70
        '
        'btnUpdate
        '
        Me.btnUpdate.BackgroundImage = CType(resources.GetObject("btnUpdate.BackgroundImage"), System.Drawing.Image)
        Me.btnUpdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnUpdate.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdate.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnUpdate.Location = New System.Drawing.Point(855, 69)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(90, 35)
        Me.btnUpdate.TabIndex = 67
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'gb1
        '
        Me.gb1.BackColor = System.Drawing.Color.Transparent
        Me.gb1.Controls.Add(Me.label22)
        Me.gb1.Controls.Add(Me.Label10)
        Me.gb1.Controls.Add(Me.dtpExpirationDate)
        Me.gb1.Controls.Add(Me.txtQuantity)
        Me.gb1.Controls.Add(Me.Label9)
        Me.gb1.Controls.Add(Me.txtDescription)
        Me.gb1.Controls.Add(Me.btnGBCode)
        Me.gb1.Controls.Add(Me.btnAddCat)
        Me.gb1.Controls.Add(Me.btnAddSupp)
        Me.gb1.Controls.Add(Me.Label6)
        Me.gb1.Controls.Add(Me.Label5)
        Me.gb1.Controls.Add(Me.Label4)
        Me.gb1.Controls.Add(Me.Label3)
        Me.gb1.Controls.Add(Me.Label2)
        Me.gb1.Controls.Add(Me.Label1)
        Me.gb1.Controls.Add(Me.cbCategory)
        Me.gb1.Controls.Add(Me.cbSupplier)
        Me.gb1.Controls.Add(Me.numCritical)
        Me.gb1.Controls.Add(Me.txtUnitPrice)
        Me.gb1.Controls.Add(Me.txtName)
        Me.gb1.Controls.Add(Me.txtCode)
        Me.gb1.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gb1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.gb1.Location = New System.Drawing.Point(12, 12)
        Me.gb1.Name = "gb1"
        Me.gb1.Size = New System.Drawing.Size(824, 179)
        Me.gb1.TabIndex = 78
        Me.gb1.TabStop = False
        Me.gb1.Text = "Product details"
        '
        'label22
        '
        Me.label22.AutoSize = True
        Me.label22.BackColor = System.Drawing.Color.Transparent
        Me.label22.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label22.ForeColor = System.Drawing.Color.White
        Me.label22.Location = New System.Drawing.Point(472, 118)
        Me.label22.Name = "label22"
        Me.label22.Size = New System.Drawing.Size(79, 19)
        Me.label22.TabIndex = 591
        Me.label22.Text = "Quantity:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(13, 149)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(132, 19)
        Me.Label10.TabIndex = 589
        Me.Label10.Text = "Expiration Date:"
        '
        'dtpExpirationDate
        '
        Me.dtpExpirationDate.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpExpirationDate.Enabled = False
        Me.dtpExpirationDate.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpExpirationDate.Location = New System.Drawing.Point(148, 143)
        Me.dtpExpirationDate.Name = "dtpExpirationDate"
        Me.dtpExpirationDate.Size = New System.Drawing.Size(286, 26)
        Me.dtpExpirationDate.TabIndex = 4
        '
        'txtQuantity
        '
        Me.txtQuantity.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtQuantity.Location = New System.Drawing.Point(557, 115)
        Me.txtQuantity.MaxLength = 10
        Me.txtQuantity.Name = "txtQuantity"
        Me.txtQuantity.Size = New System.Drawing.Size(225, 22)
        Me.txtQuantity.TabIndex = 590
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(39, 89)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(103, 19)
        Me.Label9.TabIndex = 42
        Me.Label9.Text = "Description:"
        '
        'txtDescription
        '
        Me.txtDescription.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescription.Location = New System.Drawing.Point(148, 85)
        Me.txtDescription.Multiline = True
        Me.txtDescription.Name = "txtDescription"
        Me.txtDescription.Size = New System.Drawing.Size(286, 52)
        Me.txtDescription.TabIndex = 3
        '
        'btnGBCode
        '
        Me.btnGBCode.BackgroundImage = CType(resources.GetObject("btnGBCode.BackgroundImage"), System.Drawing.Image)
        Me.btnGBCode.Enabled = False
        Me.btnGBCode.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGBCode.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnGBCode.Location = New System.Drawing.Point(327, 21)
        Me.btnGBCode.Name = "btnGBCode"
        Me.btnGBCode.Size = New System.Drawing.Size(99, 30)
        Me.btnGBCode.TabIndex = 40
        Me.btnGBCode.Text = "Generate Code"
        Me.btnGBCode.UseVisualStyleBackColor = True
        '
        'btnAddCat
        '
        Me.btnAddCat.BackgroundImage = CType(resources.GetObject("btnAddCat.BackgroundImage"), System.Drawing.Image)
        Me.btnAddCat.Enabled = False
        Me.btnAddCat.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.btnAddCat.ForeColor = System.Drawing.Color.Maroon
        Me.btnAddCat.Location = New System.Drawing.Point(788, 55)
        Me.btnAddCat.Name = "btnAddCat"
        Me.btnAddCat.Size = New System.Drawing.Size(23, 22)
        Me.btnAddCat.TabIndex = 26
        Me.btnAddCat.Text = "+"
        Me.btnAddCat.UseVisualStyleBackColor = True
        '
        'btnAddSupp
        '
        Me.btnAddSupp.BackgroundImage = CType(resources.GetObject("btnAddSupp.BackgroundImage"), System.Drawing.Image)
        Me.btnAddSupp.Enabled = False
        Me.btnAddSupp.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.btnAddSupp.ForeColor = System.Drawing.Color.Maroon
        Me.btnAddSupp.Location = New System.Drawing.Point(788, 25)
        Me.btnAddSupp.Name = "btnAddSupp"
        Me.btnAddSupp.Size = New System.Drawing.Size(23, 22)
        Me.btnAddSupp.TabIndex = 25
        Me.btnAddSupp.Text = "+"
        Me.btnAddSupp.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(455, 150)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(96, 16)
        Me.Label6.TabIndex = 20
        Me.Label6.Text = "Critical Level:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(497, 89)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(54, 19)
        Me.Label5.TabIndex = 19
        Me.Label5.Text = "Price:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(468, 58)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(85, 19)
        Me.Label4.TabIndex = 18
        Me.Label4.Text = "Category:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(468, 32)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(79, 19)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "Supplier:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(21, 59)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(124, 19)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "Product Name:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(24, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(121, 19)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "Product Code:"
        '
        'cbCategory
        '
        Me.cbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbCategory.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbCategory.FormattingEnabled = True
        Me.cbCategory.Location = New System.Drawing.Point(553, 55)
        Me.cbCategory.Name = "cbCategory"
        Me.cbCategory.Size = New System.Drawing.Size(229, 24)
        Me.cbCategory.TabIndex = 6
        '
        'cbSupplier
        '
        Me.cbSupplier.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbSupplier.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbSupplier.FormattingEnabled = True
        Me.cbSupplier.Location = New System.Drawing.Point(553, 25)
        Me.cbSupplier.Name = "cbSupplier"
        Me.cbSupplier.Size = New System.Drawing.Size(229, 24)
        Me.cbSupplier.TabIndex = 5
        '
        'numCritical
        '
        Me.numCritical.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.numCritical.Location = New System.Drawing.Point(557, 143)
        Me.numCritical.Maximum = New Decimal(New Integer() {99999, 0, 0, 0})
        Me.numCritical.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.numCritical.Name = "numCritical"
        Me.numCritical.Size = New System.Drawing.Size(81, 26)
        Me.numCritical.TabIndex = 8
        Me.numCritical.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'txtUnitPrice
        '
        Me.txtUnitPrice.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUnitPrice.Location = New System.Drawing.Point(557, 86)
        Me.txtUnitPrice.MaxLength = 10
        Me.txtUnitPrice.Name = "txtUnitPrice"
        Me.txtUnitPrice.Size = New System.Drawing.Size(225, 22)
        Me.txtUnitPrice.TabIndex = 7
        '
        'txtName
        '
        Me.txtName.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtName.Location = New System.Drawing.Point(148, 57)
        Me.txtName.MaxLength = 50
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(286, 22)
        Me.txtName.TabIndex = 2
        '
        'txtCode
        '
        Me.txtCode.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCode.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCode.Location = New System.Drawing.Point(148, 27)
        Me.txtCode.MaxLength = 15
        Me.txtCode.Name = "txtCode"
        Me.txtCode.Size = New System.Drawing.Size(173, 22)
        Me.txtCode.TabIndex = 1
        '
        'btnAdd
        '
        Me.btnAdd.BackgroundImage = CType(resources.GetObject("btnAdd.BackgroundImage"), System.Drawing.Image)
        Me.btnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnAdd.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnAdd.Location = New System.Drawing.Point(855, 26)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(90, 35)
        Me.btnAdd.TabIndex = 66
        Me.btnAdd.Text = "Add new"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.BackgroundImage = CType(resources.GetObject("Button1.BackgroundImage"), System.Drawing.Image)
        Me.Button1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button1.Location = New System.Drawing.Point(855, 391)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(90, 44)
        Me.Button1.TabIndex = 79
        Me.Button1.Text = "Go to Price Adjustment"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'frmProducts
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(959, 503)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnPrint)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.lvProducts)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.btnRemove)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.cbFields)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.gb1)
        Me.Controls.Add(Me.btnAdd)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmProducts"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Products Management"
        Me.gb1.ResumeLayout(False)
        Me.gb1.PerformLayout()
        CType(Me.numCritical, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnPrint As System.Windows.Forms.Button
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents lvProducts As System.Windows.Forms.ListView
    Friend WithEvents txtSearch As System.Windows.Forms.TextBox
    Friend WithEvents btnRemove As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents cbFields As System.Windows.Forms.ComboBox
    Friend WithEvents btnUpdate As System.Windows.Forms.Button
    Friend WithEvents gb1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnGBCode As System.Windows.Forms.Button
    Friend WithEvents btnAddCat As System.Windows.Forms.Button
    Friend WithEvents btnAddSupp As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cbCategory As System.Windows.Forms.ComboBox
    Friend WithEvents cbSupplier As System.Windows.Forms.ComboBox
    Friend WithEvents numCritical As System.Windows.Forms.NumericUpDown
    Friend WithEvents txtUnitPrice As System.Windows.Forms.TextBox
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents txtCode As System.Windows.Forms.TextBox
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents dtpExpirationDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtDescription As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents label22 As System.Windows.Forms.Label
    Friend WithEvents txtQuantity As System.Windows.Forms.TextBox
End Class
