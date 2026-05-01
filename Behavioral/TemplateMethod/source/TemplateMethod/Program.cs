using TemplateMethod.Exporter;

var exporter = new JsonExporter();
Console.WriteLine(exporter.Export());

file sealed class JsonExporter : DataExporter
{
    protected override string ReadData() => "  hello  ";
    protected override string Transform(string raw) => raw.Trim().ToUpperInvariant();
    protected override string Write(string transformed) => $$"""{"value":"{{transformed}}"}""";
}

