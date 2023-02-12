using ISpan.StringPractice.Dll;

namespace ISpan.EasyPractice.TestProject
{
	public class Tests
	{

		[TestCase(new int[] { 2, 7, 11, 15 }, 9, new int[] { 0,1})]

		public void Test_TwoSum_兩數之和(int[] nums, int target,int[] expected)
		{

			Solution solution = new Solution();
			var actual = solution.TwoSum(nums, target);

			Assert.AreEqual(expected, actual);
		}

	}
}