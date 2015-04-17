using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorExample
{
    class HumanDecorator: Human
    {
        protected Human DecoratedHuman { get; set; }
        public HumanDecorator(Human decoratedHuman)
        {
            DecoratedHuman = decoratedHuman;
        }
        public override void Show()
        {
            DecoratedHuman.Show();
        }
    }
}
