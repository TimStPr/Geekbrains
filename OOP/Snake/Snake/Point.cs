using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Point
    {
        public int PositionX;
        public int PositionY;
        public char Symbol;

        public void DrawSymbol()
        {
            Console.SetCursorPosition(PositionX, PositionY);
            Console.Write(Symbol);
        }
    }
}
