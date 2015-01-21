using System;
/*
    Problem 7. Sum of 5 Numbers

    Write a program that enters 5 numbers (given in a single line, separated by a space), calculates and prints their sum.
 */
class SumOf5Numbers
{
    static void Main()
    {
        Console.WriteLine("PLease enter the 5 numbers, separated by space: ");
        string numbers = Console.ReadLine();
        string[] separateNumbers = numbers.Split(' ');
        double[] clearNumbers = new double [separateNumbers.Length];
        double sum = 0;
        for (int i = 0; i < separateNumbers.Length; i++)
        {
            clearNumbers[i] = double.Parse(separateNumbers[i]);
            sum += clearNumbers[i];
        }
        Console.WriteLine("The sum is {0}", sum);
    }
}