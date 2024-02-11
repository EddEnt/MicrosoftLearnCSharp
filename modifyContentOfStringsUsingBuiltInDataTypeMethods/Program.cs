const string input = "<div><h2>Widgets &trade;</h2><span>5000</span></div>";

string quantity = "";
string output = "";

int openingSpan = input.IndexOf("<span>");
int closingSpan = input.IndexOf("</span>");

openingSpan += 6;

int spanLength = closingSpan - openingSpan;
quantity = input.Substring(openingSpan, spanLength);

Console.WriteLine($"Quantity: {quantity}");

string trademark = "&trade;";
string registeredTrademark = "&reg;";
output = input.Replace(trademark, registeredTrademark);

int openingDiv = output.IndexOf("<div>");
if (openingDiv != -1)
{
    output = output.Remove(openingDiv, 5);
}

int closingDiv = output.IndexOf("</div>");
if (closingDiv != -1)
{
    output = output.Remove(closingDiv, 6);
}

Console.WriteLine(output);
