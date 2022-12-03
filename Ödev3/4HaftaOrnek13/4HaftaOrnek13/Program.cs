using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4HaftaOrnek13
{
    internal class Program
    { static void Yaz(object o)
        {
            Console.WriteLine("1.metot çağırıldı..");
        }
        static void Yaz(params object[] o)
        {
            if (o.Length == 0) return;
            Console.Write("2.metot: ");
            foreach (object n in o)
                Console.Write(n.ToString() + "");
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            Yaz(25);
            Yaz("deneme1", " ","deneme2");
            Yaz('a');
            Yaz('z', 1, 23f, 4, 56, "abc");
            Console.ReadKey();
        }
    }
}
