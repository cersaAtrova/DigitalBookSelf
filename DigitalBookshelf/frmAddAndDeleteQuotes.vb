Public Class frmAddAndDeleteQuotes
    Dim rowIndxSelected As Integer = -1 ' take the selected index
    Private Sub FrmAddOrDeleteQuotes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RefreshPage()
    End Sub
    Private Sub RefreshPage() 'refresh the page and store in the array
        Dim lnqQuotes = From c In XElement.Load("Quotes.xml").Descendants("picture")
                        Let Picture As Bitmap = New Bitmap(ConvertStringToByte(c.<pic>.Value), New Size(550, 90))
                        Let Number = c.<num>.Value
                        Select Number, Picture

        dgvDisplayQuoes.DataSource = lnqQuotes.ToList
    End Sub
    Private Sub SaveQuotes()
        'save the new picture in xml file
        Dim root As XElement = New XElement("QuotesPicture")
        For i = 0 To advertisingQuotes.Count - 1
            Dim child As XElement = New XElement("picture")
            Dim elementOfChild As XElement = New XElement("pic", ConvertByteToString(advertisingQuotes.ElementAt(i)))
            Dim elementOfChild1 As XElement = New XElement("num", i + 1)
            child.Add(elementOfChild)
            child.Add(elementOfChild1)
            root.Add(child)
        Next
        root.Save("Quotes.xml")
    End Sub
    Private Sub BtnTSAdd_Click_1(sender As Object, e As EventArgs) Handles btnTSAdd.Click
        'allow the user to add new quotes image
        openImageDialog1.Filter = "PNG|*.png|JPG|*.jpg|GIF|*.gif|Bitmap|*.btm"
        openImageDialog1.InitialDirectory = "C:/"
        openImageDialog1.Title = "Select Image"
        openImageDialog1.FileName = ""
        If openImageDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
            advertisingQuotes.Add(Image.FromFile(openImageDialog1.FileName)) 'store the image in the list
            SaveQuotes() 'save the into the file
            RefreshPage() 'refresh the page
            frmHistory.AddInHistory(Date.Today & Space(1) & TimeOfDay & " => Add  1 Quotes ") 'add to history
        End If
    End Sub
    Private Sub BtnTSDelete_Click_1(sender As Object, e As EventArgs) Handles btnTSDelete.Click
        If rowIndxSelected <> -1 Then
            If MessageBox.Show("Are you sure you ant to delete this Image??", "Delete Image", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then

                Dim lnqDelete = From c In XElement.Load("Quotes.xml").Descendants("picture")
                                Let Picture As Bitmap = New Bitmap(ConvertStringToByte(c.<pic>.Value), New Size(450, 80))
                                Let Number = c.<num>.Value
                                Where Number <> rowIndxSelected + 1
                                Select Number, Picture

                For i = 0 To lnqDelete.Count - 1
                    advertisingQuotes.Item(i) = lnqDelete.ElementAt(i).Picture 'store the new image from begining
                Next
                advertisingQuotes.Remove(advertisingQuotes.Last) 'delete the last image
                SaveQuotes() 'SAVE TO XML FILE
                rowIndxSelected = -1 'initialiaze the negative value to select again the user
                RefreshPage() 'refresh the page
                frmHistory.AddInHistory(Date.Today & Space(1) & TimeOfDay & " => Delete  1 Quotes ") 'add to history the move
            End If
        Else
            MsgBox("You must select a row before Delete")
        End If
    End Sub
    Private Sub BtnTSDeleteAll_Click_1(sender As Object, e As EventArgs) Handles btnTSDeleteAll.Click
        If MessageBox.Show("Are you sure you ant to delete this Image??", "Delete Image", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
            advertisingQuotes.Clear()
            Dim root As XElement = New XElement("QuotesPicture")
            root.Save("Quotes.xml")
            RefreshPage() 'refresh the page

            frmHistory.AddInHistory(Date.Today & Space(1) & TimeOfDay & " => Delete All  Quotes ") 'add to history the move
        End If
    End Sub
    Private Sub DgvDisplayQuoes_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvDisplayQuoes.CellContentClick
        rowIndxSelected = e.RowIndex 'collect of row selected
    End Sub
End Class