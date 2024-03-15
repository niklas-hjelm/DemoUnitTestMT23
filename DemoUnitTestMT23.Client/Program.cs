// See https://aka.ms/new-console-template for more information

using DemoUnitTestMT23.Client.Geometry;
using DemoUnitTestMT23.Client.Geometry.Interfaces;
using DemoUnitTestMT23.Client.Services;
using DemoUnitTestMT23.Client.Services.Interfaces;

Console.WriteLine("Welcome to Geometry-assistant!");
int selectedForm = 0;
while (true)
{
    Console.WriteLine("Please chose a geometric form!");
    Console.WriteLine("1. Circle");
    Console.WriteLine("2. Rectangle");
    Console.WriteLine("3. Right Angle Triangle");
    Console.WriteLine("Input selection:");
    var selection = Console.ReadLine();

    if (int.TryParse(selection, out selectedForm) && selectedForm > 0 || selectedForm < 4)
    {
        break;
    }

    Console.WriteLine("Please provide a choice between 1 and 3.");
}

Console.Clear();
ICalculator calculator = new Calculator();
IShape form = null;
string userInput = string.Empty;
switch (selectedForm)
{
    case 1:
        Console.WriteLine("Input the radius of your circle:");
        userInput = Console.ReadLine();
        if (double.TryParse(userInput, out double radius))
        {
            form = new Circle(calculator) {Radius = radius};
        }

        break;
    case 2:
        Console.WriteLine("Input the height of your rectangle:");
        userInput = Console.ReadLine();
        double heightR = double.Parse(userInput);
        Console.WriteLine("Input the width of your rectangle:");
        userInput = Console.ReadLine();
        double width = double.Parse(userInput);
        form = new Rectangle(calculator) {Height = heightR, Width = width};
        break;
    case 3:
        Console.WriteLine("Input the height of your triangle:");
        userInput = Console.ReadLine();
        double heightT = double.Parse(userInput);
        Console.WriteLine("Input the base of your triangle:");
        userInput = Console.ReadLine();
        double baseT = double.Parse(userInput);
        Console.WriteLine("Input the hypotenuse of your triangle:");
        userInput = Console.ReadLine();
        double hypotenuse = double.Parse(userInput);
        form = new RightAngleTriangle(calculator) { Hypotenuse = hypotenuse, Base = baseT, Height = heightT};
        break;
    default:
        Environment.Exit(0);
        break;
}

Console.WriteLine("The Area of your form:");
Console.WriteLine(form.GetArea());
Console.WriteLine("The Circomference of your form:");
Console.WriteLine(form.GetCircumference());