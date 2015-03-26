using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderExample
{
    abstract class PCBuilder
    {
        protected PC Pc { get; private set; }
        public void CreateNewPC()
        {
            Pc = new PC();
        }
        public PC GetPC()
        {
            return Pc;
        }
        public abstract void SetProcessor();
        public abstract void SetMemory();
        public abstract void SetMemoryModules();
        public abstract void SetHDD();
    }
}
