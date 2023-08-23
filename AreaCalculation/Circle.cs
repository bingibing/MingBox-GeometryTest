namespace AreaCalculation;

public sealed class Circle : Figure
{
    /// <summary>
    /// Радиус
    /// </summary>
    private double _radius;

    /// <summary>
    /// Конструктор класса
    /// </summary>
    /// <param name="radius">Радиус <see cref="_radius"/></param>
    /// <exception cref="ArgumentException">Вызывает исключение в случае если значение равно 0 или отрицательное</exception>
    public Circle(double radius)
    {
        if (radius <= 0)
            throw new ArgumentException("Некорректное значение, радиус равен отрциательному значению или 0", nameof(radius));   
        
        _radius = radius;
    }

    /// <summary>
    /// Расчитывает площадь круга
    /// </summary>
    /// <returns>Возвращает площадь круга</returns>
    public override double GetArea()
    {
        return Math.PI * Math.Pow(_radius, 2d);
    }
}