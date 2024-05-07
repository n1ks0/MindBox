namespace MindBox.Shapes;

/// <summary>
/// Операции, которые необходимы клиентам по ТЗ
/// </summary>
public static class ShapeOperations
{
    /// <summary>
    /// Получает площадь треугольника по трем сторонам
    /// </summary>
    /// <param name="a">Сторона А</param>
    /// <param name="b">Сторона B</param>
    /// <param name="c">Сторона С</param>
    /// <returns>Площадь треугольника</returns>
    public static double GetTriangleArea(double a, double b, double c)
    {
        var triangle = ShapeFactory.CreateShape(a, b, c);
        return triangle.GetArea();
    }
    
    /// <summary>
    /// Проверяет, является ли треугольник прямоугольным
    /// </summary>
    /// <param name="a">Сторона А</param>
    /// <param name="b">Сторона B</param>
    /// <param name="c">Сторона С</param>
    /// <returns>true - прямоугольный, false - не прямоугольный</returns>
    public static bool IsRightTriangle(double a, double b, double c)
    {
        var triangle = ShapeFactory.CreateShape(a, b, c) as ITriangle;
        return triangle?.IsRight() ?? false;
    }

    /// <summary>
    /// Получает площадь круга по радиусу
    /// </summary>
    /// <param name="r">Радиус круга</param>
    /// <returns>Площадь круга</returns>
    public static double GetCircleArea(double r)
    {
        var circle = ShapeFactory.CreateShape(r);
        return circle.GetArea();
    }
}