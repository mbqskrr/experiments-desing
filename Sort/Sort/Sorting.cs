using System;

namespace Sort
{
    public static class Sorting
    {
		private static int[] arr;

		public static int[] GetArr()
		{
			return arr;
		}

		public static void SetArr(int[] value)
		{
			arr = value;
		}

		public static void Selection()
		{
			int n = GetArr().Length;

			// One by one move boundary of unsorted subarray 
			for (int i = 0; i < n - 1; i++)
			{
				// Find the minimum element in unsorted array 
				int min_idx = i;
				for (int j = i + 1; j < n; j++)
				{
					if (GetArr()[j] < GetArr()[min_idx])
					{
						min_idx = j;
					}
				}
				// Swap the found minimum element with the first 
				// element 
				int temp = GetArr()[min_idx];
				GetArr()[min_idx] = GetArr()[i];
				GetArr()[i] = temp;
			}
		}

		public static void Bubble()
		{
			int temp;
			for (int j = 0; j <= GetArr().Length - 2; j++)
			{
				for (int i = 0; i <= GetArr().Length - 2; i++)
				{
					if (GetArr()[i] > GetArr()[i + 1])
					{
						temp = GetArr()[i + 1];
						GetArr()[i + 1] = GetArr()[i];
						GetArr()[i] = temp;
					}
				}
			}
		}
	}
}
