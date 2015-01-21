using System;
/*
    Problem 4. Number Comparer

    Write a program that gets two numbers from the console and prints the greater of them.
    Try to implement this without if statements.
 */
class NumberComparer
{
    static void Main()
    {
        Console.Write("Please enter the first number - a: ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("Please enter the second number - b: ");
        double b = double.Parse(Console.ReadLine());
        double difference = a - b;
        Console.Write("The greater number is: ");
        Console.WriteLine(difference >= 0 ? a : b);
    }
}