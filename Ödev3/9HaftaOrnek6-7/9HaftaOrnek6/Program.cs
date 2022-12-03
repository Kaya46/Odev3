using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace _9HaftaOrnek6
{ class oto
    {
        protected double motorgucu = 5;
        protected double tork = 800;
        protected string renk = "Sarı";
         public oto(double guc,double tork,string renk)
        {
            this.motorgucu = guc;
            this.tork = tork;
            this.renk = renk;
        }
        public void ozellikgoster()
        {
            Console.WriteLine("Motor Gucu="+motorgucu);
            Console.WriteLine("Tork="+tork);
            Console.WriteLine("Renk="+renk);
        }
        public double MotorGucu
        {
            get { return motorgucu; }
            set { motorgucu = value; }
        }
        public double Tork
        {
            get { return tork; }
            set { tork = value; }
        }
        public string Renk
        {
            get
            {
                return renk;
            }
            set
            {
                renk = value;
            }
        }
    }
    class model1 : oto
    {
        public string Tur;
        public model1(string tur,double guc,double tork,string renk):base(guc,tork,renk)
        {
            this.Tur = tur;
        }
        public void TurGoster()
        {
            Console.WriteLine("Türü"+Tur);
        }
    }
    class model2 : oto
    {
        public string Tur;
        public model2(string tur,double guc,double tork,string renk):base(guc,tork,renk)
        {
            this.Tur = tur;
        }
        public void TurGoster()
        {
            Console.WriteLine("Türü"+Tur);
        }
    }
    internal class Program
    { public static void Goster(oto Oto)
        {
            Console.WriteLine(Oto.MotorGucu);
            Console.WriteLine(Oto.Tork);
            Console.WriteLine(Oto.Renk);
        }
        static void Main(string[] args)
        {
            oto oto1 = new oto(75,100,"Kırmızı");
            Goster(oto1);
            Console.WriteLine("-------");
            model1 oto2 = new model1("Fiat",100,110,"Beyaz");
            Goster(oto2);
            Console.WriteLine("---------");
            model2 oto3 = new model2("Renault", 100, 120, "Siyah");
            Goster(oto3);
            Console.Read();


        }
    }
}
