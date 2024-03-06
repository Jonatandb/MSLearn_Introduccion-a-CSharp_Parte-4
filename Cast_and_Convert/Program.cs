Console.Clear();

// int num = 100;
// string text = "6";
// string result = num + text;
// System.Console.WriteLine(result);


// ----------------------------------------------------------------
// Conversión de ampliación -> Conversión implícita:
// int myInt = 3;
// Console.WriteLine($"int: {myInt}");

// decimal myDecimal = myInt;
// Console.WriteLine($"decimal: {myDecimal}");


// ----------------------------------------------------------------
// Realización de una coerción,
// mediante el uso del operador de coerción "()"
// -> Conversión explícita:
// decimal myDecimal = 3.14m;
// Console.WriteLine($"decimal: {myDecimal}");

// int myInt = (int)myDecimal;
// Console.WriteLine($"int: {myInt}");


// ----------------------------------------------------------------
// La salida que convertir decimal en float es una conversión de
// restricción, ya que se pierde precisión:
// decimal myDecimal = 1.23456789m;
// float myFloat = (float)myDecimal;

// Console.WriteLine($"Decimal: {myDecimal}"); // 1,23456789
// Console.WriteLine($"Float  : {myFloat}");   // 1,2345679


// ----------------------------------------------------------------
// Uso del método ToString() para convertir explícitamente valores int en string:
// int first = 5;
// int second = 7;
// string message = first.ToString() + second.ToString();
// Console.WriteLine(message);


// ----------------------------------------------------------------
// Conversión de un objeto string en int mediante el método auxiliar Parse():
// string first = "5";
// string second = "7";
// int sum = int.Parse(first) + int.Parse(second);
// Console.WriteLine(sum);


// ----------------------------------------------------------------
// Conversión de un objeto string en int mediante la clase Convert:
// string value1 = "5";
// string value2 = "7";
// int result = Convert.ToInt32(value1) * Convert.ToInt32(value2);
// Console.WriteLine(result);


// ----------------------------------------------------------------
// Comparación de la coerción y conversión de un objeto decimal en int
int value = (int)1.5m; // casting truncates
Console.WriteLine(value);

int value2 = Convert.ToInt32(1.5m); // converting rounds up
Console.WriteLine(value2);
// La coerción trunca y la conversión redondea
// Al coercer int value = (int)1.5m;, se trunca el valor "float" y, por ende,
// el resultado es 1, lo que significa que el valor de después del decimal se
// omite por completo. Podríamos cambiar el "float" literal por 1.999m y el
// resultado de la coerción sería el mismo.

// Al usar Convert.ToInt32() para convertir, el valor "float" literal se redondea
// correctamente a 2. Si cambiáramos el valor literal a 1.499m, se redondearía a 1.