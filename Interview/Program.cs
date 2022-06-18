using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Threading;
using Interview.LinkedListProgram;
using Interview.CousinProblem;
using Interview.Algorithms;
using Interview.Algorithms.BinarySearchTree;

namespace Interview 
{
    public delegate void DelEventHandler(String s);
    class Program
    {
        static void Main(string[] args)
        {

            var bst = new Median();
            bst.Run();
            //var add = new DelEventHandler(USA);
            //add("Chumma");
            //Update();
            //Console.ReadLine();
            //List<List<int>> axes = new List<List<int>>();
            

            //var itemArray = new[] {
            //    "1 1 1 0 0 0 1 0 0 1",
            //    "0 0 0 0 0 1 1 1 0 1",
            //    "0 0 1 1 0 -1 0 0 1 0",
            //    "0 1 0 1 1 1 1 0 1 1",
            //    "0 1 1 0 0 0 0 0 1 -1",
            //    "1 0 0 0 1 -1 0 0 1 1",
            //    "0 1 1 0 0 0 0 0 0 1",
            //    "1 0 -1 1 -1 0 0 0 1 0",
            //    "1 1 0 0 1 1 0 0 1 0",
            //    "1 1 1 0 1 1 1 0 0 1"};

            //for (int i = 0; i < n; i++)
            //{
            //    var outList = new List<int>();
            //    for (int j = 0; j < m; j++)
            //    {
            //        outList.Add(Convert.ToInt32(Console.ReadLine()));
            //    }
            //    axes.Add(outList);
            //}

            //foreach(var item in itemArray)
            //{
            //    var outList = item.Split(" ").Select(i => Convert.ToInt32(i)).ToList();
                
            //    axes.Add(outList);
            //}

            //int n = axes.Count;
            //int m = axes.First().Count;

            //bool canCollect = axes[n - 1][m - 1] != -1;
            //if (!canCollect) { return; }
            //List<Axis> travelledAxis = new List<Axis>();
            
            //int startXIndex = 0; int startYIndex = 0;



            //while (true)
            //{
            //    int result = CanTravel(n, m, ref startXIndex, ref startYIndex, travelledAxis, axes);
            //    if(result == 0)
            //    {
            //        break;
            //    }
            //}

            //int collectedTravels = travelledAxis.Select(axis => axes[axis.X][axis.Y]).Where(i => i == 1).Count();

            //Console.WriteLine(collectedTravels);
            Console.ReadLine();
        }


        private static int CanTravel(int n, int m, ref int startXIndex, ref int startYIndex, List<Axis> travelledAxis, List<List<int>> points)
        {
            bool hasReachedAirport = travelledAxis.Any(axis => axis.X == n - 1 && axis.Y == m - 1);
            bool hasReachedStartPoint = travelledAxis.Any(axis => axis.X == 0 && axis.Y == 0);
            if (!hasReachedAirport)
            {
                int siblingRightIndex = startXIndex == n - 1 ? -1 : startXIndex + 1;
                int siblingDownIndex = startYIndex == m - 1 ? -1 : startYIndex + 1;

                bool canMoveRight = siblingRightIndex != -1 && points[siblingRightIndex][startYIndex] != -1 ;
                bool canMoveDown = siblingDownIndex != -1 && points[startXIndex][siblingDownIndex] != -1;

                if (canMoveRight)
                {
                    startXIndex = siblingRightIndex;

                }
                else
                {
                    startYIndex = siblingDownIndex;
                }

                if (CanAdd(startXIndex, startYIndex, travelledAxis))
                {
                    travelledAxis.Add(new Axis { X = startXIndex, Y = startYIndex });
                }
                return 1;
            }
            else if(!hasReachedStartPoint)
            {
                int siblingLeftIndex = startXIndex == 0 ? -1 : startXIndex - 1;
                int siblingUpIndex = startYIndex == 0 ? -1 : startYIndex - 1;

                bool canMoveLeft = siblingLeftIndex != -1 && points[siblingLeftIndex][startYIndex] != -1;
                bool canMoveUp = siblingUpIndex != -1 && points[startXIndex][siblingUpIndex] != -1;

                if (canMoveLeft)
                {
                    startXIndex = siblingLeftIndex;

                }
                else
                {
                    startYIndex = siblingUpIndex;
                }

                if (CanAdd(startXIndex, startYIndex, travelledAxis))
                {
                    travelledAxis.Add(new Axis { X = startXIndex, Y = startYIndex });
                }
                return 1;
            }

            return 0;
        }

        private static bool CanAdd(int x, int y, List<Axis> axes)
        {
            return !axes.Any(axis => axis.X == x && axis.Y == y);
        }
        
        private class Axis
        {
            public int X { get; set; }
            public int Y { get; set; }
        }
        private static void Update()
        {
            //add("Chumma");
        }

        static void USA(String obj)
        {
            Console.WriteLine(obj);
        }

        static void India()
        {
            Console.WriteLine("India");
        }

        static void England()
        {
            Console.WriteLine("England");
        }
    }
}
