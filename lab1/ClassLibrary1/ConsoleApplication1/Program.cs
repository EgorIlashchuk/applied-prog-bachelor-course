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
                var first = Line.Init();
                var second = Line.Init();
                var c = Line.Check(first, second);
                point.print(c);       
                Console.WriteLine("Задать параметры занаво? (Y/N)");
                answer = Console.ReadLine();
            }
            while ((answer == "y")||(answer=="Y"));   
        }
    }
}
    