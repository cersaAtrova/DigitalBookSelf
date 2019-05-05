Public Class frmReadingBooks
    Dim indxRow As Integer = -1
    Dim ReadingBooks As String
    Private Sub RefreshPage()
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
                                Where BookSelves = ReadingBooks
                                Select Picture, Title, Author, Category, ISBN, Page_Number, Rating, BookSelves
        dgvDispalyBooks.DataSource = lnqAllBookFileXml.ToList

    End Sub
    Private Sub BtnTSDeleteBook_Click(sender As Object, e As EventArgs) Handles btnTSDeleteBook.Click, DeleteBookToolStripMenuItem.Click
        If indxRow <> -1 Then
            Dim selectRowValue As DataGridViewRow = dgvDispalyBooks.Rows(indxRow)
            Dim indxRemove As Integer = -1
            'find the row were store in a structure and the delete it
            For i = 0 To storageBooks.Count - 1
                If storageBooks.ElementAt(i).ISBN = selectRowValue.Cells(4).Value AndAlso storageBooks.ElementAt(i).title = selectRowValue.Cells(1).Value AndAlso storageBooks.ElementAt(i).author = selectRowValue.Cells(2).Value Then
                    indxRemove = i
                End If
            Next
            If indxRemove <> -1 Then
                frmHistory.AddInHistory(Date.Today & Space(1) & TimeOfDay & " => Remove Book with Title= " & storageBooks.ElementAt(indxRemove).title & "  Author=" & storageBooks.ElementAt(indxRemove).author & "ISBN= " & storageBooks.ElementAt(indxRemove).ISBN)
                storageBooks.RemoveAt(indxRemove)
            End If
            indxRow = -1
        Else
            MessageBox.Show("Please Select A Row First.!", "Invalid Row")
        End If
    End Sub

    Private Sub SellectingCellIndex(sender As Object, e As DataGridViewCellEventArgs) Handles dgvDispalyBooks.CellClick
        indxRow = e.RowIndex
        Dim selectRowValue As DataGridViewRow = dgvDispalyBooks.Rows(indxRow)
        Dim lnqModifyBook = From c In storageBooks
                            Let Title = c.title
                            Let Author = c.author
                            Let Category = c.category
                            Let ISBN = c.ISBN
                            Let Description = c.description
                            Where ISBN = selectRowValue.Cells(4).Value AndAlso Title = selectRowValue.Cells(1).Value AndAlso Author = selectRowValue.Cells(2).Value
                            Select Description

        rtxtDescription.Text = lnqModifyBook.First

    End Sub

    Private Sub FrmReadingBooks_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ReadingBooks = Me.Text
        RefreshPage()
        Me.Text += " Books"
    End Sub

    Private Sub BtnTSModifyBooks_Click(sender As Object, e As EventArgs) Handles btnTSModifyBooks.Click, ModifyBookToolStripMenuItem.Click
        If indxRow > -1 Then
            '================
            'Read the data from book and store all information in Form AddNewBook
            Dim selectRowValue As DataGridViewRow = dgvDispalyBooks.Rows(indxRow)
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
            DigitalBookshelf.frmAddNewBook.ShowDialog()
            indxRow = -1 'initialize with negative value for user to select a row
            RefreshPage()
        Else
            MessageBox.Show("Please Select A Row First.!", "Invalid Row")
        End If
    End Sub

    Private Sub BtnTSAddBokk_Click(sender As Object, e As EventArgs) Handles btnTSAddBokk.Click
        frmAddNewBook.ShowDialog()
        RefreshPage()
    End Sub

    Private Sub RatingChanged(sender As Object, e As EventArgs) Handles cmnuDataGridViewRating1Star.Click, cmnuDataGridViewRating5Star.Click, cmnuDataGridViewRating4Star.Click, cmnuDataGridViewRating3Star.Click, cmnuDataGridViewRating2Star.Click
        If indxRow <> -1 Then
            Dim selectRowValue As DataGridViewRow = dgvDispalyBooks.Rows(indxRow)
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
            indxRow = -1
            RefreshPage()
        Else
            MessageBox.Show("Select a Row", "Error:Not Row Selected")
        End If
    End Sub

    Private Sub ChangeTheBookSelvesList(sender As Object, e As EventArgs) Handles cmnuDataGridViewRead.Click, cmnuDataGridViewWantToRead.Click, cmnuDataGridViewNotRead.Click, cmnuDataGridViewCurrentlyReading.Click
        If indxRow <> -1 Then
            Dim selectRowValue As DataGridViewRow = dgvDispalyBooks.Rows(indxRow)
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
                If sender.tag <> "Read" Then
                    b.rating = "None"
                End If
                frmHistory.AddInHistory(Date.Today & Space(1) & TimeOfDay & " => Change the BookSelves from " & storageBooks.ElementAt(indxSelected).rating.ToUpper & " To " & sender.text.ToString.ToUpper & "  of Book Title= " & storageBooks.ElementAt(indxSelected).title & " and Author=" & storageBooks.ElementAt(indxSelected).author)
                storageBooks.RemoveAt(indxSelected)
                storageBooks.Insert(indxSelected, b)
            End If
            indxSelected = -1
            indxRow = -1
            RefreshPage()

        Else
            MessageBox.Show("Select a Row", "Error:Not Row Selected")
        End If
    End Sub


End Class