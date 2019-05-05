<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmAddAndDeleteQuotes
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAddAndDeleteQuotes))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.btnTSAdd = New System.Windows.Forms.ToolStripButton()
        Me.btnTSDelete = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnTSDeleteAll = New System.Windows.Forms.ToolStripButton()
        Me.dgvDisplayQuoes = New System.Windows.Forms.DataGridView()
        Me.openImageDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.dgvDisplayQuoes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.ToolStrip1.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnTSAdd, Me.btnTSDelete, Me.ToolStripSeparator1, Me.btnTSDeleteAll})
        Me.ToolStrip1.Location = New System.Drawing.Point(14, 19)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(318, 45)
        Me.ToolStrip1.TabIndex = 3
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'btnTSAdd
        '
        Me.btnTSAdd.Image = CType(resources.GetObject("btnTSAdd.Image"), System.Drawing.Image)
        Me.btnTSAdd.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnTSAdd.Name = "btnTSAdd"
        Me.btnTSAdd.Size = New System.Drawing.Size(92, 42)
        Me.btnTSAdd.Text = "&Add Quotes"
        Me.btnTSAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'btnTSDelete
        '
        Me.btnTSDelete.Image = CType(resources.GetObject("btnTSDelete.Image"), System.Drawing.Image)
        Me.btnTSDelete.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnTSDelete.Name = "btnTSDelete"
        Me.btnTSDelete.Size = New System.Drawing.Size(116, 42)
        Me.btnTSDelete.Text = "&Delete Quotes"
        Me.btnTSDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 45)
        '
        'btnTSDeleteAll
        '
        Me.btnTSDeleteAll.Image = CType(resources.GetObject("btnTSDeleteAll.Image"), System.Drawing.Image)
        Me.btnTSDeleteAll.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnTSDeleteAll.Name = "btnTSDeleteAll"
        Me.btnTSDeleteAll.Size = New System.Drawing.Size(92, 42)
        Me.btnTSDeleteAll.Text = "Delete All"
        Me.btnTSDeleteAll.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'dgvDisplayQuoes
        '
        Me.dgvDisplayQuoes.AllowUserToAddRows = False
        Me.dgvDisplayQuoes.AllowUserToDeleteRows = False
        Me.dgvDisplayQuoes.AllowUserToResizeColumns = False
        Me.dgvDisplayQuoes.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.DeepSkyBlue
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvDisplayQuoes.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvDisplayQuoes.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvDisplayQuoes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.dgvDisplayQuoes.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvDisplayQuoes.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvDisplayQuoes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvDisplayQuoes.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgvDisplayQuoes.Location = New System.Drawing.Point(14, 90)
        Me.dgvDisplayQuoes.Name = "dgvDisplayQuoes"
        Me.dgvDisplayQuoes.RowTemplate.Height = 24
        Me.dgvDisplayQuoes.Size = New System.Drawing.Size(795, 510)
        Me.dgvDisplayQuoes.TabIndex = 2
        '
        'openImageDialog1
        '
        Me.openImageDialog1.FileName = "OpenFileDialog1"
        '
        'frmAddAndDeleteQuotes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(821, 618)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.dgvDisplayQuoes)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmAddAndDeleteQuotes"
        Me.Text = "Add And Delete"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.dgvDisplayQuoes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents btnTSAdd As ToolStripButton
    Friend WithEvents btnTSDelete As ToolStripButton
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents btnTSDeleteAll As ToolStripButton
    Friend WithEvents dgvDisplayQuoes As DataGridView
    Friend WithEvents openImageDialog1 As OpenFileDialog
End Class
