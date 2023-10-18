using System;
using System.Text.RegularExpressions;

public interface ITextChecker
{
    bool ContainsORCID(string inputText);
}

class TextChecker
{
    public bool ContainsORCID(string inputText)
    {
        string pattern = @"\b[0-9]{4}-[0-9]{4}-[0-9]{4}-[0-9]{3}[0-9X]\b";

        Regex regex = new Regex(pattern);

        return regex.IsMatch(inputText);
    }
}

public class TextCheckerProxy : ITextChecker
{
    private TextChecker realTextChecker = new TextChecker();

    public bool ContainsORCID(string inputText)
    {
        Console.WriteLine("TextCheckerProxy: Before checking ORCID");

        bool result = realTextChecker.ContainsORCID(inputText);

        if (result)
        {
            Console.WriteLine("TextCheckerProxy: ORCID found");
        }
        else
        {
            Console.WriteLine("TextCheckerProxy: No ORCID found");
        }
        return result;
    }
}

class Program
{
    static void Main()
    {
        ITextChecker textChecker = new TextCheckerProxy();
        string inputText = "My ORCID is https://orcid.org/0000-0001-9257-453X.";
        Console.WriteLine(inputText);
        if (textChecker.ContainsORCID(inputText))
        {
            Console.WriteLine("This text contains an ORCID.");
        }
        else
        {
            Console.WriteLine("There is no ORCID in this text.");
        }
    }
}
