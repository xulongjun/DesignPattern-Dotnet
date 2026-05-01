namespace Memento;

public sealed class HistoryCaretaker
{
    private readonly Stack<EditorMemento> _history = new();

    public void Push(EditorMemento memento) => _history.Push(memento);

    public EditorMemento Pop()
    {
        if (_history.Count == 0)
            throw new InvalidOperationException("No mementos in history.");
        return _history.Pop();
    }
}

