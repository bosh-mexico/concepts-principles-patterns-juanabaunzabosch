using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<string> names = GetNames();
        List<string> filteredNames = GetNamesStartingWith(names, 'M');

        PrintNames("Names starting with 'M':", filteredNames);
    }

    static List<string> GetNames()
    {
        return new List<string>
        {
            "Bosch", "Mexico", "Mango", "Mark", "Blr", "Clean code"
        };
    }

    static List<string> GetNamesStartingWith(List<string> names, char initial)
    {
        List<string> result = new List<string>();

        foreach (string name in names)
        {
            if (!string.IsNullOrEmpty(name) && name.StartsWith(initial.ToString()))
            {
                result.Add(name);
            }
        }

        return result;
    }

    static void PrintNames(string title, List<string> names)
    {
        Console.WriteLine(title);
        foreach (string name in names)
        {
            Console.WriteLine(name);
        }
    }
}
