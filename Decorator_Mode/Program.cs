using Decorator_Mode.ConcreteDecorator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator_Mode
{
    class Program
    {
        static void Main(string[] args)
        {
            Person xc = new Person("小育");

            Console.WriteLine("\n第一種裝扮");
            BigTrouser kk = new BigTrouser();
            Tshirts dtx = new Tshirts();

            kk.Decorate(xc);
            dtx.Decorate(kk);
            dtx.Show();

            ////////////////////////////////////////////////////////


            Console.WriteLine("\n第二種裝扮");
            BigTrouser kkk = new BigTrouser();
            Tshirts dtxk = new Tshirts();

            kkk.Decorate(xc);
            dtxk.Decorate(kk);
            dtxk.Show();

        }
    }
}
