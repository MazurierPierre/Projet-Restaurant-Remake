using System.Collections.Generic;
using Controller.Interfaces;
using Controller.Room;
using Model.Kitchen.Cooking;
using Model.Room;
using Model.Room.Element;

namespace Controller.Common
{
    public class BringJug : IAct
    {
        // TODO : Need to take care of the DateBase and of the thread lock
        private InitRoomModel initRoomModel;
        public void act(Table table, EnumRoom.JugType type = EnumRoom.JugType.Tap) // Bring Water
        {
            Jug jug = initRoomModel.jugList[0]; // Fetch a Jug
            table.jugList.Add(jug); // Add the Jug to the table
            initRoomModel.jugList.RemoveAt(0); //Remove the Jug from stock
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
