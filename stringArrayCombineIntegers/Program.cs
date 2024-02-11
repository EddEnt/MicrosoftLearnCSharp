//Program for Convert Data Types using Casting and Conversion Techniques in C#
//Unit 5 of 9

string[] values = new string[] { "12.3", "45", "ABC", "11", "DEF" };

decimal total = 0;
string message = "";

foreach (var value in values)
{
    decimal outNumber;

    if (decimal.TryParse(value, out outNumber))
    {
        total += outNumber;
    }
    else
    {
        message += value;
    }
}

Console.WriteLine($"String Message: {message}");
Console.WriteLine($"Decimal Total: {total}");

//Unit 6 of 9

int value1 = 12;
decimal value2 = 6.2m;
float value3 = 4.3f;

// Hint: You need to round the result to nearest integer (don't just truncate)

int result1 = Convert.ToInt32((decimal) value1 / value2);
Console.WriteLine($"Divide value1 by value2, display the result as an int: {result1}");


decimal result2 = value2 / (decimal)value3;
Console.WriteLine($"Divide value2 by value3, display the result as a decimal: {result2}");

float result3 = value3 / (float)value1;
Console.WriteLine($"Divide value3 by value1, display the result as a float: {result3}");