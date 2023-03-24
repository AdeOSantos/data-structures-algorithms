/*
 * Project: 
 * Purpose: 
 * Author: Adalberto Santos.
 * Date: 
 * 
 * Additional notes: 
 *
 */



using System;
using System.Collections.Generic;
using System.Text; 
using System.Runtime;

internal class Program
{
    private static void Main(string[] args)
    {
        
        Func<string, bool> hasLength = str => str.Length > 4;

        string[] countries = { "India", "United Kingdom", "US", "China", "Pakistan", "Afghanistan","Rush" };
        IEnumerable<string> country= countries.Where(hasLength);
        foreach (var item in country)
        {
            Console.WriteLine(item);
        }
        Console.ReadLine();

    }
}

