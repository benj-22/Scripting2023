using System;
					
public class Program
{
	public Weapon miniGun;
	public PowerUp weaponPowerUp;
	public Characters jimmy;
	
	public void Main()
	{
		miniGun = new Weapon();
		weaponPowerUp = new PowerUp();
		jimmy = new Characters();
		
		Console.WriteLine(jimmy.mainCharacterName + " is you!");
		
		miniGun.ammoCount += 30;
		miniGun.firePower += weaponPowerUp.powerLevel;
		Console.WriteLine(miniGun.weaponName + ": ammo count = " + miniGun.ammoCount);
		Console.WriteLine("Minigun's firepower is now " + miniGun.firePower + ": POWER UP!!! That's Broken!");
	}
}

public class Weapon {
	public int ammoCount = 10;
	public string weaponName = "Mini Gun";
	public float firePower = 11.4f;
}

public class PowerUp {
	public float powerLevel = 35e3f;
}
	
public class Characters {
	public string mainCharacterName = "Jimmy";
}
