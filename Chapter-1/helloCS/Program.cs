using System;
namespace helloCS;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello C#");
        string name = typeof(Program).Namespace ?? "None!";
        Console.WriteLine($"Namespace: {name}");
    }
}