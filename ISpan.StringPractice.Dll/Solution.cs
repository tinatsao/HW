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
		/// How:先轉成字串，再轉成陣列
		/// </summary>
		/// <param name="num"></param>
		/// <returns></returns>
		public int[] GetDigts(int num)
		{
			string strNum = num.ToString();
			var q = from c in strNum.Select(c => int.Parse(c.ToString())) select c;
			return q.ToArray();

		}

		/// <summary>
		/// What:如何取得一個正整數的每一位數
		/// How:依序將每個數字除以10，取餘數
		/// </summary>
		/// <param name="num"></param>
		/// <returns></returns>
		public int[] GetDigtsUseDiv(int num)
		{
			List<int> result = new List<int>();
			while (num > 0)
			{
				result.Insert(0, num % 10);
				num = num / 10;
			}
			return result.ToArray();
		}
		/// <summary>
		/// What:請寫一個程式可以輸入列數n，第一列列印出n+5個字，以後每列遞減一個字，其內容以"Hello"字串 依序取出字來填入。
		///以n=6為例 
		///HelloHelloH
		/// elloHelloH
		///  elloHello
		///   HelloHel
		///    loHello
		///     HelloH
		/// How:1. stringLength:先算出總共需要幾個字
		/// 2.allString:依據總字數產生一個長字串
		/// 3. result:使用Substring從長字串中，切出我想要的結果。
		/// </summary>
		/// <param name="source">"Hello"</param>
		/// <param name="row">6</param>
		/// <returns></returns>
		public string PrintHello(string source,int row)
		{
			int stringLength = 0;
			int topicNum = 5;
			string allString = string.Empty;
			string result = string.Empty;
			
			for (int i= row+ topicNum; i>= (row+ topicNum)-(row-1); i--)
			{
				stringLength += i;
			}
			allString = string.Concat(Enumerable.Repeat(source, (stringLength / source.Length)+1));
			
			int j = topicNum;
			for (int i = 0; i < row; i++)
			{
				result += new string(' ',(row+ topicNum) - (row+j))+allString.Substring(0, row + j) +"\r\n";
				allString = allString.Substring(row + j);
				j--;
			}
			return result;
		}


	
	
		public int[] TwoSum(int[] nums, int target)
		{
			for (int i = 0; i < nums.Length; i++)
			{
				for (int j = i + 1; j < nums.Length; j++)
				{
					if (nums[j] == target - nums[i])
					{
						return new int[] { i, j };
					}
				}
			}
			// In case there is no solution, we'll just return null
			return null;
		}

	}
}

