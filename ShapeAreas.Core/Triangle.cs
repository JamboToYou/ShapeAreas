namespace ShapeAreas
{
	public class Triangle : Shape
	{
		// sqrt(max(double))
		public const double MAX_ALLOWED_EDGE_VALUE = 1.3407807929942596E+154;

		public double Edge1 { get; private set; }
		public double Edge2 { get; private set; }
		public double Edge3 { get; private set; }

		/// <summary>
		/// Creates a Triangle with given edges
		/// </summary>
		/// <param name="edge1">edge 1</param>
		/// <param name="edge2">edge 2</param>
		/// <param name="edge3">edge 3</param>
		/// <exception cref="ArgumentOutOfRangeException">Raised when one of the edges is out of allowed values range</exception>
		public Triangle(double edge1, double edge2, double edge3)
		{
			if (edge1 < 0 || edge2 < 0 || edge3 < 0)
				throw new ArgumentOutOfRangeException($"Radius value must be positive. Allowed range for the edge argument: [0, {MAX_ALLOWED_EDGE_VALUE}]");

			if (edge1 > MAX_ALLOWED_EDGE_VALUE || edge2 > MAX_ALLOWED_EDGE_VALUE || edge3 > MAX_ALLOWED_EDGE_VALUE)
				throw new ArgumentOutOfRangeException($"Value exceeds type boundaries. Allowed range for the edge argument: [0, {MAX_ALLOWED_EDGE_VALUE}]");

			Edge1 = edge1;
			Edge2 = edge2;
			Edge3 = edge3;
		}

		public override double CalculateArea()
		{
			if (Edge1 == 0 || Edge2 == 0 || Edge3 == 0)
				return 0;

			if (IsRightTriangle())
			{
				var eSq1 = Edge1 * Edge1;
				var eSq2 = Edge2 * Edge2;
				var eSq3 = Edge3 * Edge3;

				double e1;
				double e2;

				if (eSq1 + eSq2 == eSq3)
				{
					e1 = Edge1;
					e2 = Edge2;
				}
				else if (eSq2 + eSq3 == eSq1)
				{
					e1 = Edge2;
					e2 = Edge3;
				}
				else
				{
					e1 = Edge1;
					e2 = Edge3;
				}

				return (e1 * e2) / 2;
			}

			var halfPerim = (Edge1 + Edge2 + Edge3) / 2;

			// sqrt separartion made to fit in type size while calculation
			return
				Math.Sqrt(halfPerim) *
				Math.Sqrt(halfPerim - Edge1) *
				Math.Sqrt(halfPerim - Edge2) *
				Math.Sqrt(halfPerim - Edge3);
		}

		public bool IsRightTriangle()
		{
			var eSq1 = Edge1 * Edge1;
			var eSq2 = Edge2 * Edge2;
			var eSq3 = Edge3 * Edge3;

			return eSq1 + eSq2 == eSq3 || eSq2 + eSq3 == eSq1 || eSq1 + eSq3 == eSq2;
		}
	}
}
