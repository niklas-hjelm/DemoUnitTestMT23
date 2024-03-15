namespace DemoUnitTestMT23.Client.Services.Interfaces;

public interface ICalculator
{
    double Add(params double[] nums);
    double Subtract(params double[] nums);
    double Multiply(params double[] nums);
    double Divide(params double[] nums);
}