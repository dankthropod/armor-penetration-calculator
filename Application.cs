using System;
using System.Xml.Serialization;
using System.IO;

class Application {
	
  	public static void Main (string[] args) {
		// XMLTank sherman = new XMLTank();
		
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

public class XMLTank {
	public XMLTank() {
		ArmorPenetration.Armor armor = new ArmorPenetration.Armor();
		ArmorPenetration.Projectile projectile = new ArmorPenetration.Projectile();

		XMLTank xo = new XMLTank();
		xo.DeserializeArmor("Examples/m4a1.xml", armor);
	}

	ArmorPenetration.Armor DeserializeArmor(string filename, ArmorPenetration.Armor armor) {
		XmlSerializer serializer = new XmlSerializer(typeof(ArmorPenetration.Armor));
		
		using (Stream reader = new FileStream(filename, FileMode.Open))
        {
            // Call the Deserialize method to restore the object's state.
            armor = (ArmorPenetration.Armor)serializer.Deserialize(reader);

        }

		Console.Write(
        armor.thickness + "\t" +
        armor.density + "\t");

		return armor;
	}
}