using System;
using LeetCodeProblems.Problems;

namespace LeetCodeProblems
{
    class Program
    {
        static void Main(string[] args)
        {
            string problem = string.Empty;
            do
            {
                Console.WriteLine("Enter Problem number: ");
                problem = Console.ReadLine();

                switch (problem)
                {
                    case "1":
                        {
                            var nums = new int[] { 2, 7, 11, 15 };
                            Console.WriteLine($"Input: {String.Join(",", nums)} - Result: {String.Join(",", TwoSum1.TwoSum(nums, 9))}");

                            var nums2 = new int[] { 3, 2, 4 };
                            Console.WriteLine($"Input: {String.Join(",", nums)} - Result: {String.Join(",", TwoSum1.TwoSum(nums2, 6))}");

                            var nums3 = new int[] { 3, 2, 3 };
                            Console.WriteLine($"Input: {String.Join(",", nums)} - Result: {String.Join(",", TwoSum1.TwoSum(nums3, 6))}");
                        }
                        break;
                    case "242":
                        {
                            Console.WriteLine($"Input: s = \"rat\", t = \"car\" - Result: {ValidAnagram242.IsAnagram("rat", "car")}");
                            Console.WriteLine($"Input: s = \"anagram\", t = \"nagaram\" - Result: {ValidAnagram242.IsAnagram("anagram", "nagaram")}");
                        }
                        break;
                    case "x":
                        Console.WriteLine("Exiting...");
                        break;
                    default:
                        Console.WriteLine("Invalid Problem Number!");
                        break;
                }

            } while (problem != "x");
        }
    }
}
