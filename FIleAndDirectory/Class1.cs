using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace FIleAndDirectory
{
    public class HFile
    {
        short strength;
        int money;
        String smth;
        DateTime time;
        public HFile() { strength = 0; money = 0; smth = "Nothing"; time = DateTime.Now; }
        public void Write()
        {
            String path = @"C:\temp\save.txt";
            var writer = new BinaryWriter(File.OpenWrite(path));
            writer.Write(strength);
            writer.Write(money);
            writer.Write(smth);
            writer.Write(time.Ticks);
            writer.Close();
        }

        public void Read()
        {
            String path = @"C:\temp\save.txt";
            var reader = new BinaryReader(File.OpenRead(path));
            var readShort = reader.ReadInt16();
            var readInt = reader.ReadInt32();
            var readChar = reader.ReadChar();
            var readLong = reader.ReadInt64();
            reader.Close();
            Console.WriteLine(readShort);
            Console.WriteLine(readInt);
            Console.WriteLine(readChar);
            Console.WriteLine(readLong);


        }
    }
}
