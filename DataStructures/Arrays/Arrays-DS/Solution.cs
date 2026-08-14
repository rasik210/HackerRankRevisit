
using System.Collections.Generic;

namespace HackerRankRevisit.DataStructures.Arrays.Arrays_DS
{
    /*
         Problem: https://www.hackerrank.com/challenges/arrays-ds/problem
         IDE: Visual Studio Community 2022
         Framework: .NET v8.0

         Algorithm Overview:
         - Traverse the input array from tail and store each element being traversed into a new array.
         - Return the new array.


         Gotchas: <None>

         Time Complexity:  O(n) //we need to traverse the entire array
         Space Complexity: O(n) //we need an additional array having original array's size

    */

    internal class Solution
    {
        static void Main(string[] args)
        {
            var arrCount = Convert.ToInt32(Console.ReadLine().Trim());
            var input = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();
            var res = Result.ReverseArray(input);
            Console.WriteLine(string.Join(" ", res));
        }

    }

    internal class Result
    {
        public static List<int> ReverseArray(List<int> input)
        {
            var output = new List<int>();
            for (int i = input.Count - 1; i >= 0; i--)
                output.Add(input[i]);

            return output;
        }
    }
}   