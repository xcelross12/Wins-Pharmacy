<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmInventory
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmInventory))
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tmrUpdateMonitoring = New System.Windows.Forms.Timer(Me.components)
        Me.dtpDate = New System.Windows.Forms.DateTimePicker()
        Me.lvInventory = New System.Windows.Forms.ListView()
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.btnFastSlowMovingProducts = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.cbFields = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(636, 25)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(126, 19)
        Me.Label2.TabIndex = 38
        Me.Label2.Text = "Inventory Date:"
        '
        'tmrUpdateMonitoring
        '
        Me.tmrUpdateMonitoring.Enabled = True
        '
        'dtpDate
        '
        Me.dtpDate.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpDate.Location = New System.Drawing.Point(773, 20)
        Me.dtpDate.Name = "dtpDate"
        Me.dtpDate.Size = New System.Drawing.Size(155, 26)
        Me.dtpDate.TabIndex = 34
        '
        'lvInventory
        '
        Me.lvInventory.Font = New System.Drawing.Font("Arial Narrow", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvInventory.FullRowSelect = True
        Me.lvInventory.GridLines = True
        Me.lvInventory.Location = New System.Drawing.Point(16, 52)
        Me.lvInventory.MultiSelect = False
        Me.lvInventory.Name = "lvInventory"
        Me.lvInventory.Size = New System.Drawing.Size(912, 371)
        Me.lvInventory.TabIndex = 33
        Me.lvInventory.UseCompatibleStateImageBehavior = False
        Me.lvInventory.View = System.Windows.Forms.View.Details
        '
        'btnPrint
        '
        Me.btnPrint.BackgroundImage = CType(resources.GetObject("btnPrint.BackgroundImage"), System.Drawing.Image)
        Me.btnPrint.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrint.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnPrint.Location = New System.Drawing.Point(798, 462)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(130, 47)
        Me.btnPrint.TabIndex = 171
        Me.btnPrint.Text = "Print"
        Me.btnPrint.UseVisualStyleBackColor = True
        '
        'btnFastSlowMovingProducts
        '
        Me.btnFastSlowMovingProducts.BackgroundImage = CType(resources.GetObject("btnFastSlowMovingProducts.BackgroundImage"), System.Drawing.Image)
        Me.btnFastSlowMovingProducts.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFastSlowMovingProducts.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnFastSlowMovingProducts.Location = New System.Drawing.Point(17, 463)
        Me.btnFastSlowMovingProducts.Name = "btnFastSlowMovingProducts"
        Me.btnFastSlowMovingProducts.Size = New System.Drawing.Size(130, 47)
        Me.btnFastSlowMovingProducts.TabIndex = 173
        Me.btnFastSlowMovingProducts.Text = "Fast and Slow" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Moving Products"
        Me.btnFastSlowMovingProducts.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(330, 434)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(101, 19)
        Me.Label8.TabIndex = 177
        Me.Label8.Text = "Search text:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(22, 434)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(92, 19)
        Me.Label7.TabIndex = 176
        Me.Label7.Text = "Search by:"
        '
        'txtSearch
        '
        Me.txtSearch.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.txtSearch.Location = New System.Drawing.Point(437, 429)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(310, 23)
        Me.txtSearch.TabIndex = 175
        '
        'cbFields
        '
        Me.cbFields.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbFields.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.cbFields.FormattingEnabled = True
        Me.cbFields.Items.AddRange(New Object() {"ProductCode", "ProductName", "Category", "Supplier"})
        Me.cbFields.Location = New System.Drawing.Point(120, 429)
        Me.cbFields.Name = "cbFields"
        Me.cbFields.Size = New System.Drawing.Size(195, 24)
        Me.cbFields.TabIndex = 174
        '
        'frmInventory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(940, 522)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.cbFields)
        Me.Controls.Add(Me.btnFastSlowMovingProducts)
        Me.Controls.Add(Me.btnPrint)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.dtpDate)
        Me.Controls.Add(Me.lvInventory)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmInventory"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Inventory"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents tmrUpdateMonitoring As System.Windows.Forms.Timer
    Friend WithEvents dtpDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents lvInventory As System.Windows.Forms.ListView
    Friend WithEvents btnPrint As System.Windows.Forms.Button
    Friend WithEvents btnFastSlowMovingProducts As System.Windows.Forms.Button
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtSearch As System.Windows.Forms.TextBox
    Friend WithEvents cbFields As System.Windows.Forms.ComboBox
End Class
