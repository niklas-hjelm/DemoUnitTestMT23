namespace DemoUnitTestMT23.Client.Geometry.Interfaces;

public interface IRightAngleTriangle : IShape
{
    double Base { get; set; }
    double Height { get; set; }
    double Hypotenuse { get; set; }
}