// See https://aka.ms/new-console-template for more information

Console.WriteLine("Enter a string to reverse!");

var input = Console.ReadLine();

Console.WriteLine(input.ReverseString().ToUpper().ReverseString());


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
}