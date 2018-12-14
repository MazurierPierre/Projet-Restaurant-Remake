using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller.Room
{
    public class RoomActorList
    {
        List<Client> clientList { get; set; }
        List<RoomClerk> clerkList { get; set; }
        List<Butler> butlerList { get; set; }
        List<Waiter> waiterList { get; set; }
        List<HeadWaiter> headWaiterList { get; set; }

        public void init()
        {

        }
    }
}
