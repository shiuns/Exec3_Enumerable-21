using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _作業03_Exec3_Enumerable_21謝孟勳
{
	internal class Program
	{
		static void Main(string[] args)
		{
			var result = Enumerable.Range(1, 10);
			foreach (int i in result)
			Console.WriteLine(i);

			Console.WriteLine();

			var result1 = Enumerable.Range(10, 6);
			foreach (int i in result1)
			Console.WriteLine(i);

		}
	}
}
