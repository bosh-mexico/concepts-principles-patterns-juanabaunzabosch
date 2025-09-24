using System;
using System.Linq;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<string> names = new List<string>
        {
            "Bosch", "Mexico", "Mango", "Mark", "Blr", "Clean code"
        };

        var namesStartingWithM = names.Where(name => name.StartsWith("M")).ToList();

        Console.WriteLine("Names starting with 'M':");
        foreach (var name in namesStartingWithM)
        {
            Console.WriteLine(name);
        }
    }
}
