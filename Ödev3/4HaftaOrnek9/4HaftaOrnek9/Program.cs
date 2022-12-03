using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4HaftaOrnek9
{
    internal class Program
    {
        static void değer(int sayi)
        {
            sayi = 30;
        }
        static void Main(string[] args)
        {
            int x = 100;
            Console.WriteLine(x);
            değer(x);
            Console.WriteLine(x);

            Console.ReadKey();

        }
    }
}
