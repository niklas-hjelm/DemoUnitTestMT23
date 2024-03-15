namespace DemoUnitTestMT23.Client.Geometry.Interfaces;

public interface ICircle : IShape
{
    double Radius { get; set; }

    double GetDiameter();
}