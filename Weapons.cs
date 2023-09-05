using System;
					
public class Program
{
	public Weapon miniGun;
	public PowerUp weaponPowerUp;
	
	public void Main()
	{
		miniGun = new Weapon();
		weaponPowerUp = new PowerUp();
		
		miniGun.ammoCount += 30;
		miniGun.firePower += weaponPowerUp.powerLevel;
		Console.WriteLine(miniGun.weaponName + ": ammo count = " + miniGun.ammoCount);
		Console.WriteLine("Minigun's firepower is now " + miniGun.firePower + ": POWER UP!!!");
	}
}

public class Weapon {
	public int ammoCount = 10;
	public string weaponName = "Mini Gun";
	public float firePower = 11.5f;
}

public class PowerUp {
	public float powerLevel = 2.5f;
}
