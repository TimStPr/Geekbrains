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
            Point p1 = new Point(1,2,'*');
            p1.DrawSymbol();

            Point p2 = new Point(4, 5, '*');
            p1.DrawSymbol();

            HorizontalLine horizontalLine = new HorizontalLine(1,10,1,'_');
            horizontalLine.Draw();

            VerticalLine verticalLine = new VerticalLine(1,2,10,'|');
            verticalLine.Draw();

            Console.ReadLine();
        }
    }
}