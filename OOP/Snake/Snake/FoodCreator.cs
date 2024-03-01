using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    internal class FoodCreator : Figure
    {
        int mapWight;
        int mapHight;
        char foodSymbol;

        Random random = new Random();
        
        public FoodCreator(int mapWight, int mapHight, char foodSymbol)
        {
            this.mapWight = mapWight;
            this.mapHight = mapHight;
            this.foodSymbol = foodSymbol;
        }

        public Point CreateFood()
        {
            int x = random.Next(2, mapWight - 2);
            int y = random.Next(2, mapHight - 2);
            return new Point(x, y, foodSymbol);
        }
    }
}
