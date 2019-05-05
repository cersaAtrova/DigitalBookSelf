
Public Class frmHistory
    Private Sub FrmHistory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'load from filethe data and show on the screen all history
        RefreshFile()
    End Sub
    Protected Friend Sub AddInHistory(ByRef storage As String)
        RefreshFile()
        lstHistory.Items.Insert(0, storage)
        Dim root As New XElement("HistoryFile")

        For i = 0 To lstHistory.Items.Count - 1
            Dim child0 As New XElement("Show")
            Dim child As New XElement("history", lstHistory.Items.Item(i))
            child0.Add(child)
            root.Add(child0)
        Next
        root.Save("History.xml")
    End Sub
    Private Sub RefreshFile()
        lstHistory.Items.Clear()

        If System.IO.File.Exists("History.xml") Then
            Dim xmlElement As XElement = XElement.Load("History.xml")
            Dim lnqHistory = From c In xmlElement.Descendants("Show")
                             Select c.<history>.Value

            For Each c In lnqHistory
                lstHistory.Items.Add(c)
            Next
        End If
    End Sub
End Class
