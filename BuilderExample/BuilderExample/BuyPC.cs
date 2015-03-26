using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderExample
{
    class BuyPC
    {
        private PCBuilder _pcbuilder;
        public void SetPcBuilder(PCBuilder pcbuilder)
        {
            _pcbuilder = pcbuilder;
        }
        public PC GetPc()
        {
            return _pcbuilder.GetPC();
        }
        public void ConstructPC()
        {
            _pcbuilder.CreateNewPC();
            _pcbuilder.SetProcessor();
            _pcbuilder.SetMemory();
            _pcbuilder.SetMemoryModules();
            _pcbuilder.SetHDD();
                
        }
    }
}
