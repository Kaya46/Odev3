using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6HaftaOrnek8
{      class Sinif
    {
        public int Sayi;
        public Sinif(int sayi)
        {
            Sayi=sayi;
        }
        public static implicit operator int(Sinif a)
        {
            return a.Sayi;
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Sinif a = new Sinif(50);
            int b = a;
            Console.WriteLine(b);
            Console.Read();
        }
    }
}
