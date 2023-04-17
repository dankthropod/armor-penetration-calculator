using System;

class Armor
{
	public float thickness; // in mm
	public float density;
	
    public Armor()
    {
		thickness = 150.0f;
		density = 7.85f;
    }

	public float CalculatePenetration(Armor armor, Projectile projectile) {
		float penetration_depth = projectile.length * (projectile.density/armor.density);
		return penetration_depth;
	}

	public float CalculateEffectiveArmor(Armor armor, Projectile projectile) {
		float effective_armor = armor.thickness/MathF.Cos(projectile.angle);
		return effective_armor;
	}
}
