<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmHistory
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
        Me.lstHistory = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'lstHistory
        '
        Me.lstHistory.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lstHistory.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstHistory.FormattingEnabled = True
        Me.lstHistory.HorizontalScrollbar = True
        Me.lstHistory.ItemHeight = 18
        Me.lstHistory.Location = New System.Drawing.Point(12, 12)
        Me.lstHistory.Name = "lstHistory"
        Me.lstHistory.SelectionMode = System.Windows.Forms.SelectionMode.None
        Me.lstHistory.Size = New System.Drawing.Size(888, 670)
        Me.lstHistory.TabIndex = 0
        Me.lstHistory.TabStop = False
        '
        'frmHistory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(912, 721)
        Me.Controls.Add(Me.lstHistory)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Name = "frmHistory"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "History"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lstHistory As ListBox
End Class
