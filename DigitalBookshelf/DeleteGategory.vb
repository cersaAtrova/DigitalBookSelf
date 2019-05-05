Public Class frmDeleteGategory
    Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        'ask for confirmation if they want to delete
        Dim checkItems As Boolean = False
        For i = 0 To cklstDisplayCategory.Items.Count - 1
            If cklstDisplayCategory.GetItemCheckState(i) = CheckState.Checked Then
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

        Dim indxChekedCategory As Integer = cklstDisplayCategory.Items.Count - 1
        Do While indxChekedCategory >= 0
            If cklstDisplayCategory.GetItemCheckState(indxChekedCategory) = CheckState.Checked Then
                frmHistory.AddInHistory(Date.Today & Space(1) & TimeOfDay & " => Delete Category with Namw : " & cklstDisplayCategory.Items.Item(indxChekedCategory))
                'we search in structure to find the category and if have signle gategory then delete all book. otherwise we delete from all book the category wich is deleted
                Dim indxCategory = storageBooks.Count - 1
                Do While indxCategory >= 0
                    If storageBooks.ElementAt(indxCategory).category = cklstDisplayCategory.Items(indxChekedCategory) Then
                        storageBooks.RemoveAt(indxCategory)
                        'Search in structure List and every books contains the selected category that user want to delete remove only the category by write again the hole book 
                    ElseIf storageBooks.ElementAt(indxCategory).category.Contains(cklstDisplayCategory.Items(indxChekedCategory)) Then
                        Dim arr() = storageBooks.ElementAt(indxCategory).category.Split(New Char() {","c}, StringSplitOptions.RemoveEmptyEntries)
                        Dim storeCategories As String = String.Empty
                        For k = 0 To arr.Length - 1
                            If arr(k) <> (cklstDisplayCategory.Items.Item(indxChekedCategory)) Then
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
        Me.Close()
    End Sub
    Private Sub CategoriesLoad()
        For i = 0 To cklstDisplayCategory.Items.Count - 1
            cklstDisplayCategory.SetItemChecked(i, False)
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
        Dim countCategory() = ShowCategory.Split(",")
        Dim lnqAllCategorys = From c In countCategory
                              Select c Distinct
        cklstDisplayCategory.DataSource = lnqAllCategorys.ToList
    End Sub
    Private Sub DeleteGategory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CategoriesLoad()
    End Sub
End Class