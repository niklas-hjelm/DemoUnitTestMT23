using DemoUnitTestMT23.Client.Geometry.Interfaces;
using DemoUnitTestMT23.Client.Services.Interfaces;

namespace DemoUnitTestMT23.Client.Geometry;

public class Rectangle(ICalculator calculator) : IRectangle
{
    public double Height { get; set; }
    public double Width { get; set; }

    public double GetArea()
    {
        return calculator.Multiply(Height, Width);
    }

    public double GetCircumference()
    {
        return calculator
            .Add(
                calculator.Multiply(2, Height),
                calculator.Multiply(2, Width)
            );
    }
}