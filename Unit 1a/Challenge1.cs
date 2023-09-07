using System; //these are the commands and variables we will use. script is read from top to bottom
					
public class Program{ //this class deals with all the specifications of the program

	//class objects
	
	public Character hero; //these three declare the objects hero, time of day, and mush exist
	public Environment timeOfDay; //then in "//objects" they are created into objects
	public Enemy mush;
	
	public void Main(string[] args){ //this is used to encapsulate the whole main string

	//objects

		hero = new Character();
		timeOfDay = new Environment();
		mush = new Enemy();
		
	//program (this is where the ridiculous story I created takes place. Where I put all the silly console stuff)

		Console.WriteLine("What is your name?");
		string heroName = Console.ReadLine(); //this is where user input is taken in and named "heroName" as a string variable
		
		Console.WriteLine("Welcome to " + heroName + "'s Adventure!"); //heroName is now the string of characters the user put in
		Console.WriteLine("Health: " + hero.heroHealth); //"hero" for the new Character, and .heroHealth from the Character class section down below
		Console.WriteLine("Attack: " + hero.atk); //these are just taking the integers inputted at the bottom of the script and putting them onto the console
		Console.WriteLine("Defense: " + hero.def); //because they're part of a public class, they can be used regardless of where they are in the order of the script
		Console.WriteLine("Speed: " + hero.spd); //if the integers were in the Program class, they would need to be declared before writing it on the console
		
	if(timeOfDay.day == true){ //my attempt at utilizing the bool variable. in the Environment class section below, it states that the bool "day" is true. Meaning it's always true, since it's declared in a public class like that
		//the new object "timeOfDay" was created earlier, and the bool says it's always day. 
		//this states that if the timeOfDay being day is true, then do this:

		Console.WriteLine("It is currently daytime."); //write on the console to show it is daytime
		//but it's always day, so this doesn't really do anything right now
	}
		
		Console.WriteLine("Oh no! It's an enemy!"); //enemy appears
		Console.WriteLine("Enemy Mushroom has appeared!!");
		Console.WriteLine("Enemy health: " + mush.mushHealth); //this displays the mushroom's stats from the Enemy class down below
		Console.WriteLine("Enemy attack: " + mush.mushAtk); //just like the hero's, the stats are stored as integers
		Console.WriteLine("Enemy defense: " + mush.mushDef); //the '+' puts the value of "mush.mushDef" after the script on the console
		Console.WriteLine("Enemy speed: " + mush.mushSpd);
		Console.Write("Quick! You must defeat it! Type any button to attack: "); //typing "Write" instead of "WriteLine" ensures that the next Console input will be on the same line in the console
		Console.ReadLine(); //this waits for the user to input and then displays the input on the console
		
		int notEffect = hero.atk / 2; //this is declaring a new integer. alternatively, i could've created a new class at the bottom, but that seemed like a lot of work for a short-term project
		//it is creating an integer called "notEffect," which has the value of the hero's attack divided by 2
		int mushHealthN = mush.mushHealth - notEffect; //this uses the new value to determine the mushroom's new Health, or "mushHealthN"
		
		Console.WriteLine("It isn't very effective :("); 
		Console.WriteLine("Mushroom's Health: " + mushHealthN); //displays the mushroom's new health
		Console.WriteLine("Mushroom's turn. Mushroom attacks.");
		Console.WriteLine("A critical hit!!");
		
		int mushCrit = mush.mushAtk * 2; //for the critical hit, the integer "mushCrit" is created. the critical is the mushroom's attack times 2
		int heroHpN = hero.heroHealth - mushCrit; //the hero's new health. or "heroHpN" is equal to the hero's normal health minus the mushroom's new attack
			
		Console.WriteLine(heroName + "'s health: " + heroHpN); //displays the hero's new health points
		Console.Write(heroName + "'s turn. Attack? ");
		Console.ReadLine();
		
		int mushHealthN2 = mushHealthN - notEffect; //i'm sure there was a better way to keep decreasing the mushroom's health than by creating another integer, but it worked for a short script
		//in the future, for a longer script, i will try making this part of a different class
		//i just overthought it and tried a lot of different things, and messed up the code a few times, so this is what i stuck with
		
		Console.WriteLine("It isn't very effective :(");
		Console.WriteLine("Mushroom's Health: " + mushHealthN2);
		Console.WriteLine("Mushroom's turn. Mushroom attacks.");
		Console.WriteLine("A critical hit!!");
		
		int heroHpN2 = heroHpN - mushCrit; //same deal with the critical stats
		Console.WriteLine(heroName + "'s health: " + heroHpN2);
		Console.Write(heroName + "'s turn. Use a potion? ");
		Console.ReadLine();
		
		int heroHpP = heroHpN2 + 15; //when '+' is not included in the Console.Write functions, it serves as an operator to add the two values together
		
		Console.WriteLine(heroName + "'s health: " + heroHpP);
		Console.WriteLine("Mushroom's turn. Mushroom is allergic to potions!!");
		Console.WriteLine("A critical hit!!");
		
		int mushHealthN3 = 0; //just a quick way to kill off the mushroom after showcasing the operations
		
		Console.WriteLine("Mushroom's Health; " + mushHealthN3);
		Console.WriteLine("Mushroom defeated!");
		Console.Write("How many levels would you like to increase? ");
		int intTemp = Convert.ToInt32(Console.ReadLine()); //i looked this one up, so i'm not exactly sure how it works
			//what i do know is that it is converting the 'Console.Readline(),' which typically stores input as script, to an integer
		
		int levUp = hero.lev + intTemp; //since the input is now an integer, the two can be added together
		Console.WriteLine("Congrats! You are now level " + levUp);
		
		int teamMem = 3;
		Console.WriteLine("Party members has increased to " + teamMem);
		Console.WriteLine(heroName + "'s xp will be divided between all party members");

	}
	
	public class Character{ //this is another class where information about the character is stored
        
		public int heroHealth = 33; //integers that determine stats are listed here with variable names. this one is called "heroHealth"
		public int atk = 5; //this one is called "atk"
		public int def = 5; //etc.
		public int spd = 4;
		public int lev = 1;
		
	}

	public class Environment{ //another class but for the environment. i was thinking maybe the environment could effect the 'game,' but something like that will have to wait till i know a bit more

		public bool day = true; //this variable is a "bool," which stores information as long as it's either "true" or "false"
	}
	
	public class Enemy{ //yet another class for the enemy's information
		
		public int mushHealth = 20; //much like the character class, this holds the enemy's stats in integers
		public int mushAtk = 3; //mush is short for mushroom to differentiate between the mushroom and the hero
		public int mushDef = 2;
		public int mushSpd = 4;
	}
}
