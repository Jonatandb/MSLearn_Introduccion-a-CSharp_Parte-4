
using System.Globalization;
internal class Program
{
	private static void Main(string[] args)
	{
		CultureInfo.CurrentCulture = new CultureInfo("en-US");

		Console.Clear();

		// string value = "123";
		// int result = 0;
		// if (int.TryParse(value, out result))
		// {
		// 	System.Console.WriteLine($"Result: {result}");
		// }
		// else
		// {
		// 	System.Console.WriteLine($"Unable to parse {value}");
		// }


		// string[] values = { "12.3", "45", "ABC", "11", "DEF" };
		// string finalStr = "";
		// decimal total = 0;
		// foreach (string value in values)
		// {
		// 	decimal partialNumber = 0;
		// 	if (decimal.TryParse(value, out partialNumber))
		// 	{
		// 		// System.Console.WriteLine($"Sumando {partialNumber} a {total}...");
		// 		total += partialNumber;
		// 	}
		// 	else
		// 	{
		// 		finalStr += value;
		// 	}
		// }
		// System.Console.WriteLine($"Message: {finalStr}");
		// System.Console.WriteLine($"Total: {total}");

		int value1 = 12;
		decimal value2 = 6.2m;
		float value3 = 4.3f;

		// int result1 = value1 / (int)value2; // My solution.
		// The Convert class is best for converting the fractional decimal numbers into whole integer numbers
		// Convert.ToInt32() rounds up the way you would expect.
		int result1 = Convert.ToInt32((decimal)value1 / value2);
		// Hint: You need to round the result to nearest integer (don't just truncate)
		Console.WriteLine($"Divide value1 by value2, display the result as an int: {result1}");

		decimal result2 = value2 / (decimal)value3;
		Console.WriteLine($"Divide value2 by value3, display the result as a decimal: {result2}");

		float result3 = value3 / value1;
		Console.WriteLine($"Divide value3 by value1, display the result as a float: {result3}");
	}
}