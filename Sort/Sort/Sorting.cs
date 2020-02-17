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
			int n = arr.Length;

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

		public static void RecursiveBubble(int[] arr, int n)
		{
			// Base case 
			if (n == 1)
				return;

			// One pass of bubble  
			// sort. After this pass, 
			// the largest element 
			// is moved (or bubbled)  
			// to end. 
			for (int i = 0; i < n - 1; i++)
				if (arr[i] > arr[i + 1])
				{
					// swap arr[i], arr[i+1] 
					int temp = arr[i];
					arr[i] = arr[i + 1];
					arr[i + 1] = temp;
				}

			// Largest element is fixed, 
			// recur for remaining array 
			RecursiveBubble(arr, n - 1);
		}

		// Return minimum index 
		private static int MinIndex(int[] a, int i, int j)
		{
			if (i == j)
				return i;

			// Find minimum of remaining elements 
			int k = MinIndex(a, i + 1, j);

			// Return minimum of current and remaining. 
			return (a[i] < a[k]) ? i : k;
		}

		// Recursive selection sort. n is size of  
		// a[] and index is index of starting element. 
		public static void RecurisveSelection(int[] a, int n, int index)
		{

			// Return when starting and size are same 
			if (index == n)
				return;

			// calling minimum index function  
			// for minimum index 
			int k = MinIndex(a, index, n - 1);

			// Swapping when index and minimum index  
			// are not same 
			if (k != index)
			{
				// swap 
				int temp = a[k];
				a[k] = a[index];
				a[index] = temp;
			}

			// Recursively calling selection sort function 
			RecurisveSelection(a, n, index + 1);
		}

		// Driver Code 

	}
}
