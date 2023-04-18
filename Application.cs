using System;

class Application {
	
  	public static void Main (string[] args) {
    	// Console.WriteLine ("Hello World");
		
		Armor armor = new Armor();
		Projectile projectile = new Projectile();
		
		Console.WriteLine("Projectile Penetrated (m):");
		Console.WriteLine(armor.CalculatePenetrationDepth(armor, projectile));

		Test test = new Test();
		test.ArmorDensityPenetration();
		test.AngleTest();
  	}
}
