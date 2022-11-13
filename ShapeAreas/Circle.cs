namespace ShapeAreas
{
	public class Circle : Shape
	{
		private double _radius;
		public double Radius => _radius;

		public Circle(double radius)
		{
			_radius = radius;
		}

		public override double CalculateArea() => Math.PI * Radius * Radius;
	}
}
