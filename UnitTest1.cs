#nullable enable
namespace MyOverwrite;

public class MyPointTests
{
	[Fact]
	public void Add_Points_ShouldAddXandY()
	{
		// Arrange
		var point1 = new MyPoint(3, 5);
		var point2 = new MyPoint(2, 4);

		// Act
		var result = point1 + point2;

		// Assert
		Assert.Equal(5, result.X);
		Assert.Equal(9, result.Y);
	}

	[Fact]
	public void Subtract_Points_ShouldSubtractXandY()
	{
		// Arrange
		var point1 = new MyPoint(10, 20);
		var point2 = new MyPoint(5, 10);

		// Act
		var result = point1 - point2;

		// Assert
		Assert.Equal(5, result.X);
		Assert.Equal(10, result.Y);
	}
}