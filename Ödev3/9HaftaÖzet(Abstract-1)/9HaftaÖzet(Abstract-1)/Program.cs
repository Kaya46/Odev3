using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
abstract class A
{
    public int x;
    abstract public int y
    {
        set;
        get;
    }
    public A() {
        this.x = x;
    }
    abstract public void Metot();

     
}
class S : A
{
    int z;
    public S(int x):base(x)
    {
        this.x = x; 
    }
    public override int y
    {
        get
        {
            return z;
        }
        set
        {
            z = value;
        }
    }
    public override void Metot()
    {
        Console.WriteLine(x);
        Console.WriteLine(y);

    }
}
namespace _9HaftaÖzet_Abstract_1_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            S s = new S(5);
            s.y = 2 * s.x;
            s.Metot();
        }
    }
}
