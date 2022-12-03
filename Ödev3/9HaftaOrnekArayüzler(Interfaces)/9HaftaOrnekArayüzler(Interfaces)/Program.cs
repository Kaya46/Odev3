using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


interface IArayuz
{
    int Metot1();
    void Metot2();
    int sayi
    {
        get;
        set;
    
    }
    int this[int indeks]
    {
        get;
    }
}
class sinif : IArayuz
{

    private int sayi;
    public int Metot1()
    {
        return 0;
    }
    public void Metot2()
    {

    }
    public int Sayi
    {
        get { return sayi; }
        set { sayi = value; }
    }
    public int this[int indeks]
    {
        get { return indeks; }
        set { }
    }
}
namespace _9HaftaOrnekArayüzler_Interfaces_
{
  
    internal class Program
    {
        static void Main(string[] args)
        {
            sinif s = new sinif();
            Console.Read();
        }
    }
}
