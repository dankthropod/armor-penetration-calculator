namespace ArmorPenetration {
	class Projectile
	{
		public float length; //meters
		public float velocity; // mps
		public float density; // g/cm3

		public float angle; // degrees
		
		public Projectile()
		{
			length = 0.35f; 
			velocity = 450f;
			density = 10f;
			angle = 20f;
		}
	}
}