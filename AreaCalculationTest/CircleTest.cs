using AreaCalculation;
using NUnit.Framework;

namespace AreaCalculationTest;

public class CircleTest
{
    [Test]
    public void CircleRadiusZeroOrNegativeTest()
    {
        Assert.Catch<ArgumentException>(() =>
        {
            var triangle = new Circle(-1);
        });
    }

    [Test]
    public void CircleRightAreaTest()
    {
        var circle = new Circle(1);
        
        Assert.That(Math.Round(circle.GetArea(), 2), Is.EqualTo(3.14));
    }
}