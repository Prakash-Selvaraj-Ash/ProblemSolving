using System;
using System.Collections.Generic;
using System.Linq;

namespace Interview.Algorithms
{
    public class BillDivision
    {
        public BillDivision()
        {
            
        }

        public void Run()
        {
            List<int> bill = new[] { 3, 10, 2, 9 }.ToList();
            int k = 1;
            int b = 12;

            int sum = 0;
            for (int i = 0; i < bill.Count; i++)
            {
                if(i == k) { continue; }
                sum += bill[i];
            }
            var actualBill = sum / 2;

            var result = b == actualBill ? "Bon Appetit" : (b - actualBill).ToString();

            Console.WriteLine(result);
        }
    }
}
