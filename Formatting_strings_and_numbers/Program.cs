// https://learn.microsoft.com/es-es/training/modules/csharp-format-strings/2-string-formatting-basics

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
//decimal price = 123.45m;
//int discount = 50;
//Console.WriteLine($"Price: {price:C} (Save {discount:C})");
////	Price: $ 123,45 (Save $ 50,00)

// Formatting decimal numbers
//decimal measurement = 123456.78912m;
//Console.WriteLine($"Measurement: {measurement:N} units");
////	Measurement: 123.456,79 units
//Console.WriteLine($"Measurement: {measurement:N4} units");
////	Measurement: 123.456,7891 units


//// Formatting percentage numbers
//decimal tax = .36785m;
//Console.WriteLine($"Tax rate: {tax:P2}");
////	Tax rate: 36,79 %


decimal price = 67.55m;
decimal salePrice = 59.99m;

string yourDiscount = String.Format("You saved {0:C2} off the regular {1:C2} price. ", (price - salePrice), price);

decimal percentage = (price - salePrice) / price;

yourDiscount += $"A discount of {percentage:P2}!"; //inserted
Console.WriteLine(yourDiscount);

/*
	C	currency
	N	decimal with point to delimiter hundred, thousand, etc
	P	percentage
 */