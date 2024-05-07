namespace MindBox.Shapes;

internal abstract class Shape : IShape
{
    /// <summary>
    /// Получает площадь фигуры и округляет её до 2 знаков после запятой
    /// </summary>
    /// <returns>Площадь фигуры</returns>
    /// <remarks>В ТЗ не сказано про округление, поэтому сделал хардкодом 2 знака</remarks>
    public double GetArea()
    {
        return Math.Round(DoGetArea(), 2);
    }
    
    protected abstract double DoGetArea();
}