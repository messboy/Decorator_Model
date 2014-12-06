using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator_Mode.ConcreteDecorator
{
    class Tshirts : Finery
    {
        public override void Show()
        {
            Console.Write("大t-shirt ");
            base.Show();
        }
    }
}
