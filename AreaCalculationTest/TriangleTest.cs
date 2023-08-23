using AreaCalculation;
using NUnit.Framework;

namespace AreaCalculationTest;

public class TriangleTest
{
    [SetUp]
    public void Setup()
    {
    }

    [TestCase(0, 0, 0)]
    [TestCase(-1, 1, 1)]
    [TestCase(1, -1, 1)]
    [TestCase(1, 1, -1)]
    public void TriangleSidesZeroOrNegativeTest(double sideA, double sideB, double sideC)
    {
        Assert.Catch<ArgumentException>(() =>
        {
            var triangle = new Triangle(sideA, sideB, sideC);
        });
    }

    [TestCase(5, 5, 10)]
    [TestCase(5, 10, 5)]
    [TestCase(10, 5, 5)]
    public void TriangleIsTriangleTest(double sideA, double sideB, double sideC)
    {
        Assert.Catch<ArgumentException>(() =>
        {
            var triangle = new Triangle(sideA, sideB, sideC);
        });
    }

    [Test]
    public void TriangleIsNotRightTriangleTest()
    {
        Assert.Catch<ArgumentException>(() =>
        {
            var triangle = new Triangle(7, 24, 25);
        });
    }

    [Test]
    public void TriangleRightAreaTest()
    {
        var triangle = new Triangle(1, 1, 1);
        
        Assert.That(Math.Round(triangle.GetArea(), 3), Is.EqualTo(0.433));
    }
}