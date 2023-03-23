    using System;
    using System.Collections.Generic;



    public class CacheCalculation
    {

        public static List<int> getCacheSize(List<List<int>> data, List<int> queries)
        {

            List<int> counts = new List<int>();
            int j;

            for ( int i = 0 ; i < queries.Count(); i++)
            {

            j = 0;    
                
                foreach (List<int> subList in data)
                {
                    if (subList.Sum() > queries[i]) j++;
                } 
                 counts.Add(j);    
            }

        



                /*
                foreach (int item in subList)
                {
                    item.Sum()
                }
            */


        




            /*
                        int i = 0;
                        foreach (int query in queries)
                        {
                            while (i < data.Count && data[i][0] <= query)
                            {
                                ttlCache.Insert(i, data[i][1], data[i][0]);
                                i++;
                            }
                            int count = 0;
                            foreach (int key in new List<int>(ttlCache.Keys))  // Iterate over a copy of keys
                            {
                                int? value = ttlCache.Get(key, query);
                                if (value != null)
                                {
                                    count++;
                                }
                            }
                            counts.Add(count);
                        }
            */


            return counts;
        }

    }

