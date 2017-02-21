using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ClassLibrary1
{
    public class Line
    {
        public int k, b;
        public Line (int k,int b)
        {
            this.k = k;
            this.b = b;
        }

        //Инициализация прямой
        public static Line Init()
        {
            int a, b;
            Console.WriteLine("Уравнение прямой типа y=kx+b");
            Console.WriteLine("Введи коофицетны k, b");
            try
            {
                a = int.Parse(Console.ReadLine());
                b = int.Parse(Console.ReadLine());
            }
            catch(Exception)
            {
                Console.WriteLine("Ошибка! Данные могут быть только целые числа!");
                Console.WriteLine("Введите занаво k,b");
                a = int.Parse(Console.ReadLine());
                b = int.Parse(Console.ReadLine());

            }
            var l = new Line(a, b);
            return l;
        }
        //Метод поиска точки пересечения
        public static point Check(Line first,Line second)
        {
            double y, x;
            if (first.k != second.k)
            {
                x = (double)(second.b - first.b) / (first.k - second.k);
                y = first.k * x + first.b;
                var a = new point(x, y);
                return a;
            }
            else
            {
                Console.WriteLine("Прямые параллельны,нет точек пересечения");
                return null;
            }
        }
    }

    public class point
    {
        double x, y;
        public point ()
        { }
        public point(double x, double y)
        {
            this.x = x;
            this.y = y;
        }
        public static void print(point c)
        {
            if (c != null)
                Console.WriteLine(" Координаты точки пересечения {0}  {1}", c.x, c.y);
            else
            {

            }   
                Console.WriteLine("Координат точки пересечения нет!");
        }
    }
}
    