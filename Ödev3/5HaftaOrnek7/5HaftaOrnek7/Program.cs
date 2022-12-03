using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5HaftaOrnek7
{   
    internal class Program
    {
        class Dortgen
        {
            public static int En = 20;
            public static int Boy = 5;
            public static int Alan()
            {
                 int Alan = En * Boy;
                  return Alan;
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("******");
            Console.WriteLine("En:{0,5}",Dortgen.En);
            Console.WriteLine("Boy:{0,5}",Dortgen.Boy);
            Console.WriteLine("Alan:{0,5}",Dortgen.Alan());
        }
    }
}
