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
            int[] nums = new int[]{ 1 };

			List<int> list1 = new List<int>();
			List<int> list2 = new List<int>();

			foreach (int item in nums)

            Console.WriteLine(mathClass.SingleNumberXor(nums).ToString());
		}
    }
}
//LeaveService leaveService = new LeaveService();
//int CaseA = leaveService.CalcTotalLeaveHours(9,18);
//int CaseB = leaveService.CalcTotalLeaveHours(9, 17);
//int CaseC = leaveService.CalcTotalLeaveHours(9, 12);
//int CaseD = leaveService.CalcTotalLeaveHours(9, 13);
//int CaseE = leaveService.CalcTotalLeaveHours(12,14);
//int CaseF = leaveService.CalcTotalLeaveHours(8, 18);
//int CaseG = leaveService.CalcTotalLeaveHours(9, 23);


//Console.WriteLine($"請假時間為09~18,總請假時數為{CaseA}小時。");
//Console.WriteLine($"請假時間為09~17,總請假時數為{CaseB}小時。");
//Console.WriteLine($"請假時間為09~12,總請假時數為{CaseC}小時。");
//Console.WriteLine($"請假時間為09~13,總請假時數為{CaseD}小時。");
//Console.WriteLine($"請假時間為12~14,總請假時數為{CaseE}小時。");
//Console.WriteLine($"請假時間為08~18,總請假時數為{CaseF}小時。");
//Console.WriteLine($"請假時間為09~23,總請假時數為{CaseG}小時。");


//string input = "890125";
//string output = DateTools.RocConvertToAdDate(input);
//Console.WriteLine(output);

//MathClass mathClass = new MathClass();
//Console.WriteLine(mathClass.SumArithmeticProgression(1, 99, 2));
//Console.WriteLine(mathClass.SumArithmeticProgressionFunction(1,99,2));



