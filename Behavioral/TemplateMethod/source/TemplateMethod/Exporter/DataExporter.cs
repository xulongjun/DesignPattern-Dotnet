namespace TemplateMethod.Exporter;

public abstract class DataExporter
{
    public string Export()
    {
        var data = ReadData();
        var transformed = Transform(data);
        return Write(transformed);
    }

    protected abstract string ReadData();
    protected virtual string Transform(string raw) => raw;
    protected abstract string Write(string transformed);
}

