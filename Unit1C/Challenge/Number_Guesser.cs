using System;

public class Program
{
	public static void Main()
	{
		var rnd = new Random();
		var num = rnd.Next(1, 11);
		Console.WriteLine("Guess a number from 1 to 10");
		var i = 0;
		
		while (i < 1)
		{
			int user = Convert.ToInt32(Console.ReadLine());
			if (user == num)
			{
				Console.Write(num + " is correct! Well done!");
				i++;
			}
			else
			{
				Console.WriteLine("Incorrect. Try again.");
			}
		}
	}
}
