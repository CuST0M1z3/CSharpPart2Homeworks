using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Write methods that calculate the surface of a triangle by given:
Side and an altitude to it; Three sides; Two sides and an angle between them. Use System.Math.
 */

class SurfaceOfTriangle
{
    static void Main()
    {
        Console.Write("Enter altitude: ");
        double altitude = double.Parse(Console.ReadLine());
        Console.Write("Enter side a: ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("Enter side b: ");
        double b = double.Parse(Console.ReadLine());
        Console.Write("Enter side c: ");
        double c = double.Parse(Console.ReadLine());
        Console.Write("Enter angle: ");
        double angle = double.Parse(Console.ReadLine());

        GeometricSurface(altitude, a);
        TrigonometryFunction(a, b, angle);
        HeronFormula(a, b, c);

    }

    static void GeometricSurface(double altitude, double side)
    {
        double surface = (side * altitude) / 2;

        Console.WriteLine("Geometric surface is: " + surface);
    }

    static void TrigonometryFunction(double a, double b, double angle)
    {
        double surface = (a * b * (Math.Round(Math.Sin(angle)))) / 2;

        Console.WriteLine("Trigonometry surface is: " + surface);
    }

    static void HeronFormula(double a, double b, double c)
    {
        double perimeter = a + b + c;
        double surface = Math.Sqrt(perimeter * (perimeter - a) * (perimeter - b) * (perimeter - c));

        Console.WriteLine("Heron surface is : " + surface);
    }
}

