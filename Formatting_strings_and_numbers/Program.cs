// string.Format
//string _first = "Hello";
//string _second = "World";
//string result = string.Format("{0} {1}!", _first, _second);
//Console.WriteLine(result);


// Using $ for string interpolation
//string first = "Hello";
//string second = "World";
//Console.WriteLine($"{first} {second}!");
//Console.WriteLine($"{second} {first}!");
//Console.WriteLine($"{first} {first} {first}!");

// Formatting numbers as currencies
decimal price = 123.45m;
int discount = 50;
Console.WriteLine($"Price: {price:C} (Save {discount:C})");