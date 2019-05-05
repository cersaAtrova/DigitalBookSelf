<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmAddNewBook
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAddNewBook))
        Me.picCoverImage = New System.Windows.Forms.PictureBox()
        Me.btnImportImage = New System.Windows.Forms.Button()
        Me.openImageDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.txtTitle = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtAuthor = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ckblstCategories = New System.Windows.Forms.CheckedListBox()
        Me.lstCategories = New System.Windows.Forms.ListBox()
        Me.txtAddCategory = New System.Windows.Forms.TextBox()
        Me.btnAddCategory = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.txtISBN = New System.Windows.Forms.TextBox()
        Me.btnRemoveCategory = New System.Windows.Forms.Button()
        Me.txtDescription = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.NumericUpDown1 = New System.Windows.Forms.NumericUpDown()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cmbBookSelves = New System.Windows.Forms.ComboBox()
        Me.btnAddBook = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.tbRating = New System.Windows.Forms.TrackBar()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cmbRating = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        CType(Me.picCoverImage, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbRating, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picCoverImage
        '
        Me.picCoverImage.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.picCoverImage.Image = CType(resources.GetObject("picCoverImage.Image"), System.Drawing.Image)
        Me.picCoverImage.Location = New System.Drawing.Point(65, 32)
        Me.picCoverImage.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.picCoverImage.Name = "picCoverImage"
        Me.picCoverImage.Size = New System.Drawing.Size(204, 226)
        Me.picCoverImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picCoverImage.TabIndex = 0
        Me.picCoverImage.TabStop = False
        '
        'btnImportImage
        '
        Me.btnImportImage.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnImportImage.Location = New System.Drawing.Point(80, 274)
        Me.btnImportImage.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnImportImage.Name = "btnImportImage"
        Me.btnImportImage.Size = New System.Drawing.Size(168, 38)
        Me.btnImportImage.TabIndex = 0
        Me.btnImportImage.Text = "&Import Image"
        Me.btnImportImage.UseVisualStyleBackColor = True
        '
        'openImageDialog1
        '
        Me.openImageDialog1.FileName = "OpenFileDialog1"
        '
        'txtTitle
        '
        Me.txtTitle.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTitle.Location = New System.Drawing.Point(453, 57)
        Me.txtTitle.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtTitle.Name = "txtTitle"
        Me.txtTitle.Size = New System.Drawing.Size(340, 25)
        Me.txtTitle.TabIndex = 1
        Me.ToolTip1.SetToolTip(Me.txtTitle, "Enter a title of thebook")
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(379, 59)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(48, 18)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Title"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(371, 111)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 18)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Author"
        '
        'txtAuthor
        '
        Me.txtAuthor.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAuthor.Location = New System.Drawing.Point(453, 108)
        Me.txtAuthor.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtAuthor.Name = "txtAuthor"
        Me.txtAuthor.Size = New System.Drawing.Size(340, 25)
        Me.txtAuthor.TabIndex = 2
        Me.ToolTip1.SetToolTip(Me.txtAuthor, "Enter author")
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(323, 156)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(104, 18)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "New Category"
        '
        'ckblstCategories
        '
        Me.ckblstCategories.CheckOnClick = True
        Me.ckblstCategories.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ckblstCategories.FormattingEnabled = True
        Me.ckblstCategories.Location = New System.Drawing.Point(453, 208)
        Me.ckblstCategories.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ckblstCategories.Name = "ckblstCategories"
        Me.ckblstCategories.Size = New System.Drawing.Size(211, 119)
        Me.ckblstCategories.Sorted = True
        Me.ckblstCategories.TabIndex = 0
        Me.ckblstCategories.ThreeDCheckBoxes = True
        Me.ToolTip1.SetToolTip(Me.ckblstCategories, "Click on category")
        '
        'lstCategories
        '
        Me.lstCategories.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstCategories.FormattingEnabled = True
        Me.lstCategories.ItemHeight = 18
        Me.lstCategories.Location = New System.Drawing.Point(453, 331)
        Me.lstCategories.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.lstCategories.Name = "lstCategories"
        Me.lstCategories.Size = New System.Drawing.Size(211, 130)
        Me.lstCategories.Sorted = True
        Me.lstCategories.TabIndex = 0
        Me.ToolTip1.SetToolTip(Me.lstCategories, "The category of the Book")
        '
        'txtAddCategory
        '
        Me.txtAddCategory.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAddCategory.Location = New System.Drawing.Point(453, 156)
        Me.txtAddCategory.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtAddCategory.Name = "txtAddCategory"
        Me.txtAddCategory.Size = New System.Drawing.Size(145, 25)
        Me.txtAddCategory.TabIndex = 3
        Me.ToolTip1.SetToolTip(Me.txtAddCategory, "Add Category" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "One By one")
        '
        'btnAddCategory
        '
        Me.btnAddCategory.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddCategory.Location = New System.Drawing.Point(604, 154)
        Me.btnAddCategory.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnAddCategory.Name = "btnAddCategory"
        Me.btnAddCategory.Size = New System.Drawing.Size(163, 30)
        Me.btnAddCategory.TabIndex = 0
        Me.btnAddCategory.Text = "Add New &Ccategory"
        Me.btnAddCategory.UseVisualStyleBackColor = True
        '
        'ToolTip1
        '
        Me.ToolTip1.AutoPopDelay = 500
        Me.ToolTip1.InitialDelay = 500
        Me.ToolTip1.ReshowDelay = 100
        '
        'txtISBN
        '
        Me.txtISBN.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtISBN.Location = New System.Drawing.Point(451, 493)
        Me.txtISBN.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtISBN.Name = "txtISBN"
        Me.txtISBN.Size = New System.Drawing.Size(340, 25)
        Me.txtISBN.TabIndex = 4
        Me.ToolTip1.SetToolTip(Me.txtISBN, "e.g. 123456789")
        '
        'btnRemoveCategory
        '
        Me.btnRemoveCategory.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRemoveCategory.Location = New System.Drawing.Point(670, 382)
        Me.btnRemoveCategory.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnRemoveCategory.Name = "btnRemoveCategory"
        Me.btnRemoveCategory.Size = New System.Drawing.Size(144, 32)
        Me.btnRemoveCategory.TabIndex = 0
        Me.btnRemoveCategory.Text = "Remove Category"
        Me.ToolTip1.SetToolTip(Me.btnRemoveCategory, "Select category to remove")
        Me.btnRemoveCategory.UseVisualStyleBackColor = True
        '
        'txtDescription
        '
        Me.txtDescription.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescription.Location = New System.Drawing.Point(34, 613)
        Me.txtDescription.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtDescription.Multiline = True
        Me.txtDescription.Name = "txtDescription"
        Me.txtDescription.Size = New System.Drawing.Size(757, 159)
        Me.txtDescription.TabIndex = 0
        Me.ToolTip1.SetToolTip(Me.txtDescription, "Give any coment Ro Descripe the book")
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(387, 501)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(40, 18)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "ISBN"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(331, 548)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(96, 18)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "Page Number"
        '
        'NumericUpDown1
        '
        Me.NumericUpDown1.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NumericUpDown1.Increment = New Decimal(New Integer() {10, 0, 0, 0})
        Me.NumericUpDown1.Location = New System.Drawing.Point(451, 540)
        Me.NumericUpDown1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.NumericUpDown1.Maximum = New Decimal(New Integer() {3000, 0, 0, 0})
        Me.NumericUpDown1.Name = "NumericUpDown1"
        Me.NumericUpDown1.Size = New System.Drawing.Size(120, 25)
        Me.NumericUpDown1.TabIndex = 5
        Me.NumericUpDown1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(33, 583)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(96, 18)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Description"
        '
        'cmbBookSelves
        '
        Me.cmbBookSelves.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbBookSelves.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbBookSelves.FormattingEnabled = True
        Me.cmbBookSelves.Items.AddRange(New Object() {"Not Read", "Read", "Want to Read", "Currently Reading"})
        Me.cmbBookSelves.Location = New System.Drawing.Point(80, 354)
        Me.cmbBookSelves.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cmbBookSelves.Name = "cmbBookSelves"
        Me.cmbBookSelves.Size = New System.Drawing.Size(167, 26)
        Me.cmbBookSelves.TabIndex = 0
        '
        'btnAddBook
        '
        Me.btnAddBook.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddBook.Location = New System.Drawing.Point(234, 792)
        Me.btnAddBook.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnAddBook.Name = "btnAddBook"
        Me.btnAddBook.Size = New System.Drawing.Size(168, 38)
        Me.btnAddBook.TabIndex = 6
        Me.btnAddBook.Text = "&Add Book"
        Me.btnAddBook.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.Location = New System.Drawing.Point(442, 792)
        Me.btnCancel.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(168, 38)
        Me.btnCancel.TabIndex = 7
        Me.btnCancel.Text = "&Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Constantia", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(77, 331)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(80, 18)
        Me.Label7.TabIndex = 23
        Me.Label7.Text = "BookSelves"
        '
        'tbRating
        '
        Me.tbRating.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.tbRating.LargeChange = 1
        Me.tbRating.Location = New System.Drawing.Point(65, 433)
        Me.tbRating.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.tbRating.Maximum = 5
        Me.tbRating.Name = "tbRating"
        Me.tbRating.Size = New System.Drawing.Size(192, 56)
        Me.tbRating.TabIndex = 0
        Me.tbRating.TickStyle = System.Windows.Forms.TickStyle.Both
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Constantia", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(62, 405)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(50, 18)
        Me.Label8.TabIndex = 24
        Me.Label8.Text = "Rating"
        '
        'cmbRating
        '
        Me.cmbRating.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbRating.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbRating.FormattingEnabled = True
        Me.cmbRating.Items.AddRange(New Object() {"None", "1 Stars", "2 Stars", "3 Stars", "4 Stars", "5 Stars"})
        Me.cmbRating.Location = New System.Drawing.Point(65, 507)
        Me.cmbRating.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cmbRating.Name = "cmbRating"
        Me.cmbRating.Size = New System.Drawing.Size(192, 26)
        Me.cmbRating.TabIndex = 25
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(355, 208)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(72, 18)
        Me.Label9.TabIndex = 26
        Me.Label9.Text = "Category"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(283, 357)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(144, 18)
        Me.Label10.TabIndex = 27
        Me.Label10.Text = "Category Selected"
        '
        'frmAddNewBook
        '
        Me.AcceptButton = Me.btnAddBook
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnCancel
        Me.ClientSize = New System.Drawing.Size(832, 847)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.cmbRating)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.cmbBookSelves)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.tbRating)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnAddBook)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtDescription)
        Me.Controls.Add(Me.NumericUpDown1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.btnRemoveCategory)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtISBN)
        Me.Controls.Add(Me.btnAddCategory)
        Me.Controls.Add(Me.txtAddCategory)
        Me.Controls.Add(Me.lstCategories)
        Me.Controls.Add(Me.ckblstCategories)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtAuthor)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtTitle)
        Me.Controls.Add(Me.btnImportImage)
        Me.Controls.Add(Me.picCoverImage)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.MaximizeBox = False
        Me.Name = "frmAddNewBook"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Add Book"
        CType(Me.picCoverImage, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbRating, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents picCoverImage As PictureBox
    Friend WithEvents btnImportImage As Button
    Friend WithEvents openImageDialog1 As OpenFileDialog
    Friend WithEvents txtTitle As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtAuthor As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents ckblstCategories As CheckedListBox
    Friend WithEvents lstCategories As ListBox
    Friend WithEvents txtAddCategory As TextBox
    Friend WithEvents btnAddCategory As Button
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents Label4 As Label
    Friend WithEvents txtISBN As TextBox
    Friend WithEvents btnRemoveCategory As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents NumericUpDown1 As NumericUpDown
    Friend WithEvents Label6 As Label
    Friend WithEvents txtDescription As TextBox
    Friend WithEvents cmbBookSelves As ComboBox
    Friend WithEvents btnAddBook As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents tbRating As TrackBar
    Friend WithEvents Label8 As Label
    Friend WithEvents cmbRating As ComboBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
End Class
