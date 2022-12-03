using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//class A
//{
//    public void Metot1()
//    {
//        Metot2();
//    }
//    public void Metot2()
//    {
//        Console.WriteLine("A sınıf");
//    }
//}
//class B : A
//{
//    public new void Metot2()
//    {
//        Console.WriteLine("B Sınıfı");
//    }
//}

class A
{
    public void Metot1()
    {
        Metot2();
    }
    public void Metot2()
    {
        Console.WriteLine("A sınıfı");
    }
}
class B : A
{
    public new void Metot1()
    {
        Metot2();
    }
    public new void Metot2()
    {
        Console.WriteLine("B sınıfı");
    }
}
namespace _9HaftaÖrnekler1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //    B b=new B();
            //    b.Metot1();
            B b = new B();
            b.Metot1();
         Console.Read();

        }
    }
}
