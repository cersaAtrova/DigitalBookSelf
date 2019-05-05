Public Class frmPieChart
    Private Sub FrmPieChart_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        frmChartsPreBuilt.Timer1.Enabled = True
    End Sub
    Protected Friend Sub PieChart(categories As Array, totalCategories As Array, totalOfAllCategories As Integer)
        'draw PieChart
        Dim gr As Graphics = picReport.CreateGraphics
        Dim arrBrushColor(totalCategories.Length - 1) As SolidBrush
        For i = 0 To arrBrushColor.Count - 1
            arrBrushColor(i) = New SolidBrush(Color.FromArgb(20 + Rnd() * 230, 20 + Rnd() * 235, 20 + Rnd() * 235))
        Next
        'Drawing the Frame Of pieChart by Black Line
        gr.DrawLine(Pens.Black, (1), (1), 900, 1)
        gr.DrawLine(Pens.Black, (1), (600), 900, 600)
        gr.DrawLine(Pens.Black, (1), (1), 1, 600)
        gr.DrawLine(Pens.Black, (900), (1), 900, 600)

        Dim miresStart = 0 'start angle
        Dim secondRowForStringReCtangles As Integer = 0 '

        For i = 0 To totalCategories.Length - 1
            ' fill the Pie chart 
            Dim percentageCategory As Double = ((totalCategories(i)) / totalOfAllCategories)
            gr.FillPie(arrBrushColor(i), 5, 5, 590, 590, miresStart, CInt(percentageCategory * 360))
            miresStart += percentageCategory * 360
            'drawing the each category by own color 
            If i Mod 2 = 0 Then 'showing one next to each other by 2 columns

                gr.FillRectangle(arrBrushColor(i), 640, 10 + 35 * secondRowForStringReCtangles, 30, 30)
                gr.DrawString(categories(i), Me.Font, Brushes.Black, 670, 20 + 35 * secondRowForStringReCtangles)
            Else
                gr.FillRectangle(arrBrushColor(i), 780, 10 + 35 * secondRowForStringReCtangles, 30, 30)
                gr.DrawString(categories(i), Me.Font, Brushes.Black, 810, 20 + 35 * secondRowForStringReCtangles)
                secondRowForStringReCtangles += 1
            End If
        Next
    End Sub

End Class