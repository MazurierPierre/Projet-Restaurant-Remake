using Model.Kitchen.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Kitchen.Wash.Machines
{
    public abstract class WashMachine : IWashMachine
    {

        public int washTime { get; set; }
        public int maxCapacity { get; set; }
        public Boolean isRunning { get; set; }

        //Will be implemented later
        public virtual void threadStart()
        {
            throw new NotImplementedException();
        }

        public virtual void wash()
        {
            throw new NotImplementedException();
        }
    }
}
