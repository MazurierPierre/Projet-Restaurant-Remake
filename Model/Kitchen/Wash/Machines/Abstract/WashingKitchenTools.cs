using Model.Kitchen.Cooking.Ingredients;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Kitchen.Wash.Machines
{
    public abstract class WashingKitchenTools : WashMachine
    {
        public List<KitchenTool> itemToWashList { get; set; }
        protected WashingKitchenTools(int washTime, int maxCapacity)
        {

        }
       
    }
}
