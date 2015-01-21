using System;
/*
    Problem 3. Circle Perimeter and Area

    Write a program that reads the radius r of a circle and prints its perimeter and area formatted with 2 digits after the decimal point.
 */
class CirclePerimeterAndArea
{
    static void Main()
    {
        Console.Write("Please enter the radius r of the circle: ");
        double r = double.Parse(Console.ReadLine());

        double perimeter = 2 * r * Math.PI;
        Console.WriteLine("The perimeter is {0:F2}", perimeter);

        double area = r * r * Math.PI;
        Console.WriteLine("The area is {0:F2}", area);
    }
}
