<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmPieChart
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPieChart))
        Me.picReport = New System.Windows.Forms.PictureBox()
        Me.lblFooter = New System.Windows.Forms.Label()
        CType(Me.picReport, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picReport
        '
        Me.picReport.Location = New System.Drawing.Point(12, 24)
        Me.picReport.Name = "picReport"
        Me.picReport.Size = New System.Drawing.Size(907, 608)
        Me.picReport.TabIndex = 0
        Me.picReport.TabStop = False
        '
        'lblFooter
        '
        Me.lblFooter.AutoSize = True
        Me.lblFooter.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFooter.Location = New System.Drawing.Point(12, 645)
        Me.lblFooter.Name = "lblFooter"
        Me.lblFooter.Size = New System.Drawing.Size(744, 18)
        Me.lblFooter.TabIndex = 1
        Me.lblFooter.Text = "NOTE: :perhaps Some Books have in stock twice and have deferenent Value of rating" &
    " or reading" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'frmPieChart
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(932, 674)
        Me.Controls.Add(Me.lblFooter)
        Me.Controls.Add(Me.picReport)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmPieChart"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Pie Chart"
        CType(Me.picReport, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents picReport As PictureBox
    Friend WithEvents lblFooter As Label
End Class
