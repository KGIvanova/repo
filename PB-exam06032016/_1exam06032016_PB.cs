using System;

public class TrainingLab
{
	public static void Main(string[] args)
	{
		double height = double.Parse(Console.ReadLine());
		double width = double.Parse(Console.ReadLine());

		int desksWidth = (int)(width * 100 - 100) / 70;
		int desksHeight = (int)(height * 100)/ 120;
		int result = desksHeight * desksWidth - 3;
		Console.WriteLine(result);
	}
}