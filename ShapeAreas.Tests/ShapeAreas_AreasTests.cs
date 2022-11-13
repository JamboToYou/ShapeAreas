namespace ShapeAreas.Tests
{
	public class ShapeAreas_AreasTests
	{
		[Theory]
		[InlineData(0, 0)]
		[InlineData(1, Math.PI)]
		[InlineData(4, Math.PI * 16)]
		[InlineData(double.MaxValue, Math.PI * double.MaxValue * double.MaxValue)]
		public void CircleArea_CanCalculate(double rad, double expected)
		{
			var circle = new Circle(rad);

			Assert.Equal(circle.CalculateArea(), expected);
		}

		[Fact]
		public void CircleArea_DoesFollowLimitations()
		{
			Assert.Throws<ArgumentException>(() => new Circle(-1));
		}
	}
}