using ScottPlot;
using System.Collections.Generic;
using System.Linq;

class Test {
	Armor armor;
	Projectile projectile;

	List<float> armor_thickness_list = new List<float>();
	List<float> penetration_list = new List<float>();
	
	public void TestPenetration() {
		armor = new Armor();
		projectile = new Projectile();

		foreach (int value in Enumerable.Range(1, 10)){
			armor.thickness = value / 10;
			armor_thickness_list.Add(armor.thickness);

			float penetration = armor.CalculatePenetration(armor, projectile);
			penetration_list.Add(penetration);
		}
		double[] armor_thickness = armor_thickness_list.Select(x=>(double)x).ToArray();
		double[] penetration_array = armor_thickness_list.Select(x=>(double)x).ToArray();
		
		var plt = new ScottPlot.Plot(400,300);
		plt.AddScatter(armor_thickness, penetration_array);

		plt.SaveFig("PenetrationTest.png");
	}
}