using System;
/*
    Problem 11.* Numbers in Interval Dividable by Given Number

    Write a program that reads two positive integer numbers and prints how many numbers p exist between them such that the reminder of the division by 5 is 0.
 */
class NumbersInIntervalDividableByGivenNumber
{
    static void Main()
    {
        Console.Write("Please enter the first possitive integer number: ");
        int start = int.Parse(Console.ReadLine());
        Console.Write("Please enter the second possitive integer number: ");
        int end = int.Parse(Console.ReadLine());
        int p = 0;
        for (int i = start; i <= end; i++)
        {
            // counting the numbers, which are dividable by 5
            if (i % 5 == 0)
            {
                p++;
            }
        }
        Console.WriteLine("The numbers are: " + p);

        // if there are any of those numbers, let's print them
        if (p >= 1)
        {
            Console.Write("And they are: ");
            int[] numbers = new int[p];
            p = 0;
            for (int i = start; i <= end; i++)
            {
                if (i % 5 == 0)
                {
                    numbers[p] = i;
                    p++;
                }
            }

            for (int i = 0; i < (p - 1); i++)
                Console.Write(numbers[i] + ", ");
            Console.WriteLine(numbers[p - 1]);
        }
    }
}