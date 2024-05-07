namespace MindBox.Shapes;

internal sealed class Circle : Shape, ICircle
{
    private double _radius;

    public Circle(double radius)
    {
        _radius = radius;
    }

    /// <inheritdoc />
    protected override double DoGetArea()
    {
        return Math.PI * _radius * _radius;
    }
}