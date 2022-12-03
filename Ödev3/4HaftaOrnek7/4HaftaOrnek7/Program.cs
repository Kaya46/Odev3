using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4HaftaOrnek7
{
    internal class Program
    {
        static int BuyukBul(int a,int b)
        {
            if(a>b)
                return a;
                return b;
        }
        static int BuyukBul3(int a,int b, int c)
        {
            return BuyukBul(a, BuyukBul(b, c));
        }
        static void Main(string[] args)
        {
            int s1, s2, s3;
            Console.Write("1.sayıyı girin:");
            s1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("2.sayıyı girin:");
            s2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("3sayıyı girin:");
            s3 = Convert.ToInt32(Console.ReadLine());
            int enbuyuk = BuyukBul3(s1, s2, s3);
            Console.Write("En büyük: {0}", enbuyuk);
            Console.ReadLine();
        }
    }
}
