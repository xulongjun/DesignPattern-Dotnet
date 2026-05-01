namespace MementoExample.TextEditor;

public sealed class TextEditor
{
    private readonly Stack<Snapshot> _history = new();

    public string Text { get; private set; } = string.Empty;

    public void Type(string text)
    {
        _history.Push(new Snapshot(Text));
        Text += text;
    }

    public void Undo()
    {
        if (_history.Count == 0)
            return;
        Text = _history.Pop().Text;
    }

    private sealed record Snapshot(string Text);
}

