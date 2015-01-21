using System;
/*
    Problem 6. Quadratic Equation

    Write a program that reads the coefficients a, b and c of a quadratic equation ax2 + bx + c = 0 and solves it (prints its real roots).
 */
class QuadraticEquation
{
    static void Main()
    {
        Console.Write("Please enter the coefficient a: ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("Please enter the coefficient b: ");
        double b = double.Parse(Console.ReadLine());
        Console.Write("Please enter the coefficient c: ");
        double c = double.Parse(Console.ReadLine());
        Console.WriteLine("{0}x*x + {1}*x + {2} = 0", a, b, c);

        if (a == 0)
        {
            if (b == 0)
            {
                if (c == 0)
                    Console.WriteLine("Every x could be root.");
                else
                    Console.WriteLine("The are no roots.");
            }
            else
                Console.WriteLine("x = {0}", ((-c) / b));
        }

        else 
        {
            double d = b * b - (4 * a * c);
            if (d < 0)
                Console.WriteLine("There are no real roots.");
            if (d == 0)
                Console.WriteLine("x1 = x2 = {0}", ((-b) / (2 * a)));
            if (d > 0)
            {
                double x1 = (-b - Math.Sqrt(b * b - (4 * a * c))) / (2 * a);
                double x2 = (-b + Math.Sqrt(b * b - (4 * a * c))) / (2 * a);
                Console.WriteLine("x1 = {0}, x2 = {1}", x1, x2);
            }

        }
    }
}
