using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISpan.StringPractice.Dll
{
	public class Solution
	{
		//public int SingleNumber(int[] nums)
		//{

		//}
		/// <summary>
		/// What:如何取得一個正整數的每一位數
		/// </summary>
		/// <param name="num"></param>
		/// <returns></returns>
		public int[] GetDigts(int num)
		{
			string strNum = num.ToString();
			int[] result = new int[] { };
			foreach (char item in strNum)
			{
				result.Append((int)item);
			}
			return result;
		}
	}
}
