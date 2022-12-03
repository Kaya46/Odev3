using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5HaftaOrnek6
{
    class Dortgen
    {
       
    }
    internal class Program
    {
        public static int En = 20;
        public static int Boy = 5;
        public static
            
            int Alan()
        {
            int Alan = En * Boy;
            return Alan;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("En:{0,5}",En);
            Console.WriteLine("Boy:{0,5}",Boy);
            Console.WriteLine("Alan:{0,5}",Alan());
            Console.Read();
        }
    }
}
