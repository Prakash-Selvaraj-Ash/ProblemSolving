using System;
namespace Interview.Algorithms
{
    public class Median
    {
        public Median()
        {
        }
        public void Run()
        {

            double d = 5;
            Console.WriteLine(Math.Round(d, MidpointRounding.ToEven));
            Console.WriteLine(Math.Round(d, MidpointRounding.AwayFromZero));
            Console.WriteLine(Math.Round(d, MidpointRounding.ToNegativeInfinity));
            Console.WriteLine(Math.Round(d, MidpointRounding.ToPositiveInfinity));
            Console.WriteLine(Math.Round(d, MidpointRounding.ToZero));

            
        }
    }
}
