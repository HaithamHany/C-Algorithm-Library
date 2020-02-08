using System;
using System.Collections.Generic;
using System.Collections;

namespace codePractice
{

    public class EulerAlgorithims
    {
        public int MultipleSum(int number)
        {
            int sum = 0;
            int value1 = 3;
            int value2 = 5;

            for (int i = 0; i < number; i++)
            {

                if (i % value1 == 0 || i % value2 == 0)
                    sum += i;
            }

            return sum;
        }

        public int[] TwoSum(int[] nums, int target)
        {
            Dictionary<int, int> map = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                if(!map.ContainsKey(nums[i]))
                    map.Add(nums[i], i);
            }

            for (int i = 0; i < nums.Length; i++)
            {
                int complement = target - nums[i];
                if (map.ContainsKey(complement) && map.GetValueOrDefault(complement) != i)
                {
                    return new int[] { i, map.GetValueOrDefault(complement) };
                }
            }

            return null;
        }
       
      
    }

    class Program
    {
        static void Main(string[] args)
        {

            EulerAlgorithims algorithim = new EulerAlgorithims();

            int[] nums = { 2, 111, 22 };
             

        }
    }
}
