using ScottPlot;
using System;
using System.Collections.Generic;
using System.Linq;

class Test {
	public void ArmorDensityPenetration()
	{
        List<float> armor_density_list = new List<float>();
        List<float> penetration_list = new List<float>();

        Armor armor = new Armor();
		Projectile projectile = new Projectile();

		foreach (float value in Enumerable.Range(50, 150))
		{
			armor.density = value / 10;
			armor_density_list.Add(armor.density);

			float penetration = armor.CalculatePenetrationDepth(armor, projectile);
			penetration_list.Add(penetration);
		}
		double[] armor_density = armor_density_list.Select(x => (double)x).ToArray();
		double[] penetration_array = penetration_list.Select(x => (double)x).ToArray();

		var plt = new ScottPlot.Plot(400, 300);
		plt.AddScatter(armor_density, penetration_array);

		try
		{
			plt.SaveFig("Tests/PenetrationTest.png");
		}

		catch (System.Exception)
		{
			Console.WriteLine("Error writing image file");
		}
	}
	public void AngleTest()
	{
		Armor armor = new Armor();
		Projectile projectile = new Projectile();

		List<float> projectile_angle_list = new List<float>();
		List<float> effective_armor_thickness_list = new List<float>();

		foreach (float value in Enumerable.Range(0,60))
		{
			projectile.angle = value;
			projectile_angle_list.Add(projectile.angle);

			float armor_thickness = armor.CalculateEffectiveArmor(armor, projectile);
			effective_armor_thickness_list.Add(armor_thickness);
		}
        double[] projectile_angle_array = projectile_angle_list.Select(x => (double)x).ToArray();
        double[] effective_armor_thickness_array = effective_armor_thickness_list.Select(x => (double)x).ToArray();

        var plt = new ScottPlot.Plot(400, 300);
        plt.AddScatter(projectile_angle_array, effective_armor_thickness_array);

        try
        {
            plt.SaveFig("Tests/AngleTest.png");
        }

        catch (System.Exception)
        {
            Console.WriteLine("Error writing image file");
        }
    }
}