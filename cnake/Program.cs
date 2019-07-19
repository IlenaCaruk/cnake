using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cnake
{
    class Program
    {
        static void Main(string[] args)
        {
            int x1 = 1;
            int y1 = 3;
            char sym1 = '*';
            Draw(x1, y1, sym1);
            int x2 = 4;
            int y2 = 5;
            char sym2 = '#';
            Draw(x2, y2, sym2);


            Console.ReadKey();
        }
        //скрывает подробности реализации
        static void Draw(int x, int y, char sym)//принимает в качестве аргумента входные параметры
        {
            Console.SetCursorPosition(x, y);
            Console.Write(sym);

        }
    }
}
