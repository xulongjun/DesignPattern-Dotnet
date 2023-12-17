﻿namespace BuilderExample.Product
{
    // It makes sense to use the Builder Design Pattern only 
    // when your products are quite complex 
    // and require extensive configuration.
    // Using the following Report Product class, we can configure different types of Product
    public class Report
    {
        public string? ReportType { get; set; }
        public string? ReportHeader { get; set; }
        public string? ReportFooter { get; set; }
        public string? ReportContent { get; set; }
        public void DisplayReport()
        {
            Console.WriteLine($"Report Type : {ReportType}");
            Console.WriteLine($"Header : {ReportHeader} ");
            Console.WriteLine($"Content : {ReportContent} ");
            Console.WriteLine($"Footer : {ReportFooter} ");
        }
    }
}
