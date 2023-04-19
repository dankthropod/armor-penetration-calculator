using System;

class Application {
	
  	public static void Main (string[] args) {
    	// Console.WriteLine ("Hello World");
		
		ArmorPenetration.Armor ShermanArmor = new ArmorPenetration.Armor();
		ShermanArmor.thickness = 50.0f;
		ShermanArmor.density = 7.86f;

		ArmorPenetration.Projectile ShermanProjectile = new ArmorPenetration.Projectile();
		ShermanProjectile.length = 0.35f;
		ShermanProjectile.velocity = 450f;
		ShermanProjectile.density = 10f;
		
		Console.WriteLine("Projectile Penetrated (m):");
		Console.WriteLine(ShermanArmor.CalculatePenetrationDepth(ShermanArmor, ShermanProjectile));

		ArmorPenetration.Test test = new ArmorPenetration.Test();
		test.ArmorDensityPenetration(ShermanArmor, ShermanProjectile);
		test.ProjectileDensityPenetration(ShermanArmor, ShermanProjectile);
		test.AngleTest(ShermanArmor, ShermanProjectile);
  	}
}
