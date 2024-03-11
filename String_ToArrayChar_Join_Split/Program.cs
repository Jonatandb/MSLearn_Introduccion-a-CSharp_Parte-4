Console.Clear();

string name = "Jonatandb";

char[] lettersArray = name.ToCharArray();

Array.Reverse(lettersArray);

string reversedName = new(lettersArray);
Console.WriteLine(reversedName);

string result = string.Join(",", lettersArray);
Console.WriteLine(result);

string[] letters = result.Split(",");
foreach (string letter in letters) {
	Console.WriteLine(letter);
}
