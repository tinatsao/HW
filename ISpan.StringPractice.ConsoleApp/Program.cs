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
			var items = new int[] { 10,1,2,3,4,0};
			Console.WriteLine(new Solution().IsZeroRight(items));
			items = new int[] { 10, 1, 2, 3, 0, 0 };
			Console.WriteLine(new Solution().IsZeroRight(items));
			items = new int[] { 0,0,0,0};
			Console.WriteLine(new Solution().IsZeroRight(items));
			items = new int[] {10,1,2,3,4,2};
			Console.WriteLine(new Solution().IsZeroRight(items));
			items = new int[] { 10,6,2,3,0,5};
			Console.WriteLine(new Solution().IsZeroRight(items));


		}	
	}
}
