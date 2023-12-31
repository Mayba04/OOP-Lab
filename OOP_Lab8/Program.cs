﻿using System;
using System.Text.RegularExpressions;

class TextChecker
{
    public bool ContainsORCID(string inputText)
    {
        string pattern = @"\b[0-9]{4}-[0-9]{4}-[0-9]{4}-[0-9]{3}[0-9X]\b";

        Regex regex = new Regex(pattern);

        return regex.IsMatch(inputText);
    }
}

class Program
{
    static void Main()
    {
        TextChecker textChecker = new TextChecker();
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
