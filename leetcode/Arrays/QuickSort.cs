namespace leetcode.Arrays;

public class QuickSort
{
	public int[] Sort(int[] candies)
	{
		Sort(candies, 0, candies.Length - 1);

		return candies;
	}


	private void Sort(int[] candies, int left, int right)
	{
		int pivot = candies[right];
		int pivotPos = right;

		for (int i = left; i < right; i++)
		{
			if (candies[i] >= pivot && pivotPos > i)
			{
				int swapedValue = candies[i];
				candies[i] = pivot;
				candies[pivotPos] = swapedValue;
				pivotPos = i;
			}

			if (candies[i] < pivot)
			{
				int newPivotInd = i;
				if (newPivotInd > pivotPos)
				{
					while (newPivotInd > pivotPos)
					{
						Swap(candies, newPivotInd, newPivotInd - 1);
						newPivotInd--;
					}

					pivotPos++;
				}
			}
		}

		if (pivotPos - 1 > left)
		{
			// слева от пивота
			Sort(candies, left, pivotPos - 1);
		}

		// справа от пивота
		if (right - pivotPos > 1)
		{
			Sort(candies, pivotPos + 1, right);
		}
	}

	static void Swap(int[] array, int i, int j)
	{
		int temp = array[i];
		array[i] = array[j];
		array[j] = temp;
	}
}