namespace ShapeAreas
{
	public class Triangle : Shape
	{
		public double Edge1 { get; private set; }
		public double Edge2 { get; private set; }
		public double Edge3 { get; private set; }

		public Triangle(double edge1, double edge2, double edge3)
		{
			Edge1 = edge1;
			Edge2 = edge2;
			Edge3 = edge3;
		}

		public override double CalculateArea()
		{
			var perimeter = Edge1 + Edge2 + Edge3;

			return Math.Sqrt(perimeter * (perimeter - Edge1) * (perimeter - Edge2) * (perimeter - Edge3));
		}

		public bool IsRightTriangle() => Edge1 == Edge2 || Edge2 == Edge3 || Edge1 == Edge3;
	}
}
