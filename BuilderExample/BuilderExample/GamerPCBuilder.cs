using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderExample
{
    class GamerPCBuilder: PCBuilder
    {

        public override void SetProcessor()
        {
            Pc.Procesor = "Core 2 Duo, 3.2 GHz";
        }

        public override void SetMemory()
        {
            Pc.Memory = "6144 Mb";
        }

        public override void SetMemoryModules()
        {
            Pc.MemoryModules = 2;
        }

        public override void SetHDD()
        {
            Pc.HDD = "500 Gb";
        }
    }
}
