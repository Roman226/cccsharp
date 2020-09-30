using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace FIleAndDirectory
{
    class Program
    {
        static List<String> list = new List<String>();
        static int count = 0;

        public static void Recursion(string pathP)
        {
            try
            {
                foreach (string tmp in Directory.EnumerateDirectories(pathP))
                {
                    list.Add(tmp);
                    Recursion(tmp);
                    ++count;
                    Console.WriteLine(count);
                }
            }
            catch
            {

            }
        }
        static void Main(string[] args)
        {
            //String pathV = @"C:\temp";
            //if (Directory.Exists(pathV))
            //{
            //    var i = 0;
            //}
            //else
            //{
            //    Directory.CreateDirectory(pathV);
            //}
            //var pathC = @"C:\";
            //Directory.GetDirectories(pathC);
            //Directory.GetCurrentDirectory();
            //Directory.Delete(path);
            //Console.WriteLine(DateTime.Now);
            //Recursion(pathC);
            //Console.WriteLine(DateTime.Now);
            String path = @"C:\temp\t.txt";
            //File.WriteAllText(path, "Hello world!\nHello World!\nHello world!\n");
            //File.ReadAllText(path);
            //for(int i = 0; i < 100; ++i)
            //{
            //    File.AppendAllText(path, "Hello world!\n");
            //}
            //Console.WriteLine(File.ReadAllText(path));
            //Stream stream;
            //stream = File.OpenRead(path);
            //Console.WriteLine(stream.Length);
            //stream.Position = stream.Length / 2;
            //StringBuilder sb = new StringBuilder();
            //while (stream.CanRead)
            //{
            //    sb.Append((char)stream.ReadByte());
            //}
            //Console.WriteLine(sb.ToString());
            //Directory.Delete(@"C:\temp");

            HFile hf = new HFile();
            hf.Write();
            hf.Read();
        }
    }
}
