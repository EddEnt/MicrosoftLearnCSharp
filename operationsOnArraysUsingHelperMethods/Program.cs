//Unit 5 of 10

string pangram = "The quick brown fox jumps over the lazy dog";

string[] pangramsSplit = pangram.Split(' ');
//foreach (var item in pangramsSplit)
//{
//    Console.WriteLine(item);
//}

for (int i = 0; i < pangramsSplit.Length; i++)
{
    pangramsSplit[i] = new string(pangramsSplit[i].Reverse().ToArray());
    //Console.WriteLine(pangramsSplit[i]);
}

string pangramRejoin = string.Join(" ", pangramsSplit);
Console.WriteLine(pangramRejoin);

//foreach (var item in pangramsSplit)
//{
//    Console.WriteLine(item);
//}

//OR

    string pangramMicrosoft = "The quick brown fox jumps over the lazy dog";

    // Step 1
    string[] message = pangramMicrosoft.Split(' ');

    //Step 2
    string[] newMessage = new string[message.Length];

    // Step 3
    for (int i = 0; i < message.Length; i++)
    {
        char[] letters = message[i].ToCharArray();
        Array.Reverse(letters);
        newMessage[i] = new string(letters);
    }

    //Step 4
    string result = String.Join(" ", newMessage);
    Console.WriteLine(result);

//Unit 7 of 10
string orderStream = "B123,C234,A345,C15,B177,G3003,C235,B179";

string[] orderStreamSplit = orderStream.Split(',');
foreach (var item in orderStreamSplit)
{
    Console.WriteLine(item);
}

Array.Sort(orderStreamSplit);
Console.WriteLine("\nSorted");
foreach (var item in orderStreamSplit)
{
    if (item.Length == 4)
    {
        Console.WriteLine(item);
    }
    else 
    { 
        Console.WriteLine(item + "\t - Error"); 
    }
}

