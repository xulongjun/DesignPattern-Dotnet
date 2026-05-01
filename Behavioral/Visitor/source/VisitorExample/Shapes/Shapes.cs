namespace VisitorExample.Shapes;

public interface IShape
{
    double Accept(IShapeVisitor visitor);
}

public interface IShapeVisitor
{
    double Visit(Circle circle);
    double Visit(Rectangle rectangle);
}

public sealed class Circle(double radius) : IShape
{
    public double Radius { get; } = radius;
    public double Accept(IShapeVisitor visitor) => visitor.Visit(this);
}

public sealed class Rectangle(double width, double height) : IShape
{
    public double Width { get; } = width;
    public double Height { get; } = height;
    public double Accept(IShapeVisitor visitor) => visitor.Visit(this);
}

public sealed class AreaVisitor : IShapeVisitor
{
    public double Visit(Circle circle) => Math.PI * circle.Radius * circle.Radius;
    public double Visit(Rectangle rectangle) => rectangle.Width * rectangle.Height;
}

