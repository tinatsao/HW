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
            Console.WriteLine(solution.GetSumOfSquares(23));
            Console.WriteLine(solution.GetSumOfSquares(123));
        }	
	}
}
