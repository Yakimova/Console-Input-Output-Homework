using System;
/*
    Problem 9. Sum of n Numbers

    Write a program that enters a number n and after that enters more n numbers and calculates and prints their sum. Note: You may need to use a for-loop.
 */
class SumOfnNumbers
{
    static void Main()
    {
        Console.Write("Please enter the integer number n of the numbers: ");
        int n = int.Parse(Console.ReadLine());
        double sum = 0;
        for (int i = 0; i < n; i++)
        {
            double number = double.Parse(Console.ReadLine());
            sum += number;
        }
        Console.WriteLine("The sum of the numbers is {0} ", sum);
    }
}