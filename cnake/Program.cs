using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace cnake
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetBufferSize(80, 25);

            Walls walls = new Walls(80, 25);
            walls.Draw();

            Point p = new Point(4, 5, '*');//создается точка 
            Snake snake = new Snake(p, 4, Direction.RIGHT);//змейка. змея тоже фигура поэтому вначеде фигура
            snake.Draw();
            FoodCreator foodCreator = new FoodCreator(80, 25, '$');
            Point food = foodCreator.CreateFood();
            food.Draw();

            while (true)
            {
                if (walls.IsHit(snake) || snake.IsHitTail())//проверка столкнется ли змейка со стеной или с хвостом
                {
                    break;
                }
                if (snake.Eat(food))
                {
                    food = foodCreator.CreateFood();
                    food.Draw();
                }
                else
                {
                    snake.Move();
                }

                Thread.Sleep(100);
                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey();
                    snake.HandleKey(key.Key);
                }



                //Snake snake = (Snake)fSnake;//явное приведение типа. сделано для того чтоб потом можно было применять на змейку ее свойства

                /*HorizontalLine hl = new HorizontalLine(0, 5, 6, '&');
                //создали список фигур
                List<Figure> figures = new List<Figure>();
                figures.Add(fSnake);
                figures.Add(vl);
                figures.Add(hl);

                foreach (var f in figures)//для всех объуктов можно вызвать метод дров
                {
                    f.Draw();
                }
                }

                static void Draw(Figure figure)//метод который в качестве аргумента принимает любую фигуру
                {
                    figure.Draw();//вызовает для фигуры метод дров
                }





                //Point p1 = new Point(1, 3, '*');
                /*p1.x = 1;
                p1.y = 3;
                p1.sym = '*';*/
                //p1.Draw();
                //Point p2 = new Point(4, 5, '#');
                /*p2.y = 4;
                p2.x = 5;
                p2.sym = '#';*/
                // p2.Draw();
                //Console.SetBufferSize(80, 25);

                //отрисовка рамочки
                /*HorizontalLine upLine = new HorizontalLine(0, 78, 0, '+');//в аргументе задаем парамент точки
                HorizontalLine downLine = new HorizontalLine(0, 78, 24, '+');
                VerticalLine leftLine = new VerticalLine(0, 24, 0,'+');
                VerticalLine reghtLine = new VerticalLine(0, 24, 78, '+');
                upLine.Drow();
                downLine.Drow();
                leftLine.Drow();
                reghtLine.Drow();

                //отрисовка точки
                Point p = new Point(4, 5, '*');
                Snake snake = new Snake(p, 4, Direction.RIGHT);
                snake.Drow();

                //создан класс ответственен за генерацию точек с едой
                FoodCreator foodCreator = new FoodCreator(80, 25, '$');//передается габариты экрана и символ еды
                Point food = foodCreator.CreateFood();//это метод который будет создавать еду в произвольных местах на карте
                food.Draw();

                while (true)
                {
                    if (snake.Eat(food))
                    {
                        food = foodCreator.CreateFood();//метод который говорит будет змея есть или нет(ложь, правда)
                        food.Draw();
                    }
                    else
                    {
                        snake.Move();
                    }

                    Thread.Sleep(100);//задержка

                    if (Console.KeyAvailable)
                    {
                        ConsoleKeyInfo key = Console.ReadKey();//считывание с консолий нажатий
                        snake.HandleKey(key.Key);
                    }
                }

                /*int x1 = 1;
                int y1 = 3;
                char sym1 = '*';
                Draw(x1, y1, sym1);*/
                /*int x2 = 4;
                int y2 = 5;
                char sym2 = '#';
                Draw(x2, y2, sym2);*/

                //как работает класс стандарстной бибилиотеки List
                /*List<int> numList = new List<int>();
                numList.Add(0);
                numList.Add(1);
                numList.Add(2);

                int x = numList[0];
                int y = numList[1];
                int z = numList[2];
                foreach(int i in numList)
                {
                    Console.WriteLine(i);
                }

                numList.RemoveAt(0);

                List<Point> pList = new List<Point>();
                pList.Add(p1);
                pList.Add(p2);*/



                //Console.ReadKey();
            }
            //скрывает подробности реализации
            /*static void Draw(int x, int y, char sym)//принимает в качестве аргумента входные параметры
            {
                Console.SetCursorPosition(x, y);
                Console.Write(sym);

            }*/
        }
    }
}
