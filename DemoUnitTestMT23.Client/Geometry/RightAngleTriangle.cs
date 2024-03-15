using DemoUnitTestMT23.Client.Geometry.Interfaces;
using DemoUnitTestMT23.Client.Services.Interfaces;

namespace DemoUnitTestMT23.Client.Geometry;

public class RightAngleTriangle(ICalculator calculator) : IRightAngleTriangle
{
    public double Base { get; set; }
    public double Height { get; set; }
    public double Hypotenuse { get; set; }
    
    public double GetArea()
    {
        return calculator.Divide(calculator.Multiply(Base,Height), 2);
    }

    public double GetCircumference()
    {
        return calculator.Add(Base, Height, Hypotenuse);
    }

}