using sabatex.Extensions;
using System;
using System.Collections.Generic;
using System.Diagnostics;
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

            fileData.OrderBy(n => n);

            UInt128 uInt128;
            String s;
            
        }
    }
}
