﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cnake
{
    class HorizontalLine : Figure
    {

        //по левой точки x, правой точки x,
        public HorizontalLine(int xLeft, int xReight, int y, char sym)
        {
            //создали точки
            pList = new List<Point>();
            for (int x = xLeft; x <= xReight; x++)
            {
                Point p = new Point(x, y, sym);
                //добавление в список точек
                pList.Add(p);

            }
        }

              /*public override void Draw()//альтернативная реализация метода дров
              {
                Console.ForegroundColor = ConsoleColor.Yellow;//желтый цвет
                foreach(Point p in pList)
                {
                p.Draw();
                }
                

                //base.Draw();//базовая реализация метода дров

                Console.ForegroundColor = ConsoleColor.White;//затем меняем на белый
              }

        /*Point p1 = new Point(4, 4, '*');
        Point p2 = new Point(5, 4, '*');
        Point p3 = new Point(6, 4, '*');
        //добавляем эти точки в список
        pList.Add(p1);
        pList.Add(p2);
        pList.Add(p3);*/
    }
        
    
}
