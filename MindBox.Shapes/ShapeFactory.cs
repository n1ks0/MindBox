namespace MindBox.Shapes;

internal static class ShapeFactory
{
    internal static IShape CreateShape(params double[] values)
    {
        switch (values.Length)
        {
            case 1:
            {
                return new Circle(values[0]);
            }
            case 3:
            {
                return new Triangle(values[0], values[1], values[2]);
            }
            default:
                throw new ArgumentException("Not supported values", nameof(values));
        }
    }
}