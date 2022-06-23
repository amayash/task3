using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Array_first a1 = new Array_first(10);
            Array_second a2 = new Array_second(4, 4);
            Console.WriteLine(a1.Print());
            Console.WriteLine(a1.nom1());
            Console.WriteLine(a2.Print());
            Console.WriteLine(a2.nom2());
            Console.WriteLine(a2.nom3(a2.stroka()));
            Console.ReadLine();
        }
    }
}
