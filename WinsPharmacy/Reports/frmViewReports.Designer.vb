<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmViewReports
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
        Me.crvViewer = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.SuspendLayout()
        '
        'crvViewer
        '
        Me.crvViewer.ActiveViewIndex = -1
        Me.crvViewer.AutoSize = True
        Me.crvViewer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.crvViewer.Cursor = System.Windows.Forms.Cursors.Default
        Me.crvViewer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.crvViewer.Location = New System.Drawing.Point(0, 0)
        Me.crvViewer.Margin = New System.Windows.Forms.Padding(2)
        Me.crvViewer.Name = "crvViewer"
        Me.crvViewer.Size = New System.Drawing.Size(316, 310)
        Me.crvViewer.TabIndex = 0
        Me.crvViewer.ToolPanelWidth = 150
        '
        'frmViewReports
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(316, 310)
        Me.Controls.Add(Me.crvViewer)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "frmViewReports"
        Me.Text = "frmViewReports"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents crvViewer As CrystalDecisions.Windows.Forms.CrystalReportViewer
End Class
