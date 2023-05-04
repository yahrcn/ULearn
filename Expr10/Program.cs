using System;

namespace Expr10
{
    class Program
    {
        // Найти сумму всех положительных чисел меньше 1000 кратных 3 или 5.
        const int MaxNumberDivisibleByThree = 999;
        const int MaxNumberDivisibleByFive = 995;
        
        static void Main()
        {
            int answer = CalculateSumDivisibleByThree(MaxNumberDivisibleByThree, 0) +
                         CalculateSumDivisibleByFive(MaxNumberDivisibleByFive, 0);
            Console.WriteLine("Рекурсией: " + answer);
            Console.WriteLine("Циклом: " + CalculateSumTest());
        }

        static int CalculateSumDivisibleByThree(int maxNumber, int sum)
        {
            if (maxNumber < 0) return sum;
            sum += maxNumber;
            return CalculateSumDivisibleByThree(maxNumber - 3, sum);
        }

        static int CalculateSumDivisibleByFive(int maxNumber, int sum)
        {
            if (maxNumber < 0) return sum;
            sum += maxNumber;
            return CalculateSumDivisibleByFive(maxNumber - 5, sum);
        }

        static int CalculateSumTest()
        {
            int sum = 0;
            for (int i = 0; i < 1000; i++)
            {
                if (i % 3 == 0) sum += i;
                if (i % 5 == 0) sum += i;
            }
            return sum;
        }
    }
}