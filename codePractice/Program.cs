using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;

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

        public int Reverse(int x)
        {
            long num = x;
            long result = 0;
            num = Math.Abs(num);
            while (num!=0)
            {
                result = (result*10)+(num % 10);

                num /= 10;
            }

            if (result > int.MaxValue)
                return 0;

            return (x < 0)? 0 - (int)result : (int) result ;
        }

        public bool IsPalindrome(int x)
        {
            int num = x;
            int divisor = 1;

            while (num / divisor >= 10)
                divisor *= 10;


            while (num != 0)
            {
                int firstDigit = num / divisor;
                int lastDigit = num % 10;

                if (firstDigit != lastDigit)
                    return false;

                //removing first and last numbers
                num = (num % divisor) / 10;
                divisor = divisor / 100;


            }

            if (x < 0)
                return false;

            return true;
        }

        public int RomanToInt(string s)
        {
            int result = 0;
            Dictionary<char, int> romanNumbers = new Dictionary<char, int>();
            romanNumbers.Add('I', 1);
            romanNumbers.Add('V', 5);
            romanNumbers.Add('X', 10);
            romanNumbers.Add('L', 50);
            romanNumbers.Add('C', 100);
            romanNumbers.Add('D', 500);
            romanNumbers.Add('M', 1000);

            int subResult = 0;

            for (int i = 0; i < s.Length; i++)
            {
                if (i < s.Length - 1)
                {
                    if (romanNumbers[s[i]] < romanNumbers[s[i + 1]])
                    {
                        subResult = romanNumbers[s[i + 1]] - romanNumbers[s[i]];
                        result += subResult;
                        subResult = 0;
                        i += 1;

                        continue;
                    }
                }

                result += romanNumbers[s[i]];
            }

            return result;
        }

        public string LongestCommonPrefix(string[] strs)
        {
            if (strs.Length == 0)
                return "";
            string prefix = strs[0];
            for (int i = 0; i < strs.Length; i++)
            {
                while (strs[i].IndexOf(prefix)!=0)
                {
                    prefix = prefix.Substring(0, prefix.Length -1 );
                    if (prefix == string.Empty)
                        return "";
                }
            }
            return prefix;
        }

        public bool IsValid(string s)
        {
            Stack<Char> stack = new Stack<char>();
            Dictionary<char, char> charactersMapping = new Dictionary<char, char>();
            charactersMapping.Add( ')', '(');
            charactersMapping.Add( '}', '{');
            charactersMapping.Add( ']', '[');

            for (int i = 0; i < s.Length; i++)
            {
                char c = s[i];

                // if the current character is a closing bracket
                if (charactersMapping.ContainsKey(c))
                {
                    //get the top element of the stack. if stack is empty set dummy value
                    char topElement = (stack.Count == 0) ? '#' : stack.Pop();

                    // if the mapping for this bracket doesn't match the stack's top elemnt. return false
                    if (topElement != charactersMapping[c])
                        return false;
                }
                else
                {
                    //if it was an opening bracket push to the stack
                    stack.Push(c); 

                }

            }


            return (stack.Count == 0);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {

            EulerAlgorithims algorithim = new EulerAlgorithims();

            string[] strings = {"leets","leetcode", "leets", "leeds"};
            Console.WriteLine(algorithim.IsValid("(((((())))))"));      
        }
    }
}
