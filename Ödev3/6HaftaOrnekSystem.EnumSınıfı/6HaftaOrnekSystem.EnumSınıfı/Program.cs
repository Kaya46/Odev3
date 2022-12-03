using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
enum Gunler : byte
{
    PAZARTESİ, SALI, ÇARŞAMBA, PERŞEMBE, CUMA, CUMARTESİ, PAZAR
}

namespace _6HaftaOrnekNumaralandırmalar1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] sabitler = Enum.GetNames(typeof(Gunler));
            foreach (string s in sabitler)
                Console.WriteLine(s);
            Console.Read();
        }
    }
}
