using System;
/*
    Problem 1. Sum of 3 Numbers

    Write a program that reads 3 real numbers from the console and prints their sum.
 */
class SumOf3Numbers
{
    static void Main()
    {
        Console.Write("Please enter the first real number - a: ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("Please enter the second real number - b: ");
        double b = double.Parse(Console.ReadLine());
        Console.Write("Please enter the third real number - c: ");
        double c = double.Parse(Console.ReadLine());

        double result = a + b + c;
        Console.WriteLine("{0} + {1} + {2} = {3}", a, b, c, result);
    }
}
