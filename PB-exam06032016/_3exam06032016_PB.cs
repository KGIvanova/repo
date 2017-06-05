using System;

namespace _3exam06032016_PB
{
	class MainClass
	{
		public static void Main (string[] args)

					{
						int hourExam = int.Parse(Console.ReadLine());
						int minutesExam = int.Parse(Console.ReadLine());
						int hourArrive = int.Parse(Console.ReadLine());
						int minutesArrive = int.Parse(Console.ReadLine());

						int timeExam = hourExam * 60 + minutesExam; //vreme na izpit
						int timeArrive = hourArrive * 60 + minutesArrive;  //vreme na pristigane
						int timeDifference = timeArrive - timeExam;

						if (timeDifference < -30) { Console.WriteLine("Early");}
						else if (timeDifference <= 0) {Console.WriteLine("On time");}
						else {Console.WriteLine("Late");}

						if (timeDifference != 0)
						{
							int hours = Math.Abs(timeDifference / 60);
							int minutes = Math.Abs(timeDifference % 60);

							if (hours > 0)
							{
								Console.Write("{0}:{1:00} hours", hours, minutes);
							}
							else {Console.Write("{0} minutes", minutes);
							}
							if (timeDifference < 0) { Console.WriteLine(" before the start");}
							else {Console.WriteLine(" after the start");}

						}


		}
	}
}
