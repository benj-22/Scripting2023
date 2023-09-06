using System;
					
public class Program{

	public Character hero;
	public Environment timeOfDay;
	
	public void Main(string[] args){

	//objects

		hero = new Character();
		timeOfDay = new Environment();
		
	//program

		Console.WriteLine("What is your name?");
		string heroName = Console.ReadLine();
		
		Console.WriteLine("Welcome to " + heroName + "'s Adventure!");
		Console.WriteLine("Health: " + hero.heroHealth);
		Console.WriteLine("Attack: " + hero.atk);
		Console.WriteLine("Defense: " + hero.def);
		Console.WriteLine("Speed: " + hero.spd);
		
	if(timeOfDay.day == true){

		Console.WriteLine("It is currently daytime.");
	}
		
	}
	
	public class Character{
        
		public float heroHealth = 33.3f;
		public int atk = 5;
		public int def = 5;
		public int spd = 4;
		
	}

	public class Environment{

		public bool day = true;
	}
}