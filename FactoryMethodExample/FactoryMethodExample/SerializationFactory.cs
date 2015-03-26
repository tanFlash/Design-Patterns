using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodExample
{
    class SerializationFactory
    {
        public static ISerializer GetSerialization(int digit)
        {
            switch (digit)
            {
                case 1:
                    return new JsonSerializer();
                   
                case 2:
                    return new XmlSerializor();
                    
                default:
                    return new JsonSerializer();
            }
        }
    }
}
