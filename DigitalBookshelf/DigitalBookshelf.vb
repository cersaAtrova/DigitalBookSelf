Public Class frmLibrary
    Dim rowIndex As Integer = -1
    Dim countAdvertsising As Integer 'upload next advertsising photo
    Dim countSaveFileToStructure As Integer = 0
    Private Sub LiabraryLoadEvent(sender As Object, e As EventArgs) Handles MyBase.Activated
        Dim bookLibraryFileXML As XElement = XElement.Load("LiabraryBooks.xml") 'load all Books
        Dim QuotesFileXML As XElement = XElement.Load("Quotes.xml") 'load all Quotes
        Dim lnqAdvertising = From c In QuotesFileXML.Descendants("picture")
                             Let Picture As Bitmap = New Bitmap(ConvertStringToByte(c.<pic>.Value))
                             Select Picture

        For i = 0 To lnqAdvertising.Count - 1
            advertisingQuotes.Add((lnqAdvertising.ElementAt(i))) 'store the quotes in array
        Next
        If advertisingQuotes.Count - 1 >= 0 Then
            If advertisingQuotes.Count - 1 > 0 Then
                picAdverstising.Image = advertisingQuotes.Item(1) 'start with a second picture of Quotes
            Else
                picAdverstising.Image = advertisingQuotes.Item(0)
            End If
        End If
        'here we read only once the file and store in the structurte
        If countSaveFileToStructure = 0 Then
            SaveXMLFileToStructure()
            countSaveFileToStructure = 1
            'adding to history
            frmHistory.AddInHistory("")
            frmHistory.AddInHistory(Date.Today & Space(1) & TimeOfDay & " => Start the Application  ")
        End If
        'reading the all  structure and storing in the grid
        RefreshBookList()
    End Sub
    Private Sub TimerCountAdvertising_Tick(sender As Object, e As EventArgs) Handles TimerCountAdvertising.Tick
        'Show the Quotes one by one under the screen
        If advertisingQuotes.Count - 1 < 0 Then 'if in the listbox of picture must turn it off the timer
            picAdverstising.Image = Nothing
            TimerCountAdvertising.Enabled = False
            Exit Sub
        End If
        If countAdvertsising > advertisingQuotes.Count - 1 Then
            countAdvertsising = 0

        End If
        picAdverstising.Image = advertisingQuotes.ElementAt(countAdvertsising)
        countAdvertsising += 1
    End Sub
    Private Sub SaveXMLFileToStructure()
        Dim bookLibraryFileXML As XElement = XElement.Load("LiabraryBooks.xml") 'load all Books

        Dim lnqModifyBook = From c In bookLibraryFileXML.Descendants("Books")
                            Let Title = c.<title>.Value
                            Let Author = c.<author>.Value
                            Let Category = c.<category>.Value
                            Let ISBN = c.<ISBN>.Value
                            Let BookSelves = c.<bookSelves>.Value
                            Let Page_Number = c.<pageNumber>.Value
                            Let Description = c.<description>.Value
                            Let rating = c.<Rating>.Value
                            Let pic As Bitmap = ConvertStringToByte(c.<pic>.Value)
                            Let s As Size = New Size(40, 50)
                            Let Picture As Bitmap = New Bitmap(pic, s) 'resize the picture
                            Select Picture, Title, Author, Category, ISBN, Page_Number, Description, BookSelves, rating

        For i = 0 To lnqModifyBook.Count - 1
            Dim b As StoreBooks
            b.pic = lnqModifyBook.ElementAt(i).Picture
            b.title = lnqModifyBook.ElementAt(i).Title
            b.author = lnqModifyBook.ElementAt(i).Author
            b.category = lnqModifyBook.ElementAt(i).Category
            b.pageNumber = lnqModifyBook.ElementAt(i).Page_Number
            b.ISBN = lnqModifyBook.ElementAt(i).ISBN
            b.description = lnqModifyBook.ElementAt(i).Description
            b.bookSelves = lnqModifyBook.ElementAt(i).BookSelves
            b.rating = lnqModifyBook.ElementAt(i).rating
            storageBooks.Add(b)

        Next
    End Sub
    Private Sub ChangeFormColor(sender As Object, e As EventArgs) Handles mnuOptionStyleConfiguaraator.Click, cmnuStyleConfigurator.Click
        'chnage the form's color
        Dim oldColor = Me.BackColor.Name
        If ColorDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
            Dim c As Color = (ColorDialog1.Color)
            If c = Color.Black Then
                Me.BackColor = c
                picAdverstising.BackColor = c
                For Each lbl In Me.Controls 'change the words label's color if is black color the background
                    If TypeOf lbl Is Label Then
                        CType(lbl, Label).ForeColor = Color.White
                    End If
                Next
            Else
                'change the words color label to black for any background color
                Me.BackColor = c
                picAdverstising.BackColor = c
                lblTime.ForeColor = Color.Black
            End If
            frmHistory.AddInHistory(Date.Today & Space(1) & TimeOfDay & " --> Change the font color of the from DigitalBookSelf from " & oldColor & " color to " & Me.BackColor.Name & " color ")
        End If
    End Sub
    Private Sub TxtSearching_TextChanged(sender As Object, e As EventArgs) Handles txtSearching.TextChanged
        'searching 
        If cmbSearching.SelectedIndex >= 0 Then
            If cmbSearching.SelectedIndex = 0 Then
                'searching by author
                Dim lnqAllBookFileXml = From c In storageBooks
                                        Let Title = c.title
                                        Let Author = c.author
                                        Let Category = c.category
                                        Let ISBN = c.ISBN
                                        Let Page_Number = c.pageNumber
                                        Let Rating = c.rating
                                        Let s As Size = New Size(40, 50)
                                        Let Picture As Bitmap = New Bitmap(c.pic, s) 'resize the picture
                                        Let BookSelves = c.bookSelves
                                        Where Author.ToLower.Contains(txtSearching.Text.ToLower)
                                        Select Picture, Title, Author, Category, ISBN, Page_Number, Rating, BookSelves

                dgvDisplayBooks.DataSource = lnqAllBookFileXml.ToList
            ElseIf cmbSearching.SelectedIndex = 1 Then
                'searching by Category
                Dim lnqAllBookFileXml = From c In storageBooks
                                        Let Title = c.title
                                        Let Rating = c.rating
                                        Let Author = c.author
                                        Let Category = c.category
                                        Let ISBN = c.ISBN
                                        Let Page_Number = c.pageNumber
                                        Let s As Size = New Size(40, 50)
                                        Let Picture As Bitmap = New Bitmap(c.pic, s) 'resize the picture
                                        Let BookSelves = c.bookSelves
                                        Where Category.ToLower.Contains(txtSearching.Text.ToLower)
                                        Select Picture, Title, Author, Category, ISBN, Page_Number, Rating, BookSelves

                dgvDisplayBooks.DataSource = lnqAllBookFileXml.ToList
            ElseIf cmbSearching.SelectedIndex = 2 Then
                'searching by ISBN
                Dim lnqAllBookFileXml = From c In storageBooks
                                        Let Title = c.title
                                        Let Author = c.author
                                        Let Rating = c.rating
                                        Let Category = c.category
                                        Let ISBN = c.ISBN
                                        Let Page_Number = c.pageNumber
                                        Let s As Size = New Size(40, 50)
                                        Let Picture As Bitmap = New Bitmap(c.pic, s) 'resize the picture
                                        Let BookSelves = c.bookSelves
                                        Where ISBN.ToLower.Contains(txtSearching.Text.ToLower)
                                        Select Picture, Title, Author, Category, ISBN, Page_Number, Rating, BookSelves

                dgvDisplayBooks.DataSource = lnqAllBookFileXml.ToList
            ElseIf cmbSearching.SelectedIndex = 3 Then
                'searching by Pace number
                Dim lnqAllBookFileXml = From c In storageBooks
                                        Let Title = c.title
                                        Let Author = c.author
                                        Let Category = c.category
                                        Let Rating = c.rating
                                        Let ISBN = c.ISBN
                                        Let Page_Number = c.pageNumber
                                        Let s As Size = New Size(40, 50)
                                        Let Picture As Bitmap = New Bitmap(c.pic, s) 'resize the picture
                                        Let BookSelves = c.bookSelves
                                        Where Page_Number.Contains((txtSearching.Text))
                                        Select Picture, Title, Author, Category, ISBN, Page_Number, Rating, BookSelves

                dgvDisplayBooks.DataSource = lnqAllBookFileXml.ToList
            ElseIf cmbSearching.SelectedIndex = 4 Then
                'searching by Title
                Dim lnqAllBookFileXml = From c In storageBooks
                                        Let Title = c.title
                                        Let Author = c.author
                                        Let Category = c.category
                                        Let ISBN = c.ISBN
                                        Let Rating = c.rating
                                        Let Page_Number = c.pageNumber
                                        Let s As Size = New Size(40, 50)
                                        Let Picture As Bitmap = New Bitmap(c.pic, s) 'resize the picture
                                        Let BookSelves = c.bookSelves
                                        Where Title.ToLower.Contains(txtSearching.Text.ToLower)
                                        Select Picture, Title, Author, Category, ISBN, Page_Number, Rating, BookSelves

                dgvDisplayBooks.DataSource = lnqAllBookFileXml.ToList
            End If
        Else
            cmbSearching.SelectedIndex = 4 'if is not selected in combobox take search by title
            Dim lnqAllBookFileXml = From c In storageBooks
                                    Let Title = c.title
                                    Let Author = c.author
                                    Let Category = c.category
                                    Let ISBN = c.ISBN
                                    Let Rating = c.rating
                                    Let Page_Number = c.pageNumber
                                    Let s As Size = New Size(40, 50)
                                    Let Picture As Bitmap = New Bitmap(c.pic, s) 'resize the picture
                                    Let BookSelves = c.bookSelves
                                    Where Title.ToLower.Contains(txtSearching.Text.ToLower)
                                    Select Picture, Title, Author, Category, ISBN, Page_Number, Rating, BookSelves

            dgvDisplayBooks.DataSource = lnqAllBookFileXml.ToList
        End If
    End Sub
    Private Sub ShowAllBooks(sender As Object, e As EventArgs) Handles cmnuRefresh.Click, btnTSRefresh.Click
        'show all books
        RefreshBookList()
    End Sub
    Public Sub RefreshBookList()
        'show all books in a grid
        Dim lnqAllBookFileXml = From c In storageBooks
                                Let Title = c.title
                                Let Author = c.author
                                Let Category = c.category
                                Let ISBN = c.ISBN
                                Let Page_Number = c.pageNumber
                                Let Rating = c.rating
                                Let s As Size = New Size(40, 50)
                                Let Picture As Bitmap = New Bitmap(c.pic, s) 'resize the picture
                                Let BookSelves = c.bookSelves
                                Select Picture, Title, Author, Category, ISBN, Page_Number, Rating, BookSelves

        dgvDisplayBooks.DataSource = lnqAllBookFileXml.ToList
        dgvDisplayBooks.CurrentCell = Nothing
        txtSearching.Text = String.Empty
        If advertisingQuotes.Count - 1 >= 0 Then
            TimerCountAdvertising.Enabled = True 'if in the listbox have picture need to s turn it on the timer
        Else
            TimerCountAdvertising.Enabled = False 'if in the listbox have no picture need to s turn it off the timer
        End If
    End Sub
    Private Sub AddQuotes(sender As Object, e As EventArgs) Handles cmnuAddQuotes.Click, mnuTSAddQoutes.Click, mnuTSDeleteQoutes.Click, cmnuPicQuotesDeleteQuotes.Click
        frmAddAndDeleteQuotes.ShowDialog() 'call the AddORDialete Form
    End Sub
    Private Sub HistoryToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HistoryToolStripMenuItem.Click
        frmHistory.ShowDialog()
    End Sub

    Private Sub AboutUsFormDialog(sender As Object, e As EventArgs) Handles mnuAboutUsAboutUs.Click
        'show about us modal form
        frmAboutUs.ShowDialog()
    End Sub
    Private Sub PrivancyFormDialog(sender As Object, e As EventArgs) Handles mnuAboutUsPrivancyPolicy.Click
        'show privancePolicy modal dialog form
        frmPrivancyPolicy.ShowDialog()

    End Sub
    Private Sub TimerForShowTheTime_Tick(sender As Object, e As EventArgs) Handles timerForShowTheTime.Tick
        'count the time every second
        lblTime.Text = Today.Date & "  " & TimeOfDay
    End Sub
    Private Sub MnuFilterAscendindByTitle_Click(sender As Object, e As EventArgs) Handles mnuFilterAscendindByTitle.Click, cmnuAscendingTitle.Click
        Dim lnqAllBookFileXml = From c In storageBooks
                                Let Title = c.title
                                Let Author = c.author
                                Let Category = c.category
                                Let ISBN = c.ISBN
                                Let Rating = c.rating
                                Let Page_Number = c.pageNumber
                                Let s As Size = New Size(40, 50)
                                Let Picture As Bitmap = New Bitmap(c.pic, s) 'resize the picture
                                Let BookSelves = c.bookSelves
                                Order By Title Ascending
                                Select Picture, Title, Author, Category, ISBN, Page_Number, Rating, BookSelves
        dgvDisplayBooks.DataSource = lnqAllBookFileXml.ToList
    End Sub
    Private Sub MnuFilterAscendindByAuthor_Click(sender As Object, e As EventArgs) Handles mnuFilterAscendindByAuthor.Click, cmnuAscendingAuthor.Click
        Dim lnqAllBookFileXml = From c In storageBooks
                                Let Title = c.title
                                Let Author = c.author
                                Let Category = c.category
                                Let ISBN = c.ISBN
                                Let Rating = c.rating
                                Let Page_Number = c.pageNumber
                                Let s As Size = New Size(40, 50)
                                Let Picture As Bitmap = New Bitmap(c.pic, s) 'resize the picture
                                Let BookSelves = c.bookSelves
                                Order By Author Ascending
                                Select Picture, Title, Author, Category, ISBN, Page_Number, Rating, BookSelves
        dgvDisplayBooks.DataSource = lnqAllBookFileXml.ToList
    End Sub
    Private Sub MnuFilterAscendindByPageNumber_Click(sender As Object, e As EventArgs) Handles mnuFilterAscendindByPageNumber.Click, cmnuAscendingPageNumber.Click
        Dim lnqAllBookFileXml = From c In storageBooks
                                Let Title = c.title
                                Let Author = c.author
                                Let Category = c.category
                                Let Rating = c.rating
                                Let ISBN = c.ISBN
                                Let Page_Number = c.pageNumber
                                Let s As Size = New Size(40, 50)
                                Let Picture As Bitmap = New Bitmap(c.pic, s) 'resize the picture
                                Let BookSelves = c.bookSelves
                                Order By Page_Number Ascending
                                Select Picture, Title, Author, Category, ISBN, Page_Number, Rating, BookSelves
        dgvDisplayBooks.DataSource = lnqAllBookFileXml.ToList
    End Sub
    Private Sub MnuFilterDescendingByTitle_Click(sender As Object, e As EventArgs) Handles mnuFilterDescendingByTitle.Click, cmnuDescendingTitle.Click
        Dim lnqAllBookFileXml = From c In storageBooks
                                Let Title = c.title
                                Let Author = c.author
                                Let Category = c.category
                                Let Rating = c.rating
                                Let ISBN = c.ISBN
                                Let Page_Number = c.pageNumber
                                Let s As Size = New Size(40, 50)
                                Let Picture As Bitmap = New Bitmap(c.pic, s) 'resize the picture
                                Let BookSelves = c.bookSelves
                                Order By Title Descending
                                Select Picture, Title, Author, Category, ISBN, Page_Number, Rating, BookSelves
        dgvDisplayBooks.DataSource = lnqAllBookFileXml.ToList
    End Sub
    Private Sub MnuFilterDescendingByAuthor_Click(sender As Object, e As EventArgs) Handles mnuFilterDescendingByAuthor.Click, cmnuDescendingAuthor.Click
        Dim lnqAllBookFileXml = From c In storageBooks
                                Let Title = c.title
                                Let Rating = c.rating
                                Let Author = c.author
                                Let Category = c.category
                                Let ISBN = c.ISBN
                                Let Page_Number = c.pageNumber
                                Let s As Size = New Size(40, 50)
                                Let Picture As Bitmap = New Bitmap(c.pic, s) 'resize the picture
                                Let BookSelves = c.bookSelves
                                Order By Author Ascending
                                Select Picture, Title, Author, Category, ISBN, Page_Number, Rating, BookSelves
        dgvDisplayBooks.DataSource = lnqAllBookFileXml.ToList
    End Sub
    Private Sub MnuFilterDescendingByPageNumber_Click(sender As Object, e As EventArgs) Handles mnuFilterDescendingByPageNumber.Click, cmnuDescendingPAgeNumber.Click
        Dim lnqAllBookFileXml = From c In storageBooks
                                Let Title = c.title
                                Let Author = c.author
                                Let Rating = c.rating
                                Let Category = c.category
                                Let ISBN = c.ISBN
                                Let Page_Number = c.pageNumber
                                Let s As Size = New Size(40, 50)
                                Let Picture As Bitmap = New Bitmap(c.pic, s) 'resize the picture
                                Let BookSelves = c.bookSelves
                                Order By Page_Number Ascending
                                Select Picture, Title, Author, Category, ISBN, Page_Number, Rating, BookSelves
        dgvDisplayBooks.DataSource = lnqAllBookFileXml.ToList
    End Sub
    Private Sub BtnTSAddBokk_Click(sender As Object, e As EventArgs) Handles btnTSAddBokk.Click, AddBookToolStripMenuItem.Click
        frmAddNewBook.Text = "Add Book"
        frmAddNewBook.btnAddBook.Text = "&Add Book"
        frmAddNewBook.ShowDialog()
    End Sub
    Private Sub BtnTSModifyBooks_Click(sender As Object, e As EventArgs) Handles btnTSModifyBooks.Click, ModifyBookToolStripMenuItem.Click
        If rowIndex > -1 Then
            '================
            'Read the data from book and store all information in Form AddNewBook
            Dim selectRowValue As DataGridViewRow = dgvDisplayBooks.Rows(rowIndex)
            Dim lnqModifyBook = From c In storageBooks
                                Let Title = c.title
                                Let Author = c.author
                                Let Category = c.category
                                Let ISBN = c.ISBN
                                Let Page_Number = c.pageNumber
                                Let s As Size = New Size(40, 50)
                                Let Picture As Bitmap = New Bitmap(c.pic, s) 'resize the picture
                                Let BookSelves = c.bookSelves
                                Let Rating = c.rating
                                Let Description = c.description
                                Where ISBN = selectRowValue.Cells(4).Value AndAlso Title = selectRowValue.Cells(1).Value AndAlso Author = selectRowValue.Cells(2).Value
                                Select Picture, Title, Author, Category, ISBN, Page_Number, BookSelves, Description, Rating

            ' save the modify book in a structure for case to use in Form AddNewBook for change or cancel
            modifyBook.pic = lnqModifyBook.First.Picture
            modifyBook.title = lnqModifyBook.First.Title.ToString
            modifyBook.author = lnqModifyBook.First.Author.ToString
            modifyBook.category = lnqModifyBook.First.Category.ToString
            modifyBook.ISBN = lnqModifyBook.First.ISBN.ToString
            modifyBook.pageNumber = lnqModifyBook.First.Page_Number.ToString
            modifyBook.description = lnqModifyBook.First.Description.ToString
            modifyBook.bookSelves = lnqModifyBook.First.BookSelves.ToString
            modifyBook.rating = lnqModifyBook.First.Rating

            frmAddNewBook.Text = "Modify Book"
            frmAddNewBook.btnAddBook.Text = "&Modify Book"
            frmAddNewBook.ShowDialog()
            rowIndex = -1 'initialize with negative value for user to select a row
        Else
            MessageBox.Show("Select a Row", "Error:Not Row Selected", MessageBoxButtons.OK, MessageBoxIcon.Information)

        End If
    End Sub
    Private Sub RowIndexSelected(sender As Object, e As DataGridViewCellEventArgs) Handles dgvDisplayBooks.CellClick
        rowIndex = e.RowIndex 'take the select row to modify the books
    End Sub
    Private Sub DeleteBook(sender As Object, e As EventArgs) Handles btnTSDeleteBook.Click, DeleteBookToolStripMenuItem.Click
        If rowIndex <> -1 Then
            If MessageBox.Show("Are You sure you want to Delete?", "Delete Book", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                Dim selectRowValue As DataGridViewRow = dgvDisplayBooks.Rows(rowIndex)
                Dim indx As Integer = -1
                'find the row were store in a structure and the delete it
                For i = 0 To storageBooks.Count - 1
                    If storageBooks.ElementAt(i).ISBN = selectRowValue.Cells(4).Value AndAlso storageBooks.ElementAt(i).title = selectRowValue.Cells(1).Value AndAlso storageBooks.ElementAt(i).author = selectRowValue.Cells(2).Value Then
                        indx = i
                    End If
                Next
                storageBooks.RemoveAt(indx)
            End If
            rowIndex = -1
            RefreshBookList()
        Else
            MessageBox.Show("Select a Row", "Error:Not Row Selected", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
    Private Sub UponClosingAndSave(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If MessageBox.Show("Are You sure you want to exit?", "Exit Application", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.No Then
            e.Cancel = True
        Else
            'Save the library by xml file
            Dim root As New XElement("MyLiabrary")
            For i = 0 To storageBooks.Count - 1
                Dim child As New XElement("Books")
                Dim pic As New XElement("pic", ConvertByteToString(storageBooks.ElementAt(i).pic))
                Dim title As New XElement("title", storageBooks.ElementAt(i).title)
                Dim author As New XElement("author", storageBooks.ElementAt(i).author)
                Dim category As New XElement("category", storageBooks.ElementAt(i).category)
                Dim isbn As New XElement("ISBN", storageBooks.ElementAt(i).ISBN)
                Dim pageNumer As New XElement("pageNumber", storageBooks.ElementAt(i).pageNumber)
                Dim description As New XElement("description", storageBooks.ElementAt(i).description)
                Dim booksSelves As New XElement("bookSelves", storageBooks.ElementAt(i).bookSelves)
                Dim rating As New XElement("Rating", storageBooks.ElementAt(i).rating)
                child.Add(pic, title, author, category, isbn, pageNumer, description, booksSelves, rating)
                root.Add(child)
            Next
            root.Save("LiabraryBooks.xml")
            'Adding to history
            frmHistory.AddInHistory("")
            frmHistory.AddInHistory(Date.Today & Space(1) & TimeOfDay & " => Close the Application  ")
        End If
    End Sub
    Private Sub OpenReadingBooks(sender As Object, e As EventArgs) Handles mnuCollectionReadBook.Click, mnuCollectionWantToRead.Click, mnuCollectionNotRead.Click, mnuCollectionCurrentlyReading.Click
        frmReadingBooks.Text = sender.tag.ToString
        frmReadingBooks.ShowDialog()
    End Sub
    Private Sub BookSelvesChanges(sender As Object, e As EventArgs) Handles cmnuDataGridViewRead.Click, cmnuDataGridViewWantToRead.Click, cmnuDataGridViewNotRead.Click, cmnuDataGridViewCurrentlyReading.Click
        If rowIndex <> -1 Then
            Dim selectRowValue As DataGridViewRow = dgvDisplayBooks.Rows(rowIndex)
            Dim indxSelected As Integer = -1
            'find the row were store in a structure and the delete it
            For i = 0 To storageBooks.Count - 1
                If storageBooks.ElementAt(i).ISBN = selectRowValue.Cells(4).Value AndAlso storageBooks.ElementAt(i).title = selectRowValue.Cells(1).Value AndAlso storageBooks.ElementAt(i).author = selectRowValue.Cells(2).Value Then
                    indxSelected = i
                End If
            Next
            If indxSelected <> -1 Then

                Dim b As StoreBooks
                b.pic = storageBooks.ElementAt(indxSelected).pic
                b.title = storageBooks.ElementAt(indxSelected).title
                b.author = storageBooks.ElementAt(indxSelected).author
                b.category = storageBooks.ElementAt(indxSelected).category
                b.pageNumber = storageBooks.ElementAt(indxSelected).pageNumber
                b.ISBN = storageBooks.ElementAt(indxSelected).ISBN
                b.description = storageBooks.ElementAt(indxSelected).description
                b.bookSelves = sender.text.ToString
                b.rating = storageBooks.ElementAt(indxSelected).rating
                If sender.text <> "Read" Then
                    b.rating = "None"
                End If
                frmHistory.AddInHistory(Date.Today & Space(1) & TimeOfDay & " => Change the BookSelves from " & storageBooks.ElementAt(indxSelected).rating.ToUpper & " To " & sender.text.ToString.ToUpper & "  of Book Title= " & storageBooks.ElementAt(indxSelected).title & " and Author=" & storageBooks.ElementAt(indxSelected).author)
                storageBooks.RemoveAt(indxSelected)
                storageBooks.Insert(indxSelected, b)

            End If
            indxSelected = -1
            rowIndex = -1
            RefreshBookList()

        Else
            MessageBox.Show("Select a Row", "Error:Not Row Selected")
        End If
    End Sub
    Private Sub ShowCategories(sender As Object, e As EventArgs) Handles mnuMenuCategoryShowCategory.Click, btnTSAddCategory.Click
        frmCategories.ShowDialog()
    End Sub

    Private Sub MnuOptionBarChartReport_Click(sender As Object, e As EventArgs) Handles mnuOptionBarChartReport.Click
        frmChartsPreBuilt.btnOk.Text = "&Go Bar Chart"
        frmChartsPreBuilt.Text = "Bar Chart"
        frmChartsPreBuilt.radByAuthor.Enabled = False
        frmChartsPreBuilt.ShowDialog()
    End Sub

    Private Sub ChangeRating(sender As Object, e As EventArgs) Handles cmnuDataGridViewRating1Star.Click, cmnuDataGridViewRating5Star.Click, cmnuDataGridViewRating4Star.Click, cmnuDataGridViewRating3Star.Click, cmnuDataGridViewRating2Star.Click
        If rowIndex <> -1 Then
            Dim selectRowValue As DataGridViewRow = dgvDisplayBooks.Rows(rowIndex)
            Dim indxSelected As Integer = -1
            'find the row were store in a structure 
            For i = 0 To storageBooks.Count - 1
                If storageBooks.ElementAt(i).ISBN = selectRowValue.Cells(4).Value AndAlso storageBooks.ElementAt(i).title = selectRowValue.Cells(1).Value AndAlso storageBooks.ElementAt(i).author = selectRowValue.Cells(2).Value Then
                    indxSelected = i
                End If
            Next
            'if the selected book is not Read by user is not allow to rating the books
            If indxSelected <> -1 Then
                If Not storageBooks.ElementAt(indxSelected).bookSelves = "Read" Then
                    MsgBox("You must Read The book First before you rating")
                    Exit Sub
                End If
                Dim b As StoreBooks
                b.pic = storageBooks.ElementAt(indxSelected).pic
                b.title = storageBooks.ElementAt(indxSelected).title
                b.author = storageBooks.ElementAt(indxSelected).author
                b.category = storageBooks.ElementAt(indxSelected).category
                b.pageNumber = storageBooks.ElementAt(indxSelected).pageNumber
                b.ISBN = storageBooks.ElementAt(indxSelected).ISBN
                b.description = storageBooks.ElementAt(indxSelected).description
                b.bookSelves = storageBooks.ElementAt(indxSelected).bookSelves
                b.rating = sender.text.ToString
                frmHistory.AddInHistory(Date.Today & Space(1) & TimeOfDay & " => Change the Rating from " & storageBooks.ElementAt(indxSelected).rating.ToUpper & " To " & sender.text.ToString.ToUpper & "  of Book Title= " & storageBooks.ElementAt(indxSelected).title & " and Author=" & storageBooks.ElementAt(indxSelected).author)

                storageBooks.RemoveAt(indxSelected)
                storageBooks.Insert(indxSelected, b)
            End If
            indxSelected = -1
            rowIndex = -1
            RefreshBookList()
        Else
            MessageBox.Show("Select a Row", "Error:Not Row Selected")
        End If
    End Sub
    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub
    Private Sub MnuOptionAuthorReport_Click(sender As Object, e As EventArgs) Handles mnuOptionPieChartReport.Click
        frmChartsPreBuilt.btnOk.Text = "&Go Pie Chart"
        frmChartsPreBuilt.Text = "Pie Chart"
        frmChartsPreBuilt.radByAuthor.Enabled = True
        frmChartsPreBuilt.ShowDialog()
    End Sub

    Private Sub DeleteCategoriesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteCategoriesToolStripMenuItem.Click
        frmDeleteGategory.ShowDialog()
    End Sub

    Private Sub DeleteAllBooks(sender As Object, e As EventArgs) Handles DeleteAllBooksToolStripMenuItem.Click
        If MessageBox.Show("Are you sure You Want to Delete All Books?", "Delete Books", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
            If MessageBox.Show("You Delete All Books Permanently Do you want to continue???", "Delete Books", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
                storageBooks.Clear()
                frmHistory.AddInHistory(Date.Today & Space(1) & TimeOfDay & " => Delete All Books ")
            End If
        End If
    End Sub
    Private Sub DeleteMultiBooksToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteMultiBooksToolStripMenuItem.Click
        frmMultipleDeleteBook.ShowDialog()
    End Sub
End Class
