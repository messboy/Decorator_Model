using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator_Mode
{
    class Person
    {
        public string name { get; set; }
    
        public Person()
        {

        }

        public Person(string name)
        {
            this.name = name;
        }

        public virtual void Show()
        {
            Console.WriteLine("裝扮 : {0}", name);
        }
    }
}
