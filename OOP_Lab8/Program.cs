using System.Text.RegularExpressions;

class TextChecker
{
    public bool ContainsDigits(string inputText)
    {
        string pattern = @"\d";

        Regex regex = new Regex(pattern);

        return regex.IsMatch(inputText);
    }
}

class Program
{
    static void Main()
    {
        TextChecker textChecker = new TextChecker();
        string inputText = "My name is Pavlo and I am 19 y.o. ";
        Console.WriteLine(inputText);
        if (textChecker.ContainsDigits(inputText))
        {
            Console.WriteLine("This text contains numbers");
        }
        else
        {
            Console.WriteLine("There is no number in this text");
        }
    }
}