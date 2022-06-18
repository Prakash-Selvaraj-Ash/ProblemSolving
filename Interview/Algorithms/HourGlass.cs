using System;
using System.Linq;

namespace Interview.Algorithms
{
    public class HourGlass
    {
        public HourGlass()
        {
        }

        public void Run()
        {
            int[][] arr = new int[6][];
            var input = @"1 1 1 0 0 0
0 1 0 0 0 0
1 1 1 0 0 0
0 0 2 4 4 0
0 0 0 2 0 0
0 0 1 2 4 0";
            var splittedItems = input.Split(Environment.NewLine);
            for (int i = 0; i < splittedItems.Length; i++)
            {
                arr[i] = Array.ConvertAll(splittedItems[i].Split(' '), arrTemp => Convert.ToInt32(arrTemp));
            }
        }
    }
}
