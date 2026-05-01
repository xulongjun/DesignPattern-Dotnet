namespace Memento;

public sealed class EditorOriginator
{
    public string Content { get; private set; } = string.Empty;

    public void SetContent(string content)
    {
        Content = content;
    }

    public EditorMemento Save()
    {
        return new EditorMemento(Content);
    }

    public void Restore(EditorMemento memento)
    {
        Content = memento.Content;
    }
}

