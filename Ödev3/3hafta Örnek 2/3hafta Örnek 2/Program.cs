using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3hafta_Örnek_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 2;
            int b = 3;
            int c = 6;
            Console.WriteLine("(a&b)-->" + (a & b));
            Console.WriteLine("(a|b)-->" + (a | b));
            Console.WriteLine("(a^b)-->"+(a^b));
            Console.WriteLine("~a-->"+(~a));
            Console.WriteLine("~b-->" + (~b));
            Console.WriteLine("~c-->" + (~c));

        }
    }
}
