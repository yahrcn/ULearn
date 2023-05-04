using System;

namespace Expr11
{
    class Program
    {
        // Дано время в часах и минутах. Найти угол от часовой к минутной стрелке на обычных часах.
        static void Main()
        {
            Console.WriteLine(CalculateAngle(12, 0));
            Console.WriteLine(CalculateAngle(15, 15));
            Console.WriteLine(CalculateAngle(16, 30));
            Console.WriteLine(CalculateAngle(18, 15));
            Console.WriteLine(CalculateAngle(13, 11));
            Console.WriteLine(CalculateAngle(16, 55));
            Console.WriteLine(CalculateAngle(23, 59));
            Console.WriteLine(CalculateAngle(12, 1));
        }

        static double CalculateAngle(int hours, int minutes)
        {
            var returnValue = Math.Abs((hours % 12 + (minutes / 60.0)) * 30 - minutes * 6.0);
            return returnValue > 180 ? 360 - returnValue : returnValue;
        }
    }
}