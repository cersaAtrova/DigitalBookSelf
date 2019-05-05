Public Class frmChartsPreBuilt
    Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub
    Private Sub BtnOk_Click(sender As Object, e As EventArgs) Handles btnOk.Click
        'open the Form
        If btnOk.Text = "&Go Pie Chart" Then
            frmPieChart.ShowDialog()
        ElseIf btnOk.Text = "&Go Bar Chart" Then
            frmBarChartReport.ShowDialog()
        End If

        Me.Close()
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        'fill the Chart by category
        If radByCategory.Checked = True Then
            Dim lnqFindCategories = From c In storageBooks
                                    Let Category = c.category
                                    Select Category

            'because we have categories by C.S.V we break the comma to take all categories 
            Dim ShowCategory As String = String.Empty
            For i = 0 To lnqFindCategories.Count - 1
                ShowCategory &= "," & lnqFindCategories.ElementAt(i)
            Next
            ShowCategory = ShowCategory.Substring(1)
            Dim countCategory() = ShowCategory.Split(",")
            Dim lnqAllCategorys = From c In countCategory
                                  Select c

            'groupping the categories to find how each category we used
            Dim lnqCountGroup = From c In countCategory
                                Group c By c Into Group
                                Order By Group.Count Descending
                                Select Category = c, Total = Group.Count

            'take the total of categories
            Dim totalBooks As Integer = 0
            For Each c In lnqCountGroup
                totalBooks += c.Total
            Next
            'remove dublicate
            Dim lnqCountCategorys = From c In countCategory
                                    Select c Distinct
            ' store in array
            ReDim countCategory(lnqCountCategorys.Count - 1)
            Dim countGroup(lnqCountCategorys.Count - 1)

            For i = 0 To lnqCountGroup.Count - 1
                countCategory(i) = lnqCountGroup.ElementAt(i).Category
                countGroup(i) = lnqCountGroup.ElementAt(i).Total
            Next
            'call the method pie Chart to drawing the result
            If btnOk.Text = "&Go Pie Chart" Then

                frmPieChart.PieChart(countCategory, countGroup, totalBooks)

            ElseIf btnOk.Text = "&Go Bar Chart" Then

                frmBarChartReport.BarChart(countCategory, countGroup, totalBooks)

            End If

            Timer1.Enabled = False

            '==================
            'drawing by Reading
            '==================
        ElseIf radByReading.Checked = True Then
            Dim lnqFindReading = From c In storageBooks
                                 Let bookselves = c.bookSelves
                                 Select bookselves

            'groupping the categories to find how each category we used
            Dim lnqCountGroup = From c In lnqFindReading
                                Group c By c Into Group
                                Order By Group.Count Descending
                                Select Bookselves = c, Total = Group.Count

            'take the total of categories
            Dim totalReading As Integer = 0
            For Each c In lnqCountGroup
                totalReading += c.Total
            Next
            'remove dublicate
            Dim lnqCountCategorys = From c In lnqFindReading
                                    Select c Distinct

            'store in array for reason to call further down the pieChart method
            Dim countCategory(lnqCountCategorys.Count - 1)
            Dim countGroup(lnqCountCategorys.Count - 1)

            For i = 0 To lnqCountGroup.Count - 1
                countCategory(i) = lnqCountGroup.ElementAt(i).Bookselves
                countGroup(i) = lnqCountGroup.ElementAt(i).Total
            Next

            If btnOk.Text = "&Go Pie Chart" Then
                frmPieChart.PieChart(countCategory, countGroup, totalReading)
            Else
                frmBarChartReport.BarChart(countCategory, countGroup, totalReading)
            End If
            Timer1.Enabled = False
            '=================
            'drawing by author
            '=================
        ElseIf radByAuthor.Checked = True Then
            Dim lnqFindAuthor = From c In storageBooks
                                Let author = c.author
                                Select author

            'groupping the categories to find how each category we used
            Dim lnqCountGroup = From c In lnqFindAuthor
                                Group c By c Into Group
                                Order By Group.Count Descending
                                Select author = c, Total = Group.Count

            'take the total of categories
            Dim totalAuthor As Integer = 0
            For Each c In lnqCountGroup
                totalAuthor += c.Total
            Next
            'remove dublicate
            Dim lnqCountCategorys = From c In lnqFindAuthor
                                    Select c Distinct

            'store in array for reason to call further down the pieChart method
            Dim countCategory(lnqCountCategorys.Count - 1)
            Dim countGroup(lnqCountCategorys.Count - 1)
            For i = 0 To lnqCountGroup.Count - 1
                countCategory(i) = lnqCountGroup.ElementAt(i).author
                countGroup(i) = lnqCountGroup.ElementAt(i).Total
            Next
            frmPieChart.PieChart(countCategory, countGroup, totalAuthor)
            Timer1.Enabled = False

            '=================
            'drawing by Rating
            '=================
        ElseIf radByRating.Checked = True Then
            Dim lnqFindRating = From c In storageBooks
                                Let rating = c.rating
                                Select rating

            'groupping the categories to find how each category we used
            Dim lnqCountGroup = From c In lnqFindRating
                                Group c By c Into Group
                                Order By Group.Count Descending
                                Select rating = c, Total = Group.Count

            'take the total of categories
            Dim totalRating As Integer = 0
            For Each c In lnqCountGroup
                totalRating += c.Total
            Next
            'remove dublicate
            Dim lnqCountCategorys = From c In lnqFindRating
                                    Select c Distinct

            'store in array for reason to call further down the pieChart method
            Dim countCategory(lnqCountCategorys.Count - 1)
            Dim countGroup(lnqCountCategorys.Count - 1)
            For i = 0 To lnqCountGroup.Count - 1
                countCategory(i) = lnqCountGroup.ElementAt(i).rating
                countGroup(i) = lnqCountGroup.ElementAt(i).Total
            Next
            If btnOk.Text = "&Go Pie Chart" Then
                frmPieChart.PieChart(countCategory, countGroup, totalRating)
            Else
                frmBarChartReport.BarChart(countCategory, countGroup, totalRating)
            End If
            Timer1.Enabled = False
        End If
    End Sub
End Class