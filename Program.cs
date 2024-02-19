namespace MyOverwrite;

public class Program
{
	public static void Main(string[] args)
	{
		System.Console.WriteLine("Hello world ♥");

		MyPoint point1 = new MyPoint(1000, 28);
		MyPoint point2 = new MyPoint(7, 228);

		MyPoint point3 = point1 + point2;
		Console.WriteLine($"{point3.X}, {point3.Y}");

		MyPoint point4 = point1 - point2;
		Console.WriteLine($"{point4.X}, {point4.Y}");
	}
}