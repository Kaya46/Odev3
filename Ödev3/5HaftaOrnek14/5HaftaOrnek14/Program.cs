using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5HaftaOrnek14
{
    internal class Program
    {   
        public int Zar()
        
        {
            Random rnd = new Random();
            return rnd.Next(1, 7);      
        }
        public static void metotlar(int a,int b,int c)
        {
            Console.WriteLine("a= "+a+"\nb= "+b+"\nc= "+c);

        }
        static void Main(string[] args)
        {
            Random rnd = new Random();
            Program a=new Program();
            metotlar(rnd.Next(1, 7), rnd.Next(1, 7), rnd.Next(1, 7));
            //Program a = new Program();
            //metotlar(a.Zar(), a.Zar(), a.Zar());
            Console.ReadLine();
        }
    }
}
