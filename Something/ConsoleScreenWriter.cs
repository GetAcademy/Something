using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Something
{
    class ConsoleScreenWriter : IScreenWriter
    {
        public void Write(int x, int y, string txt)
        {
            Console.CursorLeft = x;
            Console.CursorTop = y;
            Console.Write(txt);
        }
    }
}
