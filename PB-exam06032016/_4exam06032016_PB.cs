using System;

namespace _4exam06032016_PB
{
	class MainClass
	{
		public static void Main (string[] args)
		{
						int N = int.Parse (Console.ReadLine ());
						double p1 = 0;
						double p2 = 0;
						double p3 = 0;
						double p4 = 0;
						double p5 = 0;

						for (var i=0; i<N; i++) {
							int p = int.Parse (Console.ReadLine ());
							if (p < 200) {
								p1++;
							} else if (p >= 200 && p < 400) {
								p2++;
							} else if (p >= 400 && p < 600) {
								p3++;
							} else if (p >= 600 && p < 800) {
								p4++;
							} else
								p5++;
						}

						var procentP1 = p1 / N * 100;
						var procentP2 = p2 / N * 100;
						var procentP3 = p3 / N * 100;
						var procentP4 = p4 / N * 100;
						var procentP5 = p5 / N * 100;

						Console.WriteLine ("{0:F2}%", procentP1);
						Console.WriteLine ("{0:F2}%", procentP2);
						Console.WriteLine ("{0:F2}%", procentP3);
						Console.WriteLine ("{0:F2}%", procentP4);
						Console.WriteLine ("{0:F2}%", procentP5);
					}
			
	}
}
