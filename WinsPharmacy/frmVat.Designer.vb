<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmVat
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmVat))
        Me.txtVat = New System.Windows.Forms.TextBox()
        Me.btnEditVat = New System.Windows.Forms.Button()
        Me.lblVATRate = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtDiscount = New System.Windows.Forms.TextBox()
        Me.btnEditDiscount = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtVatRate = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'txtVat
        '
        Me.txtVat.Enabled = False
        Me.txtVat.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtVat.Location = New System.Drawing.Point(12, 42)
        Me.txtVat.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtVat.Name = "txtVat"
        Me.txtVat.Size = New System.Drawing.Size(307, 25)
        Me.txtVat.TabIndex = 62
        '
        'btnEditVat
        '
        Me.btnEditVat.BackgroundImage = CType(resources.GetObject("btnEditVat.BackgroundImage"), System.Drawing.Image)
        Me.btnEditVat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnEditVat.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEditVat.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnEditVat.Location = New System.Drawing.Point(12, 75)
        Me.btnEditVat.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnEditVat.Name = "btnEditVat"
        Me.btnEditVat.Size = New System.Drawing.Size(90, 35)
        Me.btnEditVat.TabIndex = 63
        Me.btnEditVat.Text = "Edit"
        Me.btnEditVat.UseVisualStyleBackColor = True
        Me.btnEditVat.Visible = False
        '
        'lblVATRate
        '
        Me.lblVATRate.AutoSize = True
        Me.lblVATRate.BackColor = System.Drawing.Color.Transparent
        Me.lblVATRate.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVATRate.ForeColor = System.Drawing.Color.White
        Me.lblVATRate.Location = New System.Drawing.Point(12, 19)
        Me.lblVATRate.Name = "lblVATRate"
        Me.lblVATRate.Size = New System.Drawing.Size(84, 19)
        Me.lblVATRate.TabIndex = 66
        Me.lblVATRate.Text = "VAT Rate:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(13, 126)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(177, 19)
        Me.Label1.TabIndex = 68
        Me.Label1.Text = "Senior Discount Rate:"
        '
        'txtDiscount
        '
        Me.txtDiscount.Enabled = False
        Me.txtDiscount.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDiscount.Location = New System.Drawing.Point(13, 149)
        Me.txtDiscount.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtDiscount.Name = "txtDiscount"
        Me.txtDiscount.Size = New System.Drawing.Size(307, 25)
        Me.txtDiscount.TabIndex = 67
        '
        'btnEditDiscount
        '
        Me.btnEditDiscount.BackgroundImage = CType(resources.GetObject("btnEditDiscount.BackgroundImage"), System.Drawing.Image)
        Me.btnEditDiscount.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnEditDiscount.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEditDiscount.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnEditDiscount.Location = New System.Drawing.Point(13, 182)
        Me.btnEditDiscount.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnEditDiscount.Name = "btnEditDiscount"
        Me.btnEditDiscount.Size = New System.Drawing.Size(90, 35)
        Me.btnEditDiscount.TabIndex = 69
        Me.btnEditDiscount.Text = "Edit"
        Me.btnEditDiscount.UseVisualStyleBackColor = True
        Me.btnEditDiscount.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(288, 42)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(31, 25)
        Me.Label2.TabIndex = 70
        Me.Label2.Text = "%"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(288, 149)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(31, 25)
        Me.Label3.TabIndex = 71
        Me.Label3.Text = "%"
        '
        'txtVatRate
        '
        Me.txtVatRate.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtVatRate.Location = New System.Drawing.Point(12, 42)
        Me.txtVatRate.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtVatRate.Name = "txtVatRate"
        Me.txtVatRate.Size = New System.Drawing.Size(307, 25)
        Me.txtVatRate.TabIndex = 62
        '
        'frmVat
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(333, 230)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnEditDiscount)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtDiscount)
        Me.Controls.Add(Me.lblVATRate)
        Me.Controls.Add(Me.btnEditVat)
        Me.Controls.Add(Me.txtVat)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmVat"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "VAT"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtVat As System.Windows.Forms.TextBox
    Friend WithEvents btnEditVat As System.Windows.Forms.Button
    Friend WithEvents lblVATRate As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtDiscount As System.Windows.Forms.TextBox
    Friend WithEvents btnEditDiscount As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtVatRate As System.Windows.Forms.TextBox
End Class
