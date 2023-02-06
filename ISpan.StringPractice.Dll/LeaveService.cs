using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISpan.StringPractice.Dll
{
    public class LeaveService
    {
        public int CalcTotalLeaveHours(int startHour, int endHour)
        {
            int workTimeAm = 0;
            int workTimePm = 0;
            
            IEnumerable<int> time = Enumerable.Range(startHour, (endHour - startHour) + 1);
            List<int> workTimeListAm = new List<int>() { 9, 10, 11, 12 };
            List<int> workTimeListPm = new List<int>() { 13, 14, 15, 16, 17, 18 };
            
            var q1 = time.Intersect(workTimeListAm);
            var q2 = time.Intersect(workTimeListPm);

            if (q1.Any()) workTimeAm = q1.Max() - q1.Min();
            if (q2.Any()) workTimePm = q2.Max() - q2.Min();

            return workTimeAm + workTimePm;
        }
    }
}
