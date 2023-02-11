using ISpan.StringPractice.Dll;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISpan.StringPractice.ConsoleApp
{
    public class Program
    {
        static void Main(string[] args)
        {


			string template = "Hello"; // 範本文字
			int index = 0; // 一開始從template的第一個字開始生成
			int length = 11; // 每一列要生成幾個字
			int rows = 6; // 一共要生成幾列文字
			const int lengthPerRow = 11; // 每列文字的總長度
			for (int i = 0; i < rows; i++)
			{
				(string, int) result = StringTools.RenderRowString(template, index, length);
				Console.WriteLine(result.Item1.PadLeft(lengthPerRow)); // 這裡的lengthPerRow是為了讓每一列文字都靠右對齊

				index = result.Item2; // 這裡的index是為了讓下一列文字的第一個字是上一列文字的最後一個字
				length--; // 每一列文字的長度都會減少1
			}
		}	
	}
}
