using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace FactoryMethodExample
{
    class JsonSerializer: ISerializer
    {

        public string SerializeMyObject(object obj)
        {
            string json = JsonConvert.SerializeObject(obj);
            return json;
        }
    }
}
