using System;

namespace _1_Datatype;

public class Logic
{
  static void Main(string[] args)
  {
    // User input of get value from console
    Console.Write("Enter a value: ");
    var getValue = Console.ReadLine();

    // Get the type of the value entered by the user and print it to the console
    switch (getValue)
    {
      case string s when int.TryParse(s, out _):
        Console.WriteLine($"Value: {s}, Type: {typeof(int)}");
        break;
      case string s when double.TryParse(s, out _):
        Console.WriteLine($"Value: {s}, Type: {typeof(double)}");
        break;
      case string s when float.TryParse(s, out _):
        Console.WriteLine($"Value: {s}, Type: {typeof(float)}");
        break;
      case string s when bool.TryParse(s, out _):
        Console.WriteLine($"Value: {s}, Type: {typeof(bool)}");
        break;
      case "Help":
        Console.WriteLine($"""
        Datatypes:
        - int    Length : {int.MinValue} - {int.MaxValue}
        - double Length : {double.MinValue} - {double.MaxValue}
        - float  Length : {float.MinValue} - {float.MaxValue}
        - bool   Length : {bool.FalseString} - {bool.TrueString}
        """);
        break;
      default:
        Console.WriteLine($"Value: {getValue}, Type: {typeof(string)}");
        break;
    }
  }
}