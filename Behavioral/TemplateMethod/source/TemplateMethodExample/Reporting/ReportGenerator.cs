namespace TemplateMethodExample.Reporting;

public abstract class ReportGenerator
{
    public string Generate()
    {
        var title = BuildTitle();
        var body = BuildBody();
        return $"{title}\n{body}\n";
    }

    protected abstract string BuildTitle();
    protected abstract string BuildBody();
}

public sealed class SalesReportGenerator : ReportGenerator
{
    protected override string BuildTitle() => "Sales Report";
    protected override string BuildBody() => "Total: 100";
}

