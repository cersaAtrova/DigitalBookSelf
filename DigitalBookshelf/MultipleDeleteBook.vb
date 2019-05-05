Public Class frmMultipleDeleteBook
    Dim details As New List(Of String)
    Private Sub CategoriesLoad()
        For i = 0 To cklstTitleBooks.Items.Count - 1
            cklstTitleBooks.SetItemChecked(i, False)
        Next
        'store all category in a cheked list box 
        Dim lnqFindTitleBooks = From c In storageBooks
                                Let Title = c.title
                                Select Title

        cklstTitleBooks.DataSource = lnqFindTitleBooks.ToList
        lstDescriptionOfBooks.Items.Clear()
    End Sub
    Private Sub FrmCategories_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CategoriesLoad()
    End Sub
    Private Sub RefreshListBox()
        'store only once the book in a listbox. some category have the same book
        lstDescriptionOfBooks.Items.Clear()
        Dim lnqAddToListBox = From c In details
                              Select c

        For Each c In lnqAddToListBox
            lstDescriptionOfBooks.Items.Add(c)
        Next
    End Sub
    Private Sub CategoriesItems(sender As Object, e As ItemCheckEventArgs) Handles cklstTitleBooks.ItemCheck
        'store all books in a list if is category is selected
        If e.NewValue = CheckState.Checked Then
            Dim lnqFindCategories = From c In storageBooks
                                    Let category = c.category
                                    Let author = c.author
                                    Let Title = c.title
                                    Let isbn = c.ISBN
                                    Let rating = c.rating
                                    Let bookshel = c.bookSelves
                                    Where Title = (cklstTitleBooks.SelectedItem)
                                    Select author, category, isbn, rating, bookshel

            details.Add("Author=" & lnqFindCategories.First.author & ", Category=" & lnqFindCategories.First.category & ", ISBN=" & lnqFindCategories.First.isbn & ", Bookselves=" & lnqFindCategories.First.bookshel & ", Rating=" & lnqFindCategories.First.rating)

            For Each c In lnqFindCategories
            Next
            RefreshListBox()
        Else
            'delete all books in a list if is category is selected
            Dim lnqFindCategories = From c In storageBooks
                                    Let category = c.category
                                    Let author = c.author
                                    Let Title = c.title
                                    Let isbn = c.ISBN
                                    Let rating = c.rating
                                    Let bookshel = c.bookSelves
                                    Where Title.Equals(cklstTitleBooks.SelectedItem)
                                    Select author, category, isbn, rating, bookshel

            For Each c In lnqFindCategories
                details.Remove("Author=" & lnqFindCategories.First.author & ", Category=" & lnqFindCategories.First.category & ", ISBN=" & lnqFindCategories.First.isbn & ", Bookselves=" & lnqFindCategories.First.bookshel & ", Rating=" & lnqFindCategories.First.rating)
            Next
            RefreshListBox()
        End If
    End Sub
    Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Dim checkItems As Boolean = False
        For i = 0 To cklstTitleBooks.Items.Count - 1
            If cklstTitleBooks.GetItemCheckState(i) = CheckState.Checked Then
                checkItems = True
            End If
        Next
        'check for selected category
        If checkItems = False Then
            MsgBox("Please check a category")
            Exit Sub
        End If
        If MessageBox.Show("Are you sure You want To delete those Books?" & vbNewLine & "You lost those Books permnently", "Delete Books", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.No Then
            Exit Sub
        End If

        Dim indxChekedCategory As Integer = cklstTitleBooks.Items.Count - 1
        Do While indxChekedCategory >= 0
            If cklstTitleBooks.GetItemCheckState(indxChekedCategory) = CheckState.Checked Then
                frmHistory.AddInHistory(Date.Today & Space(1) & TimeOfDay & " => Delete Category with Name : " & cklstTitleBooks.Items.Item(indxChekedCategory))
                'we search in structure to find the title and  then delete all book.
                Dim indxCategory = storageBooks.Count - 1
                Do While indxCategory >= 0
                    If storageBooks.ElementAt(indxCategory).title = cklstTitleBooks.Items(indxChekedCategory) Then
                        storageBooks.RemoveAt(indxCategory)
                        Exit Do
                    End If
                    indxCategory -= 1
                Loop
            End If
            indxChekedCategory -= 1
        Loop
        CategoriesLoad()
    End Sub
End Class