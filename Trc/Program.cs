using System;
using System.Diagnostics;

namespace Trc
{
    class Program
    {
        static void Main(string[] args)
        {
            TraceMailSender traceMailSender = new TraceMailSender();
            //Trace.Listeners.Add(traceMailSender);
            //Trace.WriteLine("trace ");
            for(int i = 0; i < 175; ++i)
            {
                traceMailSender.WriteLine("Hello world" + i);
            }
            traceMailSender.Flush();
        }
    }
}
