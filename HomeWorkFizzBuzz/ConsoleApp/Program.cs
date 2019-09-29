using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MathClass;

namespace ConsoleApp
{
	class Program
	{
		static void Main(string[] args)
		{
			Random rnd = new Random();
			int[] array = new int[rnd.Next(10000, 25000)];

			for (int i = 0; i < array.Length; i++)
			{
				array[i] = i;
			}

			MathFizBuzFibo mathFizBuzFibo = new MathFizBuzFibo();
			Console.WriteLine("Enter number of finding fibonachi number");
			int number = int.Parse(Console.ReadLine());
			Task.Run(() =>
			{
				Stopwatch watch = new Stopwatch();

				watch.Start();
				Console.WriteLine(MathFizBuzFibo.Fibonachi(number));
				watch.Stop();

				Console.WriteLine($"fibonachi time {watch.Elapsed.ToString()}");

			});

			Task.Run(() =>
			{
				var oneArraySym = mathFizBuzFibo.FizzBuzzOneArray(array);
				//Console.WriteLine(oneArraySym);
			});

			Task.Run(() =>
			{
				var twoArraySym = mathFizBuzFibo.FizzBuzzAsyncTwoArrays(array);
				//Console.WriteLine(twoArraySym);
			});

			Console.ReadKey();

		}
	}
}
