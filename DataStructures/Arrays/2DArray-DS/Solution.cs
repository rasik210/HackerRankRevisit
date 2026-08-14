
namespace HackerRankRevisit.DataStructures.Arrays.TwoDArray_DS
{
    /*
         Problem: https://www.hackerrank.com/challenges/2d-array/problem?isFullScreen=false
         IDE: Visual Studio Community 2022
         Framework: .NET 8.0
         Algorithm Overview:
         - Initialise maximum hourglass sum to 0.
         - Traverse every hourglass structure starting from any element lying in 0th to 3rd column of 0th to 3rd row of the array.
         - Calculate the current hourglass sum. 
         - Replace the max hourglass sum with the current hourglass sum if it is higher.

         Gotchas: <None>

         Time Complexity:  O(1) //Array is of a fixed 6x6 dimension. We have to iterate a constant number of array elements.
         Space Complexity: O(1) //Array is of a fixed 6x6 dimension. So space requirement is constant.

    */

    internal class Solution
    {
        static void Main(string[] args)
        {
            List<List<int>> arr = new List<List<int>>();

            for (int i = 0; i < 6; i++)
                arr.Add(Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList());

            Console.WriteLine(Result.HourglassSum(arr));
        }
    }

    internal class Result
    {
        public static int HourglassSum(List<List<int>> twoDArray)
        {
            var highestHourglassSum = int.MinValue;

            for (int i = 0; i < 4; i++) //rows
            {
                for (int j = 0; j < 4; j++)//columns
                {
                    var hourglassSum = twoDArray[i][j]   + twoDArray[i][j+1]  + twoDArray[i][j+2]
                                                         + twoDArray[i+1][j+1]
                                     + twoDArray[i+2][j] + twoDArray[i+2][j+1] + twoDArray[i+2][j+2];
                    if (hourglassSum > highestHourglassSum)
                        highestHourglassSum = hourglassSum;
                }
            }
            return highestHourglassSum;
        }
    }
}   