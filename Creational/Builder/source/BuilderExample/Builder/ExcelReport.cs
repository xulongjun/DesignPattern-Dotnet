using BuilderExample.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderExample.Builder
{
    // The Following Concrete Builder Implementd the ReportBuilder Abstract Class and 
    // provide specific implementations of the steps for Creating ExcelReport. 
    public class ExcelReport : ReportBuilder
    {
        public override void SetReportContent()
        {
            ReportObject.ReportContent = "Excel Content Section";
        }
        public override void SetReportFooter()
        {
            ReportObject.ReportFooter = "Excel Footer";
        }
        public override void SetReportHeader()
        {
            ReportObject.ReportHeader = "Excel Header";
        }
        public override void SetReportType()
        {
            ReportObject.ReportType = "Excel";
        }
    }
}
