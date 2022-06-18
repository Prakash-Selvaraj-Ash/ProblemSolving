using System;
namespace Interview.Algorithms
{
    public class DayOfTheProgrammer
    {
        public DayOfTheProgrammer()
        {
        }

        public void Run()
        {
            int year = 2400;

            bool isGR = year >= 1919;

            bool isTransitionYear = year == 1918;
            bool isLeapYear = year % 4 == 0;

            if (isGR)
            {
                isLeapYear = year % 400 == 0 || (year % 4 == 0 && year % 100 != 0);
            }

            int daysToMinus = 243 + (isLeapYear ? 1 : 0);
            Console.WriteLine(daysToMinus);
            var result = 256 - daysToMinus + (isTransitionYear ? 13 : 0);


            var date = $"{result}.09.{year}";

            Console.Write(date);

        }
    }
}
