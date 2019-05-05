<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmLibrary
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLibrary))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.picAdverstising = New System.Windows.Forms.PictureBox()
        Me.cmsFrorPicQuotes = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.cmnuAddQuotes = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmnuPicQuotesDeleteQuotes = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.MenuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddBookToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteMultiBooksToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteAllBooksToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripSeparator()
        Me.NewLiabraryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuMenuCategoryShowCategory = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteCategoriesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem5 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuTSAddQoutes = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuTSDeleteQoutes = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem11 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuFilter = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuFilterAscendind = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuFilterAscendindByTitle = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuFilterAscendindByAuthor = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuFilterAscendindByPageNumber = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuFilterDescending = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuFilterDescendingByTitle = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuFilterDescendingByAuthor = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuFilterDescendingByPageNumber = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem12 = New System.Windows.Forms.ToolStripSeparator()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuCollectionReadBook = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuCollectionCurrentlyReading = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuCollectionWantToRead = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem4 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuCollectionNotRead = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem6 = New System.Windows.Forms.ToolStripSeparator()
        Me.OptionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuOptionStyleConfiguaraator = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem7 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuOptionBarChartReport = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuOptionPieChartReport = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem8 = New System.Windows.Forms.ToolStripSeparator()
        Me.HistoryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutUsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuAboutUsAboutUs = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuAboutUsPrivancyPolicy = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.TimerCountAdvertising = New System.Windows.Forms.Timer(Me.components)
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.cmsForScreen = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.cmnuStyleConfigurator = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmnuRefresh = New System.Windows.Forms.ToolStripMenuItem()
        Me.FilterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TitleToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmnuAscendingTitle = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmnuAscendingAuthor = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmnuAscendingPageNumber = New System.Windows.Forms.ToolStripMenuItem()
        Me.DescendingToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmnuDescendingTitle = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmnuDescendingAuthor = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmnuDescendingPAgeNumber = New System.Windows.Forms.ToolStripMenuItem()
        Me.ColorDialog1 = New System.Windows.Forms.ColorDialog()
        Me.lblTime = New System.Windows.Forms.Label()
        Me.timerForShowTheTime = New System.Windows.Forms.Timer(Me.components)
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.btnTSAddBokk = New System.Windows.Forms.ToolStripButton()
        Me.btnTSModifyBooks = New System.Windows.Forms.ToolStripButton()
        Me.btnTSDeleteBook = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnTSAddCategory = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnTSRefresh = New System.Windows.Forms.ToolStripButton()
        Me.dgvDisplayBooks = New System.Windows.Forms.DataGridView()
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
        Me.cmbSearching = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtSearching = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.picAdverstising, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.cmsFrorPicQuotes.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.cmsForScreen.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.dgvDisplayBooks, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.cmnuDataGridView.SuspendLayout()
        Me.SuspendLayout()
        '
        'picAdverstising
        '
        Me.picAdverstising.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.picAdverstising.BackColor = System.Drawing.Color.White
        Me.picAdverstising.ContextMenuStrip = Me.cmsFrorPicQuotes
        Me.picAdverstising.Location = New System.Drawing.Point(12, 808)
        Me.picAdverstising.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.picAdverstising.Name = "picAdverstising"
        Me.picAdverstising.Size = New System.Drawing.Size(871, 118)
        Me.picAdverstising.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.picAdverstising.TabIndex = 0
        Me.picAdverstising.TabStop = False
        '
        'cmsFrorPicQuotes
        '
        Me.cmsFrorPicQuotes.Font = New System.Drawing.Font("Constantia", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmsFrorPicQuotes.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.cmsFrorPicQuotes.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmnuAddQuotes, Me.cmnuPicQuotesDeleteQuotes})
        Me.cmsFrorPicQuotes.Name = "ContextMenuStrip1"
        Me.cmsFrorPicQuotes.Size = New System.Drawing.Size(169, 48)
        '
        'cmnuAddQuotes
        '
        Me.cmnuAddQuotes.Name = "cmnuAddQuotes"
        Me.cmnuAddQuotes.Size = New System.Drawing.Size(168, 22)
        Me.cmnuAddQuotes.Text = "Add Quotes"
        '
        'cmnuPicQuotesDeleteQuotes
        '
        Me.cmnuPicQuotesDeleteQuotes.Name = "cmnuPicQuotesDeleteQuotes"
        Me.cmnuPicQuotesDeleteQuotes.Size = New System.Drawing.Size(168, 22)
        Me.cmnuPicQuotesDeleteQuotes.Text = "Delete Quotes"
        '
        'ToolTip1
        '
        Me.ToolTip1.AutoPopDelay = 500
        Me.ToolTip1.InitialDelay = 500
        Me.ToolTip1.IsBalloon = True
        Me.ToolTip1.ReshowDelay = 100
        '
        'MenuStrip1
        '
        Me.MenuStrip1.AutoSize = False
        Me.MenuStrip1.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.MenuStrip1.Font = New System.Drawing.Font("Consolas", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuToolStripMenuItem, Me.AboutToolStripMenuItem, Me.OptionToolStripMenuItem, Me.AboutUsToolStripMenuItem, Me.ToolStripMenuItem1})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(5, 2, 0, 2)
        Me.MenuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.MenuStrip1.Size = New System.Drawing.Size(1173, 59)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'MenuToolStripMenuItem
        '
        Me.MenuToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddBookToolStripMenuItem, Me.DeleteMultiBooksToolStripMenuItem, Me.DeleteAllBooksToolStripMenuItem, Me.ToolStripMenuItem3, Me.NewLiabraryToolStripMenuItem, Me.ToolStripMenuItem5, Me.mnuTSAddQoutes, Me.mnuTSDeleteQoutes, Me.ToolStripMenuItem11, Me.mnuFilter, Me.ToolStripMenuItem2, Me.ExitToolStripMenuItem, Me.ToolStripMenuItem12})
        Me.MenuToolStripMenuItem.ForeColor = System.Drawing.Color.Black
        Me.MenuToolStripMenuItem.Name = "MenuToolStripMenuItem"
        Me.MenuToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Q), System.Windows.Forms.Keys)
        Me.MenuToolStripMenuItem.Size = New System.Drawing.Size(62, 55)
        Me.MenuToolStripMenuItem.Text = "Menu"
        '
        'AddBookToolStripMenuItem
        '
        Me.AddBookToolStripMenuItem.Image = CType(resources.GetObject("AddBookToolStripMenuItem.Image"), System.Drawing.Image)
        Me.AddBookToolStripMenuItem.Name = "AddBookToolStripMenuItem"
        Me.AddBookToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.N), System.Windows.Forms.Keys)
        Me.AddBookToolStripMenuItem.Size = New System.Drawing.Size(396, 26)
        Me.AddBookToolStripMenuItem.Text = "&Add Book"
        '
        'DeleteMultiBooksToolStripMenuItem
        '
        Me.DeleteMultiBooksToolStripMenuItem.Image = CType(resources.GetObject("DeleteMultiBooksToolStripMenuItem.Image"), System.Drawing.Image)
        Me.DeleteMultiBooksToolStripMenuItem.Name = "DeleteMultiBooksToolStripMenuItem"
        Me.DeleteMultiBooksToolStripMenuItem.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Shift) _
            Or System.Windows.Forms.Keys.D), System.Windows.Forms.Keys)
        Me.DeleteMultiBooksToolStripMenuItem.Size = New System.Drawing.Size(396, 26)
        Me.DeleteMultiBooksToolStripMenuItem.Text = "Delete Multi Books"
        '
        'DeleteAllBooksToolStripMenuItem
        '
        Me.DeleteAllBooksToolStripMenuItem.Image = CType(resources.GetObject("DeleteAllBooksToolStripMenuItem.Image"), System.Drawing.Image)
        Me.DeleteAllBooksToolStripMenuItem.Name = "DeleteAllBooksToolStripMenuItem"
        Me.DeleteAllBooksToolStripMenuItem.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Shift) _
            Or System.Windows.Forms.Keys.Delete), System.Windows.Forms.Keys)
        Me.DeleteAllBooksToolStripMenuItem.Size = New System.Drawing.Size(396, 26)
        Me.DeleteAllBooksToolStripMenuItem.Text = "Delete All Books"
        '
        'ToolStripMenuItem3
        '
        Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        Me.ToolStripMenuItem3.Size = New System.Drawing.Size(393, 6)
        '
        'NewLiabraryToolStripMenuItem
        '
        Me.NewLiabraryToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuMenuCategoryShowCategory, Me.DeleteCategoriesToolStripMenuItem})
        Me.NewLiabraryToolStripMenuItem.Image = CType(resources.GetObject("NewLiabraryToolStripMenuItem.Image"), System.Drawing.Image)
        Me.NewLiabraryToolStripMenuItem.Name = "NewLiabraryToolStripMenuItem"
        Me.NewLiabraryToolStripMenuItem.Size = New System.Drawing.Size(396, 26)
        Me.NewLiabraryToolStripMenuItem.Text = "Category"
        '
        'mnuMenuCategoryShowCategory
        '
        Me.mnuMenuCategoryShowCategory.Name = "mnuMenuCategoryShowCategory"
        Me.mnuMenuCategoryShowCategory.ShortcutKeys = CType(((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.Shift) _
            Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.mnuMenuCategoryShowCategory.Size = New System.Drawing.Size(376, 26)
        Me.mnuMenuCategoryShowCategory.Text = "&Show Categories"
        '
        'DeleteCategoriesToolStripMenuItem
        '
        Me.DeleteCategoriesToolStripMenuItem.Name = "DeleteCategoriesToolStripMenuItem"
        Me.DeleteCategoriesToolStripMenuItem.ShortcutKeys = CType(((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.Shift) _
            Or System.Windows.Forms.Keys.D), System.Windows.Forms.Keys)
        Me.DeleteCategoriesToolStripMenuItem.Size = New System.Drawing.Size(376, 26)
        Me.DeleteCategoriesToolStripMenuItem.Text = "Delete &Categories"
        '
        'ToolStripMenuItem5
        '
        Me.ToolStripMenuItem5.Name = "ToolStripMenuItem5"
        Me.ToolStripMenuItem5.Size = New System.Drawing.Size(393, 6)
        '
        'mnuTSAddQoutes
        '
        Me.mnuTSAddQoutes.Image = CType(resources.GetObject("mnuTSAddQoutes.Image"), System.Drawing.Image)
        Me.mnuTSAddQoutes.Name = "mnuTSAddQoutes"
        Me.mnuTSAddQoutes.Size = New System.Drawing.Size(396, 26)
        Me.mnuTSAddQoutes.Text = "Add Q&uotes"
        '
        'mnuTSDeleteQoutes
        '
        Me.mnuTSDeleteQoutes.Image = CType(resources.GetObject("mnuTSDeleteQoutes.Image"), System.Drawing.Image)
        Me.mnuTSDeleteQoutes.Name = "mnuTSDeleteQoutes"
        Me.mnuTSDeleteQoutes.Size = New System.Drawing.Size(396, 26)
        Me.mnuTSDeleteQoutes.Text = "De&lete Quotes"
        '
        'ToolStripMenuItem11
        '
        Me.ToolStripMenuItem11.Name = "ToolStripMenuItem11"
        Me.ToolStripMenuItem11.Size = New System.Drawing.Size(393, 6)
        '
        'mnuFilter
        '
        Me.mnuFilter.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuFilterAscendind, Me.mnuFilterDescending})
        Me.mnuFilter.Image = CType(resources.GetObject("mnuFilter.Image"), System.Drawing.Image)
        Me.mnuFilter.Name = "mnuFilter"
        Me.mnuFilter.Size = New System.Drawing.Size(396, 26)
        Me.mnuFilter.Text = "&Filter"
        '
        'mnuFilterAscendind
        '
        Me.mnuFilterAscendind.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuFilterAscendindByTitle, Me.mnuFilterAscendindByAuthor, Me.mnuFilterAscendindByPageNumber})
        Me.mnuFilterAscendind.Name = "mnuFilterAscendind"
        Me.mnuFilterAscendind.Size = New System.Drawing.Size(246, 26)
        Me.mnuFilterAscendind.Text = "Ascenting  (A-Z)"
        '
        'mnuFilterAscendindByTitle
        '
        Me.mnuFilterAscendindByTitle.Name = "mnuFilterAscendindByTitle"
        Me.mnuFilterAscendindByTitle.Size = New System.Drawing.Size(216, 26)
        Me.mnuFilterAscendindByTitle.Text = "Title"
        '
        'mnuFilterAscendindByAuthor
        '
        Me.mnuFilterAscendindByAuthor.Name = "mnuFilterAscendindByAuthor"
        Me.mnuFilterAscendindByAuthor.Size = New System.Drawing.Size(216, 26)
        Me.mnuFilterAscendindByAuthor.Text = "Author"
        '
        'mnuFilterAscendindByPageNumber
        '
        Me.mnuFilterAscendindByPageNumber.Name = "mnuFilterAscendindByPageNumber"
        Me.mnuFilterAscendindByPageNumber.Size = New System.Drawing.Size(216, 26)
        Me.mnuFilterAscendindByPageNumber.Text = "Page Number"
        '
        'mnuFilterDescending
        '
        Me.mnuFilterDescending.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuFilterDescendingByTitle, Me.mnuFilterDescendingByAuthor, Me.mnuFilterDescendingByPageNumber})
        Me.mnuFilterDescending.Name = "mnuFilterDescending"
        Me.mnuFilterDescending.Size = New System.Drawing.Size(246, 26)
        Me.mnuFilterDescending.Text = "Descending (Z-A)"
        '
        'mnuFilterDescendingByTitle
        '
        Me.mnuFilterDescendingByTitle.Name = "mnuFilterDescendingByTitle"
        Me.mnuFilterDescendingByTitle.Size = New System.Drawing.Size(196, 26)
        Me.mnuFilterDescendingByTitle.Text = "Title"
        '
        'mnuFilterDescendingByAuthor
        '
        Me.mnuFilterDescendingByAuthor.Name = "mnuFilterDescendingByAuthor"
        Me.mnuFilterDescendingByAuthor.Size = New System.Drawing.Size(196, 26)
        Me.mnuFilterDescendingByAuthor.Text = "Author"
        '
        'mnuFilterDescendingByPageNumber
        '
        Me.mnuFilterDescendingByPageNumber.Name = "mnuFilterDescendingByPageNumber"
        Me.mnuFilterDescendingByPageNumber.Size = New System.Drawing.Size(196, 26)
        Me.mnuFilterDescendingByPageNumber.Text = "Page Number"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(393, 6)
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Image = CType(resources.GetObject("ExitToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Q), System.Windows.Forms.Keys)
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(396, 26)
        Me.ExitToolStripMenuItem.Text = "E&xit"
        '
        'ToolStripMenuItem12
        '
        Me.ToolStripMenuItem12.Name = "ToolStripMenuItem12"
        Me.ToolStripMenuItem12.Size = New System.Drawing.Size(393, 6)
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuCollectionReadBook, Me.mnuCollectionCurrentlyReading, Me.mnuCollectionWantToRead, Me.ToolStripMenuItem4, Me.mnuCollectionNotRead, Me.ToolStripMenuItem6})
        Me.AboutToolStripMenuItem.ForeColor = System.Drawing.Color.Black
        Me.AboutToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Firebrick
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Alt) _
            Or System.Windows.Forms.Keys.L), System.Windows.Forms.Keys)
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(132, 55)
        Me.AboutToolStripMenuItem.Text = "Collections"
        '
        'mnuCollectionReadBook
        '
        Me.mnuCollectionReadBook.Name = "mnuCollectionReadBook"
        Me.mnuCollectionReadBook.ShortcutKeys = CType(((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.Shift) _
            Or System.Windows.Forms.Keys.R), System.Windows.Forms.Keys)
        Me.mnuCollectionReadBook.Size = New System.Drawing.Size(366, 26)
        Me.mnuCollectionReadBook.Tag = "Read"
        Me.mnuCollectionReadBook.Text = "Read Book"
        '
        'mnuCollectionCurrentlyReading
        '
        Me.mnuCollectionCurrentlyReading.Name = "mnuCollectionCurrentlyReading"
        Me.mnuCollectionCurrentlyReading.ShortcutKeys = CType(((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.Shift) _
            Or System.Windows.Forms.Keys.C), System.Windows.Forms.Keys)
        Me.mnuCollectionCurrentlyReading.Size = New System.Drawing.Size(366, 26)
        Me.mnuCollectionCurrentlyReading.Tag = "Currently Reading"
        Me.mnuCollectionCurrentlyReading.Text = "Curently Reading"
        '
        'mnuCollectionWantToRead
        '
        Me.mnuCollectionWantToRead.Name = "mnuCollectionWantToRead"
        Me.mnuCollectionWantToRead.ShortcutKeys = CType(((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.Shift) _
            Or System.Windows.Forms.Keys.W), System.Windows.Forms.Keys)
        Me.mnuCollectionWantToRead.Size = New System.Drawing.Size(366, 26)
        Me.mnuCollectionWantToRead.Tag = "Want to Read"
        Me.mnuCollectionWantToRead.Text = "Want to Read"
        '
        'ToolStripMenuItem4
        '
        Me.ToolStripMenuItem4.Name = "ToolStripMenuItem4"
        Me.ToolStripMenuItem4.Size = New System.Drawing.Size(363, 6)
        '
        'mnuCollectionNotRead
        '
        Me.mnuCollectionNotRead.Name = "mnuCollectionNotRead"
        Me.mnuCollectionNotRead.ShortcutKeys = CType(((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.Shift) _
            Or System.Windows.Forms.Keys.N), System.Windows.Forms.Keys)
        Me.mnuCollectionNotRead.Size = New System.Drawing.Size(366, 26)
        Me.mnuCollectionNotRead.Tag = "Not Read"
        Me.mnuCollectionNotRead.Text = "Not Read"
        '
        'ToolStripMenuItem6
        '
        Me.ToolStripMenuItem6.Name = "ToolStripMenuItem6"
        Me.ToolStripMenuItem6.Size = New System.Drawing.Size(363, 6)
        '
        'OptionToolStripMenuItem
        '
        Me.OptionToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuOptionStyleConfiguaraator, Me.ToolStripMenuItem7, Me.mnuOptionBarChartReport, Me.mnuOptionPieChartReport, Me.ToolStripMenuItem8, Me.HistoryToolStripMenuItem})
        Me.OptionToolStripMenuItem.ForeColor = System.Drawing.Color.Black
        Me.OptionToolStripMenuItem.Name = "OptionToolStripMenuItem"
        Me.OptionToolStripMenuItem.Size = New System.Drawing.Size(82, 55)
        Me.OptionToolStripMenuItem.Text = "Option"
        '
        'mnuOptionStyleConfiguaraator
        '
        Me.mnuOptionStyleConfiguaraator.Name = "mnuOptionStyleConfiguaraator"
        Me.mnuOptionStyleConfiguaraator.Size = New System.Drawing.Size(276, 26)
        Me.mnuOptionStyleConfiguaraator.Text = "Style Configuarator"
        '
        'ToolStripMenuItem7
        '
        Me.ToolStripMenuItem7.Name = "ToolStripMenuItem7"
        Me.ToolStripMenuItem7.Size = New System.Drawing.Size(273, 6)
        '
        'mnuOptionBarChartReport
        '
        Me.mnuOptionBarChartReport.Image = CType(resources.GetObject("mnuOptionBarChartReport.Image"), System.Drawing.Image)
        Me.mnuOptionBarChartReport.Name = "mnuOptionBarChartReport"
        Me.mnuOptionBarChartReport.Size = New System.Drawing.Size(276, 26)
        Me.mnuOptionBarChartReport.Text = "Bar Chart Report"
        '
        'mnuOptionPieChartReport
        '
        Me.mnuOptionPieChartReport.Image = CType(resources.GetObject("mnuOptionPieChartReport.Image"), System.Drawing.Image)
        Me.mnuOptionPieChartReport.Name = "mnuOptionPieChartReport"
        Me.mnuOptionPieChartReport.Size = New System.Drawing.Size(276, 26)
        Me.mnuOptionPieChartReport.Text = "Pie Chart Report"
        '
        'ToolStripMenuItem8
        '
        Me.ToolStripMenuItem8.Name = "ToolStripMenuItem8"
        Me.ToolStripMenuItem8.Size = New System.Drawing.Size(273, 6)
        '
        'HistoryToolStripMenuItem
        '
        Me.HistoryToolStripMenuItem.Name = "HistoryToolStripMenuItem"
        Me.HistoryToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.H), System.Windows.Forms.Keys)
        Me.HistoryToolStripMenuItem.Size = New System.Drawing.Size(276, 26)
        Me.HistoryToolStripMenuItem.Text = "History"
        '
        'AboutUsToolStripMenuItem
        '
        Me.AboutUsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuAboutUsAboutUs, Me.mnuAboutUsPrivancyPolicy})
        Me.AboutUsToolStripMenuItem.ForeColor = System.Drawing.Color.Black
        Me.AboutUsToolStripMenuItem.Name = "AboutUsToolStripMenuItem"
        Me.AboutUsToolStripMenuItem.Size = New System.Drawing.Size(102, 55)
        Me.AboutUsToolStripMenuItem.Text = "About us"
        '
        'mnuAboutUsAboutUs
        '
        Me.mnuAboutUsAboutUs.Name = "mnuAboutUsAboutUs"
        Me.mnuAboutUsAboutUs.Size = New System.Drawing.Size(226, 26)
        Me.mnuAboutUsAboutUs.Text = "About &us"
        '
        'mnuAboutUsPrivancyPolicy
        '
        Me.mnuAboutUsPrivancyPolicy.Image = CType(resources.GetObject("mnuAboutUsPrivancyPolicy.Image"), System.Drawing.Image)
        Me.mnuAboutUsPrivancyPolicy.Name = "mnuAboutUsPrivancyPolicy"
        Me.mnuAboutUsPrivancyPolicy.ShortcutKeys = CType(((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.Shift) _
            Or System.Windows.Forms.Keys.P), System.Windows.Forms.Keys)
        Me.mnuAboutUsPrivancyPolicy.ShowShortcutKeys = False
        Me.mnuAboutUsPrivancyPolicy.Size = New System.Drawing.Size(226, 26)
        Me.mnuAboutUsPrivancyPolicy.Text = "Privancy Policy"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.ForeColor = System.Drawing.Color.Black
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(32, 55)
        Me.ToolStripMenuItem1.Text = "|"
        '
        'TimerCountAdvertising
        '
        Me.TimerCountAdvertising.Interval = 4000
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(902, 808)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(255, 118)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 8
        Me.PictureBox1.TabStop = False
        '
        'cmsForScreen
        '
        Me.cmsForScreen.Font = New System.Drawing.Font("Constantia", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmsForScreen.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.cmsForScreen.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmnuStyleConfigurator, Me.cmnuRefresh, Me.FilterToolStripMenuItem})
        Me.cmsForScreen.Name = "cmsForScreen"
        Me.cmsForScreen.Size = New System.Drawing.Size(204, 70)
        '
        'cmnuStyleConfigurator
        '
        Me.cmnuStyleConfigurator.Name = "cmnuStyleConfigurator"
        Me.cmnuStyleConfigurator.Size = New System.Drawing.Size(203, 22)
        Me.cmnuStyleConfigurator.Text = "Style Configuarator"
        '
        'cmnuRefresh
        '
        Me.cmnuRefresh.Name = "cmnuRefresh"
        Me.cmnuRefresh.Size = New System.Drawing.Size(203, 22)
        Me.cmnuRefresh.Text = "&Refresh"
        '
        'FilterToolStripMenuItem
        '
        Me.FilterToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TitleToolStripMenuItem, Me.DescendingToolStripMenuItem})
        Me.FilterToolStripMenuItem.Name = "FilterToolStripMenuItem"
        Me.FilterToolStripMenuItem.Size = New System.Drawing.Size(203, 22)
        Me.FilterToolStripMenuItem.Text = "Filter"
        '
        'TitleToolStripMenuItem
        '
        Me.TitleToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmnuAscendingTitle, Me.cmnuAscendingAuthor, Me.cmnuAscendingPageNumber})
        Me.TitleToolStripMenuItem.Name = "TitleToolStripMenuItem"
        Me.TitleToolStripMenuItem.Size = New System.Drawing.Size(159, 26)
        Me.TitleToolStripMenuItem.Text = "Ascending"
        '
        'cmnuAscendingTitle
        '
        Me.cmnuAscendingTitle.Name = "cmnuAscendingTitle"
        Me.cmnuAscendingTitle.Size = New System.Drawing.Size(171, 26)
        Me.cmnuAscendingTitle.Text = "Title"
        '
        'cmnuAscendingAuthor
        '
        Me.cmnuAscendingAuthor.Name = "cmnuAscendingAuthor"
        Me.cmnuAscendingAuthor.Size = New System.Drawing.Size(171, 26)
        Me.cmnuAscendingAuthor.Text = "Author"
        '
        'cmnuAscendingPageNumber
        '
        Me.cmnuAscendingPageNumber.Name = "cmnuAscendingPageNumber"
        Me.cmnuAscendingPageNumber.Size = New System.Drawing.Size(171, 26)
        Me.cmnuAscendingPageNumber.Text = "Page Number"
        '
        'DescendingToolStripMenuItem
        '
        Me.DescendingToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmnuDescendingTitle, Me.cmnuDescendingAuthor, Me.cmnuDescendingPAgeNumber})
        Me.DescendingToolStripMenuItem.Name = "DescendingToolStripMenuItem"
        Me.DescendingToolStripMenuItem.Size = New System.Drawing.Size(159, 26)
        Me.DescendingToolStripMenuItem.Text = "Descending"
        '
        'cmnuDescendingTitle
        '
        Me.cmnuDescendingTitle.Name = "cmnuDescendingTitle"
        Me.cmnuDescendingTitle.Size = New System.Drawing.Size(171, 26)
        Me.cmnuDescendingTitle.Text = "Title"
        '
        'cmnuDescendingAuthor
        '
        Me.cmnuDescendingAuthor.Name = "cmnuDescendingAuthor"
        Me.cmnuDescendingAuthor.Size = New System.Drawing.Size(171, 26)
        Me.cmnuDescendingAuthor.Text = "Author"
        '
        'cmnuDescendingPAgeNumber
        '
        Me.cmnuDescendingPAgeNumber.Name = "cmnuDescendingPAgeNumber"
        Me.cmnuDescendingPAgeNumber.Size = New System.Drawing.Size(171, 26)
        Me.cmnuDescendingPAgeNumber.Text = "Page Number"
        '
        'lblTime
        '
        Me.lblTime.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblTime.AutoSize = True
        Me.lblTime.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTime.Location = New System.Drawing.Point(939, 18)
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(0, 18)
        Me.lblTime.TabIndex = 10
        '
        'timerForShowTheTime
        '
        Me.timerForShowTheTime.Enabled = True
        Me.timerForShowTheTime.Interval = 1000
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.Color.Transparent
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.ToolStrip1.Font = New System.Drawing.Font("Consolas", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnTSAddBokk, Me.btnTSModifyBooks, Me.btnTSDeleteBook, Me.ToolStripSeparator1, Me.btnTSAddCategory, Me.ToolStripSeparator3, Me.btnTSRefresh})
        Me.ToolStrip1.Location = New System.Drawing.Point(4, 59)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.ToolStrip1.Size = New System.Drawing.Size(545, 50)
        Me.ToolStrip1.TabIndex = 12
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'btnTSAddBokk
        '
        Me.btnTSAddBokk.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnTSAddBokk.Image = CType(resources.GetObject("btnTSAddBokk.Image"), System.Drawing.Image)
        Me.btnTSAddBokk.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnTSAddBokk.Margin = New System.Windows.Forms.Padding(3)
        Me.btnTSAddBokk.Name = "btnTSAddBokk"
        Me.btnTSAddBokk.Size = New System.Drawing.Size(85, 44)
        Me.btnTSAddBokk.Text = "&Add Book"
        Me.btnTSAddBokk.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnTSAddBokk.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnTSAddBokk.ToolTipText = "Add New Book "
        '
        'btnTSModifyBooks
        '
        Me.btnTSModifyBooks.Image = CType(resources.GetObject("btnTSModifyBooks.Image"), System.Drawing.Image)
        Me.btnTSModifyBooks.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnTSModifyBooks.Name = "btnTSModifyBooks"
        Me.btnTSModifyBooks.Size = New System.Drawing.Size(112, 47)
        Me.btnTSModifyBooks.Text = "&Modify Book"
        Me.btnTSModifyBooks.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'btnTSDeleteBook
        '
        Me.btnTSDeleteBook.Image = CType(resources.GetObject("btnTSDeleteBook.Image"), System.Drawing.Image)
        Me.btnTSDeleteBook.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnTSDeleteBook.Name = "btnTSDeleteBook"
        Me.btnTSDeleteBook.Size = New System.Drawing.Size(112, 47)
        Me.btnTSDeleteBook.Text = "&Delete Book"
        Me.btnTSDeleteBook.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnTSDeleteBook.ToolTipText = "Select from list to delete a book"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 50)
        '
        'btnTSAddCategory
        '
        Me.btnTSAddCategory.Image = CType(resources.GetObject("btnTSAddCategory.Image"), System.Drawing.Image)
        Me.btnTSAddCategory.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnTSAddCategory.Name = "btnTSAddCategory"
        Me.btnTSAddCategory.Size = New System.Drawing.Size(130, 47)
        Me.btnTSAddCategory.Text = "&Show Category"
        Me.btnTSAddCategory.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnTSAddCategory.ToolTipText = "Add new Category " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "eg. Fantasy, Comedy, Crime"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 50)
        '
        'btnTSRefresh
        '
        Me.btnTSRefresh.Image = CType(resources.GetObject("btnTSRefresh.Image"), System.Drawing.Image)
        Me.btnTSRefresh.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnTSRefresh.Name = "btnTSRefresh"
        Me.btnTSRefresh.Size = New System.Drawing.Size(76, 47)
        Me.btnTSRefresh.Text = "&Refresh"
        Me.btnTSRefresh.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'dgvDisplayBooks
        '
        Me.dgvDisplayBooks.AllowUserToOrderColumns = True
        Me.dgvDisplayBooks.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.DeepSkyBlue
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvDisplayBooks.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvDisplayBooks.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvDisplayBooks.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvDisplayBooks.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders
        Me.dgvDisplayBooks.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ControlLight
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Consolas", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvDisplayBooks.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvDisplayBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDisplayBooks.ContextMenuStrip = Me.cmnuDataGridView
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.MenuBar
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvDisplayBooks.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgvDisplayBooks.Location = New System.Drawing.Point(13, 198)
        Me.dgvDisplayBooks.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.dgvDisplayBooks.MultiSelect = False
        Me.dgvDisplayBooks.Name = "dgvDisplayBooks"
        Me.dgvDisplayBooks.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgvDisplayBooks.RowHeadersVisible = False
        Me.dgvDisplayBooks.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvDisplayBooks.Size = New System.Drawing.Size(1144, 594)
        Me.dgvDisplayBooks.TabIndex = 0
        Me.dgvDisplayBooks.TabStop = False
        '
        'cmnuDataGridView
        '
        Me.cmnuDataGridView.Font = New System.Drawing.Font("Constantia", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmnuDataGridView.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.cmnuDataGridView.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmnuDataGridViewRead, Me.cmnuDataGridViewWantToRead, Me.cmnuDataGridViewCurrentlyReading, Me.cmnuDataGridViewNotRead, Me.ToolStripMenuItem9, Me.DeleteBookToolStripMenuItem, Me.ModifyBookToolStripMenuItem, Me.ToolStripMenuItem10, Me.cmnuDataGridViewRating})
        Me.cmnuDataGridView.Name = "cmnuDataGridView"
        Me.cmnuDataGridView.Size = New System.Drawing.Size(201, 198)
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
        Me.cmnuDataGridViewRating1Star.Size = New System.Drawing.Size(120, 26)
        Me.cmnuDataGridViewRating1Star.Tag = "1 Star"
        Me.cmnuDataGridViewRating1Star.Text = "1 Star"
        '
        'cmnuDataGridViewRating2Star
        '
        Me.cmnuDataGridViewRating2Star.Name = "cmnuDataGridViewRating2Star"
        Me.cmnuDataGridViewRating2Star.Size = New System.Drawing.Size(120, 26)
        Me.cmnuDataGridViewRating2Star.Tag = "2 Star"
        Me.cmnuDataGridViewRating2Star.Text = "2 Star"
        '
        'cmnuDataGridViewRating3Star
        '
        Me.cmnuDataGridViewRating3Star.Name = "cmnuDataGridViewRating3Star"
        Me.cmnuDataGridViewRating3Star.Size = New System.Drawing.Size(120, 26)
        Me.cmnuDataGridViewRating3Star.Tag = "2 Star"
        Me.cmnuDataGridViewRating3Star.Text = "3 Star"
        '
        'cmnuDataGridViewRating4Star
        '
        Me.cmnuDataGridViewRating4Star.Name = "cmnuDataGridViewRating4Star"
        Me.cmnuDataGridViewRating4Star.Size = New System.Drawing.Size(120, 26)
        Me.cmnuDataGridViewRating4Star.Tag = "2 Star"
        Me.cmnuDataGridViewRating4Star.Text = "4 Star"
        '
        'cmnuDataGridViewRating5Star
        '
        Me.cmnuDataGridViewRating5Star.Name = "cmnuDataGridViewRating5Star"
        Me.cmnuDataGridViewRating5Star.Size = New System.Drawing.Size(120, 26)
        Me.cmnuDataGridViewRating5Star.Tag = "2 Star"
        Me.cmnuDataGridViewRating5Star.Text = "5 Star"
        '
        'cmbSearching
        '
        Me.cmbSearching.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbSearching.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbSearching.FormattingEnabled = True
        Me.cmbSearching.Items.AddRange(New Object() {"Author", "Category", "ISBN", "Page Number", "Title"})
        Me.cmbSearching.Location = New System.Drawing.Point(131, 142)
        Me.cmbSearching.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cmbSearching.Name = "cmbSearching"
        Me.cmbSearching.Size = New System.Drawing.Size(457, 26)
        Me.cmbSearching.Sorted = True
        Me.cmbSearching.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(633, 145)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 18)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "For:"
        '
        'txtSearching
        '
        Me.txtSearching.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearching.Location = New System.Drawing.Point(697, 142)
        Me.txtSearching.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.txtSearching.Name = "txtSearching"
        Me.txtSearching.Size = New System.Drawing.Size(213, 25)
        Me.txtSearching.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(27, 145)
        Me.Label2.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(88, 18)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "Search By:"
        '
        'frmLibrary
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1173, 942)
        Me.ContextMenuStrip = Me.cmsForScreen
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtSearching)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmbSearching)
        Me.Controls.Add(Me.dgvDisplayBooks)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.lblTime)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.picAdverstising)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "frmLibrary"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Library"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.picAdverstising, System.ComponentModel.ISupportInitialize).EndInit()
        Me.cmsFrorPicQuotes.ResumeLayout(False)
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.cmsForScreen.ResumeLayout(False)
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.dgvDisplayBooks, System.ComponentModel.ISupportInitialize).EndInit()
        Me.cmnuDataGridView.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents picAdverstising As PictureBox
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutUsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents mnuAboutUsAboutUs As ToolStripMenuItem
    Friend WithEvents mnuAboutUsPrivancyPolicy As ToolStripMenuItem
    Friend WithEvents MenuToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OptionToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents cmsFrorPicQuotes As ContextMenuStrip
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents AddBookToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NewLiabraryToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents cmnuAddQuotes As ToolStripMenuItem
    Friend WithEvents cmnuPicQuotesDeleteQuotes As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem3 As ToolStripSeparator
    Friend WithEvents ToolStripMenuItem4 As ToolStripSeparator
    Friend WithEvents mnuOptionStyleConfiguaraator As ToolStripMenuItem
    Friend WithEvents mnuOptionBarChartReport As ToolStripMenuItem
    Friend WithEvents cmsForScreen As ContextMenuStrip
    Friend WithEvents cmnuStyleConfigurator As ToolStripMenuItem
    Friend WithEvents cmnuRefresh As ToolStripMenuItem
    Friend WithEvents ColorDialog1 As ColorDialog
    Friend WithEvents mnuOptionPieChartReport As ToolStripMenuItem
    Friend WithEvents lblTime As Label
    Friend WithEvents timerForShowTheTime As Timer
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents btnTSAddBokk As ToolStripButton
    Friend WithEvents btnTSAddCategory As ToolStripButton
    Friend WithEvents btnTSDeleteBook As ToolStripButton
    Friend WithEvents HistoryToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents btnTSModifyBooks As ToolStripButton
    Friend WithEvents dgvDisplayBooks As DataGridView
    Friend WithEvents cmbSearching As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtSearching As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents mnuFilter As ToolStripMenuItem
    Friend WithEvents mnuFilterAscendind As ToolStripMenuItem
    Friend WithEvents mnuFilterAscendindByTitle As ToolStripMenuItem
    Friend WithEvents mnuFilterAscendindByAuthor As ToolStripMenuItem
    Friend WithEvents mnuFilterAscendindByPageNumber As ToolStripMenuItem
    Friend WithEvents mnuFilterDescending As ToolStripMenuItem
    Friend WithEvents mnuFilterDescendingByTitle As ToolStripMenuItem
    Friend WithEvents mnuFilterDescendingByAuthor As ToolStripMenuItem
    Friend WithEvents mnuFilterDescendingByPageNumber As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As ToolStripSeparator
    Friend WithEvents FilterToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TitleToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DescendingToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents cmnuDescendingTitle As ToolStripMenuItem
    Friend WithEvents cmnuDescendingAuthor As ToolStripMenuItem
    Friend WithEvents cmnuDescendingPAgeNumber As ToolStripMenuItem
    Friend WithEvents cmnuAscendingTitle As ToolStripMenuItem
    Friend WithEvents cmnuAscendingAuthor As ToolStripMenuItem
    Friend WithEvents cmnuAscendingPageNumber As ToolStripMenuItem
    Public WithEvents TimerCountAdvertising As Timer
    Friend WithEvents mnuTSAddQoutes As ToolStripMenuItem
    Friend WithEvents mnuTSDeleteQoutes As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem5 As ToolStripSeparator
    Friend WithEvents btnTSRefresh As ToolStripButton
    Friend WithEvents mnuCollectionReadBook As ToolStripMenuItem
    Friend WithEvents mnuCollectionCurrentlyReading As ToolStripMenuItem
    Friend WithEvents mnuCollectionWantToRead As ToolStripMenuItem
    Friend WithEvents mnuCollectionNotRead As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem6 As ToolStripSeparator
    Friend WithEvents ToolStripMenuItem7 As ToolStripSeparator
    Friend WithEvents ToolStripMenuItem8 As ToolStripSeparator
    Friend WithEvents cmnuDataGridView As ContextMenuStrip
    Friend WithEvents cmnuDataGridViewRead As ToolStripMenuItem
    Friend WithEvents cmnuDataGridViewWantToRead As ToolStripMenuItem
    Friend WithEvents cmnuDataGridViewCurrentlyReading As ToolStripMenuItem
    Friend WithEvents cmnuDataGridViewNotRead As ToolStripMenuItem
    Friend WithEvents cmnuDataGridViewRating As ToolStripMenuItem
    Friend WithEvents cmnuDataGridViewRating1Star As ToolStripMenuItem
    Friend WithEvents cmnuDataGridViewRating2Star As ToolStripMenuItem
    Friend WithEvents cmnuDataGridViewRating3Star As ToolStripMenuItem
    Friend WithEvents cmnuDataGridViewRating4Star As ToolStripMenuItem
    Friend WithEvents cmnuDataGridViewRating5Star As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
    Friend WithEvents ToolStripMenuItem9 As ToolStripSeparator
    Friend WithEvents ToolStripMenuItem10 As ToolStripSeparator
    Friend WithEvents mnuMenuCategoryShowCategory As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem11 As ToolStripSeparator
    Friend WithEvents DeleteAllBooksToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DeleteCategoriesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ModifyBookToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DeleteBookToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DeleteMultiBooksToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem12 As ToolStripSeparator
End Class
