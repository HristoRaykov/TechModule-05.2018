using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._LongestIncreasSubs
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine().Trim().Split().Select(int.Parse).ToList();


            int left = 0; //leftmost position on the left of p (left < p), such that len[left] is the largest possible.
            int[] len = new int[nums.Count];//the length of the longest increasing subsequence (LIS) ending at position p
            int[] prev = new int[nums.Count];//left values left = prev[p]
            prev[0] = -1;            
            len[0] = 1;
            
            for (int p = 1; p < nums.Count; p++)
            {
                len[p] = 1;
                prev[p] = -1;

                for (int i = 0; i < p; i++)
                {
                    
                    if (nums[p] > nums[i] && (len[i]+1 > len[p]))
                    {
                        len[p] = 1 + len[i];
                        prev[p] = i;
                        
                    }                    
                }
                                               
            }

            List<int> result = new List<int>();
            int maxIndex = Array.IndexOf(len, len.ToList().Max());


           
            while (maxIndex != -1)
            {
                result.Add(nums[maxIndex]);
                maxIndex = prev[maxIndex];
            }
            result.Reverse();

            Console.WriteLine(string.Join(" ", result));
            Console.WriteLine();
        }
    }
}
