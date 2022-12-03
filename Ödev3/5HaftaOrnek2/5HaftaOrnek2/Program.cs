using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5HaftaOrnek2
{
    class Ogrenci
    {
        public ulong OgrenciNo;
        public string Ad;
        public string soyad;
        public string bolum;
        public byte Sinif;
    }
    internal class Program
    {
       
        static void Main(string[] args)
        {
            Ogrenci ogr = new Ogrenci();
            Console.WriteLine(ogr.OgrenciNo);
            Console.WriteLine(ogr.Ad);
            Console.WriteLine(ogr.soyad);
            Console.WriteLine(ogr.bolum);
            Console.WriteLine(ogr.Sinif);
            Console.Read();

        }
    }
}
