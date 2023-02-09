using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISpan.StringPractice.Dll
{
    public class MathClass
    {
        public int SumArithmeticProgression(int start, int end , int interval)
        {
            int sum = 0;
            for (int i = start; i <= end ;i+= interval)
            {
                sum += i;
            }
            return sum;
        }
            
        
        /// <summary>
        /// What: 一個陣列裡面有一個數字只出現一次，其他數字都出現兩次，請找出這個數字
        /// How : 用 XOR 的特性，相同的數字 XOR 會變成 0，所以把所有數字 XOR 起來，最後的結果就是只出現一次的數字
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public int SingleNumberXor(int[] nums)
        {
            int result = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                result ^= nums[i];
            }
            return result;
        }

        /// <summary>
        /// What: 一個陣列裡面有一個數字只出現一次，其他數字都出現兩次，請找出這個數字
        /// How : 用 List 的特性，把所有數字放進 List，如果 List 已經有這個數字了，就把它從 List 移除，最後 List 剩下的數字就是只出現一次的數字
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public int SingleNumberTwoList(int[] nums)
        {
            List<int> list1 = new List<int>();
            List<int> list2 = new List<int>();
            foreach (int item in nums)
            {
                if (list1.Contains(item))
                {
                    list2.Add(item);
                }
                else
                {
                    list1.Add(item);
                }
            }
            return list1.Except(list2).First();
        }
    }
}






