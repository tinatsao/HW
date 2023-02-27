using ISpan.StringPractice.Dll;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;


namespace ISpan.StringPractice.ConsoleApp
{
	public class Program
	{
		static void Main(string[] args)
		{
			double x = 0.12345;
			string s;
			
			s = String.Format("{0:P}", x); // s 的值為 "12.35%"
			
			//字串插值寫法
			s = $"{x:P}"; // s 的值為 "12.35%"
			s = $"{x:P3}"; // s 的值為 "12.345%"
			x = 123456789;
			s = $"{x:N2}%"; //s 的值為 "123,456,789.00%"
							//如果您需要在輸出的百分比值中包含千位分隔符，可以在插值表達式中使用逗號。
		}
	}
}
	
	//var items = new int[] { 10,1,2,3,4,0};
	//Console.WriteLine(new Solution().IsZeroRight(items));
	//items = new int[] { 10, 1, 2, 3, 0, 0 };
	//Console.WriteLine(new Solution().IsZeroRight(items));
	//items = new int[] { 0,0,0,0};
	//Console.WriteLine(new Solution().IsZeroRight(items));
	//items = new int[] {10,1,2,3,4,2};
	//Console.WriteLine(new Solution().IsZeroRight(items));
	//items = new int[] { 10,6,2,3,0,5};
	//Console.WriteLine(new Solution().IsZeroRight(items));
		

