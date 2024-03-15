namespace DemoUnitTestMT23.Client.Geometry.Interfaces;

public interface IRectangle : IShape
{
    double Height { get; set; }
    double Width { get; set; }
}