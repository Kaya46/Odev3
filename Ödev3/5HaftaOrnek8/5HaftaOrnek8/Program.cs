using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5HaftaOrnek8
{
    internal class Dortgen
    {
        public  int en = 30;
        public  int Boy = 23;

        public  int Alan()
        {
            int Alan = en * Boy;
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
            Dortgen dr=new Dortgen(); //nesne türettik.
            Console.WriteLine("En:{0,5}", dr.en);
            Console.WriteLine("En:{0,5}", dr.Boy);
            Console.WriteLine("En:{0,5}", dr.Alan());
            Console.Read();
        }
    }
}
