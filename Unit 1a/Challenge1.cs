using System;
					
public class Program{

	public Character hero;
	public Environment timeOfDay;
	public Enemy mush;
	
	public void Main(string[] args){
		
	//effects
		
		

	//objects

		hero = new Character();
		timeOfDay = new Environment();
		mush = new Enemy();
		
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
		
		Console.WriteLine("Oh no! It's an enemy!");
		Console.WriteLine("Enemy Mushroom has appeared!!");
		Console.WriteLine("Enemy health: " + mush.mushHealth);
		Console.WriteLine("Enemy attack: " + mush.mushAtk);
		Console.WriteLine("Enemy defense: " + mush.mushDef);
		Console.WriteLine("Enemy speed: " + mush.mushSpd);
		Console.Write("Quick! You must defeat it! Type any button to attack: ");
		Console.ReadLine();
		
		int notEffect = hero.atk / 2;
		int mushHealthN = mush.mushHealth - notEffect;
		
		Console.WriteLine("It isn't very effective :(");
		Console.WriteLine("Mushroom's Health: " + mushHealthN);
		Console.WriteLine("Mushroom's turn. Mushroom attacks.");
		Console.WriteLine("A critical hit!!");
		
		int mushCrit = mush.mushAtk * 2;
		int heroHpN = hero.heroHealth - mushCrit;
			
		Console.WriteLine(heroName + "'s health: " + heroHpN);
		Console.Write(heroName + "'s turn. Attack? ");
		Console.ReadLine();
		
		int mushHealthN2 = mushHealthN - notEffect;
		
		Console.WriteLine("It isn't very effective :(");
		Console.WriteLine("Mushroom's Health: " + mushHealthN2);
		Console.WriteLine("Mushroom's turn. Mushroom attacks.");
		Console.WriteLine("A critical hit!!");
		
		int heroHpN2 = heroHpN - mushCrit;
		Console.WriteLine(heroName + "'s health: " + heroHpN2);
		Console.Write(heroName + "'s turn. Use a potion? ");
		Console.ReadLine();
		
		int heroHpP = heroHpN2 + 15;
		
		Console.WriteLine(heroName + "'s health: " + heroHpP);
		Console.WriteLine("Mushroom's turn. Mushroom is allergic to potions!!");
		Console.WriteLine("A critical hit!!");
		
		int mushHealthN3 = 0;
		
		Console.WriteLine("Mushroom's Health; " + mushHealthN3);
		Console.WriteLine("Mushroom defeated!");
		Console.Write("How many levels would you like to increase? ");
		int intTemp = Convert.ToInt32(Console.ReadLine());
		
		int levUp = hero.lev + intTemp; 
		Console.WriteLine("Congrats! You are now level " + levUp);

	}
	
	public class Character{
        
		public int heroHealth = 33;
		public int atk = 5;
		public int def = 5;
		public int spd = 4;
		public int lev = 1;
		
	}

	public class Environment{

		public bool day = true;
	}
	
	public class Enemy{
		
		public int mushHealth = 20;
		public int mushAtk = 3;
		public int mushDef = 2;
		public int mushSpd = 4;
	}
}