Imports DevExpress.Pdf

Namespace AddBookmarks
    Friend Class Program
        Shared Sub Main(ByVal args() As String)

            Using processor As New PdfDocumentProcessor()

                ' Load a document.
                processor.LoadDocument("..\..\Document.pdf")

                ' Create bookmarks and add them to the PDF document.
                Dim destination1 As PdfDestination = processor.CreateDestination(1, 180, 150)
                Dim destination2 As PdfDestination = processor.CreateDestination(1, 168, 230)
                Dim destination3 As PdfDestination = processor.CreateDestination(1, 20, 350)
                processor.Document.Bookmarks.Add(New PdfBookmark() With {.Title = "PDF Document Processor", .Destination = destination1})
                processor.Document.Bookmarks.Add(New PdfBookmark() With {.Title = "Display, Print and Export PDF Documents", .Destination = destination2})
                processor.Document.Bookmarks.Add(New PdfBookmark() With {.Title = "Learn More", .Destination = destination3})

                ' Save the result document.
                processor.SaveDocument("..\..\Result.pdf")
            End Using
        End Sub
    End Class
End Namespace
