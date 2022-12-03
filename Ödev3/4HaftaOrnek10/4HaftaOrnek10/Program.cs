using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4HaftaOrnek10
{
    internal class Program
    {
        static void Metot1(float x,float y)
        {
            Console.WriteLine("Metot1 çağırıldı..");
        }
        static void Metot1(double x, double y)
        {
            Console.WriteLine("Metot2 çağırıldı..");
        }

        static void Main(string[] args)
        {
            Metot1(5, 6);
            Console.Read();
        }
    }
}
