using System.Collections.Generic;
using Controller.Interfaces;
using Controller.Room;
using Model.Kitchen.Cooking;
using Model.Room;
using Model.Room.Element;

namespace Controller.Common
{
    public class AssignTable : IAct // Give the client a table number
    {
        // TODO : Need to use Thread and the locks
        public void act(Client client, Table table) // Assign a client to a table
        {
            PlaceClient placeClient = new PlaceClient();
            client.setTableNumber(table.tableNumber); // Give the table's number to the client
            table.state = "occupied";

            if (table.isReserved == true) // Remove reservation if assigned
            {
                table.isReserved = false;
            }
            placeClient.act(client, table); // Place the client to the table
        }

        // Useless
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
