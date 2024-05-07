using MindBox.Shapes;

namespace MindBox.Tests;

public class Tests
{
    [Test]
    public void GetCircleArea_Test()
    {
        Assert.AreEqual(28.27d, ShapeOperations.GetCircleArea(3));
    }

    [Test]
    public void GetTriangleArea_Test()
    {
        Assert.AreEqual(6.5d, ShapeOperations.GetTriangleArea(3, 5, 7));
    }

    [Test]
    public void IsRightTriangle_Test()
    {
        Assert.True(ShapeOperations.IsRightTriangle(3, 4, 5));
        Assert.False(ShapeOperations.IsRightTriangle(3, 4, 6));
    }
}