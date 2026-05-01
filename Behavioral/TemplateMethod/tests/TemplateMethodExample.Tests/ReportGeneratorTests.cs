using TemplateMethodExample.Reporting;

namespace TemplateMethodExample.Tests;

public class ReportGeneratorTests
{
    [Fact]
    public void Generate_ShouldUseTemplateSteps()
    {
        var generator = new SalesReportGenerator();
        var report = generator.Generate();

        Assert.Contains("Sales Report", report);
        Assert.Contains("Total: 100", report);
    }
}

