using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorExample
{
    class Driver: HumanDecorator
    {
        public Driver(Human decoratedHuman)
            : base(decoratedHuman)
        {
        }

        public override void Show()
        {
            base.Show();
            Console.WriteLine("I'm a driver");
        }

    }
}
