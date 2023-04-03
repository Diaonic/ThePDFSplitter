using System;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using iText.Kernel.Pdf;
using iText.Kernel.Pdf.Canvas.Parser;
using iText.Kernel.Pdf.Canvas.Parser.Listener;

namespace ThePDFSplitter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSelectPDF_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "PDF Files (*.pdf)|*.pdf";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string sourcePdfPath = openFileDialog.FileName;
                    SplitAndRenamePDF(sourcePdfPath);
                }
            }
        }

        private void SplitAndRenamePDF(string sourcePdfPath)
        {
            string outputDirectory = Path.GetDirectoryName(sourcePdfPath);

            using (PdfReader reader = new PdfReader(sourcePdfPath))
            {
                PdfDocument sourcePdf = new PdfDocument(reader);
                int numberOfPages = sourcePdf.GetNumberOfPages();

                for (int i = 1; i <= numberOfPages; i++)
                {
                    string outputPath = Path.Combine(outputDirectory, $"{i}.pdf");
                    PdfDocument newPdf = new PdfDocument(new PdfWriter(outputPath));
                    sourcePdf.CopyPagesTo(i, i, newPdf);
                    newPdf.Close();

                    string newFilename = GetTextBetweenKeywords(outputPath, "agreement between", "hereinafter");
                    newFilename = SanitizeFilename(newFilename);
                    string newFilepath = Path.Combine(outputDirectory, $"{newFilename}.pdf");

                    File.Move(outputPath, newFilepath);
                }
            }
        }

        private string GetFirstCharactersFromPage(string pdfPath,int startingChar, int endingChar)
        {
            using (PdfReader reader = new PdfReader(pdfPath))
            {
                PdfDocument pdf = new PdfDocument(reader);
                ITextExtractionStrategy strategy = new SimpleTextExtractionStrategy();
                string pageText = PdfTextExtractor.GetTextFromPage(pdf.GetPage(1), strategy);
                return pageText.Length >= endingChar ? pageText.Substring(startingChar, endingChar) : pageText;
            }
        }

        private string GetTextBetweenKeywords(string pdfPath, string startKeyword, string endKeyword)
        {
            using (PdfReader reader = new PdfReader(pdfPath))
            {
                PdfDocument pdf = new PdfDocument(reader);
                ITextExtractionStrategy strategy = new SimpleTextExtractionStrategy();
                string pageText = PdfTextExtractor.GetTextFromPage(pdf.GetPage(1), strategy);

                int startIndex = pageText.IndexOf(startKeyword, StringComparison.OrdinalIgnoreCase) + startKeyword.Length;
                int endIndex = pageText.IndexOf(endKeyword, StringComparison.OrdinalIgnoreCase);

                if (startIndex > -1 && endIndex > -1 && endIndex > startIndex)
                {
                    return pageText.Substring(startIndex, endIndex - startIndex).Trim();
                }
                else
                {
                    return "default_filename";
                }
            }
        }

        private string SanitizeFilename(string filename)
        {
            string sanitized = Regex.Replace(filename, @"[^\w\s]", ""); // Remove special characters
            sanitized = sanitized.Replace(" ", "_"); // Replace spaces with underscores
            return sanitized;
        }
    }
}
