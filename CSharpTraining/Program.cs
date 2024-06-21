// See https://aka.ms/new-console-template for more information

// Console.WriteLine("Enter a string to reverse!");
//
// var input = Console.ReadLine();
//
// Console.WriteLine(input.ReverseString().ToUpper().ReverseString());

//test quadratic method

// Declare variables a, b, c, and x

using System.Diagnostics;

Stopwatch stopwatch = new Stopwatch();

stopwatch.Start();

double a = 15;
double b = 3;
double c = 2;
double x = 4;

// Call the QuadraticFunction method from the StringFunctions class and pass in the variables a, b, c, and x
Console.WriteLine(StringFunctions.QuadraticFunction(a, b, c, x));

stopwatch.Stop();

Console.WriteLine($"Time taken: {stopwatch.Elapsed}");

public static class StringFunctions
{
    public static string ReverseString(this string? input)
    {
        var chars = input?.ToCharArray();
        if (chars == null) return input ?? string.Empty;
        Array.Reverse(chars);
        return new string(chars);
    }

    // generate a method change a string to uppercase

    public static string ToUpper(this string? input)
    {
        return input?.ToUpper() ?? string.Empty;
    }

    public static float GetCircumference(this float radius)
    {
        const double pi = 3.14;
        double circumference = 2 * pi * radius;
        return (float)circumference;
    }


    public static float GetArea(this float radius)
    {
        const double pi = 3.14;
        double area = pi * radius * radius;
        return (float)area;
    }
    
    public static double QuadraticFunction(double a, double b, double c, double x)
    {
        return a * x * x + b * x + c;
    }
}