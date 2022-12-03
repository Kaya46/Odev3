using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5HaftaOrnek12
{
    internal class Program
    {   class Topla
        {
            public int tpl;
            public Topla(int toplam)
            {
                tpl = toplam;
            }
            public int Toplama
            {
                get { return tpl; } 
                set { tpl = value+tpl; }
            }
        }
        static void Main(string[] args)
        {
            Topla ekle = new Topla(0);
            Console.WriteLine("Başlangıçta değeri->"+ekle.Toplama);
            for (int i = 0; i < 100; i++)
                ekle.Toplama = i;
            Console.WriteLine("Sayıların toplamı: "+ekle.Toplama);
            Console.Read();
        }
    }
}
