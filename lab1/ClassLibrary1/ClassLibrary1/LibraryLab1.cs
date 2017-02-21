using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ClassLibrary1
{
    public class Line
    {
        public double k, b;
        public Line (double k,double b)
        {
            this.k = k;
            this.b = b;
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

    public class Operations
    {
        //Метод на на проверку точки пересечения прмямых
        public static point Cross(Line first, Line second)
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

    public class ConsoleData
    {
        //Ввод одного действительного числа
        public static double GetData()
        {
            double a = 0;
            try
            {
                a = double.Parse(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("Ошибка! Данные могут быть только числа!");
                Console.WriteLine("Введите занаво !");
                a = double.Parse(Console.ReadLine());
            }
            return a;
        }
    }
}
    