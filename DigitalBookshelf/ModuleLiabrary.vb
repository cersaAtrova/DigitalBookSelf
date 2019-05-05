Module ModuleLiabrary
    Friend Function ConvertByteToString(ByVal Img As Bitmap) As String
        'convert the image to string
        Dim ImgConverter As New ImageConverter()
        Dim ImgBytes As Byte() = ImgConverter.ConvertTo(Img, GetType(Byte()))
        Return Convert.ToBase64String(ImgBytes)
    End Function

    Public Function ConvertStringToByte(ByVal btmImage As String) As Bitmap
        'convert the string to image
        Dim bytes() As Byte = Convert.FromBase64String(btmImage) ' strData would come from 
        Dim MS As New System.IO.MemoryStream(bytes)
        Dim bmp As Image = Image.FromStream(MS)
        Return bmp
    End Function
    Structure StoreBooks
        Dim pic As Image
        Dim title As String
        Dim author As String
        Dim category As String
        Dim ISBN As String
        Dim pageNumber As String
        Dim description As String
        Dim bookSelves As String
        Dim rating As String
    End Structure
    Public modifyBook As StoreBooks
    Friend advertisingQuotes As New List(Of Image) 'import photo of advertising
    Public storageBooks As New List(Of StoreBooks)


End Module
