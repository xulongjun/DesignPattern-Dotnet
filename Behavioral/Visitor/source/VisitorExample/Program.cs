using VisitorExample.Shapes;

var shapes = new IShape[]
{
    new Circle(2),
    new Rectangle(3, 4),
};

var areaVisitor = new AreaVisitor();
var total = shapes.Sum(s => s.Accept(areaVisitor));
Console.WriteLine($"Total area: {total:F2}");

