/*
 * Project: Implement a propotype of a time-to-live cache.
 * Purpose: Used in the Lead/Senior Software Engineer interview process for innRoad (https://www.innroad.com/).
 * Author: Adalberto Santos.
 * Date: March/03/2022.
 * 
 * Additional notes: Given a 2-d array of integers of size n x 2 data, data() represents that the ith data point was inserted into the cache at time data[i][0].
 *It lives in the cache for a time. Sum the values of data, and it`ll get the total time.
 *Example Suppose n= 3, data = [[105231, 183], [105334, 34], [105198, 543]], q= 2, and queries = [105338, 105410]. Result = [3, 2].
 *
 */



using System;
using System.Collections.Generic;
using System.Text; 


internal class Program
{
    private static void Main(string[] args)
    {
        
        List<List<int>> data = new List<List<int>> ();
        List<int> queries = new List<int> ();

        data.Add( new List<int> { 105231, 183 });
        data.Add( new List<int> { 105334, 34 });
        data.Add( new List<int> { 105198, 543 });

        queries.Add(105338);
        queries.Add(105410);

        List<int> counts = CacheCalculation.getCacheSize(data, queries);

        foreach (var i in counts) Console.WriteLine (i);

    }
}

