using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
enum notu : byte { basarisiz,basarili}

namespace _6HaftaOrnekNumaralandırılmalar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            notu a = notu.basarili;
            if (a == (notu)1)
                Console.Write("Başarılısınız");
            else
                Console.Write("Başarısızsınız");

            Console.Read();


        }
    }
}
