namespace MyOverwrite;

public class MyPoint
{
	public int X { get; set; }
	public int Y { get; set; }

	public MyPoint(int x, int y)
	{
		X = x;
		Y = y;
	}

	public static MyPoint operator +(MyPoint p1, MyPoint p2)
	{
		return new MyPoint(p1.X + p2.X, p1.Y + p2.Y);
	}

	public static MyPoint operator -(MyPoint p1, MyPoint p2)
	{
		return new MyPoint(p1.X - p2.X, p1.Y - p2.Y);
	}
}