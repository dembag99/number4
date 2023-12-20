using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{

    public static void Main()
    {
        var numberList = new List<int>();

        int rawNumber;
        bool check;

        do
        {
            var rawEntry = Console.ReadLine();
            check = int.TryParse(rawEntry, out rawNumber);

            if (check == false && rawEntry.ToLowerInvariant() == "quit")
            {
                Console.WriteLine("List contains duplicate values but presented below are only unique numbers:");

                // using Linq
                List<int> distinctList = numberList.Distinct().ToList();
                foreach (var element in distinctList)
                    Console.WriteLine(element);

                break;

            }
            if (check == false)
                Console.WriteLine("To exit type quit or enter more numbers");

            else
                numberList.Add(rawNumber);

        }
        while (true);

    }
}