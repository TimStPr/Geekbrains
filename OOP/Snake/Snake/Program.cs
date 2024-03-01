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
            Console.SetWindowSize(80, 25);

            VerticalLine v1 = new VerticalLine(0, 10, 5, '%');
            Draw(v1);

            Point p = new Point(4, 5, '*');
            Figure fSnake = new Snake(p, 4, Direction.RIGTH);
            Draw(fSnake);
            Snake snake =(Snake)fSnake;

            HorizontalLine h1 = new HorizontalLine(0, 5, 6, '&');

            List<Figure> figures = new List<Figure>();
            figures.Add(snake);
            figures.Add(v1);
            figures.Add(h1);

            foreach (var f in figures)
            {
                f.Draw();
            }

            static void Draw (Figure figure)
            { 
                figure.Draw();
            }
        }
    }
}