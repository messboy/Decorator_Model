using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator_Mode
{
    class Finery : Person
    {
        protected Person component;

        //打扮
        public void Decorate(Person component)
        {
            this.component = component;
        }

        public override void Show()
        {
            if (component != null)
            {
                component.Show();
            }
            
        }
    }
}
