using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISpan.StringPractice.Dll
{
    public class DateTools
    {
        //民國年 英文: ROC
        //西元年 英文: AD
        /// <summary>
        /// 民國年要轉換成西元年是加 1911, 例如民國 89 年是西元 2000年
        /// 假設字串是 "890125", 請寫程式將它轉換成 "2000/01/25"
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static string RocConvertToAdDate(string input)
        {
            input = input.PadLeft(7, '0');
            DateTime dt = new DateTime();
            string output = string.Empty;
            
            int year = int.Parse(input.Substring(0, 3));
            int month = int.Parse(input.Substring(3, 2));
            int day = int.Parse(input.Substring(5, 2));

            try 
            {
                dt = new DateTime(year + 1911, month, day);
            } 
            catch (Exception ex) 
            {
                return "此日期並非合法日期，\r\n請確認後再試一次。";
            }
            output = dt.ToString("yyyy/MM/dd");
            return output;
        }
    }
}
