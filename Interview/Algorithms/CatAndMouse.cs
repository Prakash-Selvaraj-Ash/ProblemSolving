using System;
namespace Interview.Algorithms
{
    public class CatAndMouse
    {
        public CatAndMouse()
        {
        }

        public string Run()
        {
            int x = 1;
            int y = 2;
            int z = 3;

            int aTravel = Math.Abs(x - z);
            int bTravel = Math.Abs(y - z);

            if(aTravel == bTravel)
            {
                Console.Write("Mouse C");
                return "Mouse C";
            }

            bool isMouseA = aTravel < bTravel;
            string result = isMouseA ? "A" : "B";

            Console.WriteLine(result);
            return result;
        }
    }
}
