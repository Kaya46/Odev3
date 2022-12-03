using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5HaftaOrnek9
{
    class Dortgen
    {
        public static int En = 30;
        public static int Boy = 23;
        public static int Alan()
        {
            int Alan = En * Boy;
            return Alan;
        }
        static void Main()
        {
            yaz d1 = new yaz();
            d1.Yaz();

        }
    }
    class yaz
    {
        public void Yaz()
        {
            Console.WriteLine("En:{0,5}", Dortgen.En);
            Console.WriteLine("En:{0,5}", Dortgen.Boy);
            Console.WriteLine("En:{0,5}", Dortgen.Alan());
        }
    }
}
   
