using BuilderExample.Builder;

namespace BuilderExample.Director
{
    // The Director is only responsible for executing the building steps in a particular order. 
    // It is helpful when producing products according to a specific order or configuration. 
    public static class ReportDirector
    {
        public static void MakeReport(ReportBuilder reportBuilder)
        {
            reportBuilder.SetReportType();
            reportBuilder.SetReportHeader();
            reportBuilder.SetReportContent();
            reportBuilder.SetReportFooter();
        }
    }
}
