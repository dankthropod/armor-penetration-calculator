using System;

class Armor
{
	public float thickness; // in mm
	public float density;
	public float effective_thickness;
	
    public Armor()
    {
		thickness = 50.0f;
		density = 7.86f;
    }

	public float CalculatePenetrationDepth(Armor armor, Projectile projectile) { // in m
		float penetration_depth = projectile.length * (projectile.density/armor.density);
		return penetration_depth;
	}

	public float CalculateEffectiveArmor(Armor armor, Projectile projectile) {
		float radians_angle = ( MathF.PI / 180 )* projectile.angle;
		float effective_armor = armor.thickness/(MathF.Cos(radians_angle));
		return effective_armor;
	}
}
