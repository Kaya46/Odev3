using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
abstract class Ogr_not
{
    public int vize;
    public int final;
    public Ogr_not(int v, int f)
    {
        vize = v;
        final = f;
    }   
}
class ögr : Ogr_not
{
    public string str;
    public ögr(string ad,int vize,int final):base(vize,final)
    {
        str = ad;
    }
    public void ad_göster()
    {
        Console.WriteLine("Öğrenci Adı:"+str);
        Console.WriteLine("Vize Not:"+vize+"\n"+"Final Notu:"+final);
    }
}
namespace _9HaftaÖzet_Abstract_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ögr d = new ögr("Safa KAYA", 77, 94);
            d.ad_göster();
            Console.Read();
        }
    }
}
