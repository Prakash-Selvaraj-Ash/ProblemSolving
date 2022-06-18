using System;
namespace Interview.Algorithms
{
    public class CountValleys
    {
        public CountValleys()
        {
        }

        public void Run()
        {
            int steps = 8;
            string path = "UDDDUDUU";

            int currentLevel = 0;
            int valleyTraversed = 0;
            for (int i = 0; i < steps; i++)
            {
                bool isDown = path[i] == 'D';

                currentLevel += (isDown ? -1 : 1);

                if (!isDown && currentLevel == 0) { valleyTraversed++; }

            }
            

            Console.WriteLine(valleyTraversed);
        }
    }
}
