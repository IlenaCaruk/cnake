using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cnake
{
    class Snake : Figure
    {
        //здесь хранятся данные в каком направление ей двигаться
        Direction direction;
        public Snake(Point tail, int length, Direction _direction)
        {
            direction = _direction;//заполнение змейки
            pList = new List<Point>();
            for (int i = 0; i < length; i++)
            {
                
                Point p = new Point(tail);
                p.Move(i, direction);
                pList.Add( p );

            }

        }

        internal void Move()
        {
            Point tail = pList.First();//вызываем метод ферст в списке(возвращает первый элемент)
            pList.Remove(tail);//удаляет хвост когда змейка ползет вперед
            Point head = GetNextPoint();//где окажется голова змеи, метод который возвращает какие то данные
            pList.Add(head);//добавляем эту точку в список
            tail.Clear();//метод затерает точку которая была хвостом
            head.Draw();//голова змейки выводится на экран
        }
        public Point GetNextPoint()//отдай мне след точку, результатом будет какой то объект класса поинт
        {
            Point head = pList.Last();//текущая позиция головы змейки
            Point nextPoint = new Point(head);//следующая точка создана точная копия положения головы
            nextPoint.Move(1, direction);//теперь сдвигает это точку по направлению дирекшен
            return nextPoint;
        }
        public void HandleKey(ConsoleKey key)
        {
            if (key == ConsoleKey.LeftArrow)
                direction = Direction.LEFT;
            else if (key == ConsoleKey.RightArrow)
                direction = Direction.RIGHT;
            else if (key == ConsoleKey.DownArrow)
                direction = Direction.DOWN;
            else if (key == ConsoleKey.UpArrow)
                direction = Direction.UP;
        }

        internal bool Eat(Point food)
        {
            Point head = GetNextPoint();//где находится змейка в данный момент
            if (head.IsHit(food))//если голова змейки оказывается где еда
            {
                //в этом случае она ест
                food.sym = head.sym;
                pList.Add(food);//удлинение еды
                return true;
            }
            else//в другом случае не ест
                return false;
        }
    }       
}
