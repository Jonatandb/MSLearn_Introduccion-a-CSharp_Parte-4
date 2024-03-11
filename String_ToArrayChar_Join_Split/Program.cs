Console.Clear();

//string name = "Jonatandb";

//char[] lettersArray = name.ToCharArray();

//Array.Reverse(lettersArray);

//string reversedName = new(lettersArray);
//Console.WriteLine(reversedName);

//string result = string.Join(",", lettersArray);
//Console.WriteLine(result);

//string[] letters = result.Split(",");
//foreach (string letter in letters) {
//	Console.WriteLine(letter);
//}


// Desafío para invertir las palabras de una oración:
string pangram = "The quick brown fox jumps over the lazy dog";
string finalPhrase = "";
string[] words = pangram.Split(" ");
foreach (string word in words) {
	char[] letters = word.ToCharArray();
	Array.Reverse(letters);
	string reversedWord = string.Join("", letters);
	finalPhrase += reversedWord + " ";
} 
Console.WriteLine(finalPhrase);
