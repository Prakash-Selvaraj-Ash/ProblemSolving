using System;
using System.Linq;

namespace Interview.Algorithms
{
    public class NonRepeatingNumber
    {
        public NonRepeatingNumber()
        {
        }

        public void Run()
        {
            int[] arr = new[] { 2, 4, 7, 9, 2, 4 };

            int xorResult = arr.Aggregate((prev, next) => prev ^ next);
        }
    }
}
