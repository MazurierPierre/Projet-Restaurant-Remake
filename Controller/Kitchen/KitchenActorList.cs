using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller.Kitchen
{
    class KitchenActorList
    {
        public List<MainChef> mainChefList { get; set; }
        public List<Cook> cookList { get; set; }
        public List<KitchenClerk> kitchenClerkList { get; set; }
        public List<Dishwasher> dishwasherList { get; set; }

        public void init()
        {

        }
    }
}
