using DemoUnitTestMT23.Client.Services.Interfaces;

namespace DemoUnitTestMT23.Client.Services;

public class Calculator : ICalculator
{
    public double Add(params double[] nums)
    {
        return nums.Sum();
    }

    public double Subtract(params double[] nums)
    {
        double result = 0;
        foreach (var num in nums)
        {
            result -= num;
        }

        return result;
    }

    public double Multiply(params double[] nums)
    {
        double result = nums[0];
        for (int i = 1; i < nums.Length; i++)
        {
            result *= nums[i];
        }

        return result;
    }

    public double Divide(params double[] nums)
    {
        double result = nums[0];
        for (int i = 1; i < nums.Length; i++)
        {
            result /= nums[i];
        }

        return result;
    }
}