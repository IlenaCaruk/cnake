using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cnake
{
    //здесь хранятся объект класса
    class FoodCreator
    {
        int mapWidht;
        int mapHeight;
        char sym;

        Random random = new Random();

        public FoodCreator(int mapWidth, int mapHeight, char sym)//конструкторе габариты карты ширину, длину и сиимвол
        {
            this.mapWidht = mapWidth;
            this.mapHeight = mapHeight;
            this.sym = sym;
        }
        //здесь генерируется результат в приделах карты
        public Point CreateFood()
        {
            //создает новую еду
            int x = random.Next(2, mapWidht - 2);
            int y = random.Next(2, mapHeight - 2);
            //создается точка с этими координатами
            return new Point(x, y, sym);
        }
    }
}
