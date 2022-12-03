using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace _9HaftaOrnek3_3._1
{   class Kedi
    {
        protected int ayaksayisi = 4;
        public void yakalAv()
        {
            Console.WriteLine("Kedi sinifi av yakaladı");
        }
       
    }
    class Kaplan : Kedi
    {
        public Kaplan()
        {
            Console.WriteLine("Ayak Sayisi=" + ayaksayisi);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Kedi kd= new Kedi();
            kd.yakalAv();
            Kaplan kp = new Kaplan();
            kp.yakalAv();
            Console.Read();
        }
    }
}
