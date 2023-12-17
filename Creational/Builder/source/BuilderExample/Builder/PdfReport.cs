using BuilderExample.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderExample.Builder
{
    // The Following Concrete Builder Implementd the ReportBuilder Abstract Class and 
    // provide specific implementations of the steps for Creating PDFReport. 
    public class PdfReport : ReportBuilder
    {
        public override void SetReportContent()
        {
            ReportObject.ReportContent = "Pdf Content Section";
        }
        public override void SetReportFooter()
        {
            ReportObject.ReportFooter = "Pdf Footer";
        }
        public override void SetReportHeader()
        {
            ReportObject.ReportHeader = "Pdf Header";
        }
        public override void SetReportType()
        {
            ReportObject.ReportType = "Pdf";
        }
    }
}