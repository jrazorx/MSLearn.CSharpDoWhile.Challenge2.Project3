string[] myStrings = new string[2] { "I like pizza. I like roast chicken. I like salad", "I like all three of the menu choices" };
int periodLocation;

foreach (string myString in myStrings)
{
    periodLocation = myString.IndexOf(".");
    if (periodLocation == -1)
    {
        Console.WriteLine(myString);
        continue;
    }
}