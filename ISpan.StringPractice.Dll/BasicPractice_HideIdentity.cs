using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ISpan.StringPractice.Dll
{
	public class BasicPractice_HideIdentity
	{
		/// <summary>
		/// what: 隱藏身份證字號的第二個到第七個字元
		/// How: 使用Substring取得第一個字元與最後三個字元，再用new string('*',6)取得6個*號，最後再用+號連接
		/// </summary>
		/// <param name="input"></param>
		/// <returns></returns>
		public string DisableIdentityNumber(string input)
		{
			//Substring用法: string.Substring(從第幾個索引開始,要取的長度。)
			return input.Substring(0,1)+new string('*',6)+input.Substring(7,3);
		}
		/// <summary>
		/// what: 隱藏身份證字號的第二個到第七個字元
		/// How: PadRight在字串後面補字元，用法: string.PadRight(要取的長度,要補的字元)
		/// </summary>
		/// <param name="input"></param>
		/// <returns></returns>
		public string DisableIdentityNumber2(string input)
		{
			return input.Substring(0, 1).PadRight(6, '*') + input.Substring(input.Length - 3);
		}

		/// <summary>
		/// what: 隱藏身份證字號的第二個到第七個字元
		/// How: 使用Concat連接字串
		/// </summary>
		/// <param name="input"></param>
		/// <returns></returns>
		public string DisableIdentityNumber3(string input)
		{
			return string.Concat(input.Substring(0, 1).PadRight(6, '*') ,input.Substring(input.Length - 3));
		}
		/// <summary>
		/// what: 隱藏身份證字號的第二個到第七個字元
		/// How: 使用ToCharArray將字串轉成字元陣列，再用for迴圈將第二個到第七個字元改成*號
		/// </summary>
		/// <param name="input"></param>
		/// <returns></returns>
		public string DisableIdentityNumber4(string input)
		{
			char[] idArray = input.ToCharArray();
			for (int i = 1; i < idArray.Length - 3; i++)
			{
				idArray[i] = '*';
			}
			return new string(idArray);
			
		}
	}
}
