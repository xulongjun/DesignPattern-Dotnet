using Visitor.Core;

var root = new FolderElement(
    "root",
    new IElement[]
    {
        new FileElement("a.txt", 10),
        new FolderElement("sub", new IElement[] { new FileElement("b.txt", 5) })
    });

var size = root.Accept(new SizeVisitor());
Console.WriteLine($"Total size: {size}");

