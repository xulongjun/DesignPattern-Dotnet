// See https://aka.ms/new-console-template for more information
using BuilderExample.Builder;
using BuilderExample.Director;

ExcelReport excelReport = new();
ReportDirector.MakeReport(excelReport);
excelReport.ReportObject.DisplayReport();

PdfReport pdfReport = new();
ReportDirector.MakeReport(pdfReport);
pdfReport.ReportObject.DisplayReport();