using System;

public class Program
{
	public static void Main()
	{
		var rnd = new Random(); //declares the variable rnd from the Random function(? is this a function? What is this?)
		var num = rnd.Next(1, 11); //declares the variable num as a random number between between 0 and 11 (min is 1, max is 10)
		Console.WriteLine("Guess a number from 1 to 10"); //user stuff
		var i = 0; //i starts out as 0 
		
		while (i < 1) //as long as i is less than 1, this loop will keep going (0 = false, 1 = true)
		{
			int user = Convert.ToInt32(Console.ReadLine()); //converts the user's input from a string to an integer and declares variable user
			if (user == num) //if user is equal to num, then the below will happen
			{
				Console.Write(num + " is correct! Well done!"); //the correct answer was given
				i++; //adds 1 to i, making it equal to 1. Now true. Turns off the loop
			}
			else //as long as user != num,
			{
				Console.WriteLine("Incorrect. Try again."); //prompts the user to start again and the loop starts over from the top
			}
		}
	}
}
