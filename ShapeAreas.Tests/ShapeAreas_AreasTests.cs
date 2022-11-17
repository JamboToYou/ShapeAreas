namespace ShapeAreas.Tests
{
	public class ShapeAreas_AreasTests
	{
		[Theory]
		[InlineData(0, 0)]
		[InlineData(1, Math.PI)]
		[InlineData(4, Math.PI * 16)]
		public void CircleArea_CanCalculate(double rad, double expected)
		{
			var circle = new Circle(rad);

			Assert.Equal(expected, circle.CalculateArea());
		}

		[Fact]
		public void CircleArea_DoesFollowLimitations()
		{
			Assert.Throws<ArgumentOutOfRangeException>(() => new Circle(-1));
			Assert.Throws<ArgumentOutOfRangeException>(() => new Circle(Circle.MAX_ALLOWED_RAD_VALUE * 10));
			Assert.Throws<ArgumentOutOfRangeException>(() => new Circle(Circle.MAX_ALLOWED_RAD_VALUE * 1.1));
		}

		[Theory]
		[InlineData(3, 4, 5, 6)]
		[InlineData(6, 5, 5, 12)]
		[InlineData(0, 100, 100, 0)]
		[InlineData(10, 10, 10, 43.30127018922193)]
		public void TriangleArea_CanCalculate(double edge1, double edge2, double edge3, double expected)
		{
			var triangle = new Triangle(edge1, edge2, edge3);

			// precision could be set in terms of requirements
			Assert.Equal(expected, triangle.CalculateArea(), 13);
		}

		[Fact]
		public void TriangleArea_DoesFollowLimitations()
		{
			Assert.Throws<ArgumentOutOfRangeException>(() => new Triangle(-1, 100, 100));
			Assert.Throws<ArgumentOutOfRangeException>(() => new Triangle(100, -1, 100));
			Assert.Throws<ArgumentOutOfRangeException>(() => new Triangle(100, 100, -1));

			Assert.Throws<ArgumentOutOfRangeException>(() => new Triangle(Triangle.MAX_ALLOWED_EDGE_VALUE * 2, 100, 100));
			Assert.Throws<ArgumentOutOfRangeException>(() => new Triangle(100, Triangle.MAX_ALLOWED_EDGE_VALUE * 2, 100));
			Assert.Throws<ArgumentOutOfRangeException>(() => new Triangle(100, 100, Triangle.MAX_ALLOWED_EDGE_VALUE * 2));
		}

		[Theory]
		[InlineData(3, 4, 5, true)]
		[InlineData(5, 12, 13, true)]
		[InlineData(1, 2, 3, false)]
		public void Triangle_IsRightTriangle(double edge1, double edge2, double edge3, bool expected)
		{
			var triangle = new Triangle(edge1, edge2, edge3);

			Assert.Equal(expected, triangle.IsRightTriangle());
		}
	}
}