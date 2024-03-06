Console.Clear();

// Se puede usar new, pero también se puede omitir y
// simplemente usar: string test = "test";
string test = new string("test");
System.Console.WriteLine(test);


int[] numbers = new int[4];
numbers[2] = 1230;

foreach (int valor in numbers)
{
	Console.Write(valor + " ");
}
