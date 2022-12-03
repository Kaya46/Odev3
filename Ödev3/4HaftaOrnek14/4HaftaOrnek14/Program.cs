using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4HaftaOrnek14
{
    internal class Program
    {
        static int Faktoriyel(int a)
        {
            if (a == 0)
                return 1;
            return a * Faktoriyel(a - 1);
        }
        static void Main(string[] args)
        {
            Console.Write("Faktoriyeli alınacak sayı=");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Girmiş olduğunu sayının faktoriyeli:"+Faktoriyel(x));
            Console.Read();
        }
    }
}
