using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Linq
{
    class Program
    {
        static void Main(string[] args)
        {
            String path = @"C:\temp\t.txt";
            String fileData;
            fileData = File.ReadAllText(path);
            var l = from n in fileData
                    where n == 'l'
                    select n;
            Console.WriteLine(l.Count());
            //int[] numbers = new int[] { 97, 92, 81, 60, 92, 81, 81, 60, 92, 81, 60, 92, 81, 81, 60, 92, 81, 60, 92, 81, 60, 92, 81, 60, 92, 81, 60, 92, 81, 60, 2, 4, 2, 4, 2, 4, 2, 4, 2, 4, 2, 4, 2, 4 };

            // Define the query expression.
            //IEnumerable<int> scoreQuery =
            //    from score in scores
            //    where score > 80
            //    select score;

            // Execute the query.
            //foreach (int i in /*scoreQuery*/)
            //{
            //    Console.Write(i + " ");
            //}


            // Output: 97 92 81
        }
    }
}
