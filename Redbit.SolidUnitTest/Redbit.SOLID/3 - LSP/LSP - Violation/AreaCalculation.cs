using System;
using System.Collections.Generic;
using System.Text;

namespace Redbit.SOLID.LSP.Violation
{
    public class AreaCalculation
    {
        private static void GetRectangleArea(Rectangle ret)
        {
            Console.Clear();
            Console.WriteLine("### Rectangle area calculation using a square object ###");
            Console.WriteLine("Enter the HEIGHT:");
            ret.Height = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the WIDTH:");
            ret.Width = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"Height: {ret.Height} * {ret.Width}");
            Console.WriteLine();
            Console.WriteLine($"Rectangle area: {ret.Area}");
            Console.ReadKey();
        }

        public static void Calculate()
        {
            var _square = new Square()
            {
                Height = 10,
                Width = 5
            };

            GetRectangleArea(_square);
        }
    }
}
