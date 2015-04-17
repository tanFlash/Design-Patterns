using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorExample
{
    class Program
    {
        static void Main(string[] args)
        {
            var decoratorOne = new Driver(new Human());
            decoratorOne.Show();
            var decoratorTwo = new Programmer (new Human());
            decoratorTwo.Show();

        }
    }
}
