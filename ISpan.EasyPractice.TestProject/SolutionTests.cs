using ISpan.StringPractice.Dll;

namespace ISpan.EasyPractice.TestProject
{
	public class SolutionTests
	{

		[TestCase(new int[] { 2, 7, 11, 15 }, 9, new int[] { 0,1})]

		public void Test_TwoSum_兩數之和(int[] nums, int target,int[] expected)
		{

			Solution solution = new Solution();
			var actual = solution.TwoSum(nums, target);

			Assert.AreEqual(expected, actual);
		}


		[TestCase(new int[] { 2, 2, 1 }, 1)]
		[TestCase(new int[] { 4, 1, 2, 1, 2 }, 4)]
		[TestCase(new int[] { 1 }, 1)]

		public void SingleNumber2_傳回出現一次的數字(int[] nums , int expected)
		{
			Solution solution = new Solution();
			int actual = solution.SingleNumber2(nums);
			Assert.AreEqual(expected, actual);
		}

	}
}