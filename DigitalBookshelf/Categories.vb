Public Class frmCategories
    Dim titleBooks As New List(Of String)
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
    Private Sub CategoriesLoad()
        For i = 0 To ckblstCategories.Items.Count - 1
            ckblstCategories.SetItemChecked(i, False)
        Next
        'store all category in a cheked list box 
        Dim lnqFindCategories = From c In storageBooks
                                Let Category = c.category
                                Select Category Distinct

        Dim ShowCategory As String = String.Empty
        For i = 0 To lnqFindCategories.Count - 1
            ShowCategory &= "," & lnqFindCategories.ElementAt(i)
        Next
        ShowCategory = ShowCategory.Substring(1)
        'remove dublicate category
        Dim countCategory() = ShowCategory.Split(",")
        Dim lnqAllCategorys = From c In countCategory
                              Select c Distinct
        ckblstCategories.DataSource = lnqAllCategorys.ToList
        lstDisplayBooks.Items.Clear()
    End Sub
    Private Sub FrmCategories_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CategoriesLoad()
    End Sub
    Private Sub RefreshListBox()
        'store only once the book in a listbox. some category have the same book
        lstDisplayBooks.Items.Clear()
        Dim lnqAddToListBox = From c In titleBooks
                              Select c Distinct

        For Each c In lnqAddToListBox
            lstDisplayBooks.Items.Add(c)
        Next
    End Sub
    Private Sub CategoriesItems(sender As Object, e As ItemCheckEventArgs) Handles ckblstCategories.ItemCheck
        'store all books in a list if is category is selected
        If e.NewValue = CheckState.Checked Then
            Dim lnqFindCategories = From c In storageBooks
                                    Let Category = c.category
                                    Let Title = c.title
                                    Where Category.Contains(ckblstCategories.SelectedItem)
                                    Select Title

            For Each c In lnqFindCategories
                titleBooks.Add(c)
            Next
            RefreshListBox()
        Else
            'delete all books in a list if is category is selected
            Dim lnqFindCategories = From c In storageBooks
                                    Let Category = c.category
                                    Let Title = c.title
                                    Where Category.Contains(ckblstCategories.SelectedItem)
                                    Select Title

            For Each c In lnqFindCategories
                titleBooks.Remove(c)
            Next
            RefreshListBox()
        End If
    End Sub
    Private Sub DeleteCategory(sender As Object, e As EventArgs) Handles tsbtnDeleteCategories.Click, cmnuDeleteCategories.Click
        'ask for confirmation if they want to delete
        Dim checkItems As Boolean = False
        For i = 0 To ckblstCategories.Items.Count - 1
            If ckblstCategories.GetItemCheckState(i) = CheckState.Checked Then
                checkItems = True
            End If
        Next
        'check for selected category
        If checkItems = False Then
            MsgBox("Please check a category")
            Exit Sub
        End If
        If MessageBox.Show("Are you sure You want To delete this Category?" & vbNewLine & "Perhaps You lost some Books permnently", "Delete Category", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.No Then
            Exit Sub
        End If

        Dim indxChekedCategory As Integer = ckblstCategories.Items.Count - 1
        Do While indxChekedCategory >= 0
            If ckblstCategories.GetItemCheckState(indxChekedCategory) = CheckState.Checked Then
                frmHistory.AddInHistory(Date.Today & Space(1) & TimeOfDay & " => Delete Category with Namw : " & ckblstCategories.Items.Item(indxChekedCategory))
                'we search in structure to find the category and if have signle gategory then delete all book. otherwise we delete from all book the category wich is deleted
                Dim indxCategory = storageBooks.Count - 1
                Do While indxCategory >= 0
                    If storageBooks.ElementAt(indxCategory).category = ckblstCategories.Items(indxChekedCategory) Then
                        storageBooks.RemoveAt(indxCategory)
                        'Search in structure List and every books contains the selected category that user want to delete remove only the category by write again the hole book 
                    ElseIf storageBooks.ElementAt(indxCategory).category.Contains(ckblstCategories.Items(indxChekedCategory)) Then
                        Dim arr() = storageBooks.ElementAt(indxCategory).category.Split(New Char() {","c}, StringSplitOptions.RemoveEmptyEntries)
                        Dim storeCategories As String = String.Empty
                        For k = 0 To arr.Length - 1
                            If arr(k) <> (ckblstCategories.Items.Item(indxChekedCategory)) Then
                                storeCategories &= "," & arr(k)
                            End If
                        Next
                        storeCategories = storeCategories.Substring(1)
                        'store all information about books we have this category and the new categories
                        Dim b As StoreBooks
                        b.pic = storageBooks.ElementAt(indxCategory).pic
                        b.title = storageBooks.ElementAt(indxCategory).title
                        b.author = storageBooks.ElementAt(indxCategory).author
                        b.category = storeCategories
                        b.pageNumber = storageBooks.ElementAt(indxCategory).pageNumber
                        b.ISBN = storageBooks.ElementAt(indxCategory).ISBN
                        b.description = storageBooks.ElementAt(indxCategory).description
                        b.bookSelves = storageBooks.ElementAt(indxCategory).rating
                        b.rating = storageBooks.ElementAt(indxCategory).rating

                        storageBooks.RemoveAt(indxCategory)
                        storageBooks.Insert(indxCategory, b)
                    End If
                    indxCategory -= 1
                Loop
            End If
            indxChekedCategory -= 1
        Loop
        CategoriesLoad()
    End Sub
    Private Sub RenameCategory(sender As Object, e As EventArgs) Handles tsbtnReanmeCategory.Click, cmnuRename.Click
        'check for selected items
        Dim checkItems As Boolean = False
        For i = 0 To ckblstCategories.Items.Count - 1
            If ckblstCategories.GetItemCheckState(i) = CheckState.Checked Then
                checkItems = True
            End If
        Next
        If checkItems = False Then
            MsgBox("Please check a category")
            Exit Sub
        End If

        'ask for confirmation if they want to rename
        If MessageBox.Show("Are you sure You want To Rename this Categories?" & vbNewLine & "Perhaps You take few minutes of your time!", "Rename Category", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.No Then
            Exit Sub
        End If
        Dim indxChekedCategory As Integer = ckblstCategories.Items.Count - 1
        Do While indxChekedCategory >= 0
            'find the checked category
            If ckblstCategories.GetItemCheckState(indxChekedCategory) = CheckState.Checked Then
                Dim newNameCategory As String = InputBox("Rename The Category : ' " & ckblstCategories.Items.Item(indxChekedCategory) & " '" & vbNewLine & vbNewLine & vbNewLine & "To :", "Rename Category")
                If newNameCategory = String.Empty Then
                    newNameCategory = ckblstCategories.Items.Item(indxChekedCategory)
                End If
                'starting search in list of all book storage
                frmHistory.AddInHistory(Date.Today & Space(1) & TimeOfDay & " => Rename Category with Name : " & ckblstCategories.Items.Item(indxChekedCategory) & vbNewLine & "TO" & newNameCategory)

                Dim indxListCategory = storageBooks.Count - 1
                Do While indxListCategory >= 0
                    If storageBooks.ElementAt(indxListCategory).category = ckblstCategories.Items(indxChekedCategory) Then
                        Dim b As StoreBooks
                        b.pic = storageBooks.ElementAt(indxListCategory).pic
                        b.title = storageBooks.ElementAt(indxListCategory).title
                        b.author = storageBooks.ElementAt(indxListCategory).author
                        b.category = newNameCategory
                        b.pageNumber = storageBooks.ElementAt(indxListCategory).pageNumber
                        b.ISBN = storageBooks.ElementAt(indxListCategory).ISBN
                        b.description = storageBooks.ElementAt(indxListCategory).description
                        b.bookSelves = storageBooks.ElementAt(indxListCategory).bookSelves
                        b.rating = storageBooks.ElementAt(indxListCategory).rating

                        storageBooks.RemoveAt(indxListCategory)
                        storageBooks.Insert(indxListCategory, b)
                        'Search in structure List and every books contains the selected category that user want to delete remove only the category by write again the hole book 
                    ElseIf storageBooks.ElementAt(indxListCategory).category.Contains(ckblstCategories.Items(indxChekedCategory)) Then
                        Dim arr() = storageBooks.ElementAt(indxListCategory).category.Split(","c)

                        For k = 0 To arr.Length - 1
                            If arr(k) = (ckblstCategories.Items(indxChekedCategory)) Then
                                arr(k) = newNameCategory
                            End If
                        Next
                        Dim storeCategories As String = String.Empty
                        For k = 0 To arr.Length - 1
                            storeCategories += "," & arr(k)
                        Next
                        storeCategories = storeCategories.Substring(1)
                        'store all information about books we have this category and the new categories
                        Dim b As StoreBooks
                        b.pic = storageBooks.ElementAt(indxListCategory).pic
                        b.title = storageBooks.ElementAt(indxListCategory).title
                        b.author = storageBooks.ElementAt(indxListCategory).author
                        b.category = storeCategories
                        b.pageNumber = storageBooks.ElementAt(indxListCategory).pageNumber
                        b.ISBN = storageBooks.ElementAt(indxListCategory).ISBN
                        b.description = storageBooks.ElementAt(indxListCategory).description
                        b.bookSelves = storageBooks.ElementAt(indxListCategory).bookSelves
                        b.rating = storageBooks.ElementAt(indxListCategory).rating

                        storageBooks.RemoveAt(indxListCategory)
                        storageBooks.Insert(indxListCategory, b)
                    End If

                    indxListCategory -= 1
                Loop


            End If

            indxChekedCategory -= 1
        Loop
        CategoriesLoad()
    End Sub
End Class