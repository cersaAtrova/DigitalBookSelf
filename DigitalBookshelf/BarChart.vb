Public Class frmBarChartReport

    Private Sub FrmBarChart_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        frmChartsPreBuilt.Timer1.Enabled = True
    End Sub
    Protected Friend Sub BarChart(category As Array, stockOfEachCategory As Array, totalStock As Integer)
        Dim gr As Graphics = picReport.CreateGraphics
        'DrAW  the Bar Chart 
        'drawing the lines
        Dim p As New Pen(Color.Black, 2)
        gr.DrawLine(p, 100, 45, 100, 450) ' Y-ayis
        gr.DrawLine(p, 100, 450, stockOfEachCategory.Length * 70 + 50, 450) ' X-axis
        'Drwings the Y-ayis titles value
        For i = 0 To 10
            gr.DrawString((10 - i) * 10 & " %", Me.Font, Brushes.Black, 60, 43 + (i) * 40)
            If i < 10 Then
                gr.DrawString("--", Me.Font, Brushes.Black, 94, 43 + i * 40)
            End If
        Next
        'drawing the X-axis Titles value
        For i = 0 To category.Length - 1
            For k = 0 To category(i).ToString.Length - 1
                gr.DrawString(category(i).ToString.Substring(k, 1), Me.Font, Brushes.Black, (i + 1) * 60 + 50, (k * 10 + 455))
            Next
        Next
        ' drawing the Bar Chart with element
        For i = 0 To stockOfEachCategory.Length - 1
            Dim arrow As Integer = Math.Round((((((stockOfEachCategory(i)) / totalStock)) * 400))) ' the Y-axis is 400 px so i multiply times 400 to fint the fill value
            gr.FillRectangle(Brushes.Blue, (i + 1) * 60 + 50, 450 - arrow, 20, arrow)
            gr.DrawString(Math.Round(((((stockOfEachCategory(i)) / totalStock)) * 100)) & " %", Me.Font, Brushes.Black, (i + 1) * 60 + 50, 450 - arrow - 15)
        Next

    End Sub

End Class