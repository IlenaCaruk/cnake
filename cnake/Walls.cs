using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cnake
{
    class Walls//стена и припятствие
    {
        List<Figure> wallList;//фигура это базовый класс

        public Walls(int mapWidth, int mapHeight)//габариты карты
        {
            wallList = new List<Figure>();

            // Отрисовка рамочки. припятствия для змейки наследники фигуры
            HorizontalLine upLine = new HorizontalLine(0, mapWidth - 2, 0, '+');
            HorizontalLine downLine = new HorizontalLine(0, mapWidth - 2, mapHeight - 1, '+');
            VerticalLine leftLine = new VerticalLine(0, mapHeight - 1, 0, '+');
            VerticalLine rightLine = new VerticalLine(0, mapHeight - 1, mapWidth - 2, '+');
            //добавляем их в список
            wallList.Add(upLine);
            wallList.Add(downLine);
            wallList.Add(leftLine);
            wallList.Add(rightLine);
        }

        internal bool IsHit(Figure figure)//передаем в качестве агумента змейку и любую фигуру и возвращаем тип бул правду или ложь
        {
            foreach (var wall in wallList)//здесь хранятся 4 препятствия
            {
                if (wall.IsHit(figure))
                {
                    return true;
                }
            }
            return false;
        }
        //пробежка по всем фигурам
        public void Draw()
        {
            foreach (var wall in wallList)
            {
                wall.Draw();
            }
        }
    }
}
