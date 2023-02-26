using ISpan.StringPractice.Dll;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISpan.EasyPractice.TestProject
{
	public class OrderTests
	{
		[TestCase(100, 5)]
		[TestCase(119, 6)]
		[TestCase(110, 6)]
		[TestCase(130, 7)]
		[TestCase(210,11)]
		//四捨六入五成雙
		public void CalaTax_傳回5趴稅金(int price, int expencted)
		{
			//arrange(準備)：準備物件。
			//int expencted=100;
			//int actual = 5;

			//action(執行)：操作物件。
			int actual = Order.CalaTax(price);

			//assert(驗證)：驗證物件是否符合預期結果。
			Assert.AreEqual(expencted, actual);
		}
	}
}
