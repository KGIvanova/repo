using System;

namespace _5exam06032016_PB
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			int n = int.Parse(Console.ReadLine());
			int width = 2 * n;
			int height = n;
			int symbol = n / 2;
			int dashes = width - (symbol * 2) - 4;

			Console.WriteLine("/{0}\\{1}/{0}\\",new string('^',symbol),new string('_',dashes));

			for (int i = 0; i < height - 3; i++)
			{
				Console.WriteLine("|{0}|",new string(' ',width - 2));
			}

			Console.WriteLine("|{0}{1}{0}|",new string(' ',symbol + 1),new string('_',dashes));
			Console.WriteLine("\\{0}/{1}\\{0}/", new string('_', symbol), new string(' ', dashes));
		}
	}
}
