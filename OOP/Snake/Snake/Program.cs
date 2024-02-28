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
            Point p1 = new Point();

            p1.PositionX = 1;
            p1.PositionY = 2;
            p1.Symbol = '*';
            p1.DrawSymbol();

            Console.ReadLine();
        }
    }
}