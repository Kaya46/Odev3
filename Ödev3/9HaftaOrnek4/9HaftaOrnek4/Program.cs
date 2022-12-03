using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9HaftaOrnek4
{   public class Hayvan
    {
        protected String a = "Hayvan.a";
        String b = "Hayvan.b";
        private String c = "Hayvan.c";
        public String d = "Hayvan.d";

    }
    public class Kedi : Hayvan
    {
        public Kedi()
        {
            Console.WriteLine("Kedi oluşturuluyor");
            Console.WriteLine(a);
            Console.WriteLine(d);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Kedi k = new Kedi();
            Console.Read();
        }
    }
}
