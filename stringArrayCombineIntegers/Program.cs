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