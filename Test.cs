using ScottPlot;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ArmorPenetration {
	class Test {
		public double[] ArmorDensityPenetration(Armor armor, Projectile projectile)
		{
			List<float> armor_density_list = new List<float>();
			List<float> penetration_list = new List<float>();

			foreach (float value in Enumerable.Range(50, 150))
			{
				armor.density = value / 10;
				armor_density_list.Add(armor.density);

				float penetration = armor.CalculatePenetrationDepth(armor, projectile);
				penetration_list.Add(penetration);
			}
			double[] armor_density = armor_density_list.Select(x => (double)x).ToArray();
			double[] penetration_array = penetration_list.Select(x => (double)x).ToArray();

			try {
				var plt = new ScottPlot.Plot(400, 300);
				plt.AddScatter(armor_density, penetration_array);
				plt.SaveFig("Tests/PenetrationArmorDensityTest.png");
			}

			catch (System.Exception)
			{
				Console.WriteLine("Is libgdiplus missing?");
			}

			return penetration_array;
		}
		public double[] ProjectileDensityPenetration(Armor armor, Projectile projectile) 
		{
			List<float> projectile_density_list = new List<float>();
			List<float> penetration_list = new List<float>();

			foreach (float value in Enumerable.Range(50, 150))
			{
				projectile.density = value / 10;
				projectile_density_list.Add(projectile.density);

				float penetration = armor.CalculatePenetrationDepth(armor, projectile);
				penetration_list.Add(penetration);
			}
			double[] projectile_density = projectile_density_list.Select(x => (double)x).ToArray();
			double[] penetration_array = penetration_list.Select(x => (double)x).ToArray();

			try {
				var plt = new ScottPlot.Plot(400, 300);
				plt.AddScatter(projectile_density, penetration_array);
				plt.SaveFig("Tests/PenetrationProjectileDensityTest.png");
			}

			catch (System.Exception)
			{
				Console.WriteLine("Is libgdiplus missing?");
			}

			return penetration_array;
		}
		public double[] AngleTest(Armor armor, Projectile projectile)
		{
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

			try
			{
				var plt = new ScottPlot.Plot(400, 300);
				plt.AddScatter(projectile_angle_array, effective_armor_thickness_array);
				plt.SaveFig("Tests/AngleTest.png");
			}

			catch (System.Exception)
			{
				Console.WriteLine("Is libgdiplus missing?");
			}

			return effective_armor_thickness_array;
		}
	}
}