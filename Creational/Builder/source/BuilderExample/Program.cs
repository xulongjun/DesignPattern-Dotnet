// See https://aka.ms/new-console-template for more information
using BuilderExample.Builder;
using BuilderExample.Director;

var excelReport = new ExcelReport();
ReportDirector.MakeReport(excelReport);
excelReport.ReportObject.DisplayReport();

var pdfReport = new PdfReport();
ReportDirector.MakeReport(pdfReport);
pdfReport.ReportObject.DisplayReport();