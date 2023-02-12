using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISpan.StringPractice.Dll
{
	public static class StringTools
	{
		/// <summary>
		/// 生成一行文字以及最後一個字的下一個字,應該是template的哪一個索引值
		/// </summary>
		/// <param name="template">文字範本</param>
		/// <param name="startIndex">從文字範本的哪一個索引值開始生成</param>
		/// <param name="length">總長度</param>
		/// <returns></returns>
		public static (string, int) RenderRowString(string template, int startIndex, int length)
		{
			// pre conditions
			// template 不能是null or empty string
			// startIndex 不能小於0
			// length 不能小於0
			int currentIndex = startIndex;
			StringBuilder sb = new StringBuilder();
			for (int i = 0; i < length; i++)
			{
				sb.Append(template[currentIndex]);
				currentIndex++;
				if (currentIndex == template.Length)
				{
					currentIndex = 0;
				}
			}
			return (sb.ToString(), currentIndex);
		}
		public static (string, int) GiveRowString(string template, int startIndex, int length)
		{
			int currentIndex = startIndex;

			StringBuilder sb = new StringBuilder();
			for (int i = 0; i < length; i++)
			{
				sb.Append(template[currentIndex]);
				currentIndex++;
				if (currentIndex == template.Length)
				{
					currentIndex = 0;
				}
			}
			return (sb.ToString(), currentIndex);

		}
	}
}
