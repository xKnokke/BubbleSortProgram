using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubbleSort
{
	public class BubbleSortResult
	{
		public int[] arr { get; set; }
		public int comparisons { get; set; }
		public int swaps { get; set; }

		public BubbleSortResult(int[] arr, int comparisons, int swaps)
		{
			this.arr = arr;
			this.comparisons = comparisons;
			this.swaps = swaps;
		}
	}
}
