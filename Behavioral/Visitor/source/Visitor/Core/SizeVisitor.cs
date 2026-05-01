namespace Visitor.Core;

public sealed class SizeVisitor : IVisitor<int>
{
    public int Visit(FileElement file) => file.Size;

    public int Visit(FolderElement folder)
    {
        var sum = 0;
        foreach (var child in folder.Children)
        {
            sum += child.Accept(this);
        }
        return sum;
    }
}

