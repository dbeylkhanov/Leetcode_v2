namespace leetcode.Arrays;

//O(2n) = O(n)
public class KidsWithCandies
{
	public IList<bool> Execute(int[] candies, int extraCandies)
	{
		var result = new List<bool>();
		int max = 0;
		for (int i = 0; i < candies.Length; i++)
		{
			max = max > candies[i] ? max : candies[i];
		}

		for (int i = 0; i < candies.Length; i++)
		{
			result.Add(candies[i] + extraCandies >= max);
		}

		return result;
	}
}