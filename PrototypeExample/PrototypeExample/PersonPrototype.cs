using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypeExample
{
    public class PersonPrototype
    {
        //so we have one simple clone method which will perform the function of shallow copy
        public virtual PersonPrototype Clone()
        {
            var copyOfPrototype = (PersonPrototype)this.MemberwiseClone();
            return copyOfPrototype;
        }
        //and we have a deepclone method, which will be overriden in the class Person
        public virtual PersonPrototype DeepClone()
        {
            var copyOfPrototype = (PersonPrototype)this.MemberwiseClone();
            return copyOfPrototype;
        }
    }
}
