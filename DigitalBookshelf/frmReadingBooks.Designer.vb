<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmReadingBooks
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmReadingBooks))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.btnTSAddBokk = New System.Windows.Forms.ToolStripButton()
        Me.btnTSDeleteBook = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnTSModifyBooks = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.dgvDispalyBooks = New System.Windows.Forms.DataGridView()
        Me.cmnuDataGridView = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.cmnuDataGridViewRead = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmnuDataGridViewWantToRead = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmnuDataGridViewCurrentlyReading = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmnuDataGridViewNotRead = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem9 = New System.Windows.Forms.ToolStripSeparator()
        Me.DeleteBookToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ModifyBookToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem10 = New System.Windows.Forms.ToolStripSeparator()
        Me.cmnuDataGridViewRating = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmnuDataGridViewRating1Star = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmnuDataGridViewRating2Star = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmnuDataGridViewRating3Star = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmnuDataGridViewRating4Star = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmnuDataGridViewRating5Star = New System.Windows.Forms.ToolStripMenuItem()
        Me.rtxtDescription = New System.Windows.Forms.RichTextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.dgvDispalyBooks, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.cmnuDataGridView.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(25, 25)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnTSAddBokk, Me.btnTSDeleteBook, Me.ToolStripSeparator1, Me.btnTSModifyBooks, Me.ToolStripSeparator2})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1036, 53)
        Me.ToolStrip1.TabIndex = 13
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'btnTSAddBokk
        '
        Me.btnTSAddBokk.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnTSAddBokk.Image = CType(resources.GetObject("btnTSAddBokk.Image"), System.Drawing.Image)
        Me.btnTSAddBokk.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnTSAddBokk.Margin = New System.Windows.Forms.Padding(3)
        Me.btnTSAddBokk.Name = "btnTSAddBokk"
        Me.btnTSAddBokk.Size = New System.Drawing.Size(76, 47)
        Me.btnTSAddBokk.Text = "&Add Book"
        Me.btnTSAddBokk.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnTSAddBokk.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnTSAddBokk.ToolTipText = "Add New Book "
        '
        'btnTSDeleteBook
        '
        Me.btnTSDeleteBook.Image = CType(resources.GetObject("btnTSDeleteBook.Image"), System.Drawing.Image)
        Me.btnTSDeleteBook.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnTSDeleteBook.Name = "btnTSDeleteBook"
        Me.btnTSDeleteBook.Size = New System.Drawing.Size(100, 50)
        Me.btnTSDeleteBook.Text = "&Delete Book"
        Me.btnTSDeleteBook.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnTSDeleteBook.ToolTipText = "Select from list to delete a book"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 53)
        '
        'btnTSModifyBooks
        '
        Me.btnTSModifyBooks.Image = CType(resources.GetObject("btnTSModifyBooks.Image"), System.Drawing.Image)
        Me.btnTSModifyBooks.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnTSModifyBooks.Name = "btnTSModifyBooks"
        Me.btnTSModifyBooks.Size = New System.Drawing.Size(100, 50)
        Me.btnTSModifyBooks.Text = "&Modify Book"
        Me.btnTSModifyBooks.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 53)
        '
        'dgvDispalyBooks
        '
        Me.dgvDispalyBooks.AllowUserToAddRows = False
        Me.dgvDispalyBooks.AllowUserToResizeColumns = False
        Me.dgvDispalyBooks.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.DeepSkyBlue
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        Me.dgvDispalyBooks.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvDispalyBooks.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvDispalyBooks.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvDispalyBooks.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgvDispalyBooks.BackgroundColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvDispalyBooks.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvDispalyBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDispalyBooks.ContextMenuStrip = Me.cmnuDataGridView
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvDispalyBooks.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgvDispalyBooks.Location = New System.Drawing.Point(13, 59)
        Me.dgvDispalyBooks.Name = "dgvDispalyBooks"
        Me.dgvDispalyBooks.RowHeadersVisible = False
        Me.dgvDispalyBooks.RowTemplate.Height = 24
        Me.dgvDispalyBooks.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvDispalyBooks.Size = New System.Drawing.Size(1011, 432)
        Me.dgvDispalyBooks.TabIndex = 14
        '
        'cmnuDataGridView
        '
        Me.cmnuDataGridView.Font = New System.Drawing.Font("Constantia", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmnuDataGridView.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.cmnuDataGridView.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmnuDataGridViewRead, Me.cmnuDataGridViewWantToRead, Me.cmnuDataGridViewCurrentlyReading, Me.cmnuDataGridViewNotRead, Me.ToolStripMenuItem9, Me.DeleteBookToolStripMenuItem, Me.ModifyBookToolStripMenuItem, Me.ToolStripMenuItem10, Me.cmnuDataGridViewRating})
        Me.cmnuDataGridView.Name = "cmnuDataGridView"
        Me.cmnuDataGridView.Size = New System.Drawing.Size(215, 226)
        '
        'cmnuDataGridViewRead
        '
        Me.cmnuDataGridViewRead.Name = "cmnuDataGridViewRead"
        Me.cmnuDataGridViewRead.Size = New System.Drawing.Size(214, 26)
        Me.cmnuDataGridViewRead.Tag = "Read"
        Me.cmnuDataGridViewRead.Text = "Read"
        '
        'cmnuDataGridViewWantToRead
        '
        Me.cmnuDataGridViewWantToRead.Name = "cmnuDataGridViewWantToRead"
        Me.cmnuDataGridViewWantToRead.Size = New System.Drawing.Size(214, 26)
        Me.cmnuDataGridViewWantToRead.Tag = "Want to Read"
        Me.cmnuDataGridViewWantToRead.Text = "Want To Read"
        '
        'cmnuDataGridViewCurrentlyReading
        '
        Me.cmnuDataGridViewCurrentlyReading.Name = "cmnuDataGridViewCurrentlyReading"
        Me.cmnuDataGridViewCurrentlyReading.Size = New System.Drawing.Size(214, 26)
        Me.cmnuDataGridViewCurrentlyReading.Tag = "Currently Reading"
        Me.cmnuDataGridViewCurrentlyReading.Text = "Currently Reading"
        '
        'cmnuDataGridViewNotRead
        '
        Me.cmnuDataGridViewNotRead.Name = "cmnuDataGridViewNotRead"
        Me.cmnuDataGridViewNotRead.Size = New System.Drawing.Size(214, 26)
        Me.cmnuDataGridViewNotRead.Tag = "Not Read"
        Me.cmnuDataGridViewNotRead.Text = "Not Read"
        '
        'ToolStripMenuItem9
        '
        Me.ToolStripMenuItem9.Name = "ToolStripMenuItem9"
        Me.ToolStripMenuItem9.Size = New System.Drawing.Size(211, 6)
        '
        'DeleteBookToolStripMenuItem
        '
        Me.DeleteBookToolStripMenuItem.Image = CType(resources.GetObject("DeleteBookToolStripMenuItem.Image"), System.Drawing.Image)
        Me.DeleteBookToolStripMenuItem.Name = "DeleteBookToolStripMenuItem"
        Me.DeleteBookToolStripMenuItem.Size = New System.Drawing.Size(214, 26)
        Me.DeleteBookToolStripMenuItem.Text = "&Delete Book"
        '
        'ModifyBookToolStripMenuItem
        '
        Me.ModifyBookToolStripMenuItem.Image = CType(resources.GetObject("ModifyBookToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ModifyBookToolStripMenuItem.Name = "ModifyBookToolStripMenuItem"
        Me.ModifyBookToolStripMenuItem.Size = New System.Drawing.Size(214, 26)
        Me.ModifyBookToolStripMenuItem.Text = "Modify Book"
        '
        'ToolStripMenuItem10
        '
        Me.ToolStripMenuItem10.Name = "ToolStripMenuItem10"
        Me.ToolStripMenuItem10.Size = New System.Drawing.Size(211, 6)
        '
        'cmnuDataGridViewRating
        '
        Me.cmnuDataGridViewRating.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmnuDataGridViewRating1Star, Me.cmnuDataGridViewRating2Star, Me.cmnuDataGridViewRating3Star, Me.cmnuDataGridViewRating4Star, Me.cmnuDataGridViewRating5Star})
        Me.cmnuDataGridViewRating.Name = "cmnuDataGridViewRating"
        Me.cmnuDataGridViewRating.Size = New System.Drawing.Size(214, 26)
        Me.cmnuDataGridViewRating.Text = "Rating"
        '
        'cmnuDataGridViewRating1Star
        '
        Me.cmnuDataGridViewRating1Star.Name = "cmnuDataGridViewRating1Star"
        Me.cmnuDataGridViewRating1Star.Size = New System.Drawing.Size(216, 26)
        Me.cmnuDataGridViewRating1Star.Tag = "1 Star"
        Me.cmnuDataGridViewRating1Star.Text = "1 Star"
        '
        'cmnuDataGridViewRating2Star
        '
        Me.cmnuDataGridViewRating2Star.Name = "cmnuDataGridViewRating2Star"
        Me.cmnuDataGridViewRating2Star.Size = New System.Drawing.Size(216, 26)
        Me.cmnuDataGridViewRating2Star.Tag = "2 Star"
        Me.cmnuDataGridViewRating2Star.Text = "2 Star"
        '
        'cmnuDataGridViewRating3Star
        '
        Me.cmnuDataGridViewRating3Star.Name = "cmnuDataGridViewRating3Star"
        Me.cmnuDataGridViewRating3Star.Size = New System.Drawing.Size(216, 26)
        Me.cmnuDataGridViewRating3Star.Tag = "2 Star"
        Me.cmnuDataGridViewRating3Star.Text = "3 Star"
        '
        'cmnuDataGridViewRating4Star
        '
        Me.cmnuDataGridViewRating4Star.Name = "cmnuDataGridViewRating4Star"
        Me.cmnuDataGridViewRating4Star.Size = New System.Drawing.Size(216, 26)
        Me.cmnuDataGridViewRating4Star.Tag = "2 Star"
        Me.cmnuDataGridViewRating4Star.Text = "4 Star"
        '
        'cmnuDataGridViewRating5Star
        '
        Me.cmnuDataGridViewRating5Star.Name = "cmnuDataGridViewRating5Star"
        Me.cmnuDataGridViewRating5Star.Size = New System.Drawing.Size(216, 26)
        Me.cmnuDataGridViewRating5Star.Tag = "2 Star"
        Me.cmnuDataGridViewRating5Star.Text = "5 Star"
        '
        'rtxtDescription
        '
        Me.rtxtDescription.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.rtxtDescription.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rtxtDescription.Location = New System.Drawing.Point(13, 530)
        Me.rtxtDescription.Name = "rtxtDescription"
        Me.rtxtDescription.Size = New System.Drawing.Size(1011, 252)
        Me.rtxtDescription.TabIndex = 15
        Me.rtxtDescription.Text = ""
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(13, 504)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(96, 18)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Description"
        '
        'frmReadingBooks
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1036, 794)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.rtxtDescription)
        Me.Controls.Add(Me.dgvDispalyBooks)
        Me.Controls.Add(Me.ToolStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmReadingBooks"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Reading Books"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.dgvDispalyBooks, System.ComponentModel.ISupportInitialize).EndInit()
        Me.cmnuDataGridView.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents btnTSAddBokk As ToolStripButton
    Friend WithEvents btnTSDeleteBook As ToolStripButton
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents btnTSModifyBooks As ToolStripButton
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents dgvDispalyBooks As DataGridView
    Friend WithEvents rtxtDescription As RichTextBox
    Friend WithEvents cmnuDataGridView As ContextMenuStrip
    Friend WithEvents cmnuDataGridViewRead As ToolStripMenuItem
    Friend WithEvents cmnuDataGridViewWantToRead As ToolStripMenuItem
    Friend WithEvents cmnuDataGridViewCurrentlyReading As ToolStripMenuItem
    Friend WithEvents cmnuDataGridViewNotRead As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem9 As ToolStripSeparator
    Friend WithEvents DeleteBookToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ModifyBookToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem10 As ToolStripSeparator
    Friend WithEvents cmnuDataGridViewRating As ToolStripMenuItem
    Friend WithEvents cmnuDataGridViewRating1Star As ToolStripMenuItem
    Friend WithEvents cmnuDataGridViewRating2Star As ToolStripMenuItem
    Friend WithEvents cmnuDataGridViewRating3Star As ToolStripMenuItem
    Friend WithEvents cmnuDataGridViewRating4Star As ToolStripMenuItem
    Friend WithEvents cmnuDataGridViewRating5Star As ToolStripMenuItem
    Friend WithEvents Label1 As Label
End Class
