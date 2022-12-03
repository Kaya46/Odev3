using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
struct üniversite
{
    public string fakulte;
    public string bolum;
    public string Ogr_gor;
    public üniversite(string a,string b,string c)
    {
        fakulte = a;
        bolum = b;
        Ogr_gor = c;    
    }
}

namespace _6HaftaOrnekYapılar_Structs_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            üniversite k1 = new üniversite("Teknoloji Fakültesi","Yazılım Mühendisliği","2.sınıf");
            üniversite k2;
            Console.WriteLine(k1.fakulte);
            Console.WriteLine(k1.bolum);
            Console.WriteLine(k1.Ogr_gor);
            k2.fakulte = "Tıp Fakültesi";
            Console.WriteLine();
            Console.WriteLine(k2.fakulte);
            Console.Read();

        }
    }
}
