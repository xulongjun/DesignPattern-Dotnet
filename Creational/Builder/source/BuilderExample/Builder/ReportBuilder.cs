using BuilderExample.Product;

namespace BuilderExample.Builder
{
    public abstract class ReportBuilder
    {
        public Report ReportObject { get; set; } = new();
        public abstract void SetReportType();
        public abstract void SetReportHeader();
        public abstract void SetReportContent();
        public abstract void SetReportFooter();
    }
}
