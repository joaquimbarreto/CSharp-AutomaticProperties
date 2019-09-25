using System;
using System.Collections.Generic;
using System.Text;

namespace AutomaticProperties
{
    class Program
    {

        static void doWork()
        {
            Polygon square = new Polygon();
            Polygon triangle = new Polygon { NumSides = 3 };
            Polygon pentagon = new Polygon { SideLength = 15.5, NumSides = 5 };

            Console.WriteLine($"Squares: {square.NumSides}");
            Console.WriteLine($"Triangles: {triangle.NumSides}");
            Console.WriteLine($"Pentagon: {pentagon.NumSides} with side {pentagon.NumSides}");
        }

        static void Main(string[] args)
        {
            try
            {
                doWork();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
