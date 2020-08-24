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
