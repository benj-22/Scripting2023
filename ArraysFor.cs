using System;
					
public class Program
{
	public static void Main()
	{
		string[] playerTypes = {"Pawn", "Pawn", "Pawn", "Pawn"}; //playerTypes is the array
		
		for(var i = 0; i < playerTypes.Length; i++){ //i starts checking at 0 space in array; is i > the length of the list?; if it is, add 1 to i
			playerTypes[i] = "Queen"; //this makes it so "i" is however long the array is
		}
		
		foreach(var playerType in playerTypes){ //using the "in" keyword to specify where to get the variable
			Console.WriteLine(playerType);//foreach is read only and not write
		}
	}
}
