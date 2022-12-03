using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace isimalanı1
{ class Deneme
    {
        public Deneme()
        {
            Console.WriteLine("Deneme 1");
        }
    }
}
namespace isimalanı2
{
    class Deneme
    {
        public Deneme()
        {
            Console.WriteLine("Deneme 2");
        }
    }
}
internal class Program
    {
        static void Main(string[] args)
        {
        isimalanı1.Deneme d1 = new isimalanı1.Deneme();
        isimalanı2.Deneme d2 = new isimalanı2.Deneme();
        Console.Read();
        }
    }

