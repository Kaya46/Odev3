using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6HaftaOrnek1
{       class Zaman
    {
        public int Saat;
        public int Dakika;
        public int Saniye;
        public Zaman(int saat,int dakika,int saniye)
        {
            Dakika = dakika + saniye / 60;
            Saniye = saniye % 60;
            Saat = saat + Dakika / 60;
            Dakika = Dakika % 60;
        }
        public static Zaman operator+(Zaman a,Zaman b)
        {
            int ToplamSaniye = a.Saniye + b.Saniye;
            int ToplamDakika = a.Dakika + b.Dakika;
            int ToplamSaat = a.Saat + b.Saat;
            return new Zaman(ToplamSaat, ToplamDakika, ToplamSaniye);
        }

        public static Zaman operator +(Zaman a, int b) //operatörlerin Aşırı Yüklenmesi ile ilgili örnek 3
        {
            int ToplamSaniye = a.Saniye + b;
            return new Zaman(a.Saat, a.Dakika, ToplamSaniye);
        }
        public static string operator + (Zaman a,Zaman b)  //operatörlerin Aşırı Yüklenmesi ile ilgili örnek 4
        {
            int ToplamSaniye = a.Saniye + b.Saniye;
            int ToplamDakika = a.Dakika + b.Dakika;
            int ToplamSaat = a.Saat + b.Saat;
            Zaman nesne = new Zaman(ToplamSaat, ToplamDakika, ToplamSaniye);
            return nesne.Saat + "." + nesne.Dakika + "." + nesne.Saniye;
        }

        public static bool operator == (Zaman a, Zaman b) //operatörlerin Aşırı Yüklenmesi ile ilgili örnek 5
        {
            if (a.Saniye == b.Saniye && a.Dakika == b.Dakika && a.Saat == b.Saat)
                return true;
            else
                return false;

        }
        public static bool operator != (Zaman a,Zaman b)
        {
            return !(a == b);
                
                }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Zaman zaman1 = new Zaman(5, 59, 60);
            Zaman zaman2 = new Zaman(1,0,120);
            Zaman zaman3 = zaman1 + zaman2;
            Console.WriteLine("{0}.{1}.{2}",zaman3.Saat,zaman3.Dakika,zaman3.Saniye);
            Console.Read();
        }
       
    }
}
