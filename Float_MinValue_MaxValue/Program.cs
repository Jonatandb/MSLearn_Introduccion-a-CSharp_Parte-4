
/*
	Por lo tanto, float y double son útiles porque los números grandes se pueden
	almacenar con una superficie de memoria pequeña; con todo, conviene usar float
	y double únicamente cuando resulte útil una aproximación. Por ejemplo, una
	variación de unos miles al calcular la salpicadura de una bola de nieve en
	un videojuego no influye mucho.

	Si necesita una respuesta más precisa, debe usar un valor decimal.
	Cada valor de tipo decimal tiene una superficie de memoria relativamente grande,
	pero la realización de operaciones matemáticas proporciona un resultado más preciso.
	Por lo tanto, debe usar decimal al trabajar con datos financieros o con cualquier
	escenario en el que necesite el resultado exacto de un cálculo.
*/

Console.Clear();

Console.WriteLine("Floating point types:\n");

Console.WriteLine($"float  : {float.MinValue} to {    float.MaxValue} (with ~6-9 digits of precision)");
Console.WriteLine($"double : {double.MinValue} to {  double.MaxValue} (with ~15-17 digits of precision)");
Console.WriteLine($"decimal: {decimal.MinValue} to {decimal.MaxValue} (with 28-29 digits of precision)");

System.Console.WriteLine("\nTest: 1.32 / 4.12:");
System.Console.WriteLine("As Float:   " + 1.32F / 4.12F);
System.Console.WriteLine("As Double:  " + 1.32 / 4.12);
System.Console.WriteLine("As Decimal: " + 1.32M / 4.12M);