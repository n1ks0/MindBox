namespace MindBox.Shapes;

internal sealed class Triangle : Shape, ITriangle
{
    private readonly double _a, _b, _c;

    public Triangle(double a, double b, double c)
    {
        _a = a;
        _b = b;
        _c = c;
    }
    
    protected override double DoGetArea()
    {
        var p = GetPerimeter() / 2d;
        return Math.Sqrt(p * (p - _a) * (p - _b) * (p - _c));
    }

    public double GetPerimeter()
    {
        return _a + _b + _c;
    }

    public bool IsRight()
    {
        return _a * _a + _b * _b == _c * _c || _a * _a + _c * _c == _b * _b || _c * _c + _b * _b == _a * _a;
    }
}