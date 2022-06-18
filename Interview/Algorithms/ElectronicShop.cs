using System;
namespace Interview.Algorithms
{
    public class ElectronicShop
    {
        public ElectronicShop()
        {
        }

        public void Run()
        {
            int[] keyboards = new[] { 3, 1};
            int[] drives = new[] { 5, 2, 8 };
            int b = 10;
            int calculatedPrice = -1;
            for (int i = 0; i < keyboards.Length; i++)
            {
                for (int j = 0; j < drives.Length; j++)
                {
                    var price = keyboards[i] + drives[j];
                    if(calculatedPrice < price && price <= b) { calculatedPrice = price; }
                }
            }

            Console.Write(calculatedPrice);
        }
    }
}
