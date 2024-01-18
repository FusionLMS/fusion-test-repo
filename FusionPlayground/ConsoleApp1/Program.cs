using System.Diagnostics.CodeAnalysis;

namespace ConsoleApp1;

[ExcludeFromCodeCoverage]
internal static class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine(SimpleCalculator.Sum(5, 8));
    }
}