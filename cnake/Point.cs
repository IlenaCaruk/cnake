using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cnake
{
    class Point 
    {
        public int x;
        public int y;
        public char sym;
        public Point()
        {
        }

        public Point(int _x, int _y, char _sym)
        {
            x = _x;
            y = _y;
            sym = _sym;
        }
        public Point(Point p)
        {
            x = p.x;
            y = p.y;
            sym = p.sym;
        }
        public void Move(int offset, Direction direction)
        {
            if(direction == Direction.RIGHT)
            {
                x = x + offset;//координату х увеличить на размер смещения 
            }
            else if (direction == Direction.LEFT)
            {
                x = x - offset;
            }
            else if (direction == Direction.UP)
            {
                y = y + offset;//координату х увеличить на размер смещения 
            }
            else if (direction == Direction.DOWN)
            {
                y = y - offset;
            }

        }
        public bool IsHit(Point p)//проверка на равенство координат. есть ли пересечение с едой
        {
            return p.x == this.x && p.y == this.y;
        }
        

        public void Draw()
        {
            Console.SetCursorPosition(x, y);
            Console.Write(sym);
        }
        //метод для хвостовой точки
       public void Clear()
        {
            sym = ' ';//символ у нее становится пустой
            Draw();//отрисовка точки
        }
        public override string ToString()
        {
            return x + "," + y + "," + sym;
        }
    }
}
