using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4HaftaOrnek11
{
    internal class Program
    {
        //static void metot1(float x,float y)
        //{
        //    Console.WriteLine("1.metot çağırıldı..");
        //}
        //static void metot1(int x, int y)
        //{
        //    Console.WriteLine("2.metot çağırıldı");
        //}
        static void metot1(int x,int y,int z)
        {
            Console.WriteLine("1.metot çağırıldı..");
        }
        static void metot1(int x, int y)
        {
            Console.WriteLine("2.metot çağırıldı..");
        }
        static void metot1(float x, float y)
        {
            Console.WriteLine("3.metot çağırıldı..");
        }
        static void Main(string[] args)
        {
            //metot1('f', 'g');
            //Console.Read();
            metot1(3,3,6);
            metot1(3.4f, 3);
            metot1(1, 'h');
            Console.Read();
        }

    }
}
