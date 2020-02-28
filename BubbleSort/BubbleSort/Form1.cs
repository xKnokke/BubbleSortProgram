using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BubbleSort
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			int[] array = { 0, 4, 2, 6, 8, 4,1,9,0,5,3,8,65,21,654,76,322 };
			OutputArray(BubbleSort(array));
		}

		private BubbleSortResult BubbleSort(int[] arr)
		{
			int tmp;
			int cmp = 0;
			int swp = 0;

			for (int i = arr.Length; i > 1; --i)
			{
				for (int j = 0; j < i-1; ++j)
				{
					cmp++;
					if (arr[j] > arr[j+1])
					{
						swp++;
						tmp = arr[j];
						arr[j] = arr[j+1];
						arr[j+1] = tmp;
					}
				}
			}
			return new BubbleSortResult(arr, cmp, swp);
		}

		private void btnrandom_Click(object sender, EventArgs e)
		{
			int length = 0;
			int max = 0;

			if(int.TryParse(tblength.Text, out length))
			{
				if (int.TryParse(tbmax.Text, out max))
				{
					Random rnd = new Random();
					int[] randomArr = new int[length];
					for (int i = 0; i < randomArr.Length; i++)
					{
						randomArr[i] = rnd.Next(max+1);
					}

					OutputArray(BubbleSort(randomArr));
				}
			}
		}

		private void OutputArray(BubbleSortResult result)
		{
			listBox1.Items.Clear();
			foreach (int number in result.arr.ToList())
			{
				listBox1.Items.Add(number.ToString());
			}
			lblcmp.Text = "Comparisons: " + result.comparisons.ToString();
			lblswp.Text = "Swaps: " + result.swaps.ToString();
			lbllength.Text = "Array Length: " + result.arr.Length.ToString();
		}
	}
}
