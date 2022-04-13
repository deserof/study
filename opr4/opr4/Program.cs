using System;
using System.Text;

namespace opr4
{
    internal class Program
    {
        private const double E = 0.01;
        private const int N = 30;
        private const int NumForFib = N - 3;
        private static double _left;
        private static double _right;

        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            Console.WriteLine("начальное граничное значение: ");
            _left = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("конечное граничное значение: ");
            _right = Convert.ToInt16(Console.ReadLine());

            CalcDichotomy(out var xDichotomy, out var dichotomyAnswer);
            Console.WriteLine($"Дихотомия: x: {Math.Round(xDichotomy, 8)} y: {Math.Round(dichotomyAnswer, 8)}");

            CalcFibonacci(out var xMinFib, out var yMinFib);
            Console.WriteLine($"Фибоначи: x: {Math.Round(xMinFib, 8)} y: {Math.Round(yMinFib, 8)}");
        }

        private static void CalcFibonacci(
            out double xMinFib,
            out double yMinFib)
        {
            var aFib = _left;
            var bFib = _right;
            var fbn2 = GetFibonacciWithNumber(N - 2);
            var fbnN = GetFibonacciWithNumber(N);
            var fbn1 = GetFibonacciWithNumber(N - 1);
            var x1Fib = aFib + (bFib - aFib) * ((double)fbn2 / fbnN);
            var x2Fib = aFib + (bFib - aFib) * ((double)fbn1 / fbnN);
            var y1Fib = GetYMinFib(x1Fib);
            var y2Fib = GetYMinFib(x2Fib);

            for (var i = 0; i < NumForFib; i++)
            {
                if (y1Fib <= y2Fib)
                {
                    bFib = x2Fib;
                    x2Fib = x1Fib;
                    y2Fib = y1Fib;
                    x1Fib = aFib + bFib - x2Fib;
                    y1Fib = GetYMinFib(x1Fib);
                }
                else
                {
                    aFib = x1Fib;
                    x1Fib = x2Fib;
                    y1Fib = y2Fib;
                    x2Fib = aFib + bFib - x1Fib;
                    y2Fib = GetYMinFib(x2Fib);
                }
            }

            if (y1Fib < y2Fib)
            {
                bFib = x2Fib;
            }
            else
            {
                aFib = x1Fib;
            }

            x2Fib = x1Fib;
            y2Fib = y1Fib;
            x1Fib = x2Fib - E;
            y1Fib = GetYMinFib(x1Fib);

            if (y1Fib < y2Fib)
            {
                bFib = x2Fib;
            }
            else
            {
                aFib = x1Fib;
            }

            xMinFib = (aFib + bFib) / 2;
            yMinFib = GetYMinFib(xMinFib);
        }

        private static void CalcDichotomy(
            out double xDichotomy,
            out double dichotomyAnswer)
        {
            double an = _left, bn = _right;

            while (bn - an > 2 * E)
            {
                Dichotomy(E, ref an, ref bn);
            }

            xDichotomy = (an + bn) / 2;
            dichotomyAnswer = GetYMinFib(xDichotomy);
        }

        private static void Dichotomy(
            double e,
            ref double an,
            ref double bn)
        {
            var x0 = (an + bn) / 2;
            var x1 = x0 - e / 2;
            var x2 = x0 + e / 2;
            var y1 = GetYMinFib(x1);
            var y2 = GetYMinFib(x2);

            if (y1 > y2)
            {
                an = x2;
            }
            else
            {
                bn = x1;
            }
        }

        private static double GetYMinFib(
            double x)
        {
            //return a * Math.Pow(x, 2) + b * x + c;

            //return 0.22 * Math.Pow(x, 2) - 1.474 * x + 5.79; // [2,7]
            //return 3.75 * Math.Pow(x, 2) + 10.38 * x + 2.18; // [-4, 1]
            return x * Math.Pow(Math.E, x * 8.0); // [-2, 3]
        }

        private static int GetFibonacciWithNumber(int n)
        {
            var fibonacci = 1;
            var fibonacciPast1 = 0;
            var fibonacciPast2 = 1;

            for (var i = 1; i <= n; i++)
            {
                fibonacci = fibonacciPast1 + fibonacciPast2;
                fibonacciPast1 = fibonacciPast2;
                fibonacciPast2 = fibonacci;
            }

            return fibonacci;
        }
    }
}
