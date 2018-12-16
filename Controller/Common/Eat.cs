using System.Collections.Generic;
using Controller.Interfaces;
using Controller.Room;
using Model.Kitchen.Cooking;
using Model.Room;
using Model.Room.Element;

namespace Controller.Common
{
    public class Eat : IAct
    {
        // Because we don't have time to finish the clock i can't manage the speed increase
        public void act(Client client) // Allow the client to eat and so spend a specific time
        {
            if (client.behavior == "Relaxed")
            {
                System.Threading.Thread.Sleep(30000); // Wait 30 seconds 


            }
            else if (client.behavior == "StressedOut")
            {
                System.Threading.Thread.Sleep(200000);// Wait 200 seconds 

            }
        }

        // Useless
        public void act()
        {
            throw new System.NotImplementedException();
        }

        public void act(Client client, Table table)
        {
            throw new System.NotImplementedException();
        }

        public void act(Table table, EnumRoom.BreadType type)
        {
            throw new System.NotImplementedException();
        }

        public void act(Table table, EnumRoom.JugType type)
        {
            throw new System.NotImplementedException();
        }

        public void act(Table table)
        {
            throw new System.NotImplementedException();
        }

        public void act(Table table, Waiter waiter)
        {
            throw new System.NotImplementedException();
        }

        public void act(Card card)
        {
            throw new System.NotImplementedException();
        }

        public void act(Client client, List<Menu> orderList)
        {
            throw new System.NotImplementedException();
        }
    }
}
