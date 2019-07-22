using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cnake
{
    class Figure
    {
        //содержание списка точек
        protected List<Point> pList;
        //метод для отрисовки точек
        public void Draw()
        {
            foreach (Point p in pList)
            {
                p.Draw();
            }
        }
        internal bool IsHit(Figure figure)
        {
            foreach (var p in pList)//делается проверка на пересечения точек
            {
                if (figure.IsHit(p))//когда говорим о точке
                    return true;
            }
            return false;
        }

        private bool IsHit(Point point)//вызывается вот этот метод
        {
            foreach (var p in pList)
            {
                if (p.IsHit(point))
                    return true;
            }
            return false;
        }

    }
}
