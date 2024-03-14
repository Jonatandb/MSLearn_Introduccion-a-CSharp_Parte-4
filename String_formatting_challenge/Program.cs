// https://learn.microsoft.com/es-es/training/modules/csharp-format-strings/5-challenge

string customerName = "Ms. Barros";

string currentProduct = "Magic Yield";
int currentShares = 2975000;
decimal currentReturn = 0.1275m;
decimal currentProfit = 55000000.0m;

string newProduct = "Glorious Future";
decimal newReturn = 0.13125m;
decimal newProfit = 63000000.0m;

// Your logic here
string comparisonMessage = "Dear ";
comparisonMessage += customerName + ",\n";
comparisonMessage += $"As a customer of our {currentProduct} offering we are excited to tell you about a new financial product that would dramatically increase your return.\n\n";
comparisonMessage += $"Currently, you won {currentShares:N} shares at a return of {currentReturn:P2}.\n\n";
comparisonMessage += $"Our new product, {newProduct} offers a return of {newReturn:P}.  Given your current volume, your potential profit would be {newProfit:C}.\n\n";
comparisonMessage += "Here's a quick comparison:\n\n";

string currentReturnStr = $"{currentReturn:P2}";
comparisonMessage += $"{currentProduct.PadRight(20)}{currentReturnStr.PadRight(9)}{currentProfit:C}\n";

string newReturnStr = $"{newReturn:P2}";
comparisonMessage += $"{newProduct.PadRight(20)}{newReturnStr.PadRight(9)}{newProfit:C}";
// Your logic here

Console.WriteLine(comparisonMessage);