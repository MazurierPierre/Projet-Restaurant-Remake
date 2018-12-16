using System.Collections.Generic;

namespace Controller.Room
{
    public class RoomActorList
    {
        List<Client> clientList { get; set; }
        List<ClerkRoom> clerkList { get; set; }
        List<Butler> butlerList { get; set; }
        List<Waiter> waiterList { get; set; }
        List<HeadWaiter> headWaiterList { get; set; }

        public void init()
        {

        }
    }
}
