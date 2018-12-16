using System;
using System.Collections.Generic;
using Controller.Room;
using Model.Kitchen.Cooking;
using Model.Room;

namespace Controller.Common
{
    public class OrderAction : Interfaces.IAct
    {
        // TODO : Need to take car of the thread, the lock access
        // TODO : Need to correct the attributes access

        public Client client { get; set; }

        Random rnd = new Random();

        List<Menu> orderList { get; set; }

        public void act(Card card)         // This method gives the list of dish to HeadWaiter
        {
            int sizeOfMenuDish = card.menus.Count - 1; // Get the length of the menu list

            for (int i = 0; i < client.number; i++)
            { // For all client on the table
                int rndNumber = rnd.Next(0, sizeOfMenuDish); // generate a random number
                Menu menuToOrder = card.menus[rndNumber]; // With this number, choose a random menu on the card
                orderList.Add(menuToOrder); // Add the menu to the order list
            }

            TakeOrder takeOrder = new TakeOrder();
            takeOrder.act(client, orderList);
        }
    }
}
