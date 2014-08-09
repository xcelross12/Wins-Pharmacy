<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPurchaseOrder
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPurchaseOrder))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblStocks = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.lblSupplier = New System.Windows.Forms.Label()
        Me.lblItemName = New System.Windows.Forms.Label()
        Me.btnBrowse = New System.Windows.Forms.Button()
        Me.txtCount = New System.Windows.Forms.TextBox()
        Me.lblPrice = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblSupplier1 = New System.Windows.Forms.Label()
        Me.dtpDelivery = New System.Windows.Forms.DateTimePicker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtCode = New System.Windows.Forms.TextBox()
        Me.lblItemName1 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnRemove = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnGo = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tmrCode = New System.Windows.Forms.Timer(Me.components)
        Me.lblDirection = New System.Windows.Forms.Label()
        Me.tmrChange = New System.Windows.Forms.Timer(Me.components)
        Me.lblSubTotal = New System.Windows.Forms.Label()
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lvItems = New System.Windows.Forms.ListView()
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader11 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Label9 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.lblStocks)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.lblSupplier)
        Me.GroupBox1.Controls.Add(Me.lblItemName)
        Me.GroupBox1.Controls.Add(Me.btnBrowse)
        Me.GroupBox1.Controls.Add(Me.txtCount)
        Me.GroupBox1.Controls.Add(Me.lblPrice)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.lblSupplier1)
        Me.GroupBox1.Controls.Add(Me.dtpDelivery)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txtCode)
        Me.GroupBox1.Controls.Add(Me.lblItemName1)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.btnSave)
        Me.GroupBox1.Controls.Add(Me.btnRemove)
        Me.GroupBox1.Controls.Add(Me.btnReset)
        Me.GroupBox1.Controls.Add(Me.btnGo)
        Me.GroupBox1.Location = New System.Drawing.Point(25, 20)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(372, 456)
        Me.GroupBox1.TabIndex = 129
        Me.GroupBox1.TabStop = False
        '
        'lblStocks
        '
        Me.lblStocks.AutoSize = True
        Me.lblStocks.BackColor = System.Drawing.Color.Transparent
        Me.lblStocks.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStocks.Location = New System.Drawing.Point(131, 231)
        Me.lblStocks.Name = "lblStocks"
        Me.lblStocks.Size = New System.Drawing.Size(44, 15)
        Me.lblStocks.TabIndex = 146
        Me.lblStocks.Text = "Stocks"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(46, 217)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(72, 38)
        Me.Label10.TabIndex = 145
        Me.Label10.Text = "Current" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " Stocks:"
        '
        'lblSupplier
        '
        Me.lblSupplier.AutoSize = True
        Me.lblSupplier.BackColor = System.Drawing.Color.Transparent
        Me.lblSupplier.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSupplier.Location = New System.Drawing.Point(129, 187)
        Me.lblSupplier.Name = "lblSupplier"
        Me.lblSupplier.Size = New System.Drawing.Size(53, 15)
        Me.lblSupplier.TabIndex = 142
        Me.lblSupplier.Text = "Supplier"
        '
        'lblItemName
        '
        Me.lblItemName.AutoSize = True
        Me.lblItemName.BackColor = System.Drawing.Color.Transparent
        Me.lblItemName.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblItemName.Location = New System.Drawing.Point(131, 134)
        Me.lblItemName.Name = "lblItemName"
        Me.lblItemName.Size = New System.Drawing.Size(69, 15)
        Me.lblItemName.TabIndex = 141
        Me.lblItemName.Text = "Item Name"
        '
        'btnBrowse
        '
        Me.btnBrowse.BackgroundImage = CType(resources.GetObject("btnBrowse.BackgroundImage"), System.Drawing.Image)
        Me.btnBrowse.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBrowse.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnBrowse.Location = New System.Drawing.Point(325, 78)
        Me.btnBrowse.Name = "btnBrowse"
        Me.btnBrowse.Size = New System.Drawing.Size(34, 26)
        Me.btnBrowse.TabIndex = 129
        Me.btnBrowse.Text = "..."
        Me.btnBrowse.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnBrowse.UseVisualStyleBackColor = True
        '
        'txtCount
        '
        Me.txtCount.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCount.Location = New System.Drawing.Point(124, 258)
        Me.txtCount.Name = "txtCount"
        Me.txtCount.Size = New System.Drawing.Size(68, 29)
        Me.txtCount.TabIndex = 139
        '
        'lblPrice
        '
        Me.lblPrice.AutoSize = True
        Me.lblPrice.BackColor = System.Drawing.Color.Transparent
        Me.lblPrice.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrice.Location = New System.Drawing.Point(131, 162)
        Me.lblPrice.Name = "lblPrice"
        Me.lblPrice.Size = New System.Drawing.Size(35, 15)
        Me.lblPrice.TabIndex = 136
        Me.lblPrice.Text = "Price"
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(30, 159)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(108, 25)
        Me.Label6.TabIndex = 140
        Me.Label6.Text = " Unit Price:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(10, 55)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(116, 19)
        Me.Label4.TabIndex = 132
        Me.Label4.Text = "Delivery Date:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'lblSupplier1
        '
        Me.lblSupplier1.AutoSize = True
        Me.lblSupplier1.BackColor = System.Drawing.Color.Transparent
        Me.lblSupplier1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSupplier1.ForeColor = System.Drawing.Color.Black
        Me.lblSupplier1.Location = New System.Drawing.Point(46, 184)
        Me.lblSupplier1.Name = "lblSupplier1"
        Me.lblSupplier1.Size = New System.Drawing.Size(79, 19)
        Me.lblSupplier1.TabIndex = 138
        Me.lblSupplier1.Text = "Supplier:"
        '
        'dtpDelivery
        '
        Me.dtpDelivery.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpDelivery.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpDelivery.Location = New System.Drawing.Point(132, 50)
        Me.dtpDelivery.Name = "dtpDelivery"
        Me.dtpDelivery.Size = New System.Drawing.Size(187, 25)
        Me.dtpDelivery.TabIndex = 131
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(66, 85)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(60, 19)
        Me.Label5.TabIndex = 134
        Me.Label5.Text = "Code: "
        '
        'txtCode
        '
        Me.txtCode.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCode.Location = New System.Drawing.Point(132, 81)
        Me.txtCode.Name = "txtCode"
        Me.txtCode.Size = New System.Drawing.Size(187, 25)
        Me.txtCode.TabIndex = 130
        '
        'lblItemName1
        '
        Me.lblItemName1.AutoSize = True
        Me.lblItemName1.BackColor = System.Drawing.Color.Transparent
        Me.lblItemName1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblItemName1.ForeColor = System.Drawing.Color.Black
        Me.lblItemName1.Location = New System.Drawing.Point(30, 131)
        Me.lblItemName1.Name = "lblItemName1"
        Me.lblItemName1.Size = New System.Drawing.Size(95, 19)
        Me.lblItemName1.TabIndex = 135
        Me.lblItemName1.Text = "Item Name:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(39, 268)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(79, 19)
        Me.Label7.TabIndex = 133
        Me.Label7.Text = "Quantity:"
        '
        'btnSave
        '
        Me.btnSave.BackgroundImage = CType(resources.GetObject("btnSave.BackgroundImage"), System.Drawing.Image)
        Me.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnSave.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnSave.Location = New System.Drawing.Point(239, 350)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(120, 30)
        Me.btnSave.TabIndex = 126
        Me.btnSave.Text = "Generate PO"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnRemove
        '
        Me.btnRemove.BackgroundImage = CType(resources.GetObject("btnRemove.BackgroundImage"), System.Drawing.Image)
        Me.btnRemove.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnRemove.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRemove.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnRemove.Location = New System.Drawing.Point(239, 314)
        Me.btnRemove.Name = "btnRemove"
        Me.btnRemove.Size = New System.Drawing.Size(120, 30)
        Me.btnRemove.TabIndex = 43
        Me.btnRemove.Text = "Remove"
        Me.btnRemove.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.BackgroundImage = CType(resources.GetObject("btnReset.BackgroundImage"), System.Drawing.Image)
        Me.btnReset.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnReset.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReset.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnReset.Location = New System.Drawing.Point(113, 350)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(120, 30)
        Me.btnReset.TabIndex = 18
        Me.btnReset.Text = "Reset"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'btnGo
        '
        Me.btnGo.BackgroundImage = CType(resources.GetObject("btnGo.BackgroundImage"), System.Drawing.Image)
        Me.btnGo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnGo.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnGo.Location = New System.Drawing.Point(113, 314)
        Me.btnGo.Name = "btnGo"
        Me.btnGo.Size = New System.Drawing.Size(120, 30)
        Me.btnGo.TabIndex = 17
        Me.btnGo.Text = "Add to Cart"
        Me.btnGo.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(403, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(129, 19)
        Me.Label1.TabIndex = 127
        Me.Label1.Text = "Purchase Order"
        '
        'tmrCode
        '
        Me.tmrCode.Enabled = True
        '
        'lblDirection
        '
        Me.lblDirection.AutoSize = True
        Me.lblDirection.BackColor = System.Drawing.Color.Transparent
        Me.lblDirection.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDirection.ForeColor = System.Drawing.Color.White
        Me.lblDirection.Location = New System.Drawing.Point(413, 479)
        Me.lblDirection.Name = "lblDirection"
        Me.lblDirection.Size = New System.Drawing.Size(185, 14)
        Me.lblDirection.TabIndex = 128
        Me.lblDirection.Text = "(Double-click to edit item's quantity)"
        '
        'tmrChange
        '
        Me.tmrChange.Enabled = True
        '
        'lblSubTotal
        '
        Me.lblSubTotal.BackColor = System.Drawing.Color.Transparent
        Me.lblSubTotal.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSubTotal.Location = New System.Drawing.Point(842, 479)
        Me.lblSubTotal.Name = "lblSubTotal"
        Me.lblSubTotal.Size = New System.Drawing.Size(104, 21)
        Me.lblSubTotal.TabIndex = 125
        Me.lblSubTotal.Text = "0"
        Me.lblSubTotal.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Item "
        Me.ColumnHeader2.Width = 137
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Code"
        Me.ColumnHeader1.Width = 80
        '
        'lvItems
        '
        Me.lvItems.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader11})
        Me.lvItems.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvItems.FullRowSelect = True
        Me.lvItems.GridLines = True
        Me.lvItems.Location = New System.Drawing.Point(407, 42)
        Me.lvItems.Name = "lvItems"
        Me.lvItems.Size = New System.Drawing.Size(549, 430)
        Me.lvItems.TabIndex = 124
        Me.lvItems.UseCompatibleStateImageBehavior = False
        Me.lvItems.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Qty"
        Me.ColumnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Unit price"
        Me.ColumnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader4.Width = 81
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Total"
        Me.ColumnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader5.Width = 104
        '
        'ColumnHeader11
        '
        Me.ColumnHeader11.Text = "Supplier"
        Me.ColumnHeader11.Width = 97
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(677, 482)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(104, 21)
        Me.Label9.TabIndex = 86
        Me.Label9.Text = "SubTotal"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'frmPurchaseOrder
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(968, 527)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblDirection)
        Me.Controls.Add(Me.lblSubTotal)
        Me.Controls.Add(Me.lvItems)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmPurchaseOrder"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Purchase Order"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnRemove As System.Windows.Forms.Button
    Friend WithEvents btnReset As System.Windows.Forms.Button
    Friend WithEvents btnGo As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents tmrCode As System.Windows.Forms.Timer
    Friend WithEvents lblDirection As System.Windows.Forms.Label
    Friend WithEvents tmrChange As System.Windows.Forms.Timer
    Friend WithEvents lblSubTotal As System.Windows.Forms.Label
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents lvItems As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader11 As System.Windows.Forms.ColumnHeader
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents lblSupplier As System.Windows.Forms.Label
    Friend WithEvents lblItemName As System.Windows.Forms.Label
    Friend WithEvents btnBrowse As System.Windows.Forms.Button
    Friend WithEvents txtCount As System.Windows.Forms.TextBox
    Friend WithEvents lblPrice As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lblSupplier1 As System.Windows.Forms.Label
    Friend WithEvents dtpDelivery As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtCode As System.Windows.Forms.TextBox
    Friend WithEvents lblItemName1 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents lblStocks As System.Windows.Forms.Label
End Class
