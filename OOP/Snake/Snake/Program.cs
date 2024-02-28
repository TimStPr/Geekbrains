using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            int PositionX = 1;
            int PositionY = 1;
            char Symbol = '*';

            DrawSymbol(PositionX, PositionY, Symbol);

            Console.ReadLine();
        }

        static void DrawSymbol(int PositionX, int PositionY, char Symbol)
        {
            Console.SetCursorPosition(PositionX, PositionY);
            Console.Write(Symbol);
        }
    }
}