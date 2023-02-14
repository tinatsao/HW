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
            int[] nums;
            int target;
            Solution solution = new Solution();
            
			nums = new int[] { 2, 7, 11, 15}; target = 9;
            int[] result = solution.TwoSum(nums, target);
            Console.WriteLine($"[{result[0]},{result[1]}]");
            
			nums = new int[] { 3,2,4 } ; target = 6;
			result = solution.TwoSum(nums, target);
			Console.WriteLine($"[{result[0]},{result[1]}]");

			nums = new int[] { 3, 3 }; target = 6;
			result = solution.TwoSum(nums, target);
			Console.WriteLine($"[{result[0]},{result[1]}]");
		}	
	}
}
