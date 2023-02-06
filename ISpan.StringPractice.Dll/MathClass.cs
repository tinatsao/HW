using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISpan.StringPractice.Dll
{
    public class MathClass
    {
        public int SumArithmeticProgression(int start, int end , int interval)
        {
            int sum = 0;
            for (int i = start; i <= end ;i+= interval)
            {
                sum += i;
            }
            return sum;
        }
        //public int SumArithmeticProgressionFunction(int start, int end, int interval)
        //{
            
        //}
    }
}






