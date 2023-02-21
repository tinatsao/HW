using ISpan.StringPractice.Dll;

namespace ISpan.EasyPractice.TestProject
{
	public class SolutionTests
	{

		[TestCase(new int[] { 2, 7, 11, 15 }, 9, new int[] { 0,1})]

		public void Test_TwoSum_ㄢ计ぇ㎝(int[] nums, int target,int[] expected)
		{

			Solution solution = new Solution();
			var actual = solution.TwoSum(nums, target);

			Assert.AreEqual(expected, actual);
		}


		[TestCase(new int[] { 2, 2, 1 }, 1)]
		[TestCase(new int[] { 4, 1, 2, 1, 2 }, 4)]
		[TestCase(new int[] { 1 }, 1)]

		public void SingleNumber2_肚瞷Ω计(int[] nums , int expected)
		{
			Solution solution = new Solution();
			int actual = solution.SingleNumber2(nums);
			Assert.AreEqual(expected, actual);
		}

		
		
		[TestCase(new int[] { 10, 1, 2, 3, 4, 5 }, 0, 1, new int[] { 1, 10, 2, 3, 4, 5 })]
		[TestCase(new int[] {10,6,2,3,4,5 }, 1,5, new int[] { 10, 5 , 2, 3, 4, 6 })]
		

		public void SwapItemsValue_ユ传﹚index计(int[] nums, int x,int y ,int[] expected)
		{
			Solution solution = new Solution();
			solution.SwapItemsValue(nums,  x, y);
			int[] actual = nums;
			Assert.AreEqual(expected, actual);
		}

	}
}