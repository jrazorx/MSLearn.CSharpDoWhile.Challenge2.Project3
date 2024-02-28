string[] myStrings = new string[2] { "I like pizza. I like roast chicken. I like salad", "I like all three of the menu choices" };

foreach (string myString in myStrings)
{

    int periodLocation = myString.IndexOf(".");

    string mySentence = myString;

    while (periodLocation != -1)
    {
        //Console.WriteLine($"periodLocation : {periodLocation}");
        Console.WriteLine(mySentence.Substring(0, periodLocation).TrimStart());

        mySentence = mySentence.Remove(0, periodLocation + 1);
        periodLocation = mySentence.IndexOf(".");
    }
    Console.WriteLine(mySentence.TrimStart());
}