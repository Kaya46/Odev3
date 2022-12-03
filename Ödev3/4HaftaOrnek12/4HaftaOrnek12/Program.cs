using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4HaftaOrnek12
{
    internal class Program
    {
         static int ıslem(string a, params int [] sayilar)
        {
            if (a == "carp")
            {
                if (sayilar.Length == 0) return 1;
                int carpim = 1;
                foreach (int i in sayilar) carpim *= i;
                return carpim;

            }
            else if (a == "topla")
            {
                if (sayilar.Length == 0) return 0;
                int toplam = 0;
                foreach (int i in sayilar) toplam += i;
                return toplam;
            }
            else
                return 0;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(ıslem("topla", 3, 4, 7, 8));
            Console.WriteLine(ıslem("carp", 5, 23, 6));
            Console.Read();
        }
    }
}
