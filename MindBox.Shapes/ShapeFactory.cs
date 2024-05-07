namespace MindBox.Shapes;

internal abstract class ShapeFactory
{
    public abstract IShape Create(params double[] values);
}

internal class CircleFactory : ShapeFactory
{
    /// <inheritdoc />
    public override IShape Create(params double[] values)
    {
        return new Circle(values[0]);
    }
}

internal class TriangleFactory : ShapeFactory
{
    /// <inheritdoc />
    public override IShape Create(params double[] values)
    {
        return new Triangle(values[0], values[1], values[2]);
    }
}