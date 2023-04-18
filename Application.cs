using System;

class Application {
	
  	public static void Main (string[] args) {
    	// Console.WriteLine ("Hello World");
		
		Armor armor = new Armor();
		armor.thickness = 50.0f;
		armor.density = 7.86f;

		Projectile ShermanProjectile = new Projectile();
		ShermanProjectile.length = 0.35f;
		ShermanProjectile.velocity = 450f;
		ShermanProjectile.density = 10f;
		
		Console.WriteLine("Projectile Penetrated (m):");
		Console.WriteLine(armor.CalculatePenetrationDepth(armor, ShermanProjectile));

		Test test = new Test();
		test.ArmorDensityPenetration(armor, ShermanProjectile);
		test.AngleTest(armor, ShermanProjectile);
  	}
}
