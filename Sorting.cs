using System; 

namespace experiments
{
	static class Sorting
	{ 
		public int[] Arr {get; set; }
		
		public static void selection() 
		{ 
			int n = Arr.Length; 
  
			// One by one move boundary of unsorted subarray 
			for (int i = 0; i < n - 1; i++) 
			{ 
				// Find the minimum element in unsorted array 
				int min_idx = i; 
				for (int j = i + 1; j < n; j++)
				{
					if (Arr[j] < Arr[min_idx])
					{
						min_idx = j; 
					}	
				}
            // Swap the found minimum element with the first 
            // element 
            int temp = Arr[min_idx]; 
            Arr[min_idx] = Arr[i]; 
            Arr[i] = temp; 
			} 
		}
		
		public static void bubble()
		{
			for (int j = 0; j <= Arr.Length - 2; j++) {
				for (int i = 0; i <= Arr.Length - 2; i++) {
					if (Arr[i] > Arr[i + 1]) {
						temp= Arr[i + 1];
						Arr[i + 1] = Arr[i];
						Arr[i] = temp;
					}
				}
			}
		}
	}	
	
}