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
			Solution solution = new Solution();
			
			int nums = 123456;
			int[] result = solution.GetDigtsUseDiv(nums);
			foreach(int item in result)
			{
				Console.WriteLine(item);
			}
		}	
	}
}
