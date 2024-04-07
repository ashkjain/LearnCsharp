using System;
namespace Numbers;

class Program
{
    static void Main(string[] args)
    {
        // Unassigned integer holds only positive whole number or 0
        uint naturalNumber = 23;
        // An integer holds whole numbers negative and positive or 0
        int integerNumber = -23;
        // Float holds floating point number with single precision and F or f suffix is required to compile
        float realNumber = 2.3f;
        // Double holds double precision floating point number, and doesn't need suffix to compile because it is default for number with floating point number.
        double anotherRealNumber = 2.3;
        Console.WriteLine($"uint: {naturalNumber}, int: {integerNumber}, float: {realNumber}, double: {anotherRealNumber}");
        //
        int decimalNotation = 2_000_000;
        Console.WriteLine($"Decimal Notation: {decimalNotation}");
    }
}