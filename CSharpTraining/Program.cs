using Bogus;
using static System.Console;

var faker = new Faker();
var randomStrings = Enumerable.Range(0, 100).Select(_ => faker.Random.Word()).ToList();

if (randomStrings.Exists(str => str.Length > 10))
{
     WriteLine("There is a string with more than 10 characters");
     int count = randomStrings.Count(str => str.Length > 10);
     WriteLine($"There are {count} strings with more than 10 characters.");
}

var additionalStrings = Enumerable.Range(0, 100).Select(_ => faker.Random.Word()).ToList();
randomStrings.AddRange(additionalStrings);

WriteLine($"The list now contains {randomStrings.Count} strings.");

WriteLine(randomStrings[0].ReverseString().ToUpper());

public static class StringFunctions
{
    public static string ReverseString(this string? input)
    {
        var chars = input?.ToCharArray();
        if (chars == null) return input ?? string.Empty;
        Array.Reverse(chars);
        return new string(chars);
    }
    
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
        var area = pi * radius * radius;
        return (float)area;
    }
    
    public static double QuadraticFunction(double a, double b, double c, double x)
    {
        return a * x * x + b * x + c;
    }
}