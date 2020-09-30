using System;
using System.Collections.Generic;
using System.Text;

namespace cccsharp
{
    public delegate void ShowTest(int value);
    public class Counter
    {
        public event ShowTest tick;
        public void start(int count)
        {
            for (int j = 1000; count != 0; --j, --count)
            {
                if (j == 0)
                {
                    j = 1000;
                    if(tick != null)
                    {
                        tick(count);
                    }
                }
            }
        }
    }
}
