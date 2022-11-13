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

			Assert.Equal(circle.CalculateArea(), expected);
		}

		[Fact]
		public void CircleArea_DoesFollowLimitations()
		{
			Assert.Throws<ArgumentOutOfRangeException>(() => new Circle(-1));
			Assert.Throws<ArgumentOutOfRangeException>(() => new Circle(Circle.MAX_ALLOWED_RAD_VALUE * 10));
			Assert.Throws<ArgumentOutOfRangeException>(() => new Circle(Circle.MAX_ALLOWED_RAD_VALUE * 1.1));
		}
	}
}