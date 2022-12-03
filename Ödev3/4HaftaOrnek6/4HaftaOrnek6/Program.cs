using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4HaftaOrnek6
{
    internal class Program
    {
        static int Buyukbul(int a, int b)
        {
            if (a > b)
                return a;
                return b;
        }
        static void Main(string[] args)
        {
            int s1, s2;
            Console.Write("1.sayıyı girin:");
            s1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("2.Sayıyı girin:");
            s2 = Convert.ToInt32(Console.ReadLine());
            int enbuyuk = Buyukbul(s1, s2);
            Console.WriteLine("En büyük: {0}\'dir", enbuyuk);
            Console.ReadKey();
        }
    }
}
