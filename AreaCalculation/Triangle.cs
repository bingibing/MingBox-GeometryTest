namespace AreaCalculation;

public sealed class Triangle : Figure
{
    /// <summary>
    /// Сторона A
    /// </summary>
    private double _sideA;

    /// <summary>
    /// Сторона B
    /// </summary>
    private double _sideB;

    /// <summary>
    /// Сторона C
    /// </summary>
    private double _sideC;

    /// <summary>
    /// Конструктор класса
    /// </summary>
    /// <param name="sideA">Сторона A</param>
    /// <param name="sideB">Сторона B</param>
    /// <param name="sideC">Сторона C</param>
    public Triangle(double sideA, double sideB, double sideC)
    {
        SideZeroOrNegativeCheck(sideA);
        SideZeroOrNegativeCheck(sideB);
        SideZeroOrNegativeCheck(sideC);

        IsTriangleCheck(sideA, sideB, sideC);

        IsNotRightTriangle(sideA, sideB, sideC);

        _sideA = sideA;
        _sideB = sideB;
        _sideC = sideC;
    }

    /// <summary>
    /// Расчитывает плозадь треугольника
    /// </summary>
    /// <returns>Возвращает площадь треугольника</returns>
    public override double GetArea()
    {
        var p = (_sideA + _sideB + _sideC) / 2;
        return Math.Sqrt(p * (p - _sideA) * (p - _sideB) * (p - _sideC));
    }

    /// <summary>
    /// Проверяет длины стороны на отрицательные числа и 0
    /// </summary>
    /// <param name="value">Длина стороны</param>
    /// <returns>Возвращает true или ArgumentException</returns>
    /// <exception cref="ArgumentException">Вызывает исключение в случае если значение равно 0 или отрицательно</exception>
    private bool SideZeroOrNegativeCheck(double value)
    {
        if (value <= 0)
            throw new ArgumentException("Некорректное значение, одна из сторона имеет отрицательное значение или равна 0", nameof(value));
        return true;
    }

    /// <summary>
    /// Проверяет длины сторон на то, чтобы сторона не превышала сумму двух других сторон
    /// </summary>
    /// <param name="sideA">Сторона A</param>
    /// <param name="sideB">Сторона B</param>
    /// <param name="sideC">Сторона C</param>
    /// <returns>Возврашает true или ArgumentException</returns>
    /// <exception cref="ArgumentException">Вызывает исключение в случае если одна из сторон треугольника больше суммы двух других сторон</exception>
    private bool IsTriangleCheck(double sideA, double sideB, double sideC)
    {
        var maxSide = Math.Max(sideA, Math.Max(sideB, sideC));
        var perimeter = sideA + sideB + sideC;

        if (perimeter - maxSide * 2 <= 0)
            throw new ArgumentException("Одна сторона треугольника не может быть больше суммых двух других сторон");
        return true;
    }

    /// <summary>
    /// Проверяет является ли треугольник прямоугольным
    /// </summary>
    /// <param name="sideA">Сторона A</param>
    /// <param name="sideB">Сторона B</param>
    /// <param name="sideC">Сторона C</param>
    /// <returns>Возвращает true если треугольник прямоугольный</returns>
    private bool IsNotRightTriangle(double sideA, double sideB, double sideC)
    {
        var degreeA = Math.Pow(sideA, 2);
        var degreeB = Math.Pow(sideB, 2);
        var degreeC = Math.Pow(sideC, 2);

        if (degreeA + degreeB == degreeC || degreeA + degreeC == degreeB || degreeC + degreeB == degreeA)
            throw new ArgumentException("Треугольник является прямоугольным");
        return true;
    }
}