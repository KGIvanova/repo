using System;

namespace _2exam06032016_PB
{
	class MainClass
	{
		public static void Main (string[] args)
		{
					Console.Write("Broi kilomentri: ");
					double n = double.Parse(Console.ReadLine());
					Console.Write("Izberete tarifa: day/night= ");
					string tarifa = Console.ReadLine();

					if (n < 20 && tarifa == "day")
					{
						var price = 0.70 + (n * 0.79);
						Console.WriteLine(price);
					}

					if (n < 20 && tarifa == "night")
					{
						var price = 0.70 + (n * 0.90);
						Console.WriteLine(price);
					}

					if (n >= 20 && n < 100)
					{
						var price = n * 0.09;
						Console.WriteLine(price);
					}

					if (n >= 100)

					{
						var price = n * 0.06;
						Console.WriteLine(price);
					}
	}
	}
}
