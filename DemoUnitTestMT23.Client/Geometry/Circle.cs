using DemoUnitTestMT23.Client.Geometry.Interfaces;
using DemoUnitTestMT23.Client.Services.Interfaces;

namespace DemoUnitTestMT23.Client.Geometry;

public class Circle(ICalculator calculator) : ICircle
{
    public double Radius { get; set; }

    public double GetArea()
    {
        return calculator.Multiply(Radius, Radius, Math.PI);
    }

    public double GetCircumference()
    {
        return calculator.Multiply(2,
            Math.Sqrt(calculator.Divide(GetArea(), Math.PI))
        );
    }

    public double GetDiameter()
    {
        return calculator.Multiply(2, Radius);
    }
}