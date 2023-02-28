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
			Console.Write("請輸入身分證字號：");
			string id = Console.ReadLine();
			string lastEightDigits = id.Substring(5); // 取得後八碼
			string hiddenId = new string('*', 5) + lastEightDigits; // 用5個星號替換前五碼
			Console.WriteLine("隱藏前五碼後的身分證字號為：" + hiddenId);
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
		

