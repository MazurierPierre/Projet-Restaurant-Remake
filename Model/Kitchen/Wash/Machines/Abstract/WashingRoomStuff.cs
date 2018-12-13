using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Kitchen.Wash.Machines
{

    public abstract class WashingRoomTools : WashMachine
    {
        public List<Object> itemToWashList { get; set; }
        protected WashingRoomTools(int washTime, int maxCapacity) //Implemented later
        {

        }
       
    }
}
 

            
            