Public Class frmAddNewBook
    Private Sub AddNewBook_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lstCategories.Items.Clear()
        'Clear all the check list box from checked value
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
        Dim countCategory() = ShowCategory.Split(",")
        Dim lnqAllCategorys = From c In countCategory
                              Select c Distinct
        ckblstCategories.DataSource = lnqAllCategorys.ToList

        If btnAddBook.Text = "&Modify Book" Then
            picCoverImage.Image = (modifyBook.pic) 'store the picture in Form AddNewBook
            txtTitle.Text = modifyBook.title 'store the title in Form AddNewBook
            txtAuthor.Text = modifyBook.author 'store the Author in Form AddNewBook
            'store the Category in Form AddNewBook By adding one category per line
            If modifyBook.category <> String.Empty Then
                Dim arr() = modifyBook.category.Split(",")
                For i = 0 To ckblstCategories.Items.Count - 1
                    For k = 0 To arr.Length - 1
                        If ckblstCategories.Items.Item(i) = arr(k) Then
                            ckblstCategories.SetItemChecked(i, True)
                        End If
                    Next
                Next
                lstCategories.Items.Clear()
                lstCategories.Items.AddRange(arr)
            End If
            txtISBN.Text = modifyBook.ISBN 'store the ISBN in Form AddNewBook 
            NumericUpDown1.Value = CInt(modifyBook.pageNumber) 'store the number of page in Form AddNewBook 
            cmbBookSelves.SelectedItem = modifyBook.bookSelves  'store the BookSelves in Form AddNewBook 
            txtDescription.Text = modifyBook.description 'store the Description in Form AddNewBook 
            '  tbRating.Value = modifyBook.rating
            cmbRating.SelectedItem = modifyBook.rating
        Else 'add new book
            'clear all texboxes for adding new book
            For Each c In Me.Controls
                If TypeOf c Is TextBox AndAlso CType(c, TextBox).Name.ToString.StartsWith("txt") Then
                    c.text = String.Empty
                End If
            Next
            ' change value of the combobox of bookselves for the new book
            cmbBookSelves.SelectedIndex = 0
            NumericUpDown1.Value = 0 ' change value of the page Number for the new book
            'change to the image and store new for the new book
            picCoverImage.Image = Image.FromFile("NoSelectetBook.PNG")
        End If
    End Sub
    Private Sub CategoriesItems(sender As Object, e As ItemCheckEventArgs) Handles ckblstCategories.ItemCheck
        'checkeListbox : take the selected items and store in categories Or remove unselected items from categories
        If e.NewValue = CheckState.Checked Then
            lstCategories.Items.Add(ckblstCategories.SelectedItem)
        Else
            lstCategories.Items.Remove(ckblstCategories.SelectedItem)
        End If
    End Sub
    Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        'close the application
        Me.Close()
    End Sub
    Private Sub AddBookOrModify(sender As Object, e As EventArgs) Handles btnAddBook.Click
        If btnAddBook.Text = "&Modify Book" Then
            If MessageBox.Show("Are You sure you want to Modify this Book?", "Modify Book", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then

                'here we find the index value of older book and try to delete and we add the new Modify Book
                Dim indxRemove As Integer = -1
            For i = 0 To storageBooks.Count - 1
                If modifyBook.title = storageBooks.ElementAt(i).title AndAlso modifyBook.ISBN = storageBooks.ElementAt(i).ISBN AndAlso
                   modifyBook.author = storageBooks.ElementAt(i).author Then
                    indxRemove = i
                End If
            Next
            If indxRemove <> -1 Then
                storageBooks.RemoveAt(indxRemove)
            End If
            Dim b As StoreBooks
            b.pic = picCoverImage.Image
            b.title = txtTitle.Text
            b.author = txtAuthor.Text
            Dim saveNewCategory As String = String.Empty
            For sv = 0 To lstCategories.Items.Count - 1
                saveNewCategory &= "," & lstCategories.Items.Item(sv)
            Next
            saveNewCategory = saveNewCategory.Substring(1) 'remove the first comma from the first word
            b.category = saveNewCategory
            b.pageNumber = NumericUpDown1.Value
            b.ISBN = txtISBN.Text
            b.description = txtDescription.Text
            b.bookSelves = cmbBookSelves.Text
            b.rating = cmbRating.Text
            storageBooks.Insert(0, b)
            'adding to history
            frmHistory.AddInHistory(Date.Today & Space(1) & TimeOfDay & " => Modify Book. Older Book  - title =" & modifyBook.title & " - Author=" & modifyBook.author & " - ISBN = " & modifyBook.ISBN & " - Rating = " & modifyBook.rating & " - BookSelves =" & modifyBook.bookSelves)
            frmHistory.AddInHistory(Space(20) & "To =>  title=" & txtTitle.Text & " - Author=" & txtAuthor.Text & " - ISBN=" & txtISBN.Text & " - Rating = " & cmbRating.Text & " - BookSleves = " & cmbBookSelves.Text)

                Me.Close()

            End If
        Else
            If txtTitle.Text <> String.Empty AndAlso lstCategories.Items.Count - 1 >= 0 AndAlso cmbBookSelves.SelectedIndex >= 0 Then
                Dim b As StoreBooks
                b.pic = picCoverImage.Image
                b.title = txtTitle.Text
                b.author = txtAuthor.Text
                Dim saveNewCategory As String = String.Empty
                For sv = 0 To lstCategories.Items.Count - 1
                    saveNewCategory &= "," & lstCategories.Items.Item(sv)
                Next
                saveNewCategory = saveNewCategory.Substring(1) 'remove the first comma from the first word
                b.category = saveNewCategory
                b.pageNumber = NumericUpDown1.Value
                b.ISBN = txtISBN.Text
                b.description = txtDescription.Text
                b.bookSelves = cmbBookSelves.Text
                b.rating = cmbRating.Text
                storageBooks.Insert(0, b)
                'adding to history
                frmHistory.AddInHistory(Date.Today & Space(1) & TimeOfDay & " => Add new Book with Book title=" & txtTitle.Text & " Author=" & txtAuthor.Text & " ISBN=" & txtISBN.Text)
                Me.Close()

            Else
                MsgBox("Please Fill the entry of Title, Category And BookSelves")
            End If
        End If
    End Sub
    Private Sub BtnImportImage_Click(sender As Object, e As EventArgs) Handles btnImportImage.Click
        'allow the user to add new Cover image for book
        openImageDialog1.Filter = "PNG|*.png|JPG|*.jpg|GIF|*.gif|Bitmap|*.btm"
        openImageDialog1.InitialDirectory = "C:/"
        openImageDialog1.Title = "Select Image"
        openImageDialog1.FileName = ""
        If openImageDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
            picCoverImage.Image = (Image.FromFile(openImageDialog1.FileName)) 'Cover Image
        End If
    End Sub
    Private Sub BtnAddCategory_Click(sender As Object, e As EventArgs) Handles btnAddCategory.Click
        If txtAddCategory.Text.Length <= 0 OrElse txtAddCategory.Text.Contains(" ") Then ' add New Category
            MessageBox.Show("Cannot store Empty or multi Category")
        Else
            lstCategories.Items.Add(txtAddCategory.Text)
            txtAddCategory.Text = String.Empty
        End If
    End Sub
    Private Sub BtnRemoveCategory_Click(sender As Object, e As EventArgs) Handles btnRemoveCategory.Click
        'remove the category that selected from listbox
        Dim category As String = String.Empty
        If lstCategories.SelectedIndex < 0 Then
            MessageBox.Show("select a Category")
        Else

            lstCategories.Items.Remove(lstCategories.SelectedItem)
        End If


    End Sub
    Private Sub TbRating_Scroll(sender As Object, e As EventArgs) Handles tbRating.Scroll
        cmbRating.SelectedIndex = tbRating.Value
    End Sub
    Private Sub CmbRating_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbRating.SelectedIndexChanged
        tbRating.Value = cmbRating.SelectedIndex
    End Sub
    Private Sub CmbBookSelves_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbBookSelves.SelectedIndexChanged
        If cmbBookSelves.SelectedIndex = 1 Then
            cmbRating.Enabled = True
            tbRating.Enabled = True
        Else
            cmbRating.Enabled = False
            tbRating.Enabled = False
        End If
    End Sub
End Class