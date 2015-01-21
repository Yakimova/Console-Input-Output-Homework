using System;
/*
    Problem 10. Fibonacci Numbers

    Write a program that reads a number n and prints on the console the first n members of the Fibonacci sequence (at a single line, separated by comma and space - ,) : 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, ….
 */
class FibonacciNumbers
{
    static void Main()
    {
        Console.Write("Please enter the number n: ");
        int n = int.Parse(Console.ReadLine());
        long[] fibonacci = new long[n];
        if (n < 2)
            Console.WriteLine("0");
        else
        {
            fibonacci[0] = 0;
            fibonacci[1] = 1;
            for (int i = 2; i < n; i++)
                fibonacci[i] = fibonacci[i - 2] + fibonacci[i - 1];

            for (int i = 0; i < n - 1; i++)
                Console.Write(fibonacci[i] + ", ");
            Console.WriteLine(fibonacci[n - 1]);
        }
    }
}