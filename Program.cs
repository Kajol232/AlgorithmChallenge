using System;

namespace Challenge1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(ValidSubstring.CheckLongest("(()"));
            /* int[][] routes = { 
                 new int[] {1, 2, 7 },
                 new int[] {3,6,7}
             };

             Console.WriteLine(BusRoute.FindRoutes(routes, 1, 6));*/

            // Console.WriteLine(LongestDuplicatedString.LongestDuplicated("abcd"));
            /*int[] array = new int[] { 1, 1, 1 };
            Console.WriteLine(SmallestDistancePair.SmallestDistance(array, 1));*/
            print(MinimumInvalidParentheses.RemoveMinimalParentheses(")("));


        }

        static void print(string[] array)
        {
            foreach (string i in array)
            {
                Console.WriteLine(i);
            }
        }
    }
}
