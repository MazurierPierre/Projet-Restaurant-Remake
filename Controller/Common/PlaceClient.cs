using System.Collections.Generic;
using Controller.Interfaces;
using Controller.Room;
using Model.Kitchen.Cooking;
using Model.Room;
using Model.Room.Element;

namespace Controller.Common
{
    public class PlaceClient : IAct
    {
        //public delegate void Del(Table table, EnumRoom.BreadType type);

        // TODO : Need to use thread, locks 
        public void act(Client client, Table table)
        {
            ClientOnTable.clientAndTable.Add(table, client); // Add the client in the list of client present in the room
            ClientQueue.clientList.Remove(client); // Remove the client of the queue
            client.tableNumber = table.tableNumber;

            /*
            BringBread bringBread = new BringBread();
            Del foo = new Del(bringBread.act);
            Thread bread = new Thread(() => foo(table, EnumRoom.BreadType.White));
            */
        }

        public void act()
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

        public void act(Client client)
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
