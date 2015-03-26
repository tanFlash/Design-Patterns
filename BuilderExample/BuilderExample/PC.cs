using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderExample
{
    public class PC
    {
        public string Procesor { get; set; }
        public string Memory { get; set; }
        public string HDD { get; set; }
        public int MemoryModules { get; set; }
        public override string ToString()
        {
            string text = "Your Pc: " + Procesor + " " + Memory + " Memory modules:" + MemoryModules + " " + HDD;
            return text;
        }
    }
}
