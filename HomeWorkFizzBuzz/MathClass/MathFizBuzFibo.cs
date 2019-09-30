using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MathClass
{
	public class MathFizBuzFibo
	{
		public string FizzBuzzAsyncTwoArrays(int[] array)
		{
			Stopwatch watch = new Stopwatch();

			watch.Start();

			string result = "";
			int halfOfArray = array.Length / 2;
			int[] firstPart = new int[halfOfArray];
			int[] secondPart = new int[halfOfArray];

			for (int i = 0, j = halfOfArray; i < halfOfArray; i++, j++)
			{
				firstPart[i] = array[i];
				secondPart[i] = array[j];
			}

			var firstResult = Result(firstPart);
			var secondResult = Result(secondPart);


			result += firstResult.Result;
			result += secondResult.Result;
			watch.Stop();

			Console.WriteLine($"2 arrays time{watch.Elapsed.ToString()}");
			return result;
		}

		public string FizzBuzzOneArray(int[] array)
		{
			Stopwatch watch = new Stopwatch();

			watch.Start();
			string result = Result(array).Result;
			watch.Stop();

			Console.WriteLine($"1 arrays time{watch.Elapsed.ToString()}");
			return result;

		}

		private async Task<string> Result(int[] array, int firstValue = 3, int secondValue = 5)
		{
			string result = "";

			await Task.Run(() =>
			{
			
				foreach (int element in array)
				{
					if (((element % firstValue) == 0) && ((element % secondValue) == 0))
					{
						result += "FizzBuzz";
					}
					else if ((element % firstValue) == 0)
					{
						result += "Fizz";
					}
					else if ((element % secondValue) == 0)
					{
						result += "Buzz";
					}
					else
					{
						result += $"{element}";
					}
				}
			});
			return result;
		}

		public static int Fibonachi(int n)
		{
			if (n == 0 || n == 1)
			{
				return n;
			}
			else
			{
				return Fibonachi(n - 1) + Fibonachi(n - 2);
			}
		}
	}
}
