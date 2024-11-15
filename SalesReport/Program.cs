using System;
using static System.Console;

namespace SalesReport
{
	internal class Program
	{
		static void Main(string[] args)
		{
			string[] salesPerson = { "Edward", "Alphonse", "Maes" };
			char[] salesPersonInitials = { 'E', 'A', 'M' };
			double[] salesAmounts = new double[3];
			double[] salesPersonTotal = new double[3];
			char userInPut;

			do
			{
				Console.Write("Enter sales person initial: (E) for Edward (A) for Alphonse (M) for Maes or (Z) to quit: ");
				userInPut = Console.ReadKey().KeyChar.ToString().ToUpper()[0];
				Console.WriteLine();

				for (int i = 0; i < salesPersonInitials.Length; i++)
				{
					if (userInPut == salesPersonInitials[i])
					{
						string salesName = salesPerson[i];
						WriteLine("You have picked {0}", salesName);
						Write("Enter {0} sales: ", salesName);
						double salesAmount = double.Parse(Console.ReadLine());
						salesAmounts[i] = salesAmount;
						salesPersonTotal[i] += salesAmount;
					}
				}

			} while (userInPut != 'Z');

			double totalSales = 0;
			Console.WriteLine("\nSales Report:");
			Console.WriteLine("-------------");

			for (int i = 0; i < salesPerson.Length; i++)
			{
				Console.WriteLine($"{salesPerson[i]} ({salesPersonInitials[i]}): {salesPersonTotal[i]:C}");
				totalSales += salesPersonTotal[i];
			}

			Console.WriteLine($"Total Sales: {totalSales:C}");
			ReadLine();
		}
	}
}
