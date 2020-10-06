using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Text;

namespace Trc
{
    class TraceMailSender : TraceListener
    {
        UInt64 logsCount = 0;
        List<String> list = new List<String>();
        public override void Write(string message)
        {
            Console.Write(message);
        }

        public override void Flush()
        {
            ++logsCount;
            File.WriteAllLines($"Temp//Lock{logsCount}.txt", list);
            list.Clear();
        }

        public override void WriteLine(string message)
        {
            if(!Directory.Exists("Temp"))
            {
                Directory.CreateDirectory("Temp");
            }
            list.Add(message);
            if(list.Count == 50)
            {
                ++logsCount;
                File.WriteAllLines($"Temp//Lock{logsCount}.txt", list);
                list.Clear();
            }

        }
    }
}
