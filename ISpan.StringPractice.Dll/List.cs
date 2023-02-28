using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISpan.StringPractice.Dll
{
	/// <summary>
	/// indexer測試/學習
	/// </summary>
	public class List
	{
		private int[] data;

		public List(int size)
		{
			data = new int[size];
		}
		//indexer code
		public int this[int index]
		{
			get
			{
				return data[index];
			}
			set
			{
				data[index] = value;
			}
		}
	}

	// 使用範例

}
