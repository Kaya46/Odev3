using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4HaftaOrnek5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] isimler = { "ali", "ahmet", "selda", "canan", "melike" };
            Console.WriteLine("aranan isim=");

            string aranan = Console.ReadLine();

            bool status = false;

            foreach(string ss in isimler)
            {
                if (aranan.Equals(ss))
                    status = true;
            }

            if(status)
                Console.WriteLine("aranan isim bulundu...");
            else
                Console.WriteLine("isim bulunamadı");

            Console.ReadLine();
        }
    }
}
