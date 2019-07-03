using System;
using System.Collections.Generic;

namespace CsharpTest
{

    public interface ILogger
    {
        void Log(string info);
        virtual void LogInfo(string typeofInformation, string info)
              => Console.Write(typeofInformation + " " + info);

    }

    public class TextLogger : ILogger
    {

        public void LogInfo(string typeofInformation, string info)
          => Console.Write("Test class " + typeofInformation + " " + info);
        public void Log(string info)
            => Console.Write("In base Logger");
    }


    class Program
    {



        // Basic C# functional programming
        static void Main(string[] args)
        {

            ILogger _logger = new TextLogger();
            //_logger.Log("info");
            _logger.LogInfo("onek type", "Prochur info");

            //Console.WriteLine(f2(f1(4, 5)));
            //Console.WriteLine(PrintList());
        }
        #region Function Demo

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
        #endregion
    }

}
