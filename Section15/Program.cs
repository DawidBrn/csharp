using System;
using System.Collections.Generic;
using System.Linq;

namespace Section15
{
    class Program
    {

        //how many option there is to pick 3 mugs out of 7 of them, n options from k objects
        static int nCombinationOfKOption(int n, int k)
        {


            if (k == 0 || k == n) return 1;
            else
            {
                return nCombinationOfKOption(n - 1, k) + nCombinationOfKOption(n - 1, k - 1);
            }
        }
        // shortest path - a* algorithm find the shortest path from a to b , shortest path alogrithm uses scores to settle "cost" of a certain point with
        // with regards to starting point then calculetes to evaluate lowest "cost" sum which dedicates in fact fastest way from A to B
        public class Location
        {
            public int X;
            public int Y;
            public int Score1;
            public int Score2;
            public int Score3;
            public Location Parent;
        }
        static List<Location> GetMovableAdjacentSpots(int x, int y, string[] map)
        {
            List<Location> proposeLocations = new List<Location>()
            {
                new Location { X = x, Y = y - 1 },
                new Location { X = x, Y = y + 1 },
                new Location { X = x - 1, Y = y },
                new Location { X = x + 1, Y = y }
            };
            //returns list of proposedLocations based on given starting point left,right,up, down as long as
            // they are either empty space or target location
            return proposeLocations.Where(l => map[l.Y][l.X] == ' ' || map[l.Y][l.X] == 'B').ToList();
        }
        static int ComputeSpotHeuristic(int x, int y, int targetX, int targetY)
        {
            return Math.Abs(targetX - x) + Math.Abs(targetY - y);
        }
        static void shortestPath()
        {
            Console.Clear();

            string[] map = new string[]
            {
                "+----------------+",
                "|A               |",
                "|XXXXXX          |",
                "|        XXXXXX X|",
                "|                |",
                "|         XXXXXXX|",
                "|               B|",
                "+----------------+"
            };
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            foreach (var line in map) Console.WriteLine(line); // drawing board
            //iniciating current loc , passive start location of A and location of B, creating openlist which contains
            // open spaceces and closedlist containing spaces that already we've been to
            Location current = null; 
            Location start = new Location { X = 1, Y = 1 };
            Location target = new Location { X = 16, Y = 6 };
            List<Location> openList = new List<Location>();
            List<Location> closedList = new List<Location>();
            int spot = 0;

            openList.Add(start);
            //while there is any clear spot left 
            while (openList.Count > 0)
            {
                //min value of reference 
                int min = openList.Min(l => l.Score1);
                current = openList.First(l => l.Score1 == min);

                closedList.Add(current);
                Console.SetCursorPosition(current.X, current.Y);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write(".");
                Console.SetCursorPosition(current.X, current.Y);

                System.Threading.Thread.Sleep(1000);
                openList.Remove(current);
                if (closedList.FirstOrDefault(l => l.X == target.X && l.Y == target.Y) != null)
                    break;

                List<Location> adjacentSquares = GetMovableAdjacentSpots(current.X, current.Y, map);
                spot++;
                //checking adjacentsqueres in addicion to computing score for the path
                foreach (Location adjacentSquere in adjacentSquares)
                {
                    //if we visted it continue
                    if (closedList.FirstOrDefault(l => l.X == adjacentSquere.X && l.Y == adjacentSquere.Y) != null)
                    {
                        continue;
                    }
                    //if spot is open calculete
                    if (openList.FirstOrDefault(l => l.X == adjacentSquere.X && l.Y == adjacentSquere.Y) == null)
                    {
                        adjacentSquere.Score2 = spot;
                        adjacentSquere.Score3 = ComputeSpotHeuristic(adjacentSquere.X, adjacentSquere.Y, target.X, target.Y);
                        adjacentSquere.Score1 = adjacentSquere.Score2 + adjacentSquere.Score3;
                        adjacentSquere.Parent = current;
                        openList.Insert(0, adjacentSquere);

                    }
                    //if spot was open but not chosen
                    else
                    {
                        if (spot + adjacentSquere.Score3 < adjacentSquere.Score1)
                        {
                            adjacentSquere.Score2 = spot;
                            adjacentSquere.Score1 = adjacentSquere.Score2 + adjacentSquere.Score3;
                            adjacentSquere.Parent = current;
                        }
                    }
                }
            }
            while (current != null)
            {
                Console.SetCursorPosition(current.X, current.Y);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write('o');
                Console.SetCursorPosition(current.X, current.Y);
                current = current.Parent;
                System.Threading.Thread.Sleep(1000);
            }
            Console.ReadLine();
        }


        //tortoise and hare cycle detection algorithm for linked lists
        private static void Display(LinkedList<int> list)
        {
            
            foreach (int x in list)
            {
                Console.Write(x + " ");
            }
            Console.WriteLine();
            Console.WriteLine();
        }
        public static bool FloydCycleDetection<T>(LinkedList<T> list)
        {
            if (list.Count <= 2)
                return false;
            LinkedListNode<T> tortoise = list.First.Next;
            LinkedListNode<T> hare = list.First.Next.Next;

            while(tortoise != null && hare != null)
            {
                if(tortoise == hare)
                    return true;
                if (hare.Next != null)
                    hare = hare.Next.Next;
                tortoise = tortoise.Next;

            }
            return false;
        }
        
        

        static void Main(string[] args)
        {
            //Console.WriteLine("There is " + nCombinationOfKOption(7, 3).ToString() + " combination to choose 3 out of 7 mugs");
            //shortestPath();

            

        }
        
    }
}
