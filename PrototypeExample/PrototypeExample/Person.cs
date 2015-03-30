using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace PrototypeExample
{
    public class Person:PersonPrototype
    {
        public Bitmap Head { get; set; }
        public Bitmap Body { get; set; }
        public Bitmap Feet { get; set; }
        //here the method is overridden, so now it makes a deep copy of the object
        public override PersonPrototype DeepClone ()
        {
            var copy  = (Person)this.Clone();
            copy.Head = (Bitmap)Head.Clone();
            copy.Body = (Bitmap)Body.Clone();
            copy.Feet = (Bitmap)Feet.Clone();
            return copy;

        }
       

        //object ICloneable.Clone()
        //{
        //    throw new NotImplementedException();
        //}
    }
}
