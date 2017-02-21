using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;


namespace ConsoleApplication1
{
    class Program
    {
        static void Main()
        {
            string answer;
            do
            {
                Console.WriteLine("Уравнение прямой типа y=kx+b");
                Console.WriteLine("Введите коофиценты k,b по очереди");
                var first = new Line(ConsoleData.GetData(), ConsoleData.GetData());
                Console.WriteLine("Введите коофиценты k,b по очереди");
                var second = new Line(ConsoleData.GetData(), ConsoleData.GetData());
                var c = Operations.Cross(first, second);
                point.print(c);       
                Console.WriteLine("Задать параметры заново? (Y/N)");
                answer = Console.ReadLine();
            }
            while ((answer == "y")||(answer=="Y"));   
        }
    }
}
    