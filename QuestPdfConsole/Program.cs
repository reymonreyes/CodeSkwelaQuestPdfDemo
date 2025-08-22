using QuestPDF.Fluent;
using QuestPDF.Infrastructure;

namespace QuestPdfConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            QuestPDF.Settings.License = LicenseType.Community;

            Document.Create(document =>
            {
                document.Page(page =>
                {
                    page.Content().Text("Hello PDF!");
                });
            }).GeneratePdfAndShow();
        }
    }
}
