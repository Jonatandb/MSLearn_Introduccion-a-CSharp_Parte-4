
Console.Clear();

/*
// Using Sort and Reverse:
string[] pallets = { "B14", "A11", "B12", "A13" };

Console.WriteLine("Sorted...");
Array.Sort(pallets);
foreach (var pallet in pallets)
{
    Console.WriteLine($"-- {pallet}");
}

Console.WriteLine("");
Console.WriteLine("Reversed...");
Array.Reverse(pallets);
foreach (var pallet in pallets)
{
    Console.WriteLine($"-- {pallet}");
}
*/


/*
// Using Clear()
string[] pallets = { "B14", "A11", "B12", "A13" };

Console.WriteLine($"Before 'Clear()' -> pallets[0]: {pallets[0].ToLower()}");

Array.Clear(pallets, 0, 2); // Turn 2 first elements into null

if(pallets[0] != null) // Without this check, an exception is raised trying to call .ToLower() in null
	Console.WriteLine($"After: {pallets[0].ToLower()}");

Console.WriteLine($"Clearing 2... count: {pallets.Length}");
foreach (var pallet in pallets)
{
    Console.WriteLine($"-- {pallet}");
	// if(pallet == "") System.Console.WriteLine("Empty");
	// if(pallet == null) System.Console.WriteLine("Null");
}
*/


/*
// Using Resize
string[] pallets = { "B14", "A11", "B12", "A13" };

Array.Clear(pallets, 0, 2);
Console.WriteLine($"Clearing 2... count: {pallets.Length}");
foreach (var pallet in pallets)
{
    Console.WriteLine($"-- {pallet}");
}

Console.WriteLine("");
Array.Resize(ref pallets, 6);
Console.WriteLine($"Resizing 6... count: {pallets.Length}");

pallets[4] = "C01";
pallets[5] = "C02";

foreach (var pallet in pallets)
{
    Console.WriteLine($"-- {pallet}");
}

Console.WriteLine("");
Array.Resize(ref pallets, 3);
Console.WriteLine($"Resizing 3... count: {pallets.Length}");

foreach (var pallet in pallets)
{
    Console.WriteLine($"-- {pallet}");
}
*/

/*
Estas son algunas ideas importantes que se han abordado en esta unidad:

Use el método Clear() para vaciar los valores de los elementos de la matriz.
Use el método Resize() para cambiar el número de elementos de la matriz, ya sea quitando o agregando elementos del final de la matriz.
Los elementos de matriz, tanto los nuevos como los borrados, son nulos, lo que significa que no apuntan a un valor en memoria.
*/

