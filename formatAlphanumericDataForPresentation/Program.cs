

//:C is currency formating. Depending on your language settings,
//  it will display the currency symbol for your region.
decimal price = 123.45m;
int discount = 50;
Console.WriteLine($"Price: {price:C} (Save {discount:C})");

//If your language or region is unknown, :C it will display the currency symbol

//If used with a culture that uses commas as decimal separators, it will display
//use the comma instead of the period.
//  Price: 123,45 € (Save 50,00 €)

//To change to the culture you are targeting, use the CultureInfo class
//https://learn.microsoft.com/en-us/dotnet/api/system.globalization.cultureinfo?view=net-8.0

decimal measurement = 123456.78912m;
Console.WriteLine($"Measurement: {measurement:N} units");
//:N is for number formatting. It will display the number with commas

decimal tax = .36785m;
Console.WriteLine($"Tax rate: {tax:P2}");
//:P is for percentage formatting. It will display the number as a percentage

//Combining the formatting options
decimal prices = 67.55m;
decimal salePrice = 59.99m;

string yourDiscount = String.Format("\nYou saved {0:C2} off the regular {1:C2} price. ", (prices - salePrice), price);

yourDiscount += $"A discount of {((price - salePrice) / price):P2}!"; //inserted
Console.WriteLine(yourDiscount);

Console.WriteLine();
//Unit 3 of 8
int invoiceNumber = 1201;
decimal productShares = 25.4568m;
decimal subtotal = 2750.00m;
decimal taxPercentage = .15825m;
decimal total = 3185.19m;

Console.WriteLine($"Invoice Number: {invoiceNumber}");
Console.WriteLine($"   Shares: {productShares:N3} Product");
Console.WriteLine($"     Sub Total: {subtotal:C}");
Console.WriteLine($"           Tax: {taxPercentage:P2}\n");
Console.WriteLine($"     Total Billed: {total:C}\n");

//Unit 4 of 8
string paymentId = "769C";
string payeeName = "Mr. Stephen Ortega";
string paymentAmount = "$5,000.00";

var formattedLine = paymentId.PadRight(6);
formattedLine += payeeName.PadRight(24);
formattedLine += paymentAmount.PadLeft(10);

Console.WriteLine("1234567890123456789012345678901234567890");
Console.WriteLine(formattedLine);

//Unit 5 of 8
string customerName = "Ms. Barros";

string currentProduct = "Magic Yield";
int currentShares = 2975000;
decimal currentReturn = 0.1275m;
decimal currentProfit = 55000000.0m;

string newProduct = "Glorious Future";
decimal newReturn = 0.13125m;
decimal newProfit = 63000000.0m;

Console.WriteLine($"Dear {customerName}");
Console.WriteLine($"As a customer of our {currentProduct} offering " +
    $"we are excited to tell you about a new financial product that would dramatically " +
    $"increase your return.\n");
Console.WriteLine($"Currently you own {currentShares:N} at a return of {currentReturn:P2}.\n");
Console.WriteLine($"Our new product {newProduct} offers a return of {newReturn:P2}. ");
Console.WriteLine($"Given your current volume, your potential profit would be {newProfit:C}.");

Console.WriteLine("Here's a quick comparison:\n");

string comparisonMessage = "";

comparisonMessage += currentProduct.PadRight(20);
comparisonMessage += $"{currentReturn:P2}".PadRight(10);
comparisonMessage += $"{currentProfit:C}\n";

comparisonMessage += newProduct.PadRight(20);
comparisonMessage += $"{newReturn:P2}".PadRight(10);
comparisonMessage += $"{newProfit:C}\n";

Console.WriteLine(comparisonMessage);