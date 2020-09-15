using System;

namespace LeetCodeProblems.Algorithms
{
    public class MergeSortAlgorith
    {
        public static int[] MergeSort(int[] array)
        {
            int[] left;
            int[] right;
            int[] result = new int[array.Length];

            //As this is a recursive algorithm, we need to have a base case to 
            //avoid an infinite recursion and therfore a stackoverflow
            if (array.Length <= 1)
            {
                return array;
            }
            // the exact midpoint of our array
            int midpoint = array.Length / 2;
            // will represent our left array
            left = new int[midpoint];

            // if array has an even number of elements, the left and right array will have the same number of 
            //elements
            if (array.Length % 2 == 0)
            {
                right = new int[midpoint];
            }
            //if array has an odd number of elements, the right array will have one more element than left
            else
            {
                right = new int[midpoint + 1];
            }

            // populate the left array
            for (int i = 0; i < midpoint; i++)
            {
                left[i] = array[i];
            }

            // populate right array
            int x = 0;
            //We start our index from the midpoint, as we have already populated the left array from 0 to 
            //midpont
            for (int i = midpoint; i < array.Length; i++)
            {
                right[x] = array[i];
                x++;
            }

            // recursively sort the left array
            left = MergeSort(left);
            // recursively sort the right array
            right = MergeSort(right);
            result = Merge(left, right);
            return result;
        }

        //This method will be responsible for combining our two sorted arrays into one giant array
        private static int[] Merge(int[] left, int[] right)
        {
            int resultLength = right.Length + left.Length;
            int[] result = new int[resultLength];
            int indexLeft = 0, indexRight = 0, indexResult = 0;

            //while either array still has an element
            while (indexLeft < left.Length || indexRight < right.Length)
            {
                // if both arrays have elements
                if (indexLeft < left.Length && indexRight < right.Length)
                {
                    //If item on left array is less than item on right array, add that item to the result array 
                    if (left[indexLeft] <= right[indexRight])
                    {
                        result[indexResult++] = left[indexLeft++];
                    }
                    else
                    {
                        result[indexResult++] = right[indexRight++];
                    }

                }
                //if only the left array still has elements, add all its items to the results array
                else if (indexLeft < left.Length)
                {
                    result[indexResult++] = left[indexLeft++];
                }
                //if only the right array still has elements, add all its items to the results array
                else if (indexRight < right.Length)
                {
                    result[indexResult++] = right[indexRight++];
                }
            }

            return result;
        }
    }
}