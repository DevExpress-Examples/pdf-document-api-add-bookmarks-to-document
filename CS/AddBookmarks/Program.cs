using DevExpress.Pdf;

namespace AddBookmarks {
    class Program {
        static void Main(string[] args) {

            using (PdfDocumentProcessor processor = new PdfDocumentProcessor()) {

                // Load a document.
                processor.LoadDocument("..\\..\\Document.pdf");

                // Create bookmarks and add them to the PDF document.
                PdfDestination destination1 = processor.CreateDestination(1, 180, 150);
                PdfDestination destination2 = processor.CreateDestination(1, 168, 230);
                PdfDestination destination3 = processor.CreateDestination(1, 20, 350);
                processor.Document.Bookmarks.Add(new PdfBookmark() { Title = "PDF Document Processor", Destination = destination1 });
                processor.Document.Bookmarks.Add(new PdfBookmark() { Title = "Display, Print and Export PDF Documents", Destination = destination2 });
                processor.Document.Bookmarks.Add(new PdfBookmark() { Title = "Learn More", Destination = destination3 });

                // Save the result document.
                processor.SaveDocument("..\\..\\Result.pdf");
            }
        }
    }
}
