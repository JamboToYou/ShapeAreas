namespace ShapeAreas
{
	public class Circle : Shape
	{
		// sqrt(max(double) / PI)
		public const double MAX_ALLOWED_RAD_VALUE = 7.564545572282618E+153;

		private double _radius;
		public double Radius => _radius;

		/// <summary>
		/// Creates a Circle with given radius
		/// </summary>
		/// <param name="radius">Length of radius for target circle shape. Allowed range: [0, 7.564545572282618E+153] (<see cref="MAX_ALLOWED_RAD_VALUE"/>)</param>
		/// <exception cref="ArgumentOutOfRangeException">Raised when <paramref name="radius"/> is out of allowed values range </exception>
		public Circle(double radius)
		{
			if (radius < 0)
				throw new ArgumentOutOfRangeException($"Radius value must be positive. Allowed range for the \"{nameof(radius)}\" argument: [0, {MAX_ALLOWED_RAD_VALUE}]");

			if (radius > MAX_ALLOWED_RAD_VALUE)
				throw new ArgumentOutOfRangeException($"Value exceeds type boundaries. Allowed range for the \"{nameof(radius)}\" argument: [0, {MAX_ALLOWED_RAD_VALUE}]");

			_radius = radius;
		}

		public override double CalculateArea() => Math.PI * Radius * Radius;
	}
}
