using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISpan.StringPractice.Dll
{
	public class Solution
	{
		/// <summary>
		/// What:如何找出一個陣列中只出現一次的數字
		/// How:使用XOR運算
		/// </summary>
		/// <param name="nums"></param>
		/// <returns></returns>
		public int SingleNumber(int[] nums)
		{
			int result = 0;
			for (int i = 0; i< nums.Length; i++)
			{
				result ^= nums[i];
			}
			return result;
		}
		


		
		/// <summary>
		/// What:如何取得一個正整數的每一位數
		/// </summary>
		/// <param name="num"></param>
		/// <returns></returns>
		public int[] GetDigts(int num)
		{
			string strNum = num.ToString();
			var q = from c in strNum.Select(c => int.Parse(c.ToString())) select c;
			return q.ToArray();

		}
	}
}
