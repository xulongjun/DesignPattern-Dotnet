namespace Visitor.Core;

public interface IElement
{
    T Accept<T>(IVisitor<T> visitor);
}

public interface IVisitor<out T>
{
    T Visit(FileElement file);
    T Visit(FolderElement folder);
}

public sealed class FileElement(string name, int size) : IElement
{
    public string Name { get; } = name;
    public int Size { get; } = size;

    public T Accept<T>(IVisitor<T> visitor) => visitor.Visit(this);
}

public sealed class FolderElement(string name, IReadOnlyList<IElement> children) : IElement
{
    public string Name { get; } = name;
    public IReadOnlyList<IElement> Children { get; } = children;

    public T Accept<T>(IVisitor<T> visitor) => visitor.Visit(this);
}

