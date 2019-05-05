<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCategories
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCategories))
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lstDisplayBooks = New System.Windows.Forms.ListBox()
        Me.ckblstCategories = New System.Windows.Forms.CheckedListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.tsbtnDeleteCategories = New System.Windows.Forms.ToolStripButton()
        Me.tsbtnReanmeCategory = New System.Windows.Forms.ToolStripButton()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.cmnuRename = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmnuDeleteCategories = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStrip1.SuspendLayout()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnExit
        '
        Me.btnExit.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnExit.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(723, 508)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(129, 37)
        Me.btnExit.TabIndex = 3
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lstDisplayBooks
        '
        Me.lstDisplayBooks.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lstDisplayBooks.ContextMenuStrip = Me.ContextMenuStrip1
        Me.lstDisplayBooks.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstDisplayBooks.FormattingEnabled = True
        Me.lstDisplayBooks.HorizontalScrollbar = True
        Me.lstDisplayBooks.ItemHeight = 18
        Me.lstDisplayBooks.Location = New System.Drawing.Point(369, 88)
        Me.lstDisplayBooks.Name = "lstDisplayBooks"
        Me.lstDisplayBooks.Size = New System.Drawing.Size(483, 382)
        Me.lstDisplayBooks.Sorted = True
        Me.lstDisplayBooks.TabIndex = 0
        '
        'ckblstCategories
        '
        Me.ckblstCategories.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ckblstCategories.CheckOnClick = True
        Me.ckblstCategories.ContextMenuStrip = Me.ContextMenuStrip1
        Me.ckblstCategories.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ckblstCategories.FormattingEnabled = True
        Me.ckblstCategories.Location = New System.Drawing.Point(12, 86)
        Me.ckblstCategories.Name = "ckblstCategories"
        Me.ckblstCategories.Size = New System.Drawing.Size(293, 384)
        Me.ckblstCategories.Sorted = True
        Me.ckblstCategories.TabIndex = 0
        Me.ckblstCategories.ThreeDCheckBoxes = True
        Me.ToolTip1.SetToolTip(Me.ckblstCategories, "Click on Category")
        '
        'Label1
        '
        Me.Label1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.ContextMenuStrip = Me.ContextMenuStrip1
        Me.Label1.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(366, 59)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(88, 18)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Book Title"
        '
        'Label2
        '
        Me.Label2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.ContextMenuStrip = Me.ContextMenuStrip1
        Me.Label2.Font = New System.Drawing.Font("Comic Sans MS", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 59)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(79, 19)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Categories"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.ContextMenuStrip = Me.ContextMenuStrip1
        Me.ToolStrip1.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbtnDeleteCategories, Me.tsbtnReanmeCategory})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(873, 45)
        Me.ToolStrip1.TabIndex = 6
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'tsbtnDeleteCategories
        '
        Me.tsbtnDeleteCategories.Image = CType(resources.GetObject("tsbtnDeleteCategories.Image"), System.Drawing.Image)
        Me.tsbtnDeleteCategories.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbtnDeleteCategories.Name = "tsbtnDeleteCategories"
        Me.tsbtnDeleteCategories.Size = New System.Drawing.Size(148, 42)
        Me.tsbtnDeleteCategories.Text = "&Delete Categories"
        Me.tsbtnDeleteCategories.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.tsbtnDeleteCategories.ToolTipText = "Delete the selected categoriesCategories"
        '
        'tsbtnReanmeCategory
        '
        Me.tsbtnReanmeCategory.Image = CType(resources.GetObject("tsbtnReanmeCategory.Image"), System.Drawing.Image)
        Me.tsbtnReanmeCategory.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbtnReanmeCategory.Name = "tsbtnReanmeCategory"
        Me.tsbtnReanmeCategory.Size = New System.Drawing.Size(148, 42)
        Me.tsbtnReanmeCategory.Text = "&Rename Categories"
        Me.tsbtnReanmeCategory.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmnuRename, Me.cmnuDeleteCategories})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(208, 52)
        '
        'cmnuRename
        '
        Me.cmnuRename.Name = "cmnuRename"
        Me.cmnuRename.Size = New System.Drawing.Size(207, 24)
        Me.cmnuRename.Text = "&Rename Categories"
        '
        'cmnuDeleteCategories
        '
        Me.cmnuDeleteCategories.Name = "cmnuDeleteCategories"
        Me.cmnuDeleteCategories.Size = New System.Drawing.Size(207, 24)
        Me.cmnuDeleteCategories.Text = "&Delete Categories"
        '
        'frmCategories
        '
        Me.AllowDrop = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnExit
        Me.ClientSize = New System.Drawing.Size(873, 557)
        Me.ContextMenuStrip = Me.ContextMenuStrip1
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ckblstCategories)
        Me.Controls.Add(Me.lstDisplayBooks)
        Me.Controls.Add(Me.btnExit)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmCategories"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Categories"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnExit As Button
    Friend WithEvents lstDisplayBooks As ListBox
    Friend WithEvents ckblstCategories As CheckedListBox
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents tsbtnDeleteCategories As ToolStripButton
    Friend WithEvents tsbtnReanmeCategory As ToolStripButton
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents cmnuRename As ToolStripMenuItem
    Friend WithEvents cmnuDeleteCategories As ToolStripMenuItem
End Class
