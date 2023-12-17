using BuilderExample.Builder;
using BuilderExample.Director;
using BuilderExample.Product;

namespace BuilderExample.Tests
{
    public class BuilderExampleUnitTest
    {
        [Theory]
        [InlineData("Excel")]
        [InlineData("Pdf")]
        public void WhenTestingReportsBuilder_ThenShowReportsParts(string typeReport)
        {
            // Arrange
            string expectedReportContent = $"{typeReport} Content Section";
            string expectedReportFooter = $"{typeReport} Footer";
            string expectedReportHeader = $"{typeReport} Header";
            string expectedReportType = $"{typeReport}";

            // Act
            Report report = GenerateReport(typeReport);

            // Assert
            Assert.Equal(expectedReportContent, report.ReportContent);
            Assert.Equal(expectedReportFooter, report.ReportFooter);
            Assert.Equal(expectedReportHeader, report.ReportHeader);
            Assert.Equal(expectedReportType, report.ReportType);
        }

        private static Report GenerateReport(string typeVehicle)
        {
            switch (typeVehicle)
            {
                case "Excel":
                    ExcelReport excelReport = new();
                    ReportDirector.MakeReport(excelReport);
                    return excelReport.ReportObject;
                case "Pdf":
                    PdfReport pdfReport = new();
                    ReportDirector.MakeReport(pdfReport);
                    return pdfReport.ReportObject;
                default:
                    return new Report();
            }
        }
    }
}