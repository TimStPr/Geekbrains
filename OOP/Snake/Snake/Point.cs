using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Point
    {
        public int positionX;
        public int positionY;
        public char symbol;

        public Point()
        {
        }

        public Point(int positionX, int positionY, char symbol)
        {
            this.positionX = positionX;
            this.positionY = positionY;
            this.symbol = symbol;
        }

        public Point(Point p)
        {
            positionX =p.positionX;
            positionY =p.positionY;
            symbol = p.symbol;
        }

        public void Move(int offset, Direction direction) 
        {
            if(direction == Direction.RIGTH) 
            {
                positionX = positionX + offset;
            }
            else if(direction == Direction.LEFT)
            {
                positionX = positionX - offset;
            }
            else if(direction == Direction.UP) 
            {
                positionY = positionY + offset;
            }
            else 
            { 
                positionY = positionY - offset;
            }
        }

        public void DrawSymbol()
        {
            Console.SetCursorPosition(positionX, positionY);
            Console.Write(symbol);
        }

        public void Clear()
        { 
            symbol = ' ';
            DrawSymbol();
        }
    }
}
