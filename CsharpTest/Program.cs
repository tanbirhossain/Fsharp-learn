using System;
using System.Collections.Generic;

namespace CsharpTest
{
    class Program
    {
        // Basic C# functional programming
        static void Main(string[] args)
        {
            Console.WriteLine(f2(f1(4, 5)));
            Console.WriteLine(PrintList());
        }

        static Func<double, double, double> f1 = sqr;
        //static Func<double, double, double> f1 = (x, y) => sqr(x);
        static Func<double, double> f2 = x => x * x;

        //static double sqr(double x)
        //    => x * x;
        static double sqr(double x, double y)
            => x * x;

        static IEnumerable<string> PrintList()
        {
            for (int i = 0; i < 50; i++)
            {
                yield return i.ToString();
            }
            yield return null;
        }
    }

}
