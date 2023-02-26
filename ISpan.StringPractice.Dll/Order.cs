using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISpan.StringPractice.Dll
{
	public class Order
	{/// <summary>
	 /// what:回傳5%的稅金
	 /// </summary>
	 /// <param name="price"></param>
	 /// <returns></returns>
		public static int CalaTax(int price)
		{
			return (int)Math.Round((double)price/20.0,MidpointRounding.AwayFromZero);//營業稅5%
		}
	}
}
